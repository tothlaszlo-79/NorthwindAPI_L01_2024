﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NorthwindAPI_L01.Domain;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    [JsonIgnore]
    public byte[]? Picture { get; set; }
    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
