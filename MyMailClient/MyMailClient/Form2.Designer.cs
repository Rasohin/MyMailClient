namespace MyMailClient
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.returnButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.newMailButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.attachButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RecipTextBox = new System.Windows.Forms.ComboBox();
            this.attachDataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sendMailPanel = new System.Windows.Forms.Panel();
            this.downloadAttachButton = new System.Windows.Forms.Button();
            this.numAttachLabel = new System.Windows.Forms.Label();
            this.mailAttachmentsPanel = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachDataGridView)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            this.sendMailPanel.SuspendLayout();
            this.mailAttachmentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входящие:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(5, 30);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(790, 350);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(790, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(790, 350);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(150, 415);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(140, 23);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Вернуться во входящие";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(5, 30);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(790, 350);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Visible = false;
            // 
            // newMailButton
            // 
            this.newMailButton.Location = new System.Drawing.Point(5, 415);
            this.newMailButton.Name = "newMailButton";
            this.newMailButton.Size = new System.Drawing.Size(140, 23);
            this.newMailButton.TabIndex = 5;
            this.newMailButton.Text = "Написать письмо";
            this.newMailButton.UseVisualStyleBackColor = true;
            this.newMailButton.Click += new System.EventHandler(this.newMailButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(655, 415);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(140, 23);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Visible = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тема:";
            // 
            // SubjTextBox
            // 
            this.SubjTextBox.Location = new System.Drawing.Point(0, 27);
            this.SubjTextBox.Name = "SubjTextBox";
            this.SubjTextBox.Size = new System.Drawing.Size(790, 20);
            this.SubjTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Получатель:";
            // 
            // attachButton
            // 
            this.attachButton.BackgroundImage = global::MyMailClient.Properties.Resources.attach;
            this.attachButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attachButton.Location = new System.Drawing.Point(0, 98);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(23, 23);
            this.attachButton.TabIndex = 11;
            this.attachButton.UseVisualStyleBackColor = true;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(790, 223);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // RecipTextBox
            // 
            this.RecipTextBox.FormattingEnabled = true;
            this.RecipTextBox.Location = new System.Drawing.Point(0, 71);
            this.RecipTextBox.Name = "RecipTextBox";
            this.RecipTextBox.Size = new System.Drawing.Size(790, 21);
            this.RecipTextBox.TabIndex = 13;
            // 
            // attachDataGridView
            // 
            this.attachDataGridView.AllowUserToAddRows = false;
            this.attachDataGridView.AllowUserToDeleteRows = false;
            this.attachDataGridView.AllowUserToResizeColumns = false;
            this.attachDataGridView.AllowUserToResizeRows = false;
            this.attachDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.attachDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attachDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.attachDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attachDataGridView.ColumnHeadersVisible = false;
            this.attachDataGridView.Location = new System.Drawing.Point(30, 102);
            this.attachDataGridView.Name = "attachDataGridView";
            this.attachDataGridView.ReadOnly = true;
            this.attachDataGridView.RowHeadersVisible = false;
            this.attachDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.attachDataGridView.Size = new System.Drawing.Size(760, 22);
            this.attachDataGridView.TabIndex = 14;
            this.attachDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.attachDataGridView_CellMouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.label10);
            this.NavigationPanel.Controls.Add(this.label9);
            this.NavigationPanel.Controls.Add(this.label8);
            this.NavigationPanel.Controls.Add(this.label7);
            this.NavigationPanel.Controls.Add(this.label6);
            this.NavigationPanel.Controls.Add(this.label5);
            this.NavigationPanel.Controls.Add(this.label4);
            this.NavigationPanel.Location = new System.Drawing.Point(5, 385);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(285, 22);
            this.NavigationPanel.TabIndex = 15;
            this.NavigationPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            this.label4.Click += new System.EventHandler(this.NavLbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(35, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            this.label5.Click += new System.EventHandler(this.NavLbl_Click);
            // 
            // sendMailPanel
            // 
            this.sendMailPanel.Controls.Add(this.attachButton);
            this.sendMailPanel.Controls.Add(this.label3);
            this.sendMailPanel.Controls.Add(this.attachDataGridView);
            this.sendMailPanel.Controls.Add(this.label2);
            this.sendMailPanel.Controls.Add(this.SubjTextBox);
            this.sendMailPanel.Controls.Add(this.richTextBox1);
            this.sendMailPanel.Controls.Add(this.RecipTextBox);
            this.sendMailPanel.Location = new System.Drawing.Point(5, 30);
            this.sendMailPanel.Name = "sendMailPanel";
            this.sendMailPanel.Size = new System.Drawing.Size(790, 350);
            this.sendMailPanel.TabIndex = 16;
            this.sendMailPanel.Visible = false;
            // 
            // downloadAttachButton
            // 
            this.downloadAttachButton.Location = new System.Drawing.Point(183, 2);
            this.downloadAttachButton.Name = "downloadAttachButton";
            this.downloadAttachButton.Size = new System.Drawing.Size(140, 23);
            this.downloadAttachButton.TabIndex = 17;
            this.downloadAttachButton.Text = "Скачать";
            this.downloadAttachButton.UseVisualStyleBackColor = true;
            this.downloadAttachButton.Click += new System.EventHandler(this.downloadAttachButton_Click);
            // 
            // numAttachLabel
            // 
            this.numAttachLabel.AutoSize = true;
            this.numAttachLabel.Location = new System.Drawing.Point(16, 10);
            this.numAttachLabel.Name = "numAttachLabel";
            this.numAttachLabel.Size = new System.Drawing.Size(0, 13);
            this.numAttachLabel.TabIndex = 18;
            // 
            // mailAttachmentsPanel
            // 
            this.mailAttachmentsPanel.Controls.Add(this.numAttachLabel);
            this.mailAttachmentsPanel.Controls.Add(this.downloadAttachButton);
            this.mailAttachmentsPanel.Location = new System.Drawing.Point(472, 387);
            this.mailAttachmentsPanel.Name = "mailAttachmentsPanel";
            this.mailAttachmentsPanel.Size = new System.Drawing.Size(323, 28);
            this.mailAttachmentsPanel.TabIndex = 19;
            this.mailAttachmentsPanel.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(65, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            this.label6.Click += new System.EventHandler(this.NavLbl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(95, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 3;
            this.label7.Click += new System.EventHandler(this.NavLbl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(125, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 4;
            this.label8.Click += new System.EventHandler(this.NavLbl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(155, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 5;
            this.label9.Click += new System.EventHandler(this.NavLbl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(185, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 6;
            this.label10.Click += new System.EventHandler(this.NavLbl_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mailAttachmentsPanel);
            this.Controls.Add(this.sendMailPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.newMailButton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form2";
            this.Text = "MyMailClient: входящая почта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachDataGridView)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.sendMailPanel.ResumeLayout(false);
            this.sendMailPanel.PerformLayout();
            this.mailAttachmentsPanel.ResumeLayout(false);
            this.mailAttachmentsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button newMailButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubjTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox RecipTextBox;
        private System.Windows.Forms.DataGridView attachDataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel sendMailPanel;
        private System.Windows.Forms.Button downloadAttachButton;
        private System.Windows.Forms.Label numAttachLabel;
        private System.Windows.Forms.Panel mailAttachmentsPanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}