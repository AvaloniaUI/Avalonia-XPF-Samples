using System.Collections.Generic;
using System.Windows.Controls;

namespace SyncfusionApp.Views
{
    public partial class GridDemoView : UserControl
    {
        public GridDemoView()
        {
            InitializeComponent();
            grid.ItemsSource = GetData();
        }

        private List<Person> GetData()
        {
            return new List<Person>
            {
                new Person { ID = 1, Name = "Alice", Age = 28, Department = "HR" },
                new Person { ID = 2, Name = "Bob", Age = 34, Department = "IT" },
                new Person { ID = 3, Name = "Charlie", Age = 25, Department = "Sales" },
                new Person { ID = 4, Name = "Diana", Age = 40, Department = "Finance" }
            };
        }
    }

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
}