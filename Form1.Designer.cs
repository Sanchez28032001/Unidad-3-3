namespace Unidad_3_3
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
            f_num = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            Total = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 26);
            label1.Name = "label1";
            label1.Size = new Size(276, 17);
            label1.TabIndex = 0;
            label1.Text = "Este programa suma los numeros capturados";
            // 
            // f_num
            // 
            f_num.AutoSize = true;
            f_num.Location = new Point(55, 74);
            f_num.Margin = new Padding(2, 0, 2, 0);
            f_num.Name = "f_num";
            f_num.Size = new Size(130, 17);
            f_num.TabIndex = 1;
            f_num.Text = "Introduce un numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 72);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 25);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(191, 100);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(58, 30);
            button1.TabIndex = 3;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(363, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(105, 242);
            listBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(2, 186);
            button2.Name = "button2";
            button2.Size = new Size(77, 76);
            button2.TabIndex = 5;
            button2.Text = "Sumar \r\nnumeros";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(85, 216);
            Total.Name = "Total";
            Total.Size = new Size(149, 17);
            Total.TabIndex = 6;
            Total.Text = "La suma de todos son : ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 320);
            Controls.Add(textBox2);
            Controls.Add(Total);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(f_num);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label f_num;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Label Total;
        private TextBox textBox2;
    }
}