using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace Fabrefactum
{
	/// <summary>
	/// Volume Weighted Average Price
	/// </summary>
	public class VWAP
	{
		private static EntityQuote _timeSeries;
		private static int _length = 1;

		private VWAP()
		{
            
		}
        
		/// <summary>
		/// Calculate VWAP for a timeseries
		/// </summary>
		/// <param name="outputColumn"></param>
		/// <param name="volumeColumn"></param>
		public static EntityQuote Calculate(EntityQuote timeSeries, int length, int calcColumn, int outputColumn, int volumeColumn)
		{
			_length = length;
			_timeSeries = timeSeries;
			for (int i = 0; i < timeSeries.Count; i++)
			{
				((object[])timeSeries[i])[outputColumn] = Value(i, calcColumn, volumeColumn);
			}
			return timeSeries;
		}

		/// <summary>
		/// Calculate VWAP for each value in the timeseries
		/// </summary>
		/// <param name="outputColumn"></param>
		/// <param name="volumeColumn"></param>
		/// <returns></returns>
		private static double Value(int index, int calcColumn, int volumeColumn)
		{
			if (index < _length - 1)
			{
				return double.NaN;
			}
			double d1 = 0.0;
			double d2 = 0.0;
			for (int i = index; i >= index - _length + 1; i--)
			{
				object[] series = (object[])_timeSeries[i];

				d1 += (double)series[calcColumn] * (double)series[volumeColumn];
				d2 += (double)series[volumeColumn];
			}
			d1 /= d2;
			return d1;
		}

	}
}
