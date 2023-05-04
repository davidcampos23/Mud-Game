using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Trabalho_Jogo
{
    internal class dialogo
    {
        public static int Speed;

        public dialogo()
        {
            Speed = 80;
            
        }

        public void TextSpeed()
        {
            ConsoleKeyInfo cki;

            if (KeyAvailable)
            {
                cki = ReadKey(true);

                if (cki.Key == ConsoleKey.Spacebar)
                {
                    Speed = Speed / 2;
                }
            }
        }


        public void inicio()
        {
            Thread.Sleep(1000);          
            string text = "\t Você acorda dentro de uma masmorra, sobreviva e saia vivo...";

            foreach (char c in text)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }               
        }

        public void FindSlime()
        {
            Speed = 80;
            string T1 = " Uma gosma viva começa a se mexer...";
            string T2 = " Protagonista:\n Morra gosma nojenta\n\n Slime:\n *Sons gelatinosos*...";
            string T3 = " Protagonista:\n Geopolítica aqui não\n\n Slime:\n *Barulho de gotejo*...";            

            foreach (char c in T1)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();

            WriteLine("\n");
            
            foreach (char c in T2)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();

            WriteLine("\n");       

            foreach (char c in T3)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();
        }

        public void FindMinotaur()
        {
            Speed = 80;

            string T1 = " Você se depara com um minotauro agressivo...";
            string T2 = " Protagonista:\n Sai daqui chifrudo\n\n Minotauro:\n *Sons de mugido*...";
            string T3 = " Protagonista:\n Se mexer com o touro vai levar uma chifrada\n\n Minotauro:\n *Gritos de boi*...";

            foreach (char c in T1)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();

            WriteLine("\n");
            
            foreach (char c in T2)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();

            WriteLine("\n");         

            foreach (char c in T3)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();
        }

        public void FindSkeleton()
        {
            Speed = 80;

            string T1 = " Um esqueleto tenta te acertar...";
            string T2 = " Protagonista:\n Cê vai morrer, ô Puro Osso\n\n Esqueleto:\n *Sons estridentes*...";
            string T3 = " Protagonista:\n Eu não sou o Billy, ossudo\n\n Esqueleto:\n *Ossos quebrando...";

            foreach (char c in T1)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();

            WriteLine("\n");

            foreach (char c in T2)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();

            WriteLine("\n");

            foreach (char c in T3)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();
        }


        public void FindBau()
        {
            Speed = 80;

            string T1 = " Você encontra um baú dentro da sala\n Dentro do baú você acha um livro que te ensina um Ataque Mágico...";
            string T2 = " Você encontra um baú dentro da sala\n Dentro do baú você acha um livro que te ensina a se curar...";

            foreach (char c in T1)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();

            WriteLine("\n");

            foreach (char c in T2)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();
        }

        public void FindHeros()
        {
            Speed = 80;
            Clear();
            string T1 = " Você consegue escapar com vida da masmorra, mas encontra um grupo de hérois que sacam suas armas para você...";
            string T2 = " Arqueira:\n Então esse é o monstro que pediram para matarmos?\n\n Clérigo:\n Que Deus tenha piedade desta pobre alma!!\n\n Guerreiro\n Vamos logo matar essa criatura...";
            string T3 = " Protagonista:\n *Grunhidos irreconhecíveis*...";

            foreach (char c in T1)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();

            WriteLine("\n");

            foreach (char c in T2)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }

            WriteLine("\n");

            foreach (char c in T3)
            {
                Write(c);
                Thread.Sleep(Speed);
                TextSpeed();
            }
            ReadKey();

        }


        public int choiceDIG()
        {
            int x = new Random().Next(0, 3);
            return (x);
        }

    }
}

