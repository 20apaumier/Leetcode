using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.LinkedLists
{
    public class LRUCache
    {
        private int _capacity;
        private Dictionary<int, LinkedListNode<KV>> _cacheMap;
        private LinkedList<KV> _cacheList;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _cacheMap = new Dictionary<int, LinkedListNode<KV>>(capacity);
            _cacheList = new LinkedList<KV>();
        }

        public int Get(int key)
        {
            // if the key exists, return it
            if (_cacheMap.TryGetValue(key, out var node))
            {
                // rearrange the cacheList so the val is at the front
                // since it was just used
                _cacheList.Remove(node);
                _cacheList.AddFirst(node);

                // return the key's value
                return node.Value.Value;
            }
            else
            {
                // if key does not exist, return -1
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            // if the key exists, update it's value
            if (_cacheMap.TryGetValue(key, out var node))
            {
                // update the value
                node.Value.Value = value;

                // update the list so it is at the front
                _cacheList.Remove(node);
                _cacheList.AddFirst(node);
            }
            else
            {
                // if we are over capacity
                if (_cacheMap.Count >= _capacity)
                {
                    // get the last node and remove it from
                    // dictionary and linked list
                    var lastNode = _cacheList.Last;
                    _cacheMap.Remove(lastNode.Value.Key);
                    _cacheList.RemoveLast();
                }

                // init the node we need to add
                // then add to dictionary and front of linked list
                var newNode = new LinkedListNode<KV>(new KV(key, value));
                _cacheMap.Add(key, newNode);
                _cacheList.AddFirst(newNode);
            }

        }

        private class KV
        {
            // key value class so that we can actually set the value
            public int Key { get; }
            public int Value { get; set; }

            public KV(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }
    }
}
