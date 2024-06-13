namespace ConsoleApp6D.Tests
{
    public class Tests
    {
        [Test]
        public void CheckUserPassword()
        {
            // arrange
            Employee employee2 = new Employee("jackski", "Jacek", "human", 46, "pS232");

            // act
            var result = employee2.password;

            // assert
            Assert.AreEqual("pS232", result);
        }
    }
}