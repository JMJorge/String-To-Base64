using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes

                = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);

            string returnValue

                = System.Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;
        }

        static public string DecodeFrom64(string encodedData)
        {
            byte[] encodedDataAsBytes

                = System.Convert.FromBase64String(encodedData);

            string returnValue

                = System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);

            return returnValue;
        }

        static void Main(string[] args)
        {
            Console.Write("Write here: ");
            string myData = Console.ReadLine();

            string myDataEncoded = EncodeTo64(myData);
            Console.WriteLine("EncodeTo64: " + myDataEncoded);

            string myDataUnencoded = DecodeFrom64(myDataEncoded);
            Console.WriteLine("DecodeFrom64: " + myDataUnencoded);


            Console.ReadLine(); 
        }
    }
}
