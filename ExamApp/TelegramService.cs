using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    internal class TelegramService
    {
        public void SendMessage(object? source, ExamEventArgs args)
        {

            Console.WriteLine($"{args.Exam.Name} result sent by Telegram");
        }
    }
}
