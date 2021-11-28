using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Iterator
{
    class IteratorConcreto : IteratorEjemplo
    {
        private Collection collection;
        private Item item;

        public IteratorConcreto(Collection collection)
        {
            this.collection = collection;
        }

        public override Item CurrentItem()
        {
            return item;
        }

        public override void First()
        {
            item = collection.Index(0);
        
        }

        public override bool IsDone()
        {
            if (collection.Count() == collection.Posicion() +1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public override void Next()
        {
            item = collection.Index(collection.Posicion() + 1);

        }
    }
}
