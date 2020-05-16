using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    //Memento
    public class CardMemento
    {
        public STATE state;
        public CardMemento(STATE st)
        {
            this.state = st;
        }
    }
    // Caretaker
    public class CardHistory
    {
        public Stack<CardMemento> History { get; private set; }
        public CardHistory()
        {
            History = new Stack<CardMemento>();
        }
        public void Save(CardMemento mem)
        {
            this.History.Push(mem);
        }
    }
}
