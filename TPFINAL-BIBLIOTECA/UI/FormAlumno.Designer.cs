namespace UI
{
    partial class FormAlumno
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
            gbAltaAlumno = new GroupBox();
            btnConfirmarCambiosAlumno = new Button();
            btnAgregarAListaAluumno = new Button();
            btnCargarUnAlumno = new Button();
            txtEmailAlumno = new TextBox();
            txtTelefonoAlumno = new TextBox();
            txtDireccionAlumno = new TextBox();
            txtNombreAlumno = new TextBox();
            txtDniAltaAlumno = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbBajaAlumno = new GroupBox();
            btnBajaAlumno = new Button();
            txtDniBajaAlumno = new TextBox();
            label6 = new Label();
            dgvAlumnos = new DataGridView();
            btnMain = new Button();
            gbAltaAlumno.SuspendLayout();
            gbBajaAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // gbAltaAlumno
            // 
            gbAltaAlumno.Controls.Add(btnConfirmarCambiosAlumno);
            gbAltaAlumno.Controls.Add(btnAgregarAListaAluumno);
            gbAltaAlumno.Controls.Add(btnCargarUnAlumno);
            gbAltaAlumno.Controls.Add(txtEmailAlumno);
            gbAltaAlumno.Controls.Add(txtTelefonoAlumno);
            gbAltaAlumno.Controls.Add(txtDireccionAlumno);
            gbAltaAlumno.Controls.Add(txtNombreAlumno);
            gbAltaAlumno.Controls.Add(txtDniAltaAlumno);
            gbAltaAlumno.Controls.Add(label5);
            gbAltaAlumno.Controls.Add(label4);
            gbAltaAlumno.Controls.Add(label3);
            gbAltaAlumno.Controls.Add(label2);
            gbAltaAlumno.Controls.Add(label1);
            gbAltaAlumno.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbAltaAlumno.ForeColor = Color.White;
            gbAltaAlumno.Location = new Point(12, 12);
            gbAltaAlumno.Name = "gbAltaAlumno";
            gbAltaAlumno.Size = new Size(254, 239);
            gbAltaAlumno.TabIndex = 0;
            gbAltaAlumno.TabStop = false;
            gbAltaAlumno.Tag = "";
            gbAltaAlumno.Text = "Alta Alumno";
            // 
            // btnConfirmarCambiosAlumno
            // 
            btnConfirmarCambiosAlumno.BackColor = Color.Brown;
            btnConfirmarCambiosAlumno.Location = new Point(173, 183);
            btnConfirmarCambiosAlumno.Name = "btnConfirmarCambiosAlumno";
            btnConfirmarCambiosAlumno.Size = new Size(75, 50);
            btnConfirmarCambiosAlumno.TabIndex = 12;
            btnConfirmarCambiosAlumno.Text = "Confirmar cambios";
            btnConfirmarCambiosAlumno.UseVisualStyleBackColor = false;
            btnConfirmarCambiosAlumno.Click += btnConfirmarCambiosAlumno_Click;
            // 
            // btnAgregarAListaAluumno
            // 
            btnAgregarAListaAluumno.BackColor = Color.Brown;
            btnAgregarAListaAluumno.Location = new Point(90, 183);
            btnAgregarAListaAluumno.Name = "btnAgregarAListaAluumno";
            btnAgregarAListaAluumno.Size = new Size(75, 50);
            btnAgregarAListaAluumno.TabIndex = 11;
            btnAgregarAListaAluumno.Text = "Agregar a la lista";
            btnAgregarAListaAluumno.UseVisualStyleBackColor = false;
            btnAgregarAListaAluumno.Click += btnAgregarAListaAluumno_Click;
            // 
            // btnCargarUnAlumno
            // 
            btnCargarUnAlumno.BackColor = Color.Brown;
            btnCargarUnAlumno.Location = new Point(6, 183);
            btnCargarUnAlumno.Name = "btnCargarUnAlumno";
            btnCargarUnAlumno.Size = new Size(75, 50);
            btnCargarUnAlumno.TabIndex = 10;
            btnCargarUnAlumno.Text = "Cargar un alumno";
            btnCargarUnAlumno.UseVisualStyleBackColor = false;
            btnCargarUnAlumno.Click += btnCargarUnAlumno_Click;
            // 
            // txtEmailAlumno
            // 
            txtEmailAlumno.Location = new Point(122, 142);
            txtEmailAlumno.Name = "txtEmailAlumno";
            txtEmailAlumno.Size = new Size(126, 25);
            txtEmailAlumno.TabIndex = 9;
            // 
            // txtTelefonoAlumno
            // 
            txtTelefonoAlumno.Location = new Point(122, 111);
            txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            txtTelefonoAlumno.Size = new Size(126, 25);
            txtTelefonoAlumno.TabIndex = 8;
            // 
            // txtDireccionAlumno
            // 
            txtDireccionAlumno.Location = new Point(122, 80);
            txtDireccionAlumno.Name = "txtDireccionAlumno";
            txtDireccionAlumno.Size = new Size(126, 25);
            txtDireccionAlumno.TabIndex = 7;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(122, 49);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(126, 25);
            txtNombreAlumno.TabIndex = 6;
            // 
            // txtDniAltaAlumno
            // 
            txtDniAltaAlumno.Location = new Point(122, 18);
            txtDniAltaAlumno.Name = "txtDniAltaAlumno";
            txtDniAltaAlumno.Size = new Size(126, 25);
            txtDniAltaAlumno.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 145);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 114);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(30, 17);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // gbBajaAlumno
            // 
            gbBajaAlumno.Controls.Add(btnBajaAlumno);
            gbBajaAlumno.Controls.Add(txtDniBajaAlumno);
            gbBajaAlumno.Controls.Add(label6);
            gbBajaAlumno.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbBajaAlumno.ForeColor = Color.White;
            gbBajaAlumno.Location = new Point(12, 257);
            gbBajaAlumno.Name = "gbBajaAlumno";
            gbBajaAlumno.Size = new Size(254, 96);
            gbBajaAlumno.TabIndex = 1;
            gbBajaAlumno.TabStop = false;
            gbBajaAlumno.Text = "Baja Alumno";
            // 
            // btnBajaAlumno
            // 
            btnBajaAlumno.BackColor = Color.Brown;
            btnBajaAlumno.Location = new Point(56, 59);
            btnBajaAlumno.Name = "btnBajaAlumno";
            btnBajaAlumno.Size = new Size(137, 29);
            btnBajaAlumno.TabIndex = 11;
            btnBajaAlumno.Text = "Dar de baja alumno";
            btnBajaAlumno.TextAlign = ContentAlignment.BottomCenter;
            btnBajaAlumno.UseVisualStyleBackColor = false;
            btnBajaAlumno.Click += btnBajaAlumno_Click;
            // 
            // txtDniBajaAlumno
            // 
            txtDniBajaAlumno.Location = new Point(56, 18);
            txtDniBajaAlumno.Name = "txtDniBajaAlumno";
            txtDniBajaAlumno.Size = new Size(192, 25);
            txtDniBajaAlumno.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 21);
            label6.Name = "label6";
            label6.Size = new Size(30, 17);
            label6.TabIndex = 6;
            label6.Text = "DNI";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAlumnos.BackgroundColor = Color.Brown;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.GridColor = Color.White;
            dgvAlumnos.Location = new Point(272, 12);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(781, 376);
            dgvAlumnos.TabIndex = 2;
            // 
            // btnMain
            // 
            btnMain.BackColor = Color.Brown;
            btnMain.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMain.ForeColor = Color.White;
            btnMain.Location = new Point(68, 359);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(137, 29);
            btnMain.TabIndex = 12;
            btnMain.Text = "VOLVER AL MAIN";
            btnMain.TextAlign = ContentAlignment.BottomCenter;
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += btnMain_Click;
            // 
            // FormAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1065, 400);
            Controls.Add(btnMain);
            Controls.Add(dgvAlumnos);
            Controls.Add(gbBajaAlumno);
            Controls.Add(gbAltaAlumno);
            MaximizeBox = false;
            Name = "FormAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Alumnos";
            gbAltaAlumno.ResumeLayout(false);
            gbAltaAlumno.PerformLayout();
            gbBajaAlumno.ResumeLayout(false);
            gbBajaAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAltaAlumno;
        private TextBox txtEmailAlumno;
        private TextBox txtTelefonoAlumno;
        private TextBox txtDireccionAlumno;
        private TextBox txtNombreAlumno;
        private TextBox txtDniAltaAlumno;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnConfirmarCambiosAlumno;
        private Button btnAgregarAListaAluumno;
        private Button btnCargarUnAlumno;
        private GroupBox gbBajaAlumno;
        private Button btnBajaAlumno;
        private TextBox txtDniBajaAlumno;
        private Label label6;
        private DataGridView dgvAlumnos;
        private Button btnMain;
    }
}