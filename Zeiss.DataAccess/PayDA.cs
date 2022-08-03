namespace Zeiss.DataAccess
{
    public class PayDA
    {
        public int GetBasicPay(string empID, Int16 Month, Int16 Year)
        {
            //connect to the db
            //execute stored procedure/query
            //get Basic Pay
            //close connection
            return 20000;
        }
    }

    public class EmployeeDA
    {
       public string empID;
        public string FirstName;
        public string LastName;
        public string DOJ;

        public EmployeeDA GetEmpDetails(string empID)
        {
         EmployeeDA emp = new EmployeeDA();

            emp.FirstName = "Raj";
            emp.LastName = "Kumar";
            emp.DOJ = "5-5-2015";

            return emp;

        }

    }
}