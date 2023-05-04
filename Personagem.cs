using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Trabalho_Jogo
{
    internal class Personagem
    {
        public static int Vida, Mana, Cura;
        private string MenuStatus;
        private string[] opStatus;
        private int seletorOP;

        public static int VarATQ;
        public static int VarATQmag;
        int VarCURA;
        public static int varVida = 0; 
        static int varMana = 0;

        public Personagem(string[] opstatus, string statusMenu)
        {
            Vida = 30 - varVida + Cura;
            Mana = 15 - varMana;

            if(Vida > 30)
            {
                Vida = 30;
            }

            if(Mana > 15)
            {
                Mana = 15;
            }

            MenuStatus = statusMenu;
            opStatus = opstatus;
            seletorOP = 0;
        }

        public void Calculadora(int opSelect)
        {
            switch (opSelect)
            {
                case 0:
                    VarATQ = new Random().Next(0, 21);
                    WriteLine($"\nDano causado no inimigo: {VarATQ}");
                    break;

                case 1:
                    if(Mana >= 4)
                    {
                        VarATQmag = new Random().Next(10, 21);
                        varMana += 4;
                        WriteLine($"\nDano Mágico causado no inimigo: {VarATQmag}");
                    }
                    break;

                case 2:
                    if (Mana >= 3) 
                    {
                        VarCURA = new Random().Next(13, 31);
                        varMana += 3;
                        Cura += VarCURA;
                        WriteLine($"\nVida Curada: {VarCURA}");
                    }    
                    break;
            }

            
        }

        public void Display_Status() // Aparencia dos status
        {
            WriteLine($"================================================================================================================");
            string borda = "#";
            string espaço = "#";
            WriteLine();
            WriteLine(MenuStatus); // Imprime Titulo.
            WriteLine($"  #############################");

            Write($"  {borda}");
            ForegroundColor = ConsoleColor.Red;
            Write($"  Vida - 30/{Vida} \t      ");
            ResetColor();
            Write($"{borda}\n");
            
            Write($"  {borda}");
            ForegroundColor = ConsoleColor.Blue;
            Write($"  Mana - 15/{Mana} \t      ");
            ResetColor();
            Write($"{borda}\n");

            WriteLine("  #---------------------------#");

            for (int i = 0; i < opStatus.Length; i++) // Muda a formatação da opção demarcada.
            {
                string currentOption = opStatus[i];
                string prefixo;
                string[] numerosStats = { "0-20", "10-25", "5-15" };
                string currentN = numerosStats[i];

                if (i == seletorOP)
                {
                    prefixo = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefixo = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }

                if(i == 0)
                {
                    espaço = "            #";
                }
                else if(i == 1)
                {
                    espaço = "    #";
                }
                else if(i == 2)
                {
                    espaço = "              #";
                }

                WriteLine($"  {borda}{prefixo}{currentOption} > {currentN} {espaço}"); // Imprime as Opções
            }
            ResetColor();

            WriteLine($"  #############################");

            WriteLine($"\n================================================================================================================");
        }



        public int Run_Status() // Atualiza o indice selecionado atraves das setas
        {
            ConsoleKey KeyPressed;

            do // Vai Rodar enquanto não pressionar Enter.
            {
                Clear();
                Display_Status();             


                ConsoleKeyInfo KeyInfo = ReadKey(true);
                KeyPressed = KeyInfo.Key;

                if (KeyPressed == ConsoleKey.UpArrow) // Sobe a marcação dentre as opções.
                {
                    seletorOP--;
                    if (seletorOP == -1)
                    {
                        seletorOP = opStatus.Length - 1;
                    }
                }
                else if (KeyPressed == ConsoleKey.DownArrow) // Desce a marcação dentre as opções.
                {
                    seletorOP++;
                    if (seletorOP == opStatus.Length)
                    {
                        seletorOP = 0;
                    }
                }

            } while (KeyPressed != ConsoleKey.Enter); // vai rodar enquanto não apertar enter.

            return seletorOP; // retorna opção selecionada.
        }
    }
}