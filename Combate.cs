using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Trabalho_Jogo
{
    internal class Combate
    {
        public void comb(int tipo)
        {
            Sprites sprites = new Sprites();
            Sprites luta = new Sprites();
            luta.Fight();
            ReadKey();
            Clear();
            Characters Protagonista = new Characters();
            Enemy inimigo = new Enemy(tipo);

            if (turno() == 1)
            {
                WriteLine("Você Começa Ataquando");
                do
                {
                    inimigo.DisplayEnemy(tipo);
                    Thread.Sleep(2000);
                    Protagonista.Status_Prota();
                    inimigo.calculadoraE();
                    Thread.Sleep(2000);
                    if (Enemy.variacaoHP <= 0)
                    {
                        break;
                    }
                    inimigo.enemyATQ();                    
                    if (Personagem.Vida <= 0)
                    {
                        Personagem.Vida = 0;
                    }                

                } while(Personagem.Vida > 0);

                if(Personagem.Vida <= 0)
                {
                    Clear();
                    sprites.GameOver();
                    WriteLine("Pressione Para Sair...");
                    ReadKey(true);
                    Environment.Exit(0);
                }

            }
            else if (turno() == 0)
            {
                WriteLine("Inimigo Começa Ataquando");
                do
                {                   
                    inimigo.DisplayEnemy(tipo);
                    Thread.Sleep(1000);
                    inimigo.enemyATQ();
                    Thread.Sleep(2000);                  
                    Protagonista.Status_Prota();
                    inimigo.calculadoraE();

                    if (Personagem.Vida <= 0)
                    {
                        Personagem.Vida = 0;
                    }

                    if (Enemy.variacaoHP <= 0)
                    {
                        break;
                    }
                } while(Personagem.Vida > 0);

                if (Personagem.Vida <= 0)
                {
                    Clear();
                    sprites.GameOver();
                    WriteLine("Pressione Para Sair...");
                    ReadKey(true);
                    Environment.Exit(0);
                }
            }


        }

        public int turno()
        {
            int x = new Random().Next(0, 2);
            return (x);
        }
    }
}
