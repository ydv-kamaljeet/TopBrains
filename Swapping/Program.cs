namespace Question3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Number Num1 : ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                    throw new Exception();

                Console.Write("Enter Number Num2 : ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                    throw new Exception();
                
                //Swaping by Value :(Original Value won't change)
                SwapByValue(num1,num2);
                Console.WriteLine($"Using SwapByValue\nNum1 : {num1}  Num2 : {num2}");
                //Swaping by reference :
                SwapByRef(ref num1, ref num2);
                Console.WriteLine($"Using SwapByRef\nNum1 : {num1}  Num2 : {num2}");
            }
            catch (Exception)
            {
                Console.WriteLine("Enter Valid input.");
            }

        }

        public static void SwapByValue(int num1, int num2)
        {
            int temp = num1;
            num1=num2;
            num2=temp;
        }
        public static void SwapByRef(ref int num1, ref int num2)
        {
            int temp = num1;
            num1=num2;
            num2=temp;   
        }
    }
}