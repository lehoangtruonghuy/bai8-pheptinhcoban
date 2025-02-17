namespace bai8_pheptinhcoban
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.Label();
            this.txtso2 = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnTINH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCỘNG = new System.Windows.Forms.RadioButton();
            this.rdbTRỪ = new System.Windows.Forms.RadioButton();
            this.rdbNHAN = new System.Windows.Forms.RadioButton();
            this.rdbCHIA = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "phép tính cơ bản ";
            // 
            // txtso1
            // 
            this.txtso1.AutoSize = true;
            this.txtso1.Location = new System.Drawing.Point(41, 67);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(63, 13);
            this.txtso1.TabIndex = 0;
            this.txtso1.Text = "số thứ nhất:";
            // 
            // txtso2
            // 
            this.txtso2.AutoSize = true;
            this.txtso2.Location = new System.Drawing.Point(41, 116);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(56, 13);
            this.txtso2.TabIndex = 0;
            this.txtso2.Text = "số thứ hai:";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(41, 166);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(46, 13);
            this.lblkq.TabIndex = 0;
            this.lblkq.Text = "kết quả:";
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.Menu;
            this.txt1.Location = new System.Drawing.Point(122, 65);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(122, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.Menu;
            this.txt2.Location = new System.Drawing.Point(119, 112);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(122, 20);
            this.txt2.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKQ.Location = new System.Drawing.Point(93, 163);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(122, 20);
            this.txtKQ.TabIndex = 1;
            
            // 
            // btnTINH
            // 
            this.btnTINH.Location = new System.Drawing.Point(93, 219);
            this.btnTINH.Name = "btnTINH";
            this.btnTINH.Size = new System.Drawing.Size(118, 20);
            this.btnTINH.TabIndex = 2;
            this.btnTINH.Text = "TÍNH";
            this.btnTINH.UseVisualStyleBackColor = true;
           
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCHIA);
            this.groupBox1.Controls.Add(this.rdbNHAN);
            this.groupBox1.Controls.Add(this.rdbTRỪ);
            this.groupBox1.Controls.Add(this.rdbCỘNG);
            this.groupBox1.Location = new System.Drawing.Point(317, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbCỘNG
            // 
            this.rdbCỘNG.AutoSize = true;
            this.rdbCỘNG.Location = new System.Drawing.Point(6, 37);
            this.rdbCỘNG.Name = "rdbCỘNG";
            this.rdbCỘNG.Size = new System.Drawing.Size(52, 17);
            this.rdbCỘNG.TabIndex = 0;
            this.rdbCỘNG.TabStop = true;
            this.rdbCỘNG.Text = "cộng ";
            this.rdbCỘNG.UseVisualStyleBackColor = true;
            // 
            // rdbTRỪ
            // 
            this.rdbTRỪ.AutoSize = true;
            this.rdbTRỪ.Location = new System.Drawing.Point(6, 60);
            this.rdbTRỪ.Name = "rdbTRỪ";
            this.rdbTRỪ.Size = new System.Drawing.Size(37, 17);
            this.rdbTRỪ.TabIndex = 0;
            this.rdbTRỪ.TabStop = true;
            this.rdbTRỪ.Text = "trừ";
            this.rdbTRỪ.UseVisualStyleBackColor = true;
            // 
            // rdbNHAN
            // 
            this.rdbNHAN.AutoSize = true;
            this.rdbNHAN.Location = new System.Drawing.Point(6, 83);
            this.rdbNHAN.Name = "rdbNHAN";
            this.rdbNHAN.Size = new System.Drawing.Size(49, 17);
            this.rdbNHAN.TabIndex = 0;
            this.rdbNHAN.TabStop = true;
            this.rdbNHAN.Text = "nhân";
            this.rdbNHAN.UseVisualStyleBackColor = true;
            // 
            // rdbCHIA
            // 
            this.rdbCHIA.AutoSize = true;
            this.rdbCHIA.Location = new System.Drawing.Point(6, 106);
            this.rdbCHIA.Name = "rdbCHIA";
            this.rdbCHIA.Size = new System.Drawing.Size(45, 17);
            this.rdbCHIA.TabIndex = 0;
            this.rdbCHIA.TabStop = true;
            this.rdbCHIA.Text = "chia";
            this.rdbCHIA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(578, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTINH);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtso1;
        private System.Windows.Forms.Label txtso2;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnTINH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCHIA;
        private System.Windows.Forms.RadioButton rdbNHAN;
        private System.Windows.Forms.RadioButton rdbTRỪ;
        private System.Windows.Forms.RadioButton rdbCỘNG;
    }
}

