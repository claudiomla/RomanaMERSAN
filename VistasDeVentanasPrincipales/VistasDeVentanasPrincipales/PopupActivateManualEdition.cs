﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasDeVentanasPrincipales
{
    public partial class PopupActivateManualEdition : Form
    {
        public PopupActivateManualEdition()
        {
            InitializeComponent();
        }


        // El Boton cancelar cerrara la ventana
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DisplaydataEweighIN.checke = false;
            Close();
            
           
        }
    }
}
