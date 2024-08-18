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
                TransitionBtns.HideSync(b1);
                TransitionBtns.HideSync(b2);
                TransitionBtns.HideSync(b3);
                TransitionBtns.HideSync(b4);
              

                TransitionPanel.ShowSync(PanelMiPerfil);

            }
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            TransitionPanel.HideSync(PanelMiPerfil);

            TransitionBtns.ShowSync(b4);
            TransitionBtns.ShowSync(b3);
            TransitionBtns.ShowSync(b2);
            TransitionBtns.ShowSync(b1);

            TransitionBtns.ShowSync(BtnGroups);
            TransitionBtns.ShowSync(BtnNoRead);
            TransitionBtns.ShowSync(BtnAll);
           
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
    }
}
