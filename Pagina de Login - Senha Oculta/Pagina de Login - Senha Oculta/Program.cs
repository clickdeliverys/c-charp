using System; // importa funções básicas do C#

class Program
{
    static void Main(string[] args)
    {
        string usuarioCadastrado = ""; // guarda o usuário criado
        string senhaCadastrada = "";   // guarda a senha criada

        Console.WriteLine("===== CADASTRO DE USUÁRIO =====\n");

        Console.Write("Crie um usuário: ");
        usuarioCadastrado = Console.ReadLine() ?? ""; // lê o usuário digitado

        Console.Write("Crie uma senha (letras e/ou números): ");
        senhaCadastrada = LerSenhaOculta();   // chama método que oculta a senha digitada

        Console.WriteLine("\nCadastro realizado com sucesso!");
        Console.WriteLine("Pressione qualquer tecla para ir para a tela de login...");
        Console.ReadKey(); // espera o usuário apertar uma tecla
        Console.Clear();   // limpa a tela

        // ========================== TELA DE LOGIN COM LOOP ==========================

        bool loginCorreto = false; // controla quando o login for aceito

        while (!loginCorreto) // repete enquanto o login estiver errado
        {
            Console.Clear(); // limpa a tela
            Console.WriteLine("===== TELA DE LOGIN =====\n");

            Console.Write("Usuário: ");
            string usuarioLogin = Console.ReadLine() ?? ""; // lê usuário no login

            Console.Write("Senha: ");
            string senhaLogin = LerSenhaOculta();  // lê senha oculta no login

            if (usuarioLogin == usuarioCadastrado && senhaLogin == senhaCadastrada) // valida dados
            {
                Console.WriteLine("\nLogin bem-sucedido! \n\nBem-vindo, " + usuarioLogin + "!");
                loginCorreto = true; // encerra o loop
            }
            else
            {
                Console.WriteLine("\nAcesso negado!\n");

                if (usuarioLogin != usuarioCadastrado)
                    Console.WriteLine("Erro: Usuário não encontrado."); // mostra erro de usuário

                if (senhaLogin != senhaCadastrada)
                    Console.WriteLine("Erro: Senha incorreta."); // mostra erro de senha

                Console.WriteLine("\nPressione qualquer tecla para tentar novamente...");
                Console.ReadKey(); // espera antes de repetir o login
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey(); // finaliza o programa
    }

    // MÉTODO PARA LER SENHA OCULTA COM '*'
    static string LerSenhaOculta()
    {
        string senha = ""; // armazena a senha digitada
        ConsoleKeyInfo tecla; // guarda qual tecla foi pressionada

        do
        {
            tecla = Console.ReadKey(intercept: true); // lê sem mostrar na tela

            if (tecla.Key == ConsoleKey.Backspace && senha.Length > 0) // se apertou backspace
            {
                senha = senha.Substring(0, senha.Length - 1); // remove o último caractere
                Console.Write("\b \b"); // apaga o * visualmente
            }
            else if (!char.IsControl(tecla.KeyChar)) // impede teclas de controle (Enter, Esc…)
            {
                senha += tecla.KeyChar; // adiciona o caractere digitado
                Console.Write("*"); // mostra * no lugar do caractere
            }

        } while (tecla.Key != ConsoleKey.Enter); // encerra ao apertar Enter

        Console.WriteLine(); // pula linha após Enter
        return senha; // retorna a senha digitada
    }
}
