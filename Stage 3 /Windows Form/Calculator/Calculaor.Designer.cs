
namespace Calculator
{
    partial class Calculaor
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
            this.label1 = new System.Windows.Forms.Label();
            this.first_number = new System.Windows.Forms.TextBox();
            this.Second_number = new System.Windows.Forms.TextBox();
            this.Radio_add = new System.Windows.Forms.RadioButton();
            this.Radio_sub = new System.Windows.Forms.RadioButton();
            this.Radio_Mul = new System.Windows.Forms.RadioButton();
            this.Radio_div = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // first_number
            // 
            this.first_number.Location = new System.Drawing.Point(85, 114);
            this.first_number.Name = "first_number";
            this.first_number.Size = new System.Drawing.Size(359, 27);
            this.first_number.TabIndex = 1;
            // 
            // Second_number
            // 
            this.Second_number.Location = new System.Drawing.Point(85, 153);
            this.Second_number.Name = "Second_number";
            this.Second_number.Size = new System.Drawing.Size(359, 27);
            this.Second_number.TabIndex = 2;
            // 
            // Radio_add
            // 
            this.Radio_add.AutoSize = true;
            this.Radio_add.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Radio_add.Location = new System.Drawing.Point(109, 181);
            this.Radio_add.Name = "Radio_add";
            this.Radio_add.Size = new System.Drawing.Size(55, 23);
            this.Radio_add.TabIndex = 4;
            this.Radio_add.TabStop = true;
            this.Radio_add.Text = "Add";
            this.Radio_add.UseVisualStyleBackColor = true;
            // 
            // Radio_sub
            // 
            this.Radio_sub.AutoSize = true;
            this.Radio_sub.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Radio_sub.Location = new System.Drawing.Point(170, 182);
            this.Radio_sub.Name = "Radio_sub";
            this.Radio_sub.Size = new System.Drawing.Size(81, 23);
            this.Radio_sub.TabIndex = 5;
            this.Radio_sub.TabStop = true;
            this.Radio_sub.Text = "Subtract";
            this.Radio_sub.UseVisualStyleBackColor = true;
            // 
            // Radio_Mul
            // 
            this.Radio_Mul.AutoSize = true;
            this.Radio_Mul.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Radio_Mul.Location = new System.Drawing.Point(257, 182);
            this.Radio_Mul.Name = "Radio_Mul";
            this.Radio_Mul.Size = new System.Drawing.Size(80, 23);
            this.Radio_Mul.TabIndex = 6;
            this.Radio_Mul.TabStop = true;
            this.Radio_Mul.Text = "Multiply";
            this.Radio_Mul.UseVisualStyleBackColor = true;
            // 
            // Radio_div
            // 
            this.Radio_div.AutoSize = true;
            this.Radio_div.Location = new System.Drawing.Point(343, 181);
            this.Radio_div.Name = "Radio_div";
            this.Radio_div.Size = new System.Drawing.Size(83, 24);
            this.Radio_div.TabIndex = 7;
            this.Radio_div.TabStop = true;
            this.Radio_div.Text = "Division";
            this.Radio_div.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculaor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Radio_div);
            this.Controls.Add(this.Radio_Mul);
            this.Controls.Add(this.Radio_sub);
            this.Controls.Add(this.Radio_add);
            this.Controls.Add(this.Second_number);
            this.Controls.Add(this.first_number);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Calculaor";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox first_number;
        private System.Windows.Forms.TextBox Second_number;
        private System.Windows.Forms.RadioButton Radio_add;
        private System.Windows.Forms.RadioButton Radio_sub;
        private System.Windows.Forms.RadioButton Radio_Mul;
        private System.Windows.Forms.RadioButton Radio_div;
        private System.Windows.Forms.Button button1;
    }
}

