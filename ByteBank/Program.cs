﻿using ByteBank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_Agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;
Console.WriteLine("O saldo da conta de André é de R$ " + contaDoAndre.saldo + " reais.");


ContaCorrente contaDoAndre2 = new ContaCorrente();
contaDoAndre2.titular = "André Silva";
contaDoAndre2.numero_Agencia = 15;
contaDoAndre2.conta = "1010-X";
contaDoAndre2.saldo = 100;
Console.WriteLine("O saldo da conta de André é de R$ " + contaDoAndre2.saldo + " reais.");

Console.WriteLine(contaDoAndre == contaDoAndre2);

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
