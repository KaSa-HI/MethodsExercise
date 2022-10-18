using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("What is your favourite Color? ");
            string favouriteColor = Console.ReadLine();
            Console.Write("What is your favourite Animal? ");
            string favouriteAnimal = Console.ReadLine();
            Console.Write("What is your favourite Band? ");
            string favouriteBand = Console.ReadLine();

            string answer = $"Hello, {name}. I see your favourite colour is {favouriteColor}. " +
                $"At this point in time, you like {favouriteAnimal}. You are into music from {favouriteBand}.";
            Console.WriteLine(answer);
            #endregion


            #region Exercise 2
            Console.Write("Enter Number: ");
            var left = int.Parse(Console.ReadLine());


            Console.Write("Enter Another Number: ");
            var right = int.Parse(Console.ReadLine());


            var result = Add(left, right);
            Console.WriteLine($"{left} plus {right} = {result}");

             result = Subtract(left, right);
            Console.WriteLine($"{left} subtract {right} = {result}");

             result = Multiply(left, right);
            Console.WriteLine($"{left} multiply {right} = {result}");

             result = Divide(left, right);
            Console.WriteLine($"{left} divide {right} = {result}");

             result = Modulus(left, right);
            Console.WriteLine($"{left} modulus {right} = {result}");

             result = Sum(left, right,4,5,7,0,1,50000);
            Console.WriteLine($"sum({left},{right},4,5,7,0,1,50000) = {result}");



            #endregion
        }

        public static int Add(int left, int right)
        {
            return left + right;
        }

        public static int Sum(params int[] values)
        {
            int retval = 0;
            for (int i = 0; i < values.Length; i++)
                retval = retval + values[i];
            return retval;
        }

        public static int Subtract(int left, int right)
        {
            return left - right;
        }
        
        public static int Multiply(int left, int right)
        {
            return left * right;
        }
        
        public static int Divide(int left, int right)
        {
            return left / right;
        }
        
        public static int Modulus(int left, int right)
        {
            return left % right;
        }
        

    }
      
}
