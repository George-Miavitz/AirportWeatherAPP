using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportWeatherAppAPI.Data;

public partial class Feedback
{
    [Key]
    public int FeedbackId { get; set; }

    public int UserId { get; set; }

    public string? Text { get; set; }

    public DateTime Timestamp { get; set; }

    public virtual User User { get; set; } = null!;
}
