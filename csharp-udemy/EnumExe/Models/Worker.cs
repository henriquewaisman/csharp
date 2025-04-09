using System.Data;
using System.Diagnostics.Contracts;
using EnumExe.Enum;

namespace EnumExe.Models
{
    public class Worker
    {
        public string Name { get; protected set; }
        public WorkerLevel Level { get; protected set; }
        public double BaseSalary { get; protected set; }
        public List<Department> Departments { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            SetName(name);
            SetLevel(level);
            SetBaseSalary(baseSalary);
        }

        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name can not be empty.");
            }
            if(name.Length > 255)
            {
                throw new Exception("Workers name length can not be greater than 255 characters.");
            }
            Name = name;
        }
        public void SetLevel(WorkerLevel level)
        {
            if (!System.Enum.IsDefined(typeof(WorkerLevel), level))
            {
                throw new Exception("Invalid worker level.");
            }

            Level = level;
        }
        public void SetBaseSalary(double baseSalary)
        {
            if(baseSalary < 0)
            {
                throw new Exception("Workers base salary can not less than 0.");
            }
            BaseSalary = baseSalary;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double CheckIncome(int year, int month)
        {
            double income = BaseSalary;

            if(Contracts == null)
            {
                return 0;
            }
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    income += contract.ValuePerHour * contract.Hours;
                }
            }
            return income;
        }
    }
}