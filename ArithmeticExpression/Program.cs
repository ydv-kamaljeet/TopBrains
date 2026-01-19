namespace Question6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter operation string in format : {num1 operation num2} - separated by spaces.");
            string? input = Console.ReadLine();
            List<string> literals = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList(); 
            try
            {
                if(literals.Count()<3)
                    throw new InsufficientInputException();

                if(!int.TryParse(literals[0],out int num1) || !int.TryParse(literals[2],out int num2))
                    throw new InvalidInputException();

                switch (literals[1])
                {
                    case "+" : 
                        Console.WriteLine($"{num1} + {num2} = {num1+num2}");
                        break;
                    case "-":
                        Console.WriteLine($"{num1} - {num2} = {num1-num2}");
                        break;
                    case "*":
                        Console.WriteLine($"{num1} * {num2} = {num1*num2}");
                        break;
                    case "/":
                        if(num2!=0)
                            Console.WriteLine($"{num1} / {num2} = {num1/num2}");
                        else
                            throw new DivideByZeroException();
                        break;
                    default:
                        throw new UnknownOperatorException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class InvalidInputException : Exception
    {
        public override string Message => "Invalid Number Input.";
    }
    public class UnknownOperatorException : Exception
    {
        public override string Message => "Invalid Operator Input.";
    }
    public class InsufficientInputException : Exception
    {
        public override string Message => "Insufficient Input.";
    }
}