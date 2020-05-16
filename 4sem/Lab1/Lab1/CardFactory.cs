using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface ICard  // 
    {
        void putCard();
        ICard Clone();          // ICard в качестве Prototype
    }
    public interface IComponent     // интерфейс для элементов композита
    {
        string Title { get; set; }
        void Draw();
        IComponent Find(string title);
    }
    public enum STATE { IN_HANDS = 1, ON_TABLE = 2, IN_DECK = 3, DROPPED = 4 };
    public class Card : ICard, IComponent        // Target - только ей может пользоваться крупье
    {
        public string color;         
        public string number;
        public string Title { get; set; }
        public STATE state;
        public CardHistory CH;
        public Card()
        {
            this.color = "";
            this.number = "";
            this.CH = new CardHistory();
        }
        public Card(string c, string n)
        {
            this.color = c;
            this.number = n;
            this.Title = String.Format("play card: {0} {1}", this.number, this.color);
            this.CH = new CardHistory();
        }
        public void putCard()
        {
            this.SaveState();
            this.state = STATE.ON_TABLE;
            this.SaveState();
            Console.WriteLine("put out card:   suit - {0}   number - {1}", this.color, this.number);
        }
        public void takeCard()
        {
            this.SaveState();
            this.state = STATE.IN_HANDS;
            this.SaveState();
            Console.WriteLine("card taken:   suit - {0}   number - {1}", this.color, this.number);
        }
        public ICard Clone()
        {
            return new Card(this.color, this.number);
        }
        public void Draw()
        {
            this.putCard();
        }
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }
        public void SaveState()
        {
            CH.Save(new CardMemento(this.state));
        }
        public void RestoreState()
        {
            if(this.CH.History.Count !=0)
            {
                CH.History.Pop();
                this.state = CH.History.Peek().state;
                
            }
            
        }
    }
    public abstract class CardFactory               // Abstract Factory pattern
    {
        public abstract Card GetCard(string number);
    }
    //-----------------------------------------------------------
    public class RedCardFactory : CardFactory       // отличие от Factory - условия создания определяются самой фабрикой
    {                                               // у меня фабрики делают карточки разных цветов
        public override Card GetCard(string num)
        {
            Console.WriteLine("Red card was given, card number: {0}", num);
            return new Card("red", num);
        }
    }
    public class BlueCardFactory : CardFactory
    {
        public override Card GetCard(string num)
        {
            Console.WriteLine("Blue card was given, card number: {0}", num);
            return new Card("blue", num);
        }
    }
    public class yellowCardFactory : CardFactory
    {
        public override Card GetCard(string num)
        {
            Console.WriteLine("Yellow card was given, card number: {0}", num);
            return new Card("yellow", num);
        }
    }
}
