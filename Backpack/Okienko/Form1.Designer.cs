namespace Okienko
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            progressBar1 = new ProgressBar();
            textBox6 = new TextBox();
            podsumowanie = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.ForeColor = SystemColors.InactiveBorder;
            button1.Location = new Point(47, 163);
            button1.Name = "button1";
            button1.Size = new Size(185, 56);
            button1.TabIndex = 0;
            button1.Text = "Stworz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(47, 26);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Ile przedmiotow chcesz stworzyc?";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LavenderBlush;
            textBox3.Location = new Point(268, 26);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(270, 382);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Location = new Point(47, 84);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(185, 23);
            textBox4.TabIndex = 4;
            textBox4.Text = "Jaki jest maksymalny udzwig?";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(47, 55);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(185, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(47, 118);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(185, 23);
            numericUpDown2.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(688, 415);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(688, 386);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(580, 84);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(176, 46);
            progressBar1.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Info;
            textBox6.Location = new Point(580, 55);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(176, 23);
            textBox6.TabIndex = 9;
            textBox6.Text = "Ilosc wzietych przedmiotow [%]";
            // 
            // podsumowanie
            // 
            podsumowanie.BackColor = Color.Thistle;
            podsumowanie.Location = new Point(544, 163);
            podsumowanie.Multiline = true;
            podsumowanie.Name = "podsumowanie";
            podsumowanie.ReadOnly = true;
            podsumowanie.Size = new Size(252, 196);
            podsumowanie.TabIndex = 10;
            podsumowanie.TextChanged += podsumowanie_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(podsumowanie);
            Controls.Add(textBox6);
            Controls.Add(progressBar1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox5;
        private TextBox textBox2;
        private ProgressBar progressBar1;
        private TextBox textBox6;
        private TextBox podsumowanie;
    }
}