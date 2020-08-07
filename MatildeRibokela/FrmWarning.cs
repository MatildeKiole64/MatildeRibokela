using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatildeRibokela
{
    public partial class FrmWarning : Form
    {
        Arquivo arquivo;
        public FrmWarning()
        {
            InitializeComponent();
            arquivo = new Arquivo();
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
        private void FrmWarning_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            label3.Text = dataGridView1.Rows.Count.ToString();
        }

        private void ActualizarDGV()
        {

            dataGridView1.RowTemplate.Height = 50;
            Padding p = new Padding(0, 12, 0, 12);
            dataGridView1.RowTemplate.DefaultCellStyle.Padding = p;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.Text = "Abrir";
            btn.Name = "Acção";
            btn.FlatStyle = FlatStyle.Flat;

            dataGridView1.DataSource = arquivo.VerifyState();

            dataGridView1.Columns.Insert(6, btn);

            dataGridView1.Columns[0].Visible = dataGridView1.Columns[2].Visible = dataGridView1.Columns[3].Visible = false;

            dataGridView1.Columns[1].Width = 250;

            dataGridView1.Columns[4].Width = 200;

            dataGridView1.Columns[5].Width = 220;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ArquivoDTO arquivo = (ArquivoDTO)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            Process.Start(arquivo.Caminho);
        }
    }
}
