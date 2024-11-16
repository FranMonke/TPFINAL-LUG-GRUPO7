namespace UI
{
    partial class Libros
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
            gbAltaLibro = new GroupBox();
            btnConfirmarCambiosLibro = new Button();
            btnAgregarAListaLibro = new Button();
            btnCargarUnLibro = new Button();
            txtCantidad = new TextBox();
            txtGenero = new TextBox();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbBajaLibro = new GroupBox();
            btnBajaLibro = new Button();
            txtIdLibro = new TextBox();
            label6 = new Label();
            gbModificarStock = new GroupBox();
            btnModificarStockLibro = new Button();
            txtModificarCantidadLibro = new TextBox();
            rbDisminuir = new RadioButton();
            rbAumentar = new RadioButton();
            label4 = new Label();
            dgvLibros = new DataGridView();
            btnMain = new Button();
            gbAltaLibro.SuspendLayout();
            gbBajaLibro.SuspendLayout();
            gbModificarStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // gbAltaLibro
            // 
            gbAltaLibro.Controls.Add(btnConfirmarCambiosLibro);
            gbAltaLibro.Controls.Add(btnAgregarAListaLibro);
            gbAltaLibro.Controls.Add(btnCargarUnLibro);
            gbAltaLibro.Controls.Add(txtCantidad);
            gbAltaLibro.Controls.Add(txtGenero);
            gbAltaLibro.Controls.Add(txtAutor);
            gbAltaLibro.Controls.Add(txtTitulo);
            gbAltaLibro.Controls.Add(label5);
            gbAltaLibro.Controls.Add(label3);
            gbAltaLibro.Controls.Add(label2);
            gbAltaLibro.Controls.Add(label1);
            gbAltaLibro.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbAltaLibro.ForeColor = Color.White;
            gbAltaLibro.Location = new Point(12, 12);
            gbAltaLibro.Name = "gbAltaLibro";
            gbAltaLibro.Size = new Size(189, 256);
            gbAltaLibro.TabIndex = 0;
            gbAltaLibro.TabStop = false;
            gbAltaLibro.Text = "Alta libro";
            // 
            // btnConfirmarCambiosLibro
            // 
            btnConfirmarCambiosLibro.BackColor = Color.Brown;
            btnConfirmarCambiosLibro.Location = new Point(100, 208);
            btnConfirmarCambiosLibro.Name = "btnConfirmarCambiosLibro";
            btnConfirmarCambiosLibro.Size = new Size(83, 42);
            btnConfirmarCambiosLibro.TabIndex = 11;
            btnConfirmarCambiosLibro.Text = "Confirmar cambios";
            btnConfirmarCambiosLibro.TextAlign = ContentAlignment.BottomCenter;
            btnConfirmarCambiosLibro.UseVisualStyleBackColor = false;
            // 
            // btnAgregarAListaLibro
            // 
            btnAgregarAListaLibro.BackColor = Color.Brown;
            btnAgregarAListaLibro.Location = new Point(6, 208);
            btnAgregarAListaLibro.Name = "btnAgregarAListaLibro";
            btnAgregarAListaLibro.Size = new Size(83, 42);
            btnAgregarAListaLibro.TabIndex = 10;
            btnAgregarAListaLibro.Text = "Agregar a la lista";
            btnAgregarAListaLibro.TextAlign = ContentAlignment.BottomCenter;
            btnAgregarAListaLibro.UseVisualStyleBackColor = false;
            // 
            // btnCargarUnLibro
            // 
            btnCargarUnLibro.BackColor = Color.Brown;
            btnCargarUnLibro.Location = new Point(53, 154);
            btnCargarUnLibro.Name = "btnCargarUnLibro";
            btnCargarUnLibro.Size = new Size(83, 42);
            btnCargarUnLibro.TabIndex = 9;
            btnCargarUnLibro.Text = "Cargar un libro";
            btnCargarUnLibro.TextAlign = ContentAlignment.BottomCenter;
            btnCargarUnLibro.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(72, 123);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(111, 25);
            txtCantidad.TabIndex = 8;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(72, 92);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(111, 25);
            txtGenero.TabIndex = 7;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(72, 61);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(111, 25);
            txtAutor.TabIndex = 6;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(72, 30);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(111, 25);
            txtTitulo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 126);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 4;
            label5.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 2;
            label3.Text = "Genero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 1;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // gbBajaLibro
            // 
            gbBajaLibro.Controls.Add(btnBajaLibro);
            gbBajaLibro.Controls.Add(txtIdLibro);
            gbBajaLibro.Controls.Add(label6);
            gbBajaLibro.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbBajaLibro.ForeColor = Color.White;
            gbBajaLibro.Location = new Point(12, 274);
            gbBajaLibro.Name = "gbBajaLibro";
            gbBajaLibro.Size = new Size(189, 95);
            gbBajaLibro.TabIndex = 1;
            gbBajaLibro.TabStop = false;
            gbBajaLibro.Text = "Baja libro";
            // 
            // btnBajaLibro
            // 
            btnBajaLibro.BackColor = Color.Brown;
            btnBajaLibro.Location = new Point(26, 55);
            btnBajaLibro.Name = "btnBajaLibro";
            btnBajaLibro.Size = new Size(137, 29);
            btnBajaLibro.TabIndex = 12;
            btnBajaLibro.Text = "Dar de baja libro";
            btnBajaLibro.TextAlign = ContentAlignment.BottomCenter;
            btnBajaLibro.UseVisualStyleBackColor = false;
            // 
            // txtIdLibro
            // 
            txtIdLibro.Location = new Point(62, 24);
            txtIdLibro.Name = "txtIdLibro";
            txtIdLibro.Size = new Size(121, 25);
            txtIdLibro.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 27);
            label6.Name = "label6";
            label6.Size = new Size(20, 17);
            label6.TabIndex = 0;
            label6.Text = "ID";
            // 
            // gbModificarStock
            // 
            gbModificarStock.Controls.Add(btnModificarStockLibro);
            gbModificarStock.Controls.Add(txtModificarCantidadLibro);
            gbModificarStock.Controls.Add(rbDisminuir);
            gbModificarStock.Controls.Add(rbAumentar);
            gbModificarStock.Controls.Add(label4);
            gbModificarStock.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbModificarStock.ForeColor = Color.White;
            gbModificarStock.Location = new Point(12, 375);
            gbModificarStock.Name = "gbModificarStock";
            gbModificarStock.Size = new Size(189, 125);
            gbModificarStock.TabIndex = 2;
            gbModificarStock.TabStop = false;
            gbModificarStock.Text = "Modificar stock";
            // 
            // btnModificarStockLibro
            // 
            btnModificarStockLibro.BackColor = Color.Brown;
            btnModificarStockLibro.Location = new Point(26, 90);
            btnModificarStockLibro.Name = "btnModificarStockLibro";
            btnModificarStockLibro.Size = new Size(137, 29);
            btnModificarStockLibro.TabIndex = 13;
            btnModificarStockLibro.Text = "Modificar stock";
            btnModificarStockLibro.TextAlign = ContentAlignment.BottomCenter;
            btnModificarStockLibro.UseVisualStyleBackColor = false;
            // 
            // txtModificarCantidadLibro
            // 
            txtModificarCantidadLibro.Location = new Point(72, 24);
            txtModificarCantidadLibro.Name = "txtModificarCantidadLibro";
            txtModificarCantidadLibro.Size = new Size(111, 25);
            txtModificarCantidadLibro.TabIndex = 6;
            // 
            // rbDisminuir
            // 
            rbDisminuir.AutoSize = true;
            rbDisminuir.Location = new Point(94, 63);
            rbDisminuir.Name = "rbDisminuir";
            rbDisminuir.Size = new Size(80, 21);
            rbDisminuir.TabIndex = 5;
            rbDisminuir.TabStop = true;
            rbDisminuir.Text = "Disminuir";
            rbDisminuir.UseVisualStyleBackColor = true;
            // 
            // rbAumentar
            // 
            rbAumentar.AutoSize = true;
            rbAumentar.Location = new Point(6, 63);
            rbAumentar.Name = "rbAumentar";
            rbAumentar.Size = new Size(82, 21);
            rbAumentar.TabIndex = 4;
            rbAumentar.TabStop = true;
            rbAumentar.Text = "Aumentar";
            rbAumentar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 32);
            label4.Name = "label4";
            label4.Size = new Size(60, 17);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // dgvLibros
            // 
            dgvLibros.BackgroundColor = Color.Brown;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.GridColor = Color.White;
            dgvLibros.Location = new Point(207, 12);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(581, 524);
            dgvLibros.TabIndex = 3;
            // 
            // btnMain
            // 
            btnMain.BackColor = Color.Brown;
            btnMain.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMain.ForeColor = Color.White;
            btnMain.Location = new Point(38, 507);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(137, 29);
            btnMain.TabIndex = 13;
            btnMain.Text = "VOLVER AL MAIN";
            btnMain.TextAlign = ContentAlignment.BottomCenter;
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += btnMain_Click;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 548);
            Controls.Add(btnMain);
            Controls.Add(dgvLibros);
            Controls.Add(gbModificarStock);
            Controls.Add(gbBajaLibro);
            Controls.Add(gbAltaLibro);
            Name = "Libros";
            Text = "Gestor de Libros";
            gbAltaLibro.ResumeLayout(false);
            gbAltaLibro.PerformLayout();
            gbBajaLibro.ResumeLayout(false);
            gbBajaLibro.PerformLayout();
            gbModificarStock.ResumeLayout(false);
            gbModificarStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAltaLibro;
        private GroupBox gbBajaLibro;
        private GroupBox gbModificarStock;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button btnCargarUnLibro;
        private TextBox txtCantidad;
        private TextBox txtGenero;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private Button btnConfirmarCambiosLibro;
        private Button btnAgregarAListaLibro;
        private Label label6;
        private DataGridView dgvLibros;
        private TextBox txtIdLibro;
        private Button btnBajaLibro;
        private Button btnModificarStockLibro;
        private TextBox txtModificarCantidadLibro;
        private RadioButton rbDisminuir;
        private RadioButton rbAumentar;
        private Button btnMain;
    }
}