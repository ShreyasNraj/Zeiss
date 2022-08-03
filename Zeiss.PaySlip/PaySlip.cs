using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.BL;


namespace Zeiss.PaySlip
{

    

    public class PaySlip
    {
        string EmpID;
        string EmpFirstName;
        string EmpLastName;
        string Department;
        DateTime DOJ;
        short Month;
        short Year;
        int BasicPay;
        int DA;
        int HRA;
        int LTA;
        int PF;
        int ProfTax;
        int IncomeTax;
        int Loan;

       public void PrintPaySlip(string empId, short Month, short Year)
        {
            Console.WriteLine("paySlip for " + Year.ToString() + " - " + Month.ToString());
            EmployeeBL empBL = new EmployeeBL();
            empBL = empBL.GetEmpDetails("M1000403");
            Console.WriteLine(empBL.empID + "    " + empBL.FirstName + " " +empBL.LastName);
            Console.WriteLine("Date of joining:" + empBL.DOJ);

            
        }
    }
}
