namespace PasswordUtils.UnitTests
{

    /*
     * 
     * Je veux donner un mot de passe à mon application, et je veux que cette application
     * me dise la robustesse de ce mot de passe 
     *  
     * faible -> 0 - 1
     * moyen -> 2 - 3 
     * fort -> 4
     * invincible -> 5
     * 
     * + de 8 de longueur -> 1pt ok
     * + de 12 de longueur -> 1pt ok
     * Maj et MIN -> 1pt ok 
     * alpha et numeric -> 1pt ok
     * carcatères spéciaux -> 1pt ok
     * 
     * IIII -> Fort
     * APIUHIreztreztKJHB123654
     * * 
    */

    [TestClass]
    public class PasswordStrength_UnitTest
    {
        //Vérifier un mot de passe qui doit être faible
        [TestMethod]
        public void Password_ShouldBeWeak()
        {
            string lowPassword = "azertgdse";

            //ça doit me dire que mon mot de passe est faible
            PasswordStrength result = PasswordTester.GetStrengthPassword(lowPassword);

            Assert.AreEqual(PasswordStrength.Weak, result, "This password " + lowPassword + " should be weak, but your program said that is " + result);
        }

        [TestMethod]
        public void Password_ShouldBeNormal()
        {
            string normalPassword = "MAl12311qq";

            PasswordStrength result = PasswordTester.GetStrengthPassword(normalPassword);

            Assert.AreEqual(PasswordStrength.Normal, result, "This password " + normalPassword + " should be normal, but your program said that is " + result);
        }

        [TestMethod]
        public void Password_ShouldBeStrong()
        {
            string strongPassword = "APIUHIreztreztKJHB123654";

            PasswordStrength result = PasswordTester.GetStrengthPassword(strongPassword);

            Assert.AreEqual(PasswordStrength.Strong, result, "This password "+strongPassword+" should be Strong, but your program said that is "+result);
        }

        [TestMethod]
        public void Password_ShouldBeInvincible()
        {
            string invinciblePassword = "APIUHIreztreztKJHB123654$$$";

            PasswordStrength result = PasswordTester.GetStrengthPassword(invinciblePassword);

            Assert.AreEqual(PasswordStrength.Invincible, result, "This password " + invinciblePassword + " should be Invincible, but your program said that is " + result);
        }
    }
}