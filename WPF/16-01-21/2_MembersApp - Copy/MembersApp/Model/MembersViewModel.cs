using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace MembersApp.Model
{
    public class MembersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _MyCount;
        public string MyCount
        {
            get
            {
                ICollectionView membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
                List<Member> members = MembersRepository.GetAll();
                _MyCount = members.Count.ToString();
                return _MyCount;
            }
            set
            {
                _MyCount = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("MyCount"));
            }
        }

        private List<Member> _Members;
        public List<Member> Members
        {
            get
            {
                //_Members = MembersRepository.GetAll();
                return _Members;
            }
            set
            {
                _Members = MembersRepository.GetAll(); //value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Members"));
            }
        }

        //public bool IsNotFirst
        //{
        //    get { return (Members.Count > 0); }
        //}


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
            Members = MembersRepository.GetAll();
            ICollectionView membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
            if (!membersView.IsEmpty)
            {
                Console.WriteLine(membersView.IsCurrentAfterLast);
                if (membersView.CurrentPosition >= Members.Count)
                    membersView.MoveCurrentToLast();
                else
                    membersView.MoveCurrentToPosition(membersView.CurrentPosition);
            }
        }

        public bool IsNotFirstRecord
        {
            get
            {
                ICollectionView membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
                return (membersView.CurrentPosition != 0);
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
            throw new NotImplementedException();
        }
    }

    public class MoveNextCommad : Navigate
    {
        public override void Execute(object parameter)
        {
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
