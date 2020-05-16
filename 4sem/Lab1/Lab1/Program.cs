using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayField playfield = new PlayField();
            DeckDirector deckdir = new DeckDirector();
            playfield.startGame("Alex");
            //playfield.startGame("Peter");       // все равно будет Алекс, потому что Singleton
            List<Card> blues = deckdir.BlueDeck();
            List<Card> fulldeck = deckdir.FullDeck();
            //playfield.croupier.giveCardToPlayer(new DiciplinaryCard("too noisy", 5)); - нельзя
            //playfield.croupier.giveCardToPlayer(new DiciplinaryToCard(new DiciplinaryCard("too noisy", 5)));
            //playfield.croupier.giveCardToPlayer(new Card("pink", "0"));
            BeautifulCard beautiful = new BeautifulCard(new Card("pink", "0"));
            beautiful.putCard();
            Console.WriteLine("---------------------------------------");
            //Map for_play = new Map();
            //for_play.AddComponent(playfield.croupier);
            //for_play.AddComponent(new DiciplinaryCard("too noisy", 5));
            //for_play.AddComponent(new Card("red", "9"));
            //IComponent found = for_play.Find("diciplinary card - too noisy");
            //found.Draw();
            Console.WriteLine("--------------------------------------");
            List<Card> mycards = playfield.croupier.spread(fulldeck);
            Commands act = new Commands(fulldeck, mycards);
            Console.WriteLine("А теперь вводим команды до бесконечности - допустим, играем с самого начала");
            ConsoleKeyInfo x = new ConsoleKeyInfo();
            while (true)
            {
                x = Console.ReadKey();
                Console.WriteLine();
                act.Execute(x.KeyChar);
                int k = 0;
            }
            
        }
    }
}
