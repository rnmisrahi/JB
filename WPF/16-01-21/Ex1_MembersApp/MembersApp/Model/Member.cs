using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersApp.Model
{
    public class Member : INotifyPropertyChanged
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                Notify("ID");
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                Notify("Name");
            }
        }

        private int _cityID;

        public int CityID
        {
            get { return _cityID; }
            set
            {
                _cityID = value;
                Notify("CityID");
            }
        }

        private bool _isActive;

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        private double _amount;

        public double Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                Notify("Amount");
            }
        }


        public override string ToString()
        {
            return string.Format("{0}: {1}", ID, Name);
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
