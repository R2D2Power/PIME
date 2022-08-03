
namespace PIME.Models
{
    using System;
    using System.ComponentModel;
    public class Customer : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the Customer class; 
        /// </summary>
        public Customer(String customerName)
        {
            Name = customerName;
        }

        private string _Name;
        /// <summary>
        /// Get or set the Customer's name.
        /// </summary>
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }
        #region INotifyPropertyChanged Menbers

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
