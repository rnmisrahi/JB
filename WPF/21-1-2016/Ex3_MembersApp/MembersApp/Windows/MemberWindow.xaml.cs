using MembersApp.Model;
using System;
using System.Collections.Generic;
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
        int current = 0;
        public MemberWindow()
        {
            InitializeComponent();
            DataContext = MembersRepository.GetAll()[current];
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (current < MembersRepository.GetAll().Count - 1) 
            {
                current++;
                DataContext = MembersRepository.GetAll()[current];
            }
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (current >0)
            {
                current--;
                DataContext = MembersRepository.GetAll()[current];
            }
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            current = 0;
            DataContext = MembersRepository.GetAll()[current];
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            current = MembersRepository.GetAll().Count - 1;
            DataContext = MembersRepository.GetAll()[current];
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MembersRepository.Delete(current);
            if (current + 1 <= MembersRepository.GetAll().Count - 1)
            {
                DataContext = MembersRepository.GetAll()[current];
            }
            else if (MembersRepository.GetAll().Count > 0)
            {
                current = MembersRepository.GetAll().Count - 1;
                DataContext = MembersRepository.GetAll()[current];
            }
            else
            {
                grdData.Visibility = Visibility.Hidden;
                grdNodata.Visibility = Visibility.Visible;
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Member newMember = new Member();
            MembersRepository.Add(newMember);
            current = MembersRepository.GetAll().Count - 1;
            DataContext = newMember;
        }
    }
}
