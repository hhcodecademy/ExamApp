using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    internal class ExamEventArgs:EventArgs
    {
        public Exam Exam { get; set; }
    }
}
