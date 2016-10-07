using System;
using System.Collections.Generic;

namespace Cache.Lru
{    
    public class LruCache<K, V>
    {
        private readonly IDictionary<K, V> _valueDictionary;
        private readonly LinkedList<K> _timeList;

        public LruCache()
        {
          _valueDictionary = new Dictionary<K, V>();
          _timeList = new LinkedList<K>();
        }

        

    }
}