using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AppDocumentada
{
    internal class Utilities
    {
        /// <summary>
        /// This a common function which reads an integer from console.
        /// </summary>
        /// <param name="message">
        ///  An input message which tells the user what kind of number this function is asking for.
        ///  </param>
        /// <returns>
        /// Returns either the integer given by the user or an exception.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// This exception is thrown when giving a not-integer value.
        /// </exception>
        public static int GetIntegerFromConsole(string message)
        {
            Console.Write($"{message}: ");
            return int.TryParse(Console.ReadLine(), out int res) ? res :
                throw new ArgumentException("The input was not an integer!");
        }
    }
}
