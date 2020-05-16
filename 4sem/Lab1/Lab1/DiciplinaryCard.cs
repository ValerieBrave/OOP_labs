using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class DiciplinaryCard : IComponent        //Adaptee -  не реализует ICard, 
    {                                   //поэтому для него нужен адаптер, чтобы им мог пользоваться крупье
        public string message;
        public int mark;
        public string Title { get; set; }
        public DiciplinaryCard()
        {
            this.message = "";
            this.mark = 0;
            this.Title = "diciplinary card - " + this.message;
        }
        public DiciplinaryCard(string mes, int mar)
        {
            this.message = mes;
            this.mark = mar;
            this.Title = "diciplinary card - " + this.message;
        }
        public void calmDown()
        {
            Console.WriteLine("diciplinary card: message - {0}, mark - {1}", this.message, this.mark.ToString());
        }
        public void Draw()
        {
            this.calmDown();
        }
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }
    }
    public class DiciplinaryToCard : ICard     //Adapter
    {
        DiciplinaryCard diccard;
        public DiciplinaryToCard(DiciplinaryCard dc)
        {
            this.diccard = dc;
        }
        public DiciplinaryToCard(string m, int ma)
        {
            this.diccard = new DiciplinaryCard(m, ma);
        }
        public void putCard()
        {
            this.diccard.calmDown();
        }
        public ICard Clone()
        {
            return new DiciplinaryToCard(diccard.message, diccard.mark);
        }
    }
}
