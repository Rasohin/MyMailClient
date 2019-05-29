using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MyMailClient
{
    public class CheckServerName
    {
        public struct ConnectionSet
        {
            public string pop3Str;
            public string login;
            public string pass;
            public int pop3Port;
            public string smtpStr;
            public int smtpPort;
        }

        private string ServerName(string str)
        {
            int index = str.IndexOf("@");
            str = str.Substring(index+1);
            return str;
        }

        public ConnectionSet GetConnectSettings(string login, string pass)
        {
            ConnectionSet conSet= new ConnectionSet();
            conSet.login = login;
            conSet.pass = pass;
            string server = ServerName(login);
            switch (server)
            {
                case "mail.ru":
                    conSet.pop3Str = "pop.mail.ru";
                    conSet.pop3Port = 995;
                    conSet.smtpStr = "smtp.mail.ru";
                    conSet.smtpPort = 587;
                    break;
                case "gmail.com":
                    conSet.pop3Str = "pop.gmail.com";
                    conSet.pop3Port = 995;
                    conSet.smtpStr = "smtp.gmail.com";
                    conSet.smtpPort = 587;
                    break;
                case "yandex.ru":
                    conSet.pop3Str = "pop.yandex.ru";
                    conSet.pop3Port = 995;
                    conSet.smtpStr = "smtp.yandex.ru";
                    conSet.smtpPort = 587;
                    break;
                default:
                    throw new UnsupportServerException("Ошибка: Сервер вашей почты не поддерживается клиентом\n" +
                        "В настоящий момент поддерживаются только: Mail.ru, Yandex, Gmail");
            }
            return conSet;
        }
    }
}
