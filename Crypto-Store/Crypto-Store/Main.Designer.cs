namespace Crypto_Store
{
    partial class Main
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.blbH1 = new System.Windows.Forms.Label();
            this.lblNameCrypto = new System.Windows.Forms.Label();
            this.lblPriceCoin = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blbH1
            // 
            this.blbH1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blbH1.AutoSize = true;
            this.blbH1.ForeColor = System.Drawing.Color.SlateBlue;
            this.blbH1.Location = new System.Drawing.Point(529, 62);
            this.blbH1.Name = "blbH1";
            this.blbH1.Size = new System.Drawing.Size(168, 27);
            this.blbH1.TabIndex = 0;
            this.blbH1.Text = "Криптовалюта";
            // 
            // lblNameCrypto
            // 
            this.lblNameCrypto.AutoSize = true;
            this.lblNameCrypto.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblNameCrypto.Location = new System.Drawing.Point(35, 141);
            this.lblNameCrypto.Name = "lblNameCrypto";
            this.lblNameCrypto.Size = new System.Drawing.Size(51, 27);
            this.lblNameCrypto.TabIndex = 1;
            this.lblNameCrypto.Text = "Вид";
            // 
            // lblPriceCoin
            // 
            this.lblPriceCoin.AutoSize = true;
            this.lblPriceCoin.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblPriceCoin.Location = new System.Drawing.Point(35, 190);
            this.lblPriceCoin.Name = "lblPriceCoin";
            this.lblPriceCoin.Size = new System.Drawing.Size(77, 27);
            this.lblPriceCoin.TabIndex = 1;
            this.lblPriceCoin.Text = "Цена:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblPrice.Location = new System.Drawing.Point(118, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 27);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Цена";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPriceCoin);
            this.Controls.Add(this.lblNameCrypto);
            this.Controls.Add(this.blbH1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1275, 729);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blbH1;
        private System.Windows.Forms.Label lblNameCrypto;
        private System.Windows.Forms.Label lblPriceCoin;
        private System.Windows.Forms.Label lblPrice;
    }
}
