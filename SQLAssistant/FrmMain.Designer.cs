namespace SQLAssistant
{
    partial class FrmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnService = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxtSql = new System.Windows.Forms.TextBox();
            this.LblSql = new System.Windows.Forms.Label();
            this.CboDbServers = new System.Windows.Forms.ComboBox();
            this.LblConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(627, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Connection";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(627, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Execute SQL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnService
            // 
            this.BtnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnService.Location = new System.Drawing.Point(627, 148);
            this.BtnService.Name = "BtnService";
            this.BtnService.Size = new System.Drawing.Size(152, 50);
            this.BtnService.TabIndex = 2;
            this.BtnService.Text = "Service";
            this.BtnService.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(627, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Execute File";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // TxtResult
            // 
            this.TxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtResult.Location = new System.Drawing.Point(12, 278);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(767, 160);
            this.TxtResult.TabIndex = 4;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblResult.Location = new System.Drawing.Point(12, 255);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(56, 18);
            this.LblResult.TabIndex = 5;
            this.LblResult.Text = "Result";
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtSql
            // 
            this.TxtSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtSql.Location = new System.Drawing.Point(12, 51);
            this.TxtSql.Multiline = true;
            this.TxtSql.Name = "TxtSql";
            this.TxtSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSql.Size = new System.Drawing.Size(598, 201);
            this.TxtSql.TabIndex = 6;
            // 
            // LblSql
            // 
            this.LblSql.AutoSize = true;
            this.LblSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSql.Location = new System.Drawing.Point(12, 51);
            this.LblSql.Name = "LblSql";
            this.LblSql.Size = new System.Drawing.Size(41, 18);
            this.LblSql.TabIndex = 7;
            this.LblSql.Text = "SQL";
            this.LblSql.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CboDbServers
            // 
            this.CboDbServers.FormattingEnabled = true;
            this.CboDbServers.Location = new System.Drawing.Point(121, 13);
            this.CboDbServers.Name = "CboDbServers";
            this.CboDbServers.Size = new System.Drawing.Size(489, 24);
            this.CboDbServers.TabIndex = 8;
            // 
            // LblConnection
            // 
            this.LblConnection.AutoSize = true;
            this.LblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblConnection.Location = new System.Drawing.Point(12, 13);
            this.LblConnection.Name = "LblConnection";
            this.LblConnection.Size = new System.Drawing.Size(94, 18);
            this.LblConnection.TabIndex = 9;
            this.LblConnection.Text = "Connection";
            this.LblConnection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblConnection);
            this.Controls.Add(this.CboDbServers);
            this.Controls.Add(this.LblSql);
            this.Controls.Add(this.TxtSql);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnService);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmMain";
            this.Text = "SQLAssistant";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnService;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxtSql;
        private System.Windows.Forms.Label LblSql;
        private System.Windows.Forms.ComboBox CboDbServers;
        private System.Windows.Forms.Label LblConnection;
    }
}

