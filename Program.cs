//исходные данные
int []array={9,3,4,22,100,1000};
int s=array.Length;
int i=0;
int sum=0;
int i_min=0;
int i_max=0;

//определение функций мин и макс

int f_min(int []massive)
{
    int index=0;
    int size=massive.Length;
    int min=massive[0];
    while(index<size)
    {
        if(massive[index]<min)
        {
            min=massive[index];
        }
        index++;
    }
    return min;
}

int f_max(int []massive)
{
    int index=0;
    int size=massive.Length;
    int max=massive[0];
    while(index<size)
    {
        if(massive[index]>max)
        {
            max=massive[index];
        }
        index++;
    }
    return max;
}

//блок операций
int min=f_min(array);
int max=f_max(array);

while(i<s) //находит местонахождение минимального и максимального элемента в массиве
{
    if(array[i]==max)
    {
        i_max=i;
    }
    else if(array[i]==min)
    {
        i_min=i;
    }
    i++;
}

if(i_min<i_max)
{
    for (i=i_min+1;i<i_max;i++)
    {
        sum=sum+array[i];
    }
}
else
{
    for (i=i_max+1;i<i_min;i++)
    {
        sum=sum+array[i];
    }
}
    


//вывод на печать
Console.WriteLine("Минимальное значение:");
Console.WriteLine(f_min(array));
Console.WriteLine("Максимальное значение:");
Console.WriteLine(f_max(array));
Console.WriteLine("Сумма:");
Console.WriteLine(sum);
