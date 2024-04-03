using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Generics
{
    internal class BoxEnumerator: IEnumerator<Box>
    {
        private BoxCollection _box;
        private int currentBoxIndex;
        private Box currentBox;



        public BoxEnumerator(BoxCollection box)
        {
            this._box = box;
            currentBoxIndex = -1;
            currentBox = default(Box);
        }

        public Box Current { get { return currentBox; } }

        object IEnumerator.Current { get { return Current; } }

        public int count
        {
            get { return _box.Count; }
        }

        public bool MoveNext()
        {
            if (++currentBoxIndex >= _box.Count)
            {
                return false;
            }
            else
            {
                currentBox = _box[currentBoxIndex];
            }
            return true;
        }

        void IEnumerator.Reset()
        {
            currentBoxIndex = -1;
        }

        public void Dispose()
        {

        }
    }
}
