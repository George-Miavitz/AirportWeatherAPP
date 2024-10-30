using System;
using System.Collections.Generic;
using System.Data;

namespace AirportWeatherAppAPI.Data;

public partial class Observation
{
    public int ObservationId { get; set; }

    public int UserId { get; set; }

    public int OrgId { get; set; }

    public string? Descriptor { get; set; }

    public DateTime Timestamp { get; set; }

    public decimal? Temperature { get; set; }

    public decimal? WindSpeed { get; set; }

    public string? WindDirection { get; set; }

    public decimal? Visibility { get; set; }

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();

    public virtual WeatherDataOrg Org { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
