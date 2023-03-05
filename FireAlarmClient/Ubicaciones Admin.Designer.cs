namespace FireAlarmClient
{
    partial class AdmUbicaciones
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
            this.dataAdmUbicaciones = new System.Windows.Forms.DataGridView();
            this.lblAdmUbicacnes = new System.Windows.Forms.Label();
            this.txtAdmUbicaciones = new System.Windows.Forms.TextBox();
            this.btnLimpiarUbicaciones = new System.Windows.Forms.Button();
            this.btnCrearUbicaciones = new System.Windows.Forms.Button();
            this.btnBuscarUbicaciones = new System.Windows.Forms.Button();
            this.checkUbicacionActiva = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdmUbicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAdmUbicaciones
            // 
            this.dataAdmUbicaciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataAdmUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdmUbicaciones.Location = new System.Drawing.Point(357, 12);
            this.dataAdmUbicaciones.Name = "dataAdmUbicaciones";
            this.dataAdmUbicaciones.RowHeadersWidth = 51;
            this.dataAdmUbicaciones.RowTemplate.Height = 29;
            this.dataAdmUbicaciones.Size = new System.Drawing.Size(300, 282);
            this.dataAdmUbicaciones.TabIndex = 0;
            this.dataAdmUbicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAdmUbicaciones_CellContentClick);
            // 
            // lblAdmUbicacnes
            // 
            this.lblAdmUbicacnes.AutoSize = true;
            this.lblAdmUbicacnes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdmUbicacnes.Location = new System.Drawing.Point(12, 12);
            this.lblAdmUbicacnes.Name = "lblAdmUbicacnes";
            this.lblAdmUbicacnes.Size = new System.Drawing.Size(204, 32);
            this.lblAdmUbicacnes.TabIndex = 1;
            this.lblAdmUbicacnes.Text = "Crear Ubicaciones";
            // 
            // txtAdmUbicaciones
            // 
            this.txtAdmUbicaciones.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdmUbicaciones.Location = new System.Drawing.Point(12, 70);
            this.txtAdmUbicaciones.Name = "txtAdmUbicaciones";
            this.txtAdmUbicaciones.Size = new System.Drawing.Size(339, 39);
            this.txtAdmUbicaciones.TabIndex = 2;
            // 
            // btnLimpiarUbicaciones
            // 
            this.btnLimpiarUbicaciones.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarUbicaciones.Location = new System.Drawing.Point(12, 248);
            this.btnLimpiarUbicaciones.Name = "btnLimpiarUbicaciones";
            this.btnLimpiarUbicaciones.Size = new System.Drawing.Size(145, 46);
            this.btnLimpiarUbicaciones.TabIndex = 3;
            this.btnLimpiarUbicaciones.Text = "Limpiar";
            this.btnLimpiarUbicaciones.UseVisualStyleBackColor = true;
            this.btnLimpiarUbicaciones.Click += new System.EventHandler(this.btnLimpiarUbicaciones_Click);
            // 
            // btnCrearUbicaciones
            // 
            this.btnCrearUbicaciones.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearUbicaciones.Location = new System.Drawing.Point(12, 186);
            this.btnCrearUbicaciones.Name = "btnCrearUbicaciones";
            this.btnCrearUbicaciones.Size = new System.Drawing.Size(339, 46);
            this.btnCrearUbicaciones.TabIndex = 4;
            this.btnCrearUbicaciones.Text = "Crear Ubicacion";
            this.btnCrearUbicaciones.UseVisualStyleBackColor = true;
            this.btnCrearUbicaciones.Click += new System.EventHandler(this.btnCrearUbicaciones_Click);
            // 
            // btnBuscarUbicaciones
            // 
            this.btnBuscarUbicaciones.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarUbicaciones.Location = new System.Drawing.Point(206, 248);
            this.btnBuscarUbicaciones.Name = "btnBuscarUbicaciones";
            this.btnBuscarUbicaciones.Size = new System.Drawing.Size(145, 46);
            this.btnBuscarUbicaciones.TabIndex = 5;
            this.btnBuscarUbicaciones.Text = "Buscar";
            this.btnBuscarUbicaciones.UseVisualStyleBackColor = true;
            this.btnBuscarUbicaciones.Click += new System.EventHandler(this.btnBuscarUbicaciones_Click);
            // 
            // checkUbicacionActiva
            // 
            this.checkUbicacionActiva.AutoSize = true;
            this.checkUbicacionActiva.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkUbicacionActiva.Location = new System.Drawing.Point(12, 115);
            this.checkUbicacionActiva.Name = "checkUbicacionActiva";
            this.checkUbicacionActiva.Size = new System.Drawing.Size(160, 36);
            this.checkUbicacionActiva.TabIndex = 6;
            this.checkUbicacionActiva.Text = "Esta Activa?";
            this.checkUbicacionActiva.UseVisualStyleBackColor = true;
            // 
            // AdmUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 306);
            this.Controls.Add(this.checkUbicacionActiva);
            this.Controls.Add(this.btnBuscarUbicaciones);
            this.Controls.Add(this.btnCrearUbicaciones);
            this.Controls.Add(this.btnLimpiarUbicaciones);
            this.Controls.Add(this.txtAdmUbicaciones);
            this.Controls.Add(this.lblAdmUbicacnes);
            this.Controls.Add(this.dataAdmUbicaciones);
            this.MaximizeBox = false;
            this.Name = "AdmUbicaciones";
            this.Text = "Administrar Ubicaciones";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAdmUbicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataAdmUbicaciones;
        private Label lblAdmUbicacnes;
        private TextBox txtAdmUbicaciones;
        private Button btnLimpiarUbicaciones;
        private Button btnCrearUbicaciones;
        private Button btnBuscarUbicaciones;
        private CheckBox checkUbicacionActiva;
    }
}