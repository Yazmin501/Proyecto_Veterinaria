namespace Proyecto_Veterinaria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificarMascota = new System.Windows.Forms.Button();
            this.btnEliminarMascota = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnServicios);
            this.panel1.Controls.Add(this.btnEliminarMascota);
            this.panel1.Controls.Add(this.btnModificarMascota);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 446);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnModificarMascota
            // 
            this.btnModificarMascota.Location = new System.Drawing.Point(51, 325);
            this.btnModificarMascota.Name = "btnModificarMascota";
            this.btnModificarMascota.Size = new System.Drawing.Size(181, 65);
            this.btnModificarMascota.TabIndex = 0;
            this.btnModificarMascota.Text = "Modificar Mascota";
            this.btnModificarMascota.UseVisualStyleBackColor = true;
            this.btnModificarMascota.Click += new System.EventHandler(this.btnModificarMascota_Click);
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.Location = new System.Drawing.Point(445, 168);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(199, 65);
            this.btnEliminarMascota.TabIndex = 1;
            this.btnEliminarMascota.Text = "Eliminar Mascota";
            this.btnEliminarMascota.UseVisualStyleBackColor = true;
            this.btnEliminarMascota.Click += new System.EventHandler(this.btnEliminarMascota_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Location = new System.Drawing.Point(305, 322);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(199, 68);
            this.btnServicios.TabIndex = 2;
            this.btnServicios.Text = "Servicios y Pagos";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 68);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cargar Archivo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 1252);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.Button btnModificarMascota;
    }
}

