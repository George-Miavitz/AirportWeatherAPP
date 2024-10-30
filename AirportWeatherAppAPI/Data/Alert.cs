using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportWeatherAppAPI.Data;

public partial class Alert
{
    [Key]
    public int AlertId { get; set; }

    public int UserId { get; set; }

    public int ObservationId { get; set; }

    public string? CommunicationText { get; set; }

    public virtual Observation? Observation { get; set; } = null!;

    public virtual User? User { get; set; } = null!;
}
