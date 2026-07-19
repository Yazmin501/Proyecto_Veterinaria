namespace Proyecto_Veterinaria
{
    partial class FormCargarArchivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargarArchivo));
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.dtViewMascotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Samsung SVD_Medium_JP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCargarArchivo.Location = new System.Drawing.Point(155, 83);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(116, 32);
            this.btnCargarArchivo.TabIndex = 1;
            this.btnCargarArchivo.Text = "Cargar Archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // dtViewMascotas
            // 
            this.dtViewMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtViewMascotas.Location = new System.Drawing.Point(70, 136);
            this.dtViewMascotas.Name = "dtViewMascotas";
            this.dtViewMascotas.Size = new System.Drawing.Size(312, 189);
            this.dtViewMascotas.TabIndex = 2;
            // 
            // FormCargarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 503);
            this.Controls.Add(this.dtViewMascotas);
            this.Controls.Add(this.btnCargarArchivo);
            this.Name = "FormCargarArchivo";
            this.Text = "FormCargarArchivo";
            ((System.ComponentModel.ISupportInitialize)(this.dtViewMascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.DataGridView dtViewMascotas;
    }
}