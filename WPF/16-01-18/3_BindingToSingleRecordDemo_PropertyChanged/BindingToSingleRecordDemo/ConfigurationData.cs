using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToSingleRecordDemo
{
    public class ConfigurationData : INotifyPropertyChanged
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Title"));
            }
        }

        private int _itemsInWindow;

        public int ItemsInWindow
        {
            get { return _itemsInWindow; }
            set
            {
                _itemsInWindow = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("ItemsInWindow"));
            }
        }

        private bool _isUppercase;

        public bool IsUppercase
        {
            get { return _isUppercase; }
            set
            {
                _isUppercase = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("IsUppercase"));
            }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Color"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return string.Format(
                "Title={0}\n" +
                "ItemsInWindow={1}\n" +
                "IsUppercase={2}\n" +
                "Color={3}\n"
                , Title, ItemsInWindow, IsUppercase, Color);
        }
    }
}
