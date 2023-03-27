
namespace BASEDEDATOSPC2
{
    partial class VENTAS2
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
            this.label3 = new System.Windows.Forms.Label();
            this.TXTIDALMACEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDPRO = new System.Windows.Forms.Label();
            this.TXTMONTO = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TXTSERIE = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TXTFOLIO = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXTISTIPODOCUMENTO = new System.Windows.Forms.TextBox();
            this.DATETIMEFECHA = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNVENDER = new System.Windows.Forms.Button();
            this.BTNBUSCARFOLIO = new System.Windows.Forms.Button();
            this.CBPRODUCTOS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNMAS = new System.Windows.Forms.Button();
            this.BTNMENOS = new System.Windows.Forms.Button();
            this.TXTCANTIDAD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTIMPORTE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTIVA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBCLIENTES = new System.Windows.Forms.ComboBox();
            this.dsVentas = new BASEDEDATOSPC2.dsVentas();
            this.vENTADETTMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTA_DET_TMPTableAdapter = new BASEDEDATOSPC2.dsVentasTableAdapters.VENTA_DET_TMPTableAdapter();
            this.vTFOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTSERIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTIDTIPODOCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTMONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTIDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTIDALMACENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTFECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTIDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTCANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTIMPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTADETTMPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 47);
            this.label1.TabIndex = 51;
            this.label1.Text = "VENTAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vTFOLIODataGridViewTextBoxColumn,
            this.vTSERIEDataGridViewTextBoxColumn,
            this.vTIDTIPODOCTODataGridViewTextBoxColumn,
            this.vTMONTODataGridViewTextBoxColumn,
            this.vTIDCLIENTEDataGridViewTextBoxColumn,
            this.vTIDALMACENDataGridViewTextBoxColumn,
            this.vTFECHADataGridViewTextBoxColumn,
            this.vTIDPRODUCTODataGridViewTextBoxColumn,
            this.vTCANTIDADDataGridViewTextBoxColumn,
            this.vTIMPORTEDataGridViewTextBoxColumn,
            this.vTIVADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vENTADETTMPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 180);
            this.dataGridView1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1083, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 129;
            this.label3.Text = "ID ALMACEN";
            // 
            // TXTIDALMACEN
            // 
            this.TXTIDALMACEN.Location = new System.Drawing.Point(1088, 422);
            this.TXTIDALMACEN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIDALMACEN.Name = "TXTIDALMACEN";
            this.TXTIDALMACEN.Size = new System.Drawing.Size(180, 26);
            this.TXTIDALMACEN.TabIndex = 128;
            this.TXTIDALMACEN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDALMACEN_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(866, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 127;
            this.label2.Text = "CLIENTE";
            // 
            // IDPRO
            // 
            this.IDPRO.AutoSize = true;
            this.IDPRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPRO.Location = new System.Drawing.Point(650, 391);
            this.IDPRO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDPRO.Name = "IDPRO";
            this.IDPRO.Size = new System.Drawing.Size(93, 25);
            this.IDPRO.TabIndex = 125;
            this.IDPRO.Text = "MONTO";
            // 
            // TXTMONTO
            // 
            this.TXTMONTO.Location = new System.Drawing.Point(655, 420);
            this.TXTMONTO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTMONTO.Name = "TXTMONTO";
            this.TXTMONTO.Size = new System.Drawing.Size(180, 26);
            this.TXTMONTO.TabIndex = 124;
            this.TXTMONTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTMONTO_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(178, 391);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 25);
            this.label15.TabIndex = 123;
            this.label15.Text = "SERIE";
            // 
            // TXTSERIE
            // 
            this.TXTSERIE.Location = new System.Drawing.Point(183, 420);
            this.TXTSERIE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTSERIE.Name = "TXTSERIE";
            this.TXTSERIE.Size = new System.Drawing.Size(180, 26);
            this.TXTSERIE.TabIndex = 122;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 391);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 25);
            this.label16.TabIndex = 121;
            this.label16.Text = "FOLIO";
            // 
            // TXTFOLIO
            // 
            this.TXTFOLIO.Location = new System.Drawing.Point(20, 420);
            this.TXTFOLIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTFOLIO.Name = "TXTFOLIO";
            this.TXTFOLIO.Size = new System.Drawing.Size(84, 26);
            this.TXTFOLIO.TabIndex = 120;
            this.TXTFOLIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFOLIO_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(396, 391);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 25);
            this.label13.TabIndex = 119;
            this.label13.Text = "ID TIPO DOCUMENTO";
            // 
            // TXTISTIPODOCUMENTO
            // 
            this.TXTISTIPODOCUMENTO.Location = new System.Drawing.Point(400, 420);
            this.TXTISTIPODOCUMENTO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTISTIPODOCUMENTO.Name = "TXTISTIPODOCUMENTO";
            this.TXTISTIPODOCUMENTO.Size = new System.Drawing.Size(180, 26);
            this.TXTISTIPODOCUMENTO.TabIndex = 118;
            this.TXTISTIPODOCUMENTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTISTIPODOCUMENTO_KeyPress);
            // 
            // DATETIMEFECHA
            // 
            this.DATETIMEFECHA.Location = new System.Drawing.Point(20, 509);
            this.DATETIMEFECHA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DATETIMEFECHA.Name = "DATETIMEFECHA";
            this.DATETIMEFECHA.Size = new System.Drawing.Size(298, 26);
            this.DATETIMEFECHA.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 480);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 134;
            this.label6.Text = "FECHA";
            // 
            // BTNVENDER
            // 
            this.BTNVENDER.BackColor = System.Drawing.Color.LightGreen;
            this.BTNVENDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVENDER.ForeColor = System.Drawing.Color.Black;
            this.BTNVENDER.Location = new System.Drawing.Point(572, 282);
            this.BTNVENDER.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNVENDER.Name = "BTNVENDER";
            this.BTNVENDER.Size = new System.Drawing.Size(132, 75);
            this.BTNVENDER.TabIndex = 137;
            this.BTNVENDER.Text = "Vender";
            this.BTNVENDER.UseVisualStyleBackColor = false;
            this.BTNVENDER.Click += new System.EventHandler(this.BTNVENDER_Click);
            // 
            // BTNBUSCARFOLIO
            // 
            this.BTNBUSCARFOLIO.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_búsqueda_24;
            this.BTNBUSCARFOLIO.Location = new System.Drawing.Point(111, 391);
            this.BTNBUSCARFOLIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNBUSCARFOLIO.Name = "BTNBUSCARFOLIO";
            this.BTNBUSCARFOLIO.Size = new System.Drawing.Size(58, 66);
            this.BTNBUSCARFOLIO.TabIndex = 138;
            this.BTNBUSCARFOLIO.UseVisualStyleBackColor = true;
            this.BTNBUSCARFOLIO.Click += new System.EventHandler(this.BTNBUSCARFOLIO_Click);
            // 
            // CBPRODUCTOS
            // 
            this.CBPRODUCTOS.FormattingEnabled = true;
            this.CBPRODUCTOS.Location = new System.Drawing.Point(20, 592);
            this.CBPRODUCTOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBPRODUCTOS.Name = "CBPRODUCTOS";
            this.CBPRODUCTOS.Size = new System.Drawing.Size(180, 28);
            this.CBPRODUCTOS.TabIndex = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 563);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 141;
            this.label4.Text = "PRODUCTOS";
            // 
            // BTNMAS
            // 
            this.BTNMAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNMAS.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_más_26;
            this.BTNMAS.Location = new System.Drawing.Point(713, 580);
            this.BTNMAS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNMAS.Name = "BTNMAS";
            this.BTNMAS.Size = new System.Drawing.Size(74, 51);
            this.BTNMAS.TabIndex = 142;
            this.BTNMAS.UseVisualStyleBackColor = false;
            this.BTNMAS.Click += new System.EventHandler(this.BTNMAS_Click);
            // 
            // BTNMENOS
            // 
            this.BTNMENOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNMENOS.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_menos_24;
            this.BTNMENOS.Location = new System.Drawing.Point(795, 580);
            this.BTNMENOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNMENOS.Name = "BTNMENOS";
            this.BTNMENOS.Size = new System.Drawing.Size(74, 51);
            this.BTNMENOS.TabIndex = 143;
            this.BTNMENOS.UseVisualStyleBackColor = false;
            this.BTNMENOS.Click += new System.EventHandler(this.BTNMENOS_Click);
            // 
            // TXTCANTIDAD
            // 
            this.TXTCANTIDAD.Location = new System.Drawing.Point(228, 592);
            this.TXTCANTIDAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTCANTIDAD.Name = "TXTCANTIDAD";
            this.TXTCANTIDAD.Size = new System.Drawing.Size(128, 26);
            this.TXTCANTIDAD.TabIndex = 144;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 562);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 145;
            this.label5.Text = "CANTIDAD";
            // 
            // TXTIMPORTE
            // 
            this.TXTIMPORTE.Location = new System.Drawing.Point(382, 592);
            this.TXTIMPORTE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIMPORTE.Name = "TXTIMPORTE";
            this.TXTIMPORTE.Size = new System.Drawing.Size(128, 26);
            this.TXTIMPORTE.TabIndex = 146;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 562);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 147;
            this.label7.Text = "IMPORTE";
            // 
            // TXTIVA
            // 
            this.TXTIVA.Location = new System.Drawing.Point(535, 592);
            this.TXTIVA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIVA.Name = "TXTIVA";
            this.TXTIVA.Size = new System.Drawing.Size(128, 26);
            this.TXTIVA.TabIndex = 148;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(530, 562);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 149;
            this.label8.Text = "IVA";
            // 
            // CBCLIENTES
            // 
            this.CBCLIENTES.FormattingEnabled = true;
            this.CBCLIENTES.Location = new System.Drawing.Point(871, 420);
            this.CBCLIENTES.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBCLIENTES.Name = "CBCLIENTES";
            this.CBCLIENTES.Size = new System.Drawing.Size(199, 28);
            this.CBCLIENTES.TabIndex = 150;
            // 
            // dsVentas
            // 
            this.dsVentas.DataSetName = "dsVentas";
            this.dsVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTADETTMPBindingSource
            // 
            this.vENTADETTMPBindingSource.DataMember = "VENTA_DET_TMP";
            this.vENTADETTMPBindingSource.DataSource = this.dsVentas;
            // 
            // vENTA_DET_TMPTableAdapter
            // 
            this.vENTA_DET_TMPTableAdapter.ClearBeforeFill = true;
            // 
            // vTFOLIODataGridViewTextBoxColumn
            // 
            this.vTFOLIODataGridViewTextBoxColumn.DataPropertyName = "VT_FOLIO";
            this.vTFOLIODataGridViewTextBoxColumn.HeaderText = "VT_FOLIO";
            this.vTFOLIODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTFOLIODataGridViewTextBoxColumn.Name = "vTFOLIODataGridViewTextBoxColumn";
            this.vTFOLIODataGridViewTextBoxColumn.ReadOnly = true;
            this.vTFOLIODataGridViewTextBoxColumn.Width = 150;
            // 
            // vTSERIEDataGridViewTextBoxColumn
            // 
            this.vTSERIEDataGridViewTextBoxColumn.DataPropertyName = "VT_SERIE";
            this.vTSERIEDataGridViewTextBoxColumn.HeaderText = "VT_SERIE";
            this.vTSERIEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTSERIEDataGridViewTextBoxColumn.Name = "vTSERIEDataGridViewTextBoxColumn";
            this.vTSERIEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vTSERIEDataGridViewTextBoxColumn.Width = 150;
            // 
            // vTIDTIPODOCTODataGridViewTextBoxColumn
            // 
            this.vTIDTIPODOCTODataGridViewTextBoxColumn.DataPropertyName = "VT_ID_TIPODOCTO";
            this.vTIDTIPODOCTODataGridViewTextBoxColumn.HeaderText = "VT_ID_TIPODOCTO";
            this.vTIDTIPODOCTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTIDTIPODOCTODataGridViewTextBoxColumn.Name = "vTIDTIPODOCTODataGridViewTextBoxColumn";
            this.vTIDTIPODOCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.vTIDTIPODOCTODataGridViewTextBoxColumn.Width = 150;
            // 
            // vTMONTODataGridViewTextBoxColumn
            // 
            this.vTMONTODataGridViewTextBoxColumn.DataPropertyName = "VT_MONTO";
            this.vTMONTODataGridViewTextBoxColumn.HeaderText = "VT_MONTO";
            this.vTMONTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTMONTODataGridViewTextBoxColumn.Name = "vTMONTODataGridViewTextBoxColumn";
            this.vTMONTODataGridViewTextBoxColumn.ReadOnly = true;
            this.vTMONTODataGridViewTextBoxColumn.Width = 150;
            // 
            // vTIDCLIENTEDataGridViewTextBoxColumn
            // 
            this.vTIDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "VT_ID_CLIENTE";
            this.vTIDCLIENTEDataGridViewTextBoxColumn.HeaderText = "VT_ID_CLIENTE";
            this.vTIDCLIENTEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTIDCLIENTEDataGridViewTextBoxColumn.Name = "vTIDCLIENTEDataGridViewTextBoxColumn";
            this.vTIDCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vTIDCLIENTEDataGridViewTextBoxColumn.Width = 150;
            // 
            // vTIDALMACENDataGridViewTextBoxColumn
            // 
            this.vTIDALMACENDataGridViewTextBoxColumn.DataPropertyName = "VT_ID_ALMACEN";
            this.vTIDALMACENDataGridViewTextBoxColumn.HeaderText = "VT_ID_ALMACEN";
            this.vTIDALMACENDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTIDALMACENDataGridViewTextBoxColumn.Name = "vTIDALMACENDataGridViewTextBoxColumn";
            this.vTIDALMACENDataGridViewTextBoxColumn.ReadOnly = true;
            this.vTIDALMACENDataGridViewTextBoxColumn.Width = 150;
            // 
            // vTFECHADataGridViewTextBoxColumn
            // 
            this.vTFECHADataGridViewTextBoxColumn.DataPropertyName = "VT_FECHA";
            this.vTFECHADataGridViewTextBoxColumn.HeaderText = "VT_FECHA";
            this.vTFECHADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTFECHADataGridViewTextBoxColumn.Name = "vTFECHADataGridViewTextBoxColumn";
            this.vTFECHADataGridViewTextBoxColumn.ReadOnly = true;
            this.vTFECHADataGridViewTextBoxColumn.Width = 150;
            // 
            // vTIDPRODUCTODataGridViewTextBoxColumn
            // 
            this.vTIDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "VT_ID_PRODUCTO";
            this.vTIDPRODUCTODataGridViewTextBoxColumn.HeaderText = "VT_ID_PRODUCTO";
            this.vTIDPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTIDPRODUCTODataGridViewTextBoxColumn.Name = "vTIDPRODUCTODataGridViewTextBoxColumn";
            this.vTIDPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.vTIDPRODUCTODataGridViewTextBoxColumn.Width = 150;
            // 
            // vTCANTIDADDataGridViewTextBoxColumn
            // 
            this.vTCANTIDADDataGridViewTextBoxColumn.DataPropertyName = "VT_CANTIDAD";
            this.vTCANTIDADDataGridViewTextBoxColumn.HeaderText = "VT_CANTIDAD";
            this.vTCANTIDADDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTCANTIDADDataGridViewTextBoxColumn.Name = "vTCANTIDADDataGridViewTextBoxColumn";
            this.vTCANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.vTCANTIDADDataGridViewTextBoxColumn.Width = 150;
            // 
            // vTIMPORTEDataGridViewTextBoxColumn
            // 
            this.vTIMPORTEDataGridViewTextBoxColumn.DataPropertyName = "VT_IMPORTE";
            this.vTIMPORTEDataGridViewTextBoxColumn.HeaderText = "VT_IMPORTE";
            this.vTIMPORTEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTIMPORTEDataGridViewTextBoxColumn.Name = "vTIMPORTEDataGridViewTextBoxColumn";
            this.vTIMPORTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vTIMPORTEDataGridViewTextBoxColumn.Width = 150;
            // 
            // vTIVADataGridViewTextBoxColumn
            // 
            this.vTIVADataGridViewTextBoxColumn.DataPropertyName = "VT_IVA";
            this.vTIVADataGridViewTextBoxColumn.HeaderText = "VT_IVA";
            this.vTIVADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vTIVADataGridViewTextBoxColumn.Name = "vTIVADataGridViewTextBoxColumn";
            this.vTIVADataGridViewTextBoxColumn.ReadOnly = true;
            this.vTIVADataGridViewTextBoxColumn.Width = 150;
            // 
            // BTNCANCELAR
            // 
            this.BTNCANCELAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCANCELAR.Location = new System.Drawing.Point(1102, 282);
            this.BTNCANCELAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(125, 51);
            this.BTNCANCELAR.TabIndex = 151;
            this.BTNCANCELAR.Text = "Cancelar";
            this.BTNCANCELAR.UseVisualStyleBackColor = false;
            this.BTNCANCELAR.Click += new System.EventHandler(this.BTNCANCELAR_Click);
            // 
            // VENTAS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1274, 692);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.CBCLIENTES);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXTIVA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTIMPORTE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTCANTIDAD);
            this.Controls.Add(this.BTNMENOS);
            this.Controls.Add(this.BTNMAS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBPRODUCTOS);
            this.Controls.Add(this.BTNBUSCARFOLIO);
            this.Controls.Add(this.BTNVENDER);
            this.Controls.Add(this.DATETIMEFECHA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTIDALMACEN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDPRO);
            this.Controls.Add(this.TXTMONTO);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TXTSERIE);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TXTFOLIO);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TXTISTIPODOCUMENTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VENTAS2";
            this.Text = "VENTAS2";
            this.Load += new System.EventHandler(this.VENTAS2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTADETTMPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTIDALMACEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IDPRO;
        private System.Windows.Forms.TextBox TXTMONTO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXTSERIE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXTFOLIO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXTISTIPODOCUMENTO;
        private System.Windows.Forms.DateTimePicker DATETIMEFECHA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTNVENDER;
        private System.Windows.Forms.Button BTNBUSCARFOLIO;
        private System.Windows.Forms.ComboBox CBPRODUCTOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNMAS;
        private System.Windows.Forms.Button BTNMENOS;
        private System.Windows.Forms.TextBox TXTCANTIDAD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTIMPORTE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTIVA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBCLIENTES;
        private dsVentas dsVentas;
        private System.Windows.Forms.BindingSource vENTADETTMPBindingSource;
        private dsVentasTableAdapters.VENTA_DET_TMPTableAdapter vENTA_DET_TMPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTFOLIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTSERIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTIDTIPODOCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTMONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTIDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTIDALMACENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTFECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTIDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTCANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTIMPORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTNCANCELAR;
    }
}