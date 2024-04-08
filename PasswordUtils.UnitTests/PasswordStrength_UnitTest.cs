namespace PasswordUtils.UnitTests
{

    /*
     * 
     * Je veux donner un mot de passe à mon application, et je veux que cette application
     * me dise la robustesse de ce mot de passe 
     *  
     * faible -> - de 8 de longueur quoiqu'il arrive, faible
     * moyen -> + de 8 de longueur
     * fort -> + de 8 de longueur & (alpha + numeric)
     * 
    */

    [TestClass]
    public class PasswordStrength_UnitTest
    {
        //Vérifier un mot de passe qui doit être faible
        [TestMethod]
        public void Password_ShouldBeWeak()
        {
            string lowPassword = "azerty";

            //ça doit me dire que mon mot de passe est faible
            PasswordStrength result = PasswordTester.GetStrengthPassword(lowPassword);

            Assert.AreEqual(PasswordStrength.Weak, result, "This password " + lowPassword + " should be weak, but your program said that is " + result);
        }

        [TestMethod]
        public void Password_ShouldBeNormal()
        {
            string normalPassword = "azertyuiopp";

            PasswordStrength result = PasswordTester.GetStrengthPassword(normalPassword);

            Assert.AreEqual(PasswordStrength.Normal, result, "This password " + normalPassword + " should be normal, but your program said that is " + result);
        }

        [TestMethod]
        public void Password_ShouldBeStrong()
        {
            string strongPassword = "APIUHIEHBHBKJHB123654";

            PasswordStrength result = PasswordTester.GetStrengthPassword(strongPassword);

            Assert.AreEqual(PasswordStrength.Strong, result, "This password "+strongPassword+" should be Strong, but your program said that is "+result);
        }
    }
}