namespace Properties
{
    internal class Employee
    {
        private string? name;
        private double salary;

        public string? Name { get => name; set => name = value; }
        public double Salary 
        { 
            get => salary;

            set => salary = CheckSalary(value);
            
        }

        private double CheckSalary(double num) 
        {
            if (num < 0)
            {
                Console.WriteLine("Only values above or equal to 0 are permitted. Value assigned is 0.");
                num = 0;
            }

            return salary = num;
        }


        public Employee(string? name, double salary)
        {
            this.name = name;
            CheckSalary(salary);
        }
    }
}
