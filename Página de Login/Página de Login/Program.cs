using System;

class Program
{
    static void Main(string[] args)
    {
        string usuarioCadastrado = "";
        string senhaCadastrada = ""; // agora é string, se fosse inteiro seria int senhaCadastrada = 0;

        Console.WriteLine("===== CADASTRO DE USUÁRIO =====\n");

        Console.Write("Crie um usuário: ");
        usuarioCadastrado = Console.ReadLine() ?? "";

        Console.Write("Crie uma senha (letras e/ou números): ");
        senhaCadastrada = Console.ReadLine() ?? "";   // não usa mais int.Parse

        Console.WriteLine("\nCadastro realizado com sucesso!");
        Console.WriteLine("Pressione qualquer tecla para ir para a tela de login...");
        Console.ReadKey();
        Console.Clear();


        // ========================== TELA DE LOGIN COM LOOP ==========================

        bool loginCorreto = false;

        while (!loginCorreto)
        {
            Console.Clear();
            Console.WriteLine("===== TELA DE LOGIN =====\n");

            Console.Write("Usuário: ");
            string usuarioLogin = Console.ReadLine() ?? "";

            Console.Write("Senha: ");
            string senhaLogin = Console.ReadLine() ?? "";  // agora é string também

            // Validação
            if (usuarioLogin == usuarioCadastrado && senhaLogin == senhaCadastrada)
            {
                Console.WriteLine("\nLogin bem-sucedido! Bem-vindo, " + usuarioLogin + "!");
                loginCorreto = true; // sai do loop
            }
            else
            {
                Console.WriteLine("\nAcesso negado!");

                if (usuarioLogin != usuarioCadastrado)
                    Console.WriteLine("Erro: Usuário não encontrado.");

                if (senhaLogin != senhaCadastrada)
                    Console.WriteLine("Erro: Senha incorreta.");

                Console.WriteLine("\nPressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
            }
        }

        // ========================== FINAL APÓS LOGIN ==========================

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
