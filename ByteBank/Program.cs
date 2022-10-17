using ByteBank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_Agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;


Console.WriteLine("O saldo da conta de André é de R$ " + contaDoAndre.saldo + " reais.");

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_Agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("O saldo da conta de Maria é de R$ " + contaDaMaria.saldo + " reais.");