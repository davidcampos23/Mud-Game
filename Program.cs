using System;
using System.Threading;
using static System.Console;


namespace Trabalho_Jogo 
{
    class Program // Classe Principal.
    {
        static void Main(string[] args) 
        {
            Select_Menu Start_Menu = new Select_Menu();
            Start_Menu.Select();

            Thread.Sleep(17);
        }

    }


    class Select_Menu
    {
        public int rnd;

        public void Select() // Chama o Menu Funcional.
        {
            Title = "MUD GAME - The Game! ";

            RunMainMenu();
            

        }

        private void RunMainMenu() // Chama e Da Valor aos Métodos.
        {
            string prompt = @" 



                  ███╗   ███╗██╗   ██╗██████╗      ██████╗  █████╗ ███╗   ███╗███████╗    
                  ████╗ ████║██║   ██║██╔══██╗    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    
                  ██╔████╔██║██║   ██║██║  ██║    ██║  ███╗███████║██╔████╔██║█████╗      
                  ██║╚██╔╝██║██║   ██║██║  ██║    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      
                  ██║ ╚═╝ ██║╚██████╔╝██████╔╝    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    
                  ╚═╝     ╚═╝ ╚═════╝ ╚═════╝      ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝    
                                                                       ";
            string[] options = { "Start Game", "Credits", "Exit" };
            Menu menuPrincipal = new Menu(prompt, options);
            int selectedIndex = menuPrincipal.Run();

            switch(selectedIndex) // Chama a opção Selecionada.
            {
                case 0:
                    FirstChoise();
                    break;

                case 1:
                    DisplayCredits();
                    break;

                case 2:
                    ExitGame();
                    break;
            }
        }

        public void FirstChoise() // Começar o Jogo
        {
            Clear();
            Sprites sprites = new Sprites();
            Salas narrativa = new Salas();
            dialogo falas = new dialogo();
            Combate combate = new Combate();
            
            falas.inicio(); // inicio do jogo.
            WriteLine();
            sprites.inicio();
            ReadKey();
            Clear();

            narrativa.sala_01(); // primeira sala.
            rnd = falas.choiceDIG(); // primeiro inimigo.
            choiceEnemy(rnd); // escolha do inimigo
            Clear();           
            combate.comb(rnd); // funçao do combate

            Clear();
            narrativa.sala_02(); // segunda sala
            rnd = falas.choiceDIG(); // proximo inimigo.
            choiceEnemy(rnd); // escolha do inimigo
            Clear();
            combate.comb(rnd); // funçao do combate

            Clear();
            narrativa.sala_03(); // terceira sala
            rnd = falas.choiceDIG(); // proximo inimigo.
            choiceEnemy(rnd); // escolha do inimigo
            Clear();
            combate.comb(rnd); // funçao do combate

           /* Clear();
            narrativa.sala_04(); // quarta sala.
            rnd = falas.choiceDIG(); // proximo inimigo.
            choiceEnemy(rnd); // escolha do inimigo
            Clear();
            combate.comb(rnd); // funçao do combate
           */

            falas.FindHeros(); // fala dos herois.
            rnd = 3; // grupo de herois.
            choiceEnemy(rnd);
            combate.comb(rnd); // funçao do combate

            sprites.Fim();
            ExitGame();
        }

        private void DisplayCredits() // Mostrar Creditos.
        {
            Clear();

            WriteLine("Esse Jogo foi Criado Por: \nDavid Campos \nRafael  \nSantiago.");
            WriteLine("\nInspiração do Menu: https://www.youtube.com/watch?v=qAWhGEPMlS8.");
            WriteLine("Desenvolvimento do Código: David.");
            WriteLine("\nPressione Para Voltar ao Menu...");

            ReadKey(true);
            RunMainMenu(); // Volta para o Menu Inicial.
        }

        private void ExitGame() // Metodo para Sair do Jogo.
        {
            WriteLine("Pressione Para Sair...");
            ReadKey(true);
            Environment.Exit(0); // Fecha o Console.          
        }

        public void choiceEnemy(int tipo)
        {
            Sprites sprites = new Sprites();
            dialogo falas = new dialogo();

            if (tipo == 0)
            {
                falas.FindSlime();
                Clear();
                sprites.Slime();
                Thread.Sleep(3000);
            }
            else if (tipo == 1)
            {
                falas.FindSkeleton();
                Clear();
                sprites.Skeleton();
                Thread.Sleep(3000);
            }
            else if (tipo == 2)
            {
                falas.FindMinotaur();
                Clear();
                sprites.Minotaur();
                Thread.Sleep(3000);
            }
            else if(tipo == 3)
            {
                Clear();
                sprites.heroi();
                Thread.Sleep(2000);
                Clear();
                sprites.Cleriga();
                Thread.Sleep(2000);
                Clear();
                sprites.Arqueira();
                Thread.Sleep(2000);
                Clear();
            }
        }

    }
  


    class Characters
    {
        public void Status_Prota()
        {
            string status = @"     CHARACTER STATUS ";
            string[] options_Status = { "Ataque", "Ataque Mágico", "Cura" };
            Personagem Player = new Personagem(options_Status, status);           
            int selectedIndex = Player.Run_Status();            

            switch (selectedIndex)
            {
                case 0:
                    Player.Calculadora(selectedIndex);
                    break;

                case 1:
                    Player.Calculadora(selectedIndex);
                    break;

                case 2:
                    Player.Calculadora(selectedIndex);
                    break;
            }

        }
    }

}