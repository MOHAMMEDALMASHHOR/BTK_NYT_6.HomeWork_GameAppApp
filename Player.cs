public abstract class Player
{
    public string? Name { get; set; }
    public List<string> Choice = new List<string>(){"Rock","Paper","Scissros"};
    public abstract string Choose(string choise);
}