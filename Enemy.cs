using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Trabalho_Jogo
{
    internal class Enemy
    {
        int TypeEnemy;
        string? name;
        public static int Hp, Mp, ATQ, ATQM, Cura;

        public static int variacaoHP = 0;
        static int variacaoMP = 0;
        public int variacaoATQ;
        public int variacaoATQM;
        public int varcura = 0;

        public Enemy(int tipo)
        {
            TypeEnemy = tipo;

            switch(TypeEnemy)
            {
                case 0:
                    name = "Slime";
                    Hp = new Random().Next(15,26);
                    Mp = new Random().Next(15,26);
                    variacaoHP = Hp;
                    variacaoMP = Mp;
                    variacaoATQ = new Random().Next(0, 7);
                    variacaoATQM = new Random().Next(3, 11);
                    ATQ = variacaoATQ;
                    ATQM = variacaoATQM;
                    break;

                case 1:
                    name = "Skeleton";
                    Hp = new Random().Next(20, 31);
                    Mp = 0;
                    variacaoHP = Hp;
                    variacaoMP = Mp;
                    variacaoATQ = new Random().Next(0, 20);
                    ATQ = variacaoATQ ;
                    break;

                case 2:
                    name = "Minotaur";
                    Hp = new Random().Next(23, 41);
                    Mp = new Random().Next(0, 11);
                    variacaoHP = Hp;
                    variacaoMP = Mp;
                    variacaoATQ = new Random().Next(3, 26);
                    variacaoATQM = new Random().Next(3, 11);
                    ATQ = variacaoATQ;
                    ATQM = variacaoATQM;
                    break;

                case 3:
                    name = "Heroes";
                    Hp = new Random().Next(50, 101);
                    Mp = new Random().Next(20, 31);
                    variacaoHP = Hp;
                    variacaoMP = Mp;
                    variacaoATQ = new Random().Next(0, 30);
                    variacaoATQM = new Random().Next(1, 31);
                    varcura = new Random().Next(30,81);
                    ATQ = variacaoATQ;
                    ATQM = variacaoATQM;
                    break;
            }           
        }

        public void DisplayEnemy(int tipo1)
        {
            string borda = "#";

            switch (tipo1)
            {
                case 0:  

                    WriteLine();
                    WriteLine($"    {name}"); // Imprime o nome do inimigo.
                    WriteLine($"  #############################");

                    Write($"  {borda}");
                    ForegroundColor = ConsoleColor.Red;
                    Write($"  Vida - {Hp}/{variacaoHP} \t      ");
                    ResetColor();
                    Write($"{borda}\n");

                    Write($"  {borda}");
                    ForegroundColor = ConsoleColor.Blue;
                    Write($"  Mana - {Mp}/{variacaoMP} \t      ");
                    ResetColor();
                    Write($"{borda}\n");

                    WriteLine("  #---------------------------#");
                    WriteLine($"  {borda} Ataque > 0-7              #");
                    WriteLine($"  {borda} Ataque Mágico > 3-11      #");
                    WriteLine("  #############################");

                    break;

                case 1:
                    
                    WriteLine();
                    WriteLine($"    {name}"); // Imprime o nome do inimigo.
                    WriteLine($"  #############################");

                    Write($"  {borda}");
                    ForegroundColor = ConsoleColor.Red;
                    Write($"  Vida - {Hp}/{variacaoHP} \t      ");
                    ResetColor();
                    Write($"{borda}\n");

                    Write($"  {borda}");
                    ForegroundColor = ConsoleColor.Blue;
                    Write($"  Mana - {Mp}/{variacaoMP} \t      ");
                    ResetColor();
                    Write($"{borda}\n");

                    WriteLine("  #---------------------------#");
                    WriteLine($"  {borda} Ataque > 0-20             #");
                    WriteLine($"  {borda} Ataque Mágico > {ATQM}         #");
                    WriteLine("  #############################");
                    break;

                case 2:    

                    WriteLine();
                    WriteLine($"    {name}"); // Imprime o nome do inimigo.
                    WriteLine($"  #############################");

                    Write($"  {borda}");
                    ForegroundColor = ConsoleColor.Red;
                    Write($"  Vida - {Hp}/{variacaoHP} \t      ");
                    ResetColor();
                    Write($"{borda}\n");

                    Write($"  {borda}");
                    ForegroundColor = ConsoleColor.Blue;
                    Write($"  Mana - {Mp}/{variacaoMP} \t      ");
                    ResetColor();
                    Write($"{borda}\n");

                    WriteLine("  #---------------------------#");
                    WriteLine($"  {borda} Ataque > 3-26             #");
                    WriteLine($"  {borda} Ataque Mágico > 3-11      #");
                    WriteLine("  #############################");
                    break;

                case 3:

                    WriteLine();
                    WriteLine($"    {name}"); // Imprime o nome do inimigo.
                    WriteLine($"  #############################");

                    Write($"  {borda}");
                    ForegroundColor = ConsoleColor.Red;
                    Write($"  Vida - {Hp}/{variacaoHP} \t      ");
                    ResetColor();
                    Write($"{borda}\n");

                    Write($"  {borda}");
                    ForegroundColor = ConsoleColor.Blue;
                    Write($"  Mana - {Mp}/{variacaoMP} \t      ");
                    ResetColor();
                    Write($"{borda}\n");

                    WriteLine("  #---------------------------#");
                    WriteLine($"  {borda} Ataque > 0-30             #");
                    WriteLine($"  {borda} Ataque Mágico > 1-30      #");
                    WriteLine($"  {borda} Cura > 15-51              #");
                    WriteLine("  #############################");
                    break;
            }
        }

        public void calculadoraE()
        {
            variacaoHP = variacaoHP - Personagem.VarATQ;
            variacaoHP = variacaoHP - Personagem.VarATQmag;

            Personagem.VarATQ = 0;
            Personagem.VarATQmag = 0;

            if(variacaoHP > Hp)
            {
                variacaoHP = Hp;
            }

            if(variacaoHP <0)
            {
                variacaoHP = 0;
            }

            if(variacaoMP < 0)
            {
                variacaoMP = 0;
            }
        }

        public void enemyATQ()
        {
            switch (TypeEnemy)
            {
                case 0:      
                    variacaoATQ = new Random().Next(0, 7);
                    variacaoATQM = new Random().Next(3, 14);
                    ATQ = variacaoATQ;
                    ATQM = variacaoATQM;
                    break;

                case 1:                  
                    variacaoATQ = new Random().Next(0, 16);
                    ATQ = variacaoATQ;
                    break;

                case 2:  
                    variacaoATQ = new Random().Next(3, 21);
                    variacaoATQM = new Random().Next(3, 11);
                    ATQ = variacaoATQ;
                    ATQM = variacaoATQM;
                    break;

                case 3:
                    variacaoATQ = new Random().Next(0, 30);
                    variacaoATQM = new Random().Next(1, 30);
                    varcura = new Random().Next(30, 81);
                    ATQ = variacaoATQ;
                    ATQM = variacaoATQM;
                    Cura = varcura;                  
                    break;
            }

            switch (TypeEnemy)
            {
                case 0:
                    int xy = new Random().Next(0, 2);

                    if (xy == 1)
                    {
                        Personagem.varVida += ATQ;
                        WriteLine($"\n Ataque do inimigo: {ATQ}");
                    }

                    if (xy == 0 && variacaoMP >= 4)
                    {
                        Personagem.varVida += ATQM;
                        variacaoMP += -4;
                        WriteLine($"\n Ataque Mágico do inimigo: {ATQM}");
                    }
                    else if (xy == 0 && variacaoMP < 4)
                    {
                        Personagem.varVida += ATQ;
                        WriteLine($"\n Ataque do inimigo: {ATQ}");
                    }
                    break;

                case 1:
                    int xy1 = new Random().Next(0, 2);

                    if (xy1 == 1)
                    {
                        Personagem.varVida += ATQ;
                        WriteLine($"\n Ataque do inimigo: {ATQ}");
                    }

                    if (xy1 == 0 && variacaoMP >= 4)
                    {
                        Personagem.varVida += ATQM;
                        variacaoMP += -4;
                        WriteLine($"\n Ataque Mágico do inimigo: {ATQM}");
                    }
                    else if (xy1 == 0 && variacaoMP < 4)
                    {
                        Personagem.varVida += ATQ;
                        WriteLine($"\n Ataque do inimigo: {ATQ}");
                    }
                    break;

                case 2:
                    int xy2 = new Random().Next(0, 2);

                    if (xy2 == 1)
                    {
                        Personagem.varVida += ATQ;
                        WriteLine($"\n Ataque do inimigo: {ATQ}");
                    }

                    if (xy2 == 0 && variacaoMP >= 4)
                    {
                        Personagem.varVida += ATQM;
                        variacaoMP += -4;
                        WriteLine($"\n Ataque Mágico do inimigo: {ATQM}");
                    }
                    else if (xy2 == 0 && variacaoMP < 4)
                    {
                        Personagem.varVida += ATQ;
                        WriteLine($"\n Ataque do inimigo: {ATQ}");
                    }
                    break;

                case 3:
                    int xy3 = new Random().Next(0, 3);

                    if (xy3 == 1)
                    {
                        Personagem.varVida += ATQ;
                        WriteLine($"\n Ataque do inimigo: {ATQ}");
                    }

                    if (xy3 == 0 && variacaoMP >= 4)
                    {
                        Personagem.varVida += ATQM;
                        variacaoMP += -4;
                        WriteLine($"\n Ataque Mágico do inimigo: {ATQM}");
                    }
                    else if (xy3 == 0 && variacaoMP < 4)
                    {
                        Personagem.varVida += ATQ;
                        WriteLine($"\n Ataque do inimigo: {ATQ}");
                    }

                    if (xy3 == 2 && variacaoMP >= 10)
                    {
                        variacaoHP += Cura;
                        WriteLine($"\n Cura Inimiga: {Cura}");
                    }
                    else if (xy3 == 2 && variacaoMP < 10)
                    {
                        Personagem.varVida += ATQ;
                        WriteLine($"\n Ataque do inimigo: {ATQ}");
                    }

                    break;
            }
          
        }

    }
}
