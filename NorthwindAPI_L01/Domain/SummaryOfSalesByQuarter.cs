﻿using System;
using System.Collections.Generic;

namespace NorthwindAPI_L01.Domain;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
