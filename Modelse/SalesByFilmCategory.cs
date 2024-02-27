using System;
using System.Collections.Generic;

namespace mySQL_database_code.Modelse;

public partial class SalesByFilmCategory
{
    public string Category { get; set; } = null!;

    public decimal? TotalSales { get; set; }
}
