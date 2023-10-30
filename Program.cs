Player player1 = new HumanPlayer();
ComputerPlayer computer1 = new RandomComputer();
int End = 1;
string selection;

System.Console.Write("Enter Your Name: ");
player1.Name = System.Console.ReadLine();
int c=0;
int p=0;
System.Console.WriteLine($"Hello Mr.{player1.Name}");
while (End == 1)
{
    System.Console.WriteLine("Are You Ready?  ");
    for (int i = 0; i < 3; i++)
    {
        System.Console.Write("Choose between(Rock,Paper,Scissors)(1,2,3): ");
        int number = Convert.ToInt16(System.Console.ReadLine());
        selection = player1.Choice[number-1];

        player1.Choose(selection);
        computer1.rasgele = computer1.random.Next(0, 3);
        string str = computer1.Choice[computer1.rasgele];
        computer1.Choose(str);
        System.Console.WriteLine($"Your Choice: {selection} The Computer: {str}");
        if (str == "Rock"&& selection =="Scissors")
        {
            c++;
            System.Console.WriteLine($"You lost!! com: {c} {player1.Name}: {p}");
        }
        else if (str == "Rock"&& selection =="Paper")
        {
            p++;
            System.Console.WriteLine($"You win!! com: {c} {player1.Name}: {p}");
        }
        else if (str == "Paper"&&selection == "Rock")
        {
            c++;
            System.Console.WriteLine($"You lost!! com: {c} {player1.Name}: {p}");
            
        }
        else if (str == "Paper"&&selection == "Scissors")
        {
            p++;
            System.Console.WriteLine($"You win!! com: {c} {player1.Name}: {p}");
            
        }
        else if (str == "Scissros"&&selection == "Paper")
        {
            c++;
            System.Console.WriteLine($"You lost!! com: {c} {player1.Name}: {p}");
            
        }
        else if (str =="Scissors"&&selection == "Rock")
        {
            p++;
            System.Console.WriteLine($"You win: {c} {player1.Name}: {p}");
            
        }
        else{
            System.Console.WriteLine($"It is Draw com: {c} {player1.Name}: {p}");

        }


    }
    System.Console.Write("Do You Want Other 3 Tries? (press 1 for yes and any number for no):");
    End = Convert.ToInt16(Console.ReadLine());
    if (End!=1)
    {
        System.Console.WriteLine("The Game is over");
    }
}
if (p>c)
{
    System.Console.WriteLine($"Congratulaion!! you win!! com: {c} {player1.Name}: {p}");
}
else if (p<c)
{
    System.Console.WriteLine($"Infortunatily!! you lost!! com: {c} {player1.Name}: {p}");
    
}
else{
    System.Console.WriteLine($"It Is A Draw!!! com: {c} {player1.Name}: {p}");
    
}