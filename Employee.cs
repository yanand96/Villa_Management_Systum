namespace Villa_Management_System.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int GenderID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public long PrimaryMobile { get; set; }
        public long AlternateMobile { get; set; }
        public string AadhaarNumber { get; set; }
        public string PANNumber { get; set; }
        public DateTime DateOfJoining { get; set; }
        public decimal CTC { get; set; }
        public string Designation { get; set; }
        public string Experience { get; set; }
        public int EducationID { get; set; }
        public int YearOfPassing { get; set; }
        public string BankName { get; set; }
        public long AccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string BranchAddress { get; set; }
        public int BloodGroupID { get; set; }
        public int RelationID { get; set; }
        public string RelativeName { get; set; }
        public long RelativeMobile { get; set; }
        public int IsActive { get; set; }
        public string LastWorkingDay { get; set; }


    }
}
