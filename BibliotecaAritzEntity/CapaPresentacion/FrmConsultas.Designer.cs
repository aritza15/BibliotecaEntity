namespace CapaPresentacion
{
    partial class FrmConsultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMoroso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas";
            // 
            // btnCat
            // 
            this.btnCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.Location = new System.Drawing.Point(71, 170);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(158, 139);
            this.btnCat.TabIndex = 1;
            this.btnCat.Text = "Consultas por categorias";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.Location = new System.Drawing.Point(299, 170);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(174, 139);
            this.btnAutor.TabIndex = 2;
            this.btnAutor.Text = "Consultas por autor";
            this.btnAutor.UseVisualStyleBackColor = true;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(203, 382);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(352, 40);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver al menú principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMoroso
            // 
            this.btnMoroso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoroso.Location = new System.Drawing.Point(560, 170);
            this.btnMoroso.Name = "btnMoroso";
            this.btnMoroso.Size = new System.Drawing.Size(174, 139);
            this.btnMoroso.TabIndex = 4;
            this.btnMoroso.Text = "Consultas de morosos";
            this.btnMoroso.UseVisualStyleBackColor = true;
            this.btnMoroso.Click += new System.EventHandler(this.btnMoroso_Click);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoroso);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultas";
            this.Text = "FrmConsultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMoroso;
    }
}