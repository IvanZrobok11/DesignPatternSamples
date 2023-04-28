using System.Collections;

namespace BehavioralPatterns
{
    public class Iterator : IEnumerator
    {
        private Aggregate _aggregate;
        private int _currentIndex;
        public Iterator(Aggregate aggregate)
        {
            _aggregate = aggregate;
            _currentIndex = 0;
        }
        public object Current => _aggregate.ByIndex(_currentIndex);

        public bool MoveNext()
        {
            _currentIndex++;
            return _aggregate.Count > _currentIndex;
        }

        public void Reset()
        {
            _currentIndex = 0;
        }
    }

    public class Aggregate : IEnumerable
    {
        private object[] _items;
        public int Count => _items.Length;
        public Aggregate(params object[] items)
        {
            _items = items;
        }
        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }
        public object ByIndex(int index)
        {
            return _items[index];
        }
    }
    public class PIter
    {
        public void Main()
        {
            var aggregate = new Aggregate(1, "2", 3, "456");

            var iterator = aggregate.GetEnumerator();

            while (iterator.MoveNext())
            {
                var c = iterator.Current;
                Console.WriteLine(c);
            }
        }
    }
}
