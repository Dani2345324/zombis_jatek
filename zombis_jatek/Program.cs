namespace zombis_jatek
{
    internal class Program
    {
        static Random r = new Random();
        static void f19()
        {
            string[] zombik = { "Narancia", "Gyro", "Johnny", "Valentine", "Dio" };
            int[] zombiEro = new int[5];
            for (int i = 0; i < zombiEro.Length; i++)
            {
                zombiEro[i] = r.Next(10, 51);
            }
            string[] lakok = { "Napóleon", "II. Vilmos", "Ferenc Ferdinánd", "IV. Károly", "Woodrow Wilson" };
            int[] lakoEgeszseg = { 100, 100, 100, 100, 100 };

            int sum = lakoEgeszseg.Length;


            while (sum > 0)
            {
                for (int i = 0; i < zombik.Length; i++)
                {
                    if (lakoEgeszseg[i] > 0)
                    {
                        lakoEgeszseg[i] -= zombiEro[i];
                        if (lakoEgeszseg[i] < 1)
                        {
                            lakoEgeszseg[i] = 0;
                            sum--;

                        }
                        Console.WriteLine($"{zombik[i]} megtámadta {lakok[i]}t, {lakok[i]} {zombiEro[i]} egészséget veszített! ({lakoEgeszseg[i]} maradt)");
                        if (lakoEgeszseg[i] < 1)
                        {
                            Console.WriteLine($"{lakok[i]} meghalt!");
                        }
                    }



                }
            }
        }
        static void Main(string[] args)
        {


            f19();


        }
    }
}
