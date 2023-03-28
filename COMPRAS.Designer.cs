
namespace BASEDEDATOSPC2
{
    partial class COMPRAS
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
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cOMPRASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCompras = new BASEDEDATOSPC2.dsCompras();
            this.label3 = new System.Windows.Forms.Label();
            this.DATETIMEFECHA = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTFACTURA = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TXTSERIE = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TXTFOLIO = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXTISTIPODOCUMENTO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTMONTO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CBPROVEEDOR = new System.Windows.Forms.ComboBox();
            this.CBALMACEN = new System.Windows.Forms.ComboBox();
            this.cOMPRASTableAdapter = new BASEDEDATOSPC2.dsComprasTableAdapters.COMPRASTableAdapter();
            this.CBPRODUCTOS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTIMPORTE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTCANTIDAD = new System.Windows.Forms.TextBox();
            this.IDPRO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTIDUBICACION = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTIVA = new System.Windows.Forms.TextBox();
            this.dsComprasTemporal = new BASEDEDATOSPC2.dsComprasTemporal();
            this.cOMPRADETTMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPRA_DET_TMPTableAdapter = new BASEDEDATOSPC2.dsComprasTemporalTableAdapters.COMPRA_DET_TMPTableAdapter();
            this.cTFOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTSERIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTIDTIPODOCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTMONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTIDPROVEEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTIDALMACENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTFACTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTFECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTIDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTCANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTIMPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTUBICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNMENOS = new System.Windows.Forms.Button();
            this.BTNMAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprasTemporal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRADETTMPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(1797, 406);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(114, 53);
            this.BTNELIMINAR.TabIndex = 17;
            this.BTNELIMINAR.Text = "Cancelar";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.LightGreen;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.Color.Black;
            this.BTNGUARDAR.Location = new System.Drawing.Point(658, 406);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(132, 75);
            this.BTNGUARDAR.TabIndex = 15;
            this.BTNGUARDAR.Text = "Comprar";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.BackColor = System.Drawing.Color.Silver;
            this.BTNBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.ForeColor = System.Drawing.Color.Black;
            this.BTNBUSCAR.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_búsqueda_24;
            this.BTNBUSCAR.Location = new System.Drawing.Point(148, 536);
            this.BTNBUSCAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(44, 41);
            this.BTNBUSCAR.TabIndex = 16;
            this.BTNBUSCAR.UseVisualStyleBackColor = false;
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(898, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 47);
            this.label1.TabIndex = 46;
            this.label1.Text = "COMPRAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTFOLIODataGridViewTextBoxColumn,
            this.cTSERIEDataGridViewTextBoxColumn,
            this.cTIDTIPODOCTODataGridViewTextBoxColumn,
            this.cTMONTODataGridViewTextBoxColumn,
            this.cTIDPROVEEDORDataGridViewTextBoxColumn,
            this.cTIDALMACENDataGridViewTextBoxColumn,
            this.cTFACTURADataGridViewTextBoxColumn,
            this.cTFECHADataGridViewTextBoxColumn,
            this.cTIDPRODUCTODataGridViewTextBoxColumn,
            this.cTCANTIDADDataGridViewTextBoxColumn,
            this.cTIMPORTEDataGridViewTextBoxColumn,
            this.cTIVADataGridViewTextBoxColumn,
            this.cTUBICACIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOMPRADETTMPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1918, 291);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // cOMPRASBindingSource
            // 
            this.cOMPRASBindingSource.DataMember = "COMPRAS";
            this.cOMPRASBindingSource.DataSource = this.dsCompras;
            // 
            // dsCompras
            // 
            this.dsCompras.DataSetName = "dsCompras";
            this.dsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1542, 514);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 86;
            this.label3.Text = "FECHA";
            // 
            // DATETIMEFECHA
            // 
            this.DATETIMEFECHA.Location = new System.Drawing.Point(1546, 543);
            this.DATETIMEFECHA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DATETIMEFECHA.Name = "DATETIMEFECHA";
            this.DATETIMEFECHA.Size = new System.Drawing.Size(298, 26);
            this.DATETIMEFECHA.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1340, 514);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 103;
            this.label2.Text = "FACTURA";
            // 
            // TXTFACTURA
            // 
            this.TXTFACTURA.Location = new System.Drawing.Point(1345, 543);
            this.TXTFACTURA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTFACTURA.Name = "TXTFACTURA";
            this.TXTFACTURA.Size = new System.Drawing.Size(186, 26);
            this.TXTFACTURA.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(196, 514);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 25);
            this.label15.TabIndex = 101;
            this.label15.Text = "SERIE";
            // 
            // TXTSERIE
            // 
            this.TXTSERIE.Location = new System.Drawing.Point(200, 543);
            this.TXTSERIE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTSERIE.Name = "TXTSERIE";
            this.TXTSERIE.Size = new System.Drawing.Size(186, 26);
            this.TXTSERIE.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(50, 514);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 25);
            this.label16.TabIndex = 99;
            this.label16.Text = "FOLIO";
            // 
            // TXTFOLIO
            // 
            this.TXTFOLIO.Location = new System.Drawing.Point(54, 543);
            this.TXTFOLIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTFOLIO.Name = "TXTFOLIO";
            this.TXTFOLIO.Size = new System.Drawing.Size(90, 26);
            this.TXTFOLIO.TabIndex = 0;
            this.TXTFOLIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFOLIO_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(413, 514);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 25);
            this.label13.TabIndex = 97;
            this.label13.Text = "ID TIPO DOCUMENTO";
            // 
            // TXTISTIPODOCUMENTO
            // 
            this.TXTISTIPODOCUMENTO.Location = new System.Drawing.Point(418, 543);
            this.TXTISTIPODOCUMENTO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTISTIPODOCUMENTO.Name = "TXTISTIPODOCUMENTO";
            this.TXTISTIPODOCUMENTO.Size = new System.Drawing.Size(186, 26);
            this.TXTISTIPODOCUMENTO.TabIndex = 2;
            this.TXTISTIPODOCUMENTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTISTIPODOCUMENTO_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(674, 514);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 95;
            this.label12.Text = "MONTO";
            // 
            // TXTMONTO
            // 
            this.TXTMONTO.Location = new System.Drawing.Point(678, 543);
            this.TXTMONTO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTMONTO.Name = "TXTMONTO";
            this.TXTMONTO.Size = new System.Drawing.Size(186, 26);
            this.TXTMONTO.TabIndex = 3;
            this.TXTMONTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTMONTO_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(900, 514);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 25);
            this.label11.TabIndex = 93;
            this.label11.Text = "ID PROVEEDOR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1116, 514);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 91;
            this.label10.Text = "ALMACEN";
            // 
            // CBPROVEEDOR
            // 
            this.CBPROVEEDOR.FormattingEnabled = true;
            this.CBPROVEEDOR.Location = new System.Drawing.Point(905, 545);
            this.CBPROVEEDOR.Name = "CBPROVEEDOR";
            this.CBPROVEEDOR.Size = new System.Drawing.Size(185, 28);
            this.CBPROVEEDOR.TabIndex = 4;
            // 
            // CBALMACEN
            // 
            this.CBALMACEN.FormattingEnabled = true;
            this.CBALMACEN.Location = new System.Drawing.Point(1121, 545);
            this.CBALMACEN.Name = "CBALMACEN";
            this.CBALMACEN.Size = new System.Drawing.Size(185, 28);
            this.CBALMACEN.TabIndex = 5;
            // 
            // cOMPRASTableAdapter
            // 
            this.cOMPRASTableAdapter.ClearBeforeFill = true;
            // 
            // CBPRODUCTOS
            // 
            this.CBPRODUCTOS.FormattingEnabled = true;
            this.CBPRODUCTOS.Location = new System.Drawing.Point(53, 628);
            this.CBPRODUCTOS.Name = "CBPRODUCTOS";
            this.CBPRODUCTOS.Size = new System.Drawing.Size(186, 28);
            this.CBPRODUCTOS.TabIndex = 144;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 598);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 143;
            this.label4.Text = "IMPORTE";
            // 
            // TXTIMPORTE
            // 
            this.TXTIMPORTE.Location = new System.Drawing.Point(446, 628);
            this.TXTIMPORTE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIMPORTE.Name = "TXTIMPORTE";
            this.TXTIMPORTE.Size = new System.Drawing.Size(186, 26);
            this.TXTIMPORTE.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 598);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 141;
            this.label5.Text = "CANTIDAD";
            // 
            // TXTCANTIDAD
            // 
            this.TXTCANTIDAD.Location = new System.Drawing.Point(249, 628);
            this.TXTCANTIDAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTCANTIDAD.Name = "TXTCANTIDAD";
            this.TXTCANTIDAD.Size = new System.Drawing.Size(186, 26);
            this.TXTCANTIDAD.TabIndex = 140;
            // 
            // IDPRO
            // 
            this.IDPRO.AutoSize = true;
            this.IDPRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPRO.Location = new System.Drawing.Point(49, 598);
            this.IDPRO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDPRO.Name = "IDPRO";
            this.IDPRO.Size = new System.Drawing.Size(134, 25);
            this.IDPRO.TabIndex = 139;
            this.IDPRO.Text = "PRODUCTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(874, 599);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 148;
            this.label6.Text = "ID UBICACION";
            // 
            // TXTIDUBICACION
            // 
            this.TXTIDUBICACION.Location = new System.Drawing.Point(879, 628);
            this.TXTIDUBICACION.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIDUBICACION.Name = "TXTIDUBICACION";
            this.TXTIDUBICACION.Size = new System.Drawing.Size(186, 26);
            this.TXTIDUBICACION.TabIndex = 147;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(661, 599);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 146;
            this.label7.Text = "IVA";
            // 
            // TXTIVA
            // 
            this.TXTIVA.Location = new System.Drawing.Point(658, 628);
            this.TXTIVA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIVA.Name = "TXTIVA";
            this.TXTIVA.Size = new System.Drawing.Size(186, 26);
            this.TXTIVA.TabIndex = 145;
            // 
            // dsComprasTemporal
            // 
            this.dsComprasTemporal.DataSetName = "dsComprasTemporal";
            this.dsComprasTemporal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPRADETTMPBindingSource
            // 
            this.cOMPRADETTMPBindingSource.DataMember = "COMPRA_DET_TMP";
            this.cOMPRADETTMPBindingSource.DataSource = this.dsComprasTemporal;
            // 
            // cOMPRA_DET_TMPTableAdapter
            // 
            this.cOMPRA_DET_TMPTableAdapter.ClearBeforeFill = true;
            // 
            // cTFOLIODataGridViewTextBoxColumn
            // 
            this.cTFOLIODataGridViewTextBoxColumn.DataPropertyName = "CT_FOLIO";
            this.cTFOLIODataGridViewTextBoxColumn.HeaderText = "CT_FOLIO";
            this.cTFOLIODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTFOLIODataGridViewTextBoxColumn.Name = "cTFOLIODataGridViewTextBoxColumn";
            this.cTFOLIODataGridViewTextBoxColumn.ReadOnly = true;
            this.cTFOLIODataGridViewTextBoxColumn.Width = 150;
            // 
            // cTSERIEDataGridViewTextBoxColumn
            // 
            this.cTSERIEDataGridViewTextBoxColumn.DataPropertyName = "CT_SERIE";
            this.cTSERIEDataGridViewTextBoxColumn.HeaderText = "CT_SERIE";
            this.cTSERIEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTSERIEDataGridViewTextBoxColumn.Name = "cTSERIEDataGridViewTextBoxColumn";
            this.cTSERIEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTSERIEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cTIDTIPODOCTODataGridViewTextBoxColumn
            // 
            this.cTIDTIPODOCTODataGridViewTextBoxColumn.DataPropertyName = "CT_ID_TIPODOCTO";
            this.cTIDTIPODOCTODataGridViewTextBoxColumn.HeaderText = "CT_ID_TIPODOCTO";
            this.cTIDTIPODOCTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTIDTIPODOCTODataGridViewTextBoxColumn.Name = "cTIDTIPODOCTODataGridViewTextBoxColumn";
            this.cTIDTIPODOCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cTIDTIPODOCTODataGridViewTextBoxColumn.Width = 150;
            // 
            // cTMONTODataGridViewTextBoxColumn
            // 
            this.cTMONTODataGridViewTextBoxColumn.DataPropertyName = "CT_MONTO";
            this.cTMONTODataGridViewTextBoxColumn.HeaderText = "CT_MONTO";
            this.cTMONTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTMONTODataGridViewTextBoxColumn.Name = "cTMONTODataGridViewTextBoxColumn";
            this.cTMONTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cTMONTODataGridViewTextBoxColumn.Width = 150;
            // 
            // cTIDPROVEEDORDataGridViewTextBoxColumn
            // 
            this.cTIDPROVEEDORDataGridViewTextBoxColumn.DataPropertyName = "CT_ID_PROVEEDOR";
            this.cTIDPROVEEDORDataGridViewTextBoxColumn.HeaderText = "CT_ID_PROVEEDOR";
            this.cTIDPROVEEDORDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTIDPROVEEDORDataGridViewTextBoxColumn.Name = "cTIDPROVEEDORDataGridViewTextBoxColumn";
            this.cTIDPROVEEDORDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTIDPROVEEDORDataGridViewTextBoxColumn.Width = 150;
            // 
            // cTIDALMACENDataGridViewTextBoxColumn
            // 
            this.cTIDALMACENDataGridViewTextBoxColumn.DataPropertyName = "CT_ID_ALMACEN";
            this.cTIDALMACENDataGridViewTextBoxColumn.HeaderText = "CT_ID_ALMACEN";
            this.cTIDALMACENDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTIDALMACENDataGridViewTextBoxColumn.Name = "cTIDALMACENDataGridViewTextBoxColumn";
            this.cTIDALMACENDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTIDALMACENDataGridViewTextBoxColumn.Width = 150;
            // 
            // cTFACTURADataGridViewTextBoxColumn
            // 
            this.cTFACTURADataGridViewTextBoxColumn.DataPropertyName = "CT_FACTURA";
            this.cTFACTURADataGridViewTextBoxColumn.HeaderText = "CT_FACTURA";
            this.cTFACTURADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTFACTURADataGridViewTextBoxColumn.Name = "cTFACTURADataGridViewTextBoxColumn";
            this.cTFACTURADataGridViewTextBoxColumn.ReadOnly = true;
            this.cTFACTURADataGridViewTextBoxColumn.Width = 150;
            // 
            // cTFECHADataGridViewTextBoxColumn
            // 
            this.cTFECHADataGridViewTextBoxColumn.DataPropertyName = "CT_FECHA";
            this.cTFECHADataGridViewTextBoxColumn.HeaderText = "CT_FECHA";
            this.cTFECHADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTFECHADataGridViewTextBoxColumn.Name = "cTFECHADataGridViewTextBoxColumn";
            this.cTFECHADataGridViewTextBoxColumn.ReadOnly = true;
            this.cTFECHADataGridViewTextBoxColumn.Width = 150;
            // 
            // cTIDPRODUCTODataGridViewTextBoxColumn
            // 
            this.cTIDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "CT_ID_PRODUCTO";
            this.cTIDPRODUCTODataGridViewTextBoxColumn.HeaderText = "CT_ID_PRODUCTO";
            this.cTIDPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTIDPRODUCTODataGridViewTextBoxColumn.Name = "cTIDPRODUCTODataGridViewTextBoxColumn";
            this.cTIDPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cTIDPRODUCTODataGridViewTextBoxColumn.Width = 150;
            // 
            // cTCANTIDADDataGridViewTextBoxColumn
            // 
            this.cTCANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CT_CANTIDAD";
            this.cTCANTIDADDataGridViewTextBoxColumn.HeaderText = "CT_CANTIDAD";
            this.cTCANTIDADDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTCANTIDADDataGridViewTextBoxColumn.Name = "cTCANTIDADDataGridViewTextBoxColumn";
            this.cTCANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTCANTIDADDataGridViewTextBoxColumn.Width = 150;
            // 
            // cTIMPORTEDataGridViewTextBoxColumn
            // 
            this.cTIMPORTEDataGridViewTextBoxColumn.DataPropertyName = "CT_IMPORTE";
            this.cTIMPORTEDataGridViewTextBoxColumn.HeaderText = "CT_IMPORTE";
            this.cTIMPORTEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTIMPORTEDataGridViewTextBoxColumn.Name = "cTIMPORTEDataGridViewTextBoxColumn";
            this.cTIMPORTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTIMPORTEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cTIVADataGridViewTextBoxColumn
            // 
            this.cTIVADataGridViewTextBoxColumn.DataPropertyName = "CT_IVA";
            this.cTIVADataGridViewTextBoxColumn.HeaderText = "CT_IVA";
            this.cTIVADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTIVADataGridViewTextBoxColumn.Name = "cTIVADataGridViewTextBoxColumn";
            this.cTIVADataGridViewTextBoxColumn.ReadOnly = true;
            this.cTIVADataGridViewTextBoxColumn.Width = 150;
            // 
            // cTUBICACIONDataGridViewTextBoxColumn
            // 
            this.cTUBICACIONDataGridViewTextBoxColumn.DataPropertyName = "CT_UBICACION";
            this.cTUBICACIONDataGridViewTextBoxColumn.HeaderText = "CT_UBICACION";
            this.cTUBICACIONDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cTUBICACIONDataGridViewTextBoxColumn.Name = "cTUBICACIONDataGridViewTextBoxColumn";
            this.cTUBICACIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTUBICACIONDataGridViewTextBoxColumn.Width = 150;
            // 
            // BTNMENOS
            // 
            this.BTNMENOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNMENOS.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_menos_24;
            this.BTNMENOS.Location = new System.Drawing.Point(1155, 616);
            this.BTNMENOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNMENOS.Name = "BTNMENOS";
            this.BTNMENOS.Size = new System.Drawing.Size(74, 51);
            this.BTNMENOS.TabIndex = 150;
            this.BTNMENOS.UseVisualStyleBackColor = false;
            this.BTNMENOS.Click += new System.EventHandler(this.BTNMENOS_Click);
            // 
            // BTNMAS
            // 
            this.BTNMAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNMAS.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_más_26;
            this.BTNMAS.Location = new System.Drawing.Point(1073, 616);
            this.BTNMAS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNMAS.Name = "BTNMAS";
            this.BTNMAS.Size = new System.Drawing.Size(74, 51);
            this.BTNMAS.TabIndex = 149;
            this.BTNMAS.UseVisualStyleBackColor = false;
            this.BTNMAS.Click += new System.EventHandler(this.BTNMAS_Click);
            // 
            // COMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1924, 692);
            this.Controls.Add(this.BTNMENOS);
            this.Controls.Add(this.BTNMAS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTIDUBICACION);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTIVA);
            this.Controls.Add(this.CBPRODUCTOS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTIMPORTE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTCANTIDAD);
            this.Controls.Add(this.IDPRO);
            this.Controls.Add(this.CBALMACEN);
            this.Controls.Add(this.CBPROVEEDOR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTFACTURA);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TXTSERIE);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TXTFOLIO);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TXTISTIPODOCUMENTO);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TXTMONTO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DATETIMEFECHA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "COMPRAS";
            this.Text = "COMPRAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.COMPRAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComprasTemporal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRADETTMPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DATETIMEFECHA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTFACTURA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXTSERIE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXTFOLIO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXTISTIPODOCUMENTO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXTMONTO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBPROVEEDOR;
        private System.Windows.Forms.ComboBox CBALMACEN;
        private dsCompras dsCompras;
        private System.Windows.Forms.BindingSource cOMPRASBindingSource;
        private dsComprasTableAdapters.COMPRASTableAdapter cOMPRASTableAdapter;
        private System.Windows.Forms.ComboBox CBPRODUCTOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTIMPORTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTCANTIDAD;
        private System.Windows.Forms.Label IDPRO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTIDUBICACION;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTIVA;
        private dsComprasTemporal dsComprasTemporal;
        private System.Windows.Forms.BindingSource cOMPRADETTMPBindingSource;
        private dsComprasTemporalTableAdapters.COMPRA_DET_TMPTableAdapter cOMPRA_DET_TMPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTFOLIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTSERIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTIDTIPODOCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTMONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTIDPROVEEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTIDALMACENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTFACTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTFECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTIDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTCANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTIMPORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTUBICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTNMENOS;
        private System.Windows.Forms.Button BTNMAS;
    }
}