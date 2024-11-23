namespace TIENDA
{
    partial class FrmMantenimientoProductos
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
            dgdatos = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            txtbuscar = new TextBox();
            button4 = new Button();
            button5 = new Button();
            idproducto = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgdatos).BeginInit();
            SuspendLayout();
            // 
            // dgdatos
            // 
            dgdatos.AllowUserToAddRows = false;
            dgdatos.AllowUserToDeleteRows = false;
            dgdatos.BackgroundColor = Color.White;
            dgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdatos.Columns.AddRange(new DataGridViewColumn[] { idproducto, nombre, precio, stock, fecha });
            dgdatos.Location = new Point(22, 58);
            dgdatos.Name = "dgdatos";
            dgdatos.ReadOnly = true;
            dgdatos.Size = new Size(549, 380);
            dgdatos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(22, 444);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 1;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(103, 444);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 1;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(184, 444);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 1;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 2;
            label1.Text = "Buscar Producto por Nombre";
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(187, 16);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(326, 23);
            txtbuscar.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(519, 16);
            button4.Name = "button4";
            button4.Size = new Size(52, 32);
            button4.TabIndex = 4;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(496, 444);
            button5.Name = "button5";
            button5.Size = new Size(75, 32);
            button5.TabIndex = 5;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // idproducto
            // 
            idproducto.DataPropertyName = "IdProducto";
            idproducto.HeaderText = "Id Prod";
            idproducto.Name = "idproducto";
            idproducto.ReadOnly = true;
            idproducto.Width = 50;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "Nombre Producto";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // precio
            // 
            precio.DataPropertyName = "Precio";
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // stock
            // 
            stock.DataPropertyName = "stock";
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.ReadOnly = true;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "FechaCreacion";
            fecha.HeaderText = "Fecha Creación";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // FrmMantenimientoProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 500);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(txtbuscar);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgdatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMantenimientoProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Productos";
            ((System.ComponentModel.ISupportInitialize)dgdatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgdatos;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox txtbuscar;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn idproducto;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn fecha;
    }
}