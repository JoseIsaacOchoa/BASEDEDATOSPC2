
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
            this.TXTIDPRODUCTO = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASDETALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "COMPRAS DTALLE";
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
            this.dataGridView1.DataSource = this.cOMPRASDETALLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(904, 189);
            this.dataGridView1.TabIndex = 50;
            // 
            // cDFOLIODataGridViewTextBoxColumn
            // 
            this.cDFOLIODataGridViewTextBoxColumn.DataPropertyName = "CD_FOLIO";
            this.cDFOLIODataGridViewTextBoxColumn.HeaderText = "CD_FOLIO";
            this.cDFOLIODataGridViewTextBoxColumn.Name = "cDFOLIODataGridViewTextBoxColumn";
            this.cDFOLIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDSERIEDataGridViewTextBoxColumn
            // 
            this.cDSERIEDataGridViewTextBoxColumn.DataPropertyName = "CD_SERIE";
            this.cDSERIEDataGridViewTextBoxColumn.HeaderText = "CD_SERIE";
            this.cDSERIEDataGridViewTextBoxColumn.Name = "cDSERIEDataGridViewTextBoxColumn";
            this.cDSERIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDIDTIPODOCTODataGridViewTextBoxColumn
            // 
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.DataPropertyName = "CD_ID_TIPODOCTO";
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.HeaderText = "CD_ID_TIPODOCTO";
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.Name = "cDIDTIPODOCTODataGridViewTextBoxColumn";
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.Width = 120;
            // 
            // cDIDPRODUCTODataGridViewTextBoxColumn
            // 
            this.cDIDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "CD_ID_PRODUCTO";
            this.cDIDPRODUCTODataGridViewTextBoxColumn.HeaderText = "CD_ID_PRODUCTO";
            this.cDIDPRODUCTODataGridViewTextBoxColumn.Name = "cDIDPRODUCTODataGridViewTextBoxColumn";
            this.cDIDPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cDIDPRODUCTODataGridViewTextBoxColumn.Width = 120;
            // 
            // cDCANTIDADDataGridViewTextBoxColumn
            // 
            this.cDCANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CD_CANTIDAD";
            this.cDCANTIDADDataGridViewTextBoxColumn.HeaderText = "CD_CANTIDAD";
            this.cDCANTIDADDataGridViewTextBoxColumn.Name = "cDCANTIDADDataGridViewTextBoxColumn";
            this.cDCANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDIMPORTEDataGridViewTextBoxColumn
            // 
            this.cDIMPORTEDataGridViewTextBoxColumn.DataPropertyName = "CD_IMPORTE";
            this.cDIMPORTEDataGridViewTextBoxColumn.HeaderText = "CD_IMPORTE";
            this.cDIMPORTEDataGridViewTextBoxColumn.Name = "cDIMPORTEDataGridViewTextBoxColumn";
            this.cDIMPORTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDIVADataGridViewTextBoxColumn
            // 
            this.cDIVADataGridViewTextBoxColumn.DataPropertyName = "CD_IVA";
            this.cDIVADataGridViewTextBoxColumn.HeaderText = "CD_IVA";
            this.cDIVADataGridViewTextBoxColumn.Name = "cDIVADataGridViewTextBoxColumn";
            this.cDIVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDUBICACIONDataGridViewTextBoxColumn
            // 
            this.cDUBICACIONDataGridViewTextBoxColumn.DataPropertyName = "CD_UBICACION";
            this.cDUBICACIONDataGridViewTextBoxColumn.HeaderText = "CD_UBICACION";
            this.cDUBICACIONDataGridViewTextBoxColumn.Name = "cDUBICACIONDataGridViewTextBoxColumn";
            this.cDUBICACIONDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.label15.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(104, 322);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 16);
            this.label15.TabIndex = 107;
            this.label15.Text = "SERIE";
            // 
            // TXTSERIE
            // 
            this.TXTSERIE.Location = new System.Drawing.Point(107, 341);
            this.TXTSERIE.Name = "TXTSERIE";
            this.TXTSERIE.Size = new System.Drawing.Size(125, 20);
            this.TXTSERIE.TabIndex = 106;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 322);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 105;
            this.label16.Text = "FOLIO";
            // 
            // TXTFOLIO
            // 
            this.TXTFOLIO.Location = new System.Drawing.Point(10, 341);
            this.TXTFOLIO.Name = "TXTFOLIO";
            this.TXTFOLIO.Size = new System.Drawing.Size(61, 20);
            this.TXTFOLIO.TabIndex = 104;
            this.TXTFOLIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFOLIO_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(249, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 16);
            this.label13.TabIndex = 103;
            this.label13.Text = "ID TIPO DOCUMENTO";
            // 
            // TXTISTIPODOCUMENTO
            // 
            this.TXTISTIPODOCUMENTO.Location = new System.Drawing.Point(252, 341);
            this.TXTISTIPODOCUMENTO.Name = "TXTISTIPODOCUMENTO";
            this.TXTISTIPODOCUMENTO.Size = new System.Drawing.Size(125, 20);
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
            this.IDPRO.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPRO.Location = new System.Drawing.Point(409, 322);
            this.IDPRO.Name = "IDPRO";
            this.IDPRO.Size = new System.Drawing.Size(106, 16);
            this.IDPRO.TabIndex = 109;
            this.IDPRO.Text = "ID PRODUCTO";
            // 
            // TXTIDPRODUCTO
            // 
            this.TXTIDPRODUCTO.Location = new System.Drawing.Point(412, 341);
            this.TXTIDPRODUCTO.Name = "TXTIDPRODUCTO";
            this.TXTIDPRODUCTO.Size = new System.Drawing.Size(125, 20);
            this.TXTIDPRODUCTO.TabIndex = 108;
            this.TXTIDPRODUCTO.TextChanged += new System.EventHandler(this.TXTIDPRODUCTO_TextChanged);
            this.TXTIDPRODUCTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDPRODUCTO_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "CANTIDAD";
            // 
            // TXTCANTIDAD
            // 
            this.TXTCANTIDAD.Location = new System.Drawing.Point(543, 341);
            this.TXTCANTIDAD.Name = "TXTCANTIDAD";
            this.TXTCANTIDAD.Size = new System.Drawing.Size(125, 20);
            this.TXTCANTIDAD.TabIndex = 110;
            this.TXTCANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCANTIDAD_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 113;
            this.label3.Text = "IMPORTE";
            // 
            // TXTIMPORTE
            // 
            this.TXTIMPORTE.Location = new System.Drawing.Point(674, 341);
            this.TXTIMPORTE.Name = "TXTIMPORTE";
            this.TXTIMPORTE.Size = new System.Drawing.Size(125, 20);
            this.TXTIMPORTE.TabIndex = 112;
            this.TXTIMPORTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIMPORTE_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 115;
            this.label4.Text = "IVA";
            // 
            // TXTIVA
            // 
            this.TXTIVA.Location = new System.Drawing.Point(10, 397);
            this.TXTIVA.Name = "TXTIVA";
            this.TXTIVA.Size = new System.Drawing.Size(125, 20);
            this.TXTIVA.TabIndex = 114;
            this.TXTIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIVA_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 117;
            this.label5.Text = "ID UBICACION";
            // 
            // TXTIDUBICACION
            // 
            this.TXTIDUBICACION.Location = new System.Drawing.Point(157, 397);
            this.TXTIDUBICACION.Name = "TXTIDUBICACION";
            this.TXTIDUBICACION.Size = new System.Drawing.Size(125, 20);
            this.TXTIDUBICACION.TabIndex = 116;
            this.TXTIDUBICACION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDUBICACION_KeyPress);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(506, 262);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(88, 49);
            this.BTNELIMINAR.TabIndex = 137;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.LightGreen;
            this.BTNGUARDAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.Color.Black;
            this.BTNGUARDAR.Location = new System.Drawing.Point(412, 262);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(88, 49);
            this.BTNGUARDAR.TabIndex = 136;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.BackColor = System.Drawing.Color.Gold;
            this.BTNBUSCAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.ForeColor = System.Drawing.Color.Black;
            this.BTNBUSCAR.Location = new System.Drawing.Point(318, 262);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(88, 49);
            this.BTNBUSCAR.TabIndex = 135;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = false;
            // 
            // COMPRA_DETALLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(925, 450);
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
            this.Controls.Add(this.TXTIDPRODUCTO);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TXTSERIE);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TXTFOLIO);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TXTISTIPODOCUMENTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "COMPRA_DETALLE";
            this.Text = "COMPRA_DETALLE";
            this.Load += new System.EventHandler(this.COMPRA_DETALLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASDETALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet3)).EndInit();
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
        private System.Windows.Forms.TextBox TXTIDPRODUCTO;
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
    }
}