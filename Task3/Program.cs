Console.WriteLine("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArr(int[] collection)
{
  int count = collection.Length;
  int index = 0;
  while(index < count){
    Console.Write(collection[index]+ " ");
    index++;
  }
} 

int[] arr = new int[cube+1];
Cube(arr);
PrintArr(arr);