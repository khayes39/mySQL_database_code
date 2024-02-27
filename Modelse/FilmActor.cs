using System;
using System.Collections.Generic;

namespace mySQL_database_code.Modelse;

public partial class FilmActor
{
    public ushort ActorId { get; set; }

    public ushort FilmId { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual Actor Actor { get; set; } = null!;

    public virtual Film Film { get; set; } = null!;
}
