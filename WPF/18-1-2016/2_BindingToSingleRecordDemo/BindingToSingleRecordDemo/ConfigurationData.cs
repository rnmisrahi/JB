using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToSingleRecordDemo
{
    public class ConfigurationData
    {
        public string Title { get; set; }
        public int ItemsInWindow { get; set; }
        public bool  IsUppercase { get; set; }
        public string Color { get; set; }

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
