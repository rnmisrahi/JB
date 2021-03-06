﻿using MembersApp.Model;
using MembersApp.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MembersApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //ICollectionView v1 = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());
            //ICollectionView v2 = CollectionViewSource.GetDefaultView(MembersRepository.GetAll());

            MemberWindow mw = new MemberWindow();
            MembersViewModel mvm = new MembersViewModel();
            mw.DataContext = mvm;
            mw.grdData.DataContext= mvm.Members;
            mw.Show();
        }
    }
}
