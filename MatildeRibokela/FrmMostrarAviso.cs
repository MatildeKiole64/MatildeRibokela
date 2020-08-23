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
    public partial class FrmMostrarAviso : Form
    {
        ArguidoBLL arquivo;
        public FrmMostrarAviso()
        {
            InitializeComponent();
            arquivo = new ArguidoBLL();
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
            int QuantArq = dataGridView1.Rows.Count;
            label2.Text = QuantArq > 1 ? "documentos precisam ser revistos" : "documento precisa ser revisto";
            label3.Text = QuantArq.ToString();
        }

        private void ActualizarDGV()
        {

            //dataGridView1.RowTemplate.Height = 50;
            //Padding p = new Padding(0, 12, 0, 12);
            //dataGridView1.RowTemplate.DefaultCellStyle.Padding = p;

            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.UseColumnTextForButtonValue = true;
            //btn.Text = "Abrir";
            //btn.Name = "Acção";
            //btn.FlatStyle = FlatStyle.Flat;

            //dataGridView1.DataSource = arquivo.VerifyState();

            //dataGridView1.Columns.Insert(6, btn);

            //dataGridView1.Columns[0].Visible = dataGridView1.Columns[2].Visible = dataGridView1.Columns[3].Visible = false;

            //dataGridView1.Columns[1].Width = 250;

            //dataGridView1.Columns[4].Width = 200;

            //dataGridView1.Columns[5].Width = 220;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ProcessoDTO arquivo = (ProcessoDTO)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            //Process.Start(arquivo.Caminho);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    ProcessoDTO arquivo = (ProcessoDTO)dataGridView1.Rows[i].DataBoundItem;
            //    Process.Start(arquivo.Caminho);
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
