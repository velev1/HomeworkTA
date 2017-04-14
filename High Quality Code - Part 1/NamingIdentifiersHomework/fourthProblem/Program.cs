//No time for finish the homework. 
//Yes i know that affect eevaluetion and I'm ok ;) 

using System;
using System.Collections.Generic;

namespace fourthProblem
{
    public class Mines
    {
        private const int MAX = 35;

        public class Score
        {
            private string name;
            private int points;

            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }

            public int Points
            {
                get
                {
                    return this.points;
                }
                set
                {
                    this.points = value;
                }
            }

            public Score() { }

            public Score(string name, int points)
            {
                this.name = name;
                this.points = points;
            }
        }

        public static void Main()
        {
            string command = string.Empty;
            char[,] field = create_igralno_pole();
            char[,] mines = slojibombite();
            int counter = 0;
            bool grum = false;
            List<Score> shampion4eta = new List<Score>(6);
            int red = 0;
            int column = 0;
            bool flag = true;
            
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Let play Mines's game. Try to find fields without mines" +
                    " command \"top\" shows ratings, command \"restart\" restarts the game, command \"exit\" exits the application");
                    dumpp(field);
                    flag = false;
                }
                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out red) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        red <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        klasacia(shampion4eta);
                        break;
                    case "restart":
                        field = create_igralno_pole();
                        mines = slojibombite();
                        dumpp(field);
                        grum = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Thanks for playing!");
                        break;
                    case "turn":
                        if (mines[red, column] != '*')
                        {
                            if (mines[red, column] == '-')
                            {
                                tisinahod(field, mines, red, column);
                                counter++;
                            }
                            if (MAX == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                dumpp(field);
                            }
                        }
                        else
                        {
                            grum = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }
                if (grum)
                {
                    dumpp(mines);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", counter);
                    string niknejm = Console.ReadLine();
                    Score t = new Score(niknejm, counter);
                    if (shampion4eta.Count < 5)
                    {
                        shampion4eta.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < shampion4eta.Count; i++)
                        {
                            if (shampion4eta[i].Points < t.Points)
                            {
                                shampion4eta.Insert(i, t);
                                shampion4eta.RemoveAt(shampion4eta.Count - 1);
                                break;
                            }
                        }
                    }
                    shampion4eta.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    shampion4eta.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    klasacia(shampion4eta);

                    field = create_igralno_pole();
                    mines = slojibombite();
                    broya4 = 0;
                    grum = false;
                    flag = true;
                }
                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    dumpp(bombite);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Score to4kii = new Score(imeee, broya4);
                    shampion4eta.Add(to4kii);
                    klasacia(shampion4eta);
                    poleto = create_igralno_pole();
                    bombite = slojibombite();
                    broya4 = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (komanda != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void klasacia(List<Score> to4kii)
        {
            Console.WriteLine("\nTo4KI:");
            if (to4kii.Count > 0)
            {
                for (int i = 0; i < to4kii.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, to4kii[i].Name, to4kii[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void tisinahod(char[,] POLE,
            char[,] BOMBI, int RED, int KOLONA)
        {
            char kolkoBombi = kolko(BOMBI, RED, KOLONA);
            BOMBI[RED, KOLONA] = kolkoBombi;
            POLE[RED, KOLONA] = kolkoBombi;
        }

        private static void dumpp(char[,] board)
        {
            int RRR = board.GetLength(0);
            int KKK = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < RRR; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < KKK; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] create_igralno_pole()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] slojibombite()
        {
            int Редове = 5;
            int Колони = 10;
            char[,] игрално_поле = new char[Редове, Колони];

            for (int i = 0; i < Редове; i++)
            {
                for (int j = 0; j < Колони; j++)
                {
                    игрално_поле[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int kol = (i2 / Колони);
                int red = (i2 % Колони);
                if (red == 0 && i2 != 0)
                {
                    kol--;
                    red = Колони;
                }
                else
                {
                    red++;
                }
                игрално_поле[kol, red - 1] = '*';
            }

            return игрално_поле;
        }

        private static void smetki(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int red = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char kolkoo = kolko(pole, i, j);
                        pole[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char kolko(char[,] r, int rr, int rrr)
        {
            int brojkata = 0;
            int reds = r.GetLength(0);
            int kols = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rr + 1 < reds)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr + 1 < kols)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr + 1 < kols))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr + 1 < kols))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            return char.Parse(brojkata.ToString());
        }
    }
}