using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LightStage
{
    public partial class UsernameInsert : Form
    {
        public static UsernameInsert instance;
        public TextBox tb;
        public UsernameInsert()
        {
            InitializeComponent();
            instance = this;
            tb = txtUsername;
        }
        public class User
        {
            public static string username { get; set; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string UserAdmin = "EWERTON.CANDIDO";
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Nome de usuário inválido! Por favor, insira novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    User.username = txtUsername.Text;
                    if (string.Compare(txtUsername.Text.Trim().ToUpper(), UserAdmin) == 0)
                    {
                        Form1 form1 = new Form1();
                        MessageBox.Show("Bem vindo ADMIN", "Olá", MessageBoxButtons.OK);
                        Hide();
                        form1.ShowDialog();
                        Close();
                    }
                    else
                    {
                        Form1 form1 = new Form1();
                        Hide();
                        form1.ShowDialog();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}