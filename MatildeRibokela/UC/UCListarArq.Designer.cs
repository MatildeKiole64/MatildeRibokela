namespace MatildeRibokela.UC
{
    partial class UCListarArq
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabelaProcessos = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TheSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.Filtro = new System.Windows.Forms.ComboBox();
            this.Categoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProcessos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelaProcessos
            // 
            this.TabelaProcessos.AllowUserToAddRows = false;
            this.TabelaProcessos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaProcessos.BackgroundColor = System.Drawing.Color.White;
            this.TabelaProcessos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabelaProcessos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.TabelaProcessos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaProcessos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaProcessos.ColumnHeadersHeight = 30;
            this.TabelaProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TabelaProcessos.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaProcessos.DefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaProcessos.EnableHeadersVisualStyles = false;
            this.TabelaProcessos.Location = new System.Drawing.Point(58, 94);
            this.TabelaProcessos.Name = "TabelaProcessos";
            this.TabelaProcessos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaProcessos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TabelaProcessos.RowHeadersVisible = false;
            this.TabelaProcessos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TabelaProcessos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabelaProcessos.Size = new System.Drawing.Size(1168, 865);
            this.TabelaProcessos.TabIndex = 41;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // TheSearch
            // 
            this.TheSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TheSearch.DefaultText = "";
            this.TheSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TheSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TheSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TheSearch.DisabledState.Parent = this.TheSearch;
            this.TheSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TheSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TheSearch.FocusedState.Parent = this.TheSearch;
            this.TheSearch.ForeColor = System.Drawing.Color.DimGray;
            this.TheSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TheSearch.HoverState.Parent = this.TheSearch;
            this.TheSearch.IconLeftSize = new System.Drawing.Size(16, 16);
            this.TheSearch.IconRight = global::MatildeRibokela.Properties.Resources.icons8_search_16__3_;
            this.TheSearch.IconRightSize = new System.Drawing.Size(16, 16);
            this.TheSearch.Location = new System.Drawing.Point(1015, 48);
            this.TheSearch.Name = "TheSearch";
            this.TheSearch.PasswordChar = '\0';
            this.TheSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TheSearch.PlaceholderText = "Procurar processo";
            this.TheSearch.SelectedText = "";
            this.TheSearch.ShadowDecoration.Parent = this.TheSearch;
            this.TheSearch.Size = new System.Drawing.Size(200, 25);
            this.TheSearch.TabIndex = 43;
            this.TheSearch.TextChanged += new System.EventHandler(this.TheSearch_TextChanged);
            // 
            // Filtro
            // 
            this.Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filtro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro.FormattingEnabled = true;
            this.Filtro.Location = new System.Drawing.Point(848, 48);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(161, 25);
            this.Filtro.TabIndex = 44;
            // 
            // Categoria
            // 
            this.Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.FormattingEnabled = true;
            this.Categoria.Location = new System.Drawing.Point(681, 48);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(161, 25);
            this.Categoria.TabIndex = 45;
            this.Categoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Categoria_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(678, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(845, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Filtro";
            // 
            // UCListarArq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.TheSearch);
            this.Controls.Add(this.TabelaProcessos);
            this.Name = "UCListarArq";
            this.Size = new System.Drawing.Size(1277, 999);
            this.Load += new System.EventHandler(this.UCListaArq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProcessos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TabelaProcessos;
        private Guna.UI2.WinForms.Guna2TextBox TheSearch;
        private System.Windows.Forms.ComboBox Filtro;
        private System.Windows.Forms.ComboBox Categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
    }
}
