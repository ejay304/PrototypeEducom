using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrototypeEDUCOM.ViewModel
{
    class MainViewModel
    {
        public ICommand btnListRequest { get; set; }

        public MainViewModel()
        {
            btnListRequest = new RelayCommand<object>(linkToListRequest);
        }

        private void linkToListRequest(object arg)
        {

            Console.WriteLine("test");
            View.RequestsView requestsView = new View.RequestsView();
            requestsView.Show();
        }

    }
}
