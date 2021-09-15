using System;
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
        protected override ILoggerFactory CreateLogFactory()
        {
            return null;
        }

        protected override ILoggerProvider CreateLogProvider()
        {
            return null;
        }
    }
}
