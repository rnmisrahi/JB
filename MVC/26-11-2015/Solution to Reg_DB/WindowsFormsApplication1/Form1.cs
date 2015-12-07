using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.ModelConfiguration.Mappers;
using System.Data.Entity.ModelConfiguration;
using AutoMapper;

namespace SolutionToReg_DB
{
    public partial class Form1 : Form
    {
        private Class1 class1 = new Class1 { Id = 1, Name = "Ruben", Lastname = "Misrahi", Address = "Beitar" };
        private Class2 class2 = new Class2();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            class1.Name = textBox2.Text;
        }

        private void btnDisplay1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(class1.ToString());
        }

        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(class2.ToString());
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            Mapper.CreateMap<Class1, Class2>();
            //var c = new Class2();
            class2 = Mapper.Map<Class2>(class1);
        }
    }
}
