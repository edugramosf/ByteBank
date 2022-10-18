//using ByteBank;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_Agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;
//Console.WriteLine("O saldo da conta de André é de R$ " + contaDoAndre.saldo + " reais.");

//contaDoAndre.ExibirDadosDaConta();

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_Agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("O saldo da conta de Maria é de R$ " + contaDaMaria.saldo + " reais.");

//contaDoAndre.Transferir(50, contaDaMaria);

//Console.WriteLine("O saldo da conta de André é de R$ " + contaDoAndre.saldo + " reais.");
//Console.WriteLine("O saldo da conta de Maria é de R$ " + contaDaMaria.saldo + " reais.");

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.numero_Agencia);
//Console.WriteLine(contaDoPedro.conta);
//Console.WriteLine(contaDoPedro.saldo);

using ByteBank.Contas;
using ByteBank.Titular;

Cliente cliente = new Cliente();
cliente.nome = "André Silva";
cliente.cpf = "123456789";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numero_Agencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular = " + conta.titular.nome);
Console.WriteLine("CPF = " + conta.titular.cpf);
Console.WriteLine("Profissão = " + conta.titular.profissao);
Console.WriteLine("N° Conta = " + conta.conta);
Console.WriteLine("Saldo = " + conta.saldo);
Console.WriteLine("N° Agência = " + conta.numero_Agencia);


ContaCorrente conta2 = new ContaCorrente();
conta2.titular = new Cliente();
conta2.titular.nome = "José Souza";
conta2.titular.cpf = "987654321";
conta2.titular.profissao = "Tester";
conta2.conta = "9999-X";
conta2.numero_Agencia = 18;
conta2.saldo = 500;

Console.WriteLine(conta2.titular.nome);