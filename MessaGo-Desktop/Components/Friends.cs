using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessaGo_Desktop.Components
{
    public partial class Friends : UserControl
    {
        public Friends()
        {
            InitializeComponent();
        }

        public string IdDoc
        {
            get
            {
                return b1.Tag.ToString();
            }
            set
            {
                b1.Tag = value;
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

        private void b1_Click(object sender, EventArgs e)
        {
            Estados.EstadoMensaje.OtherUser = true;
            timer1.Start();

            Estados.YouPerfil.UserId = LblNombre.Text;
            Estados.EstadoMensaje.IdDocConversacion = b1.Tag.ToString();

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Estados.EstadoMensaje.OtherUser = false;
            timer1.Stop();
        }
    }
}
