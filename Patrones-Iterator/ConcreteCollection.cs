using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Iterator
{
    class ConcreteCollection : Collection
    {
        private List<Item> items = new List<Item>();
        private Item item;
        private int posicion;


        public override void Agregar(Item item)
        {
            items.Add(item);
        }

        public override int Count()
        {
            return items.Count;
        }

        public override IteratorEjemplo CrearIterator()
        {
            IteratorEjemplo iterator = new IteratorConcreto(this);
            return iterator;
        }

        public override Item Index(int index)
        {
            item = items[index];
            posicion = index;
            return item;
        }

        public override int Posicion()
        {
            return posicion;
        }
    }
}
