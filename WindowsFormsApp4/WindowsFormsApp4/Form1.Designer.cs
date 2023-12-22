namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCBV1 = new System.Windows.Forms.Label();
            this.lblCBV2 = new System.Windows.Forms.Label();
            this.lblCBV3 = new System.Windows.Forms.Label();
            this.lblCBR1 = new System.Windows.Forms.Label();
            this.lblCBR2 = new System.Windows.Forms.Label();
            this.lblCBR3 = new System.Windows.Forms.Label();
            this.btnCBV = new System.Windows.Forms.Button();
            this.btnCBR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "傳值呼叫(Call By Value)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "傳址呼叫(Call By Reference)";
            // 
            // lblCBV1
            // 
            this.lblCBV1.AutoSize = true;
            this.lblCBV1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBV1.Location = new System.Drawing.Point(92, 90);
            this.lblCBV1.Name = "lblCBV1";
            this.lblCBV1.Size = new System.Drawing.Size(111, 45);
            this.lblCBV1.TabIndex = 2;
            this.lblCBV1.Text = "CBV1";
            // 
            // lblCBV2
            // 
            this.lblCBV2.AutoSize = true;
            this.lblCBV2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBV2.Location = new System.Drawing.Point(92, 155);
            this.lblCBV2.Name = "lblCBV2";
            this.lblCBV2.Size = new System.Drawing.Size(111, 45);
            this.lblCBV2.TabIndex = 3;
            this.lblCBV2.Text = "CBV2";
            // 
            // lblCBV3
            // 
            this.lblCBV3.AutoSize = true;
            this.lblCBV3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBV3.Location = new System.Drawing.Point(92, 226);
            this.lblCBV3.Name = "lblCBV3";
            this.lblCBV3.Size = new System.Drawing.Size(111, 45);
            this.lblCBV3.TabIndex = 4;
            this.lblCBV3.Text = "CBV3";
            // 
            // lblCBR1
            // 
            this.lblCBR1.AutoSize = true;
            this.lblCBR1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBR1.Location = new System.Drawing.Point(92, 386);
            this.lblCBR1.Name = "lblCBR1";
            this.lblCBR1.Size = new System.Drawing.Size(110, 45);
            this.lblCBR1.TabIndex = 5;
            this.lblCBR1.Text = "CBR1";
            // 
            // lblCBR2
            // 
            this.lblCBR2.AutoSize = true;
            this.lblCBR2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBR2.Location = new System.Drawing.Point(93, 459);
            this.lblCBR2.Name = "lblCBR2";
            this.lblCBR2.Size = new System.Drawing.Size(110, 45);
            this.lblCBR2.TabIndex = 6;
            this.lblCBR2.Text = "CBR2";
            // 
            // lblCBR3
            // 
            this.lblCBR3.AutoSize = true;
            this.lblCBR3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBR3.Location = new System.Drawing.Point(92, 536);
            this.lblCBR3.Name = "lblCBR3";
            this.lblCBR3.Size = new System.Drawing.Size(110, 45);
            this.lblCBR3.TabIndex = 7;
            this.lblCBR3.Text = "CBR3";
            // 
            // btnCBV
            // 
            this.btnCBV.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCBV.Location = new System.Drawing.Point(593, 139);
            this.btnCBV.Name = "btnCBV";
            this.btnCBV.Size = new System.Drawing.Size(271, 76);
            this.btnCBV.TabIndex = 8;
            this.btnCBV.Text = "CBV測試";
            this.btnCBV.UseVisualStyleBackColor = true;
            this.btnCBV.Click += new System.EventHandler(this.btnCBV_Click);
            // 
            // btnCBR
            // 
            this.btnCBR.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCBR.Location = new System.Drawing.Point(593, 443);
            this.btnCBR.Name = "btnCBR";
            this.btnCBR.Size = new System.Drawing.Size(271, 76);
            this.btnCBR.TabIndex = 9;
            this.btnCBR.Text = "CBR測試";
            this.btnCBR.UseVisualStyleBackColor = true;
            this.btnCBR.Click += new System.EventHandler(this.btnCBR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(907, 645);
            this.Controls.Add(this.btnCBR);
            this.Controls.Add(this.btnCBV);
            this.Controls.Add(this.lblCBR3);
            this.Controls.Add(this.lblCBR2);
            this.Controls.Add(this.lblCBR1);
            this.Controls.Add(this.lblCBV3);
            this.Controls.Add(this.lblCBV2);
            this.Controls.Add(this.lblCBV1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "參數傳遞的方式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCBV1;
        private System.Windows.Forms.Label lblCBV2;
        private System.Windows.Forms.Label lblCBV3;
        private System.Windows.Forms.Label lblCBR1;
        private System.Windows.Forms.Label lblCBR2;
        private System.Windows.Forms.Label lblCBR3;
        private System.Windows.Forms.Button btnCBV;
        private System.Windows.Forms.Button btnCBR;
    }
}

