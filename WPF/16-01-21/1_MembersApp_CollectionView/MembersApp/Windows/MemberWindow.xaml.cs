using MembersApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MembersApp.Windows
{
    /// <summary>
    /// Interaction logic for MemberWindow.xaml
    /// </summary>
    public partial class MemberWindow : Window
    {
        // int current = 0;
        ICollectionView membersView = null;
        public MemberWindow()
        {
            InitializeComponent();
            DataContext = MembersRepository.GetAll();
            membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            membersView.MoveCurrentToNext();
            if (membersView.IsCurrentAfterLast)
            {
                membersView.MoveCurrentToLast();
            }
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            membersView.MoveCurrentToPrevious();
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            membersView.MoveCurrentToFirst();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            membersView.MoveCurrentToLast();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MembersRepository.Delete(membersView.CurrentPosition);
            membersView.MoveCurrentToPosition(membersView.CurrentPosition);
            if (membersView.IsEmpty)
            {
                grdData.Visibility = Visibility.Hidden;
                grdNodata.Visibility = Visibility.Visible;
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Member newMember = new Member();
            MembersRepository.Add(newMember);
            membersView.MoveCurrentToLast();

        }
    }
}
