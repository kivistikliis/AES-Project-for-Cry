﻿namespace Aes
{
    partial class FormAes
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
            this.tbPlain = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPlain
            // 
            this.tbPlain.Location = new System.Drawing.Point(51, 63);
            this.tbPlain.Name = "tbPlain";
            this.tbPlain.Size = new System.Drawing.Size(386, 20);
            this.tbPlain.TabIndex = 0;
            this.tbPlain.Text = "12345789abcdexyz";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(51, 9);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(386, 20);
            this.tbKey.TabIndex = 1;
            this.tbKey.Text = "112233445566778899aabbccddeeff00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "plain";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTest.Location = new System.Drawing.Point(152, 97);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(103, 42);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 151);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbPlain);
            this.Name = "FormAes";
            this.Text = "Cryptography AES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlain;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button button1;
    }
}
