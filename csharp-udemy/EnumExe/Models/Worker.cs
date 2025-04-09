using EnumExe.Enum;

namespace EnumExe.Models
{
    public class Worker
    {
        public string Name { get; protected set; }
        public WorkerLevel Level { get; protected set; }
        public double BaseSalary { get; protected set; }
        public Department Department { get; set; }
        
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
    }
}