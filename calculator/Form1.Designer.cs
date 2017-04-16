namespace calculator
{
    partial class Form1
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
            this.butt_0 = new System.Windows.Forms.Button();
            this.butt_sum = new System.Windows.Forms.Button();
            this.butt_comma = new System.Windows.Forms.Button();
            this.butt_sub = new System.Windows.Forms.Button();
            this.butt_3 = new System.Windows.Forms.Button();
            this.butt_2 = new System.Windows.Forms.Button();
            this.butt_1 = new System.Windows.Forms.Button();
            this.butt_div = new System.Windows.Forms.Button();
            this.butt_9 = new System.Windows.Forms.Button();
            this.butt_8 = new System.Windows.Forms.Button();
            this.butt_7 = new System.Windows.Forms.Button();
            this.butt_multi = new System.Windows.Forms.Button();
            this.butt_6 = new System.Windows.Forms.Button();
            this.butt_5 = new System.Windows.Forms.Button();
            this.butt_4 = new System.Windows.Forms.Button();
            this.butt_Mplus = new System.Windows.Forms.Button();
            this.butt_MS = new System.Windows.Forms.Button();
            this.butt_MR = new System.Windows.Forms.Button();
            this.butt_MC = new System.Windows.Forms.Button();
            this.butt_sign = new System.Windows.Forms.Button();
            this.butt_C = new System.Windows.Forms.Button();
            this.butt_CE = new System.Windows.Forms.Button();
            this.butt_arrow = new System.Windows.Forms.Button();
            this.butt_Mminus = new System.Windows.Forms.Button();
            this.butt_root = new System.Windows.Forms.Button();
            this.butt_1divX_Click = new System.Windows.Forms.Button();
            this.butt_percent = new System.Windows.Forms.Button();
            this.butt_Equally = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Enter = new System.Windows.Forms.TextBox();
            this.textBox_Calculating = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butt_0
            // 
            this.butt_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_0.Location = new System.Drawing.Point(12, 276);
            this.butt_0.Name = "butt_0";
            this.butt_0.Size = new System.Drawing.Size(86, 30);
            this.butt_0.TabIndex = 0;
            this.butt_0.Tag = "0";
            this.butt_0.Text = "0";
            this.butt_0.UseVisualStyleBackColor = true;
            this.butt_0.Click += new System.EventHandler(this.buttDigit_Click);
            // 
            // butt_sum
            // 
            this.butt_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_sum.Location = new System.Drawing.Point(150, 276);
            this.butt_sum.Name = "butt_sum";
            this.butt_sum.Size = new System.Drawing.Size(40, 30);
            this.butt_sum.TabIndex = 3;
            this.butt_sum.Tag = "\"+\"";
            this.butt_sum.Text = "+";
            this.butt_sum.UseVisualStyleBackColor = true;
            this.butt_sum.Click += new System.EventHandler(this.buttBinaryOperator_Click);
            // 
            // butt_comma
            // 
            this.butt_comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_comma.Location = new System.Drawing.Point(104, 276);
            this.butt_comma.Name = "butt_comma";
            this.butt_comma.Size = new System.Drawing.Size(40, 30);
            this.butt_comma.TabIndex = 2;
            this.butt_comma.Tag = "\",\"";
            this.butt_comma.Text = ",";
            this.butt_comma.UseVisualStyleBackColor = true;
            this.butt_comma.Click += new System.EventHandler(this.butt_comma_Click);
            // 
            // butt_sub
            // 
            this.butt_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_sub.Location = new System.Drawing.Point(150, 240);
            this.butt_sub.Name = "butt_sub";
            this.butt_sub.Size = new System.Drawing.Size(40, 30);
            this.butt_sub.TabIndex = 7;
            this.butt_sub.Tag = "\"-\"";
            this.butt_sub.Text = "-";
            this.butt_sub.UseVisualStyleBackColor = true;
            this.butt_sub.Click += new System.EventHandler(this.buttBinaryOperator_Click);
            // 
            // butt_3
            // 
            this.butt_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_3.Location = new System.Drawing.Point(104, 240);
            this.butt_3.Name = "butt_3";
            this.butt_3.Size = new System.Drawing.Size(40, 30);
            this.butt_3.TabIndex = 6;
            this.butt_3.Tag = "3";
            this.butt_3.Text = "3";
            this.butt_3.UseVisualStyleBackColor = true;
            this.butt_3.Click += new System.EventHandler(this.buttDigit_Click);
            // 
            // butt_2
            // 
            this.butt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_2.Location = new System.Drawing.Point(58, 240);
            this.butt_2.Name = "butt_2";
            this.butt_2.Size = new System.Drawing.Size(40, 30);
            this.butt_2.TabIndex = 5;
            this.butt_2.Tag = "2";
            this.butt_2.Text = "2";
            this.butt_2.UseVisualStyleBackColor = true;
            this.butt_2.Click += new System.EventHandler(this.buttDigit_Click);
            // 
            // butt_1
            // 
            this.butt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_1.Location = new System.Drawing.Point(12, 240);
            this.butt_1.Name = "butt_1";
            this.butt_1.Size = new System.Drawing.Size(40, 30);
            this.butt_1.TabIndex = 4;
            this.butt_1.Tag = "1";
            this.butt_1.Text = "1";
            this.butt_1.UseVisualStyleBackColor = true;
            this.butt_1.Click += new System.EventHandler(this.buttDigit_Click);
            // 
            // butt_div
            // 
            this.butt_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_div.Location = new System.Drawing.Point(150, 168);
            this.butt_div.Name = "butt_div";
            this.butt_div.Size = new System.Drawing.Size(40, 30);
            this.butt_div.TabIndex = 15;
            this.butt_div.Tag = "\"/\"";
            this.butt_div.Text = "/";
            this.butt_div.UseVisualStyleBackColor = true;
            this.butt_div.Click += new System.EventHandler(this.buttBinaryOperator_Click);
            // 
            // butt_9
            // 
            this.butt_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_9.Location = new System.Drawing.Point(104, 168);
            this.butt_9.Name = "butt_9";
            this.butt_9.Size = new System.Drawing.Size(40, 30);
            this.butt_9.TabIndex = 14;
            this.butt_9.Tag = "9";
            this.butt_9.Text = "9";
            this.butt_9.UseVisualStyleBackColor = true;
            this.butt_9.Click += new System.EventHandler(this.buttDigit_Click);
            // 
            // butt_8
            // 
            this.butt_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_8.Location = new System.Drawing.Point(58, 168);
            this.butt_8.Name = "butt_8";
            this.butt_8.Size = new System.Drawing.Size(40, 30);
            this.butt_8.TabIndex = 13;
            this.butt_8.Tag = "8";
            this.butt_8.Text = "8";
            this.butt_8.UseVisualStyleBackColor = true;
            this.butt_8.Click += new System.EventHandler(this.buttDigit_Click);
            // 
            // butt_7
            // 
            this.butt_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_7.Location = new System.Drawing.Point(12, 168);
            this.butt_7.Name = "butt_7";
            this.butt_7.Size = new System.Drawing.Size(40, 30);
            this.butt_7.TabIndex = 12;
            this.butt_7.Tag = "7";
            this.butt_7.Text = "7";
            this.butt_7.UseVisualStyleBackColor = true;
            this.butt_7.Click += new System.EventHandler(this.buttDigit_Click);
            // 
            // butt_multi
            // 
            this.butt_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_multi.Location = new System.Drawing.Point(150, 204);
            this.butt_multi.Name = "butt_multi";
            this.butt_multi.Size = new System.Drawing.Size(40, 30);
            this.butt_multi.TabIndex = 11;
            this.butt_multi.Tag = "\"x\"";
            this.butt_multi.Text = "x";
            this.butt_multi.UseVisualStyleBackColor = true;
            this.butt_multi.Click += new System.EventHandler(this.buttBinaryOperator_Click);
            // 
            // butt_6
            // 
            this.butt_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_6.Location = new System.Drawing.Point(104, 204);
            this.butt_6.Name = "butt_6";
            this.butt_6.Size = new System.Drawing.Size(40, 30);
            this.butt_6.TabIndex = 10;
            this.butt_6.Tag = "6";
            this.butt_6.Text = "6";
            this.butt_6.UseVisualStyleBackColor = true;
            this.butt_6.Click += new System.EventHandler(this.buttDigit_Click);
            // 
            // butt_5
            // 
            this.butt_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_5.Location = new System.Drawing.Point(58, 204);
            this.butt_5.Name = "butt_5";
            this.butt_5.Size = new System.Drawing.Size(40, 30);
            this.butt_5.TabIndex = 9;
            this.butt_5.Tag = "5";
            this.butt_5.Text = "5";
            this.butt_5.UseVisualStyleBackColor = true;
            this.butt_5.Click += new System.EventHandler(this.buttDigit_Click);
            // 
            // butt_4
            // 
            this.butt_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_4.Location = new System.Drawing.Point(12, 204);
            this.butt_4.Name = "butt_4";
            this.butt_4.Size = new System.Drawing.Size(40, 30);
            this.butt_4.TabIndex = 8;
            this.butt_4.Tag = "4";
            this.butt_4.Text = "4";
            this.butt_4.UseVisualStyleBackColor = true;
            this.butt_4.Click += new System.EventHandler(this.buttDigit_Click);
            // 
            // butt_Mplus
            // 
            this.butt_Mplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_Mplus.Location = new System.Drawing.Point(150, 94);
            this.butt_Mplus.Name = "butt_Mplus";
            this.butt_Mplus.Size = new System.Drawing.Size(40, 30);
            this.butt_Mplus.TabIndex = 23;
            this.butt_Mplus.Text = "M+";
            this.butt_Mplus.UseVisualStyleBackColor = true;
            // 
            // butt_MS
            // 
            this.butt_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_MS.Location = new System.Drawing.Point(104, 94);
            this.butt_MS.Name = "butt_MS";
            this.butt_MS.Size = new System.Drawing.Size(40, 30);
            this.butt_MS.TabIndex = 22;
            this.butt_MS.Text = "MS";
            this.butt_MS.UseVisualStyleBackColor = true;
            // 
            // butt_MR
            // 
            this.butt_MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_MR.Location = new System.Drawing.Point(58, 94);
            this.butt_MR.Name = "butt_MR";
            this.butt_MR.Size = new System.Drawing.Size(40, 30);
            this.butt_MR.TabIndex = 21;
            this.butt_MR.Text = "MR";
            this.butt_MR.UseVisualStyleBackColor = true;
            // 
            // butt_MC
            // 
            this.butt_MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_MC.Location = new System.Drawing.Point(12, 94);
            this.butt_MC.Name = "butt_MC";
            this.butt_MC.Size = new System.Drawing.Size(40, 30);
            this.butt_MC.TabIndex = 20;
            this.butt_MC.Text = "MC";
            this.butt_MC.UseVisualStyleBackColor = true;
            // 
            // butt_sign
            // 
            this.butt_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_sign.Location = new System.Drawing.Point(150, 130);
            this.butt_sign.Name = "butt_sign";
            this.butt_sign.Size = new System.Drawing.Size(40, 30);
            this.butt_sign.TabIndex = 19;
            this.butt_sign.Text = "±";
            this.butt_sign.UseVisualStyleBackColor = true;
            this.butt_sign.Click += new System.EventHandler(this.butt_sign_Click);
            // 
            // butt_C
            // 
            this.butt_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_C.Location = new System.Drawing.Point(104, 130);
            this.butt_C.Name = "butt_C";
            this.butt_C.Size = new System.Drawing.Size(40, 30);
            this.butt_C.TabIndex = 18;
            this.butt_C.Text = "C";
            this.butt_C.UseVisualStyleBackColor = true;
            this.butt_C.Click += new System.EventHandler(this.butt_C_Click);
            // 
            // butt_CE
            // 
            this.butt_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_CE.Location = new System.Drawing.Point(58, 130);
            this.butt_CE.Name = "butt_CE";
            this.butt_CE.Size = new System.Drawing.Size(40, 30);
            this.butt_CE.TabIndex = 17;
            this.butt_CE.Text = "CE";
            this.butt_CE.UseVisualStyleBackColor = true;
            this.butt_CE.Click += new System.EventHandler(this.butt_CE_Click);
            // 
            // butt_arrow
            // 
            this.butt_arrow.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_arrow.Location = new System.Drawing.Point(12, 130);
            this.butt_arrow.Name = "butt_arrow";
            this.butt_arrow.Size = new System.Drawing.Size(40, 30);
            this.butt_arrow.TabIndex = 16;
            this.butt_arrow.Text = "←";
            this.butt_arrow.UseCompatibleTextRendering = true;
            this.butt_arrow.UseVisualStyleBackColor = true;
            // 
            // butt_Mminus
            // 
            this.butt_Mminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_Mminus.Location = new System.Drawing.Point(196, 94);
            this.butt_Mminus.Name = "butt_Mminus";
            this.butt_Mminus.Size = new System.Drawing.Size(40, 30);
            this.butt_Mminus.TabIndex = 29;
            this.butt_Mminus.Text = "M-";
            this.butt_Mminus.UseVisualStyleBackColor = true;
            // 
            // butt_root
            // 
            this.butt_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_root.Location = new System.Drawing.Point(196, 130);
            this.butt_root.Name = "butt_root";
            this.butt_root.Size = new System.Drawing.Size(40, 30);
            this.butt_root.TabIndex = 28;
            this.butt_root.Text = "√";
            this.butt_root.UseVisualStyleBackColor = true;
            this.butt_root.Click += new System.EventHandler(this.butt_root_Click);
            // 
            // butt_1divX_Click
            // 
            this.butt_1divX_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_1divX_Click.Location = new System.Drawing.Point(196, 204);
            this.butt_1divX_Click.Name = "butt_1divX_Click";
            this.butt_1divX_Click.Size = new System.Drawing.Size(40, 30);
            this.butt_1divX_Click.TabIndex = 27;
            this.butt_1divX_Click.Text = "1/x";
            this.butt_1divX_Click.UseVisualStyleBackColor = true;
            this.butt_1divX_Click.Click += new System.EventHandler(this.butt_1divX_Click_Click);
            // 
            // butt_percent
            // 
            this.butt_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_percent.Location = new System.Drawing.Point(198, 166);
            this.butt_percent.Name = "butt_percent";
            this.butt_percent.Size = new System.Drawing.Size(40, 30);
            this.butt_percent.TabIndex = 26;
            this.butt_percent.Text = "%";
            this.butt_percent.UseVisualStyleBackColor = true;
            this.butt_percent.Click += new System.EventHandler(this.butt_percent_Click);
            // 
            // butt_Equally
            // 
            this.butt_Equally.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt_Equally.Location = new System.Drawing.Point(196, 240);
            this.butt_Equally.Name = "butt_Equally";
            this.butt_Equally.Size = new System.Drawing.Size(40, 66);
            this.butt_Equally.TabIndex = 24;
            this.butt_Equally.Tag = "null";
            this.butt_Equally.Text = "=";
            this.butt_Equally.UseVisualStyleBackColor = true;
            this.butt_Equally.Click += new System.EventHandler(this.butt_Equally_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_Enter);
            this.panel1.Controls.Add(this.textBox_Calculating);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 57);
            this.panel1.TabIndex = 31;
            // 
            // textBox_Enter
            // 
            this.textBox_Enter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Enter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Enter.CausesValidation = false;
            this.textBox_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Enter.Location = new System.Drawing.Point(0, 29);
            this.textBox_Enter.Name = "textBox_Enter";
            this.textBox_Enter.ReadOnly = true;
            this.textBox_Enter.Size = new System.Drawing.Size(219, 24);
            this.textBox_Enter.TabIndex = 33;
            this.textBox_Enter.Tag = "true";
            this.textBox_Enter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Calculating
            // 
            this.textBox_Calculating.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Calculating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Calculating.Location = new System.Drawing.Point(0, 3);
            this.textBox_Calculating.Name = "textBox_Calculating";
            this.textBox_Calculating.ReadOnly = true;
            this.textBox_Calculating.Size = new System.Drawing.Size(219, 13);
            this.textBox_Calculating.TabIndex = 32;
            this.textBox_Calculating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butt_Mminus);
            this.Controls.Add(this.butt_root);
            this.Controls.Add(this.butt_1divX_Click);
            this.Controls.Add(this.butt_percent);
            this.Controls.Add(this.butt_Equally);
            this.Controls.Add(this.butt_Mplus);
            this.Controls.Add(this.butt_MS);
            this.Controls.Add(this.butt_MR);
            this.Controls.Add(this.butt_MC);
            this.Controls.Add(this.butt_sign);
            this.Controls.Add(this.butt_C);
            this.Controls.Add(this.butt_CE);
            this.Controls.Add(this.butt_arrow);
            this.Controls.Add(this.butt_div);
            this.Controls.Add(this.butt_9);
            this.Controls.Add(this.butt_8);
            this.Controls.Add(this.butt_7);
            this.Controls.Add(this.butt_multi);
            this.Controls.Add(this.butt_6);
            this.Controls.Add(this.butt_5);
            this.Controls.Add(this.butt_4);
            this.Controls.Add(this.butt_sub);
            this.Controls.Add(this.butt_3);
            this.Controls.Add(this.butt_2);
            this.Controls.Add(this.butt_1);
            this.Controls.Add(this.butt_sum);
            this.Controls.Add(this.butt_comma);
            this.Controls.Add(this.butt_0);
            this.Name = "Form1";
            this.Text = "Colculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butt_0;
        private System.Windows.Forms.Button butt_sum;
        private System.Windows.Forms.Button butt_comma;
        private System.Windows.Forms.Button butt_sub;
        private System.Windows.Forms.Button butt_3;
        private System.Windows.Forms.Button butt_2;
        private System.Windows.Forms.Button butt_1;
        private System.Windows.Forms.Button butt_div;
        private System.Windows.Forms.Button butt_9;
        private System.Windows.Forms.Button butt_8;
        private System.Windows.Forms.Button butt_7;
        private System.Windows.Forms.Button butt_multi;
        private System.Windows.Forms.Button butt_6;
        private System.Windows.Forms.Button butt_5;
        private System.Windows.Forms.Button butt_4;
        private System.Windows.Forms.Button butt_Mplus;
        private System.Windows.Forms.Button butt_MS;
        private System.Windows.Forms.Button butt_MR;
        private System.Windows.Forms.Button butt_MC;
        private System.Windows.Forms.Button butt_sign;
        private System.Windows.Forms.Button butt_C;
        private System.Windows.Forms.Button butt_CE;
        private System.Windows.Forms.Button butt_arrow;
        private System.Windows.Forms.Button butt_Mminus;
        private System.Windows.Forms.Button butt_root;
        private System.Windows.Forms.Button butt_1divX_Click;
        private System.Windows.Forms.Button butt_percent;
        private System.Windows.Forms.Button butt_Equally;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Enter;
        private System.Windows.Forms.TextBox textBox_Calculating;
    }
}

