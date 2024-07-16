using DevExpress.Xpf.Core;
using DevExpress.Xpf.Diagram;
using DXApplication2.Data;

namespace DXApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
 
    }
}
