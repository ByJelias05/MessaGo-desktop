using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessaGo_Desktop.Modals.CreateGroup
{
    public partial class Modal : Form
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void Modal_Load(object sender, EventArgs e)
        {
          
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
