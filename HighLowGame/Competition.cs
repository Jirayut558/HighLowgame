using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGame
{
    class Competition
    {
        private Player[] _player = new Player[2];
        private Deck _setofcard = new Deck();

        private Deck cardforp_1 = new Deck();
        private Deck cardforp_2 = new Deck();

        public void start()
        {
            Console.WriteLine("**********High Low Card Game **********");
            Console.WriteLine("**********     Start         **********");
            //createcard
            _setofcard.createcard();
            //set name
            string nofplayer;
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Input name of Player" + (i + 1) + " : ");
                nofplayer = Console.ReadLine();
                _player[i] = new Player();
                _player[i].setplayer(nofplayer);
            }
            //shuffle
            _setofcard.shuffle();
            dealing();
            process();
            getwinner();
        }
        public void restart()
        {
            _setofcard.createcard();
            //
            _player[0].countcard = _player[0].wincard = 0;
            _player[1].countcard = _player[1].wincard = 0;
            _setofcard.shuffle();
            dealing();
            process();

        }
        public void dealing()
        {
            int n = 0;
            for (int i = 0; i < 52; i = i + 2)
            {
                cardforp_1.card[n] = _setofcard.card[i];
                n = n + 1;
            }
            int x = 0;
            for (int j = 1; j < 52; j = j + 2)
            {
                cardforp_2.card[x] = _setofcard.card[j];
                x = x + 1;
            }
            _player[0].countcard = 26;
            _player[1].countcard = 26;
        }
        public void process()
        {
            //compare               
            int n = 25;
            while (n >= 0)
            {
                if (cardforp_1.card[n].value != cardforp_2.card[n].value)
                {
                    Console.WriteLine("   " + cardforp_1.card[n] + "\t\t" + _player[0].name);
                    Console.WriteLine("   " + cardforp_2.card[n] + "\t\t" + _player[1].name);
                    if (cardforp_1.card[n].value > cardforp_2.card[n].value)
                    {
                        _player[0].calcard(1);
                        _player[1].calcard(1);
                        _player[0].plus(2);
                        n -= 1;
                        Console.WriteLine(_player[0].name + " :: is Win" + " Get 2 cards");
                    }
                    else
                    {
                        _player[0].calcard(1); ;
                        _player[1].calcard(1); ;
                        _player[1].plus(2);
                        n -= 1;
                        Console.WriteLine(_player[1].name + " :: is Win" + " Get 2 cards");
                    }
                    Console.WriteLine("  ---------------- ");
                }
                else
                {
                    Console.WriteLine("   " + cardforp_1.card[n] + "\t\t" + _player[0].name);
                    Console.WriteLine("   " + cardforp_2.card[n] + "\t\t" + _player[1].name);
                   
                    if (cardforp_1.card[n].value <(n + 1))
                    {
                        Console.WriteLine(" Get Last card of new setofcards " + cardforp_1.card[n].value +" cards");
                        if (cardforp_1.card[n - 1].value != cardforp_2.card[n - 1].value)
                        {
                            if (cardforp_1.card[n - 1].value > cardforp_2.card[n - 1].value)
                            {
                                Console.WriteLine("   " + cardforp_1.card[n - 1] + "\t\t" + _player[0].name);
                                Console.WriteLine("   " + cardforp_2.card[n - 1] + "\t\t" + _player[1].name);
                                _player[0].calcard(cardforp_1.card[n].value + 1);
                                _player[1].calcard(cardforp_1.card[n].value + 1);
                                _player[0].plus(cardforp_1.card[n].value + cardforp_2.card[n].value + 2);
                                Console.WriteLine(_player[0].name + " :: is Win Get " + (cardforp_1.card[n].value + cardforp_2.card[n].value + 2) + " cards");
                                n -= (cardforp_1.card[n].value + 1);
                            }
                            else
                            {
                                Console.WriteLine("   " + cardforp_1.card[n - 1] + "\t\t" + _player[0].name);
                                Console.WriteLine("   " + cardforp_2.card[n - 1] + "\t\t" + _player[1].name);
                                _player[0].calcard(cardforp_1.card[n].value + 1);
                                _player[1].calcard(cardforp_1.card[n].value + 1);
                                _player[1].plus(cardforp_1.card[n].value + cardforp_2.card[n].value + 2);
                                Console.WriteLine(_player[1].name + " :: is Win Get " + (cardforp_1.card[n].value + cardforp_2.card[n].value + 2) + " cards");
                                n -= (cardforp_1.card[n].value + 1);
                            }
                        }
                        else
                        {
                            Console.WriteLine(" \n -----------------Re Shuffle--------------- ");
                            Console.WriteLine(" \n -----------------Equal card 2 times--------------- ");
                            restart();
                            break;
                        }
                    }
                    else
                    {
                        if (n == 0)
                        {
                            Console.WriteLine(" ------- Equal Last Gard -------- ");
                            break;
                        }
                        else
                        {
                            if (cardforp_1.card[n - 1].value != cardforp_2.card[n - 1].value)
                            {
                                Console.WriteLine(" Get Last card of new last setofcards " + n + " cards");
                                if (cardforp_1.card[n - 1].value > cardforp_2.card[n - 1].value)
                                {
                                    Console.WriteLine("   " + cardforp_1.card[n - 1] + "\t\t" + _player[0].name);
                                    Console.WriteLine("   " + cardforp_2.card[n - 1] + "\t\t" + _player[1].name);
                                    _player[0].calcard(n + 1);
                                    _player[1].calcard(n + 1);
                                    _player[0].plus(n + n + 2);
                                    Console.WriteLine(_player[0].name + " :: is Win Get " + (n + n + 2) + " cards");
                                    n -= (n + 1);
                                }
                                else
                                {
                                    Console.WriteLine("   " + cardforp_1.card[n - 1] + "\t\t" + _player[0].name);
                                    Console.WriteLine("   " + cardforp_2.card[n - 1] + "\t\t" + _player[1].name);
                                    _player[0].calcard(n + 1);
                                    _player[1].calcard(n + 1);
                                    _player[1].plus(n + n + 2);
                                    Console.WriteLine(_player[1].name + " :: is Win Get " + (n + n + 2) + " cards");
                                    n -= (n + 1);
                                }
                            }
                            else
                            {
                                Console.WriteLine(" \n -----------------Re Shuffle--------------- ");
                                Console.WriteLine(" \n -----------------Equal card 2 times--------------- ");
                                restart();
                                break;
                            }
                        }
                    }
                    Console.WriteLine("  ---------------- ");
                }
                Console.ReadKey();
            }
        }
        public void getwinner()
        {
            if (_player[0].wincard != _player[1].wincard)
            {
                if (_player[0].wincard > _player[1].wincard)
                {
                    Console.WriteLine("The Winner is "+_player[0].name + " Have " + _player[0].wincard + " Cards\t" + _player[1].name + " Have " + _player[1].wincard + " Cards\t");
                }
                else
                {
                    Console.WriteLine("The Winner is " +_player[1].name + " Have " + _player[1].wincard + " Cards\t" + _player[0].name + " Have " + _player[0].wincard + " Cards\t");
                }
            }
            else
            {
                Console.WriteLine(" \n ---------------Equal WinCard--------------- ");
                Console.WriteLine(" \n -----------------Re Start--------------- ");
                restart();
                getwinner();
            }
        }

    }
}
