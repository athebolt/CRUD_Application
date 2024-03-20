using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw03_AlexanderThebolt
{
    public partial class Add : Form
    {
        private Form1 form1;

        private TxtFileCRUD file = new TxtFileCRUD();

        public Add()
        {
            InitializeComponent();
        }

        public Add(Form1 f1)
        {
            InitializeComponent();

            form1 = f1;
        }

        private void btn_a_back_Click(object sender, EventArgs e)
        {
            this.Close();

            form1.Show();
        }

        private void btn_a_add_Click(object sender, EventArgs e)
        {
            //making sure all fields are filled
            if(!tb_a_vin.Text.ToString().Equals("") && !tb_a_make.Text.ToString().Equals("") && !tb_a_model.Text.ToString().Equals("") && !tb_a_color.Text.ToString().Equals("") && !tb_a_year.Text.ToString().Equals(""))
            {
                //Create new car and add to txt file

                Car car = new Car(tb_a_vin.Text.ToString(), tb_a_make.Text.ToString(), tb_a_model.Text.ToString(), tb_a_color.Text.ToString(), tb_a_year.Text.ToString());

                file.CreateCar(car);

                this.Close();

                form1.loadListBox();

                form1.Show();
            }
            else
            {
                lbl_a_error.Show();
            }
        }
    }
}
