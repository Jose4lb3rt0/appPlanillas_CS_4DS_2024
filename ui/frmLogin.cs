using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPlanilla_CS_4DS_2024.ui
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.AliceBlue;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btn_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Black;
        }

        private void btn_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(94, 17, 90);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDni.Text = txtDni.Text = string.Empty;
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"¿Deseas salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes);
                Application.Exit();
        }
    }
}
