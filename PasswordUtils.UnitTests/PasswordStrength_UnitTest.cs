namespace PasswordUtils.UnitTests
{

    /*
     * 
     * Je veux donner un mot de passe � mon application, et je veux que cette application
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
        //V�rifier un mot de passe qui doit �tre faible
        [TestMethod]
        public void TestMethod1()
        {
            string lowPassword = "azerty";


            //�a doit me dire que mon mot de passe est faible
        }
    }
}