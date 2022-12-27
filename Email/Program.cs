using System.Net.Mail;
using System.Net;

namespace Email
{
    class Programm
    {
        static void SendEmail()
        {
            Console.WriteLine("Введите почту получателя:");
            string to = Console.ReadLine();
            while (to == null)
            {
                to = Console.ReadLine();
            }
            Console.WriteLine("Введите почту отправителя:");
            string from = Console.ReadLine();
            while (from == null)
            {
                from = Console.ReadLine();
            }
            Console.WriteLine("Введите пароль от почты отправителя:");
            string pass = Console.ReadLine();
            while (pass == null)
            {
                pass = Console.ReadLine();
            }
            MailMessage m = new MailMessage();
            m.From = new MailAddress(from);
            m.To.Add(new MailAddress(to));
            m.Subject = "Сообщение из С#";
            m.Body =  $@"Это сообщение отправлено с помощью кода C#
С наступающим :)";
            SmtpClient cli = new SmtpClient("smtp.yandex.ru", 25);
            cli.Credentials = new NetworkCredential(from,pass);
            cli.EnableSsl = true;
            //cli.UseDefaultCredentials = true;
            try
            {
                cli.Send(m);
            }
            catch (Exception e)
            {
                Console.WriteLine("Не получилось отрпавить сообщение:"+e.ToString());
            }
        }

        static void Main()
        {
            SendEmail();

        }
    }
}
