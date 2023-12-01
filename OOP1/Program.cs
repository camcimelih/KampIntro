using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempKeys = keys;
            Tvalue[]tempValues = values;

            keys = new Tkey[tempKeys.Length+1];
            values = new Tvalue[tempKeys.Length+1];
            for (int i = 0; i < tempKeys.Length; i++) 
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[tempKeys.Length + 1] = key;
            values[tempKeys.Length + 1] = value;
        }
    }

}
