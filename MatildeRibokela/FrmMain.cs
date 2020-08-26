using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        UCCadastrarProcesso uCCadastrar;
        UCListarProcesso uCListaArq;
        Movimento movimento;

        public FrmMain()
        {
            InitializeComponent();
            uCCadastrar = new UCCadastrarProcesso();
            uCListaArq = new UCListarProcesso();
            movimento = new Movimento(this);
            movimento.DarMovimento(PanelTop);

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
            WindowState = FormWindowState.Maximized;

           
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MudarTela(uCCadastrar, "Adicionar processo");
          
        }

        private void MudarTela(UserControl tela, string nomeTela)
        {
            panel1.Visible = true;
            pictureBox4.Visible = true;
            pictureBox1.ImageLocation = Application.StartupPath + @"\Imagens\icons8-home-24.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            label1.Text = nomeTela;
            panel1.Controls.Clear();
            panel1.Controls.Add(tela);
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
            if (panel1.Controls.Count > 0)
            {
                pictureBox1.BackColor = Color.FromArgb(231, 244, 231);
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
            {
                pictureBox1.BackColor = Color.White;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void Voltar()
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Visible = false;
                pictureBox4.Visible = false;
                pictureBox1.ImageLocation = Application.StartupPath + @"\Imagens\logo.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.BackColor = Color.White;
                label1.Text = "Matilde Ribokela";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PUpload_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void PUpload_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
            Voltar();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MudarTela(uCListaArq, "Lista processos");
        }
    }
}
