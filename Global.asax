<%@ Application Codebehind="Global.asax.cs" Inherits="oneSolutionForum.Web.MvcApplication" Language="C#" %>

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace CRUDADO
{
    public class EmpRepository : DbBase
    {
        //DbBase db = new DbBase();
        public SqlConnection con;
        public void connection()
        {
            string cnstr;
            cnstr = ConfigurationManager.ConnectionStrings["SalesERPDAL"].ToString();
            con = new SqlConnection(cnstr);
        }

        //public List<Employee> GetAll()
        //{
        //    connection();
        //    SqlCommand cmd = new SqlCommand("spEmployeeCRUD", con);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Action", "Get");
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    List<Employee> emp = new List<Employee>();
        //    con.Open();
        //    da.Fill(dt);
        //    con.Close();
        //    foreach(DataRow dr in dt.Rows)
        //    {
        //        emp.Add(
        //            new Employee
        //            {
        //                EmployeeId = Convert.ToInt32(dr["EmployeeId"]),
        //                FirstName = Convert.ToString(dr["FirstName"]),
        //                LastName = Convert.ToString(dr["LastName"]),
        //                Salary = Convert.ToInt32(dr["Salary"])                        
        //                }
        //            );
        //    }
        //    return emp;
        //}

        public List<Employee> GetAllWithBase()
        {
            var sqlParam = new List<Tuple<string, object>>();
            DataTable dtTemp = new DataTable();
            sqlParam.Add(new Tuple<string, object>("@Action", "Get"));
            dtTemp=RetriveRecordStoredProcedure("spEmployeeCRUD", sqlParam, dtTemp);
            List<Employee> emp = new List<Employee>();
            if(dtTemp.Rows.Count > 0)
            {
                foreach(DataRow dr in dtTemp.Rows) { 
                    emp.Add(new Employee
                    {
                        EmployeeId = Convert.ToInt32(dr["EmployeeId"]),
                        FirstName = Convert.ToString(dr["FirstName"]),
                        LastName = Convert.ToString(dr["LastName"]),
                        Salary = Convert.ToInt32(dr["Salary"])                        
                    });
                }
            }
            return emp;
        }


        //public bool AddEmployee(Employee e)
        //{
        //    connection();
        //    SqlCommand cmd = new SqlCommand("spEmployeeCRUD", con);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@EmployeeId", e.EmployeeId);
        //    cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
        //    cmd.Parameters.AddWithValue("@LastName", e.LastName);
        //    cmd.Parameters.AddWithValue("@Salary", e.Salary);
        //    cmd.Parameters.AddWithValue("@Gender", e.Gender);
        //    cmd.Parameters.AddWithValue("@Action", "InsertUpdate");
        //    con.Open();
        //    int a = cmd.ExecuteNonQuery();
        //    con.Close();
        //    if (a >= 1)
        //        return true;
        //    else
        //        return false;            
        //}

        public bool AddEmployeeWithBase(Employee e)
        {
            var sqlParam = new List<Tuple<string,object>>();
            sqlParam.Add(new Tuple<string,object>("@EmployeeId", e.EmployeeId));
            sqlParam.Add(new Tuple<string, object>("@FirstName", e.FirstName));
            sqlParam.Add(new Tuple<string, object>("@LastName", e.LastName));
            sqlParam.Add(new Tuple<string, object>("@Salary", e.Salary));
            sqlParam.Add(new Tuple<string, object>("@Gender", e.Gender));
            sqlParam.Add(new Tuple<string, object>("@Action", "InsertUpdate"));
            bool i = ExecuteProcedure("spEmployeeCRUD", sqlParam);
            if (i)
                return true;
            else
                return false;
        }

        //public bool UpdateEmployee(Employee e)
        //{
        //    connection();
        //    SqlCommand cmd = new SqlCommand("spEmployeeCRUD", con);
        //    cmd.CommandType = CommandType.StoredProcedure;            
        //    cmd.Parameters.AddWithValue("@EmployeeId", e.EmployeeId);
        //    cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
        //    cmd.Parameters.AddWithValue("@LastName", e.LastName);
        //    cmd.Parameters.AddWithValue("@Salary", e.Salary);
        //    cmd.Parameters.AddWithValue("@Action", "InsertUpdate");
        //    con.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();
        //    if (i >= 1)
        //        return true;
        //    else
        //        return false;
        //}

        public bool UpdateEmployeeWithBase(Employee e)
        {
            var SqlParam = new List<Tuple<string, object>>();
            SqlParam.Add(new Tuple<string, object>("@EmployeeId", e.EmployeeId));
            SqlParam.Add(new Tuple<string, object>("@FirstName", e.FirstName));
            SqlParam.Add(new Tuple<string, object>("@LastName", e.LastName));
            SqlParam.Add(new Tuple<string, object>("@Salary", e.Salary));
            SqlParam.Add(new Tuple<string, object>("@Action", "InsertUpdate"));
            bool i = ExecuteProcedure("spEmployeeCRUD",SqlParam);
            if (i)
                return true;
            else
                return false;
        }

        //public bool DeleteEmployee(int EmployeeId)
        //{
        //    connection();
        //    SqlCommand cmd = new SqlCommand("spEmployeeCRUD", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@EmployeeId",EmployeeId);
        //    cmd.Parameters.AddWithValue("@Action", "Delete");
        //    con.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();
        //    if (i >= 1)
        //        return true;
        //    else
        //        return false;
        //}

        public bool DeleteEmployeeWithBase(int EmployeeId)
        {
            var SqlParam = new List<Tuple<string, object>>();
            SqlParam.Add(new Tuple<string, object>("@EmployeeId", EmployeeId));           
            SqlParam.Add(new Tuple<string, object>("@Action", "Delete"));
            bool i = ExecuteProcedure("spEmployeeCRUD", SqlParam);
            if (i)
                return true;
            else
                return false;
        }
        public List<SelectListItem> EmployeeName()
        {
            //string sql = "select FirstName,EmployeeId from TblEmployee";
            List<SelectListItem> EmpName = new List<SelectListItem>();
            connection();
            SqlCommand cmd = new SqlCommand("spEmployeeList", con);
            //SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);      
            //cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            //using (SqlDataReader dr = cmd.ExecuteReader()) {    
            //    while (dr.Read())
            //    {
            //        EmpName.Add(new SelectListItem
            //        {
            //            Text = dr["FirstName"].ToString(),
            //            Value = dr["EmployeeId"].ToString(),
            //        });
            //    }
            //}
            foreach(DataRow dr in dt.Rows)
            {
                EmpName.Add(new SelectListItem
                {
                    Text = Convert.ToString(dr["FirstName"]),
                    Value = Convert.ToString(dr["EmployeeId"])
                });
            }
            con.Close();
            return EmpName;
        }        
    }
}
          
          
          
          
          
          
          using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;

namespace CRUDADO
{
    public class DbBase
    {
        SqlConnection con;
        public void Connection()
        {
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["SalesERPDAL"].ToString();
            con = new SqlConnection(connectionString);           
        }

        public bool ExecuteProcedure(string ProName, List<Tuple<string, object>> ParamList)
        {            
            int affectedRows;
            try
            {
                Connection();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand(ProName,con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (ParamList != null || ParamList.Count > 0)
                {
                    SqlParameter SP;
                    foreach(Tuple<string,object> tuple in ParamList)
                    {
                        SP = new SqlParameter();
                        cmd.Parameters.AddWithValue(SP.ParameterName = tuple.Item1, SP.Value = tuple.Item2);
                    }
                }                
                affectedRows = cmd.ExecuteNonQuery();
                con.Close();                
                if(affectedRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }            
        }
        
        public DataTable RetriveRecordStoredProcedure(string ProName, List<Tuple<string, object>> ParamList, DataTable dt)
        {
            DataTable dtTemp = new DataTable();                      
            try
            {
                Connection();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand(ProName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (ParamList != null || ParamList.Count > 0)
                {
                    SqlParameter SP;
                    foreach (Tuple<string, object> tuple in ParamList)
                    {
                        SP = new SqlParameter();
                        cmd.Parameters.AddWithValue(SP.ParameterName = tuple.Item1, SP.Value = tuple.Item2);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtTemp);                
                con.Close();
                if (dtTemp.Rows.Count > 0)
                {
                    return dtTemp;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        } 
    }
}   
          

            
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages.Html;
using PagedList;
using System.IO;
using iTextSharp.text;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Microsoft.Reporting.WebForms;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CRUDADO.Controllers
{
    public class EmployeeController : Controller
    {
        public SqlConnection con;
        public void connection()
        {
            string cnstr;
            cnstr = ConfigurationManager.ConnectionStrings["SalesERPDAL"].ToString();
            con = new SqlConnection(cnstr);
        }
        // GET: Employee
        EmpRepository er = new EmpRepository();
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee e)
        {
            if (er.AddEmployeeWithBase(e))
            {
                ViewBag.message = "Add Successfully";
            }
            return RedirectToAction("GetAll", "Employee");
        }

        public ActionResult GetAll(string Sorting_Order,string Search,int? page)
        {
            int pageNo = 1;
            int pageSize = 10;
            pageNo = page.HasValue ? Convert.ToInt32(page) : 1;
            //Search = Request.Form["search"];
            ViewBag.SortingFirstName = string.IsNullOrWhiteSpace(Sorting_Order) ? "FirstName_Desc":"";
            //ViewBag.SortingFirstName = Sorting_Order == "FirstName" ? "FirstName_Desc" : "FirstName";
            ViewBag.SortingLastName = Sorting_Order == "LastName" ? "LastName_Desc" : "LastName";
            //ViewBag.SortingSalary = Sorting_Order == "Salary" ? "Salary_Desc" : "Salary";
            //IPagedList<Employee> EP = null;
            List<Employee> emp;
            //Employee empList = new Employee();
            ViewBag.EmployeeList = FillEmployeeName();
            emp = er.GetAllWithBase().ToList();
            if (Search != null && Search != "")
            {
                emp = emp.Where(c => c.FirstName.ToUpper().Contains(Search.ToUpper()) || c.LastName.ToUpper().Contains(Search.ToUpper())
                                        || c.Salary.ToString().Contains(Search)).ToList();
            }
            switch (Sorting_Order)
            {
                //case "FirstName":
                //   emp = er.GetAll().OrderBy(x => x.FirstName).ToList();
                //    break;
                case "FirstName_Desc":
                    emp = emp.OrderByDescending(x => x.FirstName).ToList();
                    break;
                case "LastName":
                    emp = emp.OrderBy(x => x.LastName).ToList();
                    break;
                case "LastName_Desc":
                    emp = emp.OrderByDescending(x => x.LastName).ToList();
                    break;                
                default:
                    emp = emp.OrderBy(x => x.FirstName).ToList();
                    break;
            }
            //return View(emp.Skip((pageNo - 1) * pageSize).Take(pageSize));
            return View(emp);
            //EP = emp.ToPagedList(pageNo, pageSize);
            //return View(EP);
        }

        private List<System.Web.Mvc.SelectListItem> FillEmployeeName()
        {
            List<System.Web.Mvc.SelectListItem> EmpName = new List<System.Web.Mvc.SelectListItem>();
            EmpName = er.EmployeeName();
            return EmpName;
        }

        [HttpGet]
        public ActionResult EditEmployee(int id)
        {
            return View(er.GetAllWithBase().Find(x=> x.EmployeeId == id));
        }

        [HttpPost]
        public ActionResult EditEmployee(Employee e)
        {
            if (er.UpdateEmployeeWithBase(e))
            {
                ViewBag.message = "Update Successfully";
            }
            return RedirectToAction("GetAll", "Employee");
        }

        public ActionResult Delete(int id)
        {
            if (er.DeleteEmployeeWithBase(id))
            {
                ViewBag.message = "Delete Successfully";
            }
            return RedirectToAction("GetAll","Employee");
        }

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            List<Employee> emp = new List<Employee>();
            emp = er.GetAllWithBase().Take(7).ToList();
            return Json(emp, JsonRequestBehavior.AllowGet);
        }

        //public ActionResult AddEmp(Employee e)
        //{
        //    if (e.EmployeeId < 0)
        //    {
        //        er.AddEmployeeWithBase(e);
        //    }
        //    else
        //    {
        //        er.UpdateEmployeeWithBase(e);
        //    }
        //    return Json("Success", JsonRequestBehavior.AllowGet);
        //}

        //public JsonResult GetById(int id)
        //{
        //    return Json(er.GetAll().Find(c => c.EmployeeId == id), JsonRequestBehavior.AllowGet);
        //} 
        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(string GridExport)
        {
            StringReader sr = null;
            Document pdfDoc = null;
            PdfWriter writter = null;
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    sr = new StringReader(GridExport);
                    pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                    writter = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    XMLWorkerHelper.GetInstance().ParseXHtml(writter, pdfDoc, sr);
                    pdfDoc.Close();
                    return File(stream.ToArray(), "application/pdf", "Grid.pdf");
                }
            }
            finally
            {
                sr.Dispose();
                pdfDoc.Dispose();
                writter.Dispose();
            }           
        }

        DataSet ds = new DataSet();
        public ActionResult Reports()
        {
            ReportViewer rptViewer = new ReportViewer();
            rptViewer.ProcessingMode = ProcessingMode.Local;
            rptViewer.SizeToReportContent = true;
            rptViewer.ZoomMode = ZoomMode.PageWidth;
            rptViewer.Width = Unit.Percentage(99);
            rptViewer.Height = Unit.Pixel(1000);
            rptViewer.AsyncRendering = true;
            connection();
            SqlDataAdapter da = new SqlDataAdapter("select * from TblEmployee1", con);
            da.Fill(ds);
            rptViewer.LocalReport.ReportPath = ConfigurationManager.AppSettings["ReportPath"].ToString();
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables[0]));
            ////rptViewer.ServerReport.ReportServerUrl = new Uri("http://localhost/ReportServer");
            //rptViewer.ServerReport.ReportPath = ConfigurationManager.AppSettings["ReportPath"].ToString();
            ViewBag.ReportViewer = rptViewer;
            return View();
        }
    }
}
          
       
