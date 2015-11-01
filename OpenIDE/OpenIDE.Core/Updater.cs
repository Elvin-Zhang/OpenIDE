using updateSystemDotNet;

namespace OpenIDE.Core
{
    public static class Updater
    {
        private static updateController updController;

        static Updater()
        {
            updController = new updateController();
            updController.updateUrl = "http://furesoft.de/update/openide";
            updController.projectId = "7062637b-ad46-4a34-b261-5af105874382";
            updController.publicKey = "<RSAKeyValue><Modulus>2s+M0OaN71CKZbuTctXhiY8j0h2NeEogEIHhLuBT2OOOkez6qsQ9+n4hJ40EX2hvwClCYXsV2RK3WwJm/SlunIXiCjGnaRNhfCNqU5nfoZ9GXpSGixYi55s099KrngtAEgt2dPYZTN1aKjXE0xVAWXiY1ukgRbMye0GwgCiXccsns3k8gIGrtssgb5gQGwPvm8Lp10RUk7fsNHbKiI2oK7zpP8+CIwO7kAOTkxy+xuB+Ki9QW6y/I9SJYf/mF5IvGPNOmpXDMLlPNhtLinGcOdF3Jfv+PaBDrEvf3dEi0M4yP93TQY96JCzTx/f/0PUyHmu954DAM9Y6H/fhWWxP5YN+iD1iEaqgSvv/gozuJOdDU31lmb3VtZZl016WzgiJ4G+sTUxHssbI41Ec70IsqHaI6OkLSAKbgqGvQD9HFxbD2weUJrj6KMrBtuYHQFddyAGxNbwMuBX1edZDs2prdx/Wjd436nnZdiWhgGx0ZMV0+9pDO+hbVDQQehKR4wxz8RdtM2BtaoYDyBnQv5V0+pWhV6Io+nYln5lhmgYW6/QtQh6SNZXoTDtMGZRdtydZRPs5dll9ltDhYxJxsJj0l1rOjqPsT8vBiXe5meMuRzXHPDNJ6S4FLVmLLi6kqqvk8E6cAXVe/6Kc6Qop5NLoBN9vZet5kEV3/HBu1gKV4sc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

            updController.releaseFilter.checkForFinal = true;
            updController.releaseFilter.checkForBeta = true;
            updController.releaseFilter.checkForAlpha = true;

            updController.restartApplication = true;
            updController.retrieveHostVersion = true;
            updController.autoCloseHostApplication = true;
            updController.Language = Languages.English;

            updController.autoCloseHostApplication = true;
        }

        public static void Update()
        {
            updController.updateInteractive();
        }

        public static bool IsUpdateAvailable() => updController.checkForUpdates();
    }
}