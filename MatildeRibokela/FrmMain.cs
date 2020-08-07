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
using BLL;
using DTO;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using HELPER;
using MatildeRibokela.UC;

namespace MatildeRibokela
{
    public partial class FrmMain : Form
    {
        
        Movimento movimento;
        Arquivo arquivoBLL;
        ArquivoDTO arquivo;
        Categoria categoria;
        UCArqv temp;
        public FrmMain()
        {
            InitializeComponent();
            movimento = new Movimento(this);
            movimento.DarMovimento(PanelTop);
            arquivo = new ArquivoDTO();
            arquivoBLL = new Arquivo();
            categoria = new Categoria();
        }

        private const int shadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ClassStyle = shadow;
                return createParams;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (new Arquivo().VerifyState().Count > 0)
            {
                new FrmWarning().ShowDialog();
            }

            Categoria.DataSource = categoria.List();
            Categoria.DisplayMember = "descricao";
            Categoria.ValueMember = "id";
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox1.ImageLocation = Application.StartupPath+@"\Imagens\icons8-home-24.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            label1.Text = "Adicionar arquivo";

        }
     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (panel1.Visible)
            { 
                pictureBox1.BackColor = Color.FromArgb(231, 244, 231);
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                pictureBox1.BackColor = Color.White;
            }
        }

        private void Mostrar(ArquivoDTO arquivo)
        {
            UCArqv uCArqv = new UCArqv(arquivo);
            temp = uCArqv;
            uCArqv.Top = PUpload.Height / 2 - uCArqv.Height / 2;
            uCArqv.Left = PUpload.Width / 2 - uCArqv.Width / 2;
            PUpload.Controls.Add(uCArqv);
            button3.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MudarTela();
        }

        private void MudarTela() 
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
                pictureBox1.ImageLocation = Application.StartupPath + @"\Imagens\logo.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.BackColor = Color.White;
                label1.Text = "Matilde Ribokela";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Todos ficheiros (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
                arquivo.Caminho = openFileDialog1.FileName;
                arquivo.Nome = Path.GetFileName(arquivo.Caminho);
                arquivo.Tamanho = fileInfo.Length / 1024;
                Mostrar(arquivo);
            }
        }

        private void PUpload_DragDrop(object sender, DragEventArgs e)
        {
            var arqv = e.Data.GetData(DataFormats.FileDrop);
            if (arqv != null)
            {
                var nomeArquivos = arqv as string[];
                if (nomeArquivos.Length > 0)
                {
                    arquivo.Caminho = nomeArquivos[0];
                    arquivo.Nome = Path.GetFileName(arquivo.Caminho);
                    arquivo.Tamanho = new FileInfo(arquivo.Caminho).Length / (1024);
                    Mostrar(arquivo);
                }
            }
        }

        private void PUpload_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arquivo.Categoria = (CategoriaDTO)Categoria.SelectedItem;
            arquivo.DataEntrada = DataEntrada.Value.ToUniversalTime();
            arquivoBLL.upload(arquivo, Application.StartupPath);
            PUpload.Controls.Remove(temp);
            button3.Visible = true;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = Application.StartupPath + @"\Imagens\icons8-back-arrow.png";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = Application.StartupPath + @"\Imagens\icons8-back-arrow-40.png";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MudarTela();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PUpload.Controls.Remove(temp);
            button3.Visible = true;
        }
    }
}
