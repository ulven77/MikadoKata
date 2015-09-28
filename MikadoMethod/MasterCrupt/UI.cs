namespace MasterCrupt
{
    public class UI
    {
        private Application application = new Application();
        private string leeted;

        public string EncryptMessage(string unLeeted)
        {
            application.Leet(unLeeted, this);
            return "Leeted: " + leeted;
        }

        public void SetLeeted(string leeted)
        {
            this.leeted = leeted;
        }
    }
}
