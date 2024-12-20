﻿namespace UI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAlumnos = new Button();
            btnLibros = new Button();
            btnPrestamos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft New Tai Lue", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(265, 43);
            label1.TabIndex = 0;
            label1.Text = "BIBLIOTECA UAI";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnAlumnos
            // 
            btnAlumnos.BackColor = Color.Brown;
            btnAlumnos.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlumnos.Location = new Point(72, 70);
            btnAlumnos.Margin = new Padding(3, 4, 3, 4);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(178, 98);
            btnAlumnos.TabIndex = 1;
            btnAlumnos.Text = "GESTIONAR ALUMNOS";
            btnAlumnos.TextAlign = ContentAlignment.BottomCenter;
            btnAlumnos.UseVisualStyleBackColor = false;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnLibros
            // 
            btnLibros.BackColor = Color.Brown;
            btnLibros.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLibros.Location = new Point(72, 175);
            btnLibros.Margin = new Padding(3, 4, 3, 4);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(178, 98);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "GESTIONAR LIBROS";
            btnLibros.TextAlign = ContentAlignment.BottomCenter;
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.Brown;
            btnPrestamos.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrestamos.Location = new Point(72, 280);
            btnPrestamos.Margin = new Padding(3, 4, 3, 4);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(178, 98);
            btnPrestamos.TabIndex = 3;
            btnPrestamos.Text = "GESTIONAR PRESTAMOS";
            btnPrestamos.TextAlign = ContentAlignment.BottomCenter;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Brown;
            btnSalir.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(203, 399);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 43);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(328, 457);
            Controls.Add(btnSalir);
            Controls.Add(btnPrestamos);
            Controls.Add(btnLibros);
            Controls.Add(btnAlumnos);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAlumnos;
        private Button btnLibros;
        private Button btnPrestamos;
        private Button btnSalir;
    }
}
