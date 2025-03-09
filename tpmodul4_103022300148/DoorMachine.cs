using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tpmodul4_103022300148
{
    enum State { Terbuka,Terkunci,Masuk };
    class DoorMachine
    {
        private State state;
        private String[] status = { "Terbuka", "Terkunci", "Masuk" };
        public DoorMachine()
        {
            state = State.Terkunci;
            Console.WriteLine("Pintu " + status[(int)state]);
        }
        public void Terbuka()
        {
            state = State.Terbuka;
            Console.WriteLine("Pintu " + status[(int)state]);
        }
        public void Terkunci()
        {
            state = State.Terkunci;
            Console.WriteLine("Pintu " + status[(int)state]);
        }
        public void Masuk()
        {
            state = State.Masuk;
            Console.WriteLine("Anda Masuk ");
        }
        public State GetState()
        {
            return this.state;
        }
    }
}
