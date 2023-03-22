
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
            this.vENTASDataSet6 = new BASEDEDATOSPC2.VENTASDataSet6();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOSTableAdapter = new BASEDEDATOSPC2.VENTASDataSet6TableAdapters.PRODUCTOSTableAdapter();
            this.pRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDUNIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(486, 243);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(88, 49);
            this.BTNELIMINAR.TabIndex = 54;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.LightGreen;
            this.BTNGUARDAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ForeColor = System.Drawing.Color.Black;
            this.BTNGUARDAR.Location = new System.Drawing.Point(392, 243);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(88, 49);
            this.BTNGUARDAR.TabIndex = 53;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.BackColor = System.Drawing.Color.Gold;
            this.BTNBUSCAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.ForeColor = System.Drawing.Color.Black;
            this.BTNBUSCAR.Location = new System.Drawing.Point(298, 243);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(88, 49);
            this.BTNBUSCAR.TabIndex = 52;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
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
            this.dataGridView1.DataSource = this.pRODUCTOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(857, 189);
            this.dataGridView1.TabIndex = 50;
            // 
            // vENTASDataSet6
            // 
            this.vENTASDataSet6.DataSetName = "VENTASDataSet6";
            this.vENTASDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.vENTASDataSet6;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // pRIDDataGridViewTextBoxColumn
            // 
            this.pRIDDataGridViewTextBoxColumn.DataPropertyName = "PR_ID";
            this.pRIDDataGridViewTextBoxColumn.HeaderText = "PR_ID";
            this.pRIDDataGridViewTextBoxColumn.Name = "pRIDDataGridViewTextBoxColumn";
            this.pRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRNOMBREDataGridViewTextBoxColumn
            // 
            this.pRNOMBREDataGridViewTextBoxColumn.DataPropertyName = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.HeaderText = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.Name = "pRNOMBREDataGridViewTextBoxColumn";
            this.pRNOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRIDUNIDADDataGridViewTextBoxColumn
            // 
            this.pRIDUNIDADDataGridViewTextBoxColumn.DataPropertyName = "PR_ID_UNIDAD";
            this.pRIDUNIDADDataGridViewTextBoxColumn.HeaderText = "PR_ID_UNIDAD";
            this.pRIDUNIDADDataGridViewTextBoxColumn.Name = "pRIDUNIDADDataGridViewTextBoxColumn";
            this.pRIDUNIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRSTOCKMINDataGridViewTextBoxColumn
            // 
            this.pRSTOCKMINDataGridViewTextBoxColumn.DataPropertyName = "PR_STOCK_MIN";
            this.pRSTOCKMINDataGridViewTextBoxColumn.HeaderText = "PR_STOCK_MIN";
            this.pRSTOCKMINDataGridViewTextBoxColumn.Name = "pRSTOCKMINDataGridViewTextBoxColumn";
            this.pRSTOCKMINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRSTOCKMAXDataGridViewTextBoxColumn
            // 
            this.pRSTOCKMAXDataGridViewTextBoxColumn.DataPropertyName = "PR_STOCK_MAX";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.HeaderText = "PR_STOCK_MAX";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.Name = "pRSTOCKMAXDataGridViewTextBoxColumn";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRIDTPDataGridViewTextBoxColumn
            // 
            this.pRIDTPDataGridViewTextBoxColumn.DataPropertyName = "PR_ID_TP";
            this.pRIDTPDataGridViewTextBoxColumn.HeaderText = "PR_ID_TP";
            this.pRIDTPDataGridViewTextBoxColumn.Name = "pRIDTPDataGridViewTextBoxColumn";
            this.pRIDTPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRPRECIODataGridViewTextBoxColumn
            // 
            this.pRPRECIODataGridViewTextBoxColumn.DataPropertyName = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn.HeaderText = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn.Name = "pRPRECIODataGridViewTextBoxColumn";
            this.pRPRECIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRIVADataGridViewTextBoxColumn
            // 
            this.pRIVADataGridViewTextBoxColumn.DataPropertyName = "PR_IVA";
            this.pRIVADataGridViewTextBoxColumn.HeaderText = "PR_IVA";
            this.pRIVADataGridViewTextBoxColumn.Name = "pRIVADataGridViewTextBoxColumn";
            this.pRIVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(699, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 113;
            this.label2.Text = "STOCK MAX";
            // 
            // TXTSTOCKMAX
            // 
            this.TXTSTOCKMAX.Location = new System.Drawing.Point(702, 331);
            this.TXTSTOCKMAX.Name = "TXTSTOCKMAX";
            this.TXTSTOCKMAX.Size = new System.Drawing.Size(125, 20);
            this.TXTSTOCKMAX.TabIndex = 112;
            this.TXTSTOCKMAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTSTOCKMAX_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(74, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 16);
            this.label13.TabIndex = 111;
            this.label13.Text = "ID";
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(77, 331);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(125, 20);
            this.TXTID.TabIndex = 110;
            this.TXTID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTID_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(248, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 109;
            this.label12.Text = "NOMBRE";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(251, 331);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(125, 20);
            this.TXTNOMBRE.TabIndex = 108;
            this.TXTNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNOMBRE_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(405, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 107;
            this.label11.Text = "ID UNIDAD";
            // 
            // TXTIDUNIDAD
            // 
            this.TXTIDUNIDAD.Location = new System.Drawing.Point(408, 331);
            this.TXTIDUNIDAD.Name = "TXTIDUNIDAD";
            this.TXTIDUNIDAD.Size = new System.Drawing.Size(125, 20);
            this.TXTIDUNIDAD.TabIndex = 106;
            this.TXTIDUNIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDUNIDAD_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(549, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 105;
            this.label10.Text = "STOCK MIN";
            // 
            // TXTSTOCKMIN
            // 
            this.TXTSTOCKMIN.Location = new System.Drawing.Point(552, 331);
            this.TXTSTOCKMIN.Name = "TXTSTOCKMIN";
            this.TXTSTOCKMIN.Size = new System.Drawing.Size(125, 20);
            this.TXTSTOCKMIN.TabIndex = 104;
            this.TXTSTOCKMIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTSTOCKMIN_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 119;
            this.label3.Text = "IVA";
            // 
            // TXTIVA
            // 
            this.TXTIVA.Location = new System.Drawing.Point(373, 392);
            this.TXTIVA.Name = "TXTIVA";
            this.TXTIVA.Size = new System.Drawing.Size(125, 20);
            this.TXTIVA.TabIndex = 118;
            this.TXTIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIVA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 117;
            this.label4.Text = "ID TP";
            // 
            // TXTIDTP
            // 
            this.TXTIDTP.Location = new System.Drawing.Point(79, 392);
            this.TXTIDTP.Name = "TXTIDTP";
            this.TXTIDTP.Size = new System.Drawing.Size(125, 20);
            this.TXTIDTP.TabIndex = 116;
            this.TXTIDTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDTP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 115;
            this.label5.Text = "PRECIO";
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.Location = new System.Drawing.Point(223, 392);
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.Size = new System.Drawing.Size(125, 20);
            this.TXTPRECIO.TabIndex = 114;
            this.TXTPRECIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTPRECIO_KeyPress);
            // 
            // PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(920, 450);
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
            this.Name = "PRODUCTOS";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.PRODUCTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
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
    }
}