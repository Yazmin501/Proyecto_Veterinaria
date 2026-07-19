namespace Proyecto_Veterinaria
{
    partial class agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.btnRegistrarMascota = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.picPez = new System.Windows.Forms.PictureBox();
            this.picGato = new System.Windows.Forms.PictureBox();
            this.picAve = new System.Windows.Forms.PictureBox();
            this.picRoedor = new System.Windows.Forms.PictureBox();
            this.picPerro = new System.Windows.Forms.PictureBox();
            this.rdPerro = new System.Windows.Forms.RadioButton();
            this.rdRoedor = new System.Windows.Forms.RadioButton();
            this.rdGato = new System.Windows.Forms.RadioButton();
            this.rdPez = new System.Windows.Forms.RadioButton();
            this.rdAve = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Raza";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(183, 207);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(183, 175);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(183, 142);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 20);
            this.txtRaza.TabIndex = 8;
            // 
            // btnRegistrarMascota
            // 
            this.btnRegistrarMascota.Location = new System.Drawing.Point(238, 326);
            this.btnRegistrarMascota.Name = "btnRegistrarMascota";
            this.btnRegistrarMascota.Size = new System.Drawing.Size(125, 40);
            this.btnRegistrarMascota.TabIndex = 10;
            this.btnRegistrarMascota.Text = "Registrar Mascota";
            this.btnRegistrarMascota.UseVisualStyleBackColor = true;
            this.btnRegistrarMascota.Click += new System.EventHandler(this.btnRegistrarMascota_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(460, 326);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 40);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // picPez
            // 
            this.picPez.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPez.BackgroundImage")));
            this.picPez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPez.Location = new System.Drawing.Point(427, 98);
            this.picPez.Name = "picPez";
            this.picPez.Size = new System.Drawing.Size(170, 141);
            this.picPez.TabIndex = 13;
            this.picPez.TabStop = false;
            this.picPez.Click += new System.EventHandler(this.picPez_Click);
            // 
            // picGato
            // 
            this.picGato.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGato.BackgroundImage")));
            this.picGato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGato.Location = new System.Drawing.Point(411, 86);
            this.picGato.Name = "picGato";
            this.picGato.Size = new System.Drawing.Size(170, 141);
            this.picGato.TabIndex = 14;
            this.picGato.TabStop = false;
            this.picGato.Click += new System.EventHandler(this.picGato_Click);
            // 
            // picAve
            // 
            this.picAve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAve.BackgroundImage")));
            this.picAve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAve.Location = new System.Drawing.Point(411, 98);
            this.picAve.Name = "picAve";
            this.picAve.Size = new System.Drawing.Size(170, 141);
            this.picAve.TabIndex = 15;
            this.picAve.TabStop = false;
            this.picAve.Click += new System.EventHandler(this.picAve_Click);
            // 
            // picRoedor
            // 
            this.picRoedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRoedor.BackgroundImage")));
            this.picRoedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoedor.Location = new System.Drawing.Point(411, 98);
            this.picRoedor.Name = "picRoedor";
            this.picRoedor.Size = new System.Drawing.Size(170, 141);
            this.picRoedor.TabIndex = 17;
            this.picRoedor.TabStop = false;
            this.picRoedor.Click += new System.EventHandler(this.picRoedor_Click);
            // 
            // picPerro
            // 
            this.picPerro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPerro.BackgroundImage")));
            this.picPerro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPerro.Location = new System.Drawing.Point(411, 98);
            this.picPerro.Name = "picPerro";
            this.picPerro.Size = new System.Drawing.Size(186, 161);
            this.picPerro.TabIndex = 18;
            this.picPerro.TabStop = false;
            // 
            // rdPerro
            // 
            this.rdPerro.AutoSize = true;
            this.rdPerro.Location = new System.Drawing.Point(183, 241);
            this.rdPerro.Name = "rdPerro";
            this.rdPerro.Size = new System.Drawing.Size(50, 17);
            this.rdPerro.TabIndex = 19;
            this.rdPerro.TabStop = true;
            this.rdPerro.Text = "Perro";
            this.rdPerro.UseVisualStyleBackColor = true;
            this.rdPerro.CheckedChanged += new System.EventHandler(this.rdPerro_CheckedChanged);
            // 
            // rdRoedor
            // 
            this.rdRoedor.AutoSize = true;
            this.rdRoedor.Location = new System.Drawing.Point(278, 241);
            this.rdRoedor.Name = "rdRoedor";
            this.rdRoedor.Size = new System.Drawing.Size(60, 17);
            this.rdRoedor.TabIndex = 20;
            this.rdRoedor.TabStop = true;
            this.rdRoedor.Text = "Roedor";
            this.rdRoedor.UseVisualStyleBackColor = true;
            this.rdRoedor.CheckedChanged += new System.EventHandler(this.rdRoedor_CheckedChanged);
            // 
            // rdGato
            // 
            this.rdGato.AutoSize = true;
            this.rdGato.Location = new System.Drawing.Point(183, 264);
            this.rdGato.Name = "rdGato";
            this.rdGato.Size = new System.Drawing.Size(48, 17);
            this.rdGato.TabIndex = 21;
            this.rdGato.TabStop = true;
            this.rdGato.Text = "Gato";
            this.rdGato.UseVisualStyleBackColor = true;
            this.rdGato.CheckedChanged += new System.EventHandler(this.rdGato_CheckedChanged);
            // 
            // rdPez
            // 
            this.rdPez.AutoSize = true;
            this.rdPez.Location = new System.Drawing.Point(274, 264);
            this.rdPez.Name = "rdPez";
            this.rdPez.Size = new System.Drawing.Size(43, 17);
            this.rdPez.TabIndex = 22;
            this.rdPez.TabStop = true;
            this.rdPez.Text = "Pez";
            this.rdPez.UseVisualStyleBackColor = true;
            this.rdPez.CheckedChanged += new System.EventHandler(this.rdPez_CheckedChanged);
            // 
            // rdAve
            // 
            this.rdAve.AutoSize = true;
            this.rdAve.Location = new System.Drawing.Point(183, 287);
            this.rdAve.Name = "rdAve";
            this.rdAve.Size = new System.Drawing.Size(44, 17);
            this.rdAve.TabIndex = 23;
            this.rdAve.TabStop = true;
            this.rdAve.Text = "Ave";
            this.rdAve.UseVisualStyleBackColor = true;
            this.rdAve.CheckedChanged += new System.EventHandler(this.rdAve_CheckedChanged);
            // 
            // agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Veterinaria.Properties.Resources.เวกเตอร์ฟรี_____ชื่อ__;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 390);
            this.Controls.Add(this.rdAve);
            this.Controls.Add(this.rdPez);
            this.Controls.Add(this.rdGato);
            this.Controls.Add(this.rdRoedor);
            this.Controls.Add(this.rdPerro);
            this.Controls.Add(this.picPerro);
            this.Controls.Add(this.picRoedor);
            this.Controls.Add(this.picAve);
            this.Controls.Add(this.picGato);
            this.Controls.Add(this.picPez);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrarMascota);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "agregar";
            this.Text = "agregar";
            this.Load += new System.EventHandler(this.agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtRaza;
      
        private System.Windows.Forms.Button btnRegistrarMascota;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox picPez;
        private System.Windows.Forms.PictureBox picGato;
        private System.Windows.Forms.PictureBox picAve;
        private System.Windows.Forms.PictureBox picRoedor;
        private System.Windows.Forms.PictureBox picPerro;
        private System.Windows.Forms.RadioButton rdPerro;
        private System.Windows.Forms.RadioButton rdRoedor;
        private System.Windows.Forms.RadioButton rdGato;
        private System.Windows.Forms.RadioButton rdPez;
        private System.Windows.Forms.RadioButton rdAve;
    }
}