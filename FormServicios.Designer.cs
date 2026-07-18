namespace Proyecto_Veterinaria
{
    partial class FormServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicios));
            this.gpServicios = new System.Windows.Forms.GroupBox();
            this.chkConsulta = new System.Windows.Forms.CheckBox();
            this.chkVacuna = new System.Windows.Forms.CheckBox();
            this.chkDesparasitación = new System.Windows.Forms.CheckBox();
            this.chkEstetica = new System.Windows.Forms.CheckBox();
            this.chkHospedaje = new System.Windows.Forms.CheckBox();
            this.chkCirugia = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbRecibo = new System.Windows.Forms.GroupBox();
            this.lblRecibo = new System.Windows.Forms.Label();
            this.gpServicios.SuspendLayout();
            this.gbRecibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpServicios
            // 
            this.gpServicios.BackColor = System.Drawing.Color.Transparent;
            this.gpServicios.Controls.Add(this.chkCirugia);
            this.gpServicios.Controls.Add(this.chkHospedaje);
            this.gpServicios.Controls.Add(this.chkEstetica);
            this.gpServicios.Controls.Add(this.chkDesparasitación);
            this.gpServicios.Controls.Add(this.chkVacuna);
            this.gpServicios.Controls.Add(this.chkConsulta);
            this.gpServicios.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpServicios.Location = new System.Drawing.Point(69, 25);
            this.gpServicios.Name = "gpServicios";
            this.gpServicios.Size = new System.Drawing.Size(416, 373);
            this.gpServicios.TabIndex = 0;
            this.gpServicios.TabStop = false;
            this.gpServicios.Text = "Selección de Servicios";
            // 
            // chkConsulta
            // 
            this.chkConsulta.AutoSize = true;
            this.chkConsulta.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConsulta.Location = new System.Drawing.Point(66, 62);
            this.chkConsulta.Name = "chkConsulta";
            this.chkConsulta.Size = new System.Drawing.Size(152, 28);
            this.chkConsulta.TabIndex = 0;
            this.chkConsulta.Text = "Consulta";
            this.chkConsulta.UseVisualStyleBackColor = true;
            // 
            // chkVacuna
            // 
            this.chkVacuna.AutoSize = true;
            this.chkVacuna.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.chkVacuna.Location = new System.Drawing.Point(66, 109);
            this.chkVacuna.Name = "chkVacuna";
            this.chkVacuna.Size = new System.Drawing.Size(131, 28);
            this.chkVacuna.TabIndex = 1;
            this.chkVacuna.Text = "Vacuna";
            this.chkVacuna.UseVisualStyleBackColor = true;
            // 
            // chkDesparasitación
            // 
            this.chkDesparasitación.AutoSize = true;
            this.chkDesparasitación.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.chkDesparasitación.Location = new System.Drawing.Point(66, 157);
            this.chkDesparasitación.Name = "chkDesparasitación";
            this.chkDesparasitación.Size = new System.Drawing.Size(237, 28);
            this.chkDesparasitación.TabIndex = 2;
            this.chkDesparasitación.Text = "Desparasitación";
            this.chkDesparasitación.UseVisualStyleBackColor = true;
            this.chkDesparasitación.CheckedChanged += new System.EventHandler(this.chkDesparasitación_CheckedChanged);
            // 
            // chkEstetica
            // 
            this.chkEstetica.AutoSize = true;
            this.chkEstetica.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.chkEstetica.Location = new System.Drawing.Point(66, 209);
            this.chkEstetica.Name = "chkEstetica";
            this.chkEstetica.Size = new System.Drawing.Size(135, 28);
            this.chkEstetica.TabIndex = 3;
            this.chkEstetica.Text = "Estetica";
            this.chkEstetica.UseVisualStyleBackColor = true;
            // 
            // chkHospedaje
            // 
            this.chkHospedaje.AutoSize = true;
            this.chkHospedaje.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.chkHospedaje.Location = new System.Drawing.Point(66, 262);
            this.chkHospedaje.Name = "chkHospedaje";
            this.chkHospedaje.Size = new System.Drawing.Size(157, 28);
            this.chkHospedaje.TabIndex = 4;
            this.chkHospedaje.Text = "Hospedaje";
            this.chkHospedaje.UseVisualStyleBackColor = true;
            // 
            // chkCirugia
            // 
            this.chkCirugia.AutoSize = true;
            this.chkCirugia.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.chkCirugia.Location = new System.Drawing.Point(66, 316);
            this.chkCirugia.Name = "chkCirugia";
            this.chkCirugia.Size = new System.Drawing.Size(129, 28);
            this.chkCirugia.TabIndex = 5;
            this.chkCirugia.Text = "Cirugia";
            this.chkCirugia.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MistyRose;
            this.btnCalcular.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(593, 514);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(313, 92);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Generar Recibo";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbRecibo
            // 
            this.gbRecibo.BackColor = System.Drawing.Color.Transparent;
            this.gbRecibo.Controls.Add(this.lblRecibo);
            this.gbRecibo.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecibo.Location = new System.Drawing.Point(530, 25);
            this.gbRecibo.Name = "gbRecibo";
            this.gbRecibo.Size = new System.Drawing.Size(376, 429);
            this.gbRecibo.TabIndex = 2;
            this.gbRecibo.TabStop = false;
            this.gbRecibo.Text = "Recibo";
            // 
            // lblRecibo
            // 
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibo.Location = new System.Drawing.Point(15, 53);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(0, 24);
            this.lblRecibo.TabIndex = 0;
            this.lblRecibo.Click += new System.EventHandler(this.lblRecibo_Click);
            // 
            // FormServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 644);
            this.Controls.Add(this.gbRecibo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpServicios);
            this.Name = "FormServicios";
            this.Text = "FormServicios";
            this.gpServicios.ResumeLayout(false);
            this.gpServicios.PerformLayout();
            this.gbRecibo.ResumeLayout(false);
            this.gbRecibo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpServicios;
        private System.Windows.Forms.CheckBox chkCirugia;
        private System.Windows.Forms.CheckBox chkHospedaje;
        private System.Windows.Forms.CheckBox chkEstetica;
        private System.Windows.Forms.CheckBox chkDesparasitación;
        private System.Windows.Forms.CheckBox chkVacuna;
        private System.Windows.Forms.CheckBox chkConsulta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbRecibo;
        private System.Windows.Forms.Label lblRecibo;
    }
}