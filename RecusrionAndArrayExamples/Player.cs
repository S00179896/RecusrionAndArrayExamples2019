using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecusrionAndArrayExamples
{
    public class Player
    {
        int _id;
        string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public Player(int id, string PlayerName)
        {
            _id = id;
            _name = PlayerName;
        }
    }
}
