using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Pop3;
using MimeKit;
using System.Net;
using System.Net.Mail;

namespace MyMailClient
{
    public partial class Form2 : Form
    {
        CheckServerName.ConnectionSet conSet = new CheckServerName.ConnectionSet();
        MimeMessage mess = new MimeMessage();
        List<MimeMessage> messages = new List<MimeMessage>();
        IEnumerable<MimeEntity> mailAttachments;
        Pop3Client Pop3Cl;
        List<string> att = new List<string>();
        string[] attach;
        int numMailAtList = 20;
        int openMailIndex = 0;
        bool dialogres = false;
        int showPageNum = 1;

        public Form2(CheckServerName.ConnectionSet set)
        {
            InitializeComponent();
            conSet = set;
            
            Pop3Cl = new Pop3Client();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                Pop3Cl.Connect(conSet.pop3Str, conSet.pop3Port, true);
                Pop3Cl.Authenticate(conSet.login, conSet.pass);
                Text += $" ({Pop3Cl.GetMessageCount().ToString()} сообщений)";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:{ex.Message}");
            }

            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = numMailAtList;
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 520;
            dataGridView1.Columns[2].Width = 120;
            messages.Clear();
            messages.AddRange(Pop3Cl.GetMessages(Pop3Cl.GetMessageCount() - numMailAtList, numMailAtList));
            int i = numMailAtList;
            foreach (MimeMessage S in messages)
            {
                dataGridView1[0, i - 1].Value = S.From;
                dataGridView1[1, i - 1].Value = S.Subject;
                dataGridView1[2, i - 1].Value = $"{S.Date.Day}.{S.Date.Month}.{S.Date.Year}";
                i--;
            }
            Navigation(Pop3Cl.GetMessageCount());
        }


            private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pop3Cl.Disconnect(true);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            webBrowser1.Visible = true;
            returnButton.Visible = true;
            NavigationPanel.Visible = false;
            openMailIndex = numMailAtList - index - 1;
            webBrowser1.DocumentText = messages[openMailIndex].HtmlBody;
            label1.Text += $" {messages[openMailIndex].Subject}";
            mailAttachments = messages[openMailIndex].Attachments;
            if(mailAttachments.Count()>0)
            {
                numAttachLabel.Text = $"Прикрепленные файлы: {mailAttachments.Count()} шт.";
                mailAttachmentsPanel.Visible = true;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Входящие: ";
            webBrowser1.Visible = false;
            returnButton.Visible = false;
            dataGridView1.Visible = true;
            sendButton.Visible = false;
            sendMailPanel.Visible = false;
            mailAttachmentsPanel.Visible = false;
            NavigationPanel.Visible = true;
            att.Clear();
        }

        private void newMailButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            returnButton.Visible = true;
            dataGridView1.Visible = false;
            sendButton.Visible = true;
            sendMailPanel.Visible = true;
            mailAttachmentsPanel.Visible = false;
            NavigationPanel.Visible = false;
            attachDataGridView.Visible = false;
            label1.Text = "Новое сообщение: ";
            SubjTextBox.Text = "";
            RecipTextBox.Text = "";
            richTextBox1.Text = "";
            att.Clear();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient SC = new SmtpClient(conSet.smtpStr, conSet.smtpPort);
                MailMessage mess = new MailMessage();

                mess.From = new MailAddress(conSet.login);
                mess.To.Add(new MailAddress(RecipTextBox.Text));
                mess.IsBodyHtml = true;
                mess.Body = richTextBox1.Text;
                mess.Subject = SubjTextBox.Text;


                if (att.Count > 0)
                    foreach(string s in att)
                        mess.Attachments.Add(new Attachment(s));
               
                SC.Credentials = new NetworkCredential(mess.From.ToString(), conSet.pass);
                SC.EnableSsl = true;
                SC.DeliveryMethod = SmtpDeliveryMethod.Network;
                SC.Send(mess);
                MessageBox.Show("Ваше письмо отправлено получателю");

                if (RecipTextBox.Items.Contains(RecipTextBox.Text) == false)
                    RecipTextBox.Items.Add(RecipTextBox.Text);
                label1.Text = "Входящие: ";
                webBrowser1.Visible = false;
                returnButton.Visible = false;
                dataGridView1.Visible = true;
                sendButton.Visible = false;
                sendMailPanel.Visible = false;
                mailAttachmentsPanel.Visible = false;
                NavigationPanel.Visible = true;
                att.Clear();
            }
            catch (Exception ecp)
            {
                MessageBox.Show(ecp.Message);
            }
        }

        void showAttachments()
        {
            attachDataGridView.Visible = true;
            if (att.Count == 0)
            {
                attachDataGridView.RowCount = 1;
                attachDataGridView.ColumnCount = 1;
                attachDataGridView.Rows[0].Height = 15;
                attachDataGridView.Columns[0].Width = 15;
                attachDataGridView.ClearSelection();
            }
            else
            {
                int delta = 1;
                attachDataGridView.RowCount = 1;
                attachDataGridView.ColumnCount = att.Count*2;
                attachDataGridView.Rows[0].Height = 15;
                attachDataGridView.ClearSelection();
                for (int i = 0; i < att.Count * 2; i++)
                {
                    int cellWidth = (attachDataGridView.Width - att.Count * 15) / att.Count;
                    if (i % 2 == 0)
                    {
                        attachDataGridView.Columns[i].Width = 15;
                        attachDataGridView[i, 0].Value = "X";
                        attachDataGridView[i, 0].Style.BackColor = Color.DarkRed;
                    }
                    else
                    {
                        attachDataGridView.Columns[i].Width = cellWidth;
                        int index = 0;
                        index = att[i - delta].LastIndexOf('\\');
                        attachDataGridView[i, 0].Value = att[i - delta].Substring(index+1);
                        delta++;
                    }
                }
            }
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            attach = null;
            openFileDialog1.ShowDialog();
            if (attach != null)
            {
                if ((att.Count + attach.Length) <= 6)
                    foreach (string s in attach)
                        att.Add(s);
                else
                    MessageBox.Show("Максимальное количество прикрепляемых файлов: 6");
            }
            showAttachments();
        }

        private void attachDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (attachDataGridView.CurrentCell.Value.ToString() == "X")
            {
                int index = e.ColumnIndex;
                attachDataGridView.CurrentCell.Style.BackColor = Color.White;
                attachDataGridView.CurrentCell.Value = "";
                attachDataGridView[index + 1, 0].Value = "";
                att.RemoveAt(index / 2);
                showAttachments();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            attach = openFileDialog1.FileNames;
        }

        private void downloadAttachButton_Click(object sender, EventArgs e)
        {
            string fileName = "";
            int countOfSavedFiles = 0;

                foreach (MimeEntity attachment in messages[openMailIndex].Attachments)
                {
                    fileName = attachment.ContentDisposition.FileName;
                    saveFileDialog1.FileName = fileName;
                    dialogres = false;
                    saveFileDialog1.ShowDialog();
                    if(dialogres == true)
                    {
                        fileName = saveFileDialog1.FileName;
                        using (var stream = File.Create(fileName))
                        {

                            if (attachment is MessagePart)
                            {
                                var rfc822 = (MessagePart)attachment;

                                rfc822.Message.WriteTo(stream);
                            }
                            else
                            {
                                var part = (MimePart)attachment;

                                part.Content.DecodeTo(stream);
                            }
                        }
                        countOfSavedFiles++;
                    }
                }
                if(countOfSavedFiles == messages[openMailIndex].Attachments.Count())
                    MessageBox.Show("Все ваши файлы успешно сохранены");
                else
                    MessageBox.Show($"Количество успешно сохраненных файлов: {countOfSavedFiles}");
        }

        private void Navigation(int num)
        {
            int page = 1;
            if (num > 20)
                page = num / 20;
            List<Label> navLbl = new List<Label>(7);
            navLbl.Add(label4);
            navLbl.Add(label5);
            navLbl.Add(label6);
            navLbl.Add(label7);
            navLbl.Add(label8);
            navLbl.Add(label9);
            navLbl.Add(label10);

            if (page>1)
            {
                NavigationPanel.Visible = true;
                if(page<8)
                {
                    for(int i=0; i<page; i++)
                    {
                        navLbl[i].Text = (i + 1).ToString();
                    }
                }
                else
                {
                    if(showPageNum == 1 || showPageNum == page)
                    {
                        navLbl[0].Text = "1";
                        navLbl[1].Text = "2";
                        navLbl[2].Text = "3";
                        navLbl[3].Text = "...";
                        navLbl[4].Text = $"{page-2}";
                        navLbl[5].Text = $"{page - 1}";
                        navLbl[6].Text = $"{page}";
                    }
                    else if(showPageNum<(page-4))
                    {
                        navLbl[0].Text = $"{showPageNum-1}";
                        navLbl[1].Text = $"{showPageNum}";
                        navLbl[2].Text = $"{showPageNum+1}";
                        navLbl[3].Text = "...";
                        navLbl[4].Text = $"{page - 2}";
                        navLbl[5].Text = $"{page - 1}";
                        navLbl[6].Text = $"{page}";
                    }
                    else
                    {
                        navLbl[0].Text = $"1";
                        navLbl[1].Text = $"2";
                        navLbl[2].Text = $"3";
                        navLbl[3].Text = "...";
                        navLbl[4].Text = $"{showPageNum-1}";
                        navLbl[5].Text = $"{showPageNum}";
                        navLbl[6].Text = $"{showPageNum+1}";
                    }
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            dialogres = true;
        }

        private void NavLbl_Click(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            if (temp.Text != "...")
            {
                showPageNum = Convert.ToInt32(temp.Text);
                messages.Clear();
                messages.AddRange(Pop3Cl.GetMessages(Pop3Cl.GetMessageCount() - numMailAtList*showPageNum, numMailAtList));
                int i = numMailAtList;
                foreach (MimeMessage S in messages)
                {
                    dataGridView1[0, i - 1].Value = S.From;
                    dataGridView1[1, i - 1].Value = S.Subject;
                    dataGridView1[2, i - 1].Value = $"{S.Date.Day}.{S.Date.Month}.{S.Date.Year}";
                    i--;
                }
                Navigation(Pop3Cl.GetMessageCount());
            }
        }
    }
}
