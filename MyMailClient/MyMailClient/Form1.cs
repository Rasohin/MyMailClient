using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyMailClient
{
    public partial class Form1 : Form
    {
        protected string _pattern = "^[@a-zA-Z0-9_.-]+$";

        public Form1()
        {
            InitializeComponent();
        }

        private bool LoginValidation(string login, string pass)
        {
            if (Regex.IsMatch(login, "@", RegexOptions.Compiled))
                {
                    if (Regex.IsMatch(login, _pattern, RegexOptions.Compiled) && Regex.IsMatch(pass, _pattern, RegexOptions.Compiled))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Неверно введены символы!\n\nРазрешены только большие и маленькие буквы латиницы[A - z], цифры[0 - 9] и символы '-','_','.'");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Логин обязательно должен содержать знак @ и соответствовать адресу электронной почты");
                    return false;
                }
        }

        private void autorizButton_Click(object sender, EventArgs e)
        {
            if(LoginValidation(loginInput.Text, passInput.Text))
            {
                CheckServerName checker = new CheckServerName();
                try
                {
                    Form2 mainWind = new Form2(checker.GetConnectSettings(loginInput.Text, passInput.Text));
                    if (loginInput.Items.Contains(loginInput.Text) == false)
                        loginInput.Items.Add(loginInput.Text);
                    Hide();
                    mainWind.ShowDialog();
                    loginInput.Text = "";
                    passInput.Text = "";
                }
                catch(UnsupportServerException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Show();
            }
        }


        private void passInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                autorizButton.PerformClick();
        }
    }
}
