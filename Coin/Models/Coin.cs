using System;
using System.Collections.Generic;

namespace Coin.Models
{
    public class Change
    {
        public static int[] ChangeConverter(int total, int payment)
        {
            string[] coins = {"quarter", "dime", "nickle", "penny"};
            int[] coinQty = {0, 0, 0, 0};
            int change = payment - total;

            if (change >= 25)
            {
                coinQty[0] = change/25;
                
            }
            else if(change >= 10)
            {
                coinQty[1] = change/10;
            }
                
            else if(change >= 5)
            {
                coinQty[2] = change/5;
                
            }
            else if(change >= 1)
            {
             coinQty[3] = change/1;
             
            }
            return coinQty;
        }
    }
  
}