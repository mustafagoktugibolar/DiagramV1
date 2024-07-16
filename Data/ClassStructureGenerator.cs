using System.Collections.Generic;

namespace DXApplication2.Data
{
    public class ClassStructureGenerator
    {
        public static List<ClassData> ClassList()
        {
            var list = new List<ClassData>();

            list.Add(new ClassData()
            {
                ClassName = "Supplier1",
                Type = ClassType.Supplier
            });

            list.Add(new ClassData()
            {
                ClassName = "Supplier2",
                Type = ClassType.Supplier
            });

            list.Add(new ClassData()
            {
                ClassName = "Warehouse1",
                Type = ClassType.Warehouse
            });

            list.Add(new ClassData()
            {
                ClassName = "Plant1",
                Type = ClassType.Plant
            });

            list.Add(new ClassData()
            {
                ClassName = "Customer1",
                Type = ClassType.Customer
            });

            list.Add(new ClassData()
            {
                ClassName = "Customer2",
                Type = ClassType.Customer
            });

            list.Add(new ClassData()
            {
                ClassName = "Distributor1",
                Type = ClassType.Distributor
            });
            list.Add(new ClassData()
            {
                ClassName = "Distributor2",
                Type = ClassType.Distributor
            });
            list.Add(new ClassData()
            {
                ClassName = "Distributor3",
                Type = ClassType.Distributor
            });

            list.Add(new ClassData()
            {
                ClassName = "Plant2",
                Type = ClassType.Plant
            });

            return list;
        }

        public static List<ConnectionData> ConnectionList()
        {
            var cList = new List<ConnectionData>();

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Warehouse1",
                ConnectedFrom = "Supplier1"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Plant2",
                ConnectedFrom = "Supplier1"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Warehouse1",
                ConnectedFrom = "Supplier2"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Plant1",
                ConnectedFrom = "Warehouse1"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Plant2",
                ConnectedFrom = "Warehouse1"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Distributor1",
                ConnectedFrom = "Plant1"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Customer1",
                ConnectedFrom = "Plant2"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Distributor3",
                ConnectedFrom = "Plant1"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Customer1",
                ConnectedFrom = "Distributor1"
            });
            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Customer1",
                ConnectedFrom = "Distributor2"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Customer1",
                ConnectedFrom = "Distributor3"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Customer2",
                ConnectedFrom = "Distributor3"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Customer2",
                ConnectedFrom = "Distributor2"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Customer2",
                ConnectedFrom = "Distributor1"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Distributor1",
                ConnectedFrom = "Plant2"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "Distributor2",
                ConnectedFrom = "Plant2"
            });


            return cList;
        }
    }
}
