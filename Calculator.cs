         
            Console.WriteLine("Calculator");
            Console.WriteLine("--------------------");
        
        
            // Start of the program with a label for looping back
            Start:

// Prompt user to enter the first number
            Console.WriteLine("First number:");
            int a = int.Parse(Console.ReadLine());

// Ask user to choose an arithmetic operation
            Console.WriteLine("Select an operation ===> + , - , * , /");
            string c = Console.ReadLine();

// Prompt user to enter the second number
            Console.WriteLine("Second number:");
            int b = int.Parse(Console.ReadLine());

// Perform the selected operation using conditional statements
            if (c == "+")
            {
                Console.WriteLine(a + b);  // Addition
            }
            else if (c == "-")
            {
                Console.WriteLine(a - b);  // Subtraction
            }
            else if (c == "*")
            {
                Console.WriteLine(a * b);  // Multiplication
            }
            else if (c == "/")
            {
                Console.WriteLine(a / b);  // Integer division (result will be an integer)
            }
            else
            {
                // If operator is invalid, show error and restart
                Console.WriteLine("Select the correct operator!!!");
                goto Start;
            }
