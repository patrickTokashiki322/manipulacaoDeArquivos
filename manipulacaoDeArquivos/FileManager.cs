using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulacaoDeArquivos
{
    public class FileManager
    {
        MainMenu mainMenu = new MainMenu();

        public void Operate(string path)
        {
            Console.WriteLine("");

            if (path == "1")
            {
                Console.WriteLine("Você quer 'Informar um diretório.'");
                Console.WriteLine("Informe um caminho absoluto:");

                SetDirectory(Console.ReadLine());
            } 
            else if (path == "2")
            {
                Console.WriteLine("Você quer 'Criar um diretório.'");
                Console.WriteLine("Informe o nome do diretório:");

                CreateDirectory(Console.ReadLine());
            }
            else if (path == "3")
            {
                Console.WriteLine("Você quer 'Copiar um arquivo.'");
                Console.WriteLine("Informe o caminho absoluto do arquivo de origem:");

                CopyFile();
            }
            else if (path == "4")
            {
                Console.WriteLine("Você quer 'Excluir um diretório.'");
                Console.WriteLine("Informe o caminho absoluto do diretório a ser excluído:");

                DeleteDirectory();
            }
            else if (path == "5")
            {
                Console.WriteLine("Você quer 'Excluir um arquivo.'");
                Console.WriteLine("Informe o caminho absoluto do arquivo com a extensão:");

                DeleteFile(Console.ReadLine());
            }
            else if (path == "6")
            {
                Console.WriteLine("Você quer 'Ler um arquivo JSON.'");
                Console.WriteLine("Informe o caminho absoluto do arquivo:");

                ReadJsonFile();
            }
            else if (path == "0")
            {
                mainMenu.ExitApplication();
            }
            else
            {
                Console.WriteLine("Informe uma opção válida!");

                Operate(Console.ReadLine());
            }
        }

        public void SetDirectory(string path)
        {
            Directory.SetCurrentDirectory(path);

            string currentDirectory = Directory.GetCurrentDirectory();

            Console.WriteLine("");
            Console.WriteLine($"Estamos no diretório: ${currentDirectory}");

            mainMenu.setNewDirectory();
        }

        public void CreateDirectory(string path)
        {            
            bool existDirectory = Directory.Exists(path);

            if (existDirectory)
            {
                Console.WriteLine("");
                Console.WriteLine("O diretório já existe no caminho especificado.");

                mainMenu.ExistDirectory();
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), path));

                Console.WriteLine("");
                Console.WriteLine("O diretório foi criado com sucesso!");
            }

            mainMenu.createNewDirectory();
        }

        public void CopyFile()
        {
            string file1 = Console.ReadLine();

            Console.WriteLine("Informe o nome do arquivo copiado com a extensão:");

            string fileName = Console.ReadLine();

            CopyFileToDirectory(file1, fileName);

            bool existFile = File.Exists(fileName);

            if (existFile)
            {
                Console.WriteLine("");
                Console.WriteLine("O arquivo foi copiado com sucesso!");
            }

            mainMenu.copyNewFile();
        }

        private void CopyFileToDirectory(string originFilePath, string fileName)
        {
            File.Copy(originFilePath, fileName);
        }

        public void DeleteDirectory()
        {

            string path = Console.ReadLine();

            Console.WriteLine("Gostaria de deletar todos os arquivos presentes no diretório?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            string deleteAllFilesInDirectory = Console.ReadLine();

            if (deleteAllFilesInDirectory == "1")
            {
                Directory.Delete(path, true);
            }
            else if (deleteAllFilesInDirectory == "2")
            {
                Directory.Delete(path);
            }

            mainMenu.deleteOtherDitectory();
        }

        public void DeleteFile(string path)
        {
            File.Delete(path);

            mainMenu.deleteOtherFile();
        }

        public void ReadJsonFile()
        {
            string jsonPath = Console.ReadLine();
            string readJson = File.ReadAllText(jsonPath);

            Console.WriteLine("");
            Console.WriteLine(JsonConvert.DeserializeObject(readJson));
            Console.WriteLine("");

            mainMenu.readOtherJsonFile();
        }
    }
}
