class Blind_Maze
{
    static void Main()
    {
        char[,] Complite, Finish;
        Maze();
        Complite = Level1(Maze());

        Finish = withFinish(Maze(), Complite);
        WriteLevel(Complite);

        Control(Complite);

        Console.WriteLine("\n\nYou have complite the maze!");
        Console.WriteLine("\n\tPress 'Enter' to close the app");
        Console.ReadLine();
    }
    static char[,] withFinish(char[,] Maze, char[,] Finish)
    {
        for (int i = 0; i < Finish.GetLength(0); i++)
        {
            for (int j = 0; j < Finish.GetLength(1); j++)
            {
                if (Finish[i, j] == 'F')
                {
                    Maze[i, j] = 'F';
                    break;
                }
            }
        }
        return Maze;
    }
    static void Control(char[,] FilledMaze)
    {
        int axis1_Finish = 0, axis0_Finish = 0, axis1_Person = 0, axis0_Person = 0;

        for (int i = 0; i < FilledMaze.GetLength(0) && (axis0_Finish == 0 || axis0_Person == 0); i++)
        {
            for (int j = 0; j < FilledMaze.GetLength(1) && (axis0_Finish == 0 || axis0_Person == 0); j++)
            {
                switch (FilledMaze[i, j])
                {
                    case 'F':
                        axis1_Finish = i;
                        axis0_Finish = j;
                        break;
                    case '◌':
                        axis1_Person = i;
                        axis0_Person = j;
                        break;
                }
            }
        }
        Console.CursorVisible = false;
        Console.SetCursorPosition(axis0_Person, axis1_Person);
        PersonColor();

        while (axis1_Finish != axis1_Person || axis0_Person != axis0_Finish)
        {
            char Move = Console.ReadKey(true).KeyChar;

            switch (Move)
            {
                case 'w':
                case 'ц':
                    if (FilledMaze[axis1_Person - 1, axis0_Person] == '█')
                        break;
                    Console.SetCursorPosition(axis0_Person, axis1_Person);
                    Console.Write(" ");
                    Console.SetCursorPosition(axis0_Person, --axis1_Person);
                    PersonColor();
                    break;

                case 'a':
                case 'ф':
                    if (FilledMaze[axis1_Person, axis0_Person - 1] == '█')
                        break;

                    Console.SetCursorPosition(axis0_Person, axis1_Person);
                    Console.Write(" ");
                    Console.SetCursorPosition(--axis0_Person, axis1_Person);
                    PersonColor();
                    break;

                case 's':
                case 'ы':
                    if (FilledMaze[axis1_Person + 1, axis0_Person] == '█')
                        break;
                    Console.SetCursorPosition(axis0_Person, axis1_Person);
                    Console.Write(" ");
                    Console.SetCursorPosition(axis0_Person, ++axis1_Person);
                    PersonColor();
                    break;

                case 'd':
                case 'в':
                    if (FilledMaze[axis1_Person, axis0_Person + 1] == '█')
                        break;
                    Console.SetCursorPosition(axis0_Person, axis1_Person);
                    Console.Write(" ");
                    Console.SetCursorPosition(++axis0_Person, axis1_Person);
                    PersonColor();
                    break;
            }
        }
    }
    static void PersonColor()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("◌");
        Console.ResetColor();
    }
    static char[,] Maze()
    {
        char[,] Maze = new char[30, 30];

        for (int i = 0; i < Maze.GetLength(0); i++)
        {
            for (int j = 0; j < Maze.GetLength(1); j++)
            {
                Maze[i, j] = '█';
            }
        }
        return Maze;
    }
    static char[,] Level1(char[,] FilledMaze)
    {
        FilledMaze[1, 1] = ' ';
        FilledMaze[1, 2] = ' ';
        FilledMaze[1, 3] = ' ';
        FilledMaze[1, 4] = 'F';
        FilledMaze[1, 6] = ' ';
        FilledMaze[1, 7] = ' ';
        FilledMaze[1, 8] = ' ';
        FilledMaze[1, 9] = ' ';
        FilledMaze[1, 10] = ' ';
        FilledMaze[1, 11] = ' ';
        FilledMaze[1, 12] = ' ';
        FilledMaze[1, 13] = ' ';
        FilledMaze[1, 14] = ' ';
        FilledMaze[1, 15] = ' ';
        FilledMaze[1, 17] = ' ';
        FilledMaze[1, 18] = ' ';
        FilledMaze[1, 19] = ' ';
        FilledMaze[1, 20] = ' ';
        FilledMaze[1, 21] = ' ';
        FilledMaze[1, 22] = ' ';
        FilledMaze[1, 23] = ' ';
        FilledMaze[1, 24] = ' ';
        FilledMaze[1, 25] = ' ';
        FilledMaze[1, 26] = ' ';
        FilledMaze[1, 27] = ' ';
        FilledMaze[1, 28] = ' ';
        FilledMaze[2, 1] = ' ';
        FilledMaze[2, 5] = ' ';
        FilledMaze[2, 8] = ' ';
        FilledMaze[2, 10] = ' ';
        FilledMaze[2, 1] = ' ';
        FilledMaze[2, 15] = ' ';
        FilledMaze[2, 19] = ' ';
        FilledMaze[2, 24] = ' ';
        FilledMaze[2, 28] = ' ';
        FilledMaze[3, 1] = ' ';
        FilledMaze[3, 3] = ' ';
        FilledMaze[3, 5] = ' ';
        FilledMaze[3, 8] = ' ';
        FilledMaze[3, 10] = ' ';
        FilledMaze[3, 12] = ' ';
        FilledMaze[3, 13] = ' ';
        FilledMaze[3, 15] = ' ';
        FilledMaze[3, 16] = ' ';
        FilledMaze[3, 17] = ' ';
        FilledMaze[3, 18] = ' ';
        FilledMaze[3, 19] = ' ';
        FilledMaze[3, 20] = ' ';
        FilledMaze[3, 21] = ' ';
        FilledMaze[3, 22] = ' ';
        FilledMaze[3, 23] = ' ';
        FilledMaze[3, 24] = ' ';
        FilledMaze[3, 26] = ' ';
        FilledMaze[3, 28] = ' ';
        FilledMaze[4, 1] = ' ';
        FilledMaze[4, 3] = ' ';
        FilledMaze[4, 5] = ' ';
        FilledMaze[4, 8] = ' ';
        FilledMaze[4, 10] = ' ';
        FilledMaze[4, 26] = ' ';
        FilledMaze[4, 28] = ' ';
        FilledMaze[5, 1] = ' ';
        FilledMaze[5, 3] = ' ';
        FilledMaze[5, 5] = ' ';
        FilledMaze[5, 6] = ' ';
        FilledMaze[5, 7] = ' ';
        FilledMaze[5, 8] = ' ';
        FilledMaze[5, 10] = ' ';
        FilledMaze[5, 13] = ' ';
        FilledMaze[5, 14] = ' ';
        FilledMaze[5, 15] = ' ';
        FilledMaze[5, 16] = ' ';
        FilledMaze[5, 17] = ' ';
        FilledMaze[5, 19] = ' ';
        FilledMaze[5, 20] = ' ';
        FilledMaze[5, 21] = ' ';
        FilledMaze[5, 22] = ' ';
        FilledMaze[5, 23] = ' ';
        FilledMaze[5, 24] = ' ';
        FilledMaze[5, 25] = ' ';
        FilledMaze[5, 26] = ' ';
        FilledMaze[5, 28] = ' ';
        FilledMaze[6, 1] = ' ';
        FilledMaze[6, 3] = ' ';
        FilledMaze[6, 4] = ' ';
        FilledMaze[6, 10] = ' ';
        FilledMaze[6, 15] = ' ';
        FilledMaze[6, 17] = ' ';
        FilledMaze[6, 19] = ' ';
        FilledMaze[6, 21] = ' ';
        FilledMaze[6, 26] = ' ';
        FilledMaze[6, 28] = ' ';
        FilledMaze[7, 1] = ' ';
        FilledMaze[7, 4] = ' ';
        FilledMaze[7, 5] = ' ';
        FilledMaze[7, 6] = ' ';
        FilledMaze[7, 7] = ' ';
        FilledMaze[7, 8] = ' ';
        FilledMaze[7, 9] = ' ';
        FilledMaze[7, 10] = ' ';
        FilledMaze[7, 11] = ' ';
        FilledMaze[7, 14] = ' ';
        FilledMaze[7, 15] = ' ';
        FilledMaze[7, 19] = ' ';
        FilledMaze[7, 21] = ' ';
        FilledMaze[7, 22] = ' ';
        FilledMaze[7, 23] = ' ';
        FilledMaze[7, 24] = ' ';
        FilledMaze[7, 26] = ' ';
        FilledMaze[7, 28] = ' ';
        FilledMaze[8, 1] = ' ';
        FilledMaze[8, 5] = ' ';
        FilledMaze[8, 11] = ' ';
        FilledMaze[8, 14] = ' ';
        FilledMaze[8, 16] = ' ';
        FilledMaze[8, 17] = ' ';
        FilledMaze[8, 18] = ' ';
        FilledMaze[8, 19] = ' ';
        FilledMaze[8, 24] = ' ';
        FilledMaze[8, 26] = ' ';
        FilledMaze[8, 28] = ' ';
        FilledMaze[9, 1] = ' ';
        FilledMaze[9, 3] = ' ';
        FilledMaze[9, 4] = ' ';
        FilledMaze[9, 5] = ' ';
        FilledMaze[9, 7] = ' ';
        FilledMaze[9, 8] = ' ';
        FilledMaze[9, 11] = ' ';
        FilledMaze[9, 12] = ' ';
        FilledMaze[9, 13] = ' ';
        FilledMaze[9, 14] = ' ';
        FilledMaze[9, 15] = ' ';
        FilledMaze[9, 20] = ' ';
        FilledMaze[9, 21] = ' ';
        FilledMaze[9, 22] = ' ';
        FilledMaze[9, 23] = ' ';
        FilledMaze[9, 24] = ' ';
        FilledMaze[9, 26] = ' ';
        FilledMaze[9, 28] = ' ';
        FilledMaze[10, 1] = ' ';
        FilledMaze[10, 5] = ' ';
        FilledMaze[10, 8] = ' ';
        FilledMaze[10, 9] = ' ';
        FilledMaze[10, 10] = ' ';
        FilledMaze[10, 19] = ' ';
        FilledMaze[10, 20] = ' ';
        FilledMaze[10, 26] = ' ';
        FilledMaze[10, 28] = ' ';
        FilledMaze[11, 1] = ' ';
        FilledMaze[11, 2] = ' ';
        FilledMaze[11, 3] = ' ';
        FilledMaze[11, 4] = ' ';
        FilledMaze[11, 5] = ' ';
        FilledMaze[11, 8] = ' ';
        FilledMaze[11, 10] = ' ';
        FilledMaze[11, 11] = ' ';
        FilledMaze[11, 12] = ' ';
        FilledMaze[11, 13] = ' ';
        FilledMaze[11, 14] = ' ';
        FilledMaze[11, 15] = ' ';
        FilledMaze[11, 19] = ' ';
        FilledMaze[11, 21] = ' ';
        FilledMaze[11, 22] = ' ';
        FilledMaze[11, 23] = ' ';
        FilledMaze[11, 24] = ' ';
        FilledMaze[11, 25] = ' ';
        FilledMaze[11, 26] = ' ';
        FilledMaze[11, 28] = ' ';
        FilledMaze[12, 1] = ' ';
        FilledMaze[12, 7] = ' ';
        FilledMaze[12, 8] = ' ';
        FilledMaze[12, 9] = ' ';
        FilledMaze[12, 15] = ' ';
        FilledMaze[12, 17] = ' ';
        FilledMaze[12, 18] = ' ';
        FilledMaze[12, 19] = ' ';
        FilledMaze[12, 21] = ' ';
        FilledMaze[12, 28] = ' ';
        FilledMaze[13, 1] = ' ';
        FilledMaze[13, 3] = ' ';
        FilledMaze[13, 4] = ' ';
        FilledMaze[13, 5] = ' ';
        FilledMaze[13, 7] = ' ';
        FilledMaze[13, 9] = ' ';
        FilledMaze[13, 11] = ' ';
        FilledMaze[13, 15] = ' ';
        FilledMaze[13, 21] = ' ';
        FilledMaze[13, 23] = ' ';
        FilledMaze[13, 24] = ' ';
        FilledMaze[13, 25] = ' ';
        FilledMaze[13, 26] = ' ';
        FilledMaze[13, 27] = ' ';
        FilledMaze[13, 28] = ' ';
        FilledMaze[14, 1] = ' ';
        FilledMaze[14, 5] = ' ';
        FilledMaze[14, 7] = ' ';
        FilledMaze[14, 9] = ' ';
        FilledMaze[14, 10] = ' ';
        FilledMaze[14, 11] = ' ';
        FilledMaze[14, 12] = ' ';
        FilledMaze[14, 13] = ' ';
        FilledMaze[14, 14] = ' ';
        FilledMaze[14, 15] = '◌';
        FilledMaze[14, 16] = ' ';
        FilledMaze[14, 17] = ' ';
        FilledMaze[14, 18] = ' ';
        FilledMaze[14, 19] = ' ';
        FilledMaze[14, 20] = ' ';
        FilledMaze[14, 21] = ' ';
        FilledMaze[14, 23] = ' ';
        FilledMaze[15, 1] = ' ';
        FilledMaze[15, 3] = ' ';
        FilledMaze[15, 4] = ' ';
        FilledMaze[15, 5] = ' ';
        FilledMaze[15, 6] = ' ';
        FilledMaze[15, 7] = ' ';
        FilledMaze[15, 11] = ' ';
        FilledMaze[15, 15] = ' ';
        FilledMaze[15, 19] = ' ';
        FilledMaze[15, 21] = ' ';
        FilledMaze[15, 23] = ' ';
        FilledMaze[15, 25] = ' ';
        FilledMaze[15, 27] = ' ';
        FilledMaze[15, 28] = ' ';
        FilledMaze[16, 1] = ' ';
        FilledMaze[16, 3] = ' ';
        FilledMaze[16, 7] = ' ';
        FilledMaze[16, 9] = ' ';
        FilledMaze[16, 11] = ' ';
        FilledMaze[16, 15] = ' ';
        FilledMaze[16, 17] = ' ';
        FilledMaze[15, 18] = ' ';
        FilledMaze[15, 19] = ' ';
        FilledMaze[15, 21] = ' ';
        FilledMaze[15, 23] = ' ';
        FilledMaze[15, 25] = ' ';
        FilledMaze[15, 27] = ' ';
        FilledMaze[16, 1] = ' ';
        FilledMaze[16, 3] = ' ';
        FilledMaze[16, 7] = ' ';
        FilledMaze[16, 8] = ' ';
        FilledMaze[16, 9] = ' ';
        FilledMaze[16, 11] = ' ';
        FilledMaze[16, 12] = ' ';
        FilledMaze[16, 13] = ' ';
        FilledMaze[16, 15] = ' ';
        FilledMaze[16, 17] = ' ';
        FilledMaze[16, 19] = ' ';
        FilledMaze[16, 21] = ' ';
        FilledMaze[16, 23] = ' ';
        FilledMaze[16, 25] = ' ';
        FilledMaze[16, 26] = ' ';
        FilledMaze[16, 27] = ' ';
        FilledMaze[16, 28] = ' ';
        FilledMaze[17, 3] = ' ';
        FilledMaze[17, 6] = ' ';
        FilledMaze[17, 7] = ' ';
        FilledMaze[17, 11] = ' ';
        FilledMaze[17, 13] = ' ';
        FilledMaze[17, 15] = ' ';
        FilledMaze[17, 17] = ' ';
        FilledMaze[17, 19] = ' ';
        FilledMaze[17, 21] = ' ';
        FilledMaze[17, 23] = ' ';
        FilledMaze[17, 28] = ' ';
        FilledMaze[18, 1] = ' ';
        FilledMaze[18, 2] = ' ';
        FilledMaze[18, 3] = ' ';
        FilledMaze[18, 5] = ' ';
        FilledMaze[18, 6] = ' ';
        FilledMaze[18, 11] = ' ';
        FilledMaze[18, 13] = ' ';
        FilledMaze[18, 15] = ' ';
        FilledMaze[18, 17] = ' ';
        FilledMaze[18, 19] = ' ';
        FilledMaze[18, 21] = ' ';
        FilledMaze[18, 23] = ' ';
        FilledMaze[18, 24] = ' ';
        FilledMaze[18, 25] = ' ';
        FilledMaze[18, 26] = ' ';
        FilledMaze[18, 27] = ' ';
        FilledMaze[18, 28] = ' ';
        FilledMaze[19, 1] = ' ';
        FilledMaze[19, 5] = ' ';
        FilledMaze[19, 8] = ' ';
        FilledMaze[19, 9] = ' ';
        FilledMaze[19, 10] = ' ';
        FilledMaze[19, 11] = ' ';
        FilledMaze[19, 13] = ' ';
        FilledMaze[19, 15] = ' ';
        FilledMaze[19, 17] = ' ';
        FilledMaze[19, 21] = ' ';
        FilledMaze[19, 28] = ' ';
        FilledMaze[20, 1] = ' ';
        FilledMaze[20, 3] = ' ';
        FilledMaze[20, 4] = ' ';
        FilledMaze[20, 5] = ' ';
        FilledMaze[20, 7] = ' ';
        FilledMaze[20, 8] = ' ';
        FilledMaze[20, 11] = ' ';
        FilledMaze[20, 15] = ' ';
        FilledMaze[20, 17] = ' ';
        FilledMaze[20, 18] = ' ';
        FilledMaze[20, 19] = ' ';
        FilledMaze[20, 20] = ' ';
        FilledMaze[20, 21] = ' ';
        FilledMaze[20, 22] = ' ';
        FilledMaze[20, 23] = ' ';
        FilledMaze[20, 24] = ' ';
        FilledMaze[20, 25] = ' ';
        FilledMaze[20, 26] = ' ';
        FilledMaze[20, 28] = ' ';
        FilledMaze[21, 1] = ' ';
        FilledMaze[21, 3] = ' ';
        FilledMaze[21, 7] = ' ';
        FilledMaze[21, 9] = ' ';
        FilledMaze[21, 11] = ' ';
        FilledMaze[21, 12] = ' ';
        FilledMaze[21, 13] = ' ';
        FilledMaze[21, 14] = ' ';
        FilledMaze[21, 15] = ' ';
        FilledMaze[21, 24] = ' ';
        FilledMaze[21, 26] = ' ';
        FilledMaze[21, 28] = ' ';
        FilledMaze[22, 1] = ' ';
        FilledMaze[22, 3] = ' ';
        FilledMaze[22, 4] = ' ';
        FilledMaze[22, 5] = ' ';
        FilledMaze[22, 6] = ' ';
        FilledMaze[22, 7] = ' ';
        FilledMaze[22, 8] = ' ';
        FilledMaze[22, 9] = ' ';
        FilledMaze[22, 11] = ' ';
        FilledMaze[22, 15] = ' ';
        FilledMaze[22, 17] = ' ';
        FilledMaze[22, 18] = ' ';
        FilledMaze[22, 19] = ' ';
        FilledMaze[22, 20] = ' ';
        FilledMaze[22, 21] = ' ';
        FilledMaze[22, 22] = ' ';
        FilledMaze[22, 23] = ' ';
        FilledMaze[22, 24] = ' ';
        FilledMaze[22, 26] = ' ';
        FilledMaze[22, 28] = ' ';
        FilledMaze[23, 1] = ' ';
        FilledMaze[23, 3] = ' ';
        FilledMaze[23, 11] = ' ';
        FilledMaze[23, 15] = ' ';
        FilledMaze[23, 17] = ' ';
        FilledMaze[23, 28] = ' ';
        FilledMaze[24, 1] = ' ';
        FilledMaze[24, 2] = ' ';
        FilledMaze[24, 3] = ' ';
        FilledMaze[24, 4] = ' ';
        FilledMaze[24, 5] = ' ';
        FilledMaze[24, 6] = ' ';
        FilledMaze[24, 7] = ' ';
        FilledMaze[24, 8] = ' ';
        FilledMaze[24, 9] = ' ';
        FilledMaze[24, 10] = ' ';
        FilledMaze[24, 11] = ' ';
        FilledMaze[24, 15] = ' ';
        FilledMaze[24, 16] = ' ';
        FilledMaze[24, 17] = ' ';
        FilledMaze[24, 18] = ' ';
        FilledMaze[24, 19] = ' ';
        FilledMaze[24, 20] = ' ';
        FilledMaze[24, 21] = ' ';
        FilledMaze[24, 22] = ' ';
        FilledMaze[24, 23] = ' ';
        FilledMaze[24, 24] = ' ';
        FilledMaze[24, 25] = ' ';
        FilledMaze[24, 26] = ' ';
        FilledMaze[24, 27] = ' ';
        FilledMaze[24, 28] = ' ';

        return FilledMaze;
    }
    static void WriteLevel(char[,] Maze)
    {
        for (int i = 0; i < Maze.GetLength(0); i++)
        {
            for (int j = 0; j < Maze.GetLength(1); j++)
            {
                if (Maze[i, j] == 'F')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("F");
                    Console.ResetColor();
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(Maze[i, j]);
            }
            Console.WriteLine();
        }
    }
}