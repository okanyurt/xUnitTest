﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Names
    {
        public string NickName { get; set; }

        public string MakeFullName(string firstName,string lastName)
        {
            return $"{firstName}--{lastName}";
        }
    }
}
