using PrototypeEDUCOM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeEDUCOM.ViewModel
{
    class ShowRequestViewModel
    {   
        private Model.EducomDb db = new Model.EducomDb();

        public string desciption {get; set;}
        public string state { get; set; }
        public ShowRequestViewModel(request request) {
            this.desciption = request.description;
            this.state = request.state;
        }
    }
}
