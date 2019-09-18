namespace Assignment_7
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
            this.txtStartKm = new System.Windows.Forms.TextBox();
            this.txtEndKm = new System.Windows.Forms.TextBox();
            this.txtPriceKm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExcludingVat = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblIncludingVat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStartKm
            // 
            this.txtStartKm.Location = new System.Drawing.Point(142, 57);
            this.txtStartKm.Name = "txtStartKm";
            this.txtStartKm.Size = new System.Drawing.Size(100, 20);
            this.txtStartKm.TabIndex = 0;
            // 
            // txtEndKm
            // 
            this.txtEndKm.Location = new System.Drawing.Point(142, 92);
            this.txtEndKm.Name = "txtEndKm";
            this.txtEndKm.Size = new System.Drawing.Size(100, 20);
            this.txtEndKm.TabIndex = 1;
            // 
            // txtPriceKm
            // 
            this.txtPriceKm.Location = new System.Drawing.Point(142, 127);
            this.txtPriceKm.Name = "txtPriceKm";
            this.txtPriceKm.Size = new System.Drawing.Size(100, 20);
            this.txtPriceKm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = " Price / km";
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(303, 55);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 6;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(303, 127);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price excl VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price incl VAT";
            // 
            // lblExcludingVat
            // 
            this.lblExcludingVat.AutoSize = true;
            this.lblExcludingVat.Location = new System.Drawing.Point(30, 225);
            this.lblExcludingVat.Name = "lblExcludingVat";
            this.lblExcludingVat.Size = new System.Drawing.Size(22, 13);
            this.lblExcludingVat.TabIndex = 11;
            this.lblExcludingVat.Text = "-----";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(142, 225);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(22, 13);
            this.lblVAT.TabIndex = 12;
            this.lblVAT.Text = "-----";
            // 
            // lblIncludingVat
            // 
            this.lblIncludingVat.AutoSize = true;
            this.lblIncludingVat.Location = new System.Drawing.Point(244, 224);
            this.lblIncludingVat.Name = "lblIncludingVat";
            this.lblIncludingVat.Size = new System.Drawing.Size(22, 13);
            this.lblIncludingVat.TabIndex = 13;
            this.lblIncludingVat.Text = "-----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 293);
            this.Controls.Add(this.lblIncludingVat);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblExcludingVat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPriceKm);
            this.Controls.Add(this.txtEndKm);
            this.Controls.Add(this.txtStartKm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartKm;
        private System.Windows.Forms.TextBox txtEndKm;
        private System.Windows.Forms.TextBox txtPriceKm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExcludingVat;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblIncludingVat;
    }
}

