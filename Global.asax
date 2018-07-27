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
