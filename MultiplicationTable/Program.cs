namespace Question2
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter Number N : ");
                if (!int.TryParse(Console.ReadLine(), out int n))
                    throw new Exception();

                Console.Write("Enter Number Upto : ");
                if (!int.TryParse(Console.ReadLine(), out int upto))
                    throw new Exception();

                int[] multiplicationRow = Multiplication(n, upto);

                foreach (int item in multiplicationRow)
                {
                    Console.Write(item + " ");
                }
            }
            catch (Exception ecp)
            {
                Console.WriteLine($"Enter Valid Input.\nError Message : {ecp.Message}");
            }

        }


        public static int[] Multiplication(int n, int upto)
        {
            int[] multiplicationRow = new int[upto];
            for (int i = 1; i <= upto; i++)
            {
                multiplicationRow[i - 1] = n * i;
            }

            return multiplicationRow;
        }
    }
}