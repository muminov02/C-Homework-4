void Sum(int num){
    string str = num.ToString();
    int sum = 0;
    for (int i = 0; i < str.Length; i++)
    {
        int flag = 0;
        flag = num % 10;
        num = num / 10;
        sum = sum + flag;
    }
    Console.WriteLine(sum);
}

Sum(452);
Sum(82);
Sum(9012);