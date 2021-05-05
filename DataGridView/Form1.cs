using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form   
    {
        public List<Person> People { get; set; }
        public Form1()
        {
            People = GetPeople();
            InitializeComponent();
        }
        
        private List<Person> GetPeople()
        {
            var list = new List<Person>();
            list.Add(new Person() { 
                PersonID = 1,
                Name = "name1",
                Surname = "surname1"
            });

            list.Add(new Person()
            {
                PersonID = 2,
                Name = "name2",
                Surname = "surname2"
            });

            list.Add(new Person()
            {
                PersonID = 3,
                Name = "name3",
                Surname = "surname3"
            });
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var people = this.People;
            dataGridView1.DataSource = people;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
