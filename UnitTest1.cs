using SignInLib;
namespace UnitTest1
{
    [TestClass]
    
    public class UnitTest1
    {
         [TestMethod]
        public void SuccessMethod()
        {
            string expResult = "valid user";
            Assert.AreEqual(expResult, SignInTest.Authenticate("Sam", "sam@1256"));
        }
        [TestMethod]
        public void FailMethod()
        {
            string expResult = "Invalid user Credentials";
            Assert.AreEqual(expResult, SignInTest.Authenticate("ravi", "ravi@1234"));
        }
        [TestMethod]
        public void AnonymousMethod()
        {
            string expResult = "You must provide username and password";
            Assert.AreEqual(expResult, SignInTest.Authenticate(null, null));
        }
    }


}