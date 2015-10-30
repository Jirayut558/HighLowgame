using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGame
{
    class Deck
    {
        private Card[] _card = new Card[52];

        public Card[] card
        {
            get { return _card; }
            set { }
        }
        public Deck()
        {
            for (int i = 0; i < 52; i++)
            {              
                    _card[i] = new Card();             
            }
        }
        public void createcard()
        {           
            int index = 0;
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<13;j++)
                {
                    _card[index] = new Card();
                    _card[index].setCard(j,i);
                    index++;
                }
            }
        }
        public void shuffle()
        {
            int counter = 0;
            int length = 52;
            Random random = new Random();
            Card[] array = new Card[length];
            while (counter < length)
            {
                int index = random.Next(0, 52);
                Card card = _card[index];
                if (!array.Contains(card))
                {
                    array[counter] = card;
                    counter++;
                }
            }
            _card = array;
        }
    }
}
