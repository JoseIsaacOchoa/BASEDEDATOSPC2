
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTIDALMACEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTIDCLIENTE = new System.Windows.Forms.TextBox();
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
            this.BTNBUSCARIDCLIENTE = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNMAS = new System.Windows.Forms.Button();
            this.BTNMENOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "VENTAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(782, 117);
            this.dataGridView1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(726, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 129;
            this.label3.Text = "ID ALMACEN";
            // 
            // TXTIDALMACEN
            // 
            this.TXTIDALMACEN.Location = new System.Drawing.Point(729, 273);
            this.TXTIDALMACEN.Name = "TXTIDALMACEN";
            this.TXTIDALMACEN.Size = new System.Drawing.Size(121, 20);
            this.TXTIDALMACEN.TabIndex = 128;
            this.TXTIDALMACEN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDALMACEN_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 127;
            this.label2.Text = "ID CLIENTE";
            // 
            // TXTIDCLIENTE
            // 
            this.TXTIDCLIENTE.Location = new System.Drawing.Point(580, 273);
            this.TXTIDCLIENTE.Name = "TXTIDCLIENTE";
            this.TXTIDCLIENTE.Size = new System.Drawing.Size(87, 20);
            this.TXTIDCLIENTE.TabIndex = 126;
            this.TXTIDCLIENTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIDCLIENTE_KeyPress);
            // 
            // IDPRO
            // 
            this.IDPRO.AutoSize = true;
            this.IDPRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPRO.Location = new System.Drawing.Point(446, 254);
            this.IDPRO.Name = "IDPRO";
            this.IDPRO.Size = new System.Drawing.Size(63, 16);
            this.IDPRO.TabIndex = 125;
            this.IDPRO.Text = "MONTO";
            // 
            // TXTMONTO
            // 
            this.TXTMONTO.Location = new System.Drawing.Point(449, 273);
            this.TXTMONTO.Name = "TXTMONTO";
            this.TXTMONTO.Size = new System.Drawing.Size(121, 20);
            this.TXTMONTO.TabIndex = 124;
            this.TXTMONTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTMONTO_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(119, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 123;
            this.label15.Text = "SERIE";
            // 
            // TXTSERIE
            // 
            this.TXTSERIE.Location = new System.Drawing.Point(122, 273);
            this.TXTSERIE.Name = "TXTSERIE";
            this.TXTSERIE.Size = new System.Drawing.Size(121, 20);
            this.TXTSERIE.TabIndex = 122;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 16);
            this.label16.TabIndex = 121;
            this.label16.Text = "FOLIO";
            // 
            // TXTFOLIO
            // 
            this.TXTFOLIO.Location = new System.Drawing.Point(13, 273);
            this.TXTFOLIO.Name = "TXTFOLIO";
            this.TXTFOLIO.Size = new System.Drawing.Size(57, 20);
            this.TXTFOLIO.TabIndex = 120;
            this.TXTFOLIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTFOLIO_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(264, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 16);
            this.label13.TabIndex = 119;
            this.label13.Text = "ID TIPO DOCUMENTO";
            // 
            // TXTISTIPODOCUMENTO
            // 
            this.TXTISTIPODOCUMENTO.Location = new System.Drawing.Point(267, 273);
            this.TXTISTIPODOCUMENTO.Name = "TXTISTIPODOCUMENTO";
            this.TXTISTIPODOCUMENTO.Size = new System.Drawing.Size(121, 20);
            this.TXTISTIPODOCUMENTO.TabIndex = 118;
            this.TXTISTIPODOCUMENTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTISTIPODOCUMENTO_KeyPress);
            // 
            // DATETIMEFECHA
            // 
            this.DATETIMEFECHA.Location = new System.Drawing.Point(13, 331);
            this.DATETIMEFECHA.Name = "DATETIMEFECHA";
            this.DATETIMEFECHA.Size = new System.Drawing.Size(200, 20);
            this.DATETIMEFECHA.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 134;
            this.label6.Text = "FECHA";
            // 
            // BTNVENDER
            // 
            this.BTNVENDER.BackColor = System.Drawing.Color.LightGreen;
            this.BTNVENDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVENDER.ForeColor = System.Drawing.Color.Black;
            this.BTNVENDER.Location = new System.Drawing.Point(381, 183);
            this.BTNVENDER.Name = "BTNVENDER";
            this.BTNVENDER.Size = new System.Drawing.Size(88, 49);
            this.BTNVENDER.TabIndex = 137;
            this.BTNVENDER.Text = "Vender";
            this.BTNVENDER.UseVisualStyleBackColor = false;
            // 
            // BTNBUSCARFOLIO
            // 
            this.BTNBUSCARFOLIO.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_búsqueda_24;
            this.BTNBUSCARFOLIO.Location = new System.Drawing.Point(74, 254);
            this.BTNBUSCARFOLIO.Name = "BTNBUSCARFOLIO";
            this.BTNBUSCARFOLIO.Size = new System.Drawing.Size(39, 43);
            this.BTNBUSCARFOLIO.TabIndex = 138;
            this.BTNBUSCARFOLIO.UseVisualStyleBackColor = true;
            // 
            // BTNBUSCARIDCLIENTE
            // 
            this.BTNBUSCARIDCLIENTE.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_búsqueda_24;
            this.BTNBUSCARIDCLIENTE.Location = new System.Drawing.Point(673, 254);
            this.BTNBUSCARIDCLIENTE.Name = "BTNBUSCARIDCLIENTE";
            this.BTNBUSCARIDCLIENTE.Size = new System.Drawing.Size(39, 43);
            this.BTNBUSCARIDCLIENTE.TabIndex = 139;
            this.BTNBUSCARIDCLIENTE.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 141;
            this.label4.Text = "PRODUCTOS";
            // 
            // BTNMAS
            // 
            this.BTNMAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNMAS.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_más_26;
            this.BTNMAS.Location = new System.Drawing.Point(164, 373);
            this.BTNMAS.Name = "BTNMAS";
            this.BTNMAS.Size = new System.Drawing.Size(49, 33);
            this.BTNMAS.TabIndex = 142;
            this.BTNMAS.UseVisualStyleBackColor = false;
            // 
            // BTNMENOS
            // 
            this.BTNMENOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNMENOS.Image = global::BASEDEDATOSPC2.Properties.Resources.icons8_menos_24;
            this.BTNMENOS.Location = new System.Drawing.Point(219, 373);
            this.BTNMENOS.Name = "BTNMENOS";
            this.BTNMENOS.Size = new System.Drawing.Size(49, 33);
            this.BTNMENOS.TabIndex = 143;
            this.BTNMENOS.UseVisualStyleBackColor = false;
            // 
            // VENTAS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.BTNMENOS);
            this.Controls.Add(this.BTNMAS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTNBUSCARIDCLIENTE);
            this.Controls.Add(this.BTNBUSCARFOLIO);
            this.Controls.Add(this.BTNVENDER);
            this.Controls.Add(this.DATETIMEFECHA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTIDALMACEN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTIDCLIENTE);
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
            this.Name = "VENTAS2";
            this.Text = "VENTAS2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTIDALMACEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTIDCLIENTE;
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
        private System.Windows.Forms.Button BTNBUSCARIDCLIENTE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNMAS;
        private System.Windows.Forms.Button BTNMENOS;
    }
}