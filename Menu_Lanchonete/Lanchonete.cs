using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Menu_Lanchonete
{
    class Lanchonete
    {
        static void Main(string[] args)
        {
            List<Funcionario> BancoDeDados = new List<Funcionario>();
            List<Cardapio> Comidas = new List<Cardapio>();
            List<Cardapio> Bebidas = new List<Cardapio>();
            bool loop = true;
            /*BancoDeDados.Add(new Funcionario
            {
                LoginFunc = "123",
                SenhaFunc = "456"
            });

            Bebidas.Add(new Cardapio
            {
                NomeProduto = "Coca",
                PrecoProduto = 4.65,
                ID = 1                
            });
            Bebidas.Add(new Cardapio
            {
                NomeProduto = "Sprite",
                PrecoProduto = 3.65,
                ID = 2
            });

            Comidas.Add(new Cardapio
            {
                NomeProduto = "Pão",
                PrecoProduto = 4.65,
                ID = 1
            });

            Comidas.Add(new Cardapio
            {
                NomeProduto = "Biscoito",
                PrecoProduto = 1.85,
                ID = 2
            });*/


            while (loop)
            {
                Console.Clear();               
                Console.Write("O que deseja fazer (1) Adicionar item ao cardápio // (2) Abrir Cardápio // (3) Cadastrar Funcionario: ");
                string opcao = Console.ReadLine();                
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Digite login do funcionario: ");
                        string loginDoFunc = Console.ReadLine();                    
                        Console.Write("Digite senha do funcionario: ");
                        string senhaDoFunc = Console.ReadLine();
                        if (!BancoDeDados.Any(p => p.LoginFunc == loginDoFunc && p.SenhaFunc == senhaDoFunc)) //verifica dados dentro da lista
                        {
                            Console.WriteLine("Usuario/senha Invalido");
                            Thread.Sleep(2000);
                            break;
                        }
                        Console.WriteLine("Acesso permitido");
                        Thread.Sleep(2000);
                        Console.Clear();

                        // MENU PARA CADASTRAR ITEMS

                        bool menuCadastrarItens = true;
                        while (menuCadastrarItens)
                        {
                            Console.WriteLine();
                            Console.WriteLine("O que deseja fazer (1) Adicionar Bebida // (2) Adicionar Comida // (3) Sair: ");
                            string opcaoMenu1 = Console.ReadLine();
                            switch (opcaoMenu1)
                            {
                                case "1":
                                    Console.Write("Nome da bebida: ");
                                    string nomeBebida = Console.ReadLine();
                                    Console.Write("Preço da bebida: ");
                                    double precoBebida = double.Parse(Console.ReadLine());
                                    Bebidas.Add(new Cardapio
                                    {
                                        NomeProduto = nomeBebida,
                                        PrecoProduto = precoBebida,
                                        ID = Bebidas.Count() + 1
                                    });
                                    Console.Write("Bebida cadastrada com sucesso!");
                                    Thread.Sleep(2000);
                                    break;
                                case "2":
                                    Console.Write("Nome da comida: ");
                                    string nomeComida = Console.ReadLine();
                                    Console.Write("Preço da comida: ");
                                    double precoComida = double.Parse(Console.ReadLine());
                                    Comidas.Add(new Cardapio
                                    {
                                        NomeProduto = nomeComida,
                                        PrecoProduto = precoComida,
                                        ID = Comidas.Count() + 1
                                    });
                                    Console.WriteLine("Comida cadastrada com sucesso!");
                                    break;
                                case "3":
                                    menuCadastrarItens = false;
                                    break;
                            }
                            Thread.Sleep(2000);                            
                        }
                        break;

                        //MENU PARA MOSTRAR PRODUTOS (BEBIDA E COMIDA)

                    case "2":                        
                        bool loop2 = true;
                        List<Cardapio> carrinho = new List<Cardapio>();                        
                        List<Cardapio> carrinhoComida = new List<Cardapio>();                        
                        Console.Clear();
                        while (loop2)
                        {                            
                            Console.WriteLine("O que deseja ver (1) Bebidas (2) Comidas (3) Finalizar Pedido (4) Sair: ");
                            string opcao3 = Console.ReadLine();
                            switch (opcao3)
                            {
                                case "1":
                                    bool loopBebida = true;

                                    while (loopBebida)
                                    {
                                        foreach (var item in Bebidas)
                                        {
                                            Console.WriteLine($"ID: {item.ID}\nNome: {item.NomeProduto}\nPreço: {item.PrecoProduto}\n");
                                        }
                                        Console.WriteLine("Digite ID da bebida que deseja ou 0 para sair: ");
                                        int selecionarID = int.Parse(Console.ReadLine());
                                        if(selecionarID == 0)
                                        {
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            break;
                                        }
                                        if (!Bebidas.Any(p => p.ID == selecionarID))
                                        {
                                            Console.WriteLine("Bebida não encontrada");
                                            Thread.Sleep(2000);
                                            break;
                                        }
                                        foreach (var item in Bebidas)
                                        {
                                            if (item.ID == selecionarID)
                                            {
                                                carrinho.Add(item);
                                            }
                                        }
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                    }
                                    break;
                                case "2":
                                    bool loopComida = true;
                                    while (loopComida)
                                    {
                                        foreach (var item in Comidas)
                                        {
                                            Console.WriteLine($"ID: {item.ID}\nNome: {item.NomeProduto}\nPreço: {item.PrecoProduto}\n");
                                        }
                                        Console.WriteLine("Digite ID da comida que deseja ou 0 para sair: ");
                                        int selecionarIDComida = int.Parse(Console.ReadLine());
                                        if(selecionarIDComida == 0)
                                        {
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            break;
                                        }
                                        if (!Comidas.Any(p => p.ID == selecionarIDComida))
                                        {
                                            Console.WriteLine("Comida nao encontrada");
                                            Thread.Sleep(2000);
                                            break;
                                        }
                                        foreach (var item in Comidas)
                                        {
                                            if (item.ID == selecionarIDComida)
                                            {
                                                carrinho.Add(item);
                                            }                                            
                                        }
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                    }                                   
                                    break;

                                    //CARRINHO

                                case "3":
                                    Console.WriteLine();
                                    Console.WriteLine("Carrinho: ");                                  
                                    foreach (var item in carrinho)
                                    {                                        
                                        //Mostrar itens adicionados no carrinho                                       
                                        Console.WriteLine($"{item.NomeProduto}\n{item.PrecoProduto}");                                       
                                    }                                    
                                    Console.WriteLine("Deseja finalizar sua compra? [s/n]: ");
                                    string finalizar = Console.ReadLine();
                                    double valorTOTAL = 0;
                                    if (finalizar == "s" || finalizar == "S")
                                    {                                        
                                        foreach (var item in carrinho)
                                        {                                            
                                            valorTOTAL += item.PrecoProduto;
                                        }
                                        if(valorTOTAL >= 30 && valorTOTAL < 50)
                                        {
                                            valorTOTAL = valorTOTAL - (valorTOTAL*0.05);
                                        }
                                        else if (valorTOTAL >= 50)
                                        {
                                            valorTOTAL = valorTOTAL - (valorTOTAL *0.10);
                                        }
                                        else
                                        {
                                            break;
                                        }
                                        Console.WriteLine($"Valor da compra: R${valorTOTAL:F2}");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    break;
                                case "4":
                                    loop2 = false;
                                    break;
                            }                  
                        }                        
                        break;
                        
                        //CADASTRO DE FUNCIONARIOS

                    case "3":
                        Console.Clear();
                        Console.Write("Digite seu Login: ");
                        string login = Console.ReadLine();
                        Console.Write("Digite sua senha: ");
                        string senha = Console.ReadLine();
                        if (login == "admin" && senha == "1010")
                        {
                            Console.WriteLine("Acesso permitido");
                        }                 
                        else
                        {
                            Console.WriteLine("Usuario e/ou senha inválido!");
                            Thread.Sleep(2000);
                            break;
                        }                        
                        Console.WriteLine();
                        Console.Write("Nome do funcionário que será cadastrado: ");
                        string nomeFuncionario = Console.ReadLine();
                        Console.Write("Login de acesso do novo funcionario: ");
                        string loginFunc = Console.ReadLine();
                        Console.Write("Senha de acesso do novo funcionario: ");
                        string senhaFunc = Console.ReadLine();
                        BancoDeDados.Add(new Funcionario
                        {
                            Nome = nomeFuncionario,
                            LoginFunc = loginFunc,
                            SenhaFunc = senhaFunc
                        });
                        Console.WriteLine("Funcionario cadastrado com sucesso, aguarde!");
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}
