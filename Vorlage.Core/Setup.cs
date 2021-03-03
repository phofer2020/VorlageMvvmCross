using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Vorlage.Core.ViewModels;

namespace Vorlage.Core
{
    public class Setup : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
