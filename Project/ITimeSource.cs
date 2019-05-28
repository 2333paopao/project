﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public interface ITimeSource
    {
        ///<summary>Returns the current time as UTC time.</summary>
        DateTime UtcNow();

        DateTime LocalNow();
    }

    public class DateTimeNowTimeSource : ITimeSource
    {
        ///<summary>Returns DateTime.UtcNow</summary>
        public DateTime UtcNow() => DateTime.UtcNow;

        public DateTime LocalNow() => DateTime.UtcNow.ToLocalTime();
    }
}
