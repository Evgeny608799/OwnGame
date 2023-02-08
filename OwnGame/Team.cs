using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnGame
{
    public class Team
    {
        public event EventHandler<TeamDataChangedEventArgs>? Notify;

        public Team(string name) 
        {
            Name = name;
        }
        
        private int _scores = 0;
        private int _multiplier = 1;
        public string Name { get; set; }
        public int Score => _scores;
        public int Multiplier => _multiplier;

        public void AddScores (int score)
        {
            _scores += score * _multiplier;
            _multiplier++;
            Notify?.Invoke(this, new TeamDataChangedEventArgs() { 
                Message = $"{Name}: Получено {score * (_multiplier - 1)} очков\n" +
                $"Текущий множитель: {_multiplier}"
            });
        }

        public void ResetMultiplier() => _multiplier = 1;
    }

    public class TeamDataChangedEventArgs
    {
        public required string Message { get; set; }
    }
}
