namespace GA_NestedIfs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Prompt the user to enter their age
            Console.Write("Enter your age: ");

            // Step 2: Read the user's input as a string and convert it to an integer
            int age = int.Parse(Console.ReadLine());

            // Step 3: Check if the entered age is greater than or equal to 18
            if (age >= 18)
            {
                // Step 4: If the condition is true, prompt the user to enter their student status
                Console.Write("Are you a student (yes/no): ");

                // Step 5: Read the user's input as a string
                string studentStatus = Console.ReadLine();

                // Step 6: Check if the user's student status is "yes" (case-insensitive)
                if (studentStatus.ToLower() == "yes")
                {
                    // Step 7: If the condition is true, prompt the user to enter their GPA
                    Console.Write("Enter your GPA (0.0-4.0): ");

                    // Step 8: Read the user's input as a string and convert it to a double
                    double gpa = double.Parse(Console.ReadLine());

                    // Step 9: Check if the entered GPA is greater than or equal to 3.0
                    if (gpa >= 3.0)
                    {
                        // Step 10: If the condition is true, print the message below
                        Console.WriteLine("Congratulations! You are an adult with a good GPA.");
                    }
                    else
                    {
                        // Step 11: If the condition is false, print the message below
                        Console.WriteLine("You are an adult student, but your GPA needs improvement.");
                    }
                }
                else
                {
                    // Step 12: If the condition in Step 6 is false, print the message below
                    Console.WriteLine("You are an adult, but not a student.");
                }
            }
            else
            {
                // Step 13: If the condition in Step 3 is false (age < 18), print the message below
                Console.WriteLine("You are not an adult.");
            }

        } // End main
    } // End class
} // End namespace
