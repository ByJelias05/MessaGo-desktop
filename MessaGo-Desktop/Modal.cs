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
    public partial class Modal : Form
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void Modal_Load(object sender, EventArgs e)
        {
            string ModalActual = Estados.EstadoModal.ModalActual;

            if (ModalActual != "")
            {
                if (ModalActual == "AddFriend")
                {
                    Modals.AddFriend.Modal modal = new Modals.AddFriend.Modal();
                    modal.Owner = this;
                    modal.Show();
                }
                else if(ModalActual == "CreateGroup")
                {
                    Modals.CreateGroup.Modal modal = new Modals.CreateGroup.Modal();
                    modal.Owner = this;
                    modal.Show();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string ModalActual = Estados.EstadoModal.ModalActual;

            if(ModalActual == "")
            {
                this.Close();
                this.Dispose();
            }

            
            
        }
    }
}
