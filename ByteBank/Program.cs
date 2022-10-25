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

//using ByteBank.Contas;
//using ByteBank.Titular;

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_Agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("N° Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("N° Agência = " + conta.numero_Agencia);


//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.cpf = "987654321";
//conta2.titular.profissao = "Tester";
//conta2.conta = "9999-X";
//conta2.numero_Agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);


//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_Agencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_Agencia);
//Console.WriteLine(conta3.Conta);


//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_Agencia);

using ByteBank.Contas;
using ByteBank.Titular;

Cliente cliente5 = new Cliente("Márcio Castro", "12345543-26", "Analista de Processos");
ContaCorrente conta5 = new ContaCorrente(283, "1234-X", 1500, cliente5);
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.WriteLine(cliente5.Nome);
Console.WriteLine(cliente5.Cpf);
Console.WriteLine(cliente5.Profissao);
Console.WriteLine(conta5.Numero_Agencia);
Console.WriteLine(conta5.Conta);
Console.WriteLine(conta5.GetSaldo());
Console.WriteLine();

Cliente cliente6 = new Cliente("Delmira Cunha", "987567321-98", "Analista de Suporte");
ContaCorrente conta6 = new ContaCorrente(284, "9874-Z", 15, cliente6);
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.WriteLine(cliente6.Nome);
Console.WriteLine(cliente6.Cpf);
Console.WriteLine(cliente6.Profissao);
Console.WriteLine(conta6.Numero_Agencia);
Console.WriteLine(conta6.Conta);
Console.WriteLine(conta6.GetSaldo());
Console.WriteLine();

Cliente cliente7 = new Cliente("João Kléber", "756432875-34", "Desenvolvedor de Software");
ContaCorrente conta7 = new ContaCorrente(285, "1111-Z", 2889, cliente7);
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.WriteLine(cliente7.Nome);
Console.WriteLine(cliente7.Cpf);
Console.WriteLine(cliente7.Profissao);
Console.WriteLine(conta7.Numero_Agencia);
Console.WriteLine(conta7.Conta);
Console.WriteLine(conta7.GetSaldo());
Console.WriteLine();
