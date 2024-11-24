namespace UI
{
    partial class FormLibros
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
            txtBajaIdLibro = new TextBox();
            label6 = new Label();
            gbModificarStock = new GroupBox();
            label7 = new Label();
            txtModificarIdLibro = new TextBox();
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
            gbAltaLibro.Location = new Point(14, 15);
            gbAltaLibro.Margin = new Padding(3, 4, 3, 4);
            gbAltaLibro.Name = "gbAltaLibro";
            gbAltaLibro.Padding = new Padding(3, 4, 3, 4);
            gbAltaLibro.Size = new Size(216, 324);
            gbAltaLibro.TabIndex = 0;
            gbAltaLibro.TabStop = false;
            gbAltaLibro.Text = "Alta libro";
            // 
            // btnConfirmarCambiosLibro
            // 
            btnConfirmarCambiosLibro.BackColor = Color.Brown;
            btnConfirmarCambiosLibro.Location = new Point(114, 263);
            btnConfirmarCambiosLibro.Margin = new Padding(3, 4, 3, 4);
            btnConfirmarCambiosLibro.Name = "btnConfirmarCambiosLibro";
            btnConfirmarCambiosLibro.Size = new Size(95, 53);
            btnConfirmarCambiosLibro.TabIndex = 11;
            btnConfirmarCambiosLibro.Text = "Confirmar cambios";
            btnConfirmarCambiosLibro.TextAlign = ContentAlignment.BottomCenter;
            btnConfirmarCambiosLibro.UseVisualStyleBackColor = false;
            btnConfirmarCambiosLibro.Click += btnConfirmarCambiosLibro_Click;
            // 
            // btnAgregarAListaLibro
            // 
            btnAgregarAListaLibro.BackColor = Color.Brown;
            btnAgregarAListaLibro.Location = new Point(7, 263);
            btnAgregarAListaLibro.Margin = new Padding(3, 4, 3, 4);
            btnAgregarAListaLibro.Name = "btnAgregarAListaLibro";
            btnAgregarAListaLibro.Size = new Size(95, 53);
            btnAgregarAListaLibro.TabIndex = 10;
            btnAgregarAListaLibro.Text = "Agregar a la lista";
            btnAgregarAListaLibro.TextAlign = ContentAlignment.BottomCenter;
            btnAgregarAListaLibro.UseVisualStyleBackColor = false;
            btnAgregarAListaLibro.Click += btnAgregarAListaLibro_Click;
            // 
            // btnCargarUnLibro
            // 
            btnCargarUnLibro.BackColor = Color.Brown;
            btnCargarUnLibro.Location = new Point(61, 195);
            btnCargarUnLibro.Margin = new Padding(3, 4, 3, 4);
            btnCargarUnLibro.Name = "btnCargarUnLibro";
            btnCargarUnLibro.Size = new Size(95, 53);
            btnCargarUnLibro.TabIndex = 9;
            btnCargarUnLibro.Text = "Cargar un libro";
            btnCargarUnLibro.TextAlign = ContentAlignment.BottomCenter;
            btnCargarUnLibro.UseVisualStyleBackColor = false;
            btnCargarUnLibro.Click += btnCargarUnLibro_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(82, 156);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(126, 25);
            txtCantidad.TabIndex = 8;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(82, 117);
            txtGenero.Margin = new Padding(3, 4, 3, 4);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(126, 25);
            txtGenero.TabIndex = 7;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(82, 77);
            txtAutor.Margin = new Padding(3, 4, 3, 4);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(126, 25);
            txtAutor.TabIndex = 6;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(82, 38);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(126, 25);
            txtTitulo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 160);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 4;
            label5.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 120);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 2;
            label3.Text = "Genero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 81);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 1;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // gbBajaLibro
            // 
            gbBajaLibro.Controls.Add(btnBajaLibro);
            gbBajaLibro.Controls.Add(txtBajaIdLibro);
            gbBajaLibro.Controls.Add(label6);
            gbBajaLibro.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbBajaLibro.ForeColor = Color.White;
            gbBajaLibro.Location = new Point(14, 347);
            gbBajaLibro.Margin = new Padding(3, 4, 3, 4);
            gbBajaLibro.Name = "gbBajaLibro";
            gbBajaLibro.Padding = new Padding(3, 4, 3, 4);
            gbBajaLibro.Size = new Size(216, 120);
            gbBajaLibro.TabIndex = 1;
            gbBajaLibro.TabStop = false;
            gbBajaLibro.Text = "Baja libro";
            // 
            // btnBajaLibro
            // 
            btnBajaLibro.BackColor = Color.Brown;
            btnBajaLibro.Location = new Point(30, 70);
            btnBajaLibro.Margin = new Padding(3, 4, 3, 4);
            btnBajaLibro.Name = "btnBajaLibro";
            btnBajaLibro.Size = new Size(157, 37);
            btnBajaLibro.TabIndex = 12;
            btnBajaLibro.Text = "Dar de baja libro";
            btnBajaLibro.TextAlign = ContentAlignment.BottomCenter;
            btnBajaLibro.UseVisualStyleBackColor = false;
            btnBajaLibro.Click += btnBajaLibro_Click;
            // 
            // txtBajaIdLibro
            // 
            txtBajaIdLibro.Location = new Point(82, 30);
            txtBajaIdLibro.Margin = new Padding(3, 4, 3, 4);
            txtBajaIdLibro.Name = "txtBajaIdLibro";
            txtBajaIdLibro.Size = new Size(126, 25);
            txtBajaIdLibro.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 34);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 0;
            label6.Text = "ID Libro";
            // 
            // gbModificarStock
            // 
            gbModificarStock.Controls.Add(label7);
            gbModificarStock.Controls.Add(txtModificarIdLibro);
            gbModificarStock.Controls.Add(btnModificarStockLibro);
            gbModificarStock.Controls.Add(txtModificarCantidadLibro);
            gbModificarStock.Controls.Add(rbDisminuir);
            gbModificarStock.Controls.Add(rbAumentar);
            gbModificarStock.Controls.Add(label4);
            gbModificarStock.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbModificarStock.ForeColor = Color.White;
            gbModificarStock.Location = new Point(14, 475);
            gbModificarStock.Margin = new Padding(3, 4, 3, 4);
            gbModificarStock.Name = "gbModificarStock";
            gbModificarStock.Padding = new Padding(3, 4, 3, 4);
            gbModificarStock.Size = new Size(216, 198);
            gbModificarStock.TabIndex = 2;
            gbModificarStock.TabStop = false;
            gbModificarStock.Text = "Modificar stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 34);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 15;
            label7.Text = "ID Libro";
            // 
            // txtModificarIdLibro
            // 
            txtModificarIdLibro.Location = new Point(82, 30);
            txtModificarIdLibro.Margin = new Padding(3, 4, 3, 4);
            txtModificarIdLibro.Name = "txtModificarIdLibro";
            txtModificarIdLibro.Size = new Size(126, 25);
            txtModificarIdLibro.TabIndex = 14;
            // 
            // btnModificarStockLibro
            // 
            btnModificarStockLibro.BackColor = Color.Brown;
            btnModificarStockLibro.Location = new Point(30, 151);
            btnModificarStockLibro.Margin = new Padding(3, 4, 3, 4);
            btnModificarStockLibro.Name = "btnModificarStockLibro";
            btnModificarStockLibro.Size = new Size(157, 37);
            btnModificarStockLibro.TabIndex = 13;
            btnModificarStockLibro.Text = "Modificar stock";
            btnModificarStockLibro.TextAlign = ContentAlignment.BottomCenter;
            btnModificarStockLibro.UseVisualStyleBackColor = false;
            btnModificarStockLibro.Click += btnModificarStockLibro_Click;
            // 
            // txtModificarCantidadLibro
            // 
            txtModificarCantidadLibro.Location = new Point(82, 77);
            txtModificarCantidadLibro.Margin = new Padding(3, 4, 3, 4);
            txtModificarCantidadLibro.Name = "txtModificarCantidadLibro";
            txtModificarCantidadLibro.Size = new Size(126, 25);
            txtModificarCantidadLibro.TabIndex = 6;
            // 
            // rbDisminuir
            // 
            rbDisminuir.AutoSize = true;
            rbDisminuir.Location = new Point(114, 117);
            rbDisminuir.Margin = new Padding(3, 4, 3, 4);
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
            rbAumentar.Location = new Point(14, 117);
            rbAumentar.Margin = new Padding(3, 4, 3, 4);
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
            label4.Location = new Point(7, 81);
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
            dgvLibros.Location = new Point(237, 15);
            dgvLibros.Margin = new Padding(3, 4, 3, 4);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(664, 702);
            dgvLibros.TabIndex = 3;
            // 
            // btnMain
            // 
            btnMain.BackColor = Color.Brown;
            btnMain.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMain.ForeColor = Color.White;
            btnMain.Location = new Point(43, 680);
            btnMain.Margin = new Padding(3, 4, 3, 4);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(157, 37);
            btnMain.TabIndex = 13;
            btnMain.Text = "VOLVER AL MAIN";
            btnMain.TextAlign = ContentAlignment.BottomCenter;
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += btnMain_Click;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(914, 727);
            Controls.Add(btnMain);
            Controls.Add(dgvLibros);
            Controls.Add(gbModificarStock);
            Controls.Add(gbBajaLibro);
            Controls.Add(gbAltaLibro);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormLibros";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox txtBajaIdLibro;
        private Button btnBajaLibro;
        private Button btnModificarStockLibro;
        private TextBox txtModificarCantidadLibro;
        private RadioButton rbDisminuir;
        private RadioButton rbAumentar;
        private Button btnMain;
        private Label label7;
        private TextBox txtModificarIdLibro;
    }
}