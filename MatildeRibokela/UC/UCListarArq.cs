using System;
using BLL;
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
using System.Diagnostics;
using IBLL;

namespace MatildeRibokela.UC
{
    public partial class UCListarArq : UserControl
    {
        IProcessoBLL processoBLL = new ProcessoBLL();

        public UCListarArq()
        {
            InitializeComponent();
        }

        private void UCListaArq_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            //Categoria.DataSource = categoriaBLL.List();
            //Categoria.DisplayMember = "descricao";
            //Categoria.ValueMember = "id";
        }

        private void ActualizarDGV()
        {
            TabelaProcessos.RowTemplate.Height = 40;
            Padding p = new Padding(0, 12, 0, 12);
            TabelaProcessos.RowTemplate.DefaultCellStyle.Padding = p;
            TabelaProcessos.DataSource = processoBLL.List();
            TabelaProcessos.Columns[0].Visible = TabelaProcessos.Columns[2].Visible = TabelaProcessos.Columns[3].Visible = false;
            TabelaProcessos.Columns[1].Width = 360;
            TabelaProcessos.Columns[4].Width = 220;
            TabelaProcessos.Columns[5].Width = 220;
        }

        private void TheSearch_TextChanged(object sender, EventArgs e)
        {
           
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
    }
}
