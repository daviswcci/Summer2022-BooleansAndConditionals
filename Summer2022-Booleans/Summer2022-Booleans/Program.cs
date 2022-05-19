// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//float - fast
// double - middle ground
// decimal - high precision
//'type'
//type name = value;

// variable declaration
int num;
// variable assignment
num = 3; // "= 3"
//variable declaration AND assignment

string str = "Hello" + ", world!";

num = num + 1; // increment, increases by 1
num += 1;      // increment, increases by 1

num = num * 2; // doubles our number
num *= 2;      // doubles our number

num = num / 2; // integer division is weird!
num /= 2;      // halves out number

num = num - 1; // decrement, decreases by 1
num -= 1;      // decrement, decreases by 1

num++;         // increment operator, increases by 1
num--;         // decrement operator, decreases by 1

Console.WriteLine(num);
string input = Console.ReadLine(); // "123" vs. 123
int num2 = Int32.Parse(input); // converting a string to an integer -> "123" GOOD 123


// int input2 = Int32.Parse(Console.ReadLine());
Console.WriteLine(num2);
input = Console.ReadLine();



// Booleans!
// TRUE or FALSE statements
bool isSunny = true;
bool isCold = true;

// AND - &&
// Hand us TRUE if the BOTH value on the left and right of the && are true, FALSE otherwise
// true && true -> true
// true && false -> false
// false && true -> false
// false && false -> false
// true && (false && true) -> false
bool goOutside = isSunny && isCold;
int num3 = num            +   num2;

// OR - ||
// Hand us TRUE if EITHER value on the left or right of the || are true, false otherwise
// true || true -> true
// true || false -> true
// false || true -> true
// false || false -> false
// (true || false) || false -> true
bool mowTheLawn = isSunny || isCold;

// NOT - !
// Hands us true if the boolean after is false, and hands us false if the boolean after is true
// this does NOT reassign that value
// !true -> false
// !false -> true
bool isRainy = !isSunny;

// !(true || false) && true
//    !(true) && true
//     false && true
//         false

// Conditionals - If/Else
// if something is true, perform an action. If the conditions are all false, perform another action instead

// if(condition){
//   code we run if condition is true
// }

// else if(condition){
//  code we run if condition is true
// }

// copying because we can have multiple else ifs
// else if(condition){
//  code we run if condition is true
// }

// else {
//   code we run if previous conditions are false
// }
isRainy = true;
isSunny = true;

if (isRainy)
{
    Console.WriteLine("Wow, it sure is rainy today!");
}
else if (isSunny)
{
    Console.WriteLine("Don't look at the sun!");
}
else
{
    Console.WriteLine("There are some clouds in the sky!");
}

// Comparison Operators

// Equivalence Operator - ==
// Hand you a value of true if the left and right values are equivalent (equal)
// values do not have to be numbers
// 5 == 5 -> true
// 13 == 5 -> false
if(num == 3)
{
    Console.WriteLine("Our number is 3!");
}

// Inequality Operator - !=
// Hands you a value of true if the left and right values are NOT equivalent (not equal)
// values do not have to be numbers
// 5 != 5 -> false
// 13 != 5 -> true
// a != b   is the same as !(a == b)
if (num2 != 17)
{
    Console.WriteLine("Num2 is not equal to 17!");
}

// Comparison Operators - ( > , < , >= , <= )
// Converts numbers into booleans
// a > b hands you a value of true if a is greater than b
// a < b hands you a value of true if a is less than b
// a >= b hands you a value of true if a is greater than OR EQUAL to b
// a <= b hands you a value of true if a is less than OR EQUAL to b

//User Input Example
Console.WriteLine("Is today your birthday? Y/N");
string condInput = Console.ReadLine();
condInput = condInput.ToUpper(); // capitalizes all letters in our string
if (condInput == "Y" || condInput == "YES")
{
    Console.WriteLine("Happy Birthday!");
} 
else if (condInput == "N" || condInput == "NO")
{
    Console.WriteLine("Maybe tomorrow!");
}
else
{
    Console.WriteLine("I guess we'll never know!");
}

// DaViS != Davis