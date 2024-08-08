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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void guna2Button1_Click(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
