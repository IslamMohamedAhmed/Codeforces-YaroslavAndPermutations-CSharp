int n,indicator = 0,mx = 0;
int[] arr1 = new int[1001];
Array.Clear(arr1, 0, 1001);
n=Convert.ToInt32(Console.ReadLine());
string str = Console.ReadLine();


if (n == 1)
{
    Console.WriteLine("YES");
}
else
{
    var arr2 = str.Split(" ");
    for (int i = 0; i < n; i++)
    {

        int x = Convert.ToInt32(arr2[i]);
        arr1[x]++;
        mx = Math.Max(mx, x);
    }
    for(int i = 0; i <= mx; i++)
    {
        if (n % 2 == 0)
        {
            if (arr1[i] > n / 2)
            {

                indicator++;
                break;
            }
        }
        else
        {
            if (arr1[i] > n / 2 + 1)
            {

                indicator++;
                break;
            }
        }
   
    }
    if(indicator > 0)
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }
}

