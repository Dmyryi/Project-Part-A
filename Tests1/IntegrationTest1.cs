
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
            // ѕример проверки, если есть список сотрудников
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
