namespace UI
{
    partial class Prestamos
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
            groupBox1 = new GroupBox();
            btnPrestamo = new Button();
            comboLibroPrestamo = new ComboBox();
            txtAlumnoPrestamo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnDevolucion = new Button();
            txtAlumnoDevolucion = new TextBox();
            comboLibroDevolucion = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            btnMain = new Button();
            dataGridView1 = new DataGridView();
            IdPrestamo = new DataGridViewTextBoxColumn();
            IdLibro = new DataGridViewTextBoxColumn();
            DniAlumno = new DataGridViewTextBoxColumn();
            FechaPrestamo = new DataGridViewTextBoxColumn();
            FechaDevolucion = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPrestamo);
            groupBox1.Controls.Add(comboLibroPrestamo);
            groupBox1.Controls.Add(txtAlumnoPrestamo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prestamo";
            // 
            // btnPrestamo
            // 
            btnPrestamo.BackColor = Color.Brown;
            btnPrestamo.Location = new Point(33, 88);
            btnPrestamo.Name = "btnPrestamo";
            btnPrestamo.Size = new Size(133, 30);
            btnPrestamo.TabIndex = 4;
            btnPrestamo.Text = "Realizar prestamo";
            btnPrestamo.UseVisualStyleBackColor = false;
            // 
            // comboLibroPrestamo
            // 
            comboLibroPrestamo.FormattingEnabled = true;
            comboLibroPrestamo.Location = new Point(64, 55);
            comboLibroPrestamo.Name = "comboLibroPrestamo";
            comboLibroPrestamo.Size = new Size(130, 25);
            comboLibroPrestamo.TabIndex = 3;
            // 
            // txtAlumnoPrestamo
            // 
            txtAlumnoPrestamo.Location = new Point(64, 24);
            txtAlumnoPrestamo.Name = "txtAlumnoPrestamo";
            txtAlumnoPrestamo.Size = new Size(130, 25);
            txtAlumnoPrestamo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 55);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 1;
            label2.Text = "Libro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 0;
            label1.Text = "Alumno";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDevolucion);
            groupBox2.Controls.Add(txtAlumnoDevolucion);
            groupBox2.Controls.Add(comboLibroDevolucion);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 128);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Devolucion";
            // 
            // btnDevolucion
            // 
            btnDevolucion.BackColor = Color.Brown;
            btnDevolucion.Location = new Point(24, 88);
            btnDevolucion.Name = "btnDevolucion";
            btnDevolucion.Size = new Size(149, 30);
            btnDevolucion.TabIndex = 9;
            btnDevolucion.Text = "Confirmar devolucion";
            btnDevolucion.UseVisualStyleBackColor = false;
            // 
            // txtAlumnoDevolucion
            // 
            txtAlumnoDevolucion.Location = new Point(64, 24);
            txtAlumnoDevolucion.Name = "txtAlumnoDevolucion";
            txtAlumnoDevolucion.Size = new Size(130, 25);
            txtAlumnoDevolucion.TabIndex = 7;
            // 
            // comboLibroDevolucion
            // 
            comboLibroDevolucion.FormattingEnabled = true;
            comboLibroDevolucion.Location = new Point(64, 55);
            comboLibroDevolucion.Name = "comboLibroDevolucion";
            comboLibroDevolucion.Size = new Size(130, 25);
            comboLibroDevolucion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 27);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 5;
            label4.Text = "Alumno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 55);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 6;
            label3.Text = "Libro";
            // 
            // btnMain
            // 
            btnMain.BackColor = Color.Brown;
            btnMain.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMain.ForeColor = Color.White;
            btnMain.Location = new Point(41, 286);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(137, 29);
            btnMain.TabIndex = 14;
            btnMain.Text = "VOLVER AL MAIN";
            btnMain.TextAlign = ContentAlignment.BottomCenter;
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += btnMain_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Brown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdPrestamo, IdLibro, DniAlumno, FechaPrestamo, FechaDevolucion });
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(218, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(570, 303);
            dataGridView1.TabIndex = 15;
            // 
            // IdPrestamo
            // 
            IdPrestamo.HeaderText = "ID del préstamo";
            IdPrestamo.Name = "IdPrestamo";
            // 
            // IdLibro
            // 
            IdLibro.HeaderText = "ID del libro";
            IdLibro.Name = "IdLibro";
            // 
            // DniAlumno
            // 
            DniAlumno.HeaderText = "DNI del alumno";
            DniAlumno.Name = "DniAlumno";
            // 
            // FechaPrestamo
            // 
            FechaPrestamo.HeaderText = "Fecha del préstamo";
            FechaPrestamo.Name = "FechaPrestamo";
            // 
            // FechaDevolucion
            // 
            FechaDevolucion.HeaderText = "Fecha de devolución";
            FechaDevolucion.Name = "FechaDevolucion";
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 326);
            Controls.Add(dataGridView1);
            Controls.Add(btnMain);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Prestamos";
            Text = "Gestor de Prestamos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtAlumnoPrestamo;
        private Label label2;
        private Label label1;
        private Button btnPrestamo;
        private ComboBox comboLibroPrestamo;
        private Button btnDevolucion;
        private TextBox txtAlumnoDevolucion;
        private ComboBox comboLibroDevolucion;
        private Label label4;
        private Label label3;
        private Button btnMain;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdPrestamo;
        private DataGridViewTextBoxColumn IdLibro;
        private DataGridViewTextBoxColumn DniAlumno;
        private DataGridViewTextBoxColumn FechaPrestamo;
        private DataGridViewTextBoxColumn FechaDevolucion;
    }
}