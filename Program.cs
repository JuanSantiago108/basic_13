// static string SayHello(string firstName = "buddy")
// {
//     return $"Hey, {firstName}";
// }
// string greeting;
// greeting = SayHello();
// Console.WriteLine(greeting);


// static void PrintNumbers(int num = 255)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         Console.WriteLine(i);
//     }
// }

// PrintNumbers();


// static void PrintOdds(int num = 255)
// {
//     for (int i = 0; i <= num; i++)
//     {
//         if (i % 2 != 0)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }

// PrintOdds();


// static void PrintSum()
// {
//     int sum = 0;
//     for (int i = 0; i <= 255; i++)
//     {
//         sum += i;
//         Console.WriteLine($"Numer: {i}, Sum: {sum} ");
//     }
// }
// PrintSum();



int[] numbers = { 10, 100, 20, -10, -20, 30, 40, 60, 50, -100 };

// static void LoopArray(int[] numbers)
// {
//     foreach (int num in numbers)
//     {
//         Console.WriteLine(num);
//     }
// }
// LoopArray(numbers);

// static int FindMax(int[] numbers)
// {
//     int max = 0;
//     foreach (int num in numbers)
//     {
//         if( num > max)
//         {
//             max = num;
//         }
//     }
//     return max;
// }

// Console.WriteLine(FindMax(numbers));


// static void GetAverage(int[] numbers)
// {
//     int result = 0;

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         result += numbers[i];
//     }
//     int average = (int)result / numbers.Length;
//     Console.WriteLine(average);
// }

// GetAverage(numbers);




// static int[] OddArray()
// {
//     int[] arryOne = new int[]{};// this how you declare a empty parameter
//     List<int> oddList = new List<int>();
//     for (int i = 0; i <= 255; i++)
//     {
//         if (i % 3 == 0)
//         {
//             oddList.Add(i);
//         }
//     }
//     arryOne = oddList.ToArray();
//     return arryOne;
// }

// int[] arrayTest = OddArray();

// foreach (int num in arrayTest)
// {
//     Console.WriteLine(num);
// }

// static int GreaterThanY(int[] numbers, int y)
// {
//     int count = 0;
//     for( int i = 0; i<numbers.Length; i++)
//     {
//         if( y <numbers[i])
//         {
//             count++;
//         }
//     }
//     return count;

// } 

// Console.WriteLine(GreaterThanY(numbers, 40));



// static void SquareArrayValues(int[] numbers)
// {
//     for( int i = 0; i<numbers.Length; i++)
//     {
//         numbers[i] *= numbers[i];
//         Console.WriteLine(numbers[i]);
//     }
// }
// SquareArrayValues(numbers);


static void MinMaxAverage(int[] numbers)
{
    int sum = 0;
    int max = 0;
    int min = numbers[3];
    foreach (int num in numbers)
    {
        sum += num;
        if (num > max)
        {
            max = num;
        }
        if (num < min)
        {
            min = num;
        }
        Console.WriteLine(max);
        Console.WriteLine(min);
    }
    int average = sum / numbers.Length;
    Console.WriteLine(average);
}

MinMaxAverage(numbers);


static void ShiftValues(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i == numbers.Length - 1)
        {
            numbers[i] = 0;
        }
        else
        {
            numbers[i] = numbers[i + 1];
        }
        Console.WriteLine(numbers[i]);
    }
}
ShiftValues(numbers);


static object[] NumToString(int[] numbers)
{
    object[] arryOne = new object[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            arryOne[i] = "Dojo";
        }
        else
        {
            arryOne[i] = numbers[i];
        }
    }
    return arryOne;
}

object[] result = NumToString(numbers);

foreach (object item in result)
{
    Console.WriteLine(item);
}
