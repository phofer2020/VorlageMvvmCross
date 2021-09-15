﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Wpf.Core;
using Serilog;
using Serilog.Extensions.Logging;

// documentation
namespace Vorlage.Wpf
{
    public class Setup : MvxWpfSetup<Core.Setup>
    {
        protected override ILoggerProvider CreateLogProvider()
        {
            return new SerilogLoggerProvider();
        }

        protected override ILoggerFactory CreateLogFactory()
        {
            // serilog configuration
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Trace()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }
    }
}
