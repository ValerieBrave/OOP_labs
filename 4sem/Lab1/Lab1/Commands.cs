using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface ICommand
    {
        void Execute(char c);
    }
    public class Commands:ICommand
    {
        public List<Card> deck;
        public List<Card> mycards;
        public Commands()
        {
            this.deck = new List<Card>();
            this.mycards = new List<Card>();
        }
        public Commands( List<Card> d, List<Card> m)
        {
            this.deck = d;
            this.mycards = m;
        }
        public void Execute(char c)
        {
            switch(c)
            {
                case 'p':
                    {
                        if (this.mycards.Count != 0 && this.mycards[0].state != STATE.DROPPED)
                        {
                            this.mycards[mycards.Count - 1].putCard();
                            this.mycards.RemoveAt(mycards.Count - 1);
                        }
                        else Console.WriteLine("you have no cards left");
                    } break;
                case 't':
                    {
                        if(this.deck.Count !=0)
                        {
                            this.deck[this.deck.Count - 1].takeCard();
                            this.mycards.Add(this.deck[this.deck.Count - 1]);
                            this.deck.RemoveAt(this.deck.Count - 1);
                        }
                        else Console.WriteLine("no cards left in deck");
                    } break;
                case 's':
                    {
                        foreach (Card d in this.mycards)
                        {
                            d.state = STATE.DROPPED;
                        }
                    }break;
                case 'r':
                    {
                        this.mycards[0].RestoreState();
                    }break;
            }
        }
    }
    
}
