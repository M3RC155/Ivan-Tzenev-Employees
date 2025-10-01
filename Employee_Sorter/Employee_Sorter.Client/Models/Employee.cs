namespace Employee_Sorter.Client.Models
{
    public class Employee
    {
        public int EmpID { get; set; }

        public int ProjectID { get; set; }

        public DateOnly DateFrom { get; set; }

        public DateOnly? DateTo { get; set; }

        public int DaysWorked => GetDaysWorked();

        private int GetDaysWorked()
        {
            DateOnly endDate = DateTo ?? DateOnly.FromDateTime(DateTime.Now);
            return (endDate.ToDateTime(new TimeOnly()) - DateFrom.ToDateTime(new TimeOnly())).Days;
        }
    }

    public class EmployeePair
    {
        public int EmpID1 { get; set; }

        public int EmpID2 { get; set; }

        public int ProjectID { get; set; }

        public int DaysWorkedTogether { get; set; }
    }
}
