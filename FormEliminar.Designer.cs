namespace Proyecto_Veterinaria
{
    partial class FormEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminar));
            this.cmdMascotas = new System.Windows.Forms.ComboBox();
            this.btnEliminarMascota = new System.Windows.Forms.Button();
            this.gpEliminar = new System.Windows.Forms.GroupBox();
            this.lbEspecie = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbRaza = new System.Windows.Forms.Label();
            this.lnNombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMascotas
            // 
            this.cmdMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMascotas.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMascotas.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdMascotas.FormattingEnabled = true;
            this.cmdMascotas.Location = new System.Drawing.Point(121, 58);
            this.cmdMascotas.Name = "cmdMascotas";
            this.cmdMascotas.Size = new System.Drawing.Size(121, 30);
            this.cmdMascotas.TabIndex = 0;
            this.cmdMascotas.SelectedIndexChanged += new System.EventHandler(this.cmdMascotas_SelectedIndexChanged);
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEliminarMascota.FlatAppearance.BorderSize = 0;
            this.btnEliminarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarMascota.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMascota.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEliminarMascota.Location = new System.Drawing.Point(121, 343);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(139, 35);
            this.btnEliminarMascota.TabIndex = 1;
            this.btnEliminarMascota.Text = "Eliminar Mascota";
            this.btnEliminarMascota.UseVisualStyleBackColor = false;
            this.btnEliminarMascota.Click += new System.EventHandler(this.btnEliminarMascota_Click);
            // 
            // gpEliminar
            // 
            this.gpEliminar.BackColor = System.Drawing.Color.Transparent;
            this.gpEliminar.Controls.Add(this.lbEspecie);
            this.gpEliminar.Controls.Add(this.lbPeso);
            this.gpEliminar.Controls.Add(this.lbEdad);
            this.gpEliminar.Controls.Add(this.lbRaza);
            this.gpEliminar.Controls.Add(this.lnNombre);
            this.gpEliminar.Controls.Add(this.label5);
            this.gpEliminar.Controls.Add(this.label4);
            this.gpEliminar.Controls.Add(this.label3);
            this.gpEliminar.Controls.Add(this.label2);
            this.gpEliminar.Controls.Add(this.label1);
            this.gpEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpEliminar.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEliminar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.gpEliminar.Location = new System.Drawing.Point(79, 99);
            this.gpEliminar.Name = "gpEliminar";
            this.gpEliminar.Size = new System.Drawing.Size(261, 223);
            this.gpEliminar.TabIndex = 12;
            this.gpEliminar.TabStop = false;
            this.gpEliminar.Text = "Información Mascota Eliminar";
            this.gpEliminar.Enter += new System.EventHandler(this.gpEliminar_Enter);
            // 
            // lbEspecie
            // 
            this.lbEspecie.AutoSize = true;
            this.lbEspecie.Location = new System.Drawing.Point(108, 176);
            this.lbEspecie.Name = "lbEspecie";
            this.lbEspecie.Size = new System.Drawing.Size(118, 22);
            this.lbEspecie.TabIndex = 21;
            this.lbEspecie.Text = "__________________";
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(108, 137);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(124, 22);
            this.lbPeso.TabIndex = 20;
            this.lbPeso.Text = "___________________";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(111, 104);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(118, 22);
            this.lbEdad.TabIndex = 19;
            this.lbEdad.Text = "__________________";
            // 
            // lbRaza
            // 
            this.lbRaza.AutoSize = true;
            this.lbRaza.Location = new System.Drawing.Point(117, 67);
            this.lbRaza.Name = "lbRaza";
            this.lbRaza.Size = new System.Drawing.Size(112, 22);
            this.lbRaza.TabIndex = 18;
            this.lbRaza.Text = "_________________";
            // 
            // lnNombre
            // 
            this.lnNombre.AutoSize = true;
            this.lnNombre.Location = new System.Drawing.Point(114, 29);
            this.lnNombre.Name = "lnNombre";
            this.lnNombre.Size = new System.Drawing.Size(112, 22);
            this.lnNombre.TabIndex = 17;
            this.lnNombre.Text = "_________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Especie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Raza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(425, 442);
            this.Controls.Add(this.btnEliminarMascota);
            this.Controls.Add(this.cmdMascotas);
            this.Controls.Add(this.gpEliminar);
            this.Name = "FormEliminar";
            this.Text = "FormEliminar";
            this.Load += new System.EventHandler(this.FormEliminar_Load);
            this.gpEliminar.ResumeLayout(false);
            this.gpEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdMascotas;
        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.GroupBox gpEliminar;
        private System.Windows.Forms.Label lbEspecie;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbRaza;
        private System.Windows.Forms.Label lnNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}