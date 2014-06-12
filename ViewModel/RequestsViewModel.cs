using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeEDUCOM.ViewModel
{
    class RequestsViewModel
    {

        private Model.EducomDb db = new Model.EducomDb();

        public ICollection<Model.request> requests { get; set; }

        public RequestsViewModel() {
            this.requests = db.requests.ToArray();
        }
    }
}
