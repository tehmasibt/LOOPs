// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] num = { 264, 329, 2679, 7859, 17682, 40557, 239488 };
int sum3 = 0;
int mult4 = 1;
int sum4 = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] >= 99 && num[i] <= 1000)
    {
        sum3 += num[i];
    }
    else if (num[i] >= 1000 && num[i] <= 10000)
    {
        mult4 *= num[i];
        sum4 += num[i];
    }

}
int yekun = (sum3 + mult4) * 10 + 7;
int sum5 = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] >= 10000 && num[i] <= 100000)
    {
        sum5 += num[i];
    }
}
int yekun2 = sum5 + yekun;
int hasil3 = 1;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] >= 99 && num[i] <= 1000)
    {
        hasil3 *= num[i];
    }
}
int netice = yekun2 - ((hasil3 * 10) + 1);
int has6 = 1;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] >= 100000 && num[i] <= 1000000)
    {
        has6 *= num[i];
    }
}
int netice2 = netice + has6;
int proses3 = netice2 - (sum3 + sum4);
int faiz18 = proses3 * 10 / 100;
int faiz3 = faiz18 * 10 / 100;
int faiz1 = faiz3 * 10 / 100;
int son5 = faiz1 + sum5;
Console.WriteLine(son5);