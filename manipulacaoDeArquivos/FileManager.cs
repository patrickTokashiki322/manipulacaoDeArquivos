using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulacaoDeArquivos
{
    public class FileManager
    {
        public void Operation(string path)
        {
            if (path == "1")
            {
                Console.WriteLine("Você quer 'Informar um diretório.'");
                Console.WriteLine("");
                Console.WriteLine("Informe um caminho absoluto:");

                SetDirectory(Console.ReadLine());
            } 
            else if (path == "2")
            {
                Console.WriteLine("Você quer 'Criar um diretório.'");
                Console.WriteLine("");
                Console.WriteLine("Informe o nome do diretório:");

                CreateDirectory(Console.ReadLine());
            }
            else if (path == "3")
            {
                Console.WriteLine("Você quer 'Copiar um arquivo.'");
            }
            else if (path == "4")
            {
                Console.WriteLine("Você quer 'Excluir um diretório.'");
            }
            else if (path == "5")
            {
                Console.WriteLine("Você quer 'Excluir um arquivo.'");
            }
            else
            {
                Console.WriteLine("Informe uma opção válida!");

                Operation(Console.ReadLine());
            }
        }

        public void SetDirectory(string path)
        {
            MainMenu mainMenu = new MainMenu();

            Directory.SetCurrentDirectory(path);

            string currentDirectory = Directory.GetCurrentDirectory();

            Console.WriteLine($"Estamos no diretório: ${currentDirectory}");
            Console.WriteLine("");
            Console.WriteLine("Digite 0 para voltar.");
            Console.WriteLine("");

            string operation = Console.ReadLine();

            if (operation == "0")
            {
                mainMenu.Back();
            }
            else
            {
                Console.WriteLine("Desculpe, digito inválido!");
                Console.WriteLine("");
                Console.WriteLine("Informe novamente o caminho desejado:");
                Console.WriteLine("");

                SetDirectory(Console.ReadLine());
            }

        }

        public void CreateDirectory(string path)
        {
            ///Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores","201","newDir"));

            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), path));

        }
    }
}
