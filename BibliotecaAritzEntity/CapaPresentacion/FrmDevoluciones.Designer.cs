namespace CapaPresentacion
{
    partial class FrmDevoluciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNcarnet = new System.Windows.Forms.TextBox();
            this.dgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce tu número de carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Devoluciones";
            // 
            // txtNcarnet
            // 
            this.txtNcarnet.Location = new System.Drawing.Point(322, 140);
            this.txtNcarnet.Name = "txtNcarnet";
            this.txtNcarnet.Size = new System.Drawing.Size(170, 22);
            this.txtNcarnet.TabIndex = 2;
            this.txtNcarnet.TextChanged += new System.EventHandler(this.txtNcarnet_TextChanged);
            // 
            // dgvDevoluciones
            // 
            this.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevoluciones.Location = new System.Drawing.Point(48, 185);
            this.dgvDevoluciones.Name = "dgvDevoluciones";
            this.dgvDevoluciones.RowHeadersWidth = 51;
            this.dgvDevoluciones.RowTemplate.Height = 24;
            this.dgvDevoluciones.Size = new System.Drawing.Size(645, 137);
            this.dgvDevoluciones.TabIndex = 3;
            this.dgvDevoluciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevoluciones_CellClick);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(48, 344);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(193, 39);
            this.btnDevolver.TabIndex = 4;
            this.btnDevolver.Text = "Realizar devolución";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(360, 344);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(172, 39);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.dgvDevoluciones);
            this.Controls.Add(this.txtNcarnet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDevoluciones";
            this.Text = "FrmDevoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNcarnet;
        private System.Windows.Forms.DataGridView dgvDevoluciones;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnVolver;
    }
}