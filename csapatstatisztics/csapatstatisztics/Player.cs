using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace csapatstatisztics
{
    public class Player
    {
        private string _name;
        private string _position;
        private int _number;

        public string Name { get { return _name; }set { _name = value; } }
        public string Position { get { return _position; }set { _position = value; } }
        public int Number { get { return _number; }set { if(_number >= 0 && _number <= 99)_number = value;  } }
        public static int Count;

        public Player(string name, string position, int number)
        {
            _name = name;
            _position = position;
            _number = number;
            Count++;
        }

        private int _gamesPlayed;
        private int _totalPoints;

        public int GamesPlayed { get; }
        public int TotalPoints { get; }


        public bool AddPoints(int points)
        {
            _gamesPlayed++;
            _totalPoints += points;
            return points > 0;
        }

        public double AvragePoints()
        {
            if (_gamesPlayed > 0)
                return _totalPoints / _gamesPlayed;
            else
                return 0.0;
        }

        public string Describtion()
        {
            return $"{_name}, {_number}, {_position}, {Math.Round(AvragePoints(), 1)}"; // Convert.Toint(AvragePoints() * 10) / 10
        }



    }
}
