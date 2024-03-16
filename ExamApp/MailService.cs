using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    internal class MailService
    {
        public void SendMail(object? source, ExamEventArgs args)
        {

            Console.WriteLine($" {args.Exam.Name} result sent by EMail");
        }
    }
}
