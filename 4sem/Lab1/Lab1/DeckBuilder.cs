using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface IBuilder
    {
        List<Card> giveReds();
        List<Card> giveBlues();
        List<Card> giveYellows();
        List<Card> giveSpecials();
        List<Card> giveDeck();
    }
    public class DeckBuilder : IBuilder
    {
        public List<Card> giveReds()
        {
            RedCardFactory rcf = new RedCardFactory();
            List<Card> rc = new List<Card>();
            for (int i = 0; i < 10; i++) rc.Add(rcf.GetCard(i.ToString()));
            return rc;
        }
        public  List<Card> giveBlues()
        {
            BlueCardFactory bcf = new BlueCardFactory();
            List<Card> rc = new List<Card>();
            for (int i = 1; i < 10; i++) rc.Add(bcf.GetCard(i.ToString()));
            return rc;
        }
        public  List<Card> giveYellows()
        {
            yellowCardFactory ycf = new yellowCardFactory();
            List<Card> rc = new List<Card>();
            for (int i = 0; i < 10; i++) rc.Add(ycf.GetCard(i.ToString()));
            return rc;
        }
        public List<Card> giveSpecials()
        {
            List<Card> rc = new List<Card>();
            rc.Add(new Card("yellow", "return"));
            rc.Add(new Card("red", "return"));
            rc.Add(new Card("blue", "return"));
            rc.Add(new Card("yellow", "skip"));
            rc.Add(new Card("red", "skip"));
            rc.Add(new Card("blue", "skip"));
            return rc;
        }
        public List<Card> giveDeck()            // полная колода - 36
        {
            DeckBuilder db = new DeckBuilder();
            List<Card> reds = db.giveReds();
            List<Card> blues = db.giveBlues();
            List<Card> yellows = db.giveYellows();
            List<Card> spec = db.giveSpecials();
            var deck = spec.Concat(reds)
                           .Concat(blues)
                           .Concat(yellows)
                           .ToList();
            foreach (Card c in deck)
            {
                c.state = STATE.IN_DECK;
            }
            return deck;
        }
    }
    public class DeckDirector : DeckBuilder
    {
        public List<Card> RedDeck()
        {
            return giveReds();
        }
        public List<Card> BlueDeck()
        {
            return giveBlues();
        }
        public List<Card> YellowDeck()
        {
            return giveYellows();
        }
        public List<Card> FullDeck()
        {
            return giveDeck();
        }
    }
}
