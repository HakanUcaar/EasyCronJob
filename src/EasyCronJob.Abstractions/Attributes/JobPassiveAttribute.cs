﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCronJob.Abstractions
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class JobPassiveAttribute : Attribute
    {
    }
}
