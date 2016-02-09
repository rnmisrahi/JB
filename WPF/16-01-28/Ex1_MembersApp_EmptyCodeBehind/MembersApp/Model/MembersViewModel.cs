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

        private ICommand _moveLast;
        public ICommand MoveLast
        {
            get                         // Lazy loading
            {
                if (_moveLast == null)
                    _moveLast = new MoveLastCommand();
                return _moveLast;
            }
        }

        private ICommand _newMember;
        public ICommand NewMember
        {
            get                         // Lazy loading
            {
                if (_newMember == null)
                    _newMember = new NewMemberCommand();
                return _newMember;
            }
        }
        
        private ICommand _delete;
        public ICommand Delete
        {
            get                         // Lazy loading
            {
                if (_delete == null)
                    _delete = new DeleteCommand();
                return _delete;
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

    public class MoveLastCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ICollectionView membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
            membersView.MoveCurrentToLast();
        }
    }

    public class NewMemberCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ICollectionView membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
            Member newMember = new Member();
            MembersRepository.Add(newMember);
            membersView.MoveCurrentToLast();
        }
    }

    public class DeleteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ICollectionView membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
            MembersRepository.Delete(membersView.CurrentPosition);
            membersView.MoveCurrentToPosition(membersView.CurrentPosition);
            //if (membersView.IsEmpty)
            //{
            //    grdData.Visibility = Visibility.Hidden;
            //    grdNodata.Visibility = Visibility.Visible;
            //}
        }
    }
}
