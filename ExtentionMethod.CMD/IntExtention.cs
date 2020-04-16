namespace ExtentionMethod.CMD
{
    public static class IntExtention
    {
        public static bool IsPolindrom(this int number)
        {
            var numb = number.ToString();

            for (int i = 0; i < numb.Length / 2; i++)
                if (numb[i] != numb[numb.Length - i - 1])
                    return false;

            return true;
        }
    }
}