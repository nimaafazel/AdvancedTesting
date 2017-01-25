using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    /// <summary>
    /// This is the real production class that will implement the IStockFeed interface.
    /// </summary>
    public class StockFeed : IStockFeed
    {
        /// <summary>
        /// Interface method.        
        /// </summary>
        /// <param name="stockName"></param>
        /// <returns></returns>
        public int getSharePrice(string stockName)
        {
            /// here goes the logic of this implementation.
            /// for example fetch the data
            /// compare with the stcok name
            /// query the price in that moment
            /// and finally return the price.
            throw new NotImplementedException(); // we are throwing this exception because we havent implemented the method yet.
        }
    }
}
