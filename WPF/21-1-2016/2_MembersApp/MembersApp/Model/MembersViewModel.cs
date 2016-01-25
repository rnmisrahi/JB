using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace MembersApp.Model
{
    public class MembersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MembersViewModel()
        {
            HasRecords = (Members.Count > 0);
        }

        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        private bool _HasRecords;
        public bool HasRecords
        {
            get {
                return _HasRecords;
            }  
            set {
                int n = Members.Count;
                _HasRecords = (n == 0);
                Notify("pnlData");
            }
        }

        //Dov: This doesn't work. It is never called. Is it because there is no 
        private string _MyCount;
        public string MyCount
        {
            get
            {
                return Members.Count.ToString() + " Items";
            }
        }

        private MyObservableCollection _Members;
        public MyObservableCollection Members
        {
            get
            {
                _Members = MembersRepository.GetAll();
                return _Members;
            }
            set
            {
                _Members = MembersRepository.GetAll(); //value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Members"));
            }
        }

        private ICommand _moveNext;
        public ICommand MoveNext
        {
            get                         // Lazy loading
            {
                if (_moveNext == null)
                    _moveNext = new MoveNextCommad();
                return _moveNext;
            }
        }

        public void PositionAfterDelete()
        {
            ICollectionView membersView = CollectionViewSource.GetDefaultView(Members);
            if (!membersView.IsEmpty)
            {
                Console.WriteLine(membersView.IsCurrentAfterLast);
                if (membersView.CurrentPosition >= Members.Count)
                    membersView.MoveCurrentToLast();
                else
                    membersView.MoveCurrentToPosition(membersView.CurrentPosition);
            }
        }

        private ICommand _movePrev;
        public ICommand MovePrev
        {
            get                         // Lazy loading
            {
                if (_movePrev == null)
                    _movePrev = new MovePrevCommad();
                return _movePrev;
            }
        }

        private ICommand _moveFirst;
        public ICommand MoveFirst
        {
            get
            {
                if (_moveFirst == null)
                    _moveFirst = new MoveFirstCommand();
                return _moveFirst;
            }
        }

        private ICommand _moveLast;
        public ICommand MoveLast
        {
            get
            {
                if (_moveLast == null)
                    _moveLast = new MoveLastCommand();
                return _moveLast;
            }
        }

    }//MembersViewModel

    public class Navigate : ICommand
    {
        protected ICollectionView membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public virtual void Execute(object parameter)
        {
            
        }
    }

    public class MoveNextCommad : Navigate
    {
        public override void Execute(object parameter)
        {
            base.Execute(parameter);
            membersView.MoveCurrentToNext();
            if (membersView.IsCurrentAfterLast)
                membersView.MoveCurrentToLast();
        }
    }

    public class MovePrevCommad : Navigate
    {
        public override void Execute(object parameter)
        {
            if (membersView.CurrentPosition > 0)
                membersView.MoveCurrentToPrevious();
        }
    }

    public class MoveFirstCommand : Navigate
    {
        public override void Execute(object parameter)
        {
            membersView.MoveCurrentToFirst();
        }
    }

    public class MoveLastCommand : Navigate
    {
        public override void Execute(object parameter)
        {
            membersView.MoveCurrentToLast();
        }
    }
}
