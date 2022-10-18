using DesafioSistemaMedico;

Pessoa pessoa1 = new Pessoa();
pessoa1.nome = "Aderbal Pinheiro";
pessoa1.idade = 45;
pessoa1.altura = 1.72;
pessoa1.peso = 78;

Console.WriteLine("Dados do Paciente: ");
Console.WriteLine();
Console.WriteLine("Nome: " + pessoa1.nome + ".");
Console.WriteLine("Idade: " + pessoa1.idade + " anos.");
Console.WriteLine("Altura: " + pessoa1.altura + "m.");
Console.WriteLine("Peso: " + pessoa1.peso + "Kg.");
