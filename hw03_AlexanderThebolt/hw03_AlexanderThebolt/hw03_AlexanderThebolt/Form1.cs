//=============================================
//Name: Alexander Thebolt
//Date: 03-19-2024
//Desc: Car CRUD (Create, Read, Update, Delete)
//=============================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hw03_AlexanderThebolt
{
    public partial class Form1 : Form
    {
        private List<Car> listOfCars = new List<Car>();
        private TxtFileCRUD file = new TxtFileCRUD();

        public Form1()
        {
            InitializeComponent();

            loadListBox();
        }

        public void loadListBox()
        {
            listOfCars = file.GetCarInfo();

            lb_m_listCars.Items.Clear();

            for(int i = 0; i < listOfCars.Count; i++)
            {
                lb_m_listCars.Items.Add(listOfCars[i].getVIN());
            }
        }

        private void lb_m_listCars_DoubleClick(object sender, EventArgs e)
        {
            int index = lb_m_listCars.SelectedIndex;

            Car car = listOfCars[index];

            Details details = new Details(this, car.getVIN(), car.getMake(), car.getModel(), car.getColor(), car.getYear(), index);

            this.Hide();

            details.Show();
        }

        private void btn_m_addCar_Click(object sender, EventArgs e)
        {
            Add add = new Add(this);

            this.Hide();

            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadListBox();
        }
    }
}
