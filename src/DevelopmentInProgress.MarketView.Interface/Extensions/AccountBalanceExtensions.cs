﻿using DevelopmentInProgress.MarketView.Interface.Model;

namespace DevelopmentInProgress.MarketView.Interface.Extensions
{
    public static class AccountBalanceExtensions
    {
        public static bool HasAvailableFunds(this AccountBalance ab, decimal price, decimal quantity)
        {
            return ab.Free >= price * quantity;
        }

        public static bool HasAvailableQuantity(this AccountBalance ab, decimal quantity)
        {
            return ab.Free >= quantity;
        }
    }
}