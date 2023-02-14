using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BigInteger
{
    private int v;
    private long v1;
    private ulong v2;

    public BigInteger(int v)
    {
        this.v = v;
    }

    public BigInteger(long v1)
    {
        this.v1 = v1;
    }

    public BigInteger(ulong v2)
    {
        this.v2 = v2;
    }

    public static implicit operator BigInteger(int v)
    {
        throw new NotImplementedException();
    }
}
