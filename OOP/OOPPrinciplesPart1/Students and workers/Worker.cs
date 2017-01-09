namespace Students_and_workers
{
    using System.Text;

    public class Worker : Human, IWorker
    {
        public Worker(string firsName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firsName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; private set; }

        public int WorkHoursPerDay { get; private set; }


        public decimal MoneyPerHour()
        {
            //if the worker works 5 days weekly
            decimal moneyPerHour = WeekSalary / (WorkHoursPerDay * 5);
            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append(string.Format("Worker full name: {0} {1}", FirstName, LastName));
            str.Append(", Week salary:" + WeekSalary);
            str.Append(string.Format(", money per hour: {0:F2}", MoneyPerHour()));
            return str.ToString();
        }
    }
}
