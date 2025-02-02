﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportWeatherAppAPI.Data;

public partial class User
{
    [Key]
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<Observation> Observations { get; set; } = new List<Observation>();
}
