using System;

namespace NullableReferenceType
{
    class Program
    {
        #nullable enable
        static void Main(string[] args)
        {
            string strValue = "null";
            strValue = null;
            Console.WriteLine("value:"+strValue);

        }
    }
}
