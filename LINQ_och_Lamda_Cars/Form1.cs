using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_och_Lamda_Cars
{
    public partial class Car_Tracker : Form
    {
        List<Car> Cars;


        public Car_Tracker()
        {
            InitializeComponent();

            btn_AmountCollor.Text = "Amount of Red cars.";
            btn_Age.Text = "Amount of cars older than 2003.";
            btn_GrayVolvo.Text = "Amount of Grey Volvos.";
            btn_DriveDistanse.Text = "Snitsträckan för BMW bilar.";
            btn_MostExpensive.Text = "The most expensive car is.";

            Cars = new List<Car>();

            Cars.Add(new Car() { Id = 1, Make = "Volvo", Model = "V70", Color = "White", Km = 1292, Price = 3465, Year = 1998 });
            Cars.Add(new Car() { Id = 31, Make = "Skoda", Model = "Fabia", Color = "Red", Km = 1292, Price = 76556, Year = 2001 });
            Cars.Add(new Car() { Id = 14, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 432, Price = 32001, Year = 2003 });
            Cars.Add(new Car() { Id = 4, Make = "Volvo", Model = "V70", Color = "Red", Km = 1223492, Price = 24512, Year = 1998 });
            Cars.Add(new Car() { Id = 23, Make = "BMW", Model = "735", Color = "Black", Km = 435, Price = 234512, Year = 1999 });
            Cars.Add(new Car() { Id = 234, Make = "Audi", Model = "Q3", Color = "Blue", Km = 345, Price = 334552, Year = 2010 });
            Cars.Add(new Car() { Id = 451, Make = "Volvo", Model = "V40", Color = "Grey", Km = 235235, Price = 535512, Year = 2008 });
            Cars.Add(new Car() { Id = 651, Make = "Volvo", Model = "XC90", Color = "White", Km = 345345, Price = 34510, Year = 2011 });
            Cars.Add(new Car() { Id = 91, Make = "Volvo", Model = "V70", Color = "Red", Km = 345, Price = 4512, Year = 1997 });
            Cars.Add(new Car() { Id = 8001, Make = "Audi", Model = "A3", Color = "White", Km = 123492, Price = 87500, Year = 2001 });
            Cars.Add(new Car() { Id = 631, Make = "Audi", Model = "A8", Color = "Blue", Km = 55342, Price = 55400, Year = 2010 });
            Cars.Add(new Car() { Id = 51, Make = "Volvo", Model = "V40", Color = "Red", Km = 1692, Price = 3465, Year = 1999 });
            Cars.Add(new Car() { Id = 781, Make = "Skoda", Model = "Fabia", Color = "Blue", Km = 1792, Price = 56556, Year = 2000 });
            Cars.Add(new Car() { Id = 144, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 4382, Price = 25001, Year = 2004 });
            Cars.Add(new Car() { Id = 48, Make = "Volvo", Model = "V70", Color = "Red", Km = 12292, Price = 26512, Year = 1997 });
            Cars.Add(new Car() { Id = 912, Make = "BMW", Model = "735", Color = "Black", Km = 4395, Price = 134512, Year = 1960 });
            Cars.Add(new Car() { Id = 2344, Make = "Audi", Model = "Q3", Color = "Grey", Km = 3425, Price = 434552, Year = 2011 });
            Cars.Add(new Car() { Id = 4501, Make = "Volvo", Model = "V40", Color = "Grey", Km = 215235, Price = 435512, Year = 2007 });
            Cars.Add(new Car() { Id = 6051, Make = "Volvo", Model = "XC90", Color = "White", Km = 47345, Price = 134510, Year = 2012 });
            Cars.Add(new Car() { Id = 991, Make = "Volvo", Model = "V70", Color = "Red", Km = 3475, Price = 14512, Year = 1998 });
            Cars.Add(new Car() { Id = 801, Make = "Audi", Model = "A7", Color = "White", Km = 492, Price = 187500, Year = 2002 });
            Cars.Add(new Car() { Id = 6031, Make = "Audi", Model = "A6", Color = "Blue", Km = 553, Price = 55400, Year = 2011 });

            Cars = Cars.OrderBy(x => x.Make).ToList();


            foreach (var item in Cars)
            {
                lib_CarList.Items.Add($"{item.Make}\t{item.Model}\t{item.Year}");
            }

        }

        private void btn_AmountCollor_Click(object sender, EventArgs e)
        {
            int amount = Cars.Count(x => x.Color == "Red");
            lib_Kvitto.Items.Add($"You have {amount} Red cars.");
        }

        private void btn_Age_Click(object sender, EventArgs e)
        {
            int amount = Cars.Count(x => x.Year < 2003);
            lib_Kvitto.Items.Add($"You have {amount} cars that wher made before 2003.");
        }

        private void btn_GrayVolvo_Click(object sender, EventArgs e)
        {
            int amount = Cars.Count(x => x.Color == "Grey" && x.Make == "Volvo");
            lib_Kvitto.Items.Add($"You have {amount} Grey Volvos.");
        }

        private void btn_DriveDistanse_Click(object sender, EventArgs e)
        {
            try
            {
                int distanse = 0;
                int amount = 0;
                int average = 0;
                foreach (var item in Cars)
                {
                    if (item.Make == "BMW")
                    {
                        distanse += item.Km;
                        amount++;
                    }
                }

                average = distanse / amount;
                lib_Kvitto.Items.Add($"Average distance for BMW are {average}.");
            }
            catch (Exception)// Försök att hindra popp upp om dividering med noll (mislyckades). 
            {
                lib_Kvitto.Items.Add("You have no BMW to get data from.");
                throw;
            }
        }

        private void btn_MostExpensive_Click(object sender, EventArgs e)
        {
            int expensiveIndex = 0;
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[expensiveIndex].Price < Cars[i].Price)
                {
                    expensiveIndex = i;
                }
            }
            lib_Kvitto.Items.Add($"The moste expensive car is a {Cars[expensiveIndex].Make} {Cars[expensiveIndex].Model}, " +
                                 $"{Cars[expensiveIndex].Color} for {Cars[expensiveIndex].Price}kr.");
        }
    }


    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Km { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
    }
}
