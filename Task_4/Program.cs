namespace Task_4
{
    public class Program 
    {
        public static void Main(string[] args)
    {
        Player player1 = new Player();
            Console.WriteLine(player1.playerName);
            Console.WriteLine(player1.level);
            Console.WriteLine(player1.health);



            Player player2 = new Player("Madan", 3, "Bad");
            Console.WriteLine(player2.playerName);
            Console.WriteLine(player2.level);
            Console.WriteLine(player2.health);

        }
}
    
}