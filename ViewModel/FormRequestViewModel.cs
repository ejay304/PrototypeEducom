using PrototypeEDUCOM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrototypeEDUCOM.ViewModel
{
    class FormRequestViewModel : BaseViewModel
    {
        public ICommand cmdAddRequest { get; set; }
        public string description { get; set; }
        public string state { get; set; }

        public FormRequestViewModel()
        {
            this.cmdAddRequest = new RelayCommand<Object>(actAddRequest);
        }

        private void actAddRequest(object obj)
        {
            request r = new request();
            r.description = description;
            r.state = "done";
            r.user = db.users.First();
            db.requests.Add(r);
            db.SaveChanges();
        }
    }
}
