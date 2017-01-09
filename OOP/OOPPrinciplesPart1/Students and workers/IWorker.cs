namespace Students_and_workers
{
    interface IWorker
    {
        decimal WeekSalary { get; }

        int WorkHoursPerDay { get; }

        decimal MoneyPerHour();

    }
}
