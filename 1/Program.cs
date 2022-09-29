string [] arr={"111","5","45555","3","2","66","7","!!!!","sddfsdgfg"};

void PrintArray(string[] array)
{
    int count=array.Length;

    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(string [] array)
{
    
    int count=0;
    for (int i=0;i<array.Length-1; i++)
    {
        if (array[i].Length>=3)
        {
            count ++;
            // arr2[i]=array[i];

        }
    }
    string [] arr2 = new string [count+1];
    int j=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length>=3)
        {
            arr2[j]=array[i];
            j++;
        }
    }

    PrintArray(arr2);
}

PrintArray(arr);
SelectionSort(arr);


    // for (int i=0; i<array.Length-1; i++)
    // {
    //     for (int j = 0; j < count+1; j++)
    //     {
    //     if (array[i].Length>=3)
    //     {
    //         arr2[j]=array[i];
    //         Console.WriteLine(arr2[j]);
    //     }
    // }
    // }