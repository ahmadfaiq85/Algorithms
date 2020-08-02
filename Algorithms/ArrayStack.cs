﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    public class ArrayStack<T> : IEnumerable<T>
    {
        private T[] _items;

        public ArrayStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public ArrayStack(int capacity)
        {
            _items = new T[capacity];
        }

        public T Peak()
        {
            return _items[Count - 1];
        }
        public void Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            _items[--Count] = default(T);
        }

        public void Push(T item)
        {
            if (_items.Length == Count)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_items, largerArray, Count);

                _items = largerArray;
            }

            _items[Count] = item;
            Count++;
        }

        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}