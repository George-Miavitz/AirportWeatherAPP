using System;
using System.Collections.Generic;

namespace AirportWeatherAppAPI.Data;

public partial class WeatherDataOrg
{
    public int OrgId { get; set; }

    public string OrgName { get; set; } = null!;

    public virtual ICollection<Observation> Observations { get; set; } = new List<Observation>();
}
