using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportWeatherAppAPI.Data;

public partial class WeatherDataOrg
{
    [Key]
    public int OrgId { get; set; }

    public string OrgName { get; set; } = null!;

    public virtual ICollection<Observation> Observations { get; set; } = new List<Observation>();
}
