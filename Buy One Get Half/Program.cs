namespace Buy_One_Get_Half
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Buy One Get Half App");
            double priceOfTShirt = 0;
           if (!ReadNumber("price Of T-Shirt", out priceOfTShirt))return;
            double numberOfTShirt = 0;
            if (!ReadNumber("Number Of T-Shirt", out numberOfTShirt)) return;
          
            if (numberOfTShirt%2==0)
            {
               
                Console.WriteLine($"Total Cost = {numberOfTShirt* (priceOfTShirt+(priceOfTShirt*0.5))} ");
            }
            else if (numberOfTShirt % 2 == 1)
            {
                Console.WriteLine($"Total Cost = {(numberOfTShirt * (priceOfTShirt + (priceOfTShirt * 0.5)))+priceOfTShirt} ");
            }

            Console.ReadKey();
        }


        static bool ReadNumber(string field, out double number)
        {
            Console.WriteLine($"Please Enter {field}");
            
            bool isConverted=double.TryParse(Console.ReadLine(), out number);
            if (!isConverted)
            {
                Console.WriteLine("Please Enter Valid Number");
                return false;
            }

            return true;

        }
    }
}
