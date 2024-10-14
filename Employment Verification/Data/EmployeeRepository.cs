using Employment_Verification.Model;

namespace Employment_Verification.Data
{
    public class EmployeeRepository
    {
        private List<Employee> employees = new List<Employee>
    {
        new Employee { EmployeeId = 1, CompanyName = "NeGroup", VerificationCode = "123ABC" },
        new Employee { EmployeeId = 2, CompanyName = "NEGroup", VerificationCode = "456DEF" },
        new Employee { EmployeeId = 3, CompanyName = "NEGroup", VerificationCode = "789GHI" },
        new Employee { EmployeeId = 4, CompanyName = "NEGroup", VerificationCode = "321JKL" },
        new Employee { EmployeeId = 5, CompanyName = "NEGroup", VerificationCode = "654MNO" },
        new Employee { EmployeeId = 6, CompanyName = "NEGroup", VerificationCode = "987PQR" },
        new Employee { EmployeeId = 7, CompanyName = "NEGroup", VerificationCode = "112STU" },
        new Employee { EmployeeId = 8, CompanyName = "NEGroup", VerificationCode = "334VWX" },
        new Employee { EmployeeId = 9, CompanyName = "NEGroup", VerificationCode = "556YZA" },
        new Employee { EmployeeId = 10, CompanyName = "NEGroup", VerificationCode = "778BCD" }
                };

        public Employee VerifyEmployment(int employeeId, string companyName, string verificationCode)
        {
            return employees.FirstOrDefault(emp =>
                emp.EmployeeId == employeeId &&
                emp.CompanyName == companyName &&
                emp.VerificationCode == verificationCode
            );
        }
    }

}
