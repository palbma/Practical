using PractTask;
namespace TestClassFruit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodInput()
        {
            // Arrange        
            var expectedName = "Apple";
            var expectedColor = "Red";

            Fruit fruit = new Fruit();

            var inputString = $"Apple{Environment.NewLine}Red";

            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Console.SetIn(new StringReader(inputString));
                // act
                var result = fruit.Input();

                Assert.AreEqual(expectedName, result.Name);
                Assert.AreEqual(expectedColor, result.Color);
            }
        }
        public void TestMethodPrint()
        {
            // Arrange
            Fruit fruit = new Fruit();
            var fruits = new List<Fruit>
            {
                new Fruit { Name = "Apple", Color = "Red" },
                new Fruit { Name = "Banana", Color = "Yellow" },
                new Fruit { Name = "Orange", Color = "Orange" }
            };
            var expectedOutput = $"Apple - Red{Environment.NewLine}" +
                                 $"Banana - Yellow{Environment.NewLine}" +
                                 $"Orange - Orange{Environment.NewLine}";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                fruit.Print(fruits);

                // Assert
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }
    }
}