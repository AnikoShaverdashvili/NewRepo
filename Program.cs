// See https://aka.ms/new-console-template for more information



//დაწერეთ პროგრამა რომელიც კლავიატურიდან შეიტანს 10 ელემენტს და შეავსებს მასივს. (სცადეთ სხვადასხვა ტიპისთვის)

/*Console.WriteLine("Enter numbers here:");
int n = int.Parse(Console.ReadLine());
int[] array = new int[10];

for (int k = 0; k <=10; k++)
{
    array[k] = int.Parse(Console.ReadLine());
}
Console.ReadLine();



Console.WriteLine("Enter string");
string[] answer = new string[10];
for (int i = 0; i < answer.Length; i++)
{
    answer[i] = Console.ReadLine();
}
*/


//დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს რიცხვს n-ს და დაბეჭდავს 1-დან n მდე რიცხვებს ისე როგორც სურათზეა(სურ 1).(თითო ხაზზე ელემენტების რაოდენობა იზრდება 1-ით)




/*
 int temp= 1;
Console.WriteLine("Enter number:");
int num = int.Parse(Console.ReadLine());

for (int row = 1; row <= num; row++)

{   
    for (int col = 1; col <= row; col++) 
    {
        Console.Write("  "+temp);
        temp++;
    }
    Console.WriteLine();
}
    
*/



//კლავიატურიდან შემოიტანეთ რიცხვი და დათვალეთ 1-დან n მდე კენტი რიცხვების ჯამი, ნამრავლი.
/*
Console.WriteLine("Enter odd numbers:");


int EnterNum =int.Parse(Console.ReadLine());
int sum=0;
int mult = 1;
for (int k = 1; k <= EnterNum; k++) 
{
    if (k % 2 != 0)
    {
        Console.WriteLine(k);
        sum += k;
        mult*=k;

    }
}
Console.WriteLine("sum = " + sum);
Console.WriteLine("mult = " + mult);
*/


//დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოტანილი რიცხვისთვის დაითვლის 1-დან n მდე ამ რიცხვების კვადრატების ჯამს.

/*
 * int numberOfNum=int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 1; i < numberOfNum; i++)
{
   Console.WriteLine(i);
   sum+=i*i;
}
Console.WriteLine(sum);

*/

//დაწერეთ პროგრამა რომელიც შეამოწმებს არის თუ არა სტრინგი პალინდრომი.(პალინდრომია სტრინგი თუ ის შებრუნებული სახითაც იგივენაირად იკითხება) asdffdsa

/*

string myStr = "asdffdsa";
string reversed = new string(myStr.Reverse().ToArray());

if (myStr == reversed)
{
    Console.WriteLine("String is palindrome");    
}
else {
    Console.WriteLine("String is not palindrome");
}

*/


//დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოსულ რიცხვს შეამოწმებს არის თუ არა პალინდრომი (არ გამოიყენოთ სტრინგები)

/*
int n, reverse = 0, rem,temp;
Console.Write("Enter a number: ");
n = int.Parse(Console.ReadLine());
temp = n; 
while (n!=0)
{
    rem = n % 10;
    n /= 10;
    reverse = reverse * 10 + rem;
    
}
Console.WriteLine("Reversed Number: " + reverse);


if (temp == reverse)
{
    Console.WriteLine("is palindrome");
}
else
{
    Console.WriteLine("isnt palindrome");
}

*/

//მოცემულია მასივი, რომელიც შეგიძლიათ შეავსთ კლავიატურიდანაც და პროგრამიდანაც. დაწერეთ პროგრამა რომელიც დაითვლის ამ მასივში თითოეული ელემენტის რაოდენობას,

/*
    
string[] myArray = { "Dogs", "Cats", "Birds","Reptiles","Bacterias"};
//Console.WriteLine(myArray[0].Length);
//Console.WriteLine(myArray[1].Length);
//Console.WriteLine(myArray[2].Length);
//Console.WriteLine(myArray[3].Length);
for(int i = 0; i < myArray.Length; i++)
{
    {
        Console.WriteLine("Element[{0}] = {1}", i, myArray[i]);
    }
}
*/




//დაწერეთ პროგრამა რომელიც მასივში დაითვლის ამ მასივში უმცირეს,უდიდეს ელემენტს და იპოვნის მედიანას(შუა წევრს)

/*

using System;

int[] arr= { 43, 23, 45 , 21,2};
Array.Sort(arr);
int m = arr.Max();
int min=arr.Min();
int mid = arr[arr.Length / 2];


Console.WriteLine("Sort from lowest to highest");
foreach (int item in arr)
{
  
    Console.WriteLine(item);

}

Console.ReadLine();

Console.WriteLine($"Find max number:{m}");
Console.WriteLine($"Find min number:{min}");

Console.WriteLine($"Find mid number:{mid}");

*/

//დაწერეთ პროგრამა რომელიც მოცემულ მასივს დაბეჭდავს შებრუნებული სახით მაგ 1 2 3 4 —-> 4 3 2 1

/*
{
    int[] array = { 1, 2, 3, 4 };
    int length = array.Length;
    int[] reversed = new int[length];
    for (int index = 0; index < length; index++)
    {
        reversed[length - index - 1] = array[index];
    }
    for (int index = 0; index < length; index++)
    {
        Console.Write(reversed[index] + " ");
    }
}

*/

//დაწერეთ პროგრამა რომელიც მასივიდან დაბეჭდავს უარყოფითი რიცხვების რაოდენობას. ??????????

using System;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

/*
int[] array = new int[]  { 1, 2, -2, 4, 3, 6, 12, -5, -7, -9 };
int neg = 0;
int pos = 0;

foreach (int element in array)
{
    if (element <0 )
    {

    }
}


*/

//დაწერეთ პროგრამა რომელიც დაბეჭდავს მასივში უნიკალურ ელემენტებს( მაგ 1 1 1 2 2 3  4—> 1 2 3 4) მასივის შევსება როგორც გინდა მოახდინეთ.

/*
int[] items = { 2, 3, 5, 3, 7, 5,2,2,2};

Console.WriteLine("Unique array elements: ");

for (int i = 0; i < items.Length; i++)
{
    bool isDuplicate = false;
    for (int j = 0; j < i; j++)
    {
        if (items[i] == items[j])
        {
            isDuplicate = true;
            break;
        }
    }

    if (!isDuplicate)
    {
        Console.WriteLine(items[i]);

    }
}

Console.ReadLine();  
        */



//დაწერეთ პროგრამა რომელიც კლავიატურიდან შეიყვანს ტექსტ და დაითვლის ტექსტში სიტყვების რაოდენობას. (პუნქტუაციური ნიშნების რაოდენობას, და მაღალი და დაბალი რეგისტრის სიმბოლოებს)


