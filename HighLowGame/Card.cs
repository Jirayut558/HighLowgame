using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGame
{
    class Card
    {
        private int _Value;
        private string _Suit, _Name;

        public int value
        {
            get { return _Value; }
            set { }
        }
        public string suit
        {
            get { return _Suit; }
            set { }
        }

        public Card()
        {
            _Value = 0;
            _Suit = _Name = "0";
        }
        public void setCard(int n, int s)
        {
            _Value = (n + 1);
            if (_Value > 1 && _Value < 10)
            {
                _Name = "" + _Value;
            }
            else
            {
                if (_Value == 1)
                {
                    _Name = "Ace";
                }
                else if (_Value == 10)
                {
                    _Name = "Jack";
                }
                else if (_Value == 11)
                {
                    _Name = "Queen";
                }
                else
                {
                    _Name = "King";
                }
            }
            switch (s)
            {
                case 0:
                    _Suit = "spades";
                    break;
                case 1:
                    _Suit = "hearts";
                    break;
                case 2:
                    _Suit = "diamonds";
                    break;
                case 3:
                    _Suit = "clubs";
                    break;
                default: break;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} of {1}", _Name, _Suit);
        }
    }
}
