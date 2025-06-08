using System;
using System.Collections.Generic;
using System.IO;
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



            // string plainText = "AES_Encrypt"

            var res5 = AES_Encrypt("Hello World"); // AES Encription
            Console.WriteLine(res5);

            Console.WriteLine();

            var res6 = AES_Decrypt(res5); // AES Decription
            Console.WriteLine(res6); // Hello World 



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

        static string AES_Encrypt(string PlainText)
        {
            string encKey = "Myanmar";

            byte [] plainByte = Encoding.UTF8.GetBytes(PlainText);

            using ( Aes enc = Aes.Create() )
            {
                var salt = new byte [] { 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7, 0x8 };

                Rfc2898DeriveBytes rdb = new Rfc2898DeriveBytes(encKey, salt);

                enc.Key = rdb.GetBytes(32); // 256 bit key
                enc.IV = rdb.GetBytes(16); // 128 bit IV


                using ( MemoryStream ms = new MemoryStream() )
                {
                    using ( CryptoStream cs = new CryptoStream(ms, enc.CreateEncryptor(), CryptoStreamMode.Write) )
                    {
                        cs.Write(plainByte, 0, plainByte.Length);
                        cs.Close();
                    }

                    PlainText = Convert.ToBase64String(ms.ToArray());
                }
            }

            return PlainText;


        }

        static string AES_Decrypt(string PlainText)
        {
            string encKey = "Myanmar";
            PlainText = PlainText.Replace(" ", "+"); // Handle spaces in base64 string

            byte [] plainByte = Convert.FromBase64String(PlainText);

            using ( Aes enc = Aes.Create() )
            {
                var salt = new byte [] { 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7, 0x8 };

                Rfc2898DeriveBytes rdb = new Rfc2898DeriveBytes(encKey, salt);

                enc.Key = rdb.GetBytes(32); // 256 bit key
                enc.IV = rdb.GetBytes(16); // 128 bit IV


                using ( MemoryStream ms = new MemoryStream() )
                {
                    using ( CryptoStream cs = new CryptoStream(ms, enc.CreateDecryptor(), CryptoStreamMode.Write) )
                    {
                        cs.Write(plainByte, 0, plainByte.Length);
                        cs.Close();
                    }

                    PlainText = Encoding.UTF8.GetString(ms.ToArray());
                }
            }

            return PlainText;


        }

    }
}
