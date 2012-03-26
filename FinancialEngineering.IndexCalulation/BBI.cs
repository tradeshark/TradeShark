using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialEngineering.IndexCalculation
{
    public struct BBI 
    {
        
        private int n1;
        private int n2;
        private int n3;
        private int n4;
        private MA n1MovingAverage;
        private MA n2MovingAverage;
        private MA n3MovingAverage;
        private MA n4MovingAverage;
        ///                 MA(n1)+ MA(n2) +MA(n3)+ MA(n4)     
        ///       BBI =   ----------------------------------
        ///                                     4
        public BBI(int n1,int n2,int n3, int n4)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
            this.n4 = n4;
            this.n1MovingAverage = new MA(n1);
            this.n2MovingAverage = new MA(n2);
            this.n3MovingAverage = new MA(n3);
            this.n4MovingAverage = new MA(n4);
        }
     

public  double Value
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
