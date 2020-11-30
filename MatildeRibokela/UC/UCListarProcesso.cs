using System;
using MatildeRibokela.BLL;
using System.ComponentModel;
using System.Windows.Forms;
using DTO;
using IBLL;

namespace MatildeRibokela.UC
{
    public partial class UCListarProcesso : UserControl
    {
        IProcessoBLL processoBLL = new ProcessoBLL();

        public UCListarProcesso()
        {
            InitializeComponent();
        }

        private void UCListaArq_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            BuscarInfo();
            Size = Parent.Size;
        }

        private void ActualizarDGV()
        {
            TabelaProcessos.RowTemplate.Height = 40;
            TabelaProcessos.DataSource = processoBLL.List();
            TabelaProcessos.Columns[0].Visible = TabelaProcessos.Columns[4].Visible = false;
            //TabelaProcessos.Columns[10].
            TabelaProcessos.Columns[5].Visible = false;

        }

        private void TheSearch_TextChanged(object sender, EventArgs e)
        {
            var Lista = processoBLL.List(TheSearch.Text);
            TabelaProcessos.DataSource = Lista;
            BuscarInfo();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Mensagem = TabelaProcessos.SelectedRows.Count > 1 ? "Deseja remover os (" + TabelaProcessos.SelectedRows.Count + ") arquivos" :
                "Deseja remover " + TabelaProcessos.CurrentRow.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show(TabelaProcessos, Mensagem, "Remover arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                foreach (DataGridViewRow item in TabelaProcessos.SelectedRows)
                {
                    ProcessoDTO processoDTO = (ProcessoDTO)item.DataBoundItem;

                    bool remove = processoBLL.Delete(processoDTO);

                    if (remove)
                    {
                        ActualizarDGV();
                    }
                    else
                    {
                        MessageBox.Show(TabelaProcessos, "Erro ao remover o arquivo " + processoDTO.NrProcesso, "Remover arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in TabelaProcessos.SelectedRows)
            {

            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TabelaProcessos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabelaProcessos_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void TabelaProcessos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BuscarInfo();
        }

        private void BuscarInfo()
        {
            if (TabelaProcessos.Rows.Count > 0)
            {
                ProcessoDTO processo = (ProcessoDTO)TabelaProcessos.Rows[TabelaProcessos.SelectedRows[0].Index].DataBoundItem;
                dataGridView1.DataSource = processo.Arguidos;
                dataGridView1.Columns[0].Visible = dataGridView1.Columns[6].Visible = false;

                DataInicio1.Text = processo.Prazos[0].Inicio.ToShortDateString();
                DataFim1.Text = processo.Prazos[0].Fim.ToShortDateString();
                DataRevisao1.Text = processo.Prazos[0].DataRevisaoMinistPub.ToShortDateString();

                DataInicio2.Text = processo.Prazos[1].Inicio.ToShortDateString();
                DataFim2.Text = processo.Prazos[1].Fim.ToShortDateString();
                DataRevisao2.Text = processo.Prazos[1].DataRevisaoMinistPub.ToShortDateString();

                DataInicio3.Text = processo.Prazos[2].Inicio.ToShortDateString();
                DataFim3.Text = processo.Prazos[2].Fim.ToShortDateString();
                DataRevisao3.Text = processo.Prazos[2].DataRevisaoMinistPub.ToShortDateString();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

