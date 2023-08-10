internal class Division : IOperation
{
    private int num1 { get; set; }
    private int num2 { get; set; }

    public Division(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public int Perform()
    {
        try{
            return num1 / num2;
        }
        catch(DivideByZeroException ex){
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        
    }
}