﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EverGreenWebApi.Models
{
    public class CustomerOrderModel
    {
        public int LoginId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public int AddressId { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string LandMark { get; set; }
        public DateTime OrderTime { get; set; }
        public decimal TotalGST { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal NetPrice { get; set; }
        public decimal DeliveryCharge { get; set; }
        public decimal PromoDiscount { get; set; }
        public decimal SpecialDiscount { get; set; }
        public string OrderStatus { get; set; }
        public string TranscationId { get; set; }
        public int PromoCodeId { get; set; }
        public string PromoCode { get; set; }
        public string PaymentMode { get; set; }
        public IEnumerable<OrderDetailsModel> OrderDetails { get; set; }
    }
}