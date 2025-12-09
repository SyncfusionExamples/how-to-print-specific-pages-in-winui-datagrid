using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGrid_Demo
{
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public ViewModel()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1001, "Maria", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1002, "Ana", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new OrderInfo(1003, "Antonio", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new OrderInfo(1004, "Thomas", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1005, "Christina", "Sweden", "BERGS", "Lula"));
            _orders.Add(new OrderInfo(1006, "Hanna", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1007, "Frederique", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1008, "Martin", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1009, "Laurence", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1010, "Elizabeth", "Canada", "BOTTM", "Tsawassen"));

            _orders.Add(new OrderInfo(1011, "Afonso", "Brazil", "PEDRO", "Rio de Janeiro"));
            _orders.Add(new OrderInfo(1012, "Yoshi", "Japan", "YOSHI", "Tokyo"));
            _orders.Add(new OrderInfo(1013, "Carlos", "Argentina", "CARLO", "Buenos Aires"));
            _orders.Add(new OrderInfo(1014, "Isabella", "Italy", "ROSSI", "Rome"));
            _orders.Add(new OrderInfo(1015, "Sophie", "France", "SOPHI", "Paris"));
            _orders.Add(new OrderInfo(1016, "Lars", "Sweden", "LARSJ", "Stockholm"));
            _orders.Add(new OrderInfo(1017, "Emily", "USA", "EMILY", "New York"));
            _orders.Add(new OrderInfo(1018, "Rajesh", "India", "RAJES", "Delhi"));
            _orders.Add(new OrderInfo(1019, "Chen", "China", "CHENW", "Beijing"));
            _orders.Add(new OrderInfo(1020, "Fatima", "Morocco", "FATIM", "Casablanca"));

            _orders.Add(new OrderInfo(1021, "George", "Australia", "GEORG", "Sydney"));
            _orders.Add(new OrderInfo(1022, "Petrova", "Russia", "OLGAP", "Moscow"));
            _orders.Add(new OrderInfo(1023, "Ahmed", "Egypt", "AHMED", "Cairo"));
            _orders.Add(new OrderInfo(1024, "Kim", "South Korea", "KIMSO", "Seoul"));
            _orders.Add(new OrderInfo(1025, "Juan", "Spain", "JUANL", "Barcelona"));
            _orders.Add(new OrderInfo(1026, "Müller", "Germany", "EVAMU", "Munich"));
            _orders.Add(new OrderInfo(1027, "William", "UK", "WILLB", "Manchester"));
            _orders.Add(new OrderInfo(1028, "Svensson", "Norway", "NORAS", "Oslo"));
            _orders.Add(new OrderInfo(1029, "Ali", "Pakistan", "ALIKH", "Karachi"));
            _orders.Add(new OrderInfo(1030, "Lee", "Singapore", "SOPHL", "Singapore"));
        }
    }
}
