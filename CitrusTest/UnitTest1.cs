using PractTask;
namespace CitrusTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodInput()
        {
            var expectedName = "Apple";
            var expectedColor = "Red";
            var expectedVitaminC = 3;
            Citrus citrus = new Citrus();

            var inputString = $"Apple{Environment.NewLine}Red{Environment.NewLine}{3}";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Console.SetIn(new StringReader(inputString));

                var result = citrus.Input();

                Assert.AreEqual(expectedName, result.Name);
                Assert.AreEqual(expectedColor, result.Color);
                Assert.AreEqual(expectedVitaminC, citrus.VitaminC);
            }
        }
        public void TestMethodPrint()
        {
            // Arrange
            Citrus citrus = new Citrus();
            var citruses = new List<Fruit>
            {
                new Citrus { Name = "Apple", Color = "Red", VitaminC = 1 },
                new Citrus { Name = "Banana", Color = "Yellow", VitaminC = 2 },
                new Citrus { Name = "Orange", Color = "Orange", VitaminC = 3 }
            };
            var expectedOutput = $"Apple - Red {1}{Environment.NewLine}"+
                                 $"Banana - Yellow {2}{Environment.NewLine}" +
                                 $"Orange - Orange {3}{Environment.NewLine}";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                citrus.Print(citruses);

                // Assert
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }
    }
}