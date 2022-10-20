namespace FireAlarmClient
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblDispositivo1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataAlertas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnactivar = new System.Windows.Forms.Button();
            this.lblArea2 = new System.Windows.Forms.Label();
            this.lblDispositivo2 = new System.Windows.Forms.Label();
            this.pctCalor = new System.Windows.Forms.PictureBox();
            this.pctHumo = new System.Windows.Forms.PictureBox();
            this.pctFuego = new System.Windows.Forms.PictureBox();
            this.lblAlarma1 = new System.Windows.Forms.Label();
            this.lblArea1 = new System.Windows.Forms.Label();
            this.pctAlerta = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscarDispositivos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pctminihumo = new System.Windows.Forms.PictureBox();
            this.pctminicalor = new System.Windows.Forms.PictureBox();
            this.pctminifuego = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCalor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlerta)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctminihumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctminicalor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctminifuego)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDispositivo1
            // 
            this.lblDispositivo1.AutoSize = true;
            this.lblDispositivo1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDispositivo1.Location = new System.Drawing.Point(102, 277);
            this.lblDispositivo1.Name = "lblDispositivo1";
            this.lblDispositivo1.Size = new System.Drawing.Size(155, 37);
            this.lblDispositivo1.TabIndex = 1;
            this.lblDispositivo1.Text = "Dispositivo:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1193, 684);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTemperatura);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.dataAlertas);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnborrar);
            this.tabPage1.Controls.Add(this.btnactivar);
            this.tabPage1.Controls.Add(this.lblArea2);
            this.tabPage1.Controls.Add(this.lblDispositivo2);
            this.tabPage1.Controls.Add(this.pctCalor);
            this.tabPage1.Controls.Add(this.pctHumo);
            this.tabPage1.Controls.Add(this.pctFuego);
            this.tabPage1.Controls.Add(this.lblAlarma1);
            this.tabPage1.Controls.Add(this.lblArea1);
            this.tabPage1.Controls.Add(this.pctAlerta);
            this.tabPage1.Controls.Add(this.lblDispositivo1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1185, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataAlertas
            // 
            this.dataAlertas.AllowUserToAddRows = false;
            this.dataAlertas.AllowUserToDeleteRows = false;
            this.dataAlertas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlertas.Location = new System.Drawing.Point(34, 71);
            this.dataAlertas.Name = "dataAlertas";
            this.dataAlertas.ReadOnly = true;
            this.dataAlertas.RowHeadersWidth = 51;
            this.dataAlertas.RowTemplate.Height = 29;
            this.dataAlertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAlertas.Size = new System.Drawing.Size(1123, 181);
            this.dataAlertas.TabIndex = 16;
            this.dataAlertas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAlertas_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(42, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "Alertas Activas";
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(672, 543);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(149, 61);
            this.btnborrar.TabIndex = 13;
            this.btnborrar.Text = "Desactivar Alertas";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnactivar
            // 
            this.btnactivar.Location = new System.Drawing.Point(672, 474);
            this.btnactivar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(149, 61);
            this.btnactivar.TabIndex = 12;
            this.btnactivar.Text = "Buscar Alertas";
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // lblArea2
            // 
            this.lblArea2.AutoSize = true;
            this.lblArea2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArea2.Location = new System.Drawing.Point(263, 348);
            this.lblArea2.Name = "lblArea2";
            this.lblArea2.Size = new System.Drawing.Size(171, 37);
            this.lblArea2.TabIndex = 9;
            this.lblArea2.Text = "______________";
            // 
            // lblDispositivo2
            // 
            this.lblDispositivo2.AutoSize = true;
            this.lblDispositivo2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDispositivo2.Location = new System.Drawing.Point(263, 277);
            this.lblDispositivo2.Name = "lblDispositivo2";
            this.lblDispositivo2.Size = new System.Drawing.Size(171, 37);
            this.lblDispositivo2.TabIndex = 8;
            this.lblDispositivo2.Text = "______________";
            // 
            // pctCalor
            // 
            this.pctCalor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctCalor.Location = new System.Drawing.Point(321, 479);
            this.pctCalor.Name = "pctCalor";
            this.pctCalor.Size = new System.Drawing.Size(125, 125);
            this.pctCalor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCalor.TabIndex = 7;
            this.pctCalor.TabStop = false;
            // 
            // pctHumo
            // 
            this.pctHumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctHumo.Location = new System.Drawing.Point(190, 479);
            this.pctHumo.Name = "pctHumo";
            this.pctHumo.Size = new System.Drawing.Size(125, 125);
            this.pctHumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHumo.TabIndex = 6;
            this.pctHumo.TabStop = false;
            // 
            // pctFuego
            // 
            this.pctFuego.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctFuego.Location = new System.Drawing.Point(59, 479);
            this.pctFuego.Name = "pctFuego";
            this.pctFuego.Size = new System.Drawing.Size(125, 125);
            this.pctFuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFuego.TabIndex = 5;
            this.pctFuego.TabStop = false;
            // 
            // lblAlarma1
            // 
            this.lblAlarma1.AutoSize = true;
            this.lblAlarma1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlarma1.Location = new System.Drawing.Point(59, 426);
            this.lblAlarma1.Name = "lblAlarma1";
            this.lblAlarma1.Size = new System.Drawing.Size(198, 37);
            this.lblAlarma1.TabIndex = 4;
            this.lblAlarma1.Text = "Tipo de Alarma";
            // 
            // lblArea1
            // 
            this.lblArea1.AutoSize = true;
            this.lblArea1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArea1.Location = new System.Drawing.Point(168, 348);
            this.lblArea1.Name = "lblArea1";
            this.lblArea1.Size = new System.Drawing.Size(77, 37);
            this.lblArea1.TabIndex = 3;
            this.lblArea1.Text = "Area:";
            // 
            // pctAlerta
            // 
            this.pctAlerta.Image = ((System.Drawing.Image)(resources.GetObject("pctAlerta.Image")));
            this.pctAlerta.Location = new System.Drawing.Point(827, 270);
            this.pctAlerta.Name = "pctAlerta";
            this.pctAlerta.Size = new System.Drawing.Size(330, 334);
            this.pctAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAlerta.TabIndex = 2;
            this.pctAlerta.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarDispositivos);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.pctminihumo);
            this.tabPage2.Controls.Add(this.pctminicalor);
            this.tabPage2.Controls.Add(this.pctminifuego);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblDispositivo);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1185, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnBuscarDispositivos
            // 
            this.btnBuscarDispositivos.Location = new System.Drawing.Point(55, 553);
            this.btnBuscarDispositivos.Name = "btnBuscarDispositivos";
            this.btnBuscarDispositivos.Size = new System.Drawing.Size(171, 57);
            this.btnBuscarDispositivos.TabIndex = 27;
            this.btnBuscarDispositivos.Text = "Buscar Dispositvos";
            this.btnBuscarDispositivos.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(55, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 32);
            this.label9.TabIndex = 26;
            this.label9.Text = "Crear Nuevo";
            // 
            // pctminihumo
            // 
            this.pctminihumo.Location = new System.Drawing.Point(1040, 267);
            this.pctminihumo.Name = "pctminihumo";
            this.pctminihumo.Size = new System.Drawing.Size(50, 51);
            this.pctminihumo.TabIndex = 25;
            this.pctminihumo.TabStop = false;
            // 
            // pctminicalor
            // 
            this.pctminicalor.Location = new System.Drawing.Point(975, 267);
            this.pctminicalor.Name = "pctminicalor";
            this.pctminicalor.Size = new System.Drawing.Size(50, 51);
            this.pctminicalor.TabIndex = 24;
            this.pctminicalor.TabStop = false;
            // 
            // pctminifuego
            // 
            this.pctminifuego.Location = new System.Drawing.Point(907, 267);
            this.pctminifuego.Name = "pctminifuego";
            this.pctminifuego.Size = new System.Drawing.Size(50, 51);
            this.pctminifuego.TabIndex = 23;
            this.pctminifuego.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(55, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 32);
            this.label16.TabIndex = 22;
            this.label16.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 57);
            this.button1.TabIndex = 20;
            this.button1.Text = "Crear Dispositivo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(907, 577);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 32);
            this.label15.TabIndex = 19;
            this.label15.Text = "__________________";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(899, 544);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 32);
            this.label14.TabIndex = 18;
            this.label14.Text = "Respuesta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(907, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 32);
            this.label13.TabIndex = 17;
            this.label13.Text = "__________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(907, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(907, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 32);
            this.label11.TabIndex = 15;
            this.label11.Text = "__________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(907, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 32);
            this.label10.TabIndex = 14;
            this.label10.Text = "Temperatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(907, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tipo de Alerta";
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.BackColor = System.Drawing.Color.White;
            this.lblDispositivo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDispositivo.Location = new System.Drawing.Point(899, 159);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(194, 32);
            this.lblDispositivo.TabIndex = 11;
            this.lblDispositivo.Text = "__________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(907, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Detalles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(899, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dispositivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(643, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Historial";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(643, 125);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(210, 484);
            this.listBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(334, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dispositivos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ubicacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estado";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(55, 392);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(334, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 484);
            this.listBox1.TabIndex = 0;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemperatura.Location = new System.Drawing.Point(650, 277);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(171, 37);
            this.lblTemperatura.TabIndex = 18;
            this.lblTemperatura.Text = "______________";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(489, 277);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 37);
            this.label18.TabIndex = 17;
            this.label18.Text = "Temperatura:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 697);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.Text = "FireWatcher";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Shown += new System.EventHandler(this.btnactivar_Click);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCalor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlerta)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctminihumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctminicalor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctminifuego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblDispositivo1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnborrar;
        private Button btnactivar;
        private Label lblArea2;
        private Label lblDispositivo2;
        private PictureBox pctCalor;
        private PictureBox pctHumo;
        private PictureBox pctFuego;
        private Label lblAlarma1;
        private Label lblArea1;
        private PictureBox pctAlerta;
        private TabPage tabPage2;
        private ComboBox comboBox2;
        private ListBox listBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label16;
        private TextBox textBox1;
        private Button button1;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label lblDispositivo;
        private Label label6;
        private Label label5;
        private Label label4;
        private ListBox listBox2;
        private ComboBox comboBox1;
        private PictureBox pctminihumo;
        private PictureBox pctminicalor;
        private PictureBox pctminifuego;
        private Label label7;
        private DataGridView dataAlertas;
        private Label label9;
        private Button btnBuscarDispositivos;
        private Label lblTemperatura;
        private Label label18;
    }
}