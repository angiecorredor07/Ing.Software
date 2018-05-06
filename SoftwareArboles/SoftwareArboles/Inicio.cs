using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareArboles
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void link_Cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void picAprendizaje_Click(object sender, EventArgs e)
        {
            Aprendizaje ap = new Aprendizaje();
            ap.Show();
            this.Hide();
        }

        private void picPractica_Click(object sender, EventArgs e)
        {
            Practica p = new Practica();
            p.Show();
            this.Hide();
        }

        private void picEvaluacion_Click(object sender, EventArgs e)
        {
            Evaluacion ev = new Evaluacion();
            ev.Show();
            this.Hide();
        }
    }
}
