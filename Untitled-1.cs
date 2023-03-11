#Girilen sayinin çifti tekmi olduğunu bulan program
Using system;
namespace ornek1
{ class program
{ static void main(string[] args)
{double a;
Console.clear(); Console.Write("Tamsayi giriniz: ");
a=Convert.ToDouble(Console.ReadLine());
if (a%2==0) Console.WriteLine("\nGirdiğiniz tamsayi çifttir. ");
else Console.WriteLine("\nGirdiğiniz tamsayi tektir.");
Console.ReadLine(); } } }