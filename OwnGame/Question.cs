using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnGame
{
    internal struct Question
    {     
        public Question(string text, string answer, Complexity complexity) 
        {
            _text = text;
            _answer = answer;
            _complexity = complexity;
        }    
        
        private readonly string _text = "";
        private readonly string _answer = "";
        private readonly Complexity _complexity = Complexity.VeryEasy;

        public int Cost => (int)_complexity;
        public string Answer => $"Ответ: {_answer}";
        public string Text => _text;
    }

    public enum Complexity
    {
        VeryEasy = 10,
        Easy = 20,
        Normal = 30,
        Hard = 40,
        Expert = 50
    }
}
