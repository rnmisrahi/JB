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
            membersView = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
            //Binding binding = new Binding();
            //binding.Source = chkHasRecords;
            //binding.Path = new PropertyPath("membersView.IsEmpty");
            //chkHasRecords.SetBinding(CheckBox.IsCheckedProperty, binding);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MembersRepository.Delete(membersView.CurrentPosition);
            MembersViewModel mvm = new MembersViewModel();
            mvm.PositionAfterDelete();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Member> members = MembersRepository.GetAll();
            members[0].Name = "Something else";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
