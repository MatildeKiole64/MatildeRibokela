namespace MatildeRibokela.UC
{
    partial class UCListarProcesso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TheSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.siticoneGroupBox1 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataRevisao3 = new System.Windows.Forms.Label();
            this.DataFim3 = new System.Windows.Forms.Label();
            this.DataInicio3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DataRevisao2 = new System.Windows.Forms.Label();
            this.DataFim2 = new System.Windows.Forms.Label();
            this.DataInicio2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DataRevisao1 = new System.Windows.Forms.Label();
            this.DataFim1 = new System.Windows.Forms.Label();
            this.DataInicio1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TabelaProcessos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.siticoneGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProcessos)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.TheSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.TheSearch.Location = new System.Drawing.Point(737, 42);
            this.TheSearch.Name = "TheSearch";
            this.TheSearch.PasswordChar = '\0';
            this.TheSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TheSearch.PlaceholderText = "Procurar processo";
            this.TheSearch.SelectedText = "";
            this.TheSearch.ShadowDecoration.Parent = this.TheSearch;
            this.TheSearch.Size = new System.Drawing.Size(268, 31);
            this.TheSearch.TabIndex = 43;
            this.TheSearch.TextChanged += new System.EventHandler(this.TheSearch_TextChanged);
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneGroupBox1.Controls.Add(this.dataGridView1);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(504, 110);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(502, 237);
            this.siticoneGroupBox1.TabIndex = 48;
            this.siticoneGroupBox1.Text = "Arguido(s)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(28, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 153);
            this.dataGridView1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DataRevisao3);
            this.panel2.Controls.Add(this.DataFim3);
            this.panel2.Controls.Add(this.DataInicio3);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.DataRevisao2);
            this.panel2.Controls.Add(this.DataFim2);
            this.panel2.Controls.Add(this.DataInicio2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DataRevisao1);
            this.panel2.Controls.Add(this.DataFim1);
            this.panel2.Controls.Add(this.DataInicio1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(504, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 348);
            this.panel2.TabIndex = 49;
            // 
            // DataRevisao3
            // 
            this.DataRevisao3.AutoSize = true;
            this.DataRevisao3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataRevisao3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataRevisao3.Location = new System.Drawing.Point(369, 302);
            this.DataRevisao3.Name = "DataRevisao3";
            this.DataRevisao3.Size = new System.Drawing.Size(74, 17);
            this.DataRevisao3.TabIndex = 77;
            this.DataRevisao3.Text = "20/12/2020";
            // 
            // DataFim3
            // 
            this.DataFim3.AutoSize = true;
            this.DataFim3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFim3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataFim3.Location = new System.Drawing.Point(207, 302);
            this.DataFim3.Name = "DataFim3";
            this.DataFim3.Size = new System.Drawing.Size(74, 17);
            this.DataFim3.TabIndex = 76;
            this.DataFim3.Text = "20/12/2020";
            // 
            // DataInicio3
            // 
            this.DataInicio3.AutoSize = true;
            this.DataInicio3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicio3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataInicio3.Location = new System.Drawing.Point(47, 302);
            this.DataInicio3.Name = "DataInicio3";
            this.DataInicio3.Size = new System.Drawing.Size(74, 17);
            this.DataInicio3.TabIndex = 75;
            this.DataInicio3.Text = "20/12/2020";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(24, 274);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 16);
            this.label19.TabIndex = 72;
            this.label19.Text = "Inicio do 3º prazo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(186, 274);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 16);
            this.label20.TabIndex = 73;
            this.label20.Text = "Fim do 3º prazo";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(325, 274);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 16);
            this.label21.TabIndex = 74;
            this.label21.Text = "Data revisão pelo Mº Pº";
            // 
            // DataRevisao2
            // 
            this.DataRevisao2.AutoSize = true;
            this.DataRevisao2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataRevisao2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataRevisao2.Location = new System.Drawing.Point(369, 179);
            this.DataRevisao2.Name = "DataRevisao2";
            this.DataRevisao2.Size = new System.Drawing.Size(74, 17);
            this.DataRevisao2.TabIndex = 71;
            this.DataRevisao2.Text = "20/12/2020";
            // 
            // DataFim2
            // 
            this.DataFim2.AutoSize = true;
            this.DataFim2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFim2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataFim2.Location = new System.Drawing.Point(205, 179);
            this.DataFim2.Name = "DataFim2";
            this.DataFim2.Size = new System.Drawing.Size(74, 17);
            this.DataFim2.TabIndex = 70;
            this.DataFim2.Text = "20/12/2020";
            // 
            // DataInicio2
            // 
            this.DataInicio2.AutoSize = true;
            this.DataInicio2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicio2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataInicio2.Location = new System.Drawing.Point(47, 179);
            this.DataInicio2.Name = "DataInicio2";
            this.DataInicio2.Size = new System.Drawing.Size(74, 17);
            this.DataInicio2.TabIndex = 69;
            this.DataInicio2.Text = "20/12/2020";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(24, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Inicio do 2º prazo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(186, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Fim do 2º prazo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(325, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Data revisão pelo Mº Pº";
            // 
            // DataRevisao1
            // 
            this.DataRevisao1.AutoSize = true;
            this.DataRevisao1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataRevisao1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataRevisao1.Location = new System.Drawing.Point(369, 73);
            this.DataRevisao1.Name = "DataRevisao1";
            this.DataRevisao1.Size = new System.Drawing.Size(74, 17);
            this.DataRevisao1.TabIndex = 65;
            this.DataRevisao1.Text = "20/12/2020";
            // 
            // DataFim1
            // 
            this.DataFim1.AutoSize = true;
            this.DataFim1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFim1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataFim1.Location = new System.Drawing.Point(203, 73);
            this.DataFim1.Name = "DataFim1";
            this.DataFim1.Size = new System.Drawing.Size(74, 17);
            this.DataFim1.TabIndex = 64;
            this.DataFim1.Text = "20/12/2020";
            // 
            // DataInicio1
            // 
            this.DataInicio1.AutoSize = true;
            this.DataInicio1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicio1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataInicio1.Location = new System.Drawing.Point(47, 73);
            this.DataInicio1.Name = "DataInicio1";
            this.DataInicio1.Size = new System.Drawing.Size(74, 17);
            this.DataInicio1.TabIndex = 63;
            this.DataInicio1.Text = "20/12/2020";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(24, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "Inicio do 1º prazo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(186, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 16);
            this.label11.TabIndex = 55;
            this.label11.Text = "Fim do 1º prazo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(325, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "Data revisão pelo Mº Pº";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 26);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "3º Prazo";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(-1, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(629, 26);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(222, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "2º Prazo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-2, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 26);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "1º Prazo";
            // 
            // TabelaProcessos
            // 
            this.TabelaProcessos.AllowUserToAddRows = false;
            this.TabelaProcessos.BackgroundColor = System.Drawing.Color.White;
            this.TabelaProcessos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabelaProcessos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.TabelaProcessos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaProcessos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TabelaProcessos.ColumnHeadersHeight = 30;
            this.TabelaProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaProcessos.DefaultCellStyle = dataGridViewCellStyle4;
            this.TabelaProcessos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelaProcessos.EnableHeadersVisualStyles = false;
            this.TabelaProcessos.Location = new System.Drawing.Point(0, 0);
            this.TabelaProcessos.Name = "TabelaProcessos";
            this.TabelaProcessos.ReadOnly = true;
            this.TabelaProcessos.RowHeadersVisible = false;
            this.TabelaProcessos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabelaProcessos.Size = new System.Drawing.Size(462, 591);
            this.TabelaProcessos.TabIndex = 50;
            this.TabelaProcessos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaProcessos_CellClick);
            this.TabelaProcessos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaProcessos_CellContentClick);
            this.TabelaProcessos.SelectionChanged += new System.EventHandler(this.TabelaProcessos_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.TabelaProcessos);
            this.panel4.Location = new System.Drawing.Point(18, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 591);
            this.panel4.TabIndex = 51;
            // 
            // UCListarProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.TheSearch);
            this.Name = "UCListarProcesso";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.UCListaArq_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.siticoneGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProcessos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TheSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DataRevisao3;
        private System.Windows.Forms.Label DataFim3;
        private System.Windows.Forms.Label DataInicio3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label DataRevisao2;
        private System.Windows.Forms.Label DataFim2;
        private System.Windows.Forms.Label DataInicio2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DataRevisao1;
        private System.Windows.Forms.Label DataFim1;
        private System.Windows.Forms.Label DataInicio1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView TabelaProcessos;
        private System.Windows.Forms.Panel panel4;
    }
}
