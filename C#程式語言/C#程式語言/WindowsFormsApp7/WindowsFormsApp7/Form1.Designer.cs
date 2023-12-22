namespace WindowsFormsApp7
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
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.btn產生號碼 = new System.Windows.Forms.Button();
            this.btn加入選號 = new System.Windows.Forms.Button();
            this.btn刪除所選號碼 = new System.Windows.Forms.Button();
            this.btn刪除所有號碼 = new System.Windows.Forms.Button();
            this.lbox選號紀錄 = new System.Windows.Forms.ListBox();
            this.lbl筆數 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblOne.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOne.Location = new System.Drawing.Point(58, 63);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(107, 120);
            this.lblOne.TabIndex = 0;
            this.lblOne.Text = "0";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTwo.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTwo.Location = new System.Drawing.Point(201, 63);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(107, 120);
            this.lblTwo.TabIndex = 1;
            this.lblTwo.Text = "0";
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblThree.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblThree.Location = new System.Drawing.Point(345, 63);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(107, 120);
            this.lblThree.TabIndex = 2;
            this.lblThree.Text = "0";
            // 
            // btn產生號碼
            // 
            this.btn產生號碼.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn產生號碼.Location = new System.Drawing.Point(128, 230);
            this.btn產生號碼.Name = "btn產生號碼";
            this.btn產生號碼.Size = new System.Drawing.Size(249, 78);
            this.btn產生號碼.TabIndex = 3;
            this.btn產生號碼.Text = "產生號碼";
            this.btn產生號碼.UseVisualStyleBackColor = true;
            this.btn產生號碼.Click += new System.EventHandler(this.btn產生號碼_Click);
            // 
            // btn加入選號
            // 
            this.btn加入選號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入選號.ForeColor = System.Drawing.Color.Blue;
            this.btn加入選號.Location = new System.Drawing.Point(128, 345);
            this.btn加入選號.Name = "btn加入選號";
            this.btn加入選號.Size = new System.Drawing.Size(249, 71);
            this.btn加入選號.TabIndex = 4;
            this.btn加入選號.Text = "加入選號-->";
            this.btn加入選號.UseVisualStyleBackColor = true;
            this.btn加入選號.Click += new System.EventHandler(this.btn加入選號_Click);
            // 
            // btn刪除所選號碼
            // 
            this.btn刪除所選號碼.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所選號碼.ForeColor = System.Drawing.Color.Green;
            this.btn刪除所選號碼.Location = new System.Drawing.Point(730, 458);
            this.btn刪除所選號碼.Name = "btn刪除所選號碼";
            this.btn刪除所選號碼.Size = new System.Drawing.Size(305, 71);
            this.btn刪除所選號碼.TabIndex = 5;
            this.btn刪除所選號碼.Text = "刪除所選號碼";
            this.btn刪除所選號碼.UseVisualStyleBackColor = true;
            this.btn刪除所選號碼.Click += new System.EventHandler(this.btn刪除所選號碼_Click);
            // 
            // btn刪除所有號碼
            // 
            this.btn刪除所有號碼.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所有號碼.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn刪除所有號碼.Location = new System.Drawing.Point(730, 548);
            this.btn刪除所有號碼.Name = "btn刪除所有號碼";
            this.btn刪除所有號碼.Size = new System.Drawing.Size(305, 71);
            this.btn刪除所有號碼.TabIndex = 6;
            this.btn刪除所有號碼.Text = "刪除所有號碼";
            this.btn刪除所有號碼.UseVisualStyleBackColor = true;
            this.btn刪除所有號碼.Click += new System.EventHandler(this.btn刪除所有號碼_Click);
            // 
            // lbox選號紀錄
            // 
            this.lbox選號紀錄.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox選號紀錄.FormattingEnabled = true;
            this.lbox選號紀錄.ItemHeight = 50;
            this.lbox選號紀錄.Location = new System.Drawing.Point(536, 32);
            this.lbox選號紀錄.Name = "lbox選號紀錄";
            this.lbox選號紀錄.Size = new System.Drawing.Size(499, 404);
            this.lbox選號紀錄.TabIndex = 7;
            // 
            // lbl筆數
            // 
            this.lbl筆數.AutoSize = true;
            this.lbl筆數.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl筆數.Location = new System.Drawing.Point(528, 471);
            this.lbl筆數.Name = "lbl筆數";
            this.lbl筆數.Size = new System.Drawing.Size(113, 45);
            this.lbl筆數.TabIndex = 8;
            this.lbl筆數.Text = "共0筆";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1068, 651);
            this.Controls.Add(this.lbl筆數);
            this.Controls.Add(this.lbox選號紀錄);
            this.Controls.Add(this.btn刪除所有號碼);
            this.Controls.Add(this.btn刪除所選號碼);
            this.Controls.Add(this.btn加入選號);
            this.Controls.Add(this.btn產生號碼);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Name = "Form1";
            this.Text = "作業提示";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Button btn產生號碼;
        private System.Windows.Forms.Button btn加入選號;
        private System.Windows.Forms.Button btn刪除所選號碼;
        private System.Windows.Forms.Button btn刪除所有號碼;
        private System.Windows.Forms.ListBox lbox選號紀錄;
        private System.Windows.Forms.Label lbl筆數;
    }
}

