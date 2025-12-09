using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace SfDataGrid_Demo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int orderID;
        private string customerId;
        private string country;
        private string customerName;
        private string shippingCity;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public int OrderID
        {
            get => orderID;
            set
            {
                orderID = value;
                OnPropertyChanged(nameof(OrderID));
            }
        }

        public string CustomerID
        {
            get => customerId;
            set
            {
                customerId = value;
                OnPropertyChanged(nameof(CustomerID));
            }
        }

        public string CustomerName
        {
            get => customerName;
            set
            {
                customerName = value;
                OnPropertyChanged(nameof(CustomerName));
            }
        }

        public string Country
        {
            get => country;
            set
            {
                country = value;
                OnPropertyChanged(nameof(Country));
            }
        }

        public string ShipCity
        {
            get => shippingCity;
            set
            {
                shippingCity = value;
                OnPropertyChanged(nameof(ShipCity));
            }
        }

        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity)
        {
            this.orderID = orderId;
            this.customerName = customerName;
            this.country = country;
            this.customerId = customerId;
            this.shippingCity = shipCity;
        }
    }
}
