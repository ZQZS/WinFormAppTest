using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<Person> personList;
        private void btnOK_Click(object sender, EventArgs e)
        {
            personList = new List<Person>() {
                new Person(){Name="qwy",Age=20,Sex="boy",Id=0},
                new Person(){Name="qwy2",Age=21,Sex="boy",Id=1},
                new Person(){Name="qwy3",Age=22,Sex="boy",Id=2},
                new Person(){Name="qwy4",Age=23,Sex="boy",Id=3},
                new Person(){Name="qwy5",Age=24,Sex="boy",Id=4},
            };
            Person person = new Person();
            person.Name = "qqq";
            person.Age = 25;
            person.Id = 5;
            personList.Add(person);
            dgvPerson.DataSource = personList;
        }

        private void dgvPerson_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (personList!=null&&personList[rowIndex] != null)
            {
                dgvPerson.DataSource = new List<Person>();
                personList.RemoveAt(rowIndex);
                dgvPerson.DataSource = personList;
            }
        }
    }
}
