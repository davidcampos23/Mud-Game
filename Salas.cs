using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Trabalho_Jogo
{
    internal class Salas
    {
        public int speed;

        public Salas()
        {
            speed = 80;
        }

        public void speed_text()
        {
            ConsoleKeyInfo cki;
            if (Console.KeyAvailable)
            {
                cki = ReadKey(true);

                if (cki.Key == ConsoleKey.Spacebar)
                {
                    speed = speed / 2;
                }
            }
        }

        public void sala_01()
        {
            string t1 = " Você abre os olhos, ao seu redor há somente paredes feitas de um material desconhecido, " +
                        "\n após olhar rápidamente, você percebe que a sala só possui uma saída, uma porta em formato de arco," +
                        "\n de frente a porta, uma criatura está a espreita, você caminha até ela: ";

            foreach (char c in t1)
            {
                Write(c);
                Thread.Sleep(speed);
                speed_text();
            }

            WriteLine("\n");
        }

        public void sala_02()
        {
            speed = 80;
            string t1 = " Após derrotar a criatura, você avança a porta e adentra a sala seguinte," +
                        "\n diante de você está um corredor, onde as laterais estão repletas de jaulas," +
                        "\n você percorre o corredor com cautela, e após 15 minutos andando você sai em uma nova sala. ";

            string t2 = " Diante de você está uma sala circular, com duas saídas laterais," +
                        "\n no meio da sala uma nova criatura o aguarda, você rapidamente entra em guarda:";

            foreach (char c in t1)
            {
                Write(c);
                Thread.Sleep(speed);
                speed_text();
            }

            WriteLine("\n");

            foreach (char c in t2)
            {
                Write(c);
                Thread.Sleep(speed);
                speed_text();
            }

            WriteLine("\n");
        }

        public void sala_03()
        {
            speed = 80;

            string t1 = " Após derrotar a criatura, você escolhe seguir por um dos caminhos: (Direita ou Esquerda)";           

            foreach (char c in t1)
            {
                Write(c);
                Thread.Sleep(speed);
                speed_text();
            }
            string? caminho;
            do
            {
               caminho  = ReadLine();
               if(caminho != null)
               {
                caminho.ToLower();
               }

            }while (caminho != "direita" && caminho != "esquerda");

            WriteLine("\n");

            int sala_ale = new Random().Next(0,2);

            if(sala_ale == 0 )
            {
                string t2 = " Você segue em direção ao caminho escolhido, e após cruzar a passagem" +
                            "\n caminha por mais 7 minutos, até sair em uma sala ampla, fechada em todos os lados," +
                            "\n no centro da sala uma fonte de marmore branco, você se aproxima e bebe da água," +
                            "\n após saciar a sede você se sente revigorado. ( +15 HP, +10 PM )";

                Personagem.Vida += 15;
                Personagem.Mana += 10;              

                string t3 = " Você segue adiante até a próxima sala, e continua caminhando por 20 minutos, " +
                            "\n mesmo cansado você prossegue para o próximo destino, " +
                            "\n diante de você a próxima sala, siga em frente: ";

                foreach (char c in t2)
                {
                    Write(c);
                    Thread.Sleep(speed);
                    speed_text();
                }

                WriteLine("\n");

                foreach (char c in t3)
                {
                    Write(c);
                    Thread.Sleep(speed);
                    speed_text();
                }
            }
            else
            {
                string t3 = " Você segue adiante até a próxima sala, e continua caminhando por 20 minutos, " +
                            "\n mesmo cansado você prossegue para o próximo destino, " +
                            "\n diante de você a próxima sala, siga em frente: ";

                foreach (char c in t3)
                {
                    Write(c);
                    Thread.Sleep(speed);
                    speed_text();
                }
            }

            WriteLine("\n");
        }

        public void sala_04()
        {
            speed = 80;

            string t1 = "";

            foreach (char c in t1)
            {
                Write(c);
                Thread.Sleep(speed);
                speed_text();
            }

            WriteLine("\n");
        }

        public void sala_05()
        {
            string t1 = @"";

            foreach (char c in t1)
            {
                Write(c);
                Thread.Sleep(speed);
                speed_text();
            }

            WriteLine("\n");
        }

        public void sala_Restor()
        {
            string t1 = @"";

            foreach (char c in t1)
            {
                Write(c);
                Thread.Sleep(speed);
                speed_text();
            }

            WriteLine("\n");
        }

        public void Exit_DG()
        {
            string t1 = @"";

            foreach (char c in t1)
            {
                Write(c);
                Thread.Sleep(speed);
                speed_text();
            }

            WriteLine("\n");
        }
    }
}
