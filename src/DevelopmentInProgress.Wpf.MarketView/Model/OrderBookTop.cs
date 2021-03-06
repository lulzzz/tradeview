﻿using DevelopmentInProgress.Wpf.Common.Model;

namespace DevelopmentInProgress.Wpf.MarketView.Model
{
    public class OrderBookTop : EntityBase
    {
        public OrderBookPriceLevel Bid { get; set; }
        public OrderBookPriceLevel Ask { get; set; }
    }
}
