using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class DataStack
    {
        private int[] _items = new int[10];
        private int _length;
        public DataStack() => _length = -1;
        public DataStack(DataStack myStack)
        {
            this._items = myStack._items;
            this._length = myStack._length;
        }
        public int[] Items { get => _items; }
        public int Length { get => _length; }

        public void Push(int value) => Items[++_length] = value;
        public int Pop() => Items[_length--];

        public static bool operator == (DataStack myStack1, DataStack myStack2)
        {
            StackIterator iterator1 = new StackIterator(myStack1),
                          iterator2 = new StackIterator(myStack2);
            while (iterator1.IsEnd() || iterator2.IsEnd())
            {
                if (iterator1.Get() != iterator2.Get()) break;
                iterator1++;
                iterator2++;
            }
            return !iterator1.IsEnd() && !iterator2.IsEnd();
        }
        public static bool operator !=(DataStack myStack1, DataStack myStack2)
        {
            StackIterator iterator1 = new StackIterator(myStack1),
                          iterator2 = new StackIterator(myStack2);
            while (iterator1.IsEnd() || iterator2.IsEnd())
            {
                if (iterator1.Get() != iterator2.Get()) break;
                iterator1++;
                iterator2++;
            }
            return !(!iterator1.IsEnd() && !iterator2.IsEnd());
        }
    }
}
