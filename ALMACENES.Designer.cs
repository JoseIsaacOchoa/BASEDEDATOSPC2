
namespace BASEDEDATOSPC2
{
    partial class ALMACENES
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLMACENESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet = new BASEDEDATOSPC2.VENTASDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.aLMACENESTableAdapter = new BASEDEDATOSPC2.VENTASDataSetTableAdapters.ALMACENESTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTNID = new System.Windows.Forms.TextBox();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.dsAlmacen = new BASEDEDATOSPC2.dsAlmacen();
            this.aLMACENESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aLMACENESTableAdapter1 = new BASEDEDATOSPC2.dsAlmacenTableAdapters.ALMACENESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aLIDDataGridViewTextBoxColumn,
            this.aLNOMBREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aLMACENESBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(381, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // aLIDDataGridViewTextBoxColumn
            // 
            this.aLIDDataGridViewTextBoxColumn.DataPropertyName = "AL_ID";
            this.aLIDDataGridViewTextBoxColumn.HeaderText = "AL_ID";
            this.aLIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aLIDDataGridViewTextBoxColumn.Name = "aLIDDataGridViewTextBoxColumn";
            this.aLIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aLIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // aLNOMBREDataGridViewTextBoxColumn
            // 
            this.aLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "AL_NOMBRE";
            this.aLNOMBREDataGridViewTextBoxColumn.HeaderText = "AL_NOMBRE";
            this.aLNOMBREDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aLNOMBREDataGridViewTextBoxColumn.Name = "aLNOMBREDataGridViewTextBoxColumn";
            this.aLNOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            this.aLNOMBREDataGridViewTextBoxColumn.Width = 150;
            // 
            // aLMACENESBindingSource
            // 
            this.aLMACENESBindingSource.DataMember = "ALMACENES";
            this.aLMACENESBindingSource.DataSource = this.vENTASDataSet;
            // 
            // vENTASDataSet
            // 
            this.vENTASDataSet.DataSetName = "VENTASDataSet";
            this.vENTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALMACENES";
            // 
            // aLMACENESTableAdapter
            // 
            this.aLMACENESTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 515);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 515);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "NOMBRE";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(201, 545);
            this.TXTNOMBRE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(186, 26);
            this.TXTNOMBRE.TabIndex = 14;
            this.TXTNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNOMBRE_KeyPress);
            // 
            // TXTNID
            // 
            this.TXTNID.Location = new System.Drawing.Point(50, 545);
            this.TXTNID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTNID.Name = "TXTNID";
            this.TXTNID.Size = new System.Drawing.Size(90, 26);
            this.TXTNID.TabIndex = 13;
            this.TXTNID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNID_KeyPress);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(291, 400);
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
            this.BTNGUARDAR.Location = new System.Drawing.Point(150, 400);
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
            this.BTNBUSCAR.Location = new System.Drawing.Point(9, 400);
            this.BTNBUSCAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(132, 75);
            this.BTNBUSCAR.TabIndex = 135;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = false;
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // dsAlmacen
            // 
            this.dsAlmacen.DataSetName = "dsAlmacen";
            this.dsAlmacen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLMACENESBindingSource1
            // 
            this.aLMACENESBindingSource1.DataMember = "ALMACENES";
            this.aLMACENESBindingSource1.DataSource = this.dsAlmacen;
            // 
            // aLMACENESTableAdapter1
            // 
            this.aLMACENESTableAdapter1.ClearBeforeFill = true;
            // 
            // ALMACENES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(456, 692);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.TXTNID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ALMACENES";
            this.Text = "ALMACENES";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private VENTASDataSet vENTASDataSet;
        private System.Windows.Forms.BindingSource aLMACENESBindingSource;
        private VENTASDataSetTableAdapters.ALMACENESTableAdapter aLMACENESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTNID;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNBUSCAR;
        private dsAlmacen dsAlmacen;
        private System.Windows.Forms.BindingSource aLMACENESBindingSource1;
        private dsAlmacenTableAdapters.ALMACENESTableAdapter aLMACENESTableAdapter1;
    }
}

