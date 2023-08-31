namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            string answer = Methods.Add(4, 6, true);
            Console.WriteLine(answer);

            //alternatively can write as such:
            //Console.WriteLine(Methods.Add(0, -1, true));
        }
    }
}
