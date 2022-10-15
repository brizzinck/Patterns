using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class StackIterator
    {
        private DataStack _stack;
        private int _index;

        public StackIterator(DataStack myStack)
        {
            this._stack = myStack;
            this._index = 0;
        }
        public static StackIterator operator ++(StackIterator s)
        {
            s._index++;
            return s;
        }
        public int Get()
        {
            if (_index < _stack.Length)
                return _stack.Items[_index];
            return 0;
        }
        public bool IsEnd() => _index != _stack.Length + 1;
    }
}
