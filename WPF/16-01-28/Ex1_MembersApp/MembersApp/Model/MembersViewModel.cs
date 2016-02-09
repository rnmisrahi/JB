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
    public class MembersViewModel
    {
        // private List<Member> _members;
        public List<Member> Members
        { 
            get
            {
                return MembersRepository.GetAll();
            }
        }

        private ICommand _moveFirst;
        public ICommand MoveFirst
        {
            get                         // Lazy loading
            {
                if (_moveFirst == null)
                    _moveFirst = new MoveFirstCommand();
                return _moveFirst;
            }
        }

        private ICommand _moveNext;
        public ICommand MoveNext
        {
            get                         // Lazy loading
            {
                if (_moveNext == null)
                    _moveNext = new MoveNextCommand();
                return _moveNext;
            }
       }

        private ICommand _movePrev;
        public ICommand MovePrev
        {
            get                         // Lazy loading
            {
                if (_movePrev == null)
                    _movePrev = new MovePrevCommand();
                return _movePrev;
            }
        }
    }

    public class MoveFirstCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ICollectionView membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
            membersView.MoveCurrentToFirst();
        }
    }

    public class MoveNextCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ICollectionView membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
            membersView.MoveCurrentToNext();
            if (membersView.IsCurrentAfterLast)
            {
                membersView.MoveCurrentToLast();
            }
        }
    }

    public class MovePrevCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ICollectionView membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
            membersView.MoveCurrentToPrevious();
            if (membersView.IsCurrentBeforeFirst)
            {
                membersView.MoveCurrentToFirst();
            }
        }
    }
}
