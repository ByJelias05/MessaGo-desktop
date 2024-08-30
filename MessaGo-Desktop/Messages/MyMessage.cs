using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessaGo_Desktop.Messages
{
    public partial class MyMessage : UserControl
    {
        public MyMessage()
        {
            InitializeComponent();

            ////BoxMensaje.MaximumSize = new System.Drawing.Size(this.Width, 5000);

            ////label1.MaximumSize = new System.Drawing.Size(BoxMensaje.Width - 55, 0);

            //BoxMensaje = new System.Drawing.Size(426, 138);
        }

        public string Message
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyMessage_Load(object sender, EventArgs e)
        {
            //BackColor = Color.Blue;
            //BoxMensaje.Size = new System.Drawing.Size(411, label1.Height + 500);
            //Size = new Size(426, 138);

        }
    }
}
