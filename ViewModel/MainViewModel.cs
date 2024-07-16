using DevExpress.Xpf.Diagram;
using DevExpress.Mvvm;
using DXApplication2.Data;
using System.Collections.Generic;

public class MainViewModel
{
    public List<ClassData> ClassSource { get; set; }
    public List<ConnectionData> ConnectionSource { get; set; }

    public MainViewModel()
    {
        // mapping method
        ClassSource = ClassStructureGenerator.ClassList();
        ConnectionSource = ClassStructureGenerator.ConnectionList();

        GenerateItemCommand = new DelegateCommand<DiagramGenerateItemEventArgs>(AddShapes);
        GenerateConnectorCommand = new DelegateCommand<DiagramGenerateConnectorEventArgs>(AddConnectors);
    }

    public IDelegateCommand GenerateItemCommand { get; }
    public IDelegateCommand GenerateConnectorCommand { get; }

    private void AddShapes(DiagramGenerateItemEventArgs e)
    {
        var data = e.DataObject as ClassData;
        if (data != null)
        {
            switch (data.Type)
            {
                case ClassType.Distributor:
                case ClassType.Warehouse:
                    e.Item = e.CreateItemFromTemplate("ClassShape");
                    break;
                case ClassType.Supplier:
                case ClassType.Plant:
                case ClassType.Customer:
                    e.Item = e.CreateItemFromTemplate("InterfaceShape");
                    break;
                default:
                    e.Item = e.CreateItemFromTemplate("ClassShape");
                    break;
            }
        }
    }

    private void AddConnectors(DiagramGenerateConnectorEventArgs e)
    {
        var fromData = e.From as ClassData;
        var toData = e.To as ClassData;
        if (fromData != null && toData != null)
        {
            if (fromData.Type == ClassType.Warehouse || toData.Type == ClassType.Warehouse)
            {
                e.Connector = e.CreateConnectorFromTemplate("InterfaceConnector");
            }
            else
            {
                e.Connector = e.CreateConnectorFromTemplate("ClassConnector");
            }
        }
    }
}
