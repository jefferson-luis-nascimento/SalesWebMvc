﻿using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegretyException : ApplicationException
    {
        public IntegretyException(string message)
            : base(message)
        {
        }
    }
}
