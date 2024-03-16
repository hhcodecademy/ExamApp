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


        public event EventHandler<ExamEventArgs> ResultControled;

        public void ControlExam(Exam exam)
        {



            Console.WriteLine($"{exam.Name} result is ready ");

            OnResultControled(exam);
        }

        public void OnResultControled(Exam exam)
        {

            if (ResultControled != null)
            {
                ResultControled.Invoke(this, new ExamEventArgs
                {
                    Exam = exam
                });
            }


        }
    }
}
