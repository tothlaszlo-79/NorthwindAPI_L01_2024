using System;
using System.Collections.Generic;

namespace NorthwindAPI_L01.Domain;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
