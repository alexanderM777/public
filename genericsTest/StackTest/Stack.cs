using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
    public class Stack<T>
    {
        private int top ; //lugar del eemento MAS ALTO
        private T[] elements; // elementos que se almacenaran


        // parametro construtor que crea una pila de tamaño por defecto

        public Stack() : this(10)
        {
            //consttructor vacio, llama al constructor inicializado en la linea 22
        }
        //constructor que crea una pila con especifico numeros de elementos
        public Stack(int Stacksize)
        {
            if(Stacksize == 0)
            {
                throw new ArgumentOutOfRangeException("stack size must be positvo");
            }
            elements = new T[Stacksize];
            top = -1;
        }
        ////psuh/empuja la pila, si unsucessful
        /////throw/ lanza FallStackException
        ///
        public void Push(T pushValue)
        {
            if(top == elements.Length-1)
            {
                throw new FallStackException(
                    $"Stack esta lleno, no puede empujarse{pushValue}");
            }
            top++;
            
        }
        //retorna si no esta vacia
        //lanza/throw una nueva excepsion EmpTyStackException
        public T Pop()
        {
            if(top == -1)// esta vacio
            {
                throw new EmpTyStackException(
                    $"Stack esta vacio, can´t pop");
            }
            --top;
            return elements[top + 1];
        }
    }

    }
