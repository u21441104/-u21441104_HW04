using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;
using u21441104_HW_04.ViewModels;

namespace u21441104_HW_04.Controllers
{
    public class LoadProfileController : Controller
    {
        // GET: LoadProfile
        [HttpGet]
        public ActionResult Index()
        {
            dynamic myModel = new ExpandoObject();
            myModel.Food = GetUserFoodData();
            myModel.Water = GetUserWaterData();
            myModel.User = GetUserData();

            return View(myModel);
        }

        [HttpPost]
        public ActionResult index(string numID, string txtPassword)
        {
            List<LoadModelView> userStored = GetUserData();

            bool success = false;

            for (int i = 0; i < userStored.Count; i++)
            {
                if (numID == userStored[i].NumID && txtPassword == userStored[i].Password)
                {
                    ViewBag.Test = "Welcome " + numID;
                    success = true;
                }
            }

            if (success == false)
            {
                MessageBox.Show("Incorrect Username or Passowrd");
                ViewBag.Pass = "false";
            }
            else 
            {
                ViewBag.Pass = "true";
            } 

            return View();
        }


        private List<LoadModelView> GetUserData()
        {
            string[] objItems = returnUserValues();
            List<LoadModelView> users = new List<LoadModelView>();

            for (int i = 0; i < objItems.Length; i = i++)
            {
                LoadModelView obj = null;
                try
                {
                    string id = objItems[i];
                    i++;
                    string password = objItems[i];

                    obj = new LoadModelView(id,null,null,password);
                    users.Add(obj);
                }
                catch (Exception r) { }
            }

            return users;
        }

        private List<FoodViewModel> GetUserFoodData()
        {
            
            string[] objItems = returnFoodValues();
            List<FoodViewModel> users = new List<FoodViewModel>();

            for (int i = 0; i < objItems.Length; i++)
            {
                FoodViewModel obj = null;
                try
                {
                    string id = objItems[i];
                    i++;
                    string quantity = objItems[i];
                    i++;
                    string fName = objItems[i];
                    i++;
                    string lName = objItems[i];
                    i++;
                    string type = objItems[i];

                    obj = new FoodViewModel(id, quantity, fName, lName, type);
                }
                catch (Exception y) { }
                users.Add(obj);
            }

            return users;
        }

        private List<WaterViewModel> GetUserWaterData()
        {
            string[] objItems = returnWaterValues();
            List<WaterViewModel> users = new List<WaterViewModel>();

            for (int i = 0; i < objItems.Length; i = i + 5)
            {
                string id = objItems[i];
                string quantity = objItems[i + 1];
                string fName = objItems[i + 2];
                string lName = objItems[i + 3];
                string type = objItems[i + 4];

                WaterViewModel obj = new WaterViewModel(id, quantity, fName, lName, type);
                users.Add(obj);
            }

            return users;
        }

        private string[] returnFoodValues()
        {
            StreamReader streamReader = null;
            try { streamReader = new StreamReader(@"C:\Users\tyron\source\repos\u21441104_HW_04\u21441104_HW_04\App_Data\FoodDonations.txt"); }
            catch (Exception) { throw; }
            string readContents = streamReader.ReadLine();
            string [] newItems = null;
            string test;


            
            newItems = readContents.Split(':');
            test = newItems[0];


            for (int i = 0; i +1 < newItems.Length; i++)
            {
                test = test + newItems[i + 1] + ",";
            }

            string[] ArrItems = test.Split(',');

            for (int i = 0; i < ArrItems.Length; i++)
            {
                if(ArrItems[i] == "")
                {
                    int indexToRemove = i;
                    ArrItems = ArrItems.Where((source, index) => index != indexToRemove).ToArray();
                    i--;

                }
            }

            return ArrItems;
        }

        private string[] returnWaterValues()
        {
            StreamReader streamReader = null;
            try { streamReader = new StreamReader(@"C:\Users\tyron\source\repos\u21441104_HW_04\u21441104_HW_04\App_Data\WaterDonations.txt"); }
            catch (Exception) { throw; }
            string readContents = streamReader.ReadLine();
            string[] newItems = null;
            string test;



            newItems = readContents.Split(':');
            test = newItems[0];


            for (int i = 0; i + 1 < newItems.Length; i++)
            {
                test = test + newItems[i + 1] + ",";
            }

            string[] ArrItems = test.Split(',');

            for (int i = 0; i < ArrItems.Length; i++)
            {
                if (ArrItems[i] == "")
                {
                    int indexToRemove = i;
                    ArrItems = ArrItems.Where((source, index) => index != indexToRemove).ToArray();
                    i--;

                }
            }

            return ArrItems;
        }

        private string[] returnUserValues()
        {
            StreamReader streamReader = null;
            try { streamReader = new StreamReader(@"C:\Users\tyron\source\repos\u21441104_HW_04\u21441104_HW_04\App_Data\Logins.txt"); }
            catch (Exception) { throw; }
            string readContents = streamReader.ReadLine();
            string[] newItems = null;
            string test;



            newItems = readContents.Split(':');
            test = newItems[0];


            for (int i = 0; i + 1 < newItems.Length; i++)
            {
                test = test + newItems[i + 1] + ",";
            }

            string[] ArrItems = test.Split(',');

            for (int i = 0; i < ArrItems.Length; i++)
            {
                if (ArrItems[i] == "")
                {
                    int indexToRemove = i;
                    ArrItems = ArrItems.Where((source, index) => index != indexToRemove).ToArray();
                    i--;

                }
            }

            return ArrItems;
        }
    }
}