Console.OutputEncoding = System.Text.Encoding.UTF8;

void WriteTitle()
{
	Console.Clear();
	Console.ForegroundColor = ConsoleColor.DarkYellow;
	Console.WriteLine(new string('=', 29));
	Console.WriteLine("Jogo de Pedra, Papel, Tesoura");
	Console.WriteLine(new string('=', 29));
	Console.ResetColor();
}
void ColorLine(string texto, ConsoleColor cor)
{
	Console.ForegroundColor = cor;
	Console.WriteLine(texto);
	Console.ResetColor();
}

string[] escolha = { "Pedra 👊", "Papel ✋", "Tesoura ✌️" };
Random aleatorio = new Random();
int pontoUsuario = 0, pontoComputador = 0;

while (true)
{
	int numeroAleatorio = aleatorio.Next(3);
	string escolhaComputador = escolha[numeroAleatorio], escolhaUsuario;

	WriteTitle();

	while (true)
	{
		Console.Write($"Escolha 'D' para {escolha[0]}, 'P' para {escolha[1]} ou 'T' para {escolha[2]}: ");
		escolhaUsuario = Console.ReadLine().ToUpper();
		if (escolhaUsuario == "D" || escolhaUsuario == "P" || escolhaUsuario == "T")
			break;

		else
			ColorLine("Entrada inválida. Tente novamente.", ConsoleColor.DarkRed);
	}

	escolhaUsuario = escolhaUsuario == "D" ? escolha[0] :
					 escolhaUsuario == "P" ? escolha[1] :
											 escolha[2];

	Console.WriteLine();
	Console.WriteLine($"Você escolheu: {escolhaUsuario}");
	Console.WriteLine($"O computador escolheu: {escolhaComputador}");
	Console.WriteLine();

	if (escolhaUsuario == escolhaComputador)
		ColorLine("Empatou! 😬", ConsoleColor.Cyan);

	else if ((escolhaUsuario == escolha[0] && escolhaComputador == escolha[1]) ||
			 (escolhaUsuario == escolha[1] && escolhaComputador == escolha[2]) ||
			 (escolhaUsuario == escolha[2] && escolhaComputador == escolha[0]))
	{
		pontoComputador++;
		ColorLine("Que pena! Você perdeu. 😢", ConsoleColor.Red);
	}
	else
	{
		pontoUsuario++;
		ColorLine("Parabéns! Você ganhou! 🥳", ConsoleColor.Green);
	}

	Console.WriteLine();
	Console.WriteLine($"Placar: Você {pontoUsuario} - {pontoComputador} Computador");
	Console.WriteLine();

	while (true)
	{
		Console.Write("Quer jogar novamente? (S/N): ");
		string jogarDeNovo = Console.ReadLine().ToUpper();

		if (jogarDeNovo == "S")
			break;

		else if (jogarDeNovo == "N")
		{
			WriteTitle();
			Console.WriteLine("Jogo encerrado. Até a próxima! 😊");
			return;
		}
		else
			ColorLine("Entrada inválida. Tente novamente.", ConsoleColor.DarkRed);
	}
}