using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialEngineering.IndexCalculation
{
    public struct BOLL 
    {
    private double mb;    
	public double MB
	{
        get { return mb; }
	}
    private double up;
    public double UP
    {
        get { return up ; }
      
    }
    
    private double lamda;

    private double dn;
    public double DN
    {
        get { return dn; }
      
    }
   
    public BOLL(MA ma,double lamda)
    {
        var sd = new SD(ma);
        this.lamda = lamda;
        this.mb = ma.Value;
        this.up = this.mb + lamda * sd.Value;
        this.dn = this.mb - lamda *  sd.Value;

    }
    }
}
