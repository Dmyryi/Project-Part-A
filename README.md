# Project-Part-A
ПОСТАНОВКА ЗАДАЧІ
Завдання:
1.	Обрати і коротко описати нову предметну область.
2.	Для обраної предметної області з використанням IDE (наприклад, Visual Studio 2022) або будь-якого спеціалізованого онлайн-сервісу (наприклад, https://www.lucidchart.com) за два етапи побудувати модель предметної області у вигляді діаграми класів, на якій класи/інтерфейси мають бути пов’язані різними типами відношень: асоціація, агрегація, композиція, реалізація.
Етап 1: Виявлення та визначення необхідних перелічень, класів, інтерфейсів та зав’язків між ними (див. приклад на рис. 1). Бажано використовувати всі перелічені у п.2 типи відношень. 
Порада: якщо предметна область буде стосуватися приватної клініки, то розпочати виділення класів з класу «Клініка» і далі дивитися: а які інші класи потрібні, і як вони будуть пов’язані з класом «Клініка» і з іншими вже виділеними класами.
Етап 2: Детальне проєктування класів та інтерфейсів: для полів/властивостей необхідно вказати модифікатор доступу, назву, тип; для методів – додатково визначити тип значення, що повертається, та список параметрів 
3.	Засобами середи розробки (IDE) отримати/створити каркас проєкту, для цього необхідно визначити в окремих файлах *.cs всі спроєктовані у п.2 інтерфейси, класи, перелічення. Коректно реалізувати відношення між класами! Увага! Реалізовувати властивості, конструктори і методи у класах не потрібно! Замість реального коду вони мають містити «заглушки»: throw new NotImplementedException().
4.	Для тестування спроєктованих класів додати проєкт з тест-класами, які повинні містити достатній для повноцінного тестування набір реалізованих unit-тестів. Увага! Методи класів предметної області коду ще не мають, але для них вже пишемо повноцінні unit-тести (TDD-принцип розробки програми). Після запуску розроблених unit-тестів їх статус має бути failed.
5.	Використання GitHub-репозиторію з коммітами є обов’язковим! Репозиторій повинен мати заповнений Readme.md файл, в який необхідно: 
•	додати оформлений за допомогою markdown-розмітки опис предметної області (використовуйте заголовки, списки, рисунки та ін.);
•	вставити розроблену діаграму класів.
ВИКОНАННЯ РОБОТИ
1)	Опис класу: 
a)	Перелічення(Enum):
PizzaName – перелік назв піц(Пепероні, Маргарита, Гавайська, 4 Сири, Діабо, Бір-бургер, Бренд шеф 
b)	Класи:
Pizzeria – клас для зберігання даних про піцерію
Pizza – клас для оброблення кожної піци в замовлені
Order – клас для зберігання даних про замовлення в піцерії
Worker – клас для зберігання даних про робітників в піцерії
c)	Інтерфейс:
IInteraction – інтерфейс для змінення статусу та створення замовлення
d)	Виявлення та визанчення класів і зв’язків:
Асоціація: Клас Pizzeria має асоціацію з класом Worker (піцерія може мати багато робітників). Клас Pizzeria має асоціацію з класом Order(піцерія може мати багато замовлень)
Агрегація: Клас Order має агрегацію з класом Pizza(кожне замовлення містить піци, але піци існують незалежно)
Реалізація: клас Order реалізує інтерфейс IInteraction 
 
Рисунок 1 – Виявлення та визначення предметної області та зв’язки між ними
 
Рисунок 2 – Детальне проєктування елементів моделі предметної області
 
Рисунок 3 – Запущені тести
 
ДОДАТОК
Лістинг програми


Вміст консольного додатку (Pizzeria.cs):
public class Pizzeria
{
    public string Name { get; set; }
    public string Address { get; set; }


    public Pizzeria(string name, string address)
    {
        throw new NotImplementedException();
    }

    public void AddEmployee(Worker worker)
    {
        throw new NotImplementedException();
    }

    public void CreateOrder(int number, string status)
    {
        throw new NotImplementedException();
    }


Вміст класу консольного додатку (Worker.cs):

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Worker(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}

Вміст консольного додатку (Order.cs):
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public class Order : IInteraction
    {
        public int Number { get; set; }
        public string Status { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public Order(int number, string status)
        {
            throw new NotImplementedException();
        }

        public void AddPizza(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
Вміст консольного додатку (Pizza.cs):
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public class Pizza:IComparable<Pizza>
    {
        public PizzaName Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }

        public Pizza(PizzaName name, string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        public int CompareTo(Pizza other)
        {
            return Price.CompareTo(other.Price);
        }
    }


}
Вміст консольного додатку(IInteraction.cs)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public interface IInteraction
    {
        void Create();
        void Process();
    }
}
Вміст кольного додатку(PizzaName.cs)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
   
        public enum PizzaName
        {
            Margherita,
            Pepperoni,
            Hawaiian,
            FourCheese,
            Diablo
        }
    
}
Вміст консольного додатку(IntegrationTest.cs)

using System.Collections.Generic;

namespace Project_part_A
{
    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void Worker_Constructor_ShouldSetProperties()
        {
            // Arrange & Act
            var worker = new Worker("John", "Doe");

            // Assert
            Assert.AreEqual("John", worker.FirstName);
            Assert.AreEqual("Doe", worker.LastName);
        }
    }

    [TestClass]
    public class PizzeriaTests
    {
        [TestMethod]
        public void Pizzeria_Constructor_ShouldSetProperties()
        {
            // Arrange & Act
            var pizzeria = new Pizzeria("Pizzeria Uno", "123 Main St");

            // Assert
            Assert.AreEqual("Pizzeria Uno", pizzeria.Name);
            Assert.AreEqual("123 Main St", pizzeria.Address);
        }

        [TestMethod]
        public void AddEmployee_ShouldAddWorkerToPizzeria()
        {
            // Arrange
            var pizzeria = new Pizzeria("Pizzeria Uno", "123 Main St");
            var worker = new Worker("John", "Doe");

            // Act
            pizzeria.AddEmployee(worker);

            // Assert
            // Пример проверки, если есть список сотрудников
            // Assert.Contains(worker, pizzeria.Employees);
        }
    }

    [TestClass]
    public class PizzaTests
    {
        [TestMethod]
        public void Pizza_Constructor_ShouldSetProperties()
        {
            // Arrange & Act
            var pizza = new Pizza(PizzaName.Margherita, "Medium", 10.99);

            // Assert
            Assert.AreEqual(PizzaName.Margherita, pizza.Name);
            Assert.AreEqual("Medium", pizza.Size);
            Assert.AreEqual(10.99, pizza.Price);
        }

        [TestMethod]
        public void CompareTo_ShouldReturnCorrectComparison()
        {
            // Arrange
            var pizza1 = new Pizza(PizzaName.Margherita, "Medium", 10.99);
            var pizza2 = new Pizza(PizzaName.Pepperoni, "Large", 12.99);

            // Act & Assert
           
            Assert.AreEqual(0, pizza1.CompareTo(pizza1));
        }
    }

    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void Order_Constructor_ShouldSetProperties()
        {
            // Arrange & Act
            var order = new Order(1, "Pending");

            // Assert
            Assert.AreEqual(1, order.Number);
            Assert.AreEqual("Pending", order.Status);
        }

       

        [TestMethod]
        public void Create_ShouldSetOrderToCreated()
        {
            // Arrange
            var order = new Order(1, "Pending");

            // Act
            order.Create();

            // Assert
            Assert.AreEqual("Created", order.Status);
        }

        [TestMethod]
        public void Process_ShouldSetOrderToProcessed()
        {
            // Arrange
            var order = new Order(1, "Pending");

            // Act
            order.Process();

            // Assert
            Assert.AreEqual("Processed", order.Status);
        }
    }
}

ПОСТАНОВКА ЗАДАЧІ
Завдання:
1.	Обрати і коротко описати нову предметну область.
2.	Для обраної предметної області з використанням IDE (наприклад, Visual Studio 2022) або будь-якого спеціалізованого онлайн-сервісу (наприклад, https://www.lucidchart.com) за два етапи побудувати модель предметної області у вигляді діаграми класів, на якій класи/інтерфейси мають бути пов’язані різними типами відношень: асоціація, агрегація, композиція, реалізація.
Етап 1: Виявлення та визначення необхідних перелічень, класів, інтерфейсів та зав’язків між ними (див. приклад на рис. 1). Бажано використовувати всі перелічені у п.2 типи відношень. 
Порада: якщо предметна область буде стосуватися приватної клініки, то розпочати виділення класів з класу «Клініка» і далі дивитися: а які інші класи потрібні, і як вони будуть пов’язані з класом «Клініка» і з іншими вже виділеними класами.
Етап 2: Детальне проєктування класів та інтерфейсів: для полів/властивостей необхідно вказати модифікатор доступу, назву, тип; для методів – додатково визначити тип значення, що повертається, та список параметрів 
3.	Засобами середи розробки (IDE) отримати/створити каркас проєкту, для цього необхідно визначити в окремих файлах *.cs всі спроєктовані у п.2 інтерфейси, класи, перелічення. Коректно реалізувати відношення між класами! Увага! Реалізовувати властивості, конструктори і методи у класах не потрібно! Замість реального коду вони мають містити «заглушки»: throw new NotImplementedException().
4.	Для тестування спроєктованих класів додати проєкт з тест-класами, які повинні містити достатній для повноцінного тестування набір реалізованих unit-тестів. Увага! Методи класів предметної області коду ще не мають, але для них вже пишемо повноцінні unit-тести (TDD-принцип розробки програми). Після запуску розроблених unit-тестів їх статус має бути failed.
5.	Використання GitHub-репозиторію з коммітами є обов’язковим! Репозиторій повинен мати заповнений Readme.md файл, в який необхідно: 
•	додати оформлений за допомогою markdown-розмітки опис предметної області (використовуйте заголовки, списки, рисунки та ін.);
•	вставити розроблену діаграму класів.
ВИКОНАННЯ РОБОТИ
1)	Опис класу: 
a)	Перелічення(Enum):
PizzaName – перелік назв піц(Пепероні, Маргарита, Гавайська, 4 Сири, Діабо, Бір-бургер, Бренд шеф 
b)	Класи:
Pizzeria – клас для зберігання даних про піцерію
Pizza – клас для оброблення кожної піци в замовлені
Order – клас для зберігання даних про замовлення в піцерії
Worker – клас для зберігання даних про робітників в піцерії
c)	Інтерфейс:
IInteraction – інтерфейс для змінення статусу та створення замовлення
d)	Виявлення та визанчення класів і зв’язків:
Асоціація: Клас Pizzeria має асоціацію з класом Worker (піцерія може мати багато робітників). Клас Pizzeria має асоціацію з класом Order(піцерія може мати багато замовлень)
Агрегація: Клас Order має агрегацію з класом Pizza(кожне замовлення містить піци, але піци існують незалежно)
Реалізація: клас Order реалізує інтерфейс IInteraction
![Виявлення та визначення елементів предметної області та зв’язки між ними](https://github.com/2Maksym2/Project-Part-A/blob/main/Part-A/1.jpg)
Рисунок 1 – Виявлення та визначення предметної області та зв’язки між ними
 
Рисунок 2 – Детальне проєктування елементів моделі предметної області
 
Рисунок 3 – Запущені тести
 
ДОДАТОК
Лістинг програми


Вміст консольного додатку (Pizzeria.cs):
public class Pizzeria
{
    public string Name { get; set; }
    public string Address { get; set; }


    public Pizzeria(string name, string address)
    {
        throw new NotImplementedException();
    }

    public void AddEmployee(Worker worker)
    {
        throw new NotImplementedException();
    }

    public void CreateOrder(int number, string status)
    {
        throw new NotImplementedException();
    }


Вміст класу консольного додатку (Worker.cs):

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Worker(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}

Вміст консольного додатку (Order.cs):
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public class Order : IInteraction
    {
        public int Number { get; set; }
        public string Status { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public Order(int number, string status)
        {
            throw new NotImplementedException();
        }

        public void AddPizza(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
Вміст консольного додатку (Pizza.cs):
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public class Pizza:IComparable<Pizza>
    {
        public PizzaName Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }

        public Pizza(PizzaName name, string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        public int CompareTo(Pizza other)
        {
            return Price.CompareTo(other.Price);
        }
    }


}
Вміст консольного додатку(IInteraction.cs)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
    public interface IInteraction
    {
        void Create();
        void Process();
    }
}
Вміст кольного додатку(PizzaName.cs)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_part_A
{
   
        public enum PizzaName
        {
            Margherita,
            Pepperoni,
            Hawaiian,
            FourCheese,
            Diablo
        }
    
}
Вміст консольного додатку(IntegrationTest.cs)

using System.Collections.Generic;

namespace Project_part_A
{
    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void Worker_Constructor_ShouldSetProperties()
        {
            // Arrange & Act
            var worker = new Worker("John", "Doe");

            // Assert
            Assert.AreEqual("John", worker.FirstName);
            Assert.AreEqual("Doe", worker.LastName);
        }
    }

    [TestClass]
    public class PizzeriaTests
    {
        [TestMethod]
        public void Pizzeria_Constructor_ShouldSetProperties()
        {
            // Arrange & Act
            var pizzeria = new Pizzeria("Pizzeria Uno", "123 Main St");

            // Assert
            Assert.AreEqual("Pizzeria Uno", pizzeria.Name);
            Assert.AreEqual("123 Main St", pizzeria.Address);
        }

        [TestMethod]
        public void AddEmployee_ShouldAddWorkerToPizzeria()
        {
            // Arrange
            var pizzeria = new Pizzeria("Pizzeria Uno", "123 Main St");
            var worker = new Worker("John", "Doe");

            // Act
            pizzeria.AddEmployee(worker);

            // Assert
            // Пример проверки, если есть список сотрудников
            // Assert.Contains(worker, pizzeria.Employees);
        }
    }

    [TestClass]
    public class PizzaTests
    {
        [TestMethod]
        public void Pizza_Constructor_ShouldSetProperties()
        {
            // Arrange & Act
            var pizza = new Pizza(PizzaName.Margherita, "Medium", 10.99);

            // Assert
            Assert.AreEqual(PizzaName.Margherita, pizza.Name);
            Assert.AreEqual("Medium", pizza.Size);
            Assert.AreEqual(10.99, pizza.Price);
        }

        [TestMethod]
        public void CompareTo_ShouldReturnCorrectComparison()
        {
            // Arrange
            var pizza1 = new Pizza(PizzaName.Margherita, "Medium", 10.99);
            var pizza2 = new Pizza(PizzaName.Pepperoni, "Large", 12.99);

            // Act & Assert
           
            Assert.AreEqual(0, pizza1.CompareTo(pizza1));
        }
    }

    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void Order_Constructor_ShouldSetProperties()
        {
            // Arrange & Act
            var order = new Order(1, "Pending");

            // Assert
            Assert.AreEqual(1, order.Number);
            Assert.AreEqual("Pending", order.Status);
        }

       

        [TestMethod]
        public void Create_ShouldSetOrderToCreated()
        {
            // Arrange
            var order = new Order(1, "Pending");

            // Act
            order.Create();

            // Assert
            Assert.AreEqual("Created", order.Status);
        }

        [TestMethod]
        public void Process_ShouldSetOrderToProcessed()
        {
            // Arrange
            var order = new Order(1, "Pending");

            // Act
            order.Process();

            // Assert
            Assert.AreEqual("Processed", order.Status);
        }
    }
}

