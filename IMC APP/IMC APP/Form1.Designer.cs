namespace IMC_APP
{
    partial class Form1
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
            label2 = new Label();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            btnCalcular = new Button();
            label3 = new Label();
            txtPasos = new TextBox();
            Ingrese = new Label();
            txtZancada = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(247, 105);
            label1.Name = "label1";
            label1.Size = new Size(63, 31);
            label1.TabIndex = 0;
            label1.Text = "Peso\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(556, 105);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 1;
            label2.Text = "Altura";
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            txtAltura.Location = new Point(536, 149);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 38);
            txtAltura.TabIndex = 2;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            txtPeso.Location = new Point(214, 149);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 38);
            txtPeso.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btnCalcular.Location = new Point(373, 357);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 45);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 247);
            label3.Name = "label3";
            label3.Size = new Size(210, 31);
            label3.TabIndex = 5;
            label3.Text = "cantidad de pasos";
            // 
            // txtPasos
            // 
            txtPasos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPasos.Location = new Point(214, 297);
            txtPasos.Name = "txtPasos";
            txtPasos.Size = new Size(124, 38);
            txtPasos.TabIndex = 6;
            // 
            // Ingrese
            // 
            Ingrese.AutoSize = true;
            Ingrese.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Ingrese.Location = new Point(536, 247);
            Ingrese.Name = "Ingrese";
            Ingrese.Size = new Size(109, 31);
            Ingrese.TabIndex = 7;
            Ingrese.Text = "Zancada";
            // 
            // txtZancada
            // 
            txtZancada.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            txtZancada.Location = new Point(536, 297);
            txtZancada.Name = "txtZancada";
            txtZancada.Size = new Size(125, 38);
            txtZancada.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(378, 49);
            label4.Name = "label4";
            label4.Size = new Size(98, 31);
            label4.TabIndex = 9;
            label4.Text = "Ingrese:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtZancada);
            Controls.Add(Ingrese);
            Controls.Add(txtPasos);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "a";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Button btnCalcular;
        private Label label3;
        private TextBox txtPasos;
        private Label Ingrese;
        private TextBox txtZancada;
        private Label label4;
    }
}
