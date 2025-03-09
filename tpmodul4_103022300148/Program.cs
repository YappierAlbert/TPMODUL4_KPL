using tpmodul4_103022300148;

public class Program() {
    public static void Main() {
        DoorMachine door = new DoorMachine();
        while(door.GetState() != State.Masuk)
        {
            Console.Write("Masukkan Perintah : ");
            String input = Console.ReadLine();
            
            if(input == "Terbuka")
            {
                door.Terbuka();
            }else if(input == "Terkunci")
            {
                door.Terkunci();
            }else if(input == "Masuk")
            {
                door.Masuk();
            }
            else
            {
                Console.WriteLine("Pintu Tetap Terkunci !");
                break;
            }
        }
    }
}