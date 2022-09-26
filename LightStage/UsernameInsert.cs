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
        public UsernameInsert()
        {
            InitializeComponent();
        }
        public class User
        {
            public static string username { get; set; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Username inválido! Insira novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    User.username = txtUsername.Text;
                    Form1 form1 = new Form1();
                    Hide();
                    form1.ShowDialog();
                    Close();
                }
            }
            catch(Exception ex)
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
