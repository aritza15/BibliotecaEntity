namespace CapaPresentacion
{
    partial class FrmPrestamos
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.lstSeleccionados = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNcarnet = new System.Windows.Forms.TextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamos de libros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teclea el título del libro";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(284, 157);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(198, 22);
            this.txtTitulo.TabIndex = 3;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.ItemHeight = 16;
            this.lstLibros.Location = new System.Drawing.Point(284, 225);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(198, 100);
            this.lstLibros.TabIndex = 4;
            this.lstLibros.SelectedIndexChanged += new System.EventHandler(this.lstLibros_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecciona el libro que quieres ";
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Location = new System.Drawing.Point(284, 525);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(198, 46);
            this.btnPrestamo.TabIndex = 6;
            this.btnPrestamo.Text = "Pedir libro";
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // lstSeleccionados
            // 
            this.lstSeleccionados.FormattingEnabled = true;
            this.lstSeleccionados.ItemHeight = 16;
            this.lstSeleccionados.Location = new System.Drawing.Point(515, 225);
            this.lstSeleccionados.Name = "lstSeleccionados";
            this.lstSeleccionados.Size = new System.Drawing.Size(198, 100);
            this.lstSeleccionados.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Introduce tu numero de carnet";
            // 
            // txtNcarnet
            // 
            this.txtNcarnet.Location = new System.Drawing.Point(284, 456);
            this.txtNcarnet.Name = "txtNcarnet";
            this.txtNcarnet.Size = new System.Drawing.Size(87, 22);
            this.txtNcarnet.TabIndex = 9;
            this.txtNcarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNcarnet_KeyPress_1);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(719, 243);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(118, 56);
            this.btnAnular.TabIndex = 10;
            this.btnAnular.Text = "Anular seleccionado";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(527, 525);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(170, 46);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(849, 596);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.txtNcarnet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSeleccionados);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrestamos";
            this.Text = "FrmPrestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.ListBox lstSeleccionados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNcarnet;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnVolver;
    }
}