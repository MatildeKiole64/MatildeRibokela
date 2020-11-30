using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBLL;
using MatildeRibokela.BLL;
using DTO;
using HELPER;

namespace MatildeRibokela.UC
{
    public partial class UCCadastrarProcesso : UserControl
    {
        IProcessoBLL processo = new ProcessoBLL();
        IArguidoBLL arguido = new ArguidoBLL();
        IPrazoBLL prazo = new PrazoBLL();

        public UCCadastrarProcesso()
        {
            InitializeComponent();
        }

        private void siticoneDateTimePicker7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void siticoneDateTimePicker8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void siticoneDateTimePicker6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void siticoneDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private int GetTipoCircunst()
        {
            return Flagrante.Checked ? 1 : 2;
        }
        private int GetTipoManterP()
        {
            return Inconveniencia.Checked ? 2 : 1;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ProcessoDTO processoDTO = new ProcessoDTO()
            {
                Id = Guid.NewGuid(),
                Instrutor = Instrutor.Text,
                NrProcesso = NumProcesso.Text,
                NrRegisto = NumRegisto.Text,
                LocalDetencao = Local.Text,
                CircunstPrisao = (ProcessoDTO.TipoP)GetTipoCircunst(),
                ManterPrisao = (ProcessoDTO.TipoM)GetTipoManterP(),
                DataApresentacaoMinistPub = DataApresentacao.Value.ToUniversalTime(),
                DataDetencao = DataDetencao.Value.ToUniversalTime(),
                DataRemissaoDist = DataRemissao.Value.ToUniversalTime(),
            };

            Guid Id = processo.Create(processoDTO);

            PrazoDTO[] prazos = new PrazoDTO[3]
            {
                 new PrazoDTO()
                 {
                    Id = Guid.NewGuid(),
                    Inicio = DataInicio1.Value.ToUniversalTime(),
                    Fim = DataFim1.Value.ToUniversalTime(),
                    DataRevisaoMinistPub = DataRevisao1.Value.ToUniversalTime(),
                    Tipo = 1,
                    ProcessoId = Id
                 },
                  new PrazoDTO()
                 {
                    Id = Guid.NewGuid(),
                    Inicio = DataInicio2.Value.ToUniversalTime(),
                    Fim = DataFim2.Value.ToUniversalTime(),
                    DataRevisaoMinistPub = DataRevisao2.Value.ToUniversalTime(),
                    Tipo = 2,
                    ProcessoId = Id
                 },
                  new PrazoDTO()
                  {
                    Id = Guid.NewGuid(),
                    Inicio = DataInicio3.Value.ToUniversalTime(),
                    Fim = DataFim3.Value.ToUniversalTime(),
                    DataRevisaoMinistPub = DataRevisao3.Value.ToUniversalTime(),
                    Tipo = 3,
                    ProcessoId = Id
                  }
            };

            for (int i = 0; i < 3; i++)
            {
                PrazoDTO prazoDTO = prazos[i];
                prazo.Create(prazoDTO);
            }

            foreach (ListViewItem lvwItem in ListaArguidos.Items)
            {
                ArguidoDTO arguidoDTO = new ArguidoDTO()
                {
                    Id = Guid.NewGuid(),
                    Nome = lvwItem.SubItems[0].Text,
                    Idade = Convert.ToInt32(lvwItem.SubItems[1].Text),
                    ResidenciaHabitual = lvwItem.SubItems[2].Text,
                    Contacto1 = Convert.ToInt32(lvwItem.SubItems[3].Text),
                    Contacto2 = Convert.ToInt32(lvwItem.SubItems[4].Text),
                    ProcessoId = Id,
                };
                arguido.Create(arguidoDTO);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvw = ListaArguidos.Items.Add(NomeArguido.Text);
            lvw.SubItems.Add(Idade.Text);
            lvw.SubItems.Add(ResidenciaHab.Text);
            lvw.SubItems.Add(Contacto1.Text);
            lvw.SubItems.Add(Contacto2.Text);
            CaniveteSuico.Limpar(groupBoxAmigos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvwitem in ListaArguidos.SelectedItems)
            {
                ListaArguidos.Items.Remove(lvwitem);
            }
        }

        private void UCCadastrarArq_Load(object sender, EventArgs e)
        {
            int x = Parent.Width / 2 - Width / 2;
            Location = new Point(x, 0);
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Limpar();
        }
    }
}
