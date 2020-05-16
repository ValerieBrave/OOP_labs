using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    sealed class Croupier : IComponent   // Singleton pattern + Client in Adapter pattern
    {
        public static Croupier instance;
        public string Name { get; private set; }
        //сделаю так, что при старте игры может быть только один крупье за столом
        public string Title { get; set; }
        private Croupier(string n)
        {
            this.Name = n;
            this.Title = "croupier " + n;
        }
        public static Croupier getInstance(string name)
        {
            if (instance == null)
            {
                instance = new Croupier(name);
            }
            return instance;
        }
        public void giveCardToPlayer(ICard card)
        {
            card.putCard();
        }
        public void Draw()
        {
            Console.WriteLine("Croupier's name is {0}", this.Name);
        }
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }
        public List<Card> spread(List<Card> fulldeck)
        {
            Random rnd = new Random();
            List<Card> rc = new List<Card>();
            for(int i =0; i<6; i++) rc.Add(fulldeck[rnd.Next(0, fulldeck.Count)]);
            foreach(Card d in rc)
            {
                d.state = STATE.IN_HANDS;
                d.SaveState();
            }
            return rc;
        }
    }
    class PlayField
    {
        public Croupier croupier { get; set; }
        public void startGame(string cr_name)
        {
            this.croupier = Croupier.getInstance(cr_name);
            Console.WriteLine("Start game: yours croupier name - "+this.croupier.Name);
        }
    }
    
}
