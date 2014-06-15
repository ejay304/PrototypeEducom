using PrototypeEDUCOM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrototypeEDUCOM.ViewModel
{
    class RequestsViewModel : BaseViewModel
    {
        // Utiliser une ObservableCollection (Au lieu de ICollection), de cette manière, lors de la modif d'un item de la list, 
        // la vue est directement avertit et mis a jour (dans ICollection, il gere la liste global mais pas chaque item)

        // Peut-etre plus propre de mettre les NotifyPropertyChanged directement dans les set des propriété, a voir
        public ObservableCollection<Model.request> requests { get; set; }

        public string description { get; set; }

        public string state { get; set; }

        public ICommand cmdViewDetail { get; set; }

        public ICommand cmdDelete { get; set; }

        public ICommand cmdFormAddRequest { get; set; }

        public ICommand cmdAdd { get; set; }


        public RequestsViewModel() : base()
        {
            this.requests = new ObservableCollection<request>(db.requests.ToList());
            this.cmdViewDetail = new RelayCommand<request>(actViewDetail);
            this.cmdDelete = new RelayCommand<request>(actDelete);
            this.cmdFormAddRequest = new RelayCommand<request>(actFormAddRequest);
            this.cmdAdd = new RelayCommand<object>(actAdd);
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

        public void actDelete(request request)
        {
            requests.Remove(request);
            db.requests.Remove(request);
            db.SaveChanges();
            NotifyPropertyChanged("requests");
        }

        public void actAdd(object obj)
        {

            Console.WriteLine(requests.Count);

            request r = new request();
            r.description = description;
            r.state = "done";
            r.user = db.users.First();

            // Voir les possibilité avec EF de modif la list et automatiquement gere la BD

            // Ajoute dans la liste
            requests.Add(r);
            NotifyPropertyChanged("requests");
            Console.WriteLine(requests.Count);
           
            // Enregistre dans la base
            db.requests.Add(r);
            db.SaveChanges();
        }
    }
}
