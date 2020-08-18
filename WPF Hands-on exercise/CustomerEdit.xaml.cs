using HandsOnLab1.ClientEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HandsOnLab1
{
    public partial class CustomerEdit : UserControl,
INotifyPropertyChanged
    {
        private CustomerUpdate _customer = new
        CustomerUpdate(123);
public CustomerEdit()
        {
            InitializeComponent();
            DataContext = this;
        }
        public CustomerUpdate Customer
        {
            get { return _customer; }
            set
            {
                if (_customer != value)
                {
                    _customer = value;
                    OnPropertyChanged("Customer");
                }
            }
        }
        private void CanSave(object sender,
        CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void ExecuteSave(object sender,
        ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Assume the save worked.");
        }
        #region INotifyPropertyChanged Members
        /// <summary>
        /// Implicit implementation of the INotifyPropertyChanged.PropertyChanged event.
        /// /// </summary>
public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Throws the <c>PropertyChanged</c> event.
        /// </summary>
        /// <param name="propertyName">The name of theproperty that was modified.</param>
protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new
                PropertyChangedEventArgs(propertyName));
            }
        }

        

#endregion
    }
}
