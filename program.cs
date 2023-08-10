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

            Substraction substraction = new Substraction(30, 20);
            Console.WriteLine("Substraction : " + calculation.calculateOperation(substraction));
            
            Console.ReadKey();
        }
}