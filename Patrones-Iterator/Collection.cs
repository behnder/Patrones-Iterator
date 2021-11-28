using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Iterator
{
    public abstract class Collection
    {

        public abstract  IteratorEjemplo CrearIterator();
        public abstract void Agregar(Item item);
        public abstract Item Index(int index);
        public abstract int Count();
        public abstract int Posicion();
           

    }
}
