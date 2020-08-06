using System;
using System.Collections.Generic;

namespace EF_Northwind_App
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
