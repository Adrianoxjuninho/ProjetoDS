using ProjetoDS.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDS.view
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email, senha;

            email = txtemail.Text;
            senha = txtsenha.Text;

            ClienteDAO dAO = new ClienteDAO();
            dAO.EfetuaLogin(email, senha);

            this.Visible = false;
            new FrmMenu().ShowDialog();
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
