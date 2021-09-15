using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using Vorlage.Core.ViewModels;

namespace Vorlage.Wpf.Views
{
    /// <summary>
    /// Interaktionslogik für MainView.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(MainViewModel))]
    public partial class MainView : MvxWpfView
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}
