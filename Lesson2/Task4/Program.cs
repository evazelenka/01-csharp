int n = 5;
int[] arr = {1,2,5,7,8};
int i = 0;
int max = arr[0];

while(i < n)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.Write(max);