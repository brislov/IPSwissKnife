using System.Windows.Input;

namespace IPSwissKnife.ViewModels
{
    internal class ConnectionViewModel : BindableObject
    {
        private string addressEntry;
        private string portEntry;
        internal string AddressEntry 
        { 
            get => addressEntry; 
            set => addressEntry = value;
        }
        internal string PortEntry 
        { 
            get => portEntry; 
            set => addressEntry = value;
        }

        internal ICommand CreateConnectionCommand { get; }
        internal void CreateConnectionMethod()
        {
            if (string.IsNullOrEmpty(addressEntry) && string.IsNullOrEmpty(portEntry))
            {
                return;
            }

        }
    }
}
