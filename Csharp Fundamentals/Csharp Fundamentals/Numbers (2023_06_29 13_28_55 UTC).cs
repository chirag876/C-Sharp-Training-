using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Numbers

    {
    public void numberfunc()
    {
        byte b1 = 255;
        //byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
        sbyte sb1 = -128;
        sbyte sb2 = 127;

        Console.WriteLine(Byte.MaxValue);//255
        Console.WriteLine(Byte.MinValue);//0
        Console.WriteLine(SByte.MaxValue);//127
        Console.WriteLine(SByte.MinValue);//-128

        short s1 = -32768;
        short s2 = 32767;
        //short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

        ushort us1 = 65535;
        //ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

        Console.WriteLine(Int16.MaxValue);//32767
        Console.WriteLine(Int16.MinValue);//-32768
        Console.WriteLine(UInt16.MaxValue);//65535
        Console.WriteLine(UInt16.MinValue);//0

        int i = -2147483648;
        int j = 2147483647;
        //int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

        uint ui1 = 4294967295;
        //uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

        Console.WriteLine(Int32.MaxValue);//2147483647
        Console.WriteLine(Int32.MinValue);//-2147483648
        Console.WriteLine(UInt32.MaxValue);//4294967295
        Console.WriteLine(UInt32.MinValue);//0

        long l1 = -9223372036854775808;
        long l2 = 9223372036854775807;

        ulong ul1 = 18223372036854775808ul;
        ulong ul2 = 18223372036854775808UL;

        Console.WriteLine(Int64.MaxValue);//9223372036854775807
        Console.WriteLine(Int64.MinValue);//-9223372036854775808
        Console.WriteLine(UInt64.MaxValue);//18446744073709551615
        Console.WriteLine(UInt64.MinValue);//0


        float f1 = 123456.5F;
        float f2 = 1.123456f;

        Console.WriteLine(f1);//123456.5
        Console.WriteLine(f2);//1.123456

        double d1 = 12345678912345.5d;
        double d2 = 1.123456789123456d;

        Console.WriteLine(d1);//12345678912345.5
        Console.WriteLine(d2);//1.123456789123456

        //decimal de1 = 123V3fbvD4Vg.5m;
        decimal de2 = 1.1234567891345679123456789123m;

        Console.WriteLine(d1);
        Console.WriteLine(d2);

    }
}
