﻿using System;

namespace DevelopmentInProgress.MarketView.Interface.Model
{
    public class AggregateTrade
    {
        public string Symbol { get; set; }
        public long Id { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public DateTime Time { get; set; }
        public bool IsBuyerMaker { get; set; }
        public bool IsBestPriceMatch { get; set; }
        public long FirstTradeId { get; set; }
        public long LastTradeId { get; set; }
    }
}
