using System;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;

namespace Fabrefactum
{

    /// <summary>
    /// A datetime-ordinated time series
    /// </summary>
    [SerializableAttribute()]
    public class EntityQuote<TKey,TValue>: IEnumerable<TValue>
    {
        private class EntityQuoteEnumerator<TValue>: IEnumerator<TValue>, IEnumerator
        {
            private EntityQuote<TKey,TValue> fArray;

            private int fIndex;

            object IEnumerator.Current
            {
                get
                { 
                    
                    return fArray[fIndex];
                }
            }

            public EntityQuoteEnumerator(EntityQuote<TKey,TValue> Array)
            {
                fArray = Array;
                fIndex = -1;
            }

            bool IEnumerator.MoveNext()
            {
                fIndex++;
                if (fIndex >= fArray.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            void IEnumerator.Reset()
            {
                fIndex = -1;
            }

            TValue IEnumerator<TValue>.Current
            {
                get { return fArray[fIndex]; }
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

        protected internal SortedList<TKey, TValue> fArray = new SortedList<TKey, TValue>();

        protected string fName;

    
        protected bool fChanged = false;

        [DescriptionAttribute("")]
        [CategoryAttribute("Description")]
        public string Name
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }

     

        [BrowsableAttribute(false)]
        public virtual int Count
        {
            get
            {
                return fArray.Count;
            }
        }

        [BrowsableAttribute(false)]
        public virtual TKey FirstDateTime
        {
            get
            {
                if (Count <= 0)
                {
                    throw new ApplicationException("Array has no elements");
                }
                else
                {
                    return GetKey(0);
                }
            }
        }

        [BrowsableAttribute(false)]
        public virtual TKey LastKey
        {
            get
            {
                if (Count <= 0)
                {
                    throw new ApplicationException("Array has no elements");
                }
                else
                {
                    return GetKey(Count - 1);
                }
            }
        }

        [BrowsableAttribute(false)]
        public virtual int FirstIndex
        {
            get
            {
                return 0;
            }
        }

        [BrowsableAttribute(false)]
        public virtual int LastIndex
        {
            get
            {
                return Count - 1;
            }
        }

        [BrowsableAttribute(false)]
        public virtual int RealCount
        {
            get
            {
                return Count;
            }
        }

        public virtual TValue this [int Index]
        {
            get
            {
                return fArray[fArray.Keys[Index]];
            }
        }

        public TValue this [TKey key]
        {
            get
            {
                 return fArray[key];
            }

            set
            {
                Add(key, value);
            }
        }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public EntityQuote()
        {
        }

        /// <summary>
        /// Constructor with Name and Title
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Title"></param>
        public EntityQuote(string Name)
        {
            fName = Name;
            
        }

        public EntityQuote(string Name)
        {
            fName = Name;
        }

        public virtual EntityQuote<TKey,TValue> Clone()
        {
            return Clone(0, Count - 1);
        }

        /// <summary>
        /// Clones a TimeSeries
        /// </summary>
        /// <param name="Index1"></param>
        /// <param name="Index2"></param>
        /// <returns></returns>
        public virtual EntityQuote<TKey,TValue> Clone(int Index1, int Index2)
        {

            EntityQuote<TKey,TValue> timeSeries = new EntityQuote<TKey,TValue>(fName,fTitle);
            if (Count == 0)
            {
                return timeSeries;
            }
            for (int i = Index1; i <= Index2; i++)
            {
                timeSeries.Add(GetKey(i), this[i]);
            }
            return timeSeries;
        }

        /// <summary>
        /// Clears the entire TimeSeries of data
        /// </summary>
        public virtual void Clear()
        {
            fArray.Clear();
            fChanged = true;
        }

        public bool Contains(TKey key)
        {
            return fArray.ContainsKey(key);
        }

        public bool Contains(int Index)
        {
            if (Index < 0 || Index > Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Add an element using a date as an index
        /// </summary>
        /// <param name="DateTime"></param>
        /// <param name="Object"></param>
        public void Add(TKey key, TValue value)
        {
            
            fArray[key] = value;
            fChanged = true;
        }

        /// <summary>
        /// Remove an element using a data as index
        /// </summary>
        /// <param name="DateTime"></param>
        public virtual void Remove(TKey key)
        {
            fArray.Remove(key);
            fChanged = true;
        }

        public virtual void Remove(int Index)
        {
            fArray.RemoveAt(Index);
            fChanged = true;
        }

        /// <summary>
        /// Gets the date time of a particular index
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public virtual TKey GetKey(int Index)
        {
            return fArray.Keys[Index];
        }

            /// <summary>
        /// Finds an object and returns its index
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public virtual int GetIndex(TValue value)
        {
            return fArray.IndexOfValue(value);
        }
         public virtual int GetIndex(TKey key)
        {
            return fArray.IndexOfKey(key);
        }
        public virtual void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(String.Concat(GetKey(i), " ", this[i]));
            }
        }

    
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new EntityQuoteEnumerator<TValue>(this);
        }

        IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
        {
            return new EntityQuoteEnumerator<TValue>(this);
        }
    }

}

