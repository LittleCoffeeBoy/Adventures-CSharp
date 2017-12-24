using System;

public class Game
{
	public static string[,] matrizTabuleiro = new string[3, 3] {
		{"1", "2", "3"},
		{"4", "5", "6"},
		{"7", "8", "9"}
	};
	public static int posicaoInformada = 0;
	public static bool fimDoJogo;
	public static bool jogadorX, jogadorO;
	public static string vencedor;
	public static int totalPecasJogadasX, totalPecasJogadasO = 0;

	public static void Main()
	{
		jogadorX = true;
		ImprimirTabuleiro();

		do
		{
			string pecaJogadorQueIraJogar = (jogadorX) ? "X" : "O";

			Console.Write($"Informe aonde ira jogar {pecaJogadorQueIraJogar} uma posicao do tabuleiro: ");
			posicaoInformada = Convert.ToInt32(Console.ReadLine());
			
			for (int contadorLinhas = 0; contadorLinhas < 3; contadorLinhas++)
			{
				for (int contadorColunas = 0; contadorColunas < 3; contadorColunas++)
				{
					if (matrizTabuleiro[contadorLinhas, contadorColunas] == posicaoInformada.ToString())
					{
						if (jogadorX)
						{
							matrizTabuleiro[contadorLinhas, contadorColunas] = "X";
							totalPecasJogadasX++;
						}
						else
						{
							matrizTabuleiro[contadorLinhas, contadorColunas] = "O";
							totalPecasJogadasO++;
						}
						
						jogadorX = !jogadorX;
						jogadorO = !jogadorO;
					}
				}
			}

			Console.Clear();
			ImprimirTabuleiro();

			if ((totalPecasJogadasX >= 3) || (totalPecasJogadasO >= 3))
			{
				VerificacaoDeLinha("X", 0);
				VerificacaoDeLinha("X", 1);
				VerificacaoDeLinha("X", 2);

				VerificacaoDeLinha("O", 0);
				VerificacaoDeLinha("O", 1);
				VerificacaoDeLinha("O", 2);

				VerificacaoDeColuna("X", 0);
				VerificacaoDeColuna("X", 1);
				VerificacaoDeColuna("X", 2);

				VerificacaoDeColuna("O", 0);
				VerificacaoDeColuna("O", 1);
				VerificacaoDeColuna("O", 2);

				VerificarDiagonalPrincipal("X");
				VerificarDiagonalPrincipal("O");

				VerificarDiagonalSecundaria("X");
				VerificarDiagonalSecundaria("O");

				if ((totalPecasJogadasX == 5) || (totalPecasJogadasO == 5))
				{
					if (!fimDoJogo)
					{
						Console.WriteLine("Deu Velha!");
						fimDoJogo = true;
					}
				}
			}
		} while (!fimDoJogo);
		
		Console.ReadKey();
	}

	public static void ImprimirTabuleiro()
	{
		for (int contadorLinhas = 0; contadorLinhas < 3; contadorLinhas++)
		{
			for (int contadorColunas = 0; contadorColunas < 3; contadorColunas++)
			{
				Console.Write($"[{matrizTabuleiro[contadorLinhas, contadorColunas]}]");
			}
			Console.WriteLine();
			Console.WriteLine();
		}
	}

	public static void VerificacaoDeLinha(string peca, int linha)
	{
		if (!fimDoJogo)
		{
			int contadorPecasEncontradas = 0;

			for (int contadorColunas = 0; contadorColunas < 3; contadorColunas++)
			{
				if (matrizTabuleiro[linha, contadorColunas].Equals(peca))
				{
					contadorPecasEncontradas++;

					if (contadorPecasEncontradas == 3)
					{
						DefinirVencedor(peca, contadorPecasEncontradas);
					}
				}
			}
		}
	}

	public static void VerificacaoDeColuna(string peca, int coluna)
	{
		if (!fimDoJogo)
		{
			int contadorPecasEncontradas = 0;

			for (int contadorLinhas = 0; contadorLinhas < 3; contadorLinhas++)
			{
				if (matrizTabuleiro[contadorLinhas, coluna].Equals(peca))
				{
					contadorPecasEncontradas++;

					if (contadorPecasEncontradas == 3)
					{
						DefinirVencedor(peca, contadorPecasEncontradas);
					}
				}
			}
		}
	}

	public static void VerificarDiagonalPrincipal(string peca)
	{
		if (!fimDoJogo)
		{
			int contadorPecasEncontradas = 0;

			for (int contadorLinhas = 0; contadorLinhas < 3; contadorLinhas++)
			{
				for (int contadorColunas = 0; contadorColunas < 3; contadorColunas++)
				{
					if (contadorLinhas == contadorColunas && matrizTabuleiro[contadorLinhas, contadorColunas].Equals(peca))
					{
						contadorPecasEncontradas++;

						if (contadorPecasEncontradas == 3)
						{
							DefinirVencedor(peca, contadorPecasEncontradas);
						}
					}
				}
			}
		}
	}

	public static void VerificarDiagonalSecundaria(string peca)
	{
		if (!fimDoJogo)
		{
			int contadorPecasEncontradas = 0;

			for (int contadorLinhas = 0; contadorLinhas < 3; contadorLinhas++)
			{
				for (int contadorColunas = 2; contadorColunas >= 0; contadorColunas--)
				{
					if (contadorLinhas + contadorColunas == 2 && matrizTabuleiro[contadorLinhas, contadorColunas].Equals(peca))
					{
						contadorPecasEncontradas++;

						if (contadorPecasEncontradas == 3)
						{
							DefinirVencedor(peca, contadorPecasEncontradas);
						}
					}
				}
			}
		}
	}

	public static void DefinirVencedor(string peca, int quantidadePecasEncontradas)
	{
		if (peca.Equals("X"))
		{
			vencedor = "X";
		}
		else
		{
			vencedor = "O";
		}

		fimDoJogo = true;
		Console.WriteLine($"O jogador com a peca [{peca}] ganhou o jogo. Parabens!");
	}
}