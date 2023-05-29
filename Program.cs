using bytebank;
using bytebank.Contas;


LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt");

try {
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.Fechar();
}
catch(IOException) {
    Console.WriteLine($"Leitura Interrompida");
}
finally {
    leitor.Fechar();
}

#region
    /*try {
        ContaCorrente conta01 = new ContaCorrente(0, "1234");

        //conta01.Sacar(50);
        //Console.WriteLine($"Saldo da Conta.: {conta01.GetSaldo():C}");

        //conta01.Sacar(150);
        //Console.WriteLine($"Saldo da Conta.: {conta01.GetSaldo():C}");


    }
    catch (ArgumentException ex) {
        Console.WriteLine($"Parametro com erro..: {ex.ParamName}");
        Console.WriteLine(ex.Message);  
        Console.WriteLine(ex.StackTrace);
    }
    catch(SaldoInsuficienteException ex) {
        Console.WriteLine("Operação Negada! Saldo Insuficiente!");
        Console.WriteLine(ex.Message);
    }*/

#endregion