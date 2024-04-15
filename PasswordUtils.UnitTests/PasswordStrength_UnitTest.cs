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
     * IIII
     * Comp!exP@ss
     * * 
    */

    [TestClass]
    public class PasswordStrength_UnitTest
    {
        //Vérifier un mot de passe qui doit être faible
        [TestMethod]
        public void Password_ShouldBeWeak()
        {
            List<string> lowPasswords = new List<string>()
            {
                "password",
                "123456",
                "abcdef",
                "qwerty",
                "letmein",
                "111111",
                "admin",
                "123456789",
                "welcome",
                "login"
            };

            foreach(var lowPassword in lowPasswords)
            {
                //ça doit me dire que mon mot de passe est faible
                PasswordStrength result = PasswordTester.GetStrengthPassword(lowPassword);
                Assert.AreEqual(PasswordStrength.Weak, result, "This password " + lowPassword + " should be weak, but your program said that is " + result);
            }
        }

        [TestMethod]
        public void Password_ShouldBeNormal()
        {
            List<string> normalPasswords = new List<string>()
            {
                "Passw0rd",
                "Summer2022",
                "3x@mpl3!",
                "SecurePwd123",
                "Ninja1234",
                "P@ssw0rd",
                "SuperSecret!",
                "H3ll0W0rld",
                "November21",
                "MAl12311qq"
            };
             
            foreach (var normalPassword in normalPasswords)
            {
                PasswordStrength result = PasswordTester.GetStrengthPassword(normalPassword);

                Assert.AreEqual(PasswordStrength.Normal, result, "This password " + normalPassword + " should be normal, but your program said that is " + result);
            }
            
        }

        [TestMethod]
        public void Password_ShouldBeStrong()
        {
            List<string> strongPasswords = new List<string> {
                "P@ssword1!",
                "Comp!exP@ssword",
                "$ecureP@ssword",
                "5tr0ngP@55!",
                "L3tM3!nN0w",
                "P@ssw0rd!",
                "2024!supersecr3t",
                "H@rdT0Gu3ss!",
                "W3llD0n3!",
                "APIUHIreztreztKJHB123654"
            };

            foreach (var strongPassword in strongPasswords)
            {

                PasswordStrength result = PasswordTester.GetStrengthPassword(strongPassword);

                Assert.AreEqual(PasswordStrength.Strong, result, "This password " + strongPassword + " should be Strong, but your program said that is " + result);
            }
        }

        [TestMethod]
        public void Password_ShouldBeInvincible()
        {
            List<string> invinciblePasswords = new List<string> {
                "P@ssw0rd!2024$",
                "C0mp!exP@ssw0rd!",
                "$tr0ngP@ssw0rd!",
                "Pa$$w0rd2024$",
                "5tr0ngP@55w0rd!",
                "L3tM3!nN0w!2024",
                "P@ssw0rd!12345",
                "2024!SuperSecr3t$",
                "H@rdT0Gu3ss!2024",
                "W3llD0n3!2024",
                "APIUHIreztreztKJHB123654$$$"
            };

            foreach (var invinciblePassword in invinciblePasswords)
            {
                PasswordStrength result = PasswordTester.GetStrengthPassword(invinciblePassword);
                Assert.AreEqual(PasswordStrength.Invincible, result, "This password " + invinciblePassword + " should be Invincible, but your program said that is " + result);
            }

        }
    }
}