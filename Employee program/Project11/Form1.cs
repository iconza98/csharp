using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Project11
{

    public partial class Form1 : Form
    {
        const int SIZE = 10;

        Employee[] employees = new Employee[SIZE];
        StreamReader data = null;
        string inputstring;
        int count = 0;
        int i = 0;
        int j = 1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ikani Samani\nCS1400-003\nProject 11");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c://";
            openFileDialog1.Filter = "text files(*.txt)|*txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    data = new StreamReader(myStream);
                }
            }


            do
            {
                inputstring = data.ReadLine();
                if (inputstring != null)
                {
                    int empNum = int.Parse(inputstring);
                    string name = data.ReadLine();
                    string adress = data.ReadLine();
                    string info = data.ReadLine();
                    string[] pay = info.Split();
                    double wage = double.Parse(pay[0]);
                    double hours = double.Parse(pay[1]); 
                    employees[i] = new Employee(empNum, name, adress, wage, hours);
                        i++;
                        
                  
                }
            } while (inputstring != null);

           count = i;

            txtBox_name.Text = employees[0].empName;
            txtBox_adress.Text = employees[0].employeeAdress;
            txtBox_netPay.Text = string.Format("{0:c}", employees[0].CalcSalary());



        }

        private void btn_next_Click(object sender, EventArgs e)
        {


            txtBox_name.Text = employees[j].empName;
               txtBox_adress.Text = employees[j].employeeAdress;
                txtBox_netPay.Text = string.Format("{0:c}", employees[j].CalcSalary());
                j++;
                if (j == count)
                {
                    j = 0;
                    SystemSounds.Beep.Play();
                    MessageBox.Show("The file has reached the end. Press 'Next' to start again at the begining");
                }
   

        }

        private void txtBox_netPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
