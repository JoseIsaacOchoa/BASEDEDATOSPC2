
namespace BASEDEDATOSPC2
{
    partial class PRODUCTOS
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
            this.pRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDUNIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsProductos = new BASEDEDATOSPC2.dsProductos();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet6 = new BASEDEDATOSPC2.VENTASDataSet6();
            this.pRODUCTOSTableAdapter = new BASEDEDATOSPC2.VENTASDataSet6TableAdapters.PRODUCTOSTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTSTOCKMAX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTIDUNIDAD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTSTOCKMIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTIDTP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTPRECIO = new System.Windows.Forms.TextBox();
            this.pRODUCTOSTableAdapter1 = new BASEDEDATOSPC2.dsProductosTableAdapters.PRODUCTOSTableAdapter();
            this.BTNEXISTENCIA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(729, 374);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(132, 75);
            this.BTNELIMINAR.TabIndex = 54;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.LightGreen;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.Color.Black;
            this.BTNGUARDAR.Location = new System.Drawing.Point(588, 374);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(132, 75);
            this.BTNGUARDAR.TabIndex = 53;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.BackColor = System.Drawing.Color.Gold;
            this.BTNBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.ForeColor = System.Drawing.Color.Black;
            this.BTNBUSCAR.Location = new System.Drawing.Point(447, 374);
            this.BTNBUSCAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(132, 75);
            this.BTNBUSCAR.TabIndex = 52;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = false;
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 47);
            this.label1.TabIndex = 51;
            this.label1.Text = "PRODUCTOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRIDDataGridViewTextBoxColumn,
            this.pRNOMBREDataGridViewTextBoxColumn,
            this.pRIDUNIDADDataGridViewTextBoxColumn,
            this.pRSTOCKMINDataGridViewTextBoxColumn,
            this.pRSTOCKMAXDataGridViewTextBoxColumn,
            this.pRIDTPDataGridViewTextBoxColumn,
            this.pRPRECIODataGridViewTextBoxColumn,
            this.pRIVADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTOSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(18, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1286, 291);
            this.dataGridView1.TabIndex = 50;
            // 
            // pRIDDataGridViewTextBoxColumn
            // 
            this.pRIDDataGridViewTextBoxColumn.DataPropertyName = "PR_ID";
            this.pRIDDataGridViewTextBoxColumn.HeaderText = "PR_ID";
            this.pRIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRIDDataGridViewTextBoxColumn.Name = "pRIDDataGridViewTextBoxColumn";
            this.pRIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRNOMBREDataGridViewTextBoxColumn
            // 
            this.pRNOMBREDataGridViewTextBoxColumn.DataPropertyName = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.HeaderText = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRNOMBREDataGridViewTextBoxColumn.Name = "pRNOMBREDataGridViewTextBoxColumn";
            this.pRNOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRNOMBREDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRIDUNIDADDataGridViewTextBoxColumn
            // 
            this.pRIDUNIDADDataGridViewTextBoxColumn.DataPropertyName = "PR_ID_UNIDAD";
            this.pRIDUNIDADDataGridViewTextBoxColumn.HeaderText = "PR_ID_UNIDAD";
            this.pRIDUNIDADDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRIDUNIDADDataGridViewTextBoxColumn.Name = "pRIDUNIDADDataGridViewTextBoxColumn";
            this.pRIDUNIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRIDUNIDADDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRSTOCKMINDataGridViewTextBoxColumn
            // 
            this.pRSTOCKMINDataGridViewTextBoxColumn.DataPropertyName = "PR_STOCK_MIN";
            this.pRSTOCKMINDataGridViewTextBoxColumn.HeaderText = "PR_STOCK_MIN";
            this.pRSTOCKMINDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRSTOCKMINDataGridViewTextBoxColumn.Name = "pRSTOCKMINDataGridViewTextBoxColumn";
            this.pRSTOCKMINDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRSTOCKMINDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRSTOCKMAXDataGridViewTextBoxColumn
            // 
            this.pRSTOCKMAXDataGridViewTextBoxColumn.DataPropertyName = "PR_STOCK_MAX";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.HeaderText = "PR_STOCK_MAX";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRSTOCKMAXDataGridViewTextBoxColumn.Name = "pRSTOCKMAXDataGridViewTextBoxColumn";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRSTOCKMAXDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRIDTPDataGridViewTextBoxColumn
            // 
            this.pRIDTPDataGridViewTextBoxColumn.DataPropertyName = "PR_ID_TP";
            this.pRIDTPDataGridViewTextBoxColumn.HeaderText = "PR_ID_TP";
            this.pRIDTPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRIDTPDataGridViewTextBoxColumn.Name = "pRIDTPDataGridViewTextBoxColumn";
            this.pRIDTPDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRIDTPDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRPRECIODataGridViewTextBoxColumn
            // 
            this.pRPRECIODataGridViewTextBoxColumn.DataPropertyName = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn.HeaderText = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRPRECIODataGridViewTextBoxColumn.Name = "pRPRECIODataGridViewTextBoxColumn";
            this.pRPRECIODataGridViewTextBoxColumn.ReadOnly = true;
            this.pRPRECIODataGridViewTextBoxColumn.Width = 150;
            // 
            // pRIVADataGridViewTextBoxColumn
            // 
            this.pRIVADataGridViewTextBoxColumn.DataPropertyName = "PR_IVA";
            this.pRIVADataGridViewTextBoxColumn.HeaderText = "PR_IVA";
            this.pRIVADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRIVADataGridViewTextBoxColumn.Name = "pRIVADataGridViewTextBoxColumn";
            this.pRIVADataGridViewTextBoxColumn.ReadOnly = true;
            this.pRIVADataGridViewTextBoxColumn.Width = 150;
            // 
            // pRODUCTOSBindingSource1
            // 
            this.pRODUCTOSBindingSource1.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource1.DataSource = this.dsProductos;
            // 
            // dsProductos
            // 
            this.dsProductos.DataSetName = "dsProductos";
            this.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.vENTASDataSet6;
            // 
            // vENTASDataSet6
            // 
            this.vENTASDataSet6.DataSetName = "VENTASDataSet6";
            this.vENTASDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1048, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "STOCK MAX";
            // 
            // TXTSTOCKMAX
            // 
            this.TXTSTOCKMAX.Location = new System.Drawing.Point(1053, 509);
            this.TXTSTOCKMAX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTSTOCKMAX.Name = "TXTSTOCKMAX";
            this.TXTSTOCKMAX.Size = new System.Drawing.Size(186, 26);
            this.TXTSTOCKMAX.TabIndex = 112;
            this.TXTSTOCKMAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTSTOCKMAX_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(111, 480);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 25);
            this.label13.TabIndex = 111;
            this.label13.Text = "ID";
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(116, 509);
            this.TXTID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(186, 26);
            this.TXTID.TabIndex = 110;
            this.TXTID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTID_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(372, 480);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 25);
            this.label12.TabIndex = 109;
            this.label12.Text = "NOMBRE";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(376, 509);
            this.TXTNOMBRE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(186, 26);
            this.TXTNOMBRE.TabIndex = 108;
            this.TXTNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNOMBRE_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(608, 480);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 25);
            this.label11.TabIndex = 107;
            this.label11.Text = "ID UNIDAD";
            // 
            // TXTIDUNIDAD
            // 
            this.TXTIDUNIDAD.Location = new System.Drawing.Point(612, 509);
            this.TXTIDUNIDAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIDUNIDAD.Name = "TXTIDUNIDAD";
            this.TXTIDUNIDAD.Size = new System.Drawing.Size(186, 26);
            this.TXTIDUNIDAD.TabIndex = 106;
            this.TXTIDUNIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDUNIDAD_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(824, 480);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 105;
            this.label10.Text = "STOCK MIN";
            // 
            // TXTSTOCKMIN
            // 
            this.TXTSTOCKMIN.Location = new System.Drawing.Point(828, 509);
            this.TXTSTOCKMIN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTSTOCKMIN.Name = "TXTSTOCKMIN";
            this.TXTSTOCKMIN.Size = new System.Drawing.Size(186, 26);
            this.TXTSTOCKMIN.TabIndex = 104;
            this.TXTSTOCKMIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTSTOCKMIN_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 574);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 119;
            this.label3.Text = "IVA";
            // 
            // TXTIVA
            // 
            this.TXTIVA.Location = new System.Drawing.Point(560, 603);
            this.TXTIVA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIVA.Name = "TXTIVA";
            this.TXTIVA.Size = new System.Drawing.Size(186, 26);
            this.TXTIVA.TabIndex = 118;
            this.TXTIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIVA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 574);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 117;
            this.label4.Text = "ID TP";
            // 
            // TXTIDTP
            // 
            this.TXTIDTP.Location = new System.Drawing.Point(118, 603);
            this.TXTIDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIDTP.Name = "TXTIDTP";
            this.TXTIDTP.Size = new System.Drawing.Size(186, 26);
            this.TXTIDTP.TabIndex = 116;
            this.TXTIDTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDTP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 574);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 115;
            this.label5.Text = "PRECIO";
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.Location = new System.Drawing.Point(334, 603);
            this.TXTPRECIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.Size = new System.Drawing.Size(186, 26);
            this.TXTPRECIO.TabIndex = 114;
            this.TXTPRECIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTPRECIO_KeyPress);
            // 
            // pRODUCTOSTableAdapter1
            // 
            this.pRODUCTOSTableAdapter1.ClearBeforeFill = true;
            // 
            // BTNEXISTENCIA
            // 
            this.BTNEXISTENCIA.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_búsqueda_24;
            this.BTNEXISTENCIA.Location = new System.Drawing.Point(309, 499);
            this.BTNEXISTENCIA.Name = "BTNEXISTENCIA";
            this.BTNEXISTENCIA.Size = new System.Drawing.Size(43, 47);
            this.BTNEXISTENCIA.TabIndex = 121;
            this.BTNEXISTENCIA.UseVisualStyleBackColor = true;
            this.BTNEXISTENCIA.Click += new System.EventHandler(this.BTNEXISTENCIA_Click);
            // 
            // PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1380, 692);
            this.Controls.Add(this.BTNEXISTENCIA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTIVA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTIDTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTPRECIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTSTOCKMAX);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXTIDUNIDAD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TXTSTOCKMIN);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PRODUCTOS";
            this.Text = "PRODUCTOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PRODUCTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VENTASDataSet6 vENTASDataSet6;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private VENTASDataSet6TableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDUNIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRSTOCKMINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRSTOCKMAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTSTOCKMAX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXTIDUNIDAD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTSTOCKMIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTIVA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTIDTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTPRECIO;
        private dsProductos dsProductos;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource1;
        private dsProductosTableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter1;
        private System.Windows.Forms.Button BTNEXISTENCIA;
    }
}