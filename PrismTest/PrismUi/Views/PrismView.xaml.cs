using System.Windows.Controls;

namespace PrismUi.Views
{
    /// <summary>
    /// Interaction logic for PrismView.xaml
    /// </summary>
    public partial class PrismView : UserControl
    {
        public PrismView(ViewModels.PrismViewModel regionManager)
        {
            InitializeComponent();

              Loaded += (s, e) =>
            {
                DataContext = regionManager;
            };
        }
    }
}
