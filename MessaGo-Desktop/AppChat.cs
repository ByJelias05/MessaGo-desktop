using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using System.IO;

namespace MessaGo_Desktop
{
    public partial class AppChat : Form
    {
        FirestoreDb db;
        public AppChat()
        {
            InitializeComponent();

            var Path = AppDomain.CurrentDomain.BaseDirectory + @"/messago-714d2-firebase-adminsdk-a4zc7-a4623d5545.json";

            if (File.Exists(Path))
            {
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREADENTIALS", Path);
                db = FirestoreDb.Create("messago-714d2");
            }
            else
            {
                MessageBox.Show("Error del server");
            }
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async Task<List<Collections.Conversacion>> ObtenerAmigos(string Nombre)
        {
            CollectionReference collection = db.Collection("Conersaciones");

            QuerySnapshot snapshots = await collection.GetSnapshotAsync();

            List<Collections.Conversacion> ListConv = new List<Collections.Conversacion>(); 

            if (snapshots != null)
            {
                foreach (DocumentSnapshot doc in snapshots)
                {
                    Collections.Conversacion InfConv = doc.ConvertTo<Collections.Conversacion>();

                    if (InfConv.MyUserId == Nombre)
                    {
                        InfConv.IdDoc = doc.Id;
                        ListConv.Add(InfConv);
                    }
                    else if(InfConv.YouUserId == Nombre)
                    {
                        InfConv.IdDoc = doc.Id;
                        ListConv.Add(InfConv);
                    }
                }

            }

            return ListConv;
        }

        private async Task EnviarMEnsaje(string IdDoc, Collections.Mensajes Mensaje)
        {
            CollectionReference collection = db.Collection("Conersaciones");
            DocumentReference document = collection.Document(IdDoc);

            CollectionReference collectionMsg = document.Collection("Mensajes");

            await collectionMsg.AddAsync(Mensaje);

     
        } 


        private async Task<List<Collections.Mensajes>> ObtenerMensajes(string IdDoc)
        {

            List<Collections.Mensajes> mensajes = new List<Collections.Mensajes>();
            try
            {
                CollectionReference collection = db.Collection("Conersaciones");
                DocumentReference document = collection.Document(IdDoc);

                var query = document.Collection("Mensajes").OrderByDescending("Fecha");

                QuerySnapshot snapshots = await query.GetSnapshotAsync();

               
                //PanelContenedorCentral.Controls.Clear();
                if (snapshots != null)
                {
                    foreach (DocumentSnapshot doc in snapshots)
                    {
                       
                        Collections.Mensajes msg = doc.ConvertTo<Collections.Mensajes>();
                        mensajes.Add(msg);
                        
                    }
                }
            }
            catch (Exception)
            {

            }


            return mensajes;
        }

        private async Task<int> cc(string IdDoc)
        {

            int CantidadDeMensajes = 0;
            try
            {
                CollectionReference collection = db.Collection("Conersaciones");
                DocumentReference document = collection.Document(IdDoc);

                var query = document.Collection("Mensajes").OrderBy("Fecha");

                QuerySnapshot snapshots = await query.GetSnapshotAsync();


                //PanelContenedorCentral.Controls.Clear();
                if (snapshots != null)
                {
                    CantidadDeMensajes = snapshots.Count();
                  
                }
            }
            catch (Exception)
            {

            }



            return CantidadDeMensajes;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if(PanelMiPerfil.Visible == false)
            {
                TransitionBtns.HideSync(BtnAll);
                TransitionBtns.HideSync(BtnNoRead);
                TransitionBtns.HideSync(BtnGroups);
                TransitionBtns.HideSync(BtnAddFriend);
                TransitionBtns.HideSync(BtnCreateGroup);
                TransitionBtns.HideSync(BtnConfig);
                //TransitionBtns.HideSync(b4);
              

                TransitionPanel.ShowSync(PanelMiPerfil);

            }
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            TransitionPanel.HideSync(PanelMiPerfil);

            //TransitionBtns.ShowSync(b4);
            //TransitionBtns.ShowSync(b3);
            //TransitionBtns.ShowSync(b2);
            //TransitionBtns.ShowSync(b1);

            TransitionBtns.ShowSync(BtnGroups);
            TransitionBtns.ShowSync(BtnNoRead);
            TransitionBtns.ShowSync(BtnAll);
            TransitionBtns.ShowSync(BtnAddFriend);
            TransitionBtns.ShowSync(BtnCreateGroup);
            TransitionBtns.ShowSync(BtnConfig);

        }

        public bool EstadoVerYouPerfil;

        private void guna2CirclePictureBox7_Click(object sender, EventArgs e)
        {

            pp.Visible = true;
            
         
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
           
                pp.Visible = false;
            
        }

        private void BtnMinimizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAddFriend_Click(object sender, EventArgs e)
        {
            Form Sombra = new Form();

            using (Modals.AddFriend.Prueba Modal = new Modals.AddFriend.Prueba())
            {

                Sombra.StartPosition = FormStartPosition.CenterScreen;
                Sombra.FormBorderStyle = FormBorderStyle.None;
                Sombra.Size = this.Size;
                Sombra.Opacity = .50;
                Sombra.BackColor = Color.Black;
                Sombra.ShowInTaskbar = false;
                Sombra.Show();
                Modal.Owner = Sombra;
                


                Modal.ShowDialog();
                Sombra.Dispose();
            }
                

        }

        private void BtnCreateGroup_Click(object sender, EventArgs e)
        {
            Form Sombra = new Form();

            using (Modals.CreateGroup.Modal Modal = new Modals.CreateGroup.Modal())
            {

                Sombra.StartPosition = FormStartPosition.CenterScreen;
                Sombra.FormBorderStyle = FormBorderStyle.None;
                Sombra.Size = this.Size;
                Sombra.Opacity = .50;
                Sombra.BackColor = Color.Black;
                Sombra.ShowInTaskbar = false;
                Sombra.Show();
                Modal.Owner = Sombra;



                Modal.ShowDialog();
                Sombra.Dispose();
            }
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
            string miInfo = Estados.MyPerfil.Nombre +  Estados.MyPerfil.UserId + Estados.MyPerfil.PhotoUrl;

            MessageBox.Show(miInfo);
        }

        private async void AppChat_Load(object sender, EventArgs e)
        {
            var Data = await ObtenerAmigos(Estados.MyPerfil.UserId);

            foreach (var item in Data)
            {
           
                if(item.MyUserId == Estados.MyPerfil.UserId)
                {
                    var component = new Components.Friends();
                    PanelContenedorFriends.Controls.Add(component);
                    component.Dock = DockStyle.Top;
                    component.IdDoc = item.IdDoc;
                    component.Nombre = item.YouUserId;
                }
                else if(item.YouUserId == Estados.MyPerfil.UserId)
                {
                    var component = new Components.Friends();
                    PanelContenedorFriends.Controls.Add(component);
                    component.Dock = DockStyle.Top;
                    component.IdDoc = item.IdDoc;
                    component.Nombre = item.MyUserId;
                }
            }
        }

        private async Task<List<Collections.Mensajes>> Data()
        {
            var Data = await ObtenerMensajes(Estados.EstadoMensaje.IdDocConversacion);

            //MessageBox.Show("Test");

            return Data;

        }

        //public int CantidadDeMesnajes = 2;
        private async void timer1_Tick(object sender, EventArgs e)
        {

            var Data = await ObtenerMensajes(Estados.EstadoMensaje.IdDocConversacion);
            //CantidadDeMesnajes = Data.Count;

            if (Data.Count != PanelContenedorCentral.Controls.Count)
            {
                foreach (var items in Data)
                {
                    if(items.Usuario == Estados.MyPerfil.UserId)
                    {
                        var componente = new Messages.MyMessage();
                        PanelContenedorCentral.Controls.Add(componente);
                        componente.Dock = DockStyle.Top;
                        componente.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                        componente.Message = items.Mensaje;
                    }
                    else
                    {
                        var componente = new Messages.YouMessage();
                        PanelContenedorCentral.Controls.Add(componente);
                        componente.Dock = DockStyle.Top;
                        componente.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                        componente.Message = items.Mensaje;
                    }
                }
                timer1.Stop();
            }
          

        }

        private async void BtnEnviar_Click_1(object sender, EventArgs e)
        {
            Timestamp date = Timestamp.GetCurrentTimestamp();

            Collections.Mensajes mensajes = new Collections.Mensajes()
            {
                Usuario = Estados.MyPerfil.UserId,
                Mensaje = TxtMensje.Text,
                StatusMsg = "No Visto",
                TipoMensaje = "Write",
                Fecha = date,
                Foto = null
            };

            await EnviarMEnsaje(Estados.EstadoMensaje.IdDocConversacion, mensajes);

            //Estados.EstadoMensaje.OtherUser = true;
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            LblNombreHablante.Text = Estados.YouPerfil.UserId;

            //Detecta cuando cambio de conversacion
            if(Estados.EstadoMensaje.OtherUser == true)
            {
                PanelContenedorCentral.Controls.Clear();
                timer1.Start();

            }

            //Detecta cuando hay otro mensaje de en tiempo real
            int valor = await cc(Estados.EstadoMensaje.IdDocConversacion);

            if(valor > PanelContenedorCentral.Controls.Count)
            {
                PanelContenedorCentral.Controls.Clear();
                timer1.Start();
            }

        }

        private void PanelContenedorFriends_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Start();
            PanelContenedorCentral.Controls.Clear();
            
        }
    }
}
