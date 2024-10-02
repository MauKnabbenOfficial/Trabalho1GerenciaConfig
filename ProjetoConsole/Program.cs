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
                print("HISTORICO/DOCUMENTAÇÃO DO PROJETO!\n");
                Commits();
                break;
            case 2:
                print("HISTORICO/DOCUMENTAÇÃO DO PROJETO!\n");
                Issues();
                break;
            case 3:
                print("HISTORICO/DOCUMENTAÇÃO DO PROJETO!\n");
                PRs();
                break;
            case 4:
                print("HISTORICO/DOCUMENTAÇÃO DO PROJETO!\n");
                Merges();
                break;
            case 5:
                print("HISTORICO/DOCUMENTAÇÃO DO PROJETO!\n");
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

    print("5º");
    print("#9 Painel de Informação - HASH: e5c7f4007970cf1e7daa0192c20d31878a71189f");
    print("\n");

    print("6º");
    print("#12 Ajuste da documentação - HASH: 389185ca70274f1622fab33407cc9ef4327173e8");
    print("\n");

    print("7º");
    print("#15 menu - HASH: a7a503a551ac677784dfea73e0369e9b0e1fdb22");
    print("\n");

    print("8º");
    print("#18 correcao emergencial - HASH: dd9d6dfa72683e5b78cd6d8bbb112d1de91861b0");
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

    print("5ª");
    print("Painel de Informação - NUMBER: #9");
    print("\n");

    print("6ª");
    print("Ajuste da documentação - NUMBER: #12");
    print("\n");

    print("7ª");
    print("Menu - NUMBER: #15");
    print("\n");

    print("8ª");
    print("Correcao Emergencial - NUMBER: #18");
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

    print("4º");
    print("#6 Novo Processo #8 - NUMBER: #8 - ALTER: (+1 / -1)");
    print("\n");

    print("5º");
    print("#9 Painel de Informação - NUMBER: #10 - ALTER: (+143 / -2)");
    print("\n");

    print("6º");
    print("Documentação gerada na aplicação - NUMBER: #11 - ALTER: (+143 / -2)");
    print("\n");

    print("7º");
    print("#12 Ajuste da documentação - NUMBER: #13 - ALTER: (+2 / -2)");
    print("\n");

    print("8º");
    print("Ajuste na documentação - NUMBER: #14 - ALTER: (+2 / -2)");
    print("\n");

    print("9º");
    print("#15 menu - NUMBER: #16 - ALTER: (+61 / -30)");
    print("\n");

    print("10º");
    print("Menu desenvolvido - NUMBER: #17 - ALTER: (+61 / -30)");
    print("\n");

    print("11º");
    print("#18 correcao emergencial - NUMBER: #19 - ALTER: (+5 / -0)");
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

    print("4º");
    print("Merge pull request #10 from MauKnabbenOfficial/PainelInformacoes - HASH: bc624c09de3c9c590a4f5d49bf58dcfc8425f68b");
    print("\n");

    print("5º");
    print("Merge pull request #11 from MauKnabbenOfficial/develop - HASH: 9233eec6d3f45cd5f733f2db4648c6fc3f53eec0");
    print("\n");

    print("6º");
    print("Merge pull request #13 from MauKnabbenOfficial/AjusteDocumentacao - HASH: aed72a5458693cb7678448855b0ec39707cfdb77");
    print("\n");

    print("7º");
    print("Merge pull request #14 from MauKnabbenOfficial/develop - HASH: 99afa228ccbe5d9ff8e4ebdfa2feafc019ba0278");
    print("\n");

    print("7º");
    print("Merge pull request #16 from MauKnabbenOfficial/Menu - HASH: ef52602fcc054a5307b57a79afec0c8322cddf62");
    print("\n");

    print("8º");
    print("Merge pull request #17 from MauKnabbenOfficial/develop - HASH: 64f1e6982fdf86a770830aac63470937c84ea973");
    print("\n");

    print("9º");
    print("Merge pull request #19 from MauKnabbenOfficial/hotfix/DescricaoDocumentacao - HASH: ca00bcb8a75fc496f4e71b5a4efa34be909a0134");
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

    print("v1.1.0");
    print("What's Changed");
    print("#9 Painel de Informação by @MauKnabbenOfficial in #10\r\nDocumentação gerada na aplicação by @MauKnabbenOfficial in #11");
    print("\n");

    print("v2.0.0");
    print("What's Changed");
    print("#12 Ajuste da documentação by @MauKnabbenOfficial in #13\r\nAjuste na documentação by @MauKnabbenOfficial in #14\r\n#15 menu by @MauKnabbenOfficial in #16\r\nMenu desenvolvido by @MauKnabbenOfficial in #17");
    print("\n");

    print("v2.0.1");
    print("What's Changed");
    print("#18 correcao emergencial by @MauKnabbenOfficial in #19");
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