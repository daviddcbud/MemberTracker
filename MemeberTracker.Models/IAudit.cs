﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeberTracker.Models
{
    public interface  IAudit
    {
         DateTime CreatedOn { get; set; }
         DateTime ModifiedOn { get; set; }
    }
}
