using System.Reflection.Metadata;

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Console.Write("Enter an integer: ");

            // Read the integer input
            int number = Convert.ToInt32(Console.ReadLine());

            // Loop through numbers from 1 to the entered number
            Console.WriteLine("Numbers from 1 to " + number + ":");
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            Console.Write("Enter an integer: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication Table for {number}:");

            // Loop through 1 to 12 to generate the multiplication table
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            // Print all even numbers from 1 to the entered number
            Console.WriteLine("Even numbers between 1 and " + num + ":");

            for (int i = 2; i <= num; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            Console.Write("Enter the base (integer): ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the exponent (integer): ");
            int exponent = int.Parse(Console.ReadLine());
            double result = Math.Pow(baseNum, exponent);

            Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {result}");

            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.

            int subject1, subject2, subject3, subject4, subject5;
            int total;
            double average, percentage;

            // Input marks for each subject
            Console.Write("Enter marks for subject 1: ");
            subject1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for subject 2: ");
            subject2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for subject 3: ");
            subject3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for subject 4: ");
            subject4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for subject 5: ");
            subject5 = Convert.ToInt32(Console.ReadLine());

            // Calculate total, average, and percentage
            total = subject1 + subject2 + subject3 + subject4 + subject5;
            average = total / 5.0; // Ensure the division is in floating-point
            percentage = (total / 500.0) * 100; // Total maximum marks = 500

            // Display the results
            Console.WriteLine("\nTotal Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Percentage: " + percentage + "%");
            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Reverse the string
            string reversed = ReverseString(input);

            // Print the reversed string
            Console.WriteLine("Reversed string: " + reversed);
        }

        // Function to reverse a string
        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();  // Convert string to char array
            Array.Reverse(charArray);              // Reverse the char array
            return new string(charArray);
            #endregion

            #region 7-Write a program to allow the user to enter int and print the REVERSED of it. 

            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            // Call the function to reverse the integer
            int reversedNum = ReverseInteger(num);

            // Display the reversed number
            Console.WriteLine($"The reversed integer is: {reversedNum}");
        }

        // Function to reverse the integer
        static int ReverseInteger(int num)
        {
            int reversed = 0;

            // Handle the sign of the integer
            bool isNegative = num < 0;
            num = Math.Abs(num);

            // Reverse the digits
            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            // If the number was negative, restore the sign
            if (isNegative)
            {
                reversed = -reversed;
            }

            return reversed;
            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.








            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            int decimalNumber;

            // Ask the user for input
            Console.Write("Enter a decimal number: ");
            decimalNumber = int.Parse(Console.ReadLine());

            // Handle the case where the decimal number is zero
            if (decimalNumber == 0)
            {
                Console.WriteLine("Binary representation: 0");
                return;
            }

            // Convert the decimal number to binary and print it
            Console.Write("Binary representation: ");

            // Loop to extract and print each binary digit
            while (decimalNumber > 0)
            {
                // Print the current least significant bit (remainder of division by 2)
                Console.Write(decimalNumber % 2);

                // Divide the number by 2 for the next iteration
                decimalNumber /= 2;
            }

            // The digits are printed in reverse order, so we need to reverse them manually
            Console.WriteLine(); // To move to the next line after the output


            #endregion

            #region -10 Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            Console.Write("x3 = ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            // Check if the points are collinear
            if (IsCollinear(x1, y1, x2, y2, x3, y3))
            {
                Console.WriteLine("The points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("The points do not lie on a single straight line.");
            }
        }

        static bool IsCollinear(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Check the condition for collinearity: (y2 - y1)*(x3 - x2) == (y3 - y2)*(x2 - x1)
            return (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);
        }
    


        #endregion

            #region 11-Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.        
                Console.Write("Enter the size of the matrix (n): ");
              int n = int.Parse(Console.ReadLine());

             // Printing the identity matrix of size n * n
             for (int i = 0; i<n; i++)  // Loop for rows
               {
             for (int j = 0; j<n; j++)  // Loop for columns
               {
                if (i == j)  // Check if it's a diagonal element
                {
                    Console.Write("1 ");  // Diagonal element is 1
                }
                else
                {
                    Console.Write("0 ");  // Other elements are 0
                }
            }
            Console.WriteLine();  // Move to the next line after each row
}

#region 12- Write a program in C# Sharp to find the sum of all elements of the array.
//

int[] numbers = { 1, 2, 3, 4, 5 };

// Initialize a variable to store the sum
int sum = 0;

// Loop through each element in the array and add it to the sum
foreach (int number in numbers)
{
    sum += number;
}

// Output the result
Console.WriteLine("The sum of all elements in the array is: " + sum);
#endregion

#region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

///
/// 
int n = array1.Length;
int[] mergedArray = new int[2 * n];

int i = 0, j = 0, k = 0;

// Merge arrays until one of them is fully traversed
while (i < n && j < n)
{
    if (array1[i] < array2[j])
    {
        mergedArray[k++] = array1[i++];
    }
    else
    {
        mergedArray[k++] = array2[j++];
    }
}

// If any elements left in array1, add them to mergedArray
while (i < n)
{
    mergedArray[k++] = array1[i++];
}

// If any elements left in array2, add them to mergedArray
while (j < n)
{
    mergedArray[k++] = array2[j++];
}

return mergedArray;
    }

    static void Main(string[] args)
{
    // Input two sorted arrays of the same size
    Console.WriteLine("Enter the size of the arrays:");
    int size = int.Parse(Console.ReadLine());

    int[] array1 = new int[size];
    int[] array2 = new int[size];

    Console.WriteLine("Enter elements of the first sorted array:");
    for (int i = 0; i < size; i++)
    {
        array1[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Enter elements of the second sorted array:");
    for (int i = 0; i < size; i++)
    {
        array2[i] = int.Parse(Console.ReadLine());
    }

    // Merge the arrays
    int[] mergedArray = MergeSortedArrays(array1, array2);

    // Display the merged array
    Console.WriteLine("Merged array in sorted order:");
    foreach (int element in mergedArray)
    {
        Console.Write(element + " ");
    }


    #endregion

    #region 14- Write a program in C# Sharp to count the frequency of each element of an array.
    int[] arr = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5 };

    // Dictionary to store the frequency of each element
    Dictionary<int, int> frequency = new Dictionary<int, int>();

    // Loop through the array
    foreach (int num in arr)
    {
        if (frequency.ContainsKey(num))
        {
            frequency[num]++;  // If the number is already in the dictionary, increment its count
        }
        else
        {
            frequency[num] = 1;  // If the number is not in the dictionary, add it with count 1
        }
    }

    // Output the frequency of each element
    Console.WriteLine("Element Frequency:");
    foreach (var entry in frequency)
    {
        Console.WriteLine($"Element {entry.Key} appears {entry.Value} times.");
    }













    #endregion

    #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
    
    int[] numbers = { 34, 78, 12, 99, 21, 56, 45 };

    // Calling the function to find the max and min
    FindMaxMin(numbers);
}

static void FindMaxMin(int[] arr)
{
    // Initializing max and min as the first element of the array
    int max = arr[0];
    int min = arr[0];

    // Loop through the array to find the max and min
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }

   
    Console.WriteLine("Maximum element in the array: " + max);
    Console.WriteLine("Minimum element in the array: " + min);


    #endregion

    #region 16- Write a program in C# Sharp to find the second largest element in an array.
    Console.WriteLine("Enter the number of elements in the array:");
    int n = int.Parse(Console.ReadLine());

    // Declare an array of size n
    int[] arr = new int[n];

    // Take array elements as input
    Console.WriteLine("Enter the elements of the array:");
    for (int i = 0; i < n; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }

    // Check if there are enough elements
    if (n < 2)
    {
        Console.WriteLine("Array must have at least two elements.");
        return;
    }

    // Initialize the first and second largest elements
    int largest = int.MinValue;
    int secondLargest = int.MinValue;

    // Traverse the array to find the largest and second largest elements
    for (int i = 0; i < n; i++)
    {
        if (arr[i] > largest)
        {
            secondLargest = largest; // Update second largest
            largest = arr[i]; // Update largest
        }
        else if (arr[i] > secondLargest && arr[i] != largest)
        {
            secondLargest = arr[i]; // Update second largest
        }
    }

    // If second largest is still the minimum value, there is no valid second largest
    if (secondLargest == int.MinValue)
    {
        Console.WriteLine("There is no second largest element.");
    }
    else
    {
        Console.WriteLine("The second largest element is: " + secondLargest);
    }






    #endregion

    #region Q17 - Write a program to input the month number and print the number of days in that month.
    /// Example
    /// Input: Month Number: 1
    /// Output: Days in Month: 31


    #endregion

    #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

    // Define the dimensions of the arrays (e.g., 2x3 array)
    int rows = 2;
    int cols = 3;

    // Declare two 2D arrays of the same size
    int[,] firstArray = new int[rows, cols];
    int[,] secondArray = new int[rows, cols];

    // Input values for the first array
    Console.WriteLine("Enter values for the first array:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"Enter value for position [{i},{j}]: ");
            firstArray[i, j] = int.Parse(Console.ReadLine());
        }
    }

    // Copy elements from firstArray to secondArray
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            secondArray[i, j] = firstArray[i, j];
        }
    }

    // Print the second array
    Console.WriteLine("\nSecond array after copying elements from the first array:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(secondArray[i, j] + " ");
        }
        Console.WriteLine();
    }



    #endregion
    #region 20- Write a Program to Print One Dimensional Array in Reverse Order
    // Declare and initialize the array
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    // Print the array in reverse order
    Console.WriteLine("Array in reverse order:");

    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        Console.Write(numbers[i] + " ");
    }

    Console.WriteLine(); // To move to the next line after printing the 
    #endregion




}
}