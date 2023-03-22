
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).BeginInit();
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
            this.dataGridView1.DataSource = this.aLMACENESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(254, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // aLIDDataGridViewTextBoxColumn
            // 
            this.aLIDDataGridViewTextBoxColumn.DataPropertyName = "AL_ID";
            this.aLIDDataGridViewTextBoxColumn.HeaderText = "AL_ID";
            this.aLIDDataGridViewTextBoxColumn.Name = "aLIDDataGridViewTextBoxColumn";
            this.aLIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLNOMBREDataGridViewTextBoxColumn
            // 
            this.aLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "AL_NOMBRE";
            this.aLNOMBREDataGridViewTextBoxColumn.HeaderText = "AL_NOMBRE";
            this.aLNOMBREDataGridViewTextBoxColumn.Name = "aLNOMBREDataGridViewTextBoxColumn";
            this.aLNOMBREDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
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
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "NOMBRE";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(134, 354);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(125, 20);
            this.TXTNOMBRE.TabIndex = 14;
            this.TXTNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNOMBRE_KeyPress);
            // 
            // TXTNID
            // 
            this.TXTNID.Location = new System.Drawing.Point(33, 354);
            this.TXTNID.Name = "TXTNID";
            this.TXTNID.Size = new System.Drawing.Size(61, 20);
            this.TXTNID.TabIndex = 13;
            this.TXTNID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNID_KeyPress);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(194, 260);
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
            this.BTNGUARDAR.Location = new System.Drawing.Point(100, 260);
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
            this.BTNBUSCAR.Location = new System.Drawing.Point(6, 260);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(88, 49);
            this.BTNBUSCAR.TabIndex = 135;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = false;
            // 
            // ALMACENES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.TXTNID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ALMACENES";
            this.Text = "ALMACENES";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).EndInit();
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
    }
}

