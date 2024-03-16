namespace ExamApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Exam exam = new Exam();
            exam.Name = "IELTS";
            exam.Result = 8;

            MessageService messageService = new MessageService();
            TelegramService telegramService = new TelegramService();
            MailService mailService = new MailService();
            ExamOperation examOperation = new ExamOperation();
            examOperation.NotifyHandler += messageService.SendMessage;
            examOperation.NotifyHandler += mailService.SendMail;
            examOperation.NotifyHandler += telegramService.SendMessage;
            examOperation.NotifyHandler -= mailService.SendMail;
            examOperation.ControlExam(exam);


        }
    }
}
