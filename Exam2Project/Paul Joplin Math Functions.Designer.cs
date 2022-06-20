namespace Exam2Project
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
            this.showModulus = new System.Windows.Forms.Button();
            this.showFactorial = new System.Windows.Forms.Button();
            this.showFib = new System.Windows.Forms.Button();
            this.doModulus = new System.Windows.Forms.Button();
            this.doFactorial = new System.Windows.Forms.Button();
            this.doFib = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblFunc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showModulus
            // 
            this.showModulus.BackColor = System.Drawing.Color.White;
            this.showModulus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showModulus.Location = new System.Drawing.Point(125, 60);
            this.showModulus.Name = "showModulus";
            this.showModulus.Size = new System.Drawing.Size(83, 28);
            this.showModulus.TabIndex = 1;
            this.showModulus.Text = "Modulus";
            this.showModulus.UseVisualStyleBackColor = false;
            this.showModulus.Click += new System.EventHandler(this.showModulus_Click);
            // 
            // showFactorial
            // 
            this.showFactorial.BackColor = System.Drawing.Color.White;
            this.showFactorial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFactorial.Location = new System.Drawing.Point(237, 60);
            this.showFactorial.Name = "showFactorial";
            this.showFactorial.Size = new System.Drawing.Size(83, 28);
            this.showFactorial.TabIndex = 2;
            this.showFactorial.Text = "Factorial";
            this.showFactorial.UseVisualStyleBackColor = false;
            this.showFactorial.Click += new System.EventHandler(this.showFactorial_Click);
            // 
            // showFib
            // 
            this.showFib.BackColor = System.Drawing.Color.White;
            this.showFib.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFib.Location = new System.Drawing.Point(349, 60);
            this.showFib.Name = "showFib";
            this.showFib.Size = new System.Drawing.Size(83, 28);
            this.showFib.TabIndex = 3;
            this.showFib.Text = "Fibonacci";
            this.showFib.UseVisualStyleBackColor = false;
            this.showFib.Click += new System.EventHandler(this.showFib_Click);
            // 
            // doModulus
            // 
            this.doModulus.BackColor = System.Drawing.Color.White;
            this.doModulus.Enabled = false;
            this.doModulus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doModulus.Location = new System.Drawing.Point(125, 150);
            this.doModulus.Name = "doModulus";
            this.doModulus.Size = new System.Drawing.Size(83, 28);
            this.doModulus.TabIndex = 4;
            this.doModulus.Text = "&Modulus";
            this.doModulus.UseVisualStyleBackColor = false;
            this.doModulus.Click += new System.EventHandler(this.doModulus_Click);
            // 
            // doFactorial
            // 
            this.doFactorial.BackColor = System.Drawing.Color.White;
            this.doFactorial.Enabled = false;
            this.doFactorial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doFactorial.Location = new System.Drawing.Point(237, 150);
            this.doFactorial.Name = "doFactorial";
            this.doFactorial.Size = new System.Drawing.Size(83, 28);
            this.doFactorial.TabIndex = 5;
            this.doFactorial.Text = "&Factorial";
            this.doFactorial.UseVisualStyleBackColor = false;
            this.doFactorial.Click += new System.EventHandler(this.doFactorial_Click);
            // 
            // doFib
            // 
            this.doFib.BackColor = System.Drawing.Color.White;
            this.doFib.Enabled = false;
            this.doFib.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doFib.Location = new System.Drawing.Point(349, 150);
            this.doFib.Name = "doFib";
            this.doFib.Size = new System.Drawing.Size(83, 28);
            this.doFib.TabIndex = 6;
            this.doFib.Text = "F&ibonacci";
            this.doFib.UseVisualStyleBackColor = false;
            this.doFib.Click += new System.EventHandler(this.doFib_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(67, 540);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 27);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(409, 540);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 27);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMsg.Enabled = false;
            this.lblMsg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMsg.Location = new System.Drawing.Point(63, 399);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(444, 119);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(257, 38);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(44, 19);
            this.lblShow.TabIndex = 9;
            this.lblShow.Text = "Show";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDo
            // 
            this.lblDo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDo.Location = new System.Drawing.Point(234, 124);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(86, 23);
            this.lblDo.TabIndex = 10;
            this.lblDo.Text = "Do";
            this.lblDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNum1.Location = new System.Drawing.Point(108, 330);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 11;
            this.txtNum1.Visible = false;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNum2.Location = new System.Drawing.Point(349, 330);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 12;
            this.txtNum2.Visible = false;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // lblFunc
            // 
            this.lblFunc.BackColor = System.Drawing.Color.Transparent;
            this.lblFunc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunc.Location = new System.Drawing.Point(125, 232);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(307, 95);
            this.lblFunc.TabIndex = 13;
            this.lblFunc.Click += new System.EventHandler(this.lblFunc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(583, 588);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.doFib);
            this.Controls.Add(this.doFactorial);
            this.Controls.Add(this.doModulus);
            this.Controls.Add(this.showFib);
            this.Controls.Add(this.showFactorial);
            this.Controls.Add(this.showModulus);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPaulJoplinMathFunctions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showModulus;
        private System.Windows.Forms.Button showFactorial;
        private System.Windows.Forms.Button showFib;
        private System.Windows.Forms.Button doModulus;
        private System.Windows.Forms.Button doFactorial;
        private System.Windows.Forms.Button doFib;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblFunc;
    }
}

