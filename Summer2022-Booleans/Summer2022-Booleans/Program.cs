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

// == equivalence op (returns true if two things are equal)
// != (returns true if two things are not equal)


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
