﻿namespace BasicCalculatorWinForms
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
            ButtonAdd = new Button();
            ButtonSub = new Button();
            ButtonMul = new Button();
            ButtonDiv = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            buttonClear = new Button();
            buttonDot = new Button();
            button0 = new Button();
            buttonEquals = new Button();
            DisplayTextBox = new TextBox();
            SuspendLayout();
            // 
            // ButtonAdd
            // 
            ButtonAdd.Anchor = AnchorStyles.Top;
            ButtonAdd.Location = new Point(421, 131);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(30, 29);
            ButtonAdd.TabIndex = 4;
            ButtonAdd.Text = "+";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonSub
            // 
            ButtonSub.Anchor = AnchorStyles.Top;
            ButtonSub.Location = new Point(466, 131);
            ButtonSub.Name = "ButtonSub";
            ButtonSub.Size = new Size(30, 29);
            ButtonSub.TabIndex = 5;
            ButtonSub.Text = "-";
            ButtonSub.UseVisualStyleBackColor = true;
            ButtonSub.Click += ButtonSub_Click;
            // 
            // ButtonMul
            // 
            ButtonMul.Anchor = AnchorStyles.Top;
            ButtonMul.Location = new Point(421, 178);
            ButtonMul.Name = "ButtonMul";
            ButtonMul.Size = new Size(30, 29);
            ButtonMul.TabIndex = 6;
            ButtonMul.Text = "*";
            ButtonMul.UseVisualStyleBackColor = true;
            ButtonMul.Click += ButtonMul_Click;
            // 
            // ButtonDiv
            // 
            ButtonDiv.Anchor = AnchorStyles.Top;
            ButtonDiv.Location = new Point(466, 178);
            ButtonDiv.Name = "ButtonDiv";
            ButtonDiv.Size = new Size(30, 29);
            ButtonDiv.TabIndex = 7;
            ButtonDiv.Text = "/";
            ButtonDiv.UseVisualStyleBackColor = true;
            ButtonDiv.Click += ButtonDiv_Click;
            // 
            // button1
            // 
            button1.Location = new Point(206, 64);
            button1.Name = "button1";
            button1.Size = new Size(30, 29);
            button1.TabIndex = 10;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberButtons_Click;
            // 
            // button2
            // 
            button2.Location = new Point(261, 64);
            button2.Name = "button2";
            button2.Size = new Size(30, 29);
            button2.TabIndex = 11;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButtons_Click;
            // 
            // button3
            // 
            button3.Location = new Point(319, 64);
            button3.Name = "button3";
            button3.Size = new Size(30, 29);
            button3.TabIndex = 12;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButtons_Click;
            // 
            // button4
            // 
            button4.Location = new Point(206, 116);
            button4.Name = "button4";
            button4.Size = new Size(30, 29);
            button4.TabIndex = 13;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButtons_Click;
            // 
            // button5
            // 
            button5.Location = new Point(261, 116);
            button5.Name = "button5";
            button5.Size = new Size(30, 29);
            button5.TabIndex = 14;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButtons_Click;
            // 
            // button6
            // 
            button6.Location = new Point(319, 116);
            button6.Name = "button6";
            button6.Size = new Size(30, 29);
            button6.TabIndex = 15;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButtons_Click;
            // 
            // button9
            // 
            button9.Location = new Point(319, 169);
            button9.Name = "button9";
            button9.Size = new Size(30, 29);
            button9.TabIndex = 18;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberButtons_Click;
            // 
            // button8
            // 
            button8.Location = new Point(261, 169);
            button8.Name = "button8";
            button8.Size = new Size(30, 29);
            button8.TabIndex = 17;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButtons_Click;
            // 
            // button7
            // 
            button7.Location = new Point(206, 169);
            button7.Name = "button7";
            button7.Size = new Size(30, 29);
            button7.TabIndex = 16;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButtons_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(319, 221);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(30, 29);
            buttonClear.TabIndex = 21;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDot
            // 
            buttonDot.Location = new Point(261, 221);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(30, 29);
            buttonDot.TabIndex = 20;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += NumberButtons_Click;
            // 
            // button0
            // 
            button0.Location = new Point(206, 221);
            button0.Name = "button0";
            button0.Size = new Size(30, 29);
            button0.TabIndex = 19;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += NumberButtons_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(319, 269);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(30, 29);
            buttonEquals.TabIndex = 22;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // DisplayTextBox
            // 
            DisplayTextBox.Location = new Point(206, 354);
            DisplayTextBox.Name = "DisplayTextBox";
            DisplayTextBox.Size = new Size(214, 27);
            DisplayTextBox.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 591);
            Controls.Add(DisplayTextBox);
            Controls.Add(buttonEquals);
            Controls.Add(buttonClear);
            Controls.Add(buttonDot);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ButtonDiv);
            Controls.Add(ButtonMul);
            Controls.Add(ButtonSub);
            Controls.Add(ButtonAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonAdd;
        private Button ButtonSub;
        private Button ButtonMul;
        private Button ButtonDiv;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button buttonClear;
        private Button buttonDot;
        private Button button0;
        private Button buttonEquals;
        private TextBox DisplayTextBox;
    }
}
