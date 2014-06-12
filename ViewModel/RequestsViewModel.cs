using PrototypeEDUCOM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrototypeEDUCOM.ViewModel
{
    class RequestsViewModel : BaseViewModel
    {

        private Model.EducomDb db = new Model.EducomDb();

        public ICollection<Model.request> requests {
            get { return db.requests.ToArray(); }
            set {  }
        }
        public ICommand cmdViewDetail { get; set; }
        public ICommand cmdFormAddRequest { get; set; }


        public RequestsViewModel() : base()
        {
            this.requests = db.requests.ToArray();
            this.cmdViewDetail = new RelayCommand<request>(actViewDetail);
            this.cmdFormAddRequest = new RelayCommand<request>(actFormAddRequest);
        }

        private void actFormAddRequest(request obj)
        {
            View.FormRequestView showRequestsView = new View.FormRequestView();
            showRequestsView.Show();
        }

        public void actViewDetail(request request)
        {
            View.ShowRequestView showRequestsView = new View.ShowRequestView(request);
            showRequestsView.Show();
        }
    }
}
