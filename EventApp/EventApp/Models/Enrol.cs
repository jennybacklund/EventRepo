﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace EventApp.Models
{
    public class Enrol
    {
        public virtual int EventId { get; set; }
        public virtual Event Event { get; set; }

        public virtual int UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
