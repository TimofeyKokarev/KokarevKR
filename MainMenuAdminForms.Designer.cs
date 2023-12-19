namespace Kokarev_KR
{
    partial class MainMenuAdminForms
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
            this.labelAdminFIO = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelManager = new System.Windows.Forms.Label();
            this.buttonShowArendators = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать";
            // 
            // labelAdminFIO
            // 
            this.labelAdminFIO.AutoSize = true;
            this.labelAdminFIO.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminFIO.Location = new System.Drawing.Point(12, 94);
            this.labelAdminFIO.Name = "labelAdminFIO";
            this.labelAdminFIO.Size = new System.Drawing.Size(80, 31);
            this.labelAdminFIO.TabIndex = 2;
            this.labelAdminFIO.Text = "ФИО";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(12, 9);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(109, 39);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManager.Location = new System.Drawing.Point(380, 63);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(206, 31);
            this.labelManager.TabIndex = 5;
            this.labelManager.Text = "Администратор";
            // 
            // buttonShowArendators
            // 
            this.buttonShowArendators.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowArendators.Location = new System.Drawing.Point(201, 225);
            this.buttonShowArendators.Name = "buttonShowArendators";
            this.buttonShowArendators.Size = new System.Drawing.Size(190, 105);
            this.buttonShowArendators.TabIndex = 7;
            this.buttonShowArendators.Text = "Показать Арендаторов";
            this.buttonShowArendators.UseVisualStyleBackColor = true;
            this.buttonShowArendators.Click += new System.EventHandler(this.buttonShowArendators_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(599, 56);
            this.label4.TabIndex = 13;
            this.label4.Text = "Меню";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuAdminForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.buttonShowArendators);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelAdminFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "MainMenuAdminForms";
            this.Text = "MainMenuAdminForms";
            this.Load += new System.EventHandler(this.MainMenuAdminForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAdminFIO;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Button buttonShowArendators;
        private System.Windows.Forms.Label label4;
    }
}