namespace FactsWebApp.Models
{
    public class Fact
    {
        public int Id { get; set; }
        public string FactQuestion { get; set; }
        public string FactAnswer { get; set;}

        public Fact()
        {
            
        }
    }
}
