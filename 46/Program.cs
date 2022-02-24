string mass="";

for(int i=1;i<5;i++){
    string massiv="";
    Console.WriteLine($"vedite {i} kordinoti");
     massiv = Console.ReadLine();
     mass= $"{mass}({massiv})";  
}
Console.Write(mass);
Console.WriteLine();



string []array=mass.Split(' ','-',')','(');
int []numbers=new int[array.Length];
for(int i=0;i<array.Length;i++){
    
   Console.Write(array[i]+" ");
  }

Console.WriteLine(array[2]);
//for(int i=0;i<array.Length;i++){
  //  if array[i]!=" ";
  //   numbers[i]=int.Parse(array[i]);
    // Console.WriteLine(numbers[i]);
  }





//Console.WriteLine(" write Coefficient");
//int k= int.Parse(Console.ReadLine());
////Console.Writeline($"{mass*k}");



        



