namespace UI
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
<<<<<<< HEAD
            button1 = new Button();
=======
            btnSalir = new Button();
>>>>>>> test
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft New Tai Lue", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
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
            btnAlumnos.Location = new Point(63, 55);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(156, 77);
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
            btnLibros.Location = new Point(63, 138);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(156, 77);
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
            btnPrestamos.Location = new Point(63, 221);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(156, 77);
            btnPrestamos.TabIndex = 3;
            btnPrestamos.Text = "GESTIONAR PRESTAMOS";
            btnPrestamos.TextAlign = ContentAlignment.BottomCenter;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
<<<<<<< HEAD
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(178, 315);
            button1.Name = "button1";
            button1.Size = new Size(97, 34);
            button1.TabIndex = 4;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
=======
            // btnSalir
            // 
            btnSalir.BackColor = Color.Brown;
            btnSalir.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(178, 315);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
>>>>>>> test
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(287, 361);
<<<<<<< HEAD
            Controls.Add(button1);
=======
            Controls.Add(btnSalir);
>>>>>>> test
            Controls.Add(btnPrestamos);
            Controls.Add(btnLibros);
            Controls.Add(btnAlumnos);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            Name = "Main";
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
<<<<<<< HEAD
        private Button button1;
=======
        private Button btnSalir;
>>>>>>> test
    }
}
