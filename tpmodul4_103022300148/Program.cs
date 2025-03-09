public class KodePos()
{
    public void GetKodePos(String input)
    {
        String[] kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates",
            "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
        int[] kode = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

        for (int i = 0; i < kelurahan.Length; i++)
        {
            if (kelurahan[i] == input)
            {
                Console.WriteLine("Kode Pos : " + kode[i]);
            }
        }
    }
}

public class Program()
{
    public static void Main()
    {
        KodePos pos = new KodePos();
        Console.Write("Masukkan Kode Pos : ");
        String input = Console.ReadLine();
        pos.GetKodePos(input);
    }
}