# Guided Assignment - Nested Ifs

## Introduction

In C#, you can use nested `if` statements to create more complex conditional logic by placing one `if` statement inside another. This allows you to check multiple conditions and execute different code blocks based on the combinations of these conditions. Here's how nested `if` statements work:

```csharp
if (condition1)
{
    // Code to execute if condition1 is true

    if (condition2)
    {
        // Code to execute if both condition1 and condition2 are true
    }
    else
    {
        // Code to execute if condition1 is true but condition2 is false
    }
}
else
{
    // Code to execute if condition1 is false
}
```

Key points to understand about nested `if` statements in C#:

1. **Structure**: Nested `if` statements are composed of an outer `if` statement and one or more inner `if` statements or `else` blocks. Each inner `if` statement can have its own condition to check.

2. **Conditions**: The conditions in nested `if` statements are evaluated in order, starting with the outermost condition. If the outer condition is `true`, the inner condition(s) are checked. Only the code block associated with the first `true` condition is executed. Once a condition is `false`, the code blocks associated with subsequent conditions are skipped.

3. **Indentation**: Proper indentation is essential to maintain readability in nested `if` statements. Indentation helps clarify the structure of the code and shows the hierarchy of the conditions.

Here's an example of a nested `if` statement:

```csharp
int age = 25;
bool isStudent = false;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
    
    if (!isStudent)
    {
        Console.WriteLine("You are not a student.");
    }
    else
    {
        Console.WriteLine("You are a student.");
    }
}
else
{
    Console.WriteLine("You are not an adult.");
}
```

In this example:

- The outer `if` statement checks if `age` is greater than or equal to 18.
- If the outer condition is `true`, it enters the inner `if` statement to check if `isStudent` is `false` or `true`.
- Depending on the combination of `age` and `isStudent`, different messages are printed.

Nested `if` statements are helpful when you need to evaluate multiple conditions in a specific order and execute code blocks accordingly. However, be mindful of proper code organization and readability to avoid creating overly complex nested structures.

--- 
## Step By Step

### Prepare
- Create a new project with the name GA_Nested_If_YourName
- Add your name in comments at the top of `Program.cs`
- Code Parts 1, 2, and 3. Add comments to explain what is happening.
- Make sure you code has no compile time errors when you run it
- Submit your repository link to canvas

### Part 1 - Ask the User for their age. ( Code For Assignment )

> Our first if statement.

Assignment: 
Write a simple C# program that asks the user to enter their age and then tells them whether they are an adult (age 18 or older) or not.

```csharp
 1: using System;

 2: class Program
 3: {
 4:     static void Main()
 5:     {
 6:         // Step 1: Prompt the user to enter their age
 7:         Console.Write("Enter your age: ");
 8:         
 9:         // Step 2: Read the user's input as a string and convert it to an integer
10:         int age = int.Parse(Console.ReadLine());

11:         // Step 3: Check if the entered age is greater than or equal to 18
12:         if (age >= 18)
13:         {
14:             // Step 4: If the condition is true, print the message below
15:             Console.WriteLine("You are an adult.");
16:         }
17:         else
18:         {
19:             // Step 5: If the condition is false (age < 18), print the message below
20:             Console.WriteLine("You are not an adult.");
21:         }
22:     }
23: }

```

Here's what's happening step by step:

1. The program starts by displaying a prompt asking the user to enter their age.

2. The user's input is read using `Console.ReadLine()`, which reads a line of text from the console and returns it as a string.

3. The `int.Parse()` method is used to convert the input (which is a string) into an integer and store it in the `age` variable.

4. An `if` statement is used to check whether the `age` entered by the user is greater than or equal to 18.

5. If the condition in the `if` statement is true (age is 18 or older), it executes the code inside the curly braces `{ }`. In this case, it prints the message "You are an adult."

6. If the condition in the `if` statement is false (age is less than 18), it executes the code inside the `else` block. In this case, it prints the message "You are not an adult."

So, this program asks the user for their age, checks if they are 18 or older, and then provides an appropriate response based on the user's age.

#### Run Your Code - Expected Result

```
Enter your age: 25
You are an adult.
```

In this example:
- The program prompts the user to enter their age, and they enter 25.
- It checks if the entered age is greater than or equal to 18 (which is true in this case).
- Since the condition in the `if` statement is true, it prints "You are an adult." to indicate that the user is an adult.

---
### Part 2 - Nested If - Ask if they are a student ( Code For Assignment )

> Our nested if statement Inside our first if. New code starts at line 15

Assignment:
Extend the previous program to ask the user if they are a student (yes/no) if they are an adult. Depending on their answer, print a message indicating whether they are an adult student or just an adult.


```csharp
 1: using System;

 2: class Program
 3: {
 4:     static void Main()
 5:     {
 6:         // Step 1: Prompt the user to enter their age
 7:         Console.Write("Enter your age: ");
 8:         
 9:         // Step 2: Read the user's input as a string and convert it to an integer
10:         int age = int.Parse(Console.ReadLine());

11:         // Step 3: Check if the entered age is greater than or equal to 18
12:         if (age >= 18)
13:         {
14:             // Step 4: If the condition is true, prompt the user to enter their student status
15:             Console.Write("Are you a student (yes/no): ");
16:             
17:             // Step 5: Read the user's input as a string and convert it to lowercase for case-insensitive comparison
18:             string studentStatus = Console.ReadLine().ToLower();

19:             // Step 6: Check if the user's student status is "yes"
20:             if (studentStatus == "yes")
21:             {
22:                 // Step 7: If the condition is true, print the message below
23:                 Console.WriteLine("You are an adult student.");
24:             }
25:             else
26:             {
27:                 // Step 8: If the condition is false, print the message below
28:                 Console.WriteLine("You are an adult, but not a student.");
29:             }
30:         }
31:         else
32:         {
33:             // Step 9: If the condition in Step 3 is false (age < 18), print the message below
34:             Console.WriteLine("You are not an adult.");
35:         }
36:     }
37: }

```

Here's what each step does:

1. The program starts by displaying a prompt asking the user to enter their age. - ( ***Line 7*** )

2. The user's input is read using `Console.ReadLine()`, which reads a line of text from the console and returns it as a string. It is then converted to an integer using `int.Parse()` and stored in the `age` variable. - ( ***Line 10*** )

3. An `if` statement is used to check whether the `age` entered by the user is greater than or equal to 18. - ( ***Line 17*** )

4. If the condition in Step 3 is true (age is 18 or older), it prompts the user to enter their student status. - ( ***Line 12 )

5. The user's input for student status is read as a string and converted to lowercase for case-insensitive comparison. It is stored in the `studentStatus` variable. - ( ***Line 18*** )

6. Another `if` statement checks if the user's student status is "yes." - ( ***Line 20*** )

7. If the condition in Step 6 is true (studentStatus is "yes"), it prints the message "You are an adult student." - ( ***Line 23*** )

8. If the condition in Step 6 is false (studentStatus is not "yes"), it prints the message "You are an adult, but not a student." - ( ***Line 28*** )

9. If the condition in Step 3 is false (age < 18), it prints the message "You are not an adult." - ( ***Line 34*** )

#### Run Your Code

```bash
Enter your age: 20
Are you a student (yes/no): yes
You are an adult student.
```

---

### Part 3 - Add ANOTHER nested if ( Code For Assignment )

> Using the previous code we add another nested if, creating a third level. Code starts at line 23.

Assignment:
Create a C# program that asks the user for their age, student status, and GPA. If the user is an adult and a student, check if their GPA is above 3.0 and print an appropriate message. If they are an adult but not a student, print a message indicating that. If they are not an adult, indicate that as well.

```csharp
 1: using System;

 2: class Program
 3: {
 4:     static void Main()
 5:     {
 6:         // Step 1: Prompt the user to enter their age
 7:         Console.Write("Enter your age: ");
 8:         
 9:         // Step 2: Read the user's input as a string and convert it to an integer
10:         int age = int.Parse(Console.ReadLine());

11:         // Step 3: Check if the entered age is greater than or equal to 18
12:         if (age >= 18)
13:         {
14:             // Step 4: If the condition is true, prompt the user to enter their student status
15:             Console.Write("Are you a student (yes/no): ");
16:             
17:             // Step 5: Read the user's input as a string
18:             string studentStatus = Console.ReadLine();

19:             // Step 6: Check if the user's student status is "yes" (case-insensitive)
20:             if (studentStatus.ToLower() == "yes")
21:             {
22:                 // Step 7: If the condition is true, prompt the user to enter their GPA
23:                 Console.Write("Enter your GPA (0.0-4.0): ");
24:                 
25:                 // Step 8: Read the user's input as a string and convert it to a double
26:                 double gpa = double.Parse(Console.ReadLine());

27:                 // Step 9: Check if the entered GPA is greater than or equal to 3.0
28:                 if (gpa >= 3.0)
29:                 {
30:                     // Step 10: If the condition is true, print the message below
31:                     Console.WriteLine("Congratulations! You are an adult with a good GPA.");
32:                 }
33:                 else
34:                 {
35:                     // Step 11: If the condition is false, print the message below
36:                     Console.WriteLine("You are an adult student, but your GPA needs improvement.");
37:                 }
38:             }
39:             else
40:             {
41:                 // Step 12: If the condition in Step 6 is false, print the message below
42:                 Console.WriteLine("You are an adult, but not a student.");
43:             }
44:         }
45:         else
46:         {
47:             // Step 13: If the condition in Step 3 is false (age < 18), print the message below
48:             Console.WriteLine("You are not an adult.");
49:         }
50:     }
51: }
```

This updated code performs the following steps:

1. It prompts the user to enter their age.
2. Reads the user's input as a string and converts it to an integer (`age`).
3. Checks if the entered age is greater than or equal to 18.
4. If the age is 18 or older, it asks if the user is a student.
5. Reads the user's input for student status as a string.
6. Checks if the user's student status is "yes" (case-insensitive).
7. If the user is a student, it asks for their GPA.
8. Reads the user's input for GPA as a string and converts it to a double.
9. Checks if the entered GPA is greater than or equal to 3.0.
10. Prints a message based on the user's age, student status, and GPA.
11. If the user is an adult student but with a GPA below 3.0, it informs them that their GPA needs improvement.
12. If the user is not a student, it informs them that they are an adult but not a student.
13. If the user's age is less than 18, it informs them that they are not an adult.

#### Run your Code

```
Enter your age: 20
Are you a student (yes/no): yes
Enter your GPA (0.0-4.0): 3.5
Congratulations! You are an adult with a good GPA.
```

In this example:
- The program prompts the user to enter their age, and they enter 20.
- Since the age is greater than or equal to 18, the program proceeds to ask if the user is a student (yes/no), and they answer "yes."
- Next, the program asks for their GPA, and they enter 3.5.
- The program checks if the entered GPA is greater than or equal to 3.0, which is true in this case.
- As a result, it prints the message, "Congratulations! You are an adult with a good GPA."

---

## Rubric

| Criteria                  | Description                                      | Points |
|---------------------------|--------------------------------------------------|--------|
| **Preparation (5 points)**| Project and developer's name are set up properly.| 5      |
| **Part 1: Ask for Age (25 points)**    | Program asks for age, checks if the user is an adult (age >= 18) using a simple `if` statement. | 25     |
| **Part 2: Nested If - Ask for Student Status (35 points)**| Program extends to ask if the user is a student (yes/no) and uses a nested `if` statement to handle different scenarios. Understanding of nested `if` statements is crucial for this part. | 35     |
| **Part 3: Add ANOTHER nested if (40 points)**| Program asks for GPA (if adult student) and uses another level of nested `if` statements to determine and print messages based on age, student status, and GPA. Proficiency in nested `if` statements is essential here. | 40     |
| **Code Organization and Readability (20 points)**| Code is well-organized with comments, no errors, handles inputs, and is easy to understand. Proper use of indentation and structure for nested `if` statements is emphasized. | 20     |
| **Total**                  | Total points possible.                         | **100** |
