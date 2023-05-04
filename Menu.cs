using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Trabalho_Jogo
{
    internal class Menu // Criação do Menu
    {
        private int SelectedIndex; // Marcação das Opções.
        private string[] Options;   // Vetor de Opções.
        private string Prompt; // Imagem do Nome do Jogo.

        public Menu(string prompt, string[] opstions)
        {
            Prompt = prompt;
            Options = opstions;
            SelectedIndex = 0;
        }

        private void DisplayOptions() // Configura as Opções do Menu
        {
            WriteLine(Prompt); // Imprime Titulo.
            WriteLine("\n");

            for (int i = 0; i < Options.Length; i++) // Muda a formatação da opção demarcada.
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = ">";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }

                WriteLine($"\t\t\t\t\t  {prefix} << {currentOption} >>"); // Imprime as Opções
            }
            ResetColor();
        }

        public int Run() // Atualiza o indice selecionado atraves das setas
        {
            ConsoleKey KeyPressed;

            do // Vai Rodar enquanto não pressionar Enter.
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo KeyInfo = ReadKey(true);
                KeyPressed = KeyInfo.Key;

                if (KeyPressed == ConsoleKey.UpArrow) // Sobe a marcação dentre as opções.
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (KeyPressed == ConsoleKey.DownArrow) // Desce a marcação dentre as opções.
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (KeyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
    }
}
