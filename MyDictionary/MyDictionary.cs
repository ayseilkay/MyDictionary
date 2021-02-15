using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<TKey,TValue>
    {
        List<TKey> _keys;
        List<TValue> _values;
        public MyDictionary()
        {
            _keys = new List<TKey>();
            _values = new List<TValue>();
        }
        public void Add(TKey key,TValue value)
        {
            _keys.Add(key);
            _values.Add(value);
           
        }
        public void Key(TKey key)
        {
            try
            {
                Console.WriteLine(_values[_keys.IndexOf(key)]);

            }
            catch
            {
                Console.WriteLine("key mevcut değil");

            }
        }
    }
}
