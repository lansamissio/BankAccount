namespace BankAccount
{
    public class Conta
    {
        static void Main()
        {
            // Coleta de informações do usuário
            Console.Write("Nome Completo: ");
            string nome = Console.ReadLine();
            
            Console.Write("Data de Nascimento (dd/mm/aaaa): ");
            string dataNascimento = Console.ReadLine();
            
            Console.Write("Digite seu CPF: ");
            string cpf = Console.ReadLine();
            
            Console.Write("Digite sua nacionalidade: ");
            string nacionalidade = Console.ReadLine();

            // Saldo inicial zerado
            int saldo = 0;

            // Loop para operações de conta
            while (true)
            {
                // Exibição das informações da conta
                MostrarInformacoes(nome, dataNascimento, cpf, nacionalidade, saldo);

                // Pergunta ao usuário se deseja realizar uma operação
                Console.WriteLine("Deseja realizar uma operação? (s/n)");
                string resposta = Console.ReadLine().ToLower();
                if (resposta != "s")
                {
                    //Caso não queira realizar nenhuma operação é exibida a mensagem abaixo
                    Console.WriteLine("Obrigado por utilizar nossos serviços. A operação foi encerrada.");
                    break;
                }

                // Caso queira realizar alguma operação, pergunta ao usuário qual operação deseja realizar
                Console.WriteLine("Escolha a operação: 1-Depositar 2-Sacar");
                string operacao = Console.ReadLine();

                // Realização da operação (1 para depositar e 2 para sacar)
                if (operacao == "1")
                {
                    saldo = Depositar(saldo);
                }
                else if (operacao == "2")
                {
                    saldo = Sacar(saldo);
                }
                // Caso não selecione uma opção valida exibe uma mensagem de erro
                else
                {
                    Console.WriteLine("Operação inválida.");
                }
            }
        }

        // Método para exibir informações da conta
        static void MostrarInformacoes(string nome, string dataNascimento, string cpf, string nacionalidade, int saldo)
        {
            Console.Clear();
            Console.WriteLine($"Olá, {nome}, portador do CPF: {cpf}, nascido em {dataNascimento}, natural de {nacionalidade}.");
            Console.WriteLine($"Seu saldo disponível é de: {saldo:C}");
        }

        // Método para depositar valor na conta
        static int Depositar(int saldo)
        {
            Console.Write("Digite o valor a ser depositado: ");
            if (int.TryParse(Console.ReadLine(), out int valorDeposito) && valorDeposito > 0)
                //int.TryParse(Console.ReadLine) recebe a entrada do usuario e a converte em numero int
               //&& para combinar duas condições, a conversão para int e que o valor informado seja >0
            {
                saldo += valorDeposito;
                Console.WriteLine($"Depósito realizado com sucesso! Novo saldo: {saldo:C}");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            return saldo;
        }

        // Método para sacar valor da conta
        static int Sacar(int saldo)
        {
            Console.Write("Digite o valor a ser sacado: ");
            if (int.TryParse(Console.ReadLine(), out int valorSaque) && valorSaque > 0)
                //int.TryParse(Console.ReadLine) recebe a entrada do usuario e a converte em numero int
                //&& para combinar duas condições, a conversão para int e que o valor informado seja >0
            {
                if (valorSaque <= saldo)
                    //se valor do saque for menor ou igual ai saldo
                {
                    saldo -= valorSaque;
                    Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {saldo:C}");
                    //subtrai o valor do saque do saldo, atualiza o saldo após subtração e exibe com a mensagem
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para realizar o saque.");
                    //se o valor de saque digitado pelo usuario for maior que o valor disponivel do saldo
                    //aparece a mensagem de saldo insulficiente
                }
            }
            else
            {
                Console.WriteLine("Valor de saque inválido.");
                //caso digite algo que não seja um numero válido exibe essa mensagem de erro
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            return saldo;
        }
    }
}