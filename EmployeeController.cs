using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Villa_Management_System.Models;


namespace Villa_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public List<Employee> getallEmployee()
        {
            SqlConnection cn = new SqlConnection("data source=ANANDYADAV96\\SQLEXPRESS;initial catalog=Villa_Management_System;integrated security=sspi");
            SqlCommand cmd = new SqlCommand($"select * from employee", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Employee> lst = new List<Employee>();
            while (dr.Read())
            {
                Employee e = new Employee();
               // e.EmployeeID = Convert.ToInt32(dr["employeeID"]);
                e.FirstName = Convert.ToString(dr["FirstName"]);
                e.MiddleName = Convert.ToString(dr["MiddleName"]);
                e.LastName = Convert.ToString(dr["LastName"]);
                e.GenderID = Convert.ToInt32(dr["GenderID"]);
                e.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                e.Email = Convert.ToString(dr["Email"]);
                e.Password = Convert.ToString(dr["password"]);
                e.PresentAddress = Convert.ToString(dr["PresentAddress"]);
                e.PermanentAddress = Convert.ToString(dr["PermanentAddress"]);
                e.PrimaryMobile = Convert.ToInt64(dr["PrimaryMobile"]);
                e.AlternateMobile = Convert.ToInt64(dr["AlternateMobile"]);
                e.AadhaarNumber = Convert.ToString(dr["AadhaarNumber"]);
                e.PANNumber = Convert.ToString(dr["PANNumber"]);
                e.DateOfJoining = Convert.ToDateTime(dr["DateOfJoining"]);
                e.CTC = Convert.ToDecimal(dr["CTC"]);
                e.Designation = Convert.ToString(dr["Designation"]);
                e.Experience = Convert.ToString(dr["Experience"]);
                e.EducationID = Convert.ToInt32(dr["EducationID"]);
                e.YearOfPassing = Convert.ToInt32(dr["YearOfPassing"]);
                e.BankName = Convert.ToString(dr["BankName"]);
                e.AccountNumber = Convert.ToInt64(dr["AccountNumber"]);
                e.IFSCCode = Convert.ToString(dr["IFSCCode"]);
                e.BranchAddress = Convert.ToString(dr["BranchAddress"]);
                e.BloodGroupID = Convert.ToInt32(dr["BloodGroupID"]);
                e.RelationID = Convert.ToInt32(dr["RelationID"]);
                e.RelativeName = Convert.ToString(dr["RelativeName"]);
                e.RelativeMobile = Convert.ToInt64(dr["RelativeMobile"]);
                e.IsActive = Convert.ToInt32(dr["IsActive"]);
                e.LastWorkingDay = Convert.ToString(dr["LastWorkingDay"]);
                lst.Add(e);
            }
            dr.Close();
            cn.Close();
            return lst;
        }

        // GET api/values/5
        [HttpGet("{EmployeeID}")]
        public ActionResult<Employee> GetEmployee(int employeeID)
        {
            SqlConnection cn = new SqlConnection("data source=ANANDYADAV96\\SQLEXPRESS;initial catalog=Villa_Management_System;integrated security=sspi");
            SqlCommand cmd = new SqlCommand($"select * from employee", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Employee e = new Employee();
            while (dr.Read())
            {

                e.FirstName = Convert.ToString(dr["FirstName"]);
                e.MiddleName = Convert.ToString(dr["MiddleName"]);
                e.LastName = Convert.ToString(dr["LastName"]);
                e.GenderID = Convert.ToInt32(dr["GenderID"]);
                e.Password = Convert.ToString(dr["password"]);
                e.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                e.Email = Convert.ToString(dr["Email"]);
                e.PresentAddress = Convert.ToString(dr["PresentAddress"]);
                e.PermanentAddress = Convert.ToString(dr["PermanentAddress"]);
                e.PrimaryMobile = Convert.ToInt64(dr["PrimaryMobile"]);
                e.AlternateMobile = Convert.ToInt64(dr["AlternateMobile"]);
                e.AadhaarNumber = Convert.ToString(dr["AadhaarNumber"]);
                e.PANNumber = Convert.ToString(dr["PANNumber"]);
                e.DateOfJoining = Convert.ToDateTime(dr["DateOfJoining"]);
                e.CTC = Convert.ToDecimal(dr["CTC"]);
                e.Designation = Convert.ToString(dr["Designation"]);
                e.Experience = Convert.ToString(dr["Experience"]);
                e.EducationID = Convert.ToInt32(dr["EducationID"]);
                e.YearOfPassing = Convert.ToInt32(dr["YearOfPassing"]);
                e.BankName = Convert.ToString(dr["BankName"]);
                e.AccountNumber = Convert.ToInt64(dr["AccountNumber"]);
                e.IFSCCode = Convert.ToString(dr["IFSCCode"]);
                e.BranchAddress = Convert.ToString(dr["BranchAddress"]);
                e.BloodGroupID = Convert.ToInt32(dr["BloodGroupID"]);
                e.RelationID = Convert.ToInt32(dr["RelationID"]);
                e.RelativeName = Convert.ToString(dr["RelativeName"]);
                e.RelativeMobile = Convert.ToInt64(dr["RelativeMobile"]);
                e.IsActive = Convert.ToInt32(dr["IsActive"]);
                e.LastWorkingDay = Convert.ToString(dr["LastWorkingDay"]);
                
            }
            dr.Close();
            cn.Close();
            return e;

        }

        // POST api/values
        [HttpPost]
        public void Addemployee([FromBody] Employee e)
        {
            SqlConnection cn = new SqlConnection("data source=ANANDYADAV96\\SQLEXPRESS;initial catalog=Villa_Management_System;integrated security=sspi");
            SqlCommand cmd = new SqlCommand($"insert into employee values('{e.FirstName}','{e.MiddleName}','{e.LastName}','{e.GenderID}','{e.Password}','{e.DateOfBirth}','{e.Email}','{e.PresentAddress}','{e.PermanentAddress}','{e.PrimaryMobile}','{e.AlternateMobile}','{e.AadhaarNumber}','{e.PANNumber}','{e.DateOfJoining}','{e.CTC}','{e.Designation}','{e.Experience}','{e.EducationID}','{e.YearOfPassing}','{e.BankName}','{e.AccountNumber}','{e.IFSCCode}','{e.BranchAddress}','{e.BloodGroupID}','{e.RelationID}','{e.RelativeName}','{e.RelativeMobile}','{e.IsActive}','{e.LastWorkingDay}')", cn);
            cn.Open();
            int rows_insert = cmd.ExecuteNonQuery();
            cn.Close();
        }

        // PUT api/values/5
        [HttpPut("{EmployeeID}")]
        public void Updateemployee(int EmployeeID, [FromBody] Employee e)
        {
            SqlConnection cn = new SqlConnection("data source=ANANDYADAV96\\SQLEXPRESS;initial catalog=Villa_Management_System;integrated security=sspi");
            SqlCommand cmd = new SqlCommand($"update employee set fname='{e.FirstName}',mname='{e.MiddleName}',lname='{e.LastName}',gender='{e.GenderID}',password='{e.Password}',dob='{e.DateOfBirth}',email='{e.Email}',presentaddress='{e.PresentAddress}',permaantaddress='{e.PermanentAddress}',p_cell='{e.PrimaryMobile}',alter_cell='{e.AlternateMobile}',Aadhar_no='{e.AadhaarNumber}',pan_no='{e.PANNumber}',doj='{e.DateOfJoining}',ctc='{e.CTC}',designation='{e.Designation}',exp='{e.Experience}',education='{e.EducationID}',yearofpassing='{e.YearOfPassing}',bankname='{e.BankName}',bankaccount_no='{e.AccountNumber}',ifsc_code='{e.IFSCCode}',braddress'{e.BranchAddress}',bg='{e.BloodGroupID}'rel=,'{e.RelationID}',rel_name='{e.RelativeName}',rel_mob_no='{e.RelativeMobile}',isactive='{e.IsActive}',last_working_day='{e.LastWorkingDay}' where eid={e.EmployeeID}", cn);
            cn.Open();
            int rows_insert = cmd.ExecuteNonQuery();
            cn.Close();
        }

        // DELETE api/values/5
        [HttpDelete("{EmployeeID}")]
        public void Relieveemployee(int EmployeeID)
        {
            SqlConnection cn = new SqlConnection("data source=ANANDYADAV96\\SQLEXPRESS;initial catalog=Villa_Management_System;integrated security=sspi");
            SqlCommand cmd = new SqlCommand($"delete from employee where eid={EmployeeID}", cn);
            cn.Open();
            int rows_insert = cmd.ExecuteNonQuery();
            cn.Close();
        }
        [HttpGet("{isactivemembers}")]

         public List<Employee> getisactivemembers()
        {
            SqlConnection cn = new SqlConnection("data source=ANANDYADAV96\\SQLEXPRESS;initial catalog=Villa_Management_System;integrated security=sspi");
            SqlCommand cmd = new SqlCommand("select * from employee", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Employee> lst = new List<Employee>();

            while (dr.Read())
            {
                Employee e = new Employee();
                e.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
                e.FirstName = Convert.ToString(dr["FirstName"]);

                e.LastName = Convert.ToString(dr["LastName"]);
                e.GenderID = Convert.ToInt32(dr["GenderID"]);

                e.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                e.Email = Convert.ToString(dr["Email"]);

                e.PrimaryMobile = Convert.ToInt64(dr["PrimaryMobile"]);

                e.DateOfJoining = Convert.ToDateTime(dr["DateOfJoining"]);
                e.CTC = Convert.ToDecimal(dr["CTC"]);
                e.Designation = Convert.ToString(dr["Designation"]);


            }
            cn.Close();
            return lst;
        }
        [HttpGet("{inactivemembers}")]

        public List<Employee> getinactivemembers()
        {
            SqlConnection cn = new SqlConnection("data source=ANANDYADAV96\\SQLEXPRESS;initial catalog=Villa_Management_System;integrated security=sspi");
            SqlCommand cmd = new SqlCommand("select * from employee", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Employee> lst = new List<Employee>();

            while (dr.Read())
            {
                Employee e = new Employee();
                e.EmployeeID = Convert.ToInt32(dr["eid"]);
                e.FirstName = Convert.ToString(dr["FirstName"]);

                e.LastName = Convert.ToString(dr["LastName"]);
                e.GenderID = Convert.ToInt32(dr["GenderID"]);

                e.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                e.Email = Convert.ToString(dr["Email"]);

                e.PrimaryMobile = Convert.ToInt64(dr["PrimaryMobile"]);

                e.DateOfJoining = Convert.ToDateTime(dr["DateOfJoining"]);
                e.CTC = Convert.ToDecimal(dr["CTC"]);
                e.Designation = Convert.ToString(dr["Designation"]);
                e.LastWorkingDay = Convert.ToString(dr["LastWorkingDay"]);
            }
            cn.Close();
            return lst;
        }

    }
}


