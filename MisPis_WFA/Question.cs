using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisPis_WFA
{
    internal class Question
    {
        public string text;
        public string ans;
        public int difficulty;
        public string userAns;
        public Question()
        {

        }

        public Question(string text, string ans, int difficulty)
        {
            this.text = text;
            this.ans = ans;
            this.difficulty = difficulty;
        }
    }
}
