using DTO;
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
    public partial class FrmPreview : Form
    {
        ProcessoDTO processoDTO;
        public FrmPreview(ProcessoDTO processoDTO)
        {
            InitializeComponent();
            this.processoDTO = processoDTO;
        }

        private void FrmPreview_Load(object sender, EventArgs e)
        {

            ProcessoDTOBindingSource.DataSource = processoDTO;
            ArguidoDTOBindingSource.DataSource = processoDTO.Arguidos;
            PrazoDTOBindingSource.DataSource = processoDTO.Prazos;
            this.reportViewer1.RefreshReport();
        }
    }
}
