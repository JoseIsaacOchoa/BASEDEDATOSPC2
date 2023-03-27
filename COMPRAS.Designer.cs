
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
            this.cOFOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSERIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOIDTIPODOCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOIDPROVEEDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOIDALMACENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOFACTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOFECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(1102, 405);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(132, 75);
            this.BTNELIMINAR.TabIndex = 17;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.LightGreen;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.Color.Black;
            this.BTNGUARDAR.Location = new System.Drawing.Point(962, 405);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(132, 75);
            this.BTNGUARDAR.TabIndex = 15;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.BackColor = System.Drawing.Color.Gold;
            this.BTNBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.ForeColor = System.Drawing.Color.Black;
            this.BTNBUSCAR.Location = new System.Drawing.Point(820, 405);
            this.BTNBUSCAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(132, 75);
            this.BTNBUSCAR.TabIndex = 16;
            this.BTNBUSCAR.Text = "Buscar";
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
            this.cOFOLIODataGridViewTextBoxColumn,
            this.cOSERIEDataGridViewTextBoxColumn,
            this.cOIDTIPODOCTODataGridViewTextBoxColumn,
            this.cOMONTODataGridViewTextBoxColumn,
            this.cOIDPROVEEDORDataGridViewTextBoxColumn,
            this.cOIDALMACENDataGridViewTextBoxColumn,
            this.cOFACTURADataGridViewTextBoxColumn,
            this.cOFECHADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOMPRASBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1918, 291);
            this.dataGridView1.TabIndex = 45;
            // 
            // cOFOLIODataGridViewTextBoxColumn
            // 
            this.cOFOLIODataGridViewTextBoxColumn.DataPropertyName = "CO_FOLIO";
            this.cOFOLIODataGridViewTextBoxColumn.HeaderText = "CO_FOLIO";
            this.cOFOLIODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cOFOLIODataGridViewTextBoxColumn.Name = "cOFOLIODataGridViewTextBoxColumn";
            this.cOFOLIODataGridViewTextBoxColumn.ReadOnly = true;
            this.cOFOLIODataGridViewTextBoxColumn.Width = 150;
            // 
            // cOSERIEDataGridViewTextBoxColumn
            // 
            this.cOSERIEDataGridViewTextBoxColumn.DataPropertyName = "CO_SERIE";
            this.cOSERIEDataGridViewTextBoxColumn.HeaderText = "CO_SERIE";
            this.cOSERIEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cOSERIEDataGridViewTextBoxColumn.Name = "cOSERIEDataGridViewTextBoxColumn";
            this.cOSERIEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOSERIEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cOIDTIPODOCTODataGridViewTextBoxColumn
            // 
            this.cOIDTIPODOCTODataGridViewTextBoxColumn.DataPropertyName = "CO_ID_TIPODOCTO";
            this.cOIDTIPODOCTODataGridViewTextBoxColumn.HeaderText = "CO_ID_TIPODOCTO";
            this.cOIDTIPODOCTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cOIDTIPODOCTODataGridViewTextBoxColumn.Name = "cOIDTIPODOCTODataGridViewTextBoxColumn";
            this.cOIDTIPODOCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cOIDTIPODOCTODataGridViewTextBoxColumn.Width = 150;
            // 
            // cOMONTODataGridViewTextBoxColumn
            // 
            this.cOMONTODataGridViewTextBoxColumn.DataPropertyName = "CO_MONTO";
            this.cOMONTODataGridViewTextBoxColumn.HeaderText = "CO_MONTO";
            this.cOMONTODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cOMONTODataGridViewTextBoxColumn.Name = "cOMONTODataGridViewTextBoxColumn";
            this.cOMONTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMONTODataGridViewTextBoxColumn.Width = 150;
            // 
            // cOIDPROVEEDORDataGridViewTextBoxColumn
            // 
            this.cOIDPROVEEDORDataGridViewTextBoxColumn.DataPropertyName = "CO_ID_PROVEEDOR";
            this.cOIDPROVEEDORDataGridViewTextBoxColumn.HeaderText = "CO_ID_PROVEEDOR";
            this.cOIDPROVEEDORDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cOIDPROVEEDORDataGridViewTextBoxColumn.Name = "cOIDPROVEEDORDataGridViewTextBoxColumn";
            this.cOIDPROVEEDORDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOIDPROVEEDORDataGridViewTextBoxColumn.Width = 150;
            // 
            // cOIDALMACENDataGridViewTextBoxColumn
            // 
            this.cOIDALMACENDataGridViewTextBoxColumn.DataPropertyName = "CO_ID_ALMACEN";
            this.cOIDALMACENDataGridViewTextBoxColumn.HeaderText = "CO_ID_ALMACEN";
            this.cOIDALMACENDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cOIDALMACENDataGridViewTextBoxColumn.Name = "cOIDALMACENDataGridViewTextBoxColumn";
            this.cOIDALMACENDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOIDALMACENDataGridViewTextBoxColumn.Width = 150;
            // 
            // cOFACTURADataGridViewTextBoxColumn
            // 
            this.cOFACTURADataGridViewTextBoxColumn.DataPropertyName = "CO_FACTURA";
            this.cOFACTURADataGridViewTextBoxColumn.HeaderText = "CO_FACTURA";
            this.cOFACTURADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cOFACTURADataGridViewTextBoxColumn.Name = "cOFACTURADataGridViewTextBoxColumn";
            this.cOFACTURADataGridViewTextBoxColumn.ReadOnly = true;
            this.cOFACTURADataGridViewTextBoxColumn.Width = 150;
            // 
            // cOFECHADataGridViewTextBoxColumn
            // 
            this.cOFECHADataGridViewTextBoxColumn.DataPropertyName = "CO_FECHA";
            this.cOFECHADataGridViewTextBoxColumn.HeaderText = "CO_FECHA";
            this.cOFECHADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cOFECHADataGridViewTextBoxColumn.Name = "cOFECHADataGridViewTextBoxColumn";
            this.cOFECHADataGridViewTextBoxColumn.ReadOnly = true;
            this.cOFECHADataGridViewTextBoxColumn.Width = 150;
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
            this.label3.Location = new System.Drawing.Point(1748, 514);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 86;
            this.label3.Text = "FECHA";
            // 
            // DATETIMEFECHA
            // 
            this.DATETIMEFECHA.Location = new System.Drawing.Point(1752, 543);
            this.DATETIMEFECHA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DATETIMEFECHA.Name = "DATETIMEFECHA";
            this.DATETIMEFECHA.Size = new System.Drawing.Size(298, 26);
            this.DATETIMEFECHA.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1546, 514);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 103;
            this.label2.Text = "FACTURA";
            // 
            // TXTFACTURA
            // 
            this.TXTFACTURA.Location = new System.Drawing.Point(1551, 543);
            this.TXTFACTURA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTFACTURA.Name = "TXTFACTURA";
            this.TXTFACTURA.Size = new System.Drawing.Size(186, 26);
            this.TXTFACTURA.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(392, 514);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 25);
            this.label15.TabIndex = 101;
            this.label15.Text = "SERIE";
            // 
            // TXTSERIE
            // 
            this.TXTSERIE.Location = new System.Drawing.Point(396, 543);
            this.TXTSERIE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTSERIE.Name = "TXTSERIE";
            this.TXTSERIE.Size = new System.Drawing.Size(186, 26);
            this.TXTSERIE.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(246, 514);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 25);
            this.label16.TabIndex = 99;
            this.label16.Text = "FOLIO";
            // 
            // TXTFOLIO
            // 
            this.TXTFOLIO.Location = new System.Drawing.Point(250, 543);
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
            this.label13.Location = new System.Drawing.Point(609, 514);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 25);
            this.label13.TabIndex = 97;
            this.label13.Text = "ID TIPO DOCUMENTO";
            // 
            // TXTISTIPODOCUMENTO
            // 
            this.TXTISTIPODOCUMENTO.Location = new System.Drawing.Point(614, 543);
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
            this.label12.Location = new System.Drawing.Point(870, 514);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 95;
            this.label12.Text = "MONTO";
            // 
            // TXTMONTO
            // 
            this.TXTMONTO.Location = new System.Drawing.Point(874, 543);
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
            this.label11.Location = new System.Drawing.Point(1106, 514);
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
            this.label10.Location = new System.Drawing.Point(1322, 514);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 25);
            this.label10.TabIndex = 91;
            this.label10.Text = "ID ALMACEN";
            // 
            // CBPROVEEDOR
            // 
            this.CBPROVEEDOR.FormattingEnabled = true;
            this.CBPROVEEDOR.Location = new System.Drawing.Point(1111, 545);
            this.CBPROVEEDOR.Name = "CBPROVEEDOR";
            this.CBPROVEEDOR.Size = new System.Drawing.Size(185, 28);
            this.CBPROVEEDOR.TabIndex = 4;
            // 
            // CBALMACEN
            // 
            this.CBALMACEN.FormattingEnabled = true;
            this.CBALMACEN.Location = new System.Drawing.Point(1327, 545);
            this.CBALMACEN.Name = "CBALMACEN";
            this.CBALMACEN.Size = new System.Drawing.Size(185, 28);
            this.CBALMACEN.TabIndex = 5;
            // 
            // cOMPRASTableAdapter
            // 
            this.cOMPRASTableAdapter.ClearBeforeFill = true;
            // 
            // COMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1924, 692);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cOFOLIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOSERIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOIDTIPODOCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOIDPROVEEDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOIDALMACENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOFACTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOFECHADataGridViewTextBoxColumn;
    }
}