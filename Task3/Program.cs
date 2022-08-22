  int[] array = new int[0];
  Console.WriteLine("Введите элементы массива. Для завершения введите end: ");
  
  while (true)
        {   
            string? num = Console.ReadLine();          
            if(num != "end")
            {
                int number = Convert.ToInt32(num);
                int[] newArray = array;
                array = new int[array.Length + 1];
                for(int i = 0; i < newArray.Length; i++)
                {
                    array[i] = newArray[i];
                }
                array[array.Length-1] = number;
            }
            else
            {
                break;
            }
        }
void PrintArry(int[] col)
{
    Console.Write("[");
    int count = col.Length;
    int position = 0;
    while(position < count - 1)
    {
        Console.Write(col[position] + ", ");
        position ++; 
    }
    if(position == count-1)
    {
        Console.Write(col[position]);         
    }
    Console.Write("]");
}
   

PrintArry(array);


