using System;

namespace tpmodul3_1302204014
{

    public class Program
    {

        public static void Main(string[] args)
        {
            KodePos kode = new KodePos();

            Console.WriteLine();
            //kode.getKodePos();
            DoorMachine pintu = new DoorMachine();
            pintu.kunci();

        }

        class DoorMachine
        {
            enum State { TERKUNCI, TERBUKA };
            public void kunci()
            {
                State state = State.TERKUNCI;

                String[] screenName = { "TERKUNCI", "TERBUKA" };
                do
                {
                    Console.WriteLine("PINTU " + screenName[(int)state]);
                    Console.Write("Enter Command : ");
                    String command = Console.ReadLine();
                    switch (state)
                    {
                        case State.TERKUNCI:
                            if (command == "BukaPintu")
                            {
                                state = State.TERBUKA;
                            }
                            break;
                        case State.TERBUKA:
                            if (command == "KunciPintu")
                            {
                                state = State.TERKUNCI;
                            }
                            break;



                    }
                } while (state != State.TERKUNCI);
            }
        }
    }
}