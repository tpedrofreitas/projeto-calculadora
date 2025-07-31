namespace Calculadora
{
    partial class Calculadora
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
            lbl1 = new Label();
            txt1 = new TextBox();
            lbl2 = new Label();
            txt2 = new TextBox();
            btnsomar = new Button();
            btnsubtrair = new Button();
            btnmultiplicar = new Button();
            btndividir = new Button();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(8, 16);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(57, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Número1";
            // 
            // txt1
            // 
            txt1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt1.Location = new Point(8, 32);
            txt1.Name = "txt1";
            txt1.Size = new Size(96, 29);
            txt1.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(136, 16);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(57, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Número2";
            // 
            // txt2
            // 
            txt2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt2.Location = new Point(136, 32);
            txt2.Name = "txt2";
            txt2.Size = new Size(160, 29);
            txt2.TabIndex = 3;
            // 
            // btnsomar
            // 
            btnsomar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsomar.Location = new Point(8, 96);
            btnsomar.Name = "btnsomar";
            btnsomar.Size = new Size(88, 32);
            btnsomar.TabIndex = 4;
            btnsomar.Text = "Somar";
            btnsomar.UseVisualStyleBackColor = true;
            // 
            // btnsubtrair
            // 
            btnsubtrair.Location = new Point(104, 96);
            btnsubtrair.Name = "btnsubtrair";
            btnsubtrair.Size = new Size(96, 32);
            btnsubtrair.TabIndex = 5;
            btnsubtrair.Text = "Subtrair";
            btnsubtrair.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.Location = new Point(208, 96);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(112, 32);
            btnmultiplicar.TabIndex = 6;
            btnmultiplicar.Text = "Multiplicar";
            btnmultiplicar.UseVisualStyleBackColor = true;
            // 
            // btndividir
            // 
            btndividir.Location = new Point(328, 96);
            btndividir.Name = "btndividir";
            btndividir.Size = new Size(136, 32);
            btndividir.TabIndex = 7;
            btndividir.Text = "Dividir";
            btndividir.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(352, 32);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(28, 32);
            lblresultado.TabIndex = 8;
            lblresultado.Text = "0";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 180);
            Controls.Add(lblresultado);
            Controls.Add(btndividir);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnsubtrair);
            Controls.Add(btnsomar);
            Controls.Add(txt2);
            Controls.Add(lbl2);
            Controls.Add(txt1);
            Controls.Add(lbl1);
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txt1;
        private Label lbl2;
        private TextBox txt2;
        private Button btnsomar;
        private Button btnsubtrair;
        private Button btnmultiplicar;
        private Button btndividir;
        private Label lblresultado;
    }
}
