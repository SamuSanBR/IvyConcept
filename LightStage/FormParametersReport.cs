using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Emgu;
using Emgu.CV;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using static LightStage.UsernameInsert;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;

namespace LightStage
{
    public partial class FormParametersReport : Form
    {
        public static FormParametersReport instance;
        public FormParametersReport()
        {

            InitializeComponent();
            instance = this;

            if ((UsernameInsert.instance.tb.Text).Trim().ToUpper() == ConfigurationManager.AppSettings["Admin"])
            {
                btnDownload.Enabled = true;
            }

        }

        FolderBrowserDialog fbd1 = new FolderBrowserDialog();
        String filePath = ConfigurationManager.AppSettings["SavePath"];

        //public Type Details(int? vesselId)
        //{
        //    //
        //    // Enumerate through the images directory and
        //    //return the results to the view.
        //    var filePath = "C:\\Users\\samuel.cassan\\Desktop\\LightStage\\LightStage\\bin\\x64\\Debug\\Pictures";
        //    var fileName = Path.GetFileNameWithoutExtension(filePath);

        //    var model = new VesselImagesViewModel
        //    {
        //        VesselImages = Directory.EnumerateFiles(filePath)
        //        .Select(fn => "~/Content/images/vessels/" + Path.GetFileName(fn))
        //        .Where(id => Path.GetFileNameWithoutExtension(id) == vesselId.ToString())
        //    };

        //    return model;
        //}

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            try
            {


                //Define as propriedades do controle FolderBrowserDialog
                //    fbd1.Description = "Selecione uma pasta exibir as imagens";
                //    fbd1.RootFolder = Environment.SpecialFolder.Desktop;
                //    fbd1.ShowNewFolderButton = true;

                ////Exibe a caixa de diálogo
                //if (fbd1.ShowDialog() == DialogResult.OK)
                //{
                //Exibe a pasta selecionada
                fbd1.SelectedPath = filePath;
                //}
                ExibeArquivosDaPastaSelecionada(fbd1.SelectedPath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExibeArquivosDaPastaSelecionada(string pasta)
        {
            String pastaOrigem = pasta;
            var filtros = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "avi" };
            var arquivos = GetArquivosDaPasta(pastaOrigem, filtros, false, txtSerial.Text);
            //Cria um DataTable com os dados dos arquivos
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Nome do Arquivo");
            for (int i = 0; i < arquivos.Length; i++)
            {
                FileInfo arquivo = new FileInfo(arquivos[i]);
                tabela.Rows.Add(arquivo.Name);
            }
            //exibe os dados no datagridview
            dgvDados.DataSource = tabela;
            configuraDataGridView();
        }

        public static String[] GetArquivosDaPasta(String pastaRaiz, String[] filtros, bool isRecursiva, string sPesquisa)
        {
            List<String> arquivosEncontrados = new List<String>();
            //define as opções para exibir as imagens da pasta raiz
            var opcaoDeBusca = isRecursiva ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filtro in filtros)
            {
                arquivosEncontrados.AddRange(Directory.GetFiles(pastaRaiz, sPesquisa + String.Format("*.{0}", filtro), opcaoDeBusca));

            }
            return arquivosEncontrados.ToArray();
        }

        private void configuraDataGridView()
        {
            //define o nome, tamanho , inclui colunas e linha no gridview
            dgvDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDados.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvDados.GridColor = Color.Black;
            dgvDados.RowHeadersVisible = false;
            //define 3 colunas : codigo, nome e nascimento
            dgvDados.Columns[0].Name = "Nome do Arquivo";
            //dgvDados.Columns[0].Width = 200;
            dgvDados.Columns[0].ReadOnly = true;
            dgvDados.Columns[0].DefaultCellStyle.Font = new Font(this.dgvDados.DefaultCellStyle.Font, FontStyle.Bold);
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.MultiSelect = false;
        }
        private void dgvDados_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string nomeImagem = dgvDados.CurrentRow.Cells[0].Value.ToString();
                string caminhoImagem = fbd1.SelectedPath + "\\" + nomeImagem;
                txtDiretorio.Text = caminhoImagem;
                Form2 frmImagem = new Form2(caminhoImagem);
                frmImagem.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir a imagem selecionada", ex.Message);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.ShowDialog();

        }

        private void FormParametersReport_Load(object sender, EventArgs e)
        {

        }

        private void CopyFiles(string pasta, string PastaDestino)
        {
            String pastaOrigem = pasta;
            var filtros = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "avi" };
            var arquivos = GetArquivosDaPasta(pastaOrigem, filtros, false, txtSerial.Text);
            string NovoNomeArquivo;

            if (arquivos.Length == 0)
            {
                MessageBox.Show("Nenhuma imagem foi pesquisada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                for (int i = 0; i < arquivos.Length; i++)
                {
                    FileInfo arquivo = new FileInfo(arquivos[i]);
                    NovoNomeArquivo = Path.Combine(PastaDestino, arquivo.Name);
                    File.Copy(arquivo.ToString(), NovoNomeArquivo);
                }
                MessageBox.Show("Download concluído");
            }

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            string PastaDestino = "";
            try
            {
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PastaDestino = fbd.SelectedPath;
                    CopyFiles(filePath, PastaDestino);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível fazer o download dos arquivos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
