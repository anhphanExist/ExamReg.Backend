﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamReg.Authentication.Common
{
    public class AppSettings
    {
        public string JWTSecret { get; set; }
        public int JWTLifeTime { get; set; }
    }
}
