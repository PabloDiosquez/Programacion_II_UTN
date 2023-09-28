﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mensaje_Click(object sender, EventArgs e)
        {
            string usuario = this.tbx_usuario.Text;

            MessageBox.Show($"Hola {usuario}! Este es un mensaje envíado a través del espacio-tiempo 🚀");
        }
    }
}
