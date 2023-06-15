int number1 = 10;
long number2 = 123456;
float number3 = 1.5f;
double number4 = 1.35233;
bool cSharp = true;
char char1 = 'A';
string place = "Kerala";


Console.WriteLine(place + number1 + number2 + number3 + number4 + cSharp + char1);

int a = 20;
int b = 33;

Console.WriteLine(a % b);
Console.WriteLine(a / b);
Console.WriteLine(a * b);

//userinput

//Console.WriteLine("Enter Your name: ");
//String? name= Console.ReadLine();
//Console.WriteLine("Your name is : "+name);

//Console.WriteLine("Enter Your age: ");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Your age is : " + age);

//Console.WriteLine("Enter a number: ");
//int num= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Square of number : "  + num + " is " +num*num);

/*if statement
Console.WriteLine("Enter you state");
String state= Console.ReadLine();   

if(state == "Kerala")
{
    Console.WriteLine("You're a Mallu");
}
else if (state == "karnataka")
{
    Console.WriteLine("You're a kannadigan");
}
else if(state =="Tamilnadu")
{
    Console.WriteLine("You're a Tamilan");
}
else
{
    Console.WriteLine("You're from North India");
}*/

//nested if

/*Console.WriteLine("South or North");
String Part = Console.ReadLine();

if (Part == "South")
{
    Console.WriteLine("Enter you state");
    String state = Console.ReadLine();
    if (state == "Kerala")
    {
        Console.WriteLine("You're a Mallu");
    }
    else if (state == "karnataka")
    {
        Console.WriteLine("You're a kannadigan");
    }
    else if (state == "Tamilnadu")
    {
        Console.WriteLine("You're a Tamilan");
    }
}

else
{
    Console.WriteLine("You can speak Hindi");
}*/

//For Loop
/*for(int x = 1; x <= 5; x++)
{
    Console.WriteLine(x);
}*/

//while loop
/*int x = 1;
while (x <= 5)
{
    Console.WriteLine("cSharp");
    x++;    
}*/

//dowhile
/*int x = 1; 
do
{
    Console.WriteLine("cSharp");
    x++;
} while (x <= 5);*/

//switch

Console.WriteLine("Enter an Alphabet");
string? letter = Console.ReadLine();

switch (letter)
{
    case "A":
        Console.WriteLine("Apple");
        break;

    case "B":
        Console.WriteLine("Bat");
        break;

    case "C":
        Console.WriteLine("Cat");
        break;

    default:
        Console.WriteLine("Invalid");
        break;
}
