using GameConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Games
{
	public class TetrisGame : IGamePlay
	{
		public string Name { get; set; } = "Tetris";
		public int Score
		{
			get; set;
		}
		// Classic Tetris settings
		private const int BoardWidth = 10;
		private const int BoardHeight = 20;
		private static int[,] Board = new int[BoardHeight, BoardWidth];

		// Tetromino shapes (I, J, L, O, S, T, Z)
		private static readonly int[][,] Shapes = new int[][,]
		{
			new int[,] { { 1, 1, 1, 1 } },                       // I
            new int[,] { { 1, 1, 1 }, { 0, 0, 1 } },             // J
            new int[,] { { 1, 1, 1 }, { 1, 0, 0 } },             // L
            new int[,] { { 1, 1 }, { 1, 1 } },                   // O
            new int[,] { { 0, 1, 1 }, { 1, 1, 0 } },             // S
            new int[,] { { 1, 1, 1 }, { 0, 1, 0 } },             // T
            new int[,] { { 1, 1, 0 }, { 0, 1, 1 } }              // Z
        };

		public void Play()
		{
			ShowInstructions();

			Console.Clear();
			Console.CursorVisible = false;
			Board = new int[BoardHeight, BoardWidth]; // Reset board

			Random random = new Random();

			int[,] currentShape = Shapes[random.Next(Shapes.Length)];
			int currentX = BoardWidth / 2 - 1;
			int currentY = 0;

			while (true)
			{
				if (Console.KeyAvailable)
				{
					var key = Console.ReadKey(true).Key;
					if (key == ConsoleKey.Escape) return;

					// Move Left
					if (key == ConsoleKey.LeftArrow && CanMove(currentShape, currentX - 1, currentY))
						currentX--;

					// Move Right
					if (key == ConsoleKey.RightArrow && CanMove(currentShape, currentX + 1, currentY))
						currentX++;

					// Rotate
					if (key == ConsoleKey.UpArrow)
					{
						var rotated = Rotate(currentShape);
						if (CanMove(rotated, currentX, currentY))
							currentShape = rotated;
					}

					// Soft Drop
					if (key == ConsoleKey.DownArrow && CanMove(currentShape, currentX, currentY + 1))
						currentY++;
				}

				// Game Tick Logic
				if (CanMove(currentShape, currentX, currentY + 1))
				{
					currentY++;
				}
				else
				{
					// Lock shape
					PlaceShape(currentShape, currentX, currentY);

					// Check Lines
					int lines = CheckLines();
					if (lines > 0) Score += lines * 100;

					// Spawn new shape
					currentShape = Shapes[random.Next(Shapes.Length)];
					currentX = BoardWidth / 2 - 1;
					currentY = 0;

					// Game Over Check
					if (!CanMove(currentShape, currentX, currentY))
					{
						ShowEndMessage();
						return;
					}
				}

				DrawBoard(currentShape, currentX, currentY, Score);
				Thread.Sleep(150); // Speed
			}
			
		}

		private void ShowEndMessage()
		{
			Console.Clear();
			Console.Write($"""

		     ██████╗  █████╗ ██    ██╗█████╗
		    ██╔════╝ ██╔══██╗███  ███║██╔══╝
		    ██║  ███╗███████║██╔██═██║█████╗
		    ██║   ██║██╔══██║██║   ██║██╔══╝
		    ╚██████╔╝██║  ██║██║   ██║█████╗
		     ╚═════╝ ╚═╝  ╚═╝╚═╝   ╚═╝╚════╝
		      ██████╗██╗  ██╗█████╗█████╗
		      ██  ██║██║  ██║██╔══╝██╔═██╗
		      ██  ██║██║  ██║█████╗█████╔╝
		      ██  ██║╚██╗██╔╝██╔══╝██╔═██╗
		      ██████║ ╚███╔╝ █████╗██║ ██║
		      ╚═════╝  ╚══╝  ╚════╝╚═╝ ╚═╝

		    Final Score: {Score}

		    
		    [Escape] close game
		""");
			Console.CursorVisible = false;
			bool gameOverScreen = true;
			bool closeRequested = false;
			while (!closeRequested && gameOverScreen)
			{
				Console.CursorVisible = false;
				
				switch (Console.ReadKey(true).Key)
				{
					case ConsoleKey.Enter: gameOverScreen = false; Console.CursorVisible = true; return;
					case ConsoleKey.Escape: closeRequested = true; gameOverScreen = false; Console.CursorVisible = true; return;
				}
				
			}
		
		}
		

		

		private void ShowInstructions()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.Clear();
			Console.WriteLine("""

				     ███ ███╗█████╗██████╗█████╗ ██╗█████╗
				     ╚═██╔═╝██╔══╝╚═██╔═╝██╔═██╗██║██╔══╝
				       ██║  █████╗  ██║  █████╔╝██║ ███╗
				       ██║  ██╔══╝  ██║  ██╔═██╗██║   ██╗
				       ██║  █████╗  ██║  ██║ ██║██║█████║
				       ╚═╝  ╚════╝  ╚═╝  ╚═╝ ╚═╝╚═╝╚════╝

				   Controls:

				   [←] Move Left
				   [→] Move Right
				   [↓] Soft Drop (Fall Faster)
				   [↑] Rotate
				   [Esc] Close Game
				   
				   [Enter] Start Game
				""");
			Console.ReadLine();
		}

		private bool CanMove(int[,] shape, int newX, int newY)
		{
			for (int r = 0; r < shape.GetLength(0); r++)
			{
				for (int c = 0; c < shape.GetLength(1); c++)
				{
					if (shape[r, c] == 1)
					{
						int absX = newX + c;
						int absY = newY + r;

						if (absX < 0 || absX >= BoardWidth || absY >= BoardHeight) return false;
						if (absY >= 0 && Board[absY, absX] == 1) return false;
					}
				}
			}
			return true;
		}

		private void PlaceShape(int[,] shape, int x, int y)
		{
			for (int r = 0; r < shape.GetLength(0); r++)
			{
				for (int c = 0; c < shape.GetLength(1); c++)
				{
					if (shape[r, c] == 1 && y + r >= 0)
					{
						Board[y + r, x + c] = 1;
					}
				}
			}
		}

		private int CheckLines()
		{
			int linesCleared = 0;
			for (int r = BoardHeight - 1; r >= 0; r--)
			{
				bool fullLine = true;
				for (int c = 0; c < BoardWidth; c++)
				{
					if (Board[r, c] == 0) fullLine = false;
				}

				if (fullLine)
				{
					linesCleared++;
					// Move everything down
					for (int upper = r; upper > 0; upper--)
					{
						for (int c = 0; c < BoardWidth; c++)
							Board[upper, c] = Board[upper - 1, c];
					}
					r++; // Recheck this index as new line dropped
				}
			}
			return linesCleared;
		}

		private int[,] Rotate(int[,] shape)
		{
			int rows = shape.GetLength(0);
			int cols = shape.GetLength(1);
			int[,] newShape = new int[cols, rows];

			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					newShape[c, rows - 1 - r] = shape[r, c];
				}
			}
			return newShape;
		}

		private void DrawBoard(int[,] currentShape, int currX, int currY, int score)
		{
			// We use a buffer or just redraw efficiently. For simplicity: SetCursor.
			Console.SetCursorPosition(0, 0);
			Console.WriteLine($"Score: {score}");
			Console.WriteLine("┌" + new string('─', BoardWidth) + "┐");

			// Create display buffer
			int[,] display = (int[,])Board.Clone();

			// Overlay current falling piece
			for (int r = 0; r < currentShape.GetLength(0); r++)
			{
				for (int c = 0; c < currentShape.GetLength(1); c++)
				{
					if (currentShape[r, c] == 1)
					{
						int absY = currY + r;
						int absX = currX + c;
						if (absY >= 0 && absY < BoardHeight && absX >= 0 && absX < BoardWidth)
							display[absY, absX] = 1;
					}
				}
			}

			for (int r = 0; r < BoardHeight; r++)
			{
				Console.Write("│");
				for (int c = 0; c < BoardWidth; c++)
				{
					Console.Write(display[r, c] == 1 ? "█" : " ");
				}
				Console.WriteLine("│");
			}
			Console.WriteLine("└" + new string('─', BoardWidth) + "┘");
		}
	}
}