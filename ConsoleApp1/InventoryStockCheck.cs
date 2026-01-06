using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class InventoryStockCheck
    {
        public (int outOfStock, int lowStockItems) LoopCalculation(int[] stocks)
        {
            int outOfStock = 0;
            int lowStockItems = 0;

            for (int i=0; i< stocks.Length; i++)
            {
                if (stocks[i] < 10) {
                    lowStockItems++;
                }
                if (stocks[i] == 0)
                {
                    outOfStock++;
                }
            }

            return (outOfStock, lowStockItems);
        }

        public int CalculateOutOfStockItems(int[] stocks)
        {
            var result = LoopCalculation(stocks);
            return result.outOfStock;
        }

        public int CalculateLowStockItems(int[] stocks)
        {
            var result = LoopCalculation(stocks);
            return result.lowStockItems;
        }

        public int AddNewItem(int index, int quantity, int[] stocks) {
            return stocks[index] + quantity;
        }
    }
}
