using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{    
    /// <summary>
    /// This is the actual production class.
    /// Will be recieving an interface that a different class will implement. Dependency Injection.
    /// </summary>
    public class StockAnalyzer
    {
        private IStockFeed stockFeed;  // private interface property to implement the stock feed methods.

        /// <summary>
        /// Public constructor that receives the IMPLEMENTATION of an interface. Dependency Injection.
        /// </summary>
        /// <param name="feed"></param>
        public StockAnalyzer(IStockFeed feed)
        {
            stockFeed = feed;
        }

        /// <summary>
        /// Public method to get this particular stock price.
        /// </summary>
        /// <returns>The Contoso stock price.</returns>
        public int getContosoPrice()
        {
            return stockFeed.getSharePrice("COOO");
        }        
    }
}
