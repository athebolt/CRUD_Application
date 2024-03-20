using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw03_AlexanderThebolt
{
    public partial class Details : Form
    {
        private Form1 form1;

        private int index;

        TxtFileCRUD file = new TxtFileCRUD();

        public Details()
        {
            InitializeComponent();

        }

        public Details(Form1 f1, string vin, string make, string model, string color, string year, int i)
        {
            InitializeComponent();

            form1 = f1;

            //Read car info
            tb_d_vin.Text = vin;
            tb_d_make.Text = make;
            tb_d_model.Text = model;
            tb_d_color.Text = color;
            tb_d_year.Text = year;

            index = i;
        }

        private void btn_d_update_Click(object sender, EventArgs e)
        {
            if(!tb_d_vin.Text.ToString().Equals("") && !tb_d_make.Text.ToString().Equals("") && !tb_d_model.Text.ToString().Equals("") && !tb_d_color.Text.ToString().Equals("") && !tb_d_year.Text.ToString().Equals(""))
            {
                Car car = new Car(tb_d_vin.Text.ToString(), tb_d_make.Text.ToString(), tb_d_model.Text.ToString(), tb_d_color.Text.ToString(), tb_d_year.Text.ToString());

                file.UpdateCar(index, car);

                this.Close();

                form1.loadListBox();

                form1.Show();
            }
            else
            {
                lbl_d_error.Show();
            }
        }

        private void btn_d_delete_Click(object sender, EventArgs e)
        {
            //Delete car
            file.DeleteCar(index);

            this.Close();

            form1.loadListBox();

            form1.Show();
        }
    }
}
