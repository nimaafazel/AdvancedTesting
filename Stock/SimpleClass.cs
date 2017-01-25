using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    /// <summary>
    /// This class will use a method that changes everytime, so we can use Shimsm to test it.
    /// </summary>
    public class SimpleClass
    {
        /// <summary>
        /// This method wil vary depending on time, so we will use a Shim to test it on a fixed date without having to make a special class for it.
        /// </summary>
        /// <returns></returns>
        public int getCurrentYear()
        {
            return DateTime.Now.Year;  // on the tests, this method will always return Jan 1st 2000
        }
    }
}
