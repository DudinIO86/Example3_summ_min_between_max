//исходные данные
int []array={9,3,4,22,100};
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

Console.WriteLine(f_min(array));
Console.WriteLine(f_max(array));
