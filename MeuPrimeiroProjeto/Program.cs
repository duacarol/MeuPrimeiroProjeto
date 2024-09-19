Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(new string('=', 29));
Console.WriteLine("Jogo de Pedra, Papel, Tesoura");
Console.WriteLine(new string('=', 29));
Console.ResetColor();

while (true)
{
	string[] choice = { "Pedra", "Papel", "Tesoura" };
	Random random = new Random();
	int randomNumber = random.Next(0, 3);
	string computerChoice = choice[randomNumber], userChoice;

	while (true)
	{
		Console.Write($"Escolha 'D' para {choice[0]}, 'P' para {choice[1]} ou 'T' para {choice[2]}: ");
		userChoice = Console.ReadLine().ToUpper();
		if (userChoice == "D" || userChoice == "P" || userChoice == "T")
			break;
		else
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Entrada inválida. Tente novamente.");
			Console.ResetColor();
		}
	}

	if (userChoice == "D")
		userChoice = choice[0];
	else if (userChoice == "P")
		userChoice = choice[1];
	else
		userChoice = choice[2];

	Console.WriteLine($"Você escolheu: {userChoice}");
	Console.WriteLine($"O computador escolheu: {computerChoice}");

	if (userChoice == computerChoice)
		Console.WriteLine("Empate!");
	else if ((userChoice == choice[0] && computerChoice == choice[1]) || (userChoice == choice[1] && computerChoice == choice[2]) || (userChoice == choice[2] && computerChoice == choice[0]))
		Console.WriteLine("Que pena! Você perdeu.");
	else
		Console.WriteLine("Parabéns! Você ganhou!");
	Console.WriteLine();
}