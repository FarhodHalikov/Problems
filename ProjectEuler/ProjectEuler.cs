static class ProjectEuler
{

    /// <summary>
    /// Calculate summary of all numbers divisable by 3 OR 5 in range 1000
    /// </summary>
    public static void PE_1()
    {
        //init variables
        List<int> list = new();
        int sum = 0;

        //Add all numbers in range 1000 to list those  divisable by 3 or 5
        for (int i = 3; i < 1000; i++)
            if (i % 3 == 0 || i % 5 == 0)
                list.Add(i);

        //Sum the 'nums'
        foreach (var item in list)
            sum += item;

        //Output
        System.Console.WriteLine(sum);
    }

    /// <summary>
    /// Calculate summary of even Fibonacci numbers whose values do not exceed 4 millions
    /// </summary>
    public static void PE_2()
    {
        //init
        int i = 0;
        int sum = 0;

        //Recursive Fibonacci Number Method
        static int Fibonacci(int number)
        {
            //Base case
            if (number < 2)
                return number;

            //Formula F(n) = F(n-1) + (Fn-2)
            else return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        //Sum of even fibonacci numbers whose values are less than 4_000_000
        while (Fibonacci(i) < 4_000_000)
        {
            if (int.IsEvenInteger(Fibonacci(i)))
                sum += Fibonacci(i);
            i++;
        }

        //Output 
        System.Console.WriteLine(sum);
    }
}