using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    internal class ExamOperation
    {
        //public delegate void MessageDelegate(Exam exam);

        //public event MessageDelegate Notify;


        public event EventHandler<ExamEventArgs> NotifyHandler;

        public void ControlExam(Exam exam)
        {



            Console.WriteLine($"{exam.Name} result is ready ");

            FinishOperation(exam);
        }

        public void FinishOperation(Exam exam)
        {

            if (NotifyHandler != null)
            {
                NotifyHandler.Invoke(this, new ExamEventArgs
                {
                    Exam = exam
                });
            }


        }
    }
}
