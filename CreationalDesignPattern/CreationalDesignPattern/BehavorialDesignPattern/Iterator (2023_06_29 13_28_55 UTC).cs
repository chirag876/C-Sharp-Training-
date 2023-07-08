using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavorialDesignPattern
{
    public interface Iterator
    {
        string FirstItem();
        string NextItem();
        bool Done();
        string CurrentItem();
    }

    public class ConcreteIterator : Iterator
    {
        ConcreteAggregate _aggregate;
        int _currentItemIndex = 0;

        public ConcreteIterator(ConcreteAggregate C_aggregate)
        {
            this._aggregate = C_aggregate;
        }

        public string FirstItem()
        {
            return _aggregate[0];
        }

        public string NextItem()
        {
            string return_obj = null;
            if (_currentItemIndex < _aggregate.Count - 1)
            {
                return_obj = _aggregate[++_currentItemIndex];
            }
            return return_obj;
        }

        public string CurrentItem()
        {
            return _aggregate[_currentItemIndex];
        }

        public bool Done()
        {
            return _currentItemIndex >= _aggregate.Count;
        }
    }

    public interface Aggregate
    {
        Iterator Create();
    }

    public class ConcreteAggregate : Aggregate
    {
        List<string> _items = new List<string>();
        public Iterator Create()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public string this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
