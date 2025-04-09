namespace EnumExe.Models
{
    public class HourContract
    {
        public DateTime Date { get; protected set; }
        public double ValuePerHour { get; protected set; }
        public int Hours { get; protected set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            SetDate(date);
            SetValuePerHour(valuePerHour);
            SetHours(hours);
        }
        public void SetDate(DateTime date)
        {
            if(date == DateTime.MinValue)
            {
                throw new Exception("Date is invalid.");
            }
            Date = date;
        }
        public void SetValuePerHour(double valuePerHour)
        {
            if(valuePerHour < 0)
            {
                throw new Exception("Value per hour cannot be less then 0.");
            }
            ValuePerHour = valuePerHour;
        }
        public void SetHours(int hours)
        {
            if(hours < 0)
            {
                throw new Exception("Number of hours cannot be less then 0.");
            }
            Hours = hours;
        }
    }
}