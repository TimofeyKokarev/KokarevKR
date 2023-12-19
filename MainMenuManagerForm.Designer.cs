namespace Kokarev_KR
{
    partial class MainMenuManagerForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelManagerFIO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowTC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(12, 7);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(109, 39);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(504, 67);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(166, 31);
            this.labelRole.TabIndex = 10;
            this.labelRole.Text = "Менеджер А";
            // 
            // labelManagerFIO
            // 
            this.labelManagerFIO.AutoSize = true;
            this.labelManagerFIO.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManagerFIO.Location = new System.Drawing.Point(12, 98);
            this.labelManagerFIO.Name = "labelManagerFIO";
            this.labelManagerFIO.Size = new System.Drawing.Size(80, 31);
            this.labelManagerFIO.TabIndex = 9;
            this.labelManagerFIO.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добро пожаловать";
            // 
            // buttonShowTC
            // 
            this.buttonShowTC.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowTC.Location = new System.Drawing.Point(268, 242);
            this.buttonShowTC.Name = "buttonShowTC";
            this.buttonShowTC.Size = new System.Drawing.Size(190, 105);
            this.buttonShowTC.TabIndex = 11;
            this.buttonShowTC.Text = "Показать ТЦ";
            this.buttonShowTC.UseVisualStyleBackColor = true;
            this.buttonShowTC.Click += new System.EventHandler(this.buttonShowTC_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(-3, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(731, 56);
            this.label4.TabIndex = 12;
            this.label4.Text = "Меню";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 413);
            this.Controls.Add(this.buttonShowTC);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelManagerFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label4);
            this.Name = "MainMenuManagerForm";
            this.Text = "MainMenuManagerForm";
            this.Load += new System.EventHandler(this.MainMenuManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelManagerFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowTC;
        private System.Windows.Forms.Label label4;
    }
}