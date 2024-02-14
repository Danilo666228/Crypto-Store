namespace Crypto_Store
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlLeftBar = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.Main = new Crypto_Store.Main();
            this.Settings = new Crypto_Store.Settings();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnRollUp = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlLeftBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.pnlHeader.Controls.Add(this.btnRollUp);
            this.pnlHeader.Controls.Add(this.btnFullScreen);
            this.pnlHeader.Controls.Add(this.btnCloseForm);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1512, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlLeftBar
            // 
            this.pnlLeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnlLeftBar.Controls.Add(this.btnSettings);
            this.pnlLeftBar.Controls.Add(this.btnMain);
            this.pnlLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBar.Location = new System.Drawing.Point(0, 100);
            this.pnlLeftBar.Name = "pnlLeftBar";
            this.pnlLeftBar.Size = new System.Drawing.Size(269, 729);
            this.pnlLeftBar.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pnlMain.Controls.Add(this.Main);
            this.pnlMain.Controls.Add(this.Settings);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(269, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1243, 729);
            this.pnlMain.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnSettings.Image = global::Crypto_Store.Properties.Resources.Настройки;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 100);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(269, 101);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMain
            // 
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnMain.Image = global::Crypto_Store.Properties.Resources.Главная;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(0, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(269, 101);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Главная";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(6);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1243, 729);
            this.Main.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.Margin = new System.Windows.Forms.Padding(6);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(1243, 729);
            this.Settings.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.BackgroundImage = global::Crypto_Store.Properties.Resources.Закрыть;
            this.btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Location = new System.Drawing.Point(1467, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(45, 38);
            this.btnCloseForm.TabIndex = 2;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.BackgroundImage = global::Crypto_Store.Properties.Resources.Развернуть;
            this.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Location = new System.Drawing.Point(1422, 0);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(45, 38);
            this.btnFullScreen.TabIndex = 2;
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnRollUp
            // 
            this.btnRollUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRollUp.BackgroundImage = global::Crypto_Store.Properties.Resources.Свернуть;
            this.btnRollUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRollUp.FlatAppearance.BorderSize = 0;
            this.btnRollUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollUp.Location = new System.Drawing.Point(1377, 0);
            this.btnRollUp.Name = "btnRollUp";
            this.btnRollUp.Size = new System.Drawing.Size(45, 38);
            this.btnRollUp.TabIndex = 2;
            this.btnRollUp.UseVisualStyleBackColor = true;
            this.btnRollUp.Click += new System.EventHandler(this.btnRollUp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 829);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeftBar);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            this.pnlLeftBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLeftBar;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSettings;
        private Main Main;
        private Settings Settings;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnRollUp;
        private System.Windows.Forms.Button btnFullScreen;
    }
}

