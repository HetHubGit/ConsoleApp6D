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
        [Test]
        public void TwoStringsShouldBeEqual()
        {
            // arrange
            string a = "I see";
            string b = "I see";

            //act

            //assert
            Assert.AreEqual(a, b);
        }


        private Employee GetEmployee(string login, string name, string surname, int age, string password)
        {
            return new Employee(login, name, surname, age, password);
        }
        [Test]
        public void ObjectTest()
        {
            //arrange
            var employee1 = GetEmployee("LoginTest", "Worker", "Hetmanska", 5, "pS464");
            var employee2 = GetEmployee("LoginTest", "Worker", "Hetmanska", 5, "pS464");
            //act
            //assert
            Assert.AreNotEqual(employee1, employee2);
        }
    }
}
