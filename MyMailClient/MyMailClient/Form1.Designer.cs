namespace MyMailClient
{
    partial class Form1
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
            this.loginInput = new System.Windows.Forms.ComboBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.autorizButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginInput
            // 
            this.loginInput.FormattingEnabled = true;
            this.loginInput.Location = new System.Drawing.Point(13, 70);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(209, 21);
            this.loginInput.TabIndex = 0;
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(13, 125);
            this.passInput.Name = "passInput";
            this.passInput.PasswordChar = '*';
            this.passInput.Size = new System.Drawing.Size(209, 20);
            this.passInput.TabIndex = 1;
            this.passInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // autorizButton
            // 
            this.autorizButton.Location = new System.Drawing.Point(70, 306);
            this.autorizButton.Name = "autorizButton";
            this.autorizButton.Size = new System.Drawing.Size(100, 23);
            this.autorizButton.TabIndex = 4;
            this.autorizButton.Text = "Авторизация";
            this.autorizButton.UseVisualStyleBackColor = true;
            this.autorizButton.Click += new System.EventHandler(this.autorizButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyMailClient.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(234, 341);
            this.Controls.Add(this.autorizButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.loginInput);
            this.MaximumSize = new System.Drawing.Size(250, 380);
            this.MinimumSize = new System.Drawing.Size(250, 380);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox loginInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button autorizButton;
    }
}

