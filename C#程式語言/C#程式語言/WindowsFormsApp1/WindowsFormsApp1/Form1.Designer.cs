namespace WindowsFormsApp1
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
            this.lbl標題 = new System.Windows.Forms.Label();
            this.lbl回應訊息 = new System.Windows.Forms.Label();
            this.btn紅茶 = new System.Windows.Forms.Button();
            this.btn綠茶 = new System.Windows.Forms.Button();
            this.btn奶茶 = new System.Windows.Forms.Button();
            this.btnCoke = new System.Windows.Forms.Button();
            this.btn掃描載具 = new System.Windows.Forms.Button();
            this.btnQRCODE付款 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl標題
            // 
            this.lbl標題.AutoSize = true;
            this.lbl標題.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl標題.Location = new System.Drawing.Point(329, 20);
            this.lbl標題.Name = "lbl標題";
            this.lbl標題.Size = new System.Drawing.Size(302, 50);
            this.lbl標題.TabIndex = 0;
            this.lbl標題.Text = "冷飲自動販賣機";
            // 
            // lbl回應訊息
            // 
            this.lbl回應訊息.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl回應訊息.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl回應訊息.Location = new System.Drawing.Point(67, 85);
            this.lbl回應訊息.Name = "lbl回應訊息";
            this.lbl回應訊息.Size = new System.Drawing.Size(840, 305);
            this.lbl回應訊息.TabIndex = 1;
            this.lbl回應訊息.Text = "回應訊息";
            // 
            // btn紅茶
            // 
            this.btn紅茶.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn紅茶.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn紅茶.Location = new System.Drawing.Point(75, 421);
            this.btn紅茶.Name = "btn紅茶";
            this.btn紅茶.Size = new System.Drawing.Size(189, 93);
            this.btn紅茶.TabIndex = 2;
            this.btn紅茶.Text = "紅茶";
            this.btn紅茶.UseVisualStyleBackColor = false;
            this.btn紅茶.Click += new System.EventHandler(this.btn紅茶_Click);
            // 
            // btn綠茶
            // 
            this.btn綠茶.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn綠茶.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn綠茶.Location = new System.Drawing.Point(291, 421);
            this.btn綠茶.Name = "btn綠茶";
            this.btn綠茶.Size = new System.Drawing.Size(189, 93);
            this.btn綠茶.TabIndex = 3;
            this.btn綠茶.Text = "綠茶";
            this.btn綠茶.UseVisualStyleBackColor = false;
            this.btn綠茶.Click += new System.EventHandler(this.btn綠茶_Click);
            // 
            // btn奶茶
            // 
            this.btn奶茶.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn奶茶.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn奶茶.Location = new System.Drawing.Point(514, 421);
            this.btn奶茶.Name = "btn奶茶";
            this.btn奶茶.Size = new System.Drawing.Size(189, 93);
            this.btn奶茶.TabIndex = 4;
            this.btn奶茶.Text = "奶茶";
            this.btn奶茶.UseVisualStyleBackColor = false;
            this.btn奶茶.Click += new System.EventHandler(this.btn奶茶_Click);
            // 
            // btnCoke
            // 
            this.btnCoke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCoke.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCoke.Location = new System.Drawing.Point(718, 421);
            this.btnCoke.Name = "btnCoke";
            this.btnCoke.Size = new System.Drawing.Size(189, 93);
            this.btnCoke.TabIndex = 5;
            this.btnCoke.Text = "Coke";
            this.btnCoke.UseVisualStyleBackColor = false;
            this.btnCoke.Click += new System.EventHandler(this.btnCoke_Click);
            // 
            // btn掃描載具
            // 
            this.btn掃描載具.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn掃描載具.Location = new System.Drawing.Point(406, 566);
            this.btn掃描載具.Name = "btn掃描載具";
            this.btn掃描載具.Size = new System.Drawing.Size(225, 90);
            this.btn掃描載具.TabIndex = 6;
            this.btn掃描載具.Text = "掃描載具";
            this.btn掃描載具.UseVisualStyleBackColor = true;
            this.btn掃描載具.Click += new System.EventHandler(this.btn掃描載具_Click);
            // 
            // btnQRCODE付款
            // 
            this.btnQRCODE付款.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQRCODE付款.Location = new System.Drawing.Point(648, 566);
            this.btnQRCODE付款.Name = "btnQRCODE付款";
            this.btnQRCODE付款.Size = new System.Drawing.Size(259, 90);
            this.btnQRCODE付款.TabIndex = 7;
            this.btnQRCODE付款.Text = "QRCode付款";
            this.btnQRCODE付款.UseVisualStyleBackColor = true;
            this.btnQRCODE付款.Click += new System.EventHandler(this.btnQRCODE付款_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(978, 698);
            this.Controls.Add(this.btnQRCODE付款);
            this.Controls.Add(this.btn掃描載具);
            this.Controls.Add(this.btnCoke);
            this.Controls.Add(this.btn奶茶);
            this.Controls.Add(this.btn綠茶);
            this.Controls.Add(this.btn紅茶);
            this.Controls.Add(this.lbl回應訊息);
            this.Controls.Add(this.lbl標題);
            this.Name = "Form1";
            this.Text = "冷飲自動販賣機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl標題;
        private System.Windows.Forms.Label lbl回應訊息;
        private System.Windows.Forms.Button btn紅茶;
        private System.Windows.Forms.Button btn綠茶;
        private System.Windows.Forms.Button btn奶茶;
        private System.Windows.Forms.Button btnCoke;
        private System.Windows.Forms.Button btn掃描載具;
        private System.Windows.Forms.Button btnQRCODE付款;
    }
}

