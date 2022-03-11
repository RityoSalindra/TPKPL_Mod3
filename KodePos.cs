using System;

namespace tpmodul3_1302204014
{
    public class KodePos
    {

        public string b = "class KodePos";

        enum State
        {
            START, GAME, PAUSE, EXIT,
            Batununggal, Kujangsari, Mengger, Wates,
            Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru,
            Maleer, Samoja
        };

        public void getKodePos()
        {

            State state = State.START;
            State kel = State.START;
            string[] screenName = { "START", "GAME", "PAUSE", "EXIT", "40266",
                "40287", "40267", "40256", "40287", "40286", "40286", "40286",
                "40272", "40274", "40273"

            };

            while (state != State.EXIT)
            {
              
                Console.WriteLine("Masukkan Kelurahan yang ingin dicari Kode Pos nya");
                Console.Write("Kelurahan : ");



                string command = Console.ReadLine();
                switch (state)
                {
                    case State.START:
                        if (command == "ENTER")
                        {
                            state = State.GAME;
                        }
                        else if (command == "QUIT")
                        {
                            state = State.EXIT;
                        }
                        else if (command == "Batununggal")
                        {

                            kel = State.Batununggal;
                        }
                        else if (command == "Kujangsari")
                        {
                            kel = State.Kujangsari;
                        }
                        else if (command == "Mengger")
                        {
                            kel = State.Mengger;
                        }
                        else if (command == "Wates")
                        {
                            kel = State.Wates;
                        }
                        else if (command == "Cijaura")
                        {
                            kel = State.Cijaura;
                        }
                        else if (command == "Jatisari")
                        {
                            kel = State.Jatisari;
                        }
                        else if (command == "Margasari")
                        {
                            kel = State.Margasari;
                        }
                        else if (command == "Sekejati")
                        {
                            kel = State.Sekejati;
                        }
                        else if (command == "Kebonwaru")
                        {
                            kel = State.Kebonwaru;
                        }
                        else if (command == "Maleer")
                        {
                            kel = State.Maleer;
                        }
                        else if (command == "Samoja")
                        {
                            kel = State.Samoja;
                        }
                        else
                        {
                            state = State.START;
                            command = "QUIT";

                        }
                        break;
                       
                }
                if (command != "QUIT")

                    Console.WriteLine("Kode Pos " + command + " : " + screenName[(int)kel]);

            }
            Console.WriteLine("EXIT SCREEN");
        }
    }
}