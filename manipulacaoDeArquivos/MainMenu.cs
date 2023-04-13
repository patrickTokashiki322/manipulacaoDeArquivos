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

            Console.WriteLine($@"Digite a opção desejada:
1 - Informar um diretório
2 - Criar diretório
3 - Copiar arquivo
4 - Excluir diretório
5 - Excluir arquivo");

            fileManager.Operation(Console.ReadLine());
        }

        public void Back()
        {
            MainMenu mainMenu = new MainMenu();
            
            mainMenu.Menu();
        }
    }
}
