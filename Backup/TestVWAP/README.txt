All files in this Solution Copyright (C) 2006 Andrew Peters and Fabrefactum Software LLC
This code is for educational purposes only.  Commercial use is prohibited except with author's permission

Contact the Author:
Andrew Peters
apeters@fabrefactum.com
www.fabrefactum.com

Build/Installation Notes:

The TestVWAP project uses StockChartX, a 3rd party COM component.  Unless you have purchased a 
license for its use and it is registered on your machine, you will not be able to build or run
this project.  You may run the compiled executable, provided you register the StockChartX.ocx component.
For most users, this test code is useful as example only.  

The tester reads in a comma-delimited text file in the following format:
Date, Time, Open, High, Low, Close, Volume
It is hard-coded for this column order.  Any custom column orders have to be changed in the code.
It would be very straightforward to pull out the column manipulation code into its own class to make it more
flexible.

VWAP is primarily used by institutional traders.  Make broker dealers offer VWAP orders so that a basket of orders' 
fill price will average out to the VWAP.  This places risk on the broker dealer, so there are often higher spreads
or fees for this type of order, or are only offered to high-volume traders.  VWAP orders balance time versus impace and
often traders will use VWAP orders to send a packet of a few hundred shares every few seconds over the course of an entire day.

While many electronic broker dealers now offer VWAP orders, it is often difficult for traders to calculate VWAP realtime.  This simple
VWAP class automates the calculation for a time series.

Before calculating volume weighted average price for a time series, we first need to construct a TimeSeries class that holds our data.

