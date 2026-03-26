using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] Usuarios = new String[10];
        Int32 INDICE = 0;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (INDICE < 10)
            {
                Usuarios[INDICE] = txtUsuarios.Text;
                INDICE++;
                MessageBox.Show("El dato se cargó correctamente");
                txtUsuarios.Text = "";
            }
            else 
            {
                MessageBox.Show("No se pueden cargar más datos");
            }
        }
    }
}
