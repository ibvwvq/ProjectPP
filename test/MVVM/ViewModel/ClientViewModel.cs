using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.MVVM.Model;

namespace test.MVVM.ViewModel 
{
    internal class ClientViewModel : BaseViewModel
    {
        private readonly Client client;

        public Client Client
        {
            get { return client; }
        }

        public string Name
        {
            get => client.Name;
            set
            {
                client.Name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get => client.Surname;
            set
            {
                client.Surname = value;
                OnPropertyChanged();
            }
        }

        public int Id
        {
            get => client.Id;
            set
            {
                client.Id = value;
                OnPropertyChanged();
            }
        }

        public ClientViewModel(Client note)
        {
            this.client = note;
        }
    }
}
