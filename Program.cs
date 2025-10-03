//using System;
//
//namespace OOPBasics
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Student denis = new Student();
//            denis.name = "Denis";
//            denis.age = 18;
//            denis.group = "ISP-231";
//            denis.PrintInfo();
//            
//            Console.WriteLine($"Студент {denis.name} совершеннолетний - {denis.IsAdult()}");
//
//            Student anton = new Student();
//            anton.PrintInfo();
//
//            Car myCar = new Car();
//            myCar.model = "Toyota";
//            Console.WriteLine($"Модель: {myCar.model}");
//            myCar.Accelerate(20);
//
//            Player player = new Player();
//            player.TakeDamage(34);
//            Console.WriteLine(player.GetHealth());
//
//            Television tv = new Television();
//            tv.SetVolume(50);
//            tv.SetVolume(150);
//
//            BankAccount bankAccount = new BankAccount();
//            bankAccount.Deposit(50);
//            bankAccount.Withdraw(23);
//
//            Student maksim = new Student();
//            Student ivan = new Student("Ivan");
//            Student petr = new Student("Petr", 20);
//            Student anna = new Student("Anna", 19, "ISP-232");
//
//            Person bob = new Person(68);
//            bob.CheckAge();
//            Person tom = new Person(37);
//            tom.CheckAge();
//            Console.WriteLine(Person.retirementAge);
//            Person.retirementAge = 67;
//        }
//    }
//
//    class Student
//    {
//        public string? name;
//        public int age;
//        public string? group;
//
//        public Student()
//        {
//            Console.WriteLine("Создание объекта Студент");
//            this.name = "Неизвестно";
//            this.age = 18;
//            this.group = "Неизвестно";
//        }
//
//        public Student(string name)
//        {
//            this.name = name;
//            this.age = 18;
//            this.group = "Неизвестно";
//        }
//
//        public Student(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//            this.group = "Неизвестно";
//        }
//
//        public Student(string name, int age, string group)
//        {
//            this.name = name;
//            this.age = age;
//            this.group = group;
//        }
//
//        public void PrintInfo()
//        {
//            Console.WriteLine($"Имя: {name}, Возраст: {age}, Группа: {group}");
//        }
//
//        public bool IsAdult()
//        {
//            return age >= 18;
//        }
//    }
//
//    internal class Car
//    {
//        public string? model;
//        private int _currentSpeed;
//        protected string? engineType;
//
//        public void Accelerate(int speed)
//        {
//            if (speed > 0)
//            {
//                _currentSpeed += speed;
//                Console.WriteLine($"Разгон до {_currentSpeed} км/ч");
//            }
//        }
//
//        private void CheckEngine()
//        {
//            Console.WriteLine("Проверка двигателя...");
//        }
//
//        protected void SetEngine(string type)
//        {
//            engineType = type;
//        }
//    }
//
//    internal class Player
//    {
//        private int health = 100;
//
//        public void TakeDamage(int damage)
//        {
//            if (damage > 0)
//            {
//                health -= damage;
//                Console.WriteLine($"Персонаж получил урона: {damage}. Осталось здоровья: {health}.");
//            }
//        }
//
//        public int GetHealth()
//        {
//            return health;
//        }
//    }
//
//    internal class Television
//    {
//        private int volume = 50;
//
//        public void SetVolume(int newVolume)
//        {
//            if (newVolume >= 0 && newVolume <= 100)
//            {
//                volume = newVolume;
//                Console.WriteLine($"Громкость изменена: {volume}");
//            }
//            else
//            {
//                Console.WriteLine("Ошибка! Громкость должна быть от 0 до 100.");
//            }
//        }
//    }
//
//    internal class BankAccount
//    {
//        private decimal balance = 0m;
//
//        public void Deposit(decimal amount)
//        {
//            if (amount > 0)
//            {
//                balance += amount;
//                Console.WriteLine($"Пополнение: {amount}. Текущий баланс: {balance}");
//            }
//        }
//
//        public void Withdraw(decimal amount)
//        {
//            if (amount > 0 && amount <= balance)
//            {
//                balance -= amount;
//                Console.WriteLine($"Снятие: {amount}. Остаток: {balance}");
//            }
//            else
//            {
//                Console.WriteLine("Недостаточно средств!");
//            }
//        }
//    }
//
//    internal class Person
//    {
//        int age;
//        public static int retirementAge = 65;
//
//        public Person(int age)
//        {
//            this.age = age;
//        }
//
//        public void CheckAge()
//        {
//            if (age >= retirementAge)
//                Console.WriteLine("Уже на пенсии");
//            else
//                Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
//        }
//    }
//}
//
//namespace PickRandomCards
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите количество карт для выбора: ");
//            string? line = Console.ReadLine();
//
//            if (int.TryParse(line, out int numberOfCards))
//            {
//                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
//                {
//                    Console.WriteLine(card);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Введите корректное число.");
//            }
//        }
//    }
//
//    internal class CardPicker
//    {
//        static Random random = new Random();
//
//        public static string[] PickSomeCards(int numberOfCards)
//        {
//            string[] pickedCards = new string[numberOfCards];
//            for (int i = 0; i < numberOfCards; i++)
//            {
//                pickedCards[i] = RandomValue() + " " + RandomSuit();
//            }
//            return pickedCards;
//        }
//
//        private static string RandomSuit()
//        {
//            int value = random.Next(1, 5);
//            if (value == 1) return "пик";
//            if (value == 2) return "червей";
//            if (value == 3) return "треф";
//            return "бубен";
//        }
//
//        private static string RandomValue()
//        {
//            int value = random.Next(1, 14);
//            if (value == 1) return "Туз";
//            if (value == 11) return "Валет";
//            if (value == 12) return "Дама";
//            if (value == 13) return "Король";
//            return value.ToString();
//        }
//    }
//}