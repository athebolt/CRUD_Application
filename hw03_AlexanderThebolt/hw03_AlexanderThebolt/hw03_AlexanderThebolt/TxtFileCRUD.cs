using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;
using System.Drawing.Drawing2D;

namespace hw03_AlexanderThebolt
{
    internal class TxtFileCRUD
    {
        private string filePath = "../../Resources/CarInfo.txt";

        public List<Car> GetCarInfo()
        {
            List<Car> listCars = new List<Car>();

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(filePath);
                //Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading file: " + e.Message);
            }

            string vin;
            string make;
            string model;
            string color;
            string year;

            Car car;

            int delimPos;
            char delim = ',';

            String line = reader.ReadLine();

            while (line != null)
            {
                //Find delim pos
                delimPos = line.IndexOf(delim);
                
                //vin is the first part of the line
                vin = line.Substring(0, delimPos);

                //change line to be the information that is after the first comma
                line = line.Substring(delimPos + 1);

                delimPos = line.IndexOf(delim);

                make = line.Substring(0, delimPos);

                line = line.Substring(delimPos + 1);

                delimPos = line.IndexOf(delim);

                model = line.Substring(0, delimPos);

                line = line.Substring(delimPos + 1);

                delimPos = line.IndexOf(delim);

                color = line.Substring(0, delimPos);

                line = line.Substring(delimPos + 1);

                //year is all that is left in the line
                year = line;
                
                //create a new instance of a car
                car = new Car(vin, make, model, color, year);

                //add the car to the list
                listCars.Add(car);

                //read the next line of text
                line = reader.ReadLine();
            }

            reader.Close();

            return listCars;
        }

        //this function is pretty straightforward and easy to read
        public void CreateCar(Car car)
        {
            //appending to the existing file
            StreamWriter writer = new StreamWriter(filePath, true);

            //testing
            //file.WriteLine("test");

            writer.WriteLine(car.getVIN() + "," + car.getMake() + "," + car.getModel() + "," + car.getColor() + "," + car.getYear());

            writer.Close();
        }

        //basically what i am doing in this function is reading all the lines of the txt file except for the one im deleting (using its position in the file)
        //then I overwrite the txt using the lines I read
        public void DeleteCar(int index)
        {
            //create a list called lines (its going to hold all the lines I want to keep in the file)
            List<String> lines = new List<String>();

            //We are reading the text file
            StreamReader reader = new StreamReader(filePath);

            //read the first line
            String line = reader.ReadLine();

            //position starting at 0
            int pos = 0;

            //read all the lines in the txt file and store them in the list...
            while (line != null)
            {
                //...except for the one im deleting
                if(pos != index)
                {
                    lines.Add(line);
                }

                line = reader.ReadLine();
                
                pos++;
            }

            reader.Close();

            //testing
            //for (int test = 0; test < lines.Count; test++)
            //{
            //    Console.WriteLine(lines[test]);
            //}

            //now we are writing to the text file
            StreamWriter writer = new StreamWriter(filePath);

            //for every line in lines, write it into the text file
            for (int i = 0; i < lines.Count; i++)
            {
                writer.WriteLine(lines[i]);
            }

            writer.Close();
        }

        //reading the text file, chaning the updated line of code, overwritting the text file
        public void UpdateCar(int index, Car car)
        {
            List<String> lines = new List<String>();

            //reading the text file
            StreamReader reader = new StreamReader(filePath);

            String line = reader.ReadLine();

            //read all the lines in the txt file
            while(line != null)
            {
                lines.Add(line);

                line = reader.ReadLine();
            }

            reader.Close();

            //update line
            lines[index] = car.getVIN() + "," + car.getMake() + "," + car.getModel() + "," + car.getColor() + "," + car.getYear();

            //rewrite the whole text file
            StreamWriter writer = new StreamWriter(filePath);

            for (int i = 0; i < lines.Count; i++)
            {
                writer.WriteLine(lines[i]);
            }

            writer.Close();
        }
    }
}
