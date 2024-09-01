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
using Firebase.Storage;
using System.IO;
using System.Data.SqlClient;

namespace MessaGo_Desktop
{
    public partial class Form1 : Form
    {
        FirestoreDb db;
        public Form1()
        {
            InitializeComponent();

            var path = AppDomain.CurrentDomain.BaseDirectory + @"\messago-714d2-firebase-adminsdk-a4zc7-a4623d5545.json";

            if(File.Exists(path))
            {
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path );
                db = FirestoreDb.Create("messago-714d2");
                MessageBox.Show("La app inicializo bien");
            }
            else
            {
                MessageBox.Show("Error de conexion");
            }

        }

        private async Task CrearUsuario(Collections.Users Usuario)
        {
            CollectionReference collection = db.Collection("Usuarios");

            DocumentReference doc = await collection.AddAsync(Usuario);

            MessageBox.Show("Usuario creado con exito");
        }

        private async Task<List<Collections.Users>> IniciarSesion(string Email)
        {
            CollectionReference collection = db.Collection("Usuarios");

            var query = collection.WhereEqualTo("Email", Email);

            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            List<Collections.Users> Usuario = new List<Collections.Users>();

            foreach(DocumentSnapshot doc in snapshot)
            {
                Collections.Users user = doc.ConvertTo<Collections.Users>();
                user.ID = doc.Id;
                Usuario.Add(user);
            }

            return Usuario;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(PanelHelp.Visible == false)
            {
                PanelHelp.Visible = true;
            }
            else
            {
                PanelHelp.Visible = false;
            }
        }

        private void BtnSwitchLogin_Click(object sender, EventArgs e)
        {
            if(PanelSesion.Visible == true)
            {
                BtnSwitchLogin.Text = "LOGIN";

                PanelSesion.Visible = false;
                PanelCreateUser.Visible = true;

            }
            else
            {
                BtnSwitchLogin.Text = "CREATE ACCOUNT";

                PanelCreateUser.Visible = false;
                PanelSesion.Visible = true;

            }
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            PanelHelp.Visible = false;

        }

        private async void BtnCreateUSer_Click(object sender, EventArgs e)
        {
            if (TxtNewEmail.Text.Contains("@messago.com"))
            {
                Collections.Users Usuario = new Collections.Users()
                {
                    CompleteName = TxtCompleteName.Text,
                    UserID = TxtUserId.Text,
                    Email = TxtNewEmail.Text,
                    PassWord = TxtNewPass.Text,
                    PhotoUrl = null,
                    StatuUSer = "Offline",
                    LastTime = null,
                };

                await CrearUsuario(Usuario);
            }
            else
            {
                MessageBox.Show("Ese correo no es valido: debe ser example@messago.com");
            }
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            var USuarios = await IniciarSesion(TxtEmail.Text);

            if(USuarios.Count < 1)
            {
                MessageBox.Show("Usuario no encontrado");
            }

            foreach (var us in USuarios)
            {
               if(us.PassWord == TxtPassword.Text)
               {
                    AppChat app = new AppChat();
                    app.UserId.Text = us.UserID.ToString();
                    Estados.MyPerfil.DocID = us.ID;
                    Estados.MyPerfil.Nombre = us.CompleteName;
                    Estados.MyPerfil.UserId = us.UserID;
                    Estados.MyPerfil.PhotoUrl = us.PhotoUrl;
                    app.Show();
                    this.Hide();
               }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
        }

        private void TxtNewEmail_TextChanged(object sender, EventArgs e)
        {
            if (!TxtNewEmail.Text.Contains("@messago.com"))
            {
                TxtNewEmail.Text = "@messago.com";
            }
        }
    }
}
