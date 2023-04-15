using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulacaoDeArquivos
{
    internal class MainMenu
    {
        public void Menu()
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine($@"----------------------------------
          Menu principal          
----------------------------------

Digite a opção desejada:
1 - Informar um diretório
2 - Criar diretório
3 - Copiar arquivo
4 - Excluir diretório
5 - Excluir arquivo
6 - Ler aquivo JSON
0 - Sair");

            fileManager.Operate(Console.ReadLine());
        }

        private void Back()
        {
            MainMenu mainMenu = new MainMenu();
            
            mainMenu.Menu();
        }

        public void ExitApplication()
        {
            Environment.Exit(0);
        }

        public void ExistDirectory()
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine("Gostaria de criar um diretório com um nome diferente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            string operation = Console.ReadLine();

            if (operation == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe o nome do diretório a ser criado:");
                fileManager.CreateDirectory(Console.ReadLine());
            }
            else if(operation == "2")
            {
                Console.WriteLine("");
                Back();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe uma opção válida!");

                ExistDirectory();
            }
        }

        public void setNewDirectory()
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine("Gostaria de informar um diretório diferente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            string operation = Console.ReadLine();

            if (operation == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe o caminho absoluto do novo diretório:");
                fileManager.SetDirectory(Console.ReadLine());
            }
            else if (operation == "2")
            {
                Console.WriteLine("");
                Back();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe uma opção válida!");

                setNewDirectory();
            }
        }

        public void infoDirectory()
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine("Você já informou um diretório?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            string operation = Console.ReadLine();

            if (operation == "1")
            {
                Console.WriteLine("");
            }
            else if (operation == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe o caminho absoluto do novo diretório:");
                fileManager.SetDirectory(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe uma opção válida!");

                setNewDirectory();
            }
        }

        public void copyNewFile()
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine("Gostaria de copiar ou outro arquivo?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            string operation = Console.ReadLine();

            if (operation == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe o caminho absoluto do arquivo:");
                fileManager.CopyFile();
            }
            else if (operation == "2")
            {
                Console.WriteLine("");
                Back();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe uma opção válida!");

                copyNewFile();
            }
        }

        public void createNewDirectory()
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine("Gostaria de criar um novo outro diretório?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            string operation = Console.ReadLine();

            if (operation == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe o nome do diretório a ser criado:");
                fileManager.CreateDirectory(Console.ReadLine());
            }
            else if (operation == "2")
            {
                Console.WriteLine("");
                Back();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe uma opção válida!");

                createNewDirectory();
            }
        }

        public void deleteOtherDitectory()
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine("Gostaria de deletar um outro diretório?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            string operation = Console.ReadLine();

            if (operation == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe o caminho absoluto do diretório a ser deletado:");
                fileManager.DeleteDirectory();
            }
            else if (operation == "2")
            {
                Console.WriteLine("");
                Back();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe uma opção válida!");

                deleteOtherDitectory();
            }
        }

        public void deleteOtherFile()
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine("Gostaria de deletar um outro arquivo?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            string operation = Console.ReadLine();

            if (operation == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Informe o caminho absoluto do arquivo com a extensão:");
                fileManager.DeleteFile(Console.ReadLine());
            }
            else if (operation == "2")
            {
                Console.WriteLine("");
                Back();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe uma opção válida!");

                deleteOtherFile();
            }
        }

        public void readOtherJsonFile()
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine("Gostaria de ler um outro arquivo JSON?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            string operation = Console.ReadLine();

            if (operation == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Informe o caminho absoluto do arquivo:");
                fileManager.ReadJsonFile();
            }
            else if (operation == "2")
            {
                Console.WriteLine("");
                Back();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor, informe uma opção válida!");

                readOtherJsonFile();
            }
        }
    }
}
