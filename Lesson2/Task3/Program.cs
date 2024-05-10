int n = 10;
int[] arr = {2,5,6,3,7,9,11,24,31,0};
int i = 0;
while (i < n) 
{
    if(arr[i] % 2 == 0)
    {
        Console.WriteLine(arr[i]);
    }
    i = i + 1;
}