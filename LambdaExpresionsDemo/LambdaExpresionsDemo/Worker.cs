using System;

namespace LambdaExpresionsDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            int a = 10;
            int b = 20;

            Func<int, int, int> multiplyDelegate;// = (x, y) => x * y;
            multiplyDelegate = Multiply;
            int product = multiplyDelegate(a, b);
            Console.WriteLine($"Result: {product}");

            Func<int, int, int> multiplyDelegate2 = (x, y) => (x * y); // linia 22 i 23 do kupy to: int product2 = ((Func<int, int, int>) ((x, y) => (x * y)))(a, b);
            int product2 = multiplyDelegate2(a, b);
            Console.WriteLine($"Result2: {product2}");

        }

        public int Multiply(int x, int y)
        {
            return x*y;
        }
    }
}
