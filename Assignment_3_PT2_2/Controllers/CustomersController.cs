using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Assignment_3_PT2_2.Controllers
{
    public class CustomersController : Controller
    {
        DataProvider dp = new DataProvider();
        public IActionResult Show()
        {
            List<Customers> customers = new List<Customers>();
            List<String> customersCode = new List<string>();
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Customers"))
            {
                
                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    string CustomerName = dr.GetString(1);
                    bool Gender = dr.GetBoolean(2);
                    string Address = dr.GetString(3);
                    DateTime DOB = dr.GetDateTime(4);
                    Customers c = new Customers(CustomerCode,CustomerName,Gender,Address,DOB);
                    customers.Add(c);
                    customersCode.Add(CustomerCode);
                }
         
            }
                ViewBag.customers = customers;
                ViewBag.code = customersCode;
                return View();
        }

        [HttpPost]
        public IActionResult Show(Customers model)
        {
            List<Customers> customers = new List<Customers>();
            List<String> customersCode = new List<string>();
            String customerCode = model.CustomerCode;
            String query = "SELECT * FROM Customers WHERE CustomerCode = @code";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@code",model.CustomerCode)
            };
            using (IDataReader dr = dp.executeQuery2(query,parameters))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    string CustomerName = dr.GetString(1);
                    bool Gender = dr.GetBoolean(2);
                    string Address = dr.GetString(3);
                    DateTime DOB = dr.GetDateTime(4);
                    Customers c = new Customers(CustomerCode, CustomerName, Gender, Address, DOB);
                    customers.Add(c);
                    customersCode.Add(CustomerCode);
                }

            }
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Customers"))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    customersCode.Add(CustomerCode);
                }

            }
            ViewBag.customers = customers;
            ViewBag.code = customersCode;
            ViewBag.selected = customerCode;
            return View();
        }
        public IActionResult Reset()
        {
            return RedirectToAction("Show");
        }
        public IActionResult ShowFilter(List<Customers> products)
        {
            List<String> customersCode = new List<string>();
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Customers"))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    customersCode.Add(CustomerCode);
                }

            }
            ViewBag.code = customersCode;
            ViewBag.Products = products;
            return View();
        }
        //FilterByName
        public IActionResult FilterByName(Customers model)
        {
            List<Customers> customers = new List<Customers>();
            List<String> customersCode = new List<string>();
            String customerCode = model.CustomerCode;
            String query = "SELECT * FROM Customers WHERE CustomerName like @name";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name","%"+model.CustomerName+"%")
            };
            using (IDataReader dr = dp.executeQuery2(query, parameters))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    string CustomerName = dr.GetString(1);
                    bool Gender = dr.GetBoolean(2);
                    string Address = dr.GetString(3);
                    DateTime DOB = dr.GetDateTime(4);
                    Customers c = new Customers(CustomerCode, CustomerName, Gender, Address, DOB);
                    customers.Add(c);
                    customersCode.Add(CustomerCode);
                }

            }
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Customers"))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    customersCode.Add(CustomerCode);
                }

            }
            ViewBag.customers = customers;
            ViewBag.code = customersCode;
            ViewBag.selected = customerCode;
            return View("ShowFilter");
        }

        //FilterByGender
        public IActionResult FilterByGender(Customers model)
        {
            List<Customers> customers = new List<Customers>();
            List<String> customersCode = new List<string>();
            String customerCode = model.CustomerCode;
            String query = "SELECT * FROM Customers WHERE Gender = @gender";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@gender",model.Gender)
            };
            using (IDataReader dr = dp.executeQuery2(query, parameters))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    string CustomerName = dr.GetString(1);
                    bool Gender = dr.GetBoolean(2); 
                    string Address = dr.GetString(3);
                    DateTime DOB = dr.GetDateTime(4);
                    Customers c = new Customers(CustomerCode, CustomerName, Gender, Address, DOB);
                    customers.Add(c);
                    customersCode.Add(CustomerCode);
                }

            }
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Customers"))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    customersCode.Add(CustomerCode);
                }

            }
            ViewBag.customers = customers;
            ViewBag.code = customersCode;
            ViewBag.selected = customerCode;
            return View("ShowFilter");
        }
        public IActionResult FilterByAddress(Customers model)
        {
            List<Customers> customers = new List<Customers>();
            List<String> customersCode = new List<string>();
            String customerCode = model.CustomerCode;
            String query = "SELECT * FROM Customers WHERE Address like @address";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@address","%"+model.Address+"%")
            };
            using (IDataReader dr = dp.executeQuery2(query, parameters))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    string CustomerName = dr.GetString(1);
                    bool Gender = dr.GetBoolean(2);
                    string Address = dr.GetString(3);
                    DateTime DOB = dr.GetDateTime(4);
                    Customers c = new Customers(CustomerCode, CustomerName, Gender, Address, DOB);
                    customers.Add(c);
                    customersCode.Add(CustomerCode);
                }

            }
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Customers"))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    customersCode.Add(CustomerCode);
                }

            }
            ViewBag.customers = customers;
            ViewBag.code = customersCode;
            ViewBag.selected = customerCode;
            return View("ShowFilter");
        }
        public IActionResult FilterByDOB(Customers model)
        {
            List<Customers> customers = new List<Customers>();
            List<String> customersCode = new List<string>();
            String customerCode = model.CustomerCode;
            String query = "SELECT * FROM Customers WHERE DOB = @dob";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dob",model.DOB)
            };
            using (IDataReader dr = dp.executeQuery2(query, parameters))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    string CustomerName = dr.GetString(1);
                    bool Gender = dr.GetBoolean(2);
                    string Address = dr.GetString(3);
                    DateTime DOB = dr.GetDateTime(4);
                    Customers c = new Customers(CustomerCode, CustomerName, Gender, Address, DOB);
                    customers.Add(c);
                    customersCode.Add(CustomerCode);
                }

            }
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Customers"))
            {

                while (dr.Read())
                {
                    string CustomerCode = dr.GetString(0);
                    customersCode.Add(CustomerCode);
                }

            }
            ViewBag.customers = customers;
            ViewBag.code = customersCode;
            ViewBag.selected = customerCode;
            return View("ShowFilter");
        }
    }
}
