// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
Console.WriteLine("write numbers");
string arr=(Console.ReadLine());
string [] array= arr.Split(' ',',');
int []numbers= new int[array.Length];

for(int i=0;i<array.Length;i++){
   numbers[i]=int.Parse(array[i]);}
int counter=0;
for(int i=0;i<numbers.Length;i++){
    //int counter=0;
    if (numbers[i]>0) counter++;
    

}
Console.WriteLine(counter);