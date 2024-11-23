namespace TIENDA
{
    partial class FrmActualizarProducto
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
            button1 = new Button();
            button3 = new Button();
            txtStock = new TextBox();
            label3 = new Label();
            txtprecio = new TextBox();
            label2 = new Label();
            txtnombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtIdProdcuto = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(310, 151);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 9;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(229, 151);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 10;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(111, 109);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(101, 23);
            txtStock.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 117);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Stock";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(111, 80);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(101, 23);
            txtprecio.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 88);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(111, 51);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(274, 23);
            txtnombre.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 30);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 5;
            label4.Text = "IdProducto";
            // 
            // txtIdProdcuto
            // 
            txtIdProdcuto.Location = new Point(111, 22);
            txtIdProdcuto.Name = "txtIdProdcuto";
            txtIdProdcuto.ReadOnly = true;
            txtIdProdcuto.Size = new Size(44, 23);
            txtIdProdcuto.TabIndex = 8;
            // 
            // FrmActualizarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 200);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtprecio);
            Controls.Add(label2);
            Controls.Add(txtIdProdcuto);
            Controls.Add(label4);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmActualizarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private TextBox txtStock;
        private Label label3;
        private TextBox txtprecio;
        private Label label2;
        private TextBox txtnombre;
        private Label label1;
        private Label label4;
        private TextBox txtIdProdcuto;
    }
}