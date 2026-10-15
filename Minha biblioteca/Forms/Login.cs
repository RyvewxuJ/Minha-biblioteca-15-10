using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Minha_biblioteca.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public async void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                f1.ShowAsync();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer login: "
                    + ex.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
