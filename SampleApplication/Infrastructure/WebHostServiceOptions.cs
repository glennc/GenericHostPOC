﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace Microsoft.AspNetCore.Hosting
{
    public class WebHostServiceOptions
    {
        public Action<IApplicationBuilder> ConfigureApplication { get; internal set; }
    }
}
