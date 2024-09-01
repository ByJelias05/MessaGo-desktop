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

namespace MessaGo_Desktop
{
    public partial class AppChat : Form
    {
        public AppChat()
        {
            InitializeComponent();
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
