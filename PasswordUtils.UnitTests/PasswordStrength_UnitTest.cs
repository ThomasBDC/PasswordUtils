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
        public void TestMethod1()
        {
            string lowPassword = "azerty";


            //ça doit me dire que mon mot de passe est faible
        }
    }
}