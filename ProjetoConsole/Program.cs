using System;

int opcao = 0;

while(opcao >= 0)
{
    Console.Clear(); // Limpa o console
    print("HISTORICO/DOCUMENTAÇÃO DO PROJETO!\n");

    print("Escolha a opção:\n");
    print("Exibir Commits:         1");
    print("Exibir Issues:          2");
    print("Exibir Pull Requests:   3");
    print("Exibir Merges:          4");
    print("Exibir Releases:        5");
    print("Encerrar:               6");
    print("\n");

    string input = Console.ReadLine();

    if (int.TryParse(input, out opcao))
    {
        Console.Clear();

        switch (opcao)
        {
            case 1:
                Commits();
                break;
            case 2:
                Issues();
                break;
            case 3:
                PRs();
                break;
            case 4:
                Merges();
                break;
            case 5:
                Releases();
                break;
            case 6:
                opcao = -1;
                break;
        }

        if(opcao > -1)
        {
            print("\nPressiona qualquer tecla para retornar ao menu.");
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            print("\nAté breve!\n");

        }

    }
}

void Commits()
{
    print("COMMITS\n");

    print("1º");
    print("Initial commit - HASH: 7e3db01ea48e2ce396e1bf0d1ae1836a54b250bd");
    print("\n");

    print("2º");
    print("#1 descrição do trabalho - HASH: eaae554f2cec28c09d40d5e3d3cb7cdf6daf5cd4");
    print("\n");

    print("3º");
    print("#3 Criacao Projeto Console - HASH: 7e8ce8a7cfd83921aa2cc29d77d01145dc1473c4");
    print("\n");

    print("4º");
    print("#4 Documentacao - HASH: 6e510375ed917c76ab29479384f3c8914f4a3260");
    print("\n");

    print("4º");
    print("#6 Correcao Processo e documentacao - HASH: f23e02e642b953e91255d3d1fc7461b0e2c679ab");
    print("\n");
}

void Issues()
{
    print("ISSUES\n");

    print("1ª");
    print("Descrição - NUMBER: #1");
    print("\n");

    print("2ª");
    print("Projeto - NUMBER: #3");
    print("\n");

    print("3ª");
    print("Documentação - NUMBER: #4");
    print("\n");

    print("4ª");
    print("Correção de Processo - NUMBER: #6");
    print("\n");

}

void PRs()
{
    print("PULL REQUESTS\n");

    print("1º");
    print("#1 descrição do trabalho - NUMBER: #2 - ALTER: (+64 / -1)");
    print("\n");

    print("2º");
    print("Projeto e Documentação - NUMBER: #5 - ALTER: (+64 / -2)");
    print("\n");

    print("3º");
    print("#6 Correcao Processo e documentacao - NUMBER: #7 - ALTER: (+1 / -1)");
    print("\n");

    print("4º");
    print("#6 Novo Processo #8 - NUMBER: #8 - ALTER: (+1 / -1)");
    print("\n");
}

void Merges()
{
    print("MERGE PULL REQUESTS\n");

    print("1º");
    print("Merge pull request #2 from MauKnabbenOfficial/develop - HASH: 24cdd8c869b2f3f043e5acce775e259d7388f554");
    print("\n");

    print("2º");
    print("Merge pull request #5 from MauKnabbenOfficial/develop - HASH: 7493d7507b790a14e425e00cebac90ac079c131d");
    print("\n");

    print("3º");
    print("Merge pull request #7 from MauKnabbenOfficial/CorrecaoProcesso - HASH: 8894110dec39e94ab65c01e98096ac7b860f9ff0");
    print("\n");

    print("3º");
    print("Merge pull request #8 from MauKnabbenOfficial/develop - HASH: 21e60caf52661e9faf6cd3dfa52e3e529b1fd6ba");
    print("\n");
}

void Releases()
{
    print("RELEASES\n");

    print("v1.0.0");
    print("What's Changed");
    print("#1 descrição do trabalho by @MauKnabbenOfficial in #2\r\nProjeto e Documentação by @MauKnabbenOfficial in #5");
    print("\n");

    print("v1.0.1");
    print("What's Changed");
    print("#6 Correcao Processo e documentacao by @MauKnabbenOfficial in #7\r\n#6 Novo Processo by @MauKnabbenOfficial in #8");
    print("\n");
}

void print(string info)
{
    Console.WriteLine(info);
}

void Aguarda()
{
    Thread.Sleep(300);
}