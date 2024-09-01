using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Storage;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace MessaGo_Desktop.Modals.AddFriend
{
    public partial class ModalAddFriend : UserControl
    {
        FirestoreDb db;
        public ModalAddFriend()
        {
            InitializeComponent();

            var Path = AppDomain.CurrentDomain.BaseDirectory + @"/messago-714d2-firebase-adminsdk-a4zc7-a4623d5545.json";

            if (File.Exists(Path))
            {
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Path);
                db = FirestoreDb.Create("messago-714d2");

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private async Task<Collections.Users> ObtenerUSuario(string Nombre)
        {
            CollectionReference collection = db.Collection("Usuarios");

            var query = collection.WhereEqualTo("UserID", Nombre);

            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            Collections.Users user = new Collections.Users();

            foreach(DocumentSnapshot doc in snapshot)
            {
               Collections.Users userFOund = doc.ConvertTo<Collections.Users>();
               userFOund.ID = doc.Id;
               user = userFOund;

            }

            return user;
        }

        private async Task EnviarSolicitud(Collections.Users user)
        {
            CollectionReference collection = db.Collection("Usuarios");
            CollectionReference collectionSolicitud = collection.Document(user.ID).Collection("Solicitudes");

            Collections.Solicitud solicitud = new Collections.Solicitud();
            solicitud.Nombre = Estados.MyPerfil.Nombre;
            solicitud.UserId = Estados.MyPerfil.UserId;
            solicitud.PhotoUrl = Estados.MyPerfil.PhotoUrl;

            await collectionSolicitud.AddAsync(solicitud);

            MessageBox.Show("Solicitud enviada");
        }

        private async Task<List<Collections.Solicitud>> ObtenerSolicitudes()
        {
            CollectionReference collection = db.Collection("Usuarios").Document(Estados.MyPerfil.DocID)
                 .Collection("Solicitudes");

            QuerySnapshot snapshots = await collection.GetSnapshotAsync();

            List<Collections.Solicitud> solicitudes = new List<Collections.Solicitud>();

            foreach(DocumentSnapshot doc in snapshots)
            {
                Collections.Solicitud solicitud = doc.ConvertTo<Collections.Solicitud>();
                solicitud.DOcID = doc.Id;
                solicitudes.Add(solicitud);
            }

            return solicitudes; 
        } 

        private async void ModalAddFriend_Load(object sender, EventArgs e)
        {
            var Data = await ObtenerSolicitudes();

            foreach(var items in Data)
            {
                string[] Nombre = items.Nombre.Split(' ');
                var component = new Components_Users.Acept();
                component.Nombre = Nombre[0] + " " + Nombre[1];
                component.IdDoc = items.DOcID;
                component.IdDocAceptar = items.DOcID;
                //component.Img = items.PhotoUrl.ToString();
                ContenedorSolicitudes.Controls.Add(component);
            }

            
        }

        public new Collections.Users usuario;

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
             usuario = await ObtenerUSuario(TxtUserId.Text);

            if(usuario.CompleteName != "")
            {
                PtbImage.ImageLocation = usuario.PhotoUrl;
                LblNameUser.Text = usuario.CompleteName;

                if (LblNameUser.Text == null)
                {
                    LblNameUser.Text = "USER NO FOUND";
                }
            }
        }

        private async void BtnSendRequest_Click(object sender, EventArgs e)
        {

            await EnviarSolicitud(usuario);

        }
    }
}
