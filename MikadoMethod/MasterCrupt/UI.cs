namespace MasterCrupt
{
    public class UI
    {
        private Application application = new Application();
        private string leeted;

        public string EncryptMessage(string unLeeted, int customerType)
        {
            application.Leet(unLeeted, this, customerType);
            return "Leeted: " + leeted;
        }

        public void SetLeeted(string leeted)
        {
            this.leeted = leeted;
        }
    }
}
