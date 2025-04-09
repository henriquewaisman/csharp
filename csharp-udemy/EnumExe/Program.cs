using System;
using EnumExe.Enum;
using EnumExe.Models;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
                Department department = new Department("DHO");
                Department department1 = new Department("Maxpar");
                Department department2 = new Department("B4B");

                HourContract contract = new HourContract(DateTime.Now, 15, 30);
                HourContract contract1 = new HourContract(DateTime.Now, 40, 40);
                HourContract contract2 = new HourContract(DateTime.Now, 100, 20);

                Worker worker = new Worker("Henrique", WorkerLevel.senior, 15000.0, department);
                Worker worker1 = new Worker("Silvio", WorkerLevel.mid_level, 10000.0, department1);
                Worker worker2 = new Worker("João", WorkerLevel.junior, 5000.0, department2);

                Console.WriteLine(worker.Name);
                Console.WriteLine(worker.Level.ToString());
                Console.WriteLine(worker.Department.Name);
                
                worker.AddContract(contract);

                var workerContracts = worker.Contracts;
                foreach(var c in workerContracts)
                {
                    Console.WriteLine($"data do contrato: {c.Date:dd/mm/yyyy} - horas semanais:" +
                    $" {c.Hours}, reais por hora - {c.ValuePerHour}");
                }

                Console.WriteLine(worker.CheckIncome(2025, 4));
        
        }
    }
}