namespace Aes
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
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.TextBox();
            this.tbCipher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.rbKey128 = new System.Windows.Forms.RadioButton();
            this.rbKey192 = new System.Windows.Forms.RadioButton();
            this.rbKey256 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(104, 69);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(307, 60);
            this.tbKey.TabIndex = 1;
            this.tbKey.Text = "112233445566778899aabbccddeeff00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "The key :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Plain text \r\nmax 16 char :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "encryption/decryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(256, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "AES";
            // 
            // tbPlain
            // 
            this.tbPlain.Location = new System.Drawing.Point(104, 137);
            this.tbPlain.Multiline = true;
            this.tbPlain.Name = "tbPlain";
            this.tbPlain.Size = new System.Drawing.Size(307, 32);
            this.tbPlain.TabIndex = 19;
            this.tbPlain.Text = "12345789abcdexyz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mode :";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(13, 11);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(46, 17);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ECB";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(416, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "ENCRYPT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(416, 175);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "DECRYPT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbResult
            // 
            this.lbResult.Location = new System.Drawing.Point(100, 441);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbResult.Multiline = true;
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(459, 90);
            this.lbResult.TabIndex = 28;
            // 
            // tbCipher
            // 
            this.tbCipher.Location = new System.Drawing.Point(104, 175);
            this.tbCipher.Multiline = true;
            this.tbCipher.Name = "tbCipher";
            this.tbCipher.Size = new System.Drawing.Size(307, 32);
            this.tbCipher.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cipher text :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Result :";
            // 
            // tbResult
            // 
            this.tbResult.Enabled = false;
            this.tbResult.Location = new System.Drawing.Point(104, 269);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(307, 38);
            this.tbResult.TabIndex = 32;
            // 
            // rbKey128
            // 
            this.rbKey128.AutoSize = true;
            this.rbKey128.Checked = true;
            this.rbKey128.Location = new System.Drawing.Point(3, 3);
            this.rbKey128.Name = "rbKey128";
            this.rbKey128.Size = new System.Drawing.Size(78, 17);
            this.rbKey128.TabIndex = 33;
            this.rbKey128.TabStop = true;
            this.rbKey128.Text = "Key 128 bit";
            this.rbKey128.UseVisualStyleBackColor = true;
            this.rbKey128.CheckedChanged += new System.EventHandler(this.rbKey128_CheckedChanged);
            // 
            // rbKey192
            // 
            this.rbKey192.AutoSize = true;
            this.rbKey192.Location = new System.Drawing.Point(3, 23);
            this.rbKey192.Name = "rbKey192";
            this.rbKey192.Size = new System.Drawing.Size(78, 17);
            this.rbKey192.TabIndex = 34;
            this.rbKey192.TabStop = true;
            this.rbKey192.Text = "Key 192 bit";
            this.rbKey192.UseVisualStyleBackColor = true;
            this.rbKey192.CheckedChanged += new System.EventHandler(this.rbKey192_CheckedChanged);
            // 
            // rbKey256
            // 
            this.rbKey256.AutoSize = true;
            this.rbKey256.Location = new System.Drawing.Point(3, 43);
            this.rbKey256.Name = "rbKey256";
            this.rbKey256.Size = new System.Drawing.Size(78, 17);
            this.rbKey256.TabIndex = 35;
            this.rbKey256.TabStop = true;
            this.rbKey256.Text = "Key 256 bit";
            this.rbKey256.UseVisualStyleBackColor = true;
            this.rbKey256.CheckedChanged += new System.EventHandler(this.rbKey256_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Location = new System.Drawing.Point(104, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 40);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbKey256);
            this.panel2.Controls.Add(this.rbKey128);
            this.panel2.Controls.Add(this.rbKey192);
            this.panel2.Location = new System.Drawing.Point(417, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 63);
            this.panel2.TabIndex = 37;
            // 
            // FormAes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 358);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCipher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPlain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormAes";
            this.Text = "Cryptography AES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox lbResult;
        private System.Windows.Forms.TextBox tbCipher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.RadioButton rbKey128;
        private System.Windows.Forms.RadioButton rbKey192;
        private System.Windows.Forms.RadioButton rbKey256;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
     
    }
}

