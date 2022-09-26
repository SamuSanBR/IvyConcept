using System.Drawing;
using System.Windows.Forms;

namespace LightStage
{
    public partial class Form2 : Form
    {
        public Form2(string caminhoImagem)
        {
            InitializeComponent();
            Image img;
            img = Image.FromFile(caminhoImagem);
            picImagem.Image = img;
        }
    }
}
