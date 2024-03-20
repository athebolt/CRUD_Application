using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw03_AlexanderThebolt
{
    internal class Car
    {
        //Variable
        private string vin;
        private string make;
        private string model;
        private string color;
        private string year;

        //Constructors
        public Car()
        {

        }

        public Car (string vin, string make, string model, string color, string year)
        {
            this.vin = vin;
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        //Setters
        public void setVIN(string vin)
        {
            this.vin = vin;
        }

        public void setMake(string make)
        { 
            this.make = make;
        }

        public void setModel(string model) 
        {
            this.model = model;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void setYear(string year)
        {
            this.year = year;
        }

        //Getters
        public string getVIN()
        {
            return vin;
        }

        public string getMake()
        {
            return make;
        }

        public string getModel()
        {
            return model;
        }

        public string getColor()
        {
            return color;
        }

        public string getYear()
        {
            return year;
        }

    }
}
