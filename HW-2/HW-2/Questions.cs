using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
 

    public class Questions
    {
        private string question;
        private int answer;

        public Questions(string question, int answer)
        {
            this.question = question;
            this.answer = answer;
        }

        public string getQuestion()
        {
            return question;
        }

        public int getAnswer()
        {
            return answer;
        }
    }
}
