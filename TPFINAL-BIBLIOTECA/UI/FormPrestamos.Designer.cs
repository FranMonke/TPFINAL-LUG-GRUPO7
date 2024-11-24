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
            btnRestaurar = new Button();
            btnBuscarDni = new Button();
            txtDniDevolucion = new TextBox();
            btnDevolucion = new Button();
            txtPrestamoDevolucion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnMain = new Button();
            dgvPrestamos = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
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
            groupBox1.Location = new Point(14, 15);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prestamo";
            // 
            // btnPrestamo
            // 
            btnPrestamo.BackColor = Color.Brown;
            btnPrestamo.Location = new Point(38, 111);
            btnPrestamo.Margin = new Padding(3, 4, 3, 4);
            btnPrestamo.Name = "btnPrestamo";
            btnPrestamo.Size = new Size(152, 38);
            btnPrestamo.TabIndex = 4;
            btnPrestamo.Text = "Realizar prestamo";
            btnPrestamo.UseVisualStyleBackColor = false;
            btnPrestamo.Click += btnPrestamo_Click;
            // 
            // comboLibroPrestamo
            // 
            comboLibroPrestamo.FormattingEnabled = true;
            comboLibroPrestamo.Location = new Point(94, 70);
            comboLibroPrestamo.Margin = new Padding(3, 4, 3, 4);
            comboLibroPrestamo.Name = "comboLibroPrestamo";
            comboLibroPrestamo.Size = new Size(127, 25);
            comboLibroPrestamo.TabIndex = 3;
            // 
            // txtAlumnoPrestamo
            // 
            txtAlumnoPrestamo.Location = new Point(94, 30);
            txtAlumnoPrestamo.Margin = new Padding(3, 4, 3, 4);
            txtAlumnoPrestamo.Name = "txtAlumnoPrestamo";
            txtAlumnoPrestamo.Size = new Size(127, 25);
            txtAlumnoPrestamo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 70);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 1;
            label2.Text = "Libro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 34);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 0;
            label1.Text = "DNI Alumno";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRestaurar);
            groupBox2.Controls.Add(btnBuscarDni);
            groupBox2.Controls.Add(txtDniDevolucion);
            groupBox2.Controls.Add(btnDevolucion);
            groupBox2.Controls.Add(txtPrestamoDevolucion);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(14, 182);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(229, 172);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Devolucion";
            // 
            // btnRestaurar
            // 
            btnRestaurar.ForeColor = Color.Black;
            btnRestaurar.Location = new Point(187, 90);
            btnRestaurar.Margin = new Padding(3, 4, 3, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(34, 29);
            btnRestaurar.TabIndex = 12;
            btnRestaurar.Text = "↩";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.ForeColor = Color.Black;
            btnBuscarDni.Location = new Point(145, 90);
            btnBuscarDni.Margin = new Padding(3, 4, 3, 4);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(35, 29);
            btnBuscarDni.TabIndex = 11;
            btnBuscarDni.Text = "🔎";
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // txtDniDevolucion
            // 
            txtDniDevolucion.Location = new Point(24, 91);
            txtDniDevolucion.Margin = new Padding(3, 4, 3, 4);
            txtDniDevolucion.Name = "txtDniDevolucion";
            txtDniDevolucion.Size = new Size(114, 25);
            txtDniDevolucion.TabIndex = 10;
            // 
            // btnDevolucion
            // 
            btnDevolucion.BackColor = Color.Brown;
            btnDevolucion.Location = new Point(24, 127);
            btnDevolucion.Margin = new Padding(3, 4, 3, 4);
            btnDevolucion.Name = "btnDevolucion";
            btnDevolucion.Size = new Size(170, 38);
            btnDevolucion.TabIndex = 9;
            btnDevolucion.Text = "Confirmar devolucion";
            btnDevolucion.UseVisualStyleBackColor = false;
            btnDevolucion.Click += btnDevolucion_Click;
            // 
            // txtPrestamoDevolucion
            // 
            txtPrestamoDevolucion.Location = new Point(104, 30);
            txtPrestamoDevolucion.Margin = new Padding(3, 4, 3, 4);
            txtPrestamoDevolucion.Name = "txtPrestamoDevolucion";
            txtPrestamoDevolucion.Size = new Size(117, 25);
            txtPrestamoDevolucion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 34);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 5;
            label4.Text = "ID Préstamo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 66);
            label3.Name = "label3";
            label3.Size = new Size(145, 17);
            label3.TabIndex = 6;
            label3.Text = "Buscar por DNI Alumno";
            // 
            // btnMain
            // 
            btnMain.BackColor = Color.Brown;
            btnMain.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMain.ForeColor = Color.White;
            btnMain.Location = new Point(47, 362);
            btnMain.Margin = new Padding(3, 4, 3, 4);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(157, 37);
            btnMain.TabIndex = 14;
            btnMain.Text = "VOLVER AL MAIN";
            btnMain.TextAlign = ContentAlignment.BottomCenter;
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += btnMain_Click;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.BackgroundColor = Color.Brown;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.GridColor = Color.White;
            dgvPrestamos.Location = new Point(249, 15);
            dgvPrestamos.Margin = new Padding(3, 4, 3, 4);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.Size = new Size(651, 384);
            dgvPrestamos.TabIndex = 15;
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(914, 413);
            Controls.Add(dgvPrestamos);
            Controls.Add(btnMain);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Prestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Prestamos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
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
        private TextBox txtPrestamoDevolucion;
        private Label label4;
        private Label label3;
        private Button btnMain;
        private DataGridView dgvPrestamos;
        private Button btnBuscarDni;
        private TextBox txtDniDevolucion;
        private Button btnRestaurar;
    }
}