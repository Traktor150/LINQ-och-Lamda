using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsForm2._0
{
    public partial class Form1 : Form
    {
        List<Car> Cars;
        public Form1()
        {
            InitializeComponent();

            // Hindra att det kommer in otilåtna tecken
            txb_Id.KeyPress += new KeyPressEventHandler(KeyPress_OnlyNumber);
            txb_EditPrise.KeyPress += new KeyPressEventHandler(KeyPress_OnlyNumber);
            txb_EditKm.KeyPress += new KeyPressEventHandler(KeyPress_OnlyNumber);
            txb_AddId.KeyPress += new KeyPressEventHandler(KeyPress_OnlyNumber);
            txb_AddKm.KeyPress += new KeyPressEventHandler(KeyPress_OnlyNumber);
            txb_AddPrice.KeyPress += new KeyPressEventHandler(KeyPress_OnlyNumber);
            txb_AddYear.KeyPress += new KeyPressEventHandler(KeyPress_OnlyNumber);

            // Sätter in data
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

            // Skriver ut Visar data
            Update_lists();

            // där mer data ska visas 
            lbl_Facts.Text = "Fakta för markerad bil:";
            lbl_Id.Text = "Id för bilen är: ";
            lbl_Make.Text = "Tillverkare på bilen: ";
            lbl_Model.Text = "Modellen är: ";
            lbl_Color.Text = "Färjen på bilen är: ";
            lbl_Km.Text = "Bilen har kört: ";
            lbl_Price.Text = "Priset är: ";
            lbl_Year.Text = "Bilen bygdes år: ";

            // Komboboxen
            cmb_Chose.Text = "Välg färj";



            // Ändra Data 
            lbl_CarEdit.Text = "Redigera bilfakta";
            lbl_EditId.Text = "Ange Id på bil som ändras:";
            lbl_EditPrice.Text = "Ändra priset till:";
            lbl_EditKm.Text = "Ändra sträckan till:";
            btn_Edit.Text = "Ändra val";
            btn_SaveEdit.Text = "Spara";
            txb_EditPrise.Enabled = false;
            txb_EditKm.Enabled = false;


            // Lägga till en bil
            lbl_AddCar.Text = "Legg till en bil";
            lbl_AddId.Text = "Id:";
            lbl_AddMake.Text = "Maker";
            lbl_AddModel.Text = "Modle:";
            lbl_AddColor.Text = "Färj:";
            lbl_AddKm.Text = "Km:";
            lbl_AddPrice.Text = "Pris:";
            lbl_AddYear.Text = "År:";
            btn_AddCar.Text = "Lägg till";


            // Ta bort en bil
            lbl_RemoveCar.Text = "Ta bort en bil";
            lbl_RemoveId.Text = "Id:";
            btn_RemoveCar.Text = "Ta bort";

        }

        public void Update_lists()
        {
            lib_AllCars.Items.Clear();
            foreach (var fiskmas in Cars.OrderBy(x => x.Make).ThenBy(x => x.Model))
            {
                lib_AllCars.Items.Add(fiskmas);
            }

            cmb_Chose.Items.Clear();
            foreach (var Color in Cars.Select(x => x.Color).Distinct())
            {
                cmb_Chose.Items.Add(Color);
            }
        }


        private void lib_AllCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox myListOfCars = sender as ListBox;

            Car mySelektedCar = myListOfCars.SelectedItem as Car;

            lbl_Id.Text = $"Id för bilen är: {mySelektedCar.Id}";
            lbl_Make.Text = $"Tillverkare på bilen: {mySelektedCar.Make}";
            lbl_Model.Text = $"Modellen är: {mySelektedCar.Model}";
            lbl_Color.Text = $"Färjen på bilen är: {mySelektedCar.Color}";
            lbl_Km.Text = $"Bilen har kört: {mySelektedCar.Km} km";
            lbl_Price.Text = $"Priset är: {mySelektedCar.Price}";
            lbl_Year.Text = $"Bilen bygdes år: {mySelektedCar.Year}";
        }

        private void cmb_Chose_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox myCombo = sender as ComboBox;

            string myComboCar = myCombo.SelectedItem as string;

            lib_ShowCarsOfColor.Items.Clear();

            foreach (var Car in Cars.OrderBy(x => x.Make).ThenBy(x => x.Model))
            {
                if (Car.Color == myComboCar)
                {
                    lib_ShowCarsOfColor.Items.Add(Car);
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txb_Id.Text == "")
            {
                txb_Id.Focus();
            }
            else
            {
                txb_EditPrise.Enabled = true;
                txb_EditKm.Enabled = true;
                txb_EditPrise.Clear();
                txb_EditKm.Clear();
            }
        }

        private void btn_SaveEdit_Click(object sender, EventArgs e)
        {


            if (txb_Id.Text == "")
            {
                txb_Id.Focus();
            }

            else
            {
                if (Cars.Select(x => x.Id).Contains(int.Parse(txb_Id.Text)))
                {
                    Car EditCar = new Car();
                    EditCar = Cars.Find(x => x.Id == int.Parse(txb_Id.Text));

                    if (txb_EditPrise.Text != "")
                    {
                        EditCar.Price = int.Parse(txb_EditPrise.Text);
                    }

                    if (txb_EditKm.Text != "")
                    {
                        EditCar.Km = int.Parse(txb_EditKm.Text);
                    }

                    txb_EditPrise.Enabled = false;
                    txb_EditKm.Enabled = false;
                }
                else
                {
                    txb_Id.Focus();
                }
            }
        }

        private void KeyPress_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if ((short)e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_AddCar_Click(object sender, EventArgs e)
        {
            Cars.Add(new Car()
            {
                Id = Cars.Max(x => x.Id) + 1,
                Make = txb_AddMake.Text,
                Model = txb_AddModel.Text,
                Color = txb_AddColor.Text,
                Km = int.Parse(txb_AddKm.Text),
                Price = int.Parse(txb_AddPrice.Text),
                Year = int.Parse(txb_AddYear.Text)
            });

            txb_AddId.Clear();
            txb_AddMake.Clear();
            txb_AddModel.Clear();
            txb_AddColor.Clear();
            txb_AddKm.Clear();
            txb_AddPrice.Clear();
            txb_AddYear.Clear();

            Update_lists();
        }

        private void btn_RemoveCar_Click(object sender, EventArgs e)
        {
            Cars.RemoveAt(Cars.FindIndex(x => x.Id == int.Parse(txb_RemoveId.Text)));
            txb_RemoveId.Clear();

            Update_lists();
        }

        
    }
}
