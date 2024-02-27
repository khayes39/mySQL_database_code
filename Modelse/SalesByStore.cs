using System;
using System.Collections.Generic;

namespace mySQL_database_code.Modelse;

public partial class SalesByStore
{
    public string? Store { get; set; }

    public string? Manager { get; set; }

    public decimal? TotalSales { get; set; }
}
