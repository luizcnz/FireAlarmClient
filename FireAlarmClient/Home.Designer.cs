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
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAdmUbicaciones = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHistUbicacion = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pctminihumo = new System.Windows.Forms.PictureBox();
            this.pctminicalor = new System.Windows.Forms.PictureBox();
            this.pctminifuego = new System.Windows.Forms.PictureBox();
            this.lblHistRespuesta = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblHistFecha = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHistTemperatura = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHistDispositivo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataHistorial = new System.Windows.Forms.DataGridView();
            this.dataDispositivos = new System.Windows.Forms.DataGridView();
            this.btnBuscarDispositivos = new System.Windows.Forms.Button();
            this.lblAccion = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCodgo = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxUbicacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCalor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlerta)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctminihumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctminicalor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctminifuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDispositivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDispositivo1
            // 
            this.lblDispositivo1.AutoSize = true;
            this.lblDispositivo1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDispositivo1.Location = new System.Drawing.Point(30, 208);
            this.lblDispositivo1.Name = "lblDispositivo1";
            this.lblDispositivo1.Size = new System.Drawing.Size(119, 30);
            this.lblDispositivo1.TabIndex = 1;
            this.lblDispositivo1.Text = "Dispositivo:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1044, 513);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.FillCbox);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1036, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemperatura.Location = new System.Drawing.Point(864, 208);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(139, 30);
            this.lblTemperatura.TabIndex = 18;
            this.lblTemperatura.Text = "______________";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(712, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 30);
            this.label18.TabIndex = 17;
            this.label18.Text = "Temperatura:";
            // 
            // dataAlertas
            // 
            this.dataAlertas.AllowUserToAddRows = false;
            this.dataAlertas.AllowUserToDeleteRows = false;
            this.dataAlertas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlertas.Location = new System.Drawing.Point(30, 53);
            this.dataAlertas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataAlertas.Name = "dataAlertas";
            this.dataAlertas.ReadOnly = true;
            this.dataAlertas.RowHeadersWidth = 51;
            this.dataAlertas.RowTemplate.Height = 29;
            this.dataAlertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAlertas.Size = new System.Drawing.Size(983, 136);
            this.dataAlertas.TabIndex = 16;
            this.dataAlertas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAlertas_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Alertas Activas";
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(209, 407);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(130, 46);
            this.btnborrar.TabIndex = 13;
            this.btnborrar.Text = "Desactivar Alertas";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnactivar
            // 
            this.btnactivar.Location = new System.Drawing.Point(47, 407);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(130, 46);
            this.btnactivar.TabIndex = 12;
            this.btnactivar.Text = "Buscar Alertas";
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // lblArea2
            // 
            this.lblArea2.AutoSize = true;
            this.lblArea2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArea2.Location = new System.Drawing.Point(360, 208);
            this.lblArea2.Name = "lblArea2";
            this.lblArea2.Size = new System.Drawing.Size(139, 30);
            this.lblArea2.TabIndex = 9;
            this.lblArea2.Text = "______________";
            // 
            // lblDispositivo2
            // 
            this.lblDispositivo2.AutoSize = true;
            this.lblDispositivo2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDispositivo2.Location = new System.Drawing.Point(171, 208);
            this.lblDispositivo2.Name = "lblDispositivo2";
            this.lblDispositivo2.Size = new System.Drawing.Size(103, 30);
            this.lblDispositivo2.TabIndex = 8;
            this.lblDispositivo2.Text = "__________";
            // 
            // pctCalor
            // 
            this.pctCalor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctCalor.Location = new System.Drawing.Point(712, 390);
            this.pctCalor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctCalor.Name = "pctCalor";
            this.pctCalor.Size = new System.Drawing.Size(88, 76);
            this.pctCalor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCalor.TabIndex = 7;
            this.pctCalor.TabStop = false;
            // 
            // pctHumo
            // 
            this.pctHumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctHumo.Location = new System.Drawing.Point(572, 390);
            this.pctHumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctHumo.Name = "pctHumo";
            this.pctHumo.Size = new System.Drawing.Size(88, 76);
            this.pctHumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHumo.TabIndex = 6;
            this.pctHumo.TabStop = false;
            // 
            // pctFuego
            // 
            this.pctFuego.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctFuego.Location = new System.Drawing.Point(426, 390);
            this.pctFuego.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctFuego.Name = "pctFuego";
            this.pctFuego.Size = new System.Drawing.Size(88, 76);
            this.pctFuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFuego.TabIndex = 5;
            this.pctFuego.TabStop = false;
            // 
            // lblAlarma1
            // 
            this.lblAlarma1.AutoSize = true;
            this.lblAlarma1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlarma1.Location = new System.Drawing.Point(534, 340);
            this.lblAlarma1.Name = "lblAlarma1";
            this.lblAlarma1.Size = new System.Drawing.Size(154, 30);
            this.lblAlarma1.TabIndex = 4;
            this.lblAlarma1.Text = "Tipo de Alarma";
            // 
            // lblArea1
            // 
            this.lblArea1.AutoSize = true;
            this.lblArea1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArea1.Location = new System.Drawing.Point(288, 208);
            this.lblArea1.Name = "lblArea1";
            this.lblArea1.Size = new System.Drawing.Size(61, 30);
            this.lblArea1.TabIndex = 3;
            this.lblArea1.Text = "Area:";
            // 
            // pctAlerta
            // 
            this.pctAlerta.Image = ((System.Drawing.Image)(resources.GetObject("pctAlerta.Image")));
            this.pctAlerta.Location = new System.Drawing.Point(832, 311);
            this.pctAlerta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctAlerta.Name = "pctAlerta";
            this.pctAlerta.Size = new System.Drawing.Size(200, 172);
            this.pctAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAlerta.TabIndex = 2;
            this.pctAlerta.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAdmUbicaciones);
            this.tabPage3.Controls.Add(this.btnLimpiar);
            this.tabPage3.Controls.Add(this.btnCargar);
            this.tabPage3.Controls.Add(this.checkBoxActivo);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.dataHistorial);
            this.tabPage3.Controls.Add(this.dataDispositivos);
            this.tabPage3.Controls.Add(this.btnBuscarDispositivos);
            this.tabPage3.Controls.Add(this.lblAccion);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtCodgo);
            this.tabPage3.Controls.Add(this.btnCrear);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.cBoxUbicacion);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1036, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dispositivos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAdmUbicaciones
            // 
            this.btnAdmUbicaciones.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdmUbicaciones.Location = new System.Drawing.Point(144, 414);
            this.btnAdmUbicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmUbicaciones.Name = "btnAdmUbicaciones";
            this.btnAdmUbicaciones.Size = new System.Drawing.Size(111, 43);
            this.btnAdmUbicaciones.TabIndex = 65;
            this.btnAdmUbicaciones.Text = "Adm. Ubicaciones";
            this.btnAdmUbicaciones.UseVisualStyleBackColor = true;
            this.btnAdmUbicaciones.Click += new System.EventHandler(this.btnAdmUbicaciones_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(27, 414);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 43);
            this.btnLimpiar.TabIndex = 64;
            this.btnLimpiar.Text = "Limpiar Todo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargar.Location = new System.Drawing.Point(144, 362);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(111, 43);
            this.btnCargar.TabIndex = 63;
            this.btnCargar.Text = "Cargar Dispositivo";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxActivo.Location = new System.Drawing.Point(35, 215);
            this.checkBoxActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(131, 29);
            this.checkBoxActivo.TabIndex = 61;
            this.checkBoxActivo.Text = "Esta Activo?";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHistUbicacion);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.pctminihumo);
            this.groupBox1.Controls.Add(this.pctminicalor);
            this.groupBox1.Controls.Add(this.pctminifuego);
            this.groupBox1.Controls.Add(this.lblHistRespuesta);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblHistFecha);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblHistTemperatura);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblHistDispositivo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(718, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(299, 425);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // lblHistUbicacion
            // 
            this.lblHistUbicacion.AutoSize = true;
            this.lblHistUbicacion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistUbicacion.Location = new System.Drawing.Point(18, 209);
            this.lblHistUbicacion.Name = "lblHistUbicacion";
            this.lblHistUbicacion.Size = new System.Drawing.Size(156, 25);
            this.lblHistUbicacion.TabIndex = 72;
            this.lblHistUbicacion.Text = "__________________";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(18, 184);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 25);
            this.label19.TabIndex = 71;
            this.label19.Text = "Ubicacion";
            // 
            // pctminihumo
            // 
            this.pctminihumo.Location = new System.Drawing.Point(135, 127);
            this.pctminihumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctminihumo.Name = "pctminihumo";
            this.pctminihumo.Size = new System.Drawing.Size(44, 38);
            this.pctminihumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctminihumo.TabIndex = 70;
            this.pctminihumo.TabStop = false;
            // 
            // pctminicalor
            // 
            this.pctminicalor.Location = new System.Drawing.Point(78, 127);
            this.pctminicalor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctminicalor.Name = "pctminicalor";
            this.pctminicalor.Size = new System.Drawing.Size(44, 38);
            this.pctminicalor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctminicalor.TabIndex = 69;
            this.pctminicalor.TabStop = false;
            // 
            // pctminifuego
            // 
            this.pctminifuego.Location = new System.Drawing.Point(18, 127);
            this.pctminifuego.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctminifuego.Name = "pctminifuego";
            this.pctminifuego.Size = new System.Drawing.Size(44, 38);
            this.pctminifuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctminifuego.TabIndex = 68;
            this.pctminifuego.TabStop = false;
            // 
            // lblHistRespuesta
            // 
            this.lblHistRespuesta.AutoSize = true;
            this.lblHistRespuesta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistRespuesta.Location = new System.Drawing.Point(18, 382);
            this.lblHistRespuesta.Name = "lblHistRespuesta";
            this.lblHistRespuesta.Size = new System.Drawing.Size(156, 25);
            this.lblHistRespuesta.TabIndex = 67;
            this.lblHistRespuesta.Text = "__________________";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(18, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 25);
            this.label14.TabIndex = 66;
            this.label14.Text = "Respuesta";
            // 
            // lblHistFecha
            // 
            this.lblHistFecha.AutoSize = true;
            this.lblHistFecha.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistFecha.Location = new System.Drawing.Point(18, 318);
            this.lblHistFecha.Name = "lblHistFecha";
            this.lblHistFecha.Size = new System.Drawing.Size(156, 25);
            this.lblHistFecha.TabIndex = 65;
            this.lblHistFecha.Text = "__________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(18, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 25);
            this.label12.TabIndex = 64;
            this.label12.Text = "Fecha";
            // 
            // lblHistTemperatura
            // 
            this.lblHistTemperatura.AutoSize = true;
            this.lblHistTemperatura.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistTemperatura.Location = new System.Drawing.Point(18, 262);
            this.lblHistTemperatura.Name = "lblHistTemperatura";
            this.lblHistTemperatura.Size = new System.Drawing.Size(156, 25);
            this.lblHistTemperatura.TabIndex = 63;
            this.lblHistTemperatura.Text = "__________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(18, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 62;
            this.label10.Text = "Temperatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(18, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 61;
            this.label8.Text = "Tipo de Alerta";
            // 
            // lblHistDispositivo
            // 
            this.lblHistDispositivo.AutoSize = true;
            this.lblHistDispositivo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistDispositivo.Location = new System.Drawing.Point(18, 68);
            this.lblHistDispositivo.Name = "lblHistDispositivo";
            this.lblHistDispositivo.Size = new System.Drawing.Size(156, 25);
            this.lblHistDispositivo.TabIndex = 60;
            this.lblHistDispositivo.Text = "__________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Dispositivo";
            // 
            // dataHistorial
            // 
            this.dataHistorial.AllowUserToAddRows = false;
            this.dataHistorial.AllowUserToDeleteRows = false;
            this.dataHistorial.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistorial.Location = new System.Drawing.Point(261, 314);
            this.dataHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataHistorial.Name = "dataHistorial";
            this.dataHistorial.ReadOnly = true;
            this.dataHistorial.RowHeadersWidth = 51;
            this.dataHistorial.RowTemplate.Height = 29;
            this.dataHistorial.Size = new System.Drawing.Size(451, 142);
            this.dataHistorial.TabIndex = 59;
            this.dataHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHistorial_CellContentClick);
            // 
            // dataDispositivos
            // 
            this.dataDispositivos.AllowUserToAddRows = false;
            this.dataDispositivos.AllowUserToDeleteRows = false;
            this.dataDispositivos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDispositivos.Location = new System.Drawing.Point(261, 97);
            this.dataDispositivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataDispositivos.Name = "dataDispositivos";
            this.dataDispositivos.ReadOnly = true;
            this.dataDispositivos.RowHeadersWidth = 51;
            this.dataDispositivos.RowTemplate.Height = 29;
            this.dataDispositivos.Size = new System.Drawing.Size(451, 142);
            this.dataDispositivos.TabIndex = 58;
            this.dataDispositivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDispositivos_CellContentClick);
            // 
            // btnBuscarDispositivos
            // 
            this.btnBuscarDispositivos.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarDispositivos.Location = new System.Drawing.Point(27, 362);
            this.btnBuscarDispositivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarDispositivos.Name = "btnBuscarDispositivos";
            this.btnBuscarDispositivos.Size = new System.Drawing.Size(111, 43);
            this.btnBuscarDispositivos.TabIndex = 55;
            this.btnBuscarDispositivos.Text = "Buscar Dispositvos";
            this.btnBuscarDispositivos.UseVisualStyleBackColor = true;
            this.btnBuscarDispositivos.Click += new System.EventHandler(this.btnBuscarDispositivos_Click);
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccion.Location = new System.Drawing.Point(35, 32);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(180, 25);
            this.lblAccion.TabIndex = 54;
            this.lblAccion.Text = "Crear Dispositivo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(35, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 25);
            this.label16.TabIndex = 50;
            this.label16.Text = "Codigo";
            // 
            // txtCodgo
            // 
            this.txtCodgo.Location = new System.Drawing.Point(35, 118);
            this.txtCodgo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodgo.Name = "txtCodgo";
            this.txtCodgo.Size = new System.Drawing.Size(193, 23);
            this.txtCodgo.TabIndex = 49;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.Location = new System.Drawing.Point(27, 314);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(228, 43);
            this.btnCrear.TabIndex = 48;
            this.btnCrear.Text = "Crear Dispositivo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(261, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Historial";
            // 
            // cBoxUbicacion
            // 
            this.cBoxUbicacion.FormattingEnabled = true;
            this.cBoxUbicacion.Location = new System.Drawing.Point(35, 178);
            this.cBoxUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxUbicacion.Name = "cBoxUbicacion";
            this.cBoxUbicacion.Size = new System.Drawing.Size(193, 23);
            this.cBoxUbicacion.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(261, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dispositivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ubicacion";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 523);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctminihumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctminicalor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctminifuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDispositivos)).EndInit();
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
        private Label label7;
        private DataGridView dataAlertas;
        private Label lblTemperatura;
        private Label label18;
        private TabPage tabPage3;
        private Button btnBuscarDispositivos;
        private Label lblAccion;
        private Label label16;
        private TextBox txtCodgo;
        private Button btnCrear;
        private Label label4;
        private ComboBox cBoxUbicacion;
        private Label label3;
        private Label label2;
        private DataGridView dataHistorial;
        private DataGridView dataDispositivos;
        private GroupBox groupBox1;
        private Label lblHistUbicacion;
        private Label label19;
        private PictureBox pctminihumo;
        private PictureBox pctminicalor;
        private PictureBox pctminifuego;
        private Label lblHistRespuesta;
        private Label label14;
        private Label lblHistFecha;
        private Label label12;
        private Label lblHistTemperatura;
        private Label label10;
        private Label label8;
        private Label lblHistDispositivo;
        private Label label5;
        private CheckBox checkBoxActivo;
        private Button btnCargar;
        private Button btnLimpiar;
        private Button btnAdmUbicaciones;
    }
}