namespace CapaPresentacion
{
    partial class frmActiculos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActiculos));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFiltroPorNombre = new System.Windows.Forms.TextBox();
            this.lblFiltroPorNombre = new System.Windows.Forms.Label();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblListaDeArticulos = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.btnFiltroAvanzado = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.erpArticulos = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResetLista = new System.Windows.Forms.Button();
            this.btnInicioLista = new System.Windows.Forms.Button();
            this.gbFiltroAvanzado = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeight = 30;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvArticulos.Location = new System.Drawing.Point(38, 119);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(649, 375);
            this.dgvArticulos.TabIndex = 10;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pcbImagen
            // 
            this.pcbImagen.Location = new System.Drawing.Point(735, 174);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(185, 192);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 1;
            this.pcbImagen.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(37, 538);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 43);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(268, 538);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(188, 43);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(499, 538);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 43);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFiltroPorNombre
            // 
            this.txtFiltroPorNombre.Location = new System.Drawing.Point(299, 78);
            this.txtFiltroPorNombre.Name = "txtFiltroPorNombre";
            this.txtFiltroPorNombre.Size = new System.Drawing.Size(166, 20);
            this.txtFiltroPorNombre.TabIndex = 0;
            this.txtFiltroPorNombre.TextChanged += new System.EventHandler(this.txtFiltroPorNombre_TextChanged);
            // 
            // lblFiltroPorNombre
            // 
            this.lblFiltroPorNombre.AutoSize = true;
            this.lblFiltroPorNombre.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroPorNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFiltroPorNombre.Location = new System.Drawing.Point(40, 78);
            this.lblFiltroPorNombre.Name = "lblFiltroPorNombre";
            this.lblFiltroPorNombre.Size = new System.Drawing.Size(229, 20);
            this.lblFiltroPorNombre.TabIndex = 6;
            this.lblFiltroPorNombre.Text = "Filtrar por nombre de articulo:";
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.pnSuperior.Controls.Add(this.lblListaDeArticulos);
            this.pnSuperior.Controls.Add(this.btnCerrar);
            this.pnSuperior.Controls.Add(this.btnMinimizar);
            this.pnSuperior.Location = new System.Drawing.Point(-2, -1);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(954, 47);
            this.pnSuperior.TabIndex = 9;
            this.pnSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnSuperior_MouseDown);
            this.pnSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnSuperior_MouseMove);
            this.pnSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnSuperior_MouseUp);
            // 
            // lblListaDeArticulos
            // 
            this.lblListaDeArticulos.AutoSize = true;
            this.lblListaDeArticulos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeArticulos.Location = new System.Drawing.Point(35, 13);
            this.lblListaDeArticulos.Name = "lblListaDeArticulos";
            this.lblListaDeArticulos.Size = new System.Drawing.Size(192, 25);
            this.lblListaDeArticulos.TabIndex = 12;
            this.lblListaDeArticulos.Text = "Lista de articulos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(911, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 41);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimizar.Location = new System.Drawing.Point(873, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 41);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(758, 76);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 20);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(854, 76);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(53, 20);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "label1";
            // 
            // tmrHora
            // 
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(107, 649);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 4;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCampo.Location = new System.Drawing.Point(35, 651);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 13;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCriterio.Location = new System.Drawing.Point(265, 651);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 14;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(337, 649);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterio.TabIndex = 5;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(495, 651);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(39, 16);
            this.lblFiltroAvanzado.TabIndex = 16;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(105)))));
            this.btnFiltroAvanzado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFiltroAvanzado.FlatAppearance.BorderSize = 0;
            this.btnFiltroAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(701, 641);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(129, 35);
            this.btnFiltroAvanzado.TabIndex = 7;
            this.btnFiltroAvanzado.Text = "Buscar";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = false;
            this.btnFiltroAvanzado.Click += new System.EventHandler(this.btnFiltroAvanzado_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(571, 649);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.ShortcutsEnabled = false;
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 6;
            // 
            // erpArticulos
            // 
            this.erpArticulos.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(703, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnResetLista
            // 
            this.btnResetLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(105)))));
            this.btnResetLista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResetLista.FlatAppearance.BorderSize = 0;
            this.btnResetLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetLista.Location = new System.Drawing.Point(836, 641);
            this.btnResetLista.Name = "btnResetLista";
            this.btnResetLista.Size = new System.Drawing.Size(101, 35);
            this.btnResetLista.TabIndex = 8;
            this.btnResetLista.Text = "Reiniciar Lista";
            this.btnResetLista.UseVisualStyleBackColor = false;
            this.btnResetLista.Click += new System.EventHandler(this.btnResetLista_Click);
            // 
            // btnInicioLista
            // 
            this.btnInicioLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(179)))));
            this.btnInicioLista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInicioLista.FlatAppearance.BorderSize = 0;
            this.btnInicioLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioLista.Image = ((System.Drawing.Image)(resources.GetObject("btnInicioLista.Image")));
            this.btnInicioLista.Location = new System.Drawing.Point(703, 460);
            this.btnInicioLista.Name = "btnInicioLista";
            this.btnInicioLista.Size = new System.Drawing.Size(33, 34);
            this.btnInicioLista.TabIndex = 9;
            this.btnInicioLista.UseVisualStyleBackColor = false;
            this.btnInicioLista.Click += new System.EventHandler(this.btnInicioLista_Click);
            // 
            // gbFiltroAvanzado
            // 
            this.gbFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroAvanzado.ForeColor = System.Drawing.Color.White;
            this.gbFiltroAvanzado.Location = new System.Drawing.Point(29, 601);
            this.gbFiltroAvanzado.Name = "gbFiltroAvanzado";
            this.gbFiltroAvanzado.Size = new System.Drawing.Size(658, 100);
            this.gbFiltroAvanzado.TabIndex = 23;
            this.gbFiltroAvanzado.TabStop = false;
            this.gbFiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(742, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Subir hasta arriba de la lista";
            // 
            // frmActiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(949, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicioLista);
            this.Controls.Add(this.btnResetLista);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFiltroPorNombre);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.txtFiltroPorNombre);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.gbFiltroAvanzado);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmActiculos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnSuperior_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnSuperior_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnSuperior_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtFiltroPorNombre;
        private System.Windows.Forms.Label lblFiltroPorNombre;
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Button btnFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ErrorProvider erpArticulos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblListaDeArticulos;
        private System.Windows.Forms.Button btnResetLista;
        private System.Windows.Forms.Button btnInicioLista;
        private System.Windows.Forms.GroupBox gbFiltroAvanzado;
        private System.Windows.Forms.Label label1;
    }
}

