namespace CapaPresentacion
{
    partial class FrmConsultaCategorias
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
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.btnTodosLibros = new System.Windows.Forms.Button();
            this.btnLibrosPrestables = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnPrestables = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas por categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categorias: ";
            // 
            // cboCat
            // 
            this.cboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(214, 138);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(294, 24);
            this.cboCat.TabIndex = 2;
            // 
            // btnTodosLibros
            // 
            this.btnTodosLibros.Location = new System.Drawing.Point(214, 186);
            this.btnTodosLibros.Name = "btnTodosLibros";
            this.btnTodosLibros.Size = new System.Drawing.Size(294, 23);
            this.btnTodosLibros.TabIndex = 3;
            this.btnTodosLibros.Text = "Mostrar todos los libros de la categoria.";
            this.btnTodosLibros.UseVisualStyleBackColor = true;
            this.btnTodosLibros.Click += new System.EventHandler(this.btnTodosLibros_Click);
            // 
            // btnLibrosPrestables
            // 
            this.btnLibrosPrestables.Location = new System.Drawing.Point(214, 224);
            this.btnLibrosPrestables.Name = "btnLibrosPrestables";
            this.btnLibrosPrestables.Size = new System.Drawing.Size(294, 23);
            this.btnLibrosPrestables.TabIndex = 4;
            this.btnLibrosPrestables.Text = "Mostrar libros prestables";
            this.btnLibrosPrestables.UseVisualStyleBackColor = true;
            this.btnLibrosPrestables.Click += new System.EventHandler(this.btnLibrosPrestables_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(56, 313);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(621, 204);
            this.dgvLibros.TabIndex = 5;
            // 
            // btnPrestables
            // 
            this.btnPrestables.Location = new System.Drawing.Point(214, 259);
            this.btnPrestables.Name = "btnPrestables";
            this.btnPrestables.Size = new System.Drawing.Size(294, 23);
            this.btnPrestables.TabIndex = 6;
            this.btnPrestables.Text = "Mostrar libros prestables disponibles";
            this.btnPrestables.UseVisualStyleBackColor = true;
            this.btnPrestables.Click += new System.EventHandler(this.btnPrestables_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver al menú de consultas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmConsultaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(852, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrestables);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.btnLibrosPrestables);
            this.Controls.Add(this.btnTodosLibros);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaCategorias";
            this.Text = "FrmConsultaCategorias";
            this.Load += new System.EventHandler(this.FrmConsultaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.Button btnTodosLibros;
        private System.Windows.Forms.Button btnLibrosPrestables;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnPrestables;
        private System.Windows.Forms.Button button1;
    }
}