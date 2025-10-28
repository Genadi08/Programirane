namespace prostiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vliza spisuk ot shisla i programata vrucha spisuk
            //programata poema ili vkarva spisuk ot int-ove {list}  
            Console.WriteLine("Input number");
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            PrimeNumbers sito = new PrimeNumbers();
            List<int> resPrimeNumber = sito.FindPrimeNumbers(list);
            foreach (int item in resPrimeNumber)
            {
                Console.WriteLine(item + " ,  ");
            }
            {
                Console.WriteLine(string.Join(", ", list));
            }
        }
    }
}
