using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    /// <summary>
    /// Has all the methods to the stock market feed.
    /// This interface will be implemented by the StockFeed (real production class) and the StubStockFeed (for testing purpouses) classes
    /// </summary>    
    public interface IStockFeed
    {
        /// <summary>
        /// Gets the price of a specific stock in that moment.
        /// </summary>
        /// <param name="stockName">The stock name.</param>
        /// <returns>The price.</returns>
        int getSharePrice(string stockName);
    }
}
