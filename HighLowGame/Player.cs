using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGame
{
    class Player
    {
        private string _name;
        private int _countcard, _wincard;

        public string name
        {
            get { return _name; }
            set { }
        }
        public int countcard
        {
            get { return _countcard; }
            set { _countcard = value; }
        }
        public int wincard
        {
            get { return _wincard; }
            set { _wincard = value; }
        }
        public Player()
        {
            _name = "player";
            _countcard = _wincard = 0;
        }
        public Player(string N)
        {
            _name = N;
            _countcard = _wincard = 0;
        }


        public void setplayer(string N)
        {
            _name = N;
            _countcard = _wincard = 0;
        }
        public int getnumberofwincard()
        {
            return _wincard;
        }
        public void calcard(int n)
        {
            _countcard = _countcard - n;
        }
        public void plus(int n)
        {
            _wincard = _wincard + n;
        }
    }
}
