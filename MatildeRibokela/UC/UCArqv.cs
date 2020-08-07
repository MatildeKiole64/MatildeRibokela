using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.IO;

namespace MatildeRibokela.UC
{
    public partial class UCArqv : UserControl
    {
        private ArquivoDTO arquivo;
        public UCArqv()
        {
            InitializeComponent();
        }

        public UCArqv(ArquivoDTO arquivo)
        {
            InitializeComponent();
            this.arquivo = arquivo;
        }

        private void UCArqv_Load(object sender, EventArgs e)
        {
            
        }

        private void UCArqv_Load_1(object sender, EventArgs e)
        {
            label1.Text = arquivo.Nome;
            label2.Text = arquivo.Tamanho.ToString()+" KB";
        }
    }
}
