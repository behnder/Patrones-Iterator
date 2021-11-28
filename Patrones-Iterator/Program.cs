using System;

namespace Patrones_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {

            ConcreteCollection coleccion = new ConcreteCollection();
            coleccion.Agregar(new Item("cuchara"));
            coleccion.Agregar(new Item("tenedor"));
            coleccion.Agregar(new Item("cuchillo"));

            IteratorConcreto iterator = new IteratorConcreto(coleccion);
            iterator.First();
            Item i = iterator.CurrentItem();

            Console.WriteLine(i.ToString());

            while (!iterator.IsDone())
            {
                iterator.Next();
                i = iterator.CurrentItem();
                Console.WriteLine(i.ToString());

            }

        }
    }
}
