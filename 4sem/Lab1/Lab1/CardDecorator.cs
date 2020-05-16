using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class CardDecorator : ICard      // базовый декоратор
    {
        protected readonly ICard card;
        public CardDecorator()
        {
            this.card = new Card();
        }
        public CardDecorator(ICard element)
        {
            this.card = element;
        }
        public virtual void putCard()
        {
            Console.WriteLine("suit - {0}   number - {1}", ((Card)this.card).color, ((Card)this.card).number);
        }
        public ICard Clone()
        {
            return new CardDecorator();
        }
    }
    public class BeautifulCard : CardDecorator      // специфичный декоратор
    {
        public BeautifulCard(ICard element) : base(element) { }
        public override void putCard()
        {
            base.putCard();
            Console.WriteLine(" -------------------");
            Console.WriteLine("|                  |");
            Console.WriteLine("|                 {0}|", ((Card)this.card).number);
            Console.WriteLine("|                  |");
            Console.WriteLine("|                  |");
            Console.WriteLine("|       {0}       |", ((Card)this.card).color);
            Console.WriteLine("|                  |");
            Console.WriteLine("|                  |");
            Console.WriteLine("|{0}                 |", ((Card)this.card).number);
            Console.WriteLine("|                  |");
            Console.WriteLine(" -------------------");
        }
    }
}
