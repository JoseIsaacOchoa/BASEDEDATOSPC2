
namespace BASEDEDATOSPC2
{
    partial class COMPRA_DETALLE
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cDFOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDSERIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDIDTIPODOCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDIDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDCANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDIMPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDUBICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPRASDETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet3 = new BASEDEDATOSPC2.VENTASDataSet3();
            this.label15 = new System.Windows.Forms.Label();
            this.TXTSERIE = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TXTFOLIO = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXTISTIPODOCUMENTO = new System.Windows.Forms.TextBox();
            this.cOMPRAS_DETALLETableAdapter = new BASEDEDATOSPC2.VENTASDataSet3TableAdapters.COMPRAS_DETALLETableAdapter();
            this.IDPRO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTCANTIDAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTIMPORTE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTIVA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTIDUBICACION = new System.Windows.Forms.TextBox();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.dsCOMPRASDETALLE = new BASEDEDATOSPC2.dsCOMPRASDETALLE();
            this.cOMPRASDETALLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPRAS_DETALLETableAdapter1 = new BASEDEDATOSPC2.dsCOMPRASDETALLETableAdapters.COMPRAS_DETALLETableAdapter();
            this.CBPRODUCTOS = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASDETALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCOMPRASDETALLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASDETALLEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 47);
            this.label1.TabIndex = 51;
            this.label1.Text = "COMPRAS DETALLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDFOLIODataGridViewTextBoxColumn,
            this.cDSERIEDataGridViewTextBoxColumn,
            this.cDIDTIPODOCTODataGridViewTextBoxColumn,
            this.cDIDPRODUCTODataGridViewTextBoxColumn,
            this.cDCANTIDADDataGridViewTextBoxColumn,
            this.cDIMPORTEDataGridViewTextBoxColumn,
            this.cDIVADataGridViewTextBoxColumn,
            this.cDUBICACIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOMPRASDETALLEBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 291);
            this.dataGridView1.TabIndex = 50;
            // 
            // cDFOLIODataGridViewTextBoxColumn
            // 
            this.cDFOLIODataGridViewTextBoxColumn.DataPropertyName = "CD_FOLIO";
            this.cDFOLIODataGridViewTextBoxColumn.HeaderText = "CD_FOLIO";
            this.cDFOLIODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cDFOLIODataGridViewTextBoxColumn.Name = "cDFOLIODataGridViewTextBoxColumn";
            this.cDFOLIODataGridViewTextBoxColumn.ReadOnly = true;
            this.cDFOLIODataGridViewTextBoxColumn.Width = 150;
            // 
            // cDSERIEDataGridViewTextBoxColumn
            // 
            this.cDSERIEDataGridViewTextBoxColumn.DataPropertyName = "CD_SERIE";
            this.cDSERIEDataGridViewTextBoxColumn.HeaderText = "CD_SERIE";
            this.cDSERIEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cDSERIEDataGridViewTextBoxColumn.Name = "cDSERIEDataGridViewTextBoxColumn";
            this.cDSERIEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDSERIEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cDIDTIPODOCTODataGridViewTextBoxColumn
            // 
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.DataPropertyName = "CD_ID_TIPODOCTO";
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.HeaderText = "CD_ID_TIPODOCTO";
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.Name = "cDIDTIPODOCTODataGridViewTextBoxColumn";
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.Width = 120;
            // 
            // cDIDPRODUCTODataGridViewTextBoxColumn
            // 
            this.cDIDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "CD_ID_PRODUCTO";
            this.cDIDPRODUCTODataGridViewTextBoxColumn.HeaderText = "CD_ID_PRODUCTO";
            this.cDIDPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cDIDPRODUCTODataGridViewTextBoxColumn.Name = "cDIDPRODUCTODataGridViewTextBoxColumn";
            this.cDIDPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cDIDPRODUCTODataGridViewTextBoxColumn.Width = 120;
            // 
            // cDCANTIDADDataGridViewTextBoxColumn
            // 
            this.cDCANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CD_CANTIDAD";
            this.cDCANTIDADDataGridViewTextBoxColumn.HeaderText = "CD_CANTIDAD";
            this.cDCANTIDADDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cDCANTIDADDataGridViewTextBoxColumn.Name = "cDCANTIDADDataGridViewTextBoxColumn";
            this.cDCANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDCANTIDADDataGridViewTextBoxColumn.Width = 150;
            // 
            // cDIMPORTEDataGridViewTextBoxColumn
            // 
            this.cDIMPORTEDataGridViewTextBoxColumn.DataPropertyName = "CD_IMPORTE";
            this.cDIMPORTEDataGridViewTextBoxColumn.HeaderText = "CD_IMPORTE";
            this.cDIMPORTEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cDIMPORTEDataGridViewTextBoxColumn.Name = "cDIMPORTEDataGridViewTextBoxColumn";
            this.cDIMPORTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDIMPORTEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cDIVADataGridViewTextBoxColumn
            // 
            this.cDIVADataGridViewTextBoxColumn.DataPropertyName = "CD_IVA";
            this.cDIVADataGridViewTextBoxColumn.HeaderText = "CD_IVA";
            this.cDIVADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cDIVADataGridViewTextBoxColumn.Name = "cDIVADataGridViewTextBoxColumn";
            this.cDIVADataGridViewTextBoxColumn.ReadOnly = true;
            this.cDIVADataGridViewTextBoxColumn.Width = 150;
            // 
            // cDUBICACIONDataGridViewTextBoxColumn
            // 
            this.cDUBICACIONDataGridViewTextBoxColumn.DataPropertyName = "CD_UBICACION";
            this.cDUBICACIONDataGridViewTextBoxColumn.HeaderText = "CD_UBICACION";
            this.cDUBICACIONDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cDUBICACIONDataGridViewTextBoxColumn.Name = "cDUBICACIONDataGridViewTextBoxColumn";
            this.cDUBICACIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDUBICACIONDataGridViewTextBoxColumn.Width = 150;
            // 
            // cOMPRASDETALLEBindingSource
            // 
            this.cOMPRASDETALLEBindingSource.DataMember = "COMPRAS_DETALLE";
            this.cOMPRASDETALLEBindingSource.DataSource = this.vENTASDataSet3;
            // 
            // vENTASDataSet3
            // 
            this.vENTASDataSet3.DataSetName = "VENTASDataSet3";
            this.vENTASDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(156, 495);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 25);
            this.label15.TabIndex = 107;
            this.label15.Text = "SERIE";
            // 
            // TXTSERIE
            // 
            this.TXTSERIE.Location = new System.Drawing.Point(160, 525);
            this.TXTSERIE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTSERIE.Name = "TXTSERIE";
            this.TXTSERIE.Size = new System.Drawing.Size(186, 26);
            this.TXTSERIE.TabIndex = 106;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 495);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 25);
            this.label16.TabIndex = 105;
            this.label16.Text = "FOLIO";
            // 
            // TXTFOLIO
            // 
            this.TXTFOLIO.Location = new System.Drawing.Point(15, 525);
            this.TXTFOLIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTFOLIO.Name = "TXTFOLIO";
            this.TXTFOLIO.Size = new System.Drawing.Size(90, 26);
            this.TXTFOLIO.TabIndex = 104;
            this.TXTFOLIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFOLIO_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(374, 495);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 25);
            this.label13.TabIndex = 103;
            this.label13.Text = "ID TIPO DOCUMENTO";
            // 
            // TXTISTIPODOCUMENTO
            // 
            this.TXTISTIPODOCUMENTO.Location = new System.Drawing.Point(378, 525);
            this.TXTISTIPODOCUMENTO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTISTIPODOCUMENTO.Name = "TXTISTIPODOCUMENTO";
            this.TXTISTIPODOCUMENTO.Size = new System.Drawing.Size(186, 26);
            this.TXTISTIPODOCUMENTO.TabIndex = 102;
            this.TXTISTIPODOCUMENTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDPRODUCTO_KeyPress);
            // 
            // cOMPRAS_DETALLETableAdapter
            // 
            this.cOMPRAS_DETALLETableAdapter.ClearBeforeFill = true;
            // 
            // IDPRO
            // 
            this.IDPRO.AutoSize = true;
            this.IDPRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPRO.Location = new System.Drawing.Point(614, 495);
            this.IDPRO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDPRO.Name = "IDPRO";
            this.IDPRO.Size = new System.Drawing.Size(161, 25);
            this.IDPRO.TabIndex = 109;
            this.IDPRO.Text = "ID PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(810, 495);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 111;
            this.label2.Text = "CANTIDAD";
            // 
            // TXTCANTIDAD
            // 
            this.TXTCANTIDAD.Location = new System.Drawing.Point(814, 525);
            this.TXTCANTIDAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTCANTIDAD.Name = "TXTCANTIDAD";
            this.TXTCANTIDAD.Size = new System.Drawing.Size(186, 26);
            this.TXTCANTIDAD.TabIndex = 110;
            this.TXTCANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCANTIDAD_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1006, 495);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 113;
            this.label3.Text = "IMPORTE";
            // 
            // TXTIMPORTE
            // 
            this.TXTIMPORTE.Location = new System.Drawing.Point(1011, 525);
            this.TXTIMPORTE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIMPORTE.Name = "TXTIMPORTE";
            this.TXTIMPORTE.Size = new System.Drawing.Size(186, 26);
            this.TXTIMPORTE.TabIndex = 112;
            this.TXTIMPORTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIMPORTE_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 582);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 115;
            this.label4.Text = "IVA";
            // 
            // TXTIVA
            // 
            this.TXTIVA.Location = new System.Drawing.Point(15, 611);
            this.TXTIVA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIVA.Name = "TXTIVA";
            this.TXTIVA.Size = new System.Drawing.Size(186, 26);
            this.TXTIVA.TabIndex = 114;
            this.TXTIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIVA_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 582);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 117;
            this.label5.Text = "ID UBICACION";
            // 
            // TXTIDUBICACION
            // 
            this.TXTIDUBICACION.Location = new System.Drawing.Point(236, 611);
            this.TXTIDUBICACION.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIDUBICACION.Name = "TXTIDUBICACION";
            this.TXTIDUBICACION.Size = new System.Drawing.Size(186, 26);
            this.TXTIDUBICACION.TabIndex = 116;
            this.TXTIDUBICACION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDUBICACION_KeyPress);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(759, 403);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(132, 75);
            this.BTNELIMINAR.TabIndex = 137;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.LightGreen;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.Color.Black;
            this.BTNGUARDAR.Location = new System.Drawing.Point(618, 403);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(132, 75);
            this.BTNGUARDAR.TabIndex = 136;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.BackColor = System.Drawing.Color.Gold;
            this.BTNBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.ForeColor = System.Drawing.Color.Black;
            this.BTNBUSCAR.Location = new System.Drawing.Point(477, 403);
            this.BTNBUSCAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(132, 75);
            this.BTNBUSCAR.TabIndex = 135;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = false;
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // dsCOMPRASDETALLE
            // 
            this.dsCOMPRASDETALLE.DataSetName = "dsCOMPRASDETALLE";
            this.dsCOMPRASDETALLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPRASDETALLEBindingSource1
            // 
            this.cOMPRASDETALLEBindingSource1.DataMember = "COMPRAS_DETALLE";
            this.cOMPRASDETALLEBindingSource1.DataSource = this.dsCOMPRASDETALLE;
            // 
            // cOMPRAS_DETALLETableAdapter1
            // 
            this.cOMPRAS_DETALLETableAdapter1.ClearBeforeFill = true;
            // 
            // CBPRODUCTOS
            // 
            this.CBPRODUCTOS.FormattingEnabled = true;
            this.CBPRODUCTOS.Location = new System.Drawing.Point(618, 525);
            this.CBPRODUCTOS.Name = "CBPRODUCTOS";
            this.CBPRODUCTOS.Size = new System.Drawing.Size(186, 28);
            this.CBPRODUCTOS.TabIndex = 138;
            // 
            // COMPRA_DETALLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1388, 692);
            this.Controls.Add(this.CBPRODUCTOS);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTIDUBICACION);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTIVA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTIMPORTE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTCANTIDAD);
            this.Controls.Add(this.IDPRO);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TXTSERIE);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TXTFOLIO);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TXTISTIPODOCUMENTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "COMPRA_DETALLE";
            this.Text = "COMPRA_DETALLE";
            this.Load += new System.EventHandler(this.COMPRA_DETALLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASDETALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCOMPRASDETALLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASDETALLEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXTSERIE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXTFOLIO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXTISTIPODOCUMENTO;
        private VENTASDataSet3 vENTASDataSet3;
        private System.Windows.Forms.BindingSource cOMPRASDETALLEBindingSource;
        private VENTASDataSet3TableAdapters.COMPRAS_DETALLETableAdapter cOMPRAS_DETALLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDFOLIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDSERIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDIDTIPODOCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDIDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDCANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDIMPORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDUBICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label IDPRO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTCANTIDAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTIMPORTE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTIVA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTIDUBICACION;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNBUSCAR;
        private dsCOMPRASDETALLE dsCOMPRASDETALLE;
        private System.Windows.Forms.BindingSource cOMPRASDETALLEBindingSource1;
        private dsCOMPRASDETALLETableAdapters.COMPRAS_DETALLETableAdapter cOMPRAS_DETALLETableAdapter1;
        private System.Windows.Forms.ComboBox CBPRODUCTOS;
    }
}