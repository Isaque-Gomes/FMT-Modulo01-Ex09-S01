// Instituição bancária Coqueiros
string opcao;
string opcao2;
string opcao3 = "0";
float insercao;

Console.WriteLine("Olá, bem vindo ao banco nacional Coqueiros! Por favor, selecione uma opção para continuar:");
do{
    Console.WriteLine("1. Adicionar uma transação");
    Console.WriteLine("2. Consultar extrato");
    Console.WriteLine("3. Sair");
    opcao = Console.ReadLine();
} while (!(opcao == "1" || opcao == "2" || opcao == "3"));
List<float> transacoes = new List<float>();
if(opcao == "1"){
    do{
        Console.WriteLine("Digite o valor da transação:");
        while(! float.TryParse(Console.ReadLine(), out insercao)){
            Console.WriteLine("Favor digitar somente números. Digite o valor da transacao:");
        };
        transacoes.Add(insercao);
        Console.WriteLine("O que deseja fazer agora?");
        Console.WriteLine("1. Adicionar mais uma transação");
        Console.WriteLine("2. Consultar extrato");
        Console.WriteLine("3. Sair");
        opcao2 = Console.ReadLine();
    } while(!(opcao2 == "1" || opcao2 == "2" || opcao2 == "3"));
    if(opcao2 == "1"){
        do{
        Console.WriteLine("Digite o valor da transação:");
        while(! float.TryParse(Console.ReadLine(), out insercao)){
            Console.WriteLine("Favor digitar somente números. Digite o valor da transacao:");
        };
        transacoes.Add(insercao);
        Console.WriteLine("Não é possível mais adicionar transações. O que deseja fazer agora?");
        Console.WriteLine("1. Consultar extrato");
        Console.WriteLine("2. Sair");
        opcao3 = Console.ReadLine();
    } while(!(opcao3 == "1" || opcao3 == "2"));
    }
    if(opcao3 == "1" || opcao == "2" || opcao2 == "2"){
        Console.WriteLine("Os valores das transações foram:");
        foreach(var transacao in transacoes){
            Console.WriteLine(transacao.ToString("N"));
        }

    } else{
        Console.WriteLine("Obrigado por sua visita. Até logo!");
    }
} else{
        Console.WriteLine("Obrigado por sua visita. Até logo!");
}