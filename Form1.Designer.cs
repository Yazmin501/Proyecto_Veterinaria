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
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnEliminarMascota = new System.Windows.Forms.Button();
            this.btnModificarMascota = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnCargarArchivo);
            this.panel1.Controls.Add(this.btnServicios);
            this.panel1.Controls.Add(this.btnEliminarMascota);
            this.panel1.Controls.Add(this.btnModificarMascota);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 259);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCargarArchivo.FlatAppearance.BorderSize = 0;
            this.btnCargarArchivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCargarArchivo.Location = new System.Drawing.Point(171, 97);
            this.btnCargarArchivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(121, 33);
            this.btnCargarArchivo.TabIndex = 3;
            this.btnCargarArchivo.Text = "Cargar Archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicios.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnServicios.Location = new System.Drawing.Point(334, 97);
            this.btnServicios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(133, 33);
            this.btnServicios.TabIndex = 2;
            this.btnServicios.Text = "Servicios y Pagos";
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEliminarMascota.FlatAppearance.BorderSize = 0;
            this.btnEliminarMascota.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.btnEliminarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarMascota.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMascota.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEliminarMascota.Location = new System.Drawing.Point(334, 40);
            this.btnEliminarMascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(133, 31);
            this.btnEliminarMascota.TabIndex = 1;
            this.btnEliminarMascota.Text = "Eliminar Mascota";
            this.btnEliminarMascota.UseVisualStyleBackColor = false;
            this.btnEliminarMascota.Click += new System.EventHandler(this.btnEliminarMascota_Click);
            // 
            // btnModificarMascota
            // 
            this.btnModificarMascota.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnModificarMascota.FlatAppearance.BorderSize = 0;
            this.btnModificarMascota.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.btnModificarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarMascota.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMascota.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnModificarMascota.Location = new System.Drawing.Point(171, 40);
            this.btnModificarMascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarMascota.Name = "btnModificarMascota";
            this.btnModificarMascota.Size = new System.Drawing.Size(142, 31);
            this.btnModificarMascota.TabIndex = 0;
            this.btnModificarMascota.Text = "Modificar Mascota";
            this.btnModificarMascota.UseVisualStyleBackColor = false;
            this.btnModificarMascota.Click += new System.EventHandler(this.btnModificarMascota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 487);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.Button btnModificarMascota;
    }
}

