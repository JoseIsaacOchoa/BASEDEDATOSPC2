
namespace BASEDEDATOSPC2
{
    partial class CLIENTES
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
            this.cLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLRFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLLADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLTELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCALLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLNUMEROEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCTABANCARIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCONTACTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLTELEFCONTACTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLREGIMENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet1 = new BASEDEDATOSPC2.VENTASDataSet1();
            this.cLIENTESTableAdapter = new BASEDEDATOSPC2.VENTASDataSet1TableAdapters.CLIENTESTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.TXTRFC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTCORREO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTLADA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTTELEFONO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTCALLE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTNUMEXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTCUENTABANCARIA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTNOMBRECONTCTO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTTELCONTACTO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTREGIMEN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "CLIENTES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIDDataGridViewTextBoxColumn,
            this.cLNOMBREDataGridViewTextBoxColumn,
            this.cLRFCDataGridViewTextBoxColumn,
            this.cLCORREODataGridViewTextBoxColumn,
            this.cLLADADataGridViewTextBoxColumn,
            this.cLTELEFONODataGridViewTextBoxColumn,
            this.cLCALLEDataGridViewTextBoxColumn,
            this.cLNUMEROEXTDataGridViewTextBoxColumn,
            this.cLCTABANCARIADataGridViewTextBoxColumn,
            this.cLCONTACTODataGridViewTextBoxColumn,
            this.cLTELEFCONTACTODataGridViewTextBoxColumn,
            this.cLREGIMENDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 189);
            this.dataGridView1.TabIndex = 11;
            // 
            // cLIDDataGridViewTextBoxColumn
            // 
            this.cLIDDataGridViewTextBoxColumn.DataPropertyName = "CL_ID";
            this.cLIDDataGridViewTextBoxColumn.HeaderText = "CL_ID";
            this.cLIDDataGridViewTextBoxColumn.Name = "cLIDDataGridViewTextBoxColumn";
            this.cLIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLNOMBREDataGridViewTextBoxColumn
            // 
            this.cLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "CL_NOMBRE";
            this.cLNOMBREDataGridViewTextBoxColumn.HeaderText = "CL_NOMBRE";
            this.cLNOMBREDataGridViewTextBoxColumn.Name = "cLNOMBREDataGridViewTextBoxColumn";
            this.cLNOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLRFCDataGridViewTextBoxColumn
            // 
            this.cLRFCDataGridViewTextBoxColumn.DataPropertyName = "CL_RFC";
            this.cLRFCDataGridViewTextBoxColumn.HeaderText = "CL_RFC";
            this.cLRFCDataGridViewTextBoxColumn.Name = "cLRFCDataGridViewTextBoxColumn";
            this.cLRFCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLCORREODataGridViewTextBoxColumn
            // 
            this.cLCORREODataGridViewTextBoxColumn.DataPropertyName = "CL_CORREO";
            this.cLCORREODataGridViewTextBoxColumn.HeaderText = "CL_CORREO";
            this.cLCORREODataGridViewTextBoxColumn.Name = "cLCORREODataGridViewTextBoxColumn";
            this.cLCORREODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLLADADataGridViewTextBoxColumn
            // 
            this.cLLADADataGridViewTextBoxColumn.DataPropertyName = "CL_LADA";
            this.cLLADADataGridViewTextBoxColumn.HeaderText = "CL_LADA";
            this.cLLADADataGridViewTextBoxColumn.Name = "cLLADADataGridViewTextBoxColumn";
            this.cLLADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLTELEFONODataGridViewTextBoxColumn
            // 
            this.cLTELEFONODataGridViewTextBoxColumn.DataPropertyName = "CL_TELEFONO";
            this.cLTELEFONODataGridViewTextBoxColumn.HeaderText = "CL_TELEFONO";
            this.cLTELEFONODataGridViewTextBoxColumn.Name = "cLTELEFONODataGridViewTextBoxColumn";
            this.cLTELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLCALLEDataGridViewTextBoxColumn
            // 
            this.cLCALLEDataGridViewTextBoxColumn.DataPropertyName = "CL_CALLE";
            this.cLCALLEDataGridViewTextBoxColumn.HeaderText = "CL_CALLE";
            this.cLCALLEDataGridViewTextBoxColumn.Name = "cLCALLEDataGridViewTextBoxColumn";
            this.cLCALLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLNUMEROEXTDataGridViewTextBoxColumn
            // 
            this.cLNUMEROEXTDataGridViewTextBoxColumn.DataPropertyName = "CL_NUMERO_EXT";
            this.cLNUMEROEXTDataGridViewTextBoxColumn.HeaderText = "CL_NUMERO_EXT";
            this.cLNUMEROEXTDataGridViewTextBoxColumn.Name = "cLNUMEROEXTDataGridViewTextBoxColumn";
            this.cLNUMEROEXTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLNUMEROEXTDataGridViewTextBoxColumn.Width = 110;
            // 
            // cLCTABANCARIADataGridViewTextBoxColumn
            // 
            this.cLCTABANCARIADataGridViewTextBoxColumn.DataPropertyName = "CL_CTABANCARIA";
            this.cLCTABANCARIADataGridViewTextBoxColumn.HeaderText = "CL_CTABANCARIA";
            this.cLCTABANCARIADataGridViewTextBoxColumn.Name = "cLCTABANCARIADataGridViewTextBoxColumn";
            this.cLCTABANCARIADataGridViewTextBoxColumn.ReadOnly = true;
            this.cLCTABANCARIADataGridViewTextBoxColumn.Width = 110;
            // 
            // cLCONTACTODataGridViewTextBoxColumn
            // 
            this.cLCONTACTODataGridViewTextBoxColumn.DataPropertyName = "CL_CONTACTO";
            this.cLCONTACTODataGridViewTextBoxColumn.HeaderText = "CL_CONTACTO";
            this.cLCONTACTODataGridViewTextBoxColumn.Name = "cLCONTACTODataGridViewTextBoxColumn";
            this.cLCONTACTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLTELEFCONTACTODataGridViewTextBoxColumn
            // 
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.DataPropertyName = "CL_TELEF_CONTACTO";
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.HeaderText = "CL_TELEF_CONTACTO";
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.Name = "cLTELEFCONTACTODataGridViewTextBoxColumn";
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.Width = 130;
            // 
            // cLREGIMENDataGridViewTextBoxColumn
            // 
            this.cLREGIMENDataGridViewTextBoxColumn.DataPropertyName = "CL_REGIMEN";
            this.cLREGIMENDataGridViewTextBoxColumn.HeaderText = "CL_REGIMEN";
            this.cLREGIMENDataGridViewTextBoxColumn.Name = "cLREGIMENDataGridViewTextBoxColumn";
            this.cLREGIMENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.vENTASDataSet1;
            // 
            // vENTASDataSet1
            // 
            this.vENTASDataSet1.DataSetName = "VENTASDataSet1";
            this.vENTASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(281, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 63;
            this.label13.Text = "RFC";
            // 
            // TXTRFC
            // 
            this.TXTRFC.Location = new System.Drawing.Point(284, 371);
            this.TXTRFC.Name = "TXTRFC";
            this.TXTRFC.Size = new System.Drawing.Size(125, 20);
            this.TXTRFC.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(445, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "CORREO";
            // 
            // TXTCORREO
            // 
            this.TXTCORREO.Location = new System.Drawing.Point(448, 371);
            this.TXTCORREO.Name = "TXTCORREO";
            this.TXTCORREO.Size = new System.Drawing.Size(125, 20);
            this.TXTCORREO.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(602, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 59;
            this.label11.Text = "LADA";
            // 
            // TXTLADA
            // 
            this.TXTLADA.Location = new System.Drawing.Point(605, 371);
            this.TXTLADA.Name = "TXTLADA";
            this.TXTLADA.Size = new System.Drawing.Size(125, 20);
            this.TXTLADA.TabIndex = 58;
            this.TXTLADA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTLADA_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(746, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 57;
            this.label10.Text = "TELEFONO";
            // 
            // TXTTELEFONO
            // 
            this.TXTTELEFONO.Location = new System.Drawing.Point(749, 371);
            this.TXTTELEFONO.Name = "TXTTELEFONO";
            this.TXTTELEFONO.Size = new System.Drawing.Size(125, 20);
            this.TXTTELEFONO.TabIndex = 56;
            this.TXTTELEFONO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTTELEFONO_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(894, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "CALLE";
            // 
            // TXTCALLE
            // 
            this.TXTCALLE.Location = new System.Drawing.Point(897, 371);
            this.TXTCALLE.Name = "TXTCALLE";
            this.TXTCALLE.Size = new System.Drawing.Size(125, 20);
            this.TXTCALLE.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1037, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "NUMERO EXTERIOR";
            // 
            // TXTNUMEXT
            // 
            this.TXTNUMEXT.Location = new System.Drawing.Point(1040, 371);
            this.TXTNUMEXT.Name = "TXTNUMEXT";
            this.TXTNUMEXT.Size = new System.Drawing.Size(125, 20);
            this.TXTNUMEXT.TabIndex = 52;
            this.TXTNUMEXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNUMEXT_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1186, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "CUENTA BANCARIA";
            // 
            // TXTCUENTABANCARIA
            // 
            this.TXTCUENTABANCARIA.Location = new System.Drawing.Point(1189, 371);
            this.TXTCUENTABANCARIA.Name = "TXTCUENTABANCARIA";
            this.TXTCUENTABANCARIA.Size = new System.Drawing.Size(125, 20);
            this.TXTCUENTABANCARIA.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "NOMBRE DEL CONTACTO";
            // 
            // TXTNOMBRECONTCTO
            // 
            this.TXTNOMBRECONTCTO.Location = new System.Drawing.Point(31, 448);
            this.TXTNOMBRECONTCTO.Name = "TXTNOMBRECONTCTO";
            this.TXTNOMBRECONTCTO.Size = new System.Drawing.Size(125, 20);
            this.TXTNOMBRECONTCTO.TabIndex = 48;
            this.TXTNOMBRECONTCTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNOMBRECONTCTO_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "TELEFONO DE CONTACTO";
            // 
            // TXTTELCONTACTO
            // 
            this.TXTTELCONTACTO.Location = new System.Drawing.Point(260, 448);
            this.TXTTELCONTACTO.Name = "TXTTELCONTACTO";
            this.TXTTELCONTACTO.Size = new System.Drawing.Size(125, 20);
            this.TXTTELCONTACTO.TabIndex = 46;
            this.TXTTELCONTACTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTTELCONTACTO_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "REGIMEN";
            // 
            // TXTREGIMEN
            // 
            this.TXTREGIMEN.Location = new System.Drawing.Point(461, 448);
            this.TXTREGIMEN.Name = "TXTREGIMEN";
            this.TXTREGIMEN.Size = new System.Drawing.Size(125, 20);
            this.TXTREGIMEN.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "NOMBRE";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(128, 371);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(125, 20);
            this.TXTNOMBRE.TabIndex = 42;
            this.TXTNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNOMBRE_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID";
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(31, 371);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(61, 20);
            this.TXTID.TabIndex = 40;
            this.TXTID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTID_KeyDown);
            this.TXTID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTID_KeyPress);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.Color.Black;
            this.BTNELIMINAR.Location = new System.Drawing.Point(728, 283);
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
            this.BTNGUARDAR.Location = new System.Drawing.Point(634, 283);
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
            this.BTNBUSCAR.Location = new System.Drawing.Point(540, 283);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(88, 49);
            this.BTNBUSCAR.TabIndex = 135;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = false;
            // 
            // CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1370, 486);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TXTRFC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TXTCORREO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXTLADA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TXTTELEFONO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TXTCALLE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXTNUMEXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTCUENTABANCARIA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTNOMBRECONTCTO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTTELCONTACTO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTREGIMEN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CLIENTES";
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.CLIENTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VENTASDataSet1 vENTASDataSet1;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private VENTASDataSet1TableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLRFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLLADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLTELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCALLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLNUMEROEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCTABANCARIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCONTACTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLTELEFCONTACTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLREGIMENDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXTRFC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXTCORREO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXTLADA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTTELEFONO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTCALLE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTNUMEXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTCUENTABANCARIA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTNOMBRECONTCTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTTELCONTACTO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTREGIMEN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNBUSCAR;
    }
}