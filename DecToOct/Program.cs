using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToOct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const uint MAX_INT = uint.MaxValue;
            Console.WriteLine("Input an unsigned integer number");
            var bIsRightNumber = (uint.TryParse(Console.ReadLine(), out var uNumber)) &&
                                 (uNumber <= MAX_INT);
            if (!bIsRightNumber)
            {
                Console.WriteLine("Invalid number format or number too big");
                Console.Read();
                return;
            }
            var strOctNum = "";
            var uTempVal = uNumber;
            while (uTempVal > 0)
            {
                strOctNum = (uTempVal % 8) + strOctNum;
                uTempVal /= 8;
            }
            if (strOctNum.Length == 0)
                strOctNum = "0";
            Console.WriteLine
            (
                "The octal equivalent of the decimal number {0} is: {1}",
                uNumber, strOctNum
            );
            Console.Read();
        }
    }
}
