namespace ExamApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Exam exam = new Exam();
            exam.Name = "IELTS";
            exam.Result = 8;
                           
      
            ExamOperation examOperation = new ExamOperation();
            examOperation.ResultControled += Mail_ResultControled;
            examOperation.ResultControled += Message_ResultControled;
            examOperation.ResultControled += Telegram_ResultControled;

            //examOperation.ResultControled += messageService.SendMessage;
            //examOperation.ResultControled += mailService.SendMail;
            //examOperation.ResultControled += telegramService.SendMessage;
            examOperation.ControlExam(exam);


        }

        private static void Telegram_ResultControled(object? sender, ExamEventArgs e)
        {
            TelegramService telegramService = new TelegramService();
            telegramService.SendMessage(sender, e);
        }

        private static void Message_ResultControled(object? sender, ExamEventArgs e)
        {
            MessageService messageService = new MessageService();
            messageService.SendMessage(messageService, e);
        }

        private static void Mail_ResultControled(object? sender, ExamEventArgs e)
        {
            MailService mailService = new MailService();
            mailService.SendMail(sender, e);
        }
    }
}
