namespace lab__2
{
    namespace Lab_2
    {
        using System;

        // Клас Address
        class Address
        {
            public string Index { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string House { get; set; }
            public string Apartment { get; set; }
        }

        // Клас Converter
        class Converter
        {
            private double usdRate;
            private double eurRate;
            private double plnRate;

            public Converter(double usd, double eur, double pln)
            {
                usdRate = usd;
                eurRate = eur;
                plnRate = pln;
            }

            public double ConvertToUSD(double uah)
            {
                return uah / usdRate;
            }

            public double ConvertToEUR(double uah)
            {
                return uah / eurRate;
            }

            public double ConvertToPLN(double uah)
            {
                return uah / plnRate;
            }

            public double ConvertFromUSD(double usd)
            {
                return usd * usdRate;
            }

            public double ConvertFromEUR(double eur)
            {
                return eur * eurRate;
            }

            public double ConvertFromPLN(double pln)
            {
                return pln * plnRate;
            }
        }

        // Клас Employee
        class Employee
        {
            private string lastName;
            private string firstName;

            public Employee(string lastName, string firstName)
            {
                this.lastName = lastName;
                this.firstName = firstName;
            }

            public string LastName => lastName;
            public string FirstName => firstName;

            public double CalculateSalary(string position, int experience)
            {
                // Ваш код для розрахунку окладу співробітника
                // В цьому прикладі просто повертаємо фіксований оклад для ілюстрації
                double baseSalary = 3000;
                double salary = baseSalary;

                // Додатковий розрахунок окладу залежно від посади та стажу
                if (position == "Менеджер")
                {
                    salary += experience * 200;
                }
                else if (position == "Програміст")
                {
                    salary += experience * 300;
                }

                return salary;
            }

            public double CalculateTax(double salary)
            {
                // Розрахунок податкового збору (просто 15% від окладу в цьому прикладі)
                return 0.15 * salary;
            }
        }

        // Клас User
        class User
        {
            public string Login { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public DateTime RegistrationDate { get; }

            public User(string login, string firstName, string lastName, int age)
            {
                Login = login;
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                RegistrationDate = DateTime.Now;
            }

            public void DisplayUserInfo()
            {
                Console.WriteLine($"Логін: {Login}");
                Console.WriteLine($"Ім'я: {FirstName}");
                Console.WriteLine($"Прізвище: {LastName}");
                Console.WriteLine($"Вік: {Age}");
                Console.WriteLine($"Дата заповнення анкети: {RegistrationDate}");
            }
        }
    }
