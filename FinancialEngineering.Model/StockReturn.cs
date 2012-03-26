using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialEngineering.Model
{
    public  class StockReturn 
    {
  
        public static StockReturn CreateStockReturn(global::System.String secuCode, global::System.String secuAbbr, global::System.Int32 innerCode, global::System.Double value)
        {
            StockReturn stockReturn = new StockReturn();
            stockReturn.SecuCode = secuCode;
            stockReturn.SecuAbbr = secuAbbr;
            stockReturn.InnerCode = innerCode;
            stockReturn.Value = value;
            return stockReturn;
        }

   
        public global::System.String SecuCode
        {
          get;set;
        }
    
     
    
        public global::System.String SecuAbbr
        {
           get;set;
        }
      

        public global::System.Int32 InnerCode
        {
           get;set;
        }
      
      
        public global::System.Double Value
        {
          get;set;
        }
      

    }
}
