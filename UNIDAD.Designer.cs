﻿
namespace BASEDEDATOSPC2
{
    partial class UNIDAD
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
            this.uNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet5 = new BASEDEDATOSPC2.VENTASDataSet5();
            this.TXTDESCRIPCION = new System.Windows.Forms.TextBox();
            this.TXTNID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uNIDADTableAdapter = new BASEDEDATOSPC2.VENTASDataSet5TableAdapters.UNIDADTableAdapter();
            this.dsUNIDAD = new BASEDEDATOSPC2.dsUNIDAD();
            this.uNIDADBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uNIDADTableAdapter1 = new BASEDEDATOSPC2.dsUNIDADTableAdapters.UNIDADTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUNIDAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(352, 382);
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
            this.BTNGUARDAR.Location = new System.Drawing.Point(212, 382);
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
            this.BTNBUSCAR.Location = new System.Drawing.Point(70, 382);
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
            this.label1.Location = new System.Drawing.Point(184, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 47);
            this.label1.TabIndex = 51;
            this.label1.Text = "UNIDAD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uNIDDataGridViewTextBoxColumn,
            this.uNDESCRIPCIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uNIDADBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(18, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(504, 291);
            this.dataGridView1.TabIndex = 50;
            // 
            // uNIDDataGridViewTextBoxColumn
            // 
            this.uNIDDataGridViewTextBoxColumn.DataPropertyName = "UN_ID";
            this.uNIDDataGridViewTextBoxColumn.HeaderText = "UN_ID";
            this.uNIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.uNIDDataGridViewTextBoxColumn.Name = "uNIDDataGridViewTextBoxColumn";
            this.uNIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // uNDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "UN_DESCRIPCION";
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "UN_DESCRIPCION";
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.Name = "uNDESCRIPCIONDataGridViewTextBoxColumn";
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.Width = 130;
            // 
            // uNIDADBindingSource
            // 
            this.uNIDADBindingSource.DataMember = "UNIDAD";
            this.uNIDADBindingSource.DataSource = this.vENTASDataSet5;
            // 
            // vENTASDataSet5
            // 
            this.vENTASDataSet5.DataSetName = "VENTASDataSet5";
            this.vENTASDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TXTDESCRIPCION
            // 
            this.TXTDESCRIPCION.Location = new System.Drawing.Point(249, 514);
            this.TXTDESCRIPCION.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTDESCRIPCION.Name = "TXTDESCRIPCION";
            this.TXTDESCRIPCION.Size = new System.Drawing.Size(186, 26);
            this.TXTDESCRIPCION.TabIndex = 58;
            this.TXTDESCRIPCION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTDESCRIPCION_KeyPress);
            // 
            // TXTNID
            // 
            this.TXTNID.Location = new System.Drawing.Point(98, 514);
            this.TXTNID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTNID.Name = "TXTNID";
            this.TXTNID.Size = new System.Drawing.Size(90, 26);
            this.TXTNID.TabIndex = 57;
            this.TXTNID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 485);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "DESCRIPCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID";
            // 
            // uNIDADTableAdapter
            // 
            this.uNIDADTableAdapter.ClearBeforeFill = true;
            // 
            // dsUNIDAD
            // 
            this.dsUNIDAD.DataSetName = "dsUNIDAD";
            this.dsUNIDAD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNIDADBindingSource1
            // 
            this.uNIDADBindingSource1.DataMember = "UNIDAD";
            this.uNIDADBindingSource1.DataSource = this.dsUNIDAD;
            // 
            // uNIDADTableAdapter1
            // 
            this.uNIDADTableAdapter1.ClearBeforeFill = true;
            // 
            // UNIDAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(578, 692);
            this.Controls.Add(this.TXTDESCRIPCION);
            this.Controls.Add(this.TXTNID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UNIDAD";
            this.Text = "UNIDAD";
            this.Load += new System.EventHandler(this.UNIDAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUNIDAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXTDESCRIPCION;
        private System.Windows.Forms.TextBox TXTNID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private VENTASDataSet5 vENTASDataSet5;
        private System.Windows.Forms.BindingSource uNIDADBindingSource;
        private VENTASDataSet5TableAdapters.UNIDADTableAdapter uNIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNDESCRIPCIONDataGridViewTextBoxColumn;
        private dsUNIDAD dsUNIDAD;
        private System.Windows.Forms.BindingSource uNIDADBindingSource1;
        private dsUNIDADTableAdapters.UNIDADTableAdapter uNIDADTableAdapter1;
    }
}