using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using test.MVVM.Commands;
using test.MVVM.Model;

namespace test.MVVM.ViewModel
{
    internal class MainViewModel : BaseViewModel
    {
        private ObservableCollection<ClientViewModel> clients;
        private ClientViewModel? selectNote;
        //private readonly Note note;
        private readonly RelayCommand addCommand;
        private readonly RelayCommand removeCommand;
        private readonly RelayCommand sortByTitle;
        private readonly RelayCommand sortByTitleDec;
        private readonly RelayCommand saveCommand;

        public MainViewModel()
        {
            clients = new ObservableCollection<ClientViewModel>();
            addCommand = new RelayCommand(Add);
            removeCommand = new RelayCommand(Remove, obj => Clients.Count > 0 && selectNote != null);
            sortByTitle = new RelayCommand(SortByTitle, obj => Clients.Count > 1);
            sortByTitleDec = new RelayCommand(SortByTitleDec, obj => Clients.Count > 1);
            saveCommand = new RelayCommand(Save, obj => selectNote != null);

            using (DbPracticContext db = new DbPracticContext())
            {
                clients = new ObservableCollection<ClientViewModel>(db.Clients.Select(i => new ClientViewModel(i)));
            }
        }



        public ObservableCollection<ClientViewModel> Clients
        {
            get => clients;
            set => Set(ref clients, value);
        }

        public ClientViewModel? SelectNote
        {
            get => selectNote;
            set => Set(ref selectNote, value);
        }

        public RelayCommand AddCommand
        {
            get => addCommand;
        }

        public RelayCommand RemoveCommand
        {
            get => removeCommand;
        }

        public RelayCommand SortyngByTitleCommand
        {
            get => sortByTitle;
        }
        public RelayCommand SortyngByTitleDecCommand
        {
            get => sortByTitleDec;
        }

        public RelayCommand SaveCommand
        {
            get => saveCommand;
        }

        private void Add(object? param)
        {
            Clients.Add(new ClientViewModel(new Client { Name = "Безымянный", Surname = "" }));
            MessageBox.Show("Add");
        }

        private void Remove(object? param)
        {
            if (SelectNote is null)
                return;
            Clients.Remove(SelectNote);
        }

        private void Save(object? obj)
        {
            using (DbPracticContext db = new DbPracticContext())
            {
                foreach (var item in clients)
                {
                    if (item.Id == 0)
                    {
                        db.Add(item.Client);
                    }
                    else
                    {
                        db.Entry(item.Client).State = EntityState.Modified;
                    }
                }
                db.SaveChanges();
            }
        }

        private void SortByTitleDec(object? param)
        {
            Clients = new ObservableCollection<ClientViewModel>(Clients.OrderByDescending(i => i.Name));
        }
        private void SortByTitle(object? param)
        {
            Clients = new ObservableCollection<ClientViewModel>(Clients.OrderBy(i => i.Surname));
        }   
    }
}
