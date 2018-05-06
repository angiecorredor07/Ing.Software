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
    public partial class Aprendizaje : Form
    {
        public Aprendizaje()
        {
            InitializeComponent();
        }

        private void lbl_cerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio pan = new Inicio();
            pan.Show();
            this.Hide();
        }

        private void lbl_definicion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Definicion def = new Definicion();
            def.Show();
            this.Hide();
        }

        private void lbl_binarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Binarios bin = new Binarios();
            bin.Show();
            this.Hide();
        }

        private void lbl_ternarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ternarios tern = new Ternarios();
            tern.Show();
            this.Hide();
        }

        private void lbl_libres_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Libres lib = new Libres();
            lib.Show();
            this.Hide();
        }

        private void lbl_raiz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Raiz ra = new Raiz();
            ra.Show();
            this.Hide();
        }

        private void lbl_pre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pre pre = new Pre();
            pre.Show();
            this.Hide();
        }

        private void lbl_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InOrden inO = new InOrden();
            inO.Show();
            this.Hide();
        }

        private void lbl_post_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Post post = new Post();
            post.Show();
            this.Close();
        }
    }
}
