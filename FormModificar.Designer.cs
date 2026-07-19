namespace Proyecto_Veterinaria
{
    partial class FormModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificar));
            this.cmdMascotas = new System.Windows.Forms.ComboBox();
            this.gpModificarMascota = new System.Windows.Forms.GroupBox();
            this.txtNewPeso = new System.Windows.Forms.TextBox();
            this.txtNewEdad = new System.Windows.Forms.TextBox();
            this.txtNewRaza = new System.Windows.Forms.TextBox();
            this.txtNewNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbNewEspecie = new System.Windows.Forms.ComboBox();
            this.gpModificarMascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMascotas
            // 
            this.cmdMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMascotas.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMascotas.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdMascotas.FormattingEnabled = true;
            this.cmdMascotas.Location = new System.Drawing.Point(154, 54);
            this.cmdMascotas.Name = "cmdMascotas";
            this.cmdMascotas.Size = new System.Drawing.Size(121, 30);
            this.cmdMascotas.TabIndex = 0;
            this.cmdMascotas.SelectedIndexChanged += new System.EventHandler(this.cmdMascotas_SelectedIndexChanged);
            // 
            // gpModificarMascota
            // 
            this.gpModificarMascota.BackColor = System.Drawing.Color.Transparent;
            this.gpModificarMascota.Controls.Add(this.cbNewEspecie);
            this.gpModificarMascota.Controls.Add(this.txtNewPeso);
            this.gpModificarMascota.Controls.Add(this.txtNewEdad);
            this.gpModificarMascota.Controls.Add(this.txtNewRaza);
            this.gpModificarMascota.Controls.Add(this.txtNewNombre);
            this.gpModificarMascota.Controls.Add(this.label5);
            this.gpModificarMascota.Controls.Add(this.label4);
            this.gpModificarMascota.Controls.Add(this.label3);
            this.gpModificarMascota.Controls.Add(this.label2);
            this.gpModificarMascota.Controls.Add(this.label1);
            this.gpModificarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpModificarMascota.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpModificarMascota.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.gpModificarMascota.Location = new System.Drawing.Point(86, 109);
            this.gpModificarMascota.Name = "gpModificarMascota";
            this.gpModificarMascota.Size = new System.Drawing.Size(236, 248);
            this.gpModificarMascota.TabIndex = 1;
            this.gpModificarMascota.TabStop = false;
            this.gpModificarMascota.Text = "Modificar Datos Mascota";
            // 
            // txtNewPeso
            // 
            this.txtNewPeso.Location = new System.Drawing.Point(88, 170);
            this.txtNewPeso.Name = "txtNewPeso";
            this.txtNewPeso.Size = new System.Drawing.Size(100, 33);
            this.txtNewPeso.TabIndex = 30;
            // 
            // txtNewEdad
            // 
            this.txtNewEdad.Location = new System.Drawing.Point(89, 131);
            this.txtNewEdad.Name = "txtNewEdad";
            this.txtNewEdad.Size = new System.Drawing.Size(100, 33);
            this.txtNewEdad.TabIndex = 29;
            // 
            // txtNewRaza
            // 
            this.txtNewRaza.Location = new System.Drawing.Point(89, 92);
            this.txtNewRaza.Name = "txtNewRaza";
            this.txtNewRaza.Size = new System.Drawing.Size(100, 33);
            this.txtNewRaza.TabIndex = 28;
            // 
            // txtNewNombre
            // 
            this.txtNewNombre.Location = new System.Drawing.Point(93, 48);
            this.txtNewNombre.Name = "txtNewNombre";
            this.txtNewNombre.Size = new System.Drawing.Size(100, 33);
            this.txtNewNombre.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Especie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Raza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnModificar.Location = new System.Drawing.Point(134, 384);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(167, 35);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Mascota";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Moccasin;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnActualizar.Location = new System.Drawing.Point(174, 431);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 29);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar Mascotas";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cbNewEspecie
            // 
            this.cbNewEspecie.FormattingEnabled = true;
            this.cbNewEspecie.Location = new System.Drawing.Point(93, 210);
            this.cbNewEspecie.Name = "cbNewEspecie";
            this.cbNewEspecie.Size = new System.Drawing.Size(121, 30);
            this.cbNewEspecie.TabIndex = 31;
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 511);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gpModificarMascota);
            this.Controls.Add(this.cmdMascotas);
            this.Name = "FormModificar";
            this.Text = "FormModificar";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            this.gpModificarMascota.ResumeLayout(false);
            this.gpModificarMascota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdMascotas;
        private System.Windows.Forms.GroupBox gpModificarMascota;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPeso;
        private System.Windows.Forms.TextBox txtNewEdad;
        private System.Windows.Forms.TextBox txtNewRaza;
        private System.Windows.Forms.TextBox txtNewNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbNewEspecie;
    }
}