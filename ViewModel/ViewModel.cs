using DXApplication2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication2.ViewModel
{

    public class MainViewModel
    {
        public List<ClassData> ClassSource { get; set; }
        public List<ConnectionData> ConnectionSource { get; set; }

        public MainViewModel()
        {
            ClassSource = ClassStructureGenerator.ClassList();
            ConnectionSource = ClassStructureGenerator.ConnectionList();
        }
    }
}