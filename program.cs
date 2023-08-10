internal class Calculation
{
        public int calculateOperation(IOperation operationType)
        {
            return operationType.Perform();
        }

        static void Main(string[] args)
        {
            
            Calculation calculation = new Calculation();

            Addition addition = new Addition(20, 30);
            Console.WriteLine("Addition : " + calculation.calculateOperation(addition));
            
            Console.ReadKey();
        }
}