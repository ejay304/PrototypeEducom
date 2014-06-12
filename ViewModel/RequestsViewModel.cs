using PrototypeEDUCOM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrototypeEDUCOM.ViewModel
{
    class RequestsViewModel
    {

        private Model.EducomDb db = new Model.EducomDb();

        public ICollection<Model.request> requests { get; set; }
        public ICommand cmdViewDetail { get; set; }

        public RequestsViewModel() {
            this.requests = db.requests.ToArray();
            this.cmdViewDetail = new RelayCommand<request>(actViewDetail);
        }

        public void actViewDetail(request request)
        {
            View.ShowRequestView showRequestsView = new View.ShowRequestView(request);
            showRequestsView.Show();
        }
    }
}
