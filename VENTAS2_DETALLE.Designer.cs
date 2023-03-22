
namespace BASEDEDATOSPC2
{
    partial class VENTAS2_DETALLE
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
            this.vDFOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDSERIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDIDTIPODOCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDIDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDCANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDIMPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENTASDETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet4 = new BASEDEDATOSPC2.VENTASDataSet4();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTIVA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTIMPORTE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTCANTIDAD = new System.Windows.Forms.TextBox();
            this.IDPRO = new System.Windows.Forms.Label();
            this.TXTIDPRODUCTO = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TXTSERIE = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TXTFOLIO = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXTISTIPODOCUMENTO = new System.Windows.Forms.TextBox();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.vENTAS_DETALLETableAdapter = new BASEDEDATOSPC2.VENTASDataSet4TableAdapters.VENTAS_DETALLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDETALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "VENTAS DETALLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vDFOLIODataGridViewTextBoxColumn,
            this.vDSERIEDataGridViewTextBoxColumn,
            this.vDIDTIPODOCTODataGridViewTextBoxColumn,
            this.vDIDPRODUCTODataGridViewTextBoxColumn,
            this.vDCANTIDADDataGridViewTextBoxColumn,
            this.vDIMPORTEDataGridViewTextBoxColumn,
            this.vDIVADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vENTASDETALLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 189);
            this.dataGridView1.TabIndex = 47;
            // 
            // vDFOLIODataGridViewTextBoxColumn
            // 
            this.vDFOLIODataGridViewTextBoxColumn.DataPropertyName = "VD_FOLIO";
            this.vDFOLIODataGridViewTextBoxColumn.HeaderText = "VD_FOLIO";
            this.vDFOLIODataGridViewTextBoxColumn.Name = "vDFOLIODataGridViewTextBoxColumn";
            this.vDFOLIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDSERIEDataGridViewTextBoxColumn
            // 
            this.vDSERIEDataGridViewTextBoxColumn.DataPropertyName = "VD_SERIE";
            this.vDSERIEDataGridViewTextBoxColumn.HeaderText = "VD_SERIE";
            this.vDSERIEDataGridViewTextBoxColumn.Name = "vDSERIEDataGridViewTextBoxColumn";
            this.vDSERIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDIDTIPODOCTODataGridViewTextBoxColumn
            // 
            this.vDIDTIPODOCTODataGridViewTextBoxColumn.DataPropertyName = "VD_ID_TIPODOCTO";
            this.vDIDTIPODOCTODataGridViewTextBoxColumn.HeaderText = "VD_ID_TIPODOCTO";
            this.vDIDTIPODOCTODataGridViewTextBoxColumn.Name = "vDIDTIPODOCTODataGridViewTextBoxColumn";
            this.vDIDTIPODOCTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDIDPRODUCTODataGridViewTextBoxColumn
            // 
            this.vDIDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "VD_ID_PRODUCTO";
            this.vDIDPRODUCTODataGridViewTextBoxColumn.HeaderText = "VD_ID_PRODUCTO";
            this.vDIDPRODUCTODataGridViewTextBoxColumn.Name = "vDIDPRODUCTODataGridViewTextBoxColumn";
            this.vDIDPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDCANTIDADDataGridViewTextBoxColumn
            // 
            this.vDCANTIDADDataGridViewTextBoxColumn.DataPropertyName = "VD_CANTIDAD";
            this.vDCANTIDADDataGridViewTextBoxColumn.HeaderText = "VD_CANTIDAD";
            this.vDCANTIDADDataGridViewTextBoxColumn.Name = "vDCANTIDADDataGridViewTextBoxColumn";
            this.vDCANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDIMPORTEDataGridViewTextBoxColumn
            // 
            this.vDIMPORTEDataGridViewTextBoxColumn.DataPropertyName = "VD_IMPORTE";
            this.vDIMPORTEDataGridViewTextBoxColumn.HeaderText = "VD_IMPORTE";
            this.vDIMPORTEDataGridViewTextBoxColumn.Name = "vDIMPORTEDataGridViewTextBoxColumn";
            this.vDIMPORTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDIVADataGridViewTextBoxColumn
            // 
            this.vDIVADataGridViewTextBoxColumn.DataPropertyName = "VD_IVA";
            this.vDIVADataGridViewTextBoxColumn.HeaderText = "VD_IVA";
            this.vDIVADataGridViewTextBoxColumn.Name = "vDIVADataGridViewTextBoxColumn";
            this.vDIVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vENTASDETALLEBindingSource
            // 
            this.vENTASDETALLEBindingSource.DataMember = "VENTAS_DETALLE";
            this.vENTASDETALLEBindingSource.DataSource = this.vENTASDataSet4;
            // 
            // vENTASDataSet4
            // 
            this.vENTASDataSet4.DataSetName = "VENTASDataSet4";
            this.vENTASDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 131;
            this.label4.Text = "IVA";
            // 
            // TXTIVA
            // 
            this.TXTIVA.Location = new System.Drawing.Point(10, 417);
            this.TXTIVA.Name = "TXTIVA";
            this.TXTIVA.Size = new System.Drawing.Size(125, 20);
            this.TXTIVA.TabIndex = 130;
            this.TXTIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIVA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 129;
            this.label3.Text = "IMPORTE";
            // 
            // TXTIMPORTE
            // 
            this.TXTIMPORTE.Location = new System.Drawing.Point(674, 361);
            this.TXTIMPORTE.Name = "TXTIMPORTE";
            this.TXTIMPORTE.Size = new System.Drawing.Size(125, 20);
            this.TXTIMPORTE.TabIndex = 128;
            this.TXTIMPORTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIMPORTE_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 127;
            this.label2.Text = "CANTIDAD";
            // 
            // TXTCANTIDAD
            // 
            this.TXTCANTIDAD.Location = new System.Drawing.Point(543, 361);
            this.TXTCANTIDAD.Name = "TXTCANTIDAD";
            this.TXTCANTIDAD.Size = new System.Drawing.Size(125, 20);
            this.TXTCANTIDAD.TabIndex = 126;
            this.TXTCANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCANTIDAD_KeyPress);
            // 
            // IDPRO
            // 
            this.IDPRO.AutoSize = true;
            this.IDPRO.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPRO.Location = new System.Drawing.Point(409, 342);
            this.IDPRO.Name = "IDPRO";
            this.IDPRO.Size = new System.Drawing.Size(106, 16);
            this.IDPRO.TabIndex = 125;
            this.IDPRO.Text = "ID PRODUCTO";
            // 
            // TXTIDPRODUCTO
            // 
            this.TXTIDPRODUCTO.Location = new System.Drawing.Point(412, 361);
            this.TXTIDPRODUCTO.Name = "TXTIDPRODUCTO";
            this.TXTIDPRODUCTO.Size = new System.Drawing.Size(125, 20);
            this.TXTIDPRODUCTO.TabIndex = 124;
            this.TXTIDPRODUCTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDPRODUCTO_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(104, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 16);
            this.label15.TabIndex = 123;
            this.label15.Text = "SERIE";
            // 
            // TXTSERIE
            // 
            this.TXTSERIE.Location = new System.Drawing.Point(107, 361);
            this.TXTSERIE.Name = "TXTSERIE";
            this.TXTSERIE.Size = new System.Drawing.Size(125, 20);
            this.TXTSERIE.TabIndex = 122;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 342);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 121;
            this.label16.Text = "FOLIO";
            // 
            // TXTFOLIO
            // 
            this.TXTFOLIO.Location = new System.Drawing.Point(10, 361);
            this.TXTFOLIO.Name = "TXTFOLIO";
            this.TXTFOLIO.Size = new System.Drawing.Size(61, 20);
            this.TXTFOLIO.TabIndex = 120;
            this.TXTFOLIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFOLIO_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(249, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 16);
            this.label13.TabIndex = 119;
            this.label13.Text = "ID TIPO DOCUMENTO";
            // 
            // TXTISTIPODOCUMENTO
            // 
            this.TXTISTIPODOCUMENTO.Location = new System.Drawing.Point(252, 361);
            this.TXTISTIPODOCUMENTO.Name = "TXTISTIPODOCUMENTO";
            this.TXTISTIPODOCUMENTO.Size = new System.Drawing.Size(125, 20);
            this.TXTISTIPODOCUMENTO.TabIndex = 118;
            this.TXTISTIPODOCUMENTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTISTIPODOCUMENTO_KeyPress);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(449, 277);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(88, 49);
            this.BTNELIMINAR.TabIndex = 134;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.LightGreen;
            this.BTNGUARDAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.Color.Black;
            this.BTNGUARDAR.Location = new System.Drawing.Point(355, 277);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(88, 49);
            this.BTNGUARDAR.TabIndex = 133;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.BackColor = System.Drawing.Color.Gold;
            this.BTNBUSCAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.ForeColor = System.Drawing.Color.Black;
            this.BTNBUSCAR.Location = new System.Drawing.Point(261, 277);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(88, 49);
            this.BTNBUSCAR.TabIndex = 132;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = false;
            // 
            // vENTAS_DETALLETableAdapter
            // 
            this.vENTAS_DETALLETableAdapter.ClearBeforeFill = true;
            // 
            // VENTAS2_DETALLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTIVA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTIMPORTE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTCANTIDAD);
            this.Controls.Add(this.IDPRO);
            this.Controls.Add(this.TXTIDPRODUCTO);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TXTSERIE);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TXTFOLIO);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TXTISTIPODOCUMENTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VENTAS2_DETALLE";
            this.Text = "VENTAS2_DETALLE";
            this.Load += new System.EventHandler(this.VENTAS2_DETALLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDETALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTIVA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTIMPORTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTCANTIDAD;
        private System.Windows.Forms.Label IDPRO;
        private System.Windows.Forms.TextBox TXTIDPRODUCTO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXTSERIE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXTFOLIO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXTISTIPODOCUMENTO;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNBUSCAR;
        private VENTASDataSet4 vENTASDataSet4;
        private System.Windows.Forms.BindingSource vENTASDETALLEBindingSource;
        private VENTASDataSet4TableAdapters.VENTAS_DETALLETableAdapter vENTAS_DETALLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDFOLIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDSERIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDIDTIPODOCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDIDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDCANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDIMPORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDIVADataGridViewTextBoxColumn;
    }
}