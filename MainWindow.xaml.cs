using DevExpress.Xpf.Core;
using DXApplication2.Data;
using DXApplication2.ViewModel;

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
        private void DiagramDataBindingBehavior_GenerateItem(object sender, DevExpress.Xpf.Diagram.DiagramGenerateItemEventArgs e)
        {
            if (((ClassData)e.DataObject).Type == ClassType.Interface)
                e.Item = e.CreateItemFromTemplate("InterfaceShape");
            else e.Item = e.CreateItemFromTemplate("ClassShape");
        }

        private void DiagramDataBindingBehavior_GenerateConnector(object sender, DevExpress.Xpf.Diagram.DiagramGenerateConnectorEventArgs e)
        {
            if (((ClassData)e.From).Type == ClassType.Interface || ((ClassData)e.To).Type == ClassType.Interface)
                e.Connector = e.CreateConnectorFromTemplate("InterfaceConnector");
            else e.Connector = e.CreateConnectorFromTemplate("ClassConnector");
        }
    }
}
