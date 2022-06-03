internal class priemgetallenBase
{
    static void Main()
    {
        int Num = 100;
        bool flag = false;

        for (int num1 = 2; num1 <= Num; num1++)
        {
            flag = false;
            for (int num2 = 2; num2 < num1 / 2 + 2; num2++)
            {
                if (num1 != num2 && num1 % num2 == 0)
                {
                    break;
                }
                flag = true;
            }
            if (flag)
                Console.WriteLine(num1);
        }
    }
}