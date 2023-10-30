public abstract class ComputerPlayer
{
    public string[] Choice = new string[]{"Rock","Paper","Scissros"};
    public abstract string Choose(string choise);
    // Random random = new Random();
    // private int rasgele = random.Next(0, 3);
    public Random random = new Random();
    public int rasgele { get; set; }
    public ComputerPlayer()
    {
    rasgele = random.Next(0, 3);
        
    }

    
}