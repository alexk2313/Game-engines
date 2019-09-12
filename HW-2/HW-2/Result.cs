using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Result
    {
        private string name;
        private int score;

        public Result(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public string getName()
        {
            return name;
        }
        public int getScore()
        {
            return score;
        }
    }
}
