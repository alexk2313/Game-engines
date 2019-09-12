using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
   

    class Question
    {
        private string content;
        private bool answer;
        
        public Question(string content, bool answer)
        {
            this.content = content;
            this.answer = answer;
        }


        public string getContent()
        {
            return content;
            
        }


        public bool getAnswer()
        {
            return answer;
        }
    }

    
}
