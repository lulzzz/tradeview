﻿using Interface = DevelopmentInProgress.MarketView.Interface.Model;
using DevelopmentInProgress.Wpf.MarketView.Model;
using System;
using DevelopmentInProgress.MarketView.Interface.Extensions;

namespace DevelopmentInProgress.Wpf.MarketView.Extensions
{
    public static class OrderExtensions
    {
        public static Order GetViewOrder(this Interface.Order o)
        {
            return new Order
            {
                Symbol = o.Symbol,
                Id = o.Id,
                ClientOrderId = o.ClientOrderId,
                Price = o.Price,
                OriginalQuantity = o.OriginalQuantity,
                ExecutedQuantity = o.ExecutedQuantity,
                Status = o.Status.GetOrderStatusName(),
                TimeInForce = o.TimeInForce.GetTimeInForceName(),
                Type = o.Type.GetOrderTypeName(),
                Side = o.Side.GetOrderSideName(),
                StopPrice = o.StopPrice,
                IcebergQuantity = o.IcebergQuantity,
                Time = o.Time,
                IsWorking = o.IsWorking
            };
        }

        public static Order Update(this Order o, Order order)
        {
            if (string.IsNullOrWhiteSpace(o.ClientOrderId)
                || string.IsNullOrWhiteSpace(order.ClientOrderId)
                || o.ClientOrderId != order.ClientOrderId)
            {
                throw new Exception($"{o.Symbol} order update failed: Cannot update ClientOrderId {o.ClientOrderId} with {order.ClientOrderId}");
            }

            o.Symbol = order.Symbol;
            o.Id = order.Id;
            o.ClientOrderId = order.ClientOrderId;
            o.Price = order.Price;
            o.OriginalQuantity = order.OriginalQuantity;
            o.ExecutedQuantity = order.ExecutedQuantity;
            o.Status = order.Status;
            o.TimeInForce = order.TimeInForce;
            o.Type = order.Type;
            o.Side = order.Side;
            o.StopPrice = order.StopPrice;
            o.IcebergQuantity = order.IcebergQuantity;
            o.Time = order.Time;
            o.IsWorking = order.IsWorking;
            return o;
        }
    }
}
