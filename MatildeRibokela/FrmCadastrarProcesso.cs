using BLL;
using DTO;
using IBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatildeRibokela
{
    public partial class FrmCadastrarProcesso : Form
    {
        IProcessoBLL processo = new ProcessoBLL();
        IDetencaoBLL detencao = new DetencaoBLL();
        IArguidoBLL arguido = new ArguidoBLL();
        IPrazoBLL prazo = new PrazoBLL();
        public FrmCadastrarProcesso()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetencaoDTO detencaoDTO = new DetencaoDTO()
            {
                Flagrante = Flagrante.Checked,
                Local = Local.Text
            };

            detencaoDTO.DataApresentacaoMinistPub = DataApresentacao.Value.ToUniversalTime();
            detencaoDTO.Data = DataDetencao.Value.ToUniversalTime();
            long IdDetencao = detencao.Create(detencaoDTO);

            PrazoDTO[] prazos = new PrazoDTO[3]
            {
                 new PrazoDTO()
                 {
                    Inicio = DataInicio1.Value.ToUniversalTime(),
                    Fim = DataFim1.Value.ToUniversalTime(),
                    DataRevisaoMinistPub = DataRevisao1.Value.ToUniversalTime()
                 },
                  new PrazoDTO()
                 {
                    Inicio = DataInicio2.Value.ToUniversalTime(),
                    Fim = DataFim2.Value.ToUniversalTime(),
                    DataRevisaoMinistPub = DataRevisao2.Value.ToUniversalTime()
                 },
                  new PrazoDTO()
                  {
                    Inicio = DataInicio3.Value.ToUniversalTime(),
                    Fim = DataFim3.Value.ToUniversalTime(),
                    DataRevisaoMinistPub = DataRevisao3.Value.ToUniversalTime()
                  }

        };
            prazos[0].Id = prazo.Create(prazos[0]);
            prazos[1].Id = prazo.Create(prazos[1]);
            prazos[2].Id = prazo.Create(prazos[2]);

            ProcessoDTO processoDTO = new ProcessoDTO()
            {
                DetencaoId = IdDetencao,
                Inconveniencia = Inconveniencia.Checked,
                Instrutor = Instrutor.Text,
                NrProcesso = NumProcesso.Text,
                NrRegisto = NumRegisto.Text,
                DataRemissaoDist = DataRemissao.Value.ToUniversalTime(),
                Prazo1Id = prazos[0].Id,
                Prazo2Id = prazos[1].Id,
                Prazo3Id = prazos[2].Id
            };

            processoDTO.Id = processo.Create(processoDTO);

            foreach (ListViewItem lvwItem in ListaArguidos.Items)
            {
                ArguidoDTO arguidoDTO = new ArguidoDTO()
                {
                    Nome = lvwItem.SubItems[0].Text,
                    Idade = Convert.ToInt32(lvwItem.SubItems[1].Text),
                    ResidenciaHabitual = lvwItem.SubItems[2].Text,
                    Contacto1 = Convert.ToInt32(lvwItem.SubItems[3].Text),
                    Contacto2 = Convert.ToInt32(lvwItem.SubItems[4].Text),
                    ProcessoId = processoDTO.Id
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvwitem in ListaArguidos.SelectedItems)
            {
                ListaArguidos.Items.Remove(lvwitem);
            }
        }
    }
}
