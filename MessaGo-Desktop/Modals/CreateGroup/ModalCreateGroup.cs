﻿using System;
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
    public partial class ModalCreateGroup : UserControl
    {
        public ModalCreateGroup()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Estados.EstadoModal.ModalActual = "";
        }
    }
}