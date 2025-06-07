using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Day18
{
    public class Program
    {
        static void Main(string [] args)
        {
            //var res = Method1("Hello World");

            //foreach(var res1 in res)
            //{
            //    Console.Write(res1);
            //}

            //Console.WriteLine();


            //var res2 = Encoding.UTF8.GetString(Method2(res));
            //Console.WriteLine(res2);


            //var res3 = WDPE("Hello World"); // WDP + SALT
            //foreach ( var wdpe1 in res3 )
            //{
            //    Console.Write(wdpe1);
            //}
            //Console.WriteLine();


            //string ress4 = Encoding.UTF8.GetString(WDPED(res3));
            //Console.WriteLine(ress4);

        }



        //static byte [] Method1 (string csm1)
        // {
        //     byte [] csmbyte = Encoding.UTF8.GetBytes(csm1);
        //     return ProtectedData.Protect(csmbyte, null, DataProtectionScope.CurrentUser);
        // }


        // static byte [] Method2(byte [] csmbyte)
        // {
        //     return ProtectedData.Unprotect(csmbyte, null, DataProtectionScope.CurrentUser);
        // }

        //static byte [] WDPE(string pt1)  // WDP + SALT (Encription)
        //{
        //    byte [] pt1byte = Encoding.UTF8.GetBytes(pt1);

        //    var salt = new byte [] { 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7, 0x8 };
        //    return ProtectedData.Protect(pt1byte, salt, DataProtectionScope.CurrentUser);
        //}

        //static byte [] WDPED(byte [] pt1byte) // WDP + SALT (Decription)
        //{
        //    var salt = new byte [] { 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7, 0x8 };
        //    return ProtectedData.Unprotect(pt1byte, salt, DataProtectionScope.CurrentUser);
        //}



    }
}
