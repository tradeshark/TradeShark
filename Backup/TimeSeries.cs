using System;
using System.Collections;
using System.ComponentModel;

namespace Fabrefactum
{

	/// <summary>
	/// A datetime-ordinated time series
	/// </summary>
	[SerializableAttribute()]
	public class TimeSeries: IEnumerable
	{
		private class TimeSeriesEnumerator: IEnumerator
		{
			private TimeSeries fArray;

			private int fIndex;

			object IEnumerator.Current
			{
				get
				{ 
					return fArray[fIndex];
				}
			}

			public TimeSeriesEnumerator(TimeSeries Array)
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
		}

		protected internal SortedList fArray = new SortedList();

		protected string fName;

		protected string fTitle;

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

		[DescriptionAttribute("")]
		[CategoryAttribute("Description")]
		public string Title
		{
			get
			{
				return fTitle;
			}

			set
			{
				fTitle = value;
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
		public virtual DateTime FirstDateTime
		{
			get
			{
				if (Count <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				else
				{
					return GetDateTime(0);
				}
			}
		}

		[BrowsableAttribute(false)]
		public virtual DateTime LastDateTime
		{
			get
			{
				if (Count <= 0)
				{
					throw new ApplicationException("Array has no elements");
				}
				else
				{
					return GetDateTime(Count - 1);
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

		public virtual object this [int Index]
		{
			get
			{
				return fArray.GetByIndex(Index);
			}
		}

		public virtual double this [int Index, int Row]
		{
			get
			{
				return (double)fArray.GetByIndex(Index);
			}
					
		}
 
		public object this [DateTime DateTime]
		{
			get
			{
					int i = GetIndex(DateTime);
				if (i != -1)
				{
					return fArray.GetByIndex(i);}
				else
				{
					return null;
				}
			}

			set
			{
				Add(DateTime, value);
			}
		}

		/// <summary>
		/// Empty Constructor
		/// </summary>
		public TimeSeries()
		{
		}

		/// <summary>
		/// Constructor with Name and Title
		/// </summary>
		/// <param name="Name"></param>
		/// <param name="Title"></param>
		public TimeSeries(string Name, string Title)
		{
			fName = Name;
			fTitle = Title;
		}

		public TimeSeries(string Name)
		{
			fName = Name;
		}

		public virtual TimeSeries Clone()
		{
			return Clone(0, Count - 1);
		}

		/// <summary>
		/// Clones a TimeSeries
		/// </summary>
		/// <param name="Index1"></param>
		/// <param name="Index2"></param>
		/// <returns></returns>
		public virtual TimeSeries Clone(int Index1, int Index2)
		{

			TimeSeries timeSeries = new TimeSeries(fName,fTitle);
			if (Count == 0)
			{
				return timeSeries;
			}
			for (int i = Index1; i <= Index2; i++)
			{
				timeSeries.Add(GetDateTime(i), this[i]);
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

		public bool Contains(DateTime DateTime)
		{
			return fArray.Contains(DateTime);
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
		public void Add(DateTime DateTime, object Object)
		{
			fArray[DateTime] = Object;
			fChanged = true;
		}

		/// <summary>
		/// Remove an element using a data as index
		/// </summary>
		/// <param name="DateTime"></param>
		public virtual void Remove(DateTime DateTime)
		{
			fArray.Remove(DateTime);
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
		public virtual DateTime GetDateTime(int Index)
		{
			return (System.DateTime)fArray.GetKey(Index);
		}

			/// <summary>
		/// Finds an object and returns its index
		/// </summary>
		/// <param name="Item"></param>
		/// <returns></returns>
		public virtual int GetIndex(object Item)
		{
			return fArray.IndexOfValue(Item);
		}

		public virtual void Print()
		{
			for (int i = 0; i < Count; i++)
			{
				Console.WriteLine(String.Concat(GetDateTime(i), " ", this[i]));
			}
		}

	
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TimeSeriesEnumerator(this);
		}
	}

}

