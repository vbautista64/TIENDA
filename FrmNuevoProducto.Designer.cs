namespace TIENDA
{
    partial class FrmNuevoProducto
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
            label1 = new Label();
            txtnombre = new TextBox();
            label2 = new Label();
            txtprecio = new TextBox();
            label3 = new Label();
            txtStock = new TextBox();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(103, 15);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(274, 23);
            txtnombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 52);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Precio";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(103, 44);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(101, 23);
            txtprecio.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 81);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(103, 73);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(101, 23);
            txtStock.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(221, 115);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 2;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(302, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 2;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 159);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtprecio);
            Controls.Add(label2);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevoProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Producto";
            Load += FrmNuevoProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnombre;
        private Label label2;
        private TextBox txtprecio;
        private Label label3;
        private TextBox txtStock;
        private Button button3;
        private Button button1;
    }
}