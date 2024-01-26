// See https://aka.ms/new-console-template for more information
using AdapterExample;

Employee employee = new Employee();
Worker worker = new Worker();
worker.id = 1;
worker.name = "Khaled";
worker.basic_salary = 1000;
SalaryAdapter salcal = new SalaryAdapter();
Console.WriteLine(salcal.Calculate(worker).ToString());