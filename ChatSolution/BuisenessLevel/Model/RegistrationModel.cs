﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessLevel.Model
{
    public class RegistrationModel
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public byte[] Hash { get; set; }
    }
}
