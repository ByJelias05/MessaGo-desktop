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
using Google.Cloud.Firestore;
using Google.Type;

namespace MessaGo_Desktop.Components_Users
{
    public partial class Acept : UserControl
    {
        FirestoreDb db;
        public Acept()
        {
            InitializeComponent();

            var path = AppDomain.CurrentDomain.BaseDirectory + @"/messago-714d2-firebase-adminsdk-a4zc7-a4623d5545.json";

            if (File.Exists(path))
            {
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREADENTIALS", path);
                db = FirestoreDb.Create("messago-714d2");
            }
            else
            {
                MessageBox.Show("Error server");
            }
        }

        public string Img
        {
            get
            {
                return PtbFoto.ImageLocation;
            }
            set
            {
                PtbFoto.ImageLocation = value;
            }
        }

        public string Nombre
        {
            get
            {
                return LblNombre.Text;
            }
            set
            {
                LblNombre.Text = value;
            }
        }

        public string IdDoc
        {
            get
            {
                return BtnRechazar.Tag.ToString();
            }
            set
            {
                BtnRechazar.Tag = value;
            }
        }


        public string IdDocAceptar
        {
            get
            {
                return BtnAceptar.Tag.ToString();
            }
            set
            {
                BtnAceptar.Tag = value;
            }
        }

        private async Task NegarSolicitud(string ID)
        {
            CollectionReference collection = db.Collection("Usuarios").Document(Estados.MyPerfil.DocID)
                .Collection("Solicitudes");

            DocumentReference document = collection.Document(ID);

            await document.DeleteAsync();

            MessageBox.Show("Soli eliminada");
        }

        private async Task<Collections.Solicitud> ObtenerSolicitante(string ID)
        {
            CollectionReference collection = db.Collection("Usuarios");
                DocumentReference document = collection.Document(Estados.MyPerfil.DocID);

            CollectionReference collection1 = document.Collection("Solicitudes");
                DocumentReference document1 = collection1.Document(ID);

            DocumentSnapshot docc = await document1.GetSnapshotAsync();


            Collections.Solicitud solicitudUser = new Collections.Solicitud();

            if (docc.Exists)
            {
                solicitudUser = docc.ConvertTo<Collections.Solicitud>();
            }

            return solicitudUser;
        }

        private async Task AcpetarSolicitud(Collections.Conversacion conversacion)
        {
            CollectionReference collection = db.Collection("Conersaciones");

            DocumentReference document = collection.Document();

            await document.CreateAsync(conversacion);

            MessageBox.Show("Solicitud aceptada");
        }

        private async void BtnRechazar_Click(object sender, EventArgs e)
        {
            await NegarSolicitud(BtnRechazar.Tag.ToString());
            //this.Dispose();
            //this.Hide();
            Controls.Clear();
        }

        private async void BtnAceptar_Click(object sender, EventArgs e)
        {
             var data = await ObtenerSolicitante(BtnAceptar.Tag.ToString());

            Collections.Conversacion conversacion = new Collections.Conversacion()
            {
                MyUserId = Estados.MyPerfil.UserId,
                MyPhotoUrl = Estados.MyPerfil.PhotoUrl,
                MyLastTime = System.DateTime.Now.DayOfWeek.ToString() + System.DateTime.Now.Day.ToString(),
                MyStatuUser = "Online",

                YouUserId = data.UserId,
                YouPhotoUrl = data.PhotoUrl,
                //YouLastTime = "",
                //YouStatuUser = ""
            };

            await AcpetarSolicitud(conversacion);
        }
    }
}
