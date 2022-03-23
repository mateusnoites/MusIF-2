using System;

class Program {
  public static char op = ' ';

  public static void Main() {
    Console.WriteLine("Bem-vindo ao MusIF.");

    do {
      try{
        Program.op = MenuPrincipal();
        switch(Program.op) {
          case 'A' : case 'a' : PlaylistInserir(); break;
          case 'B' : case 'b' : PlaylistAtualizar(); break;
          case 'C' : case 'c' : PlaylistExcluir(); break;
          case 'D' : case 'd' : PlaylistListar(); break;
          case 'F' : case 'f' : Finalizar(); break;
        }
      } catch (Exception erro) {
        Program.op = 'Z'; // Colocar uma opção pra escolher se quer ou não continuar no aplicativo.
        Console.WriteLine("Erro: " +erro.Message);
      }
    } while (Program.op != ' ');
  }
  public static char MenuPrincipal() {
    Visuals.CaixaCabecalho();
    Console.WriteLine();
    Visuals.CaixaTituloLonga("Escolha uma opção.");
    Visuals.Esquerda("A - Adicionar uma nova Playlist");
    Visuals.Esquerda("B - Editar uma Playlist");
    Visuals.Esquerda("C - Apagar uma Playlist");
    Visuals.Esquerda("D - Listar as Playlists cadastradas");
    Visuals.LinhaDivisoria();
    Visuals.Esquerda("F - Finalizar o MusIF");
    Visuals.Finalizacao();
    
    /*Console.WriteLine("Escolha uma opção.");
    Console.WriteLine("A - Inserir uma nova Playlist.");
    Console.WriteLine("B - Listar as Playlists cadastradas.");
    Console.WriteLine("C - Atualizar uma playlist.");
    Console.WriteLine("D - Excluir uma playlist.");
    Console.WriteLine("F - Finalizar o sistema.");

    Console.Write("Opção: ");*/
    char op = char.Parse(Console.ReadLine());

    return op;
  }
  public static void PlaylistInserir() {
    Console.WriteLine("Inserir uma nova playlist.");
    // Dados da playlist
    Console.Write("Informe o ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe o Nome: ");
    string nome = Console.ReadLine();
    // Instanciar a classe Playlist
    Playlist obj = new Playlist(id, nome);
    // Inserir a playlist no sistema
    Sistema.PlaylistInserir(obj);
    Console.WriteLine("Playlist inserida.");
  }
  public static void PlaylistListar() {
    Console.WriteLine("Listar playlists.");

    foreach (Playlist obj in Sistema.PlaylistListar()) {
      Console.WriteLine(obj);
    }
  }
  public static void PlaylistAtualizar() {
    Console.WriteLine("Atualizar uma playlist.");
    // Dados da playlist
    Console.Write("Informe o ID da Playlist a ser atualizada: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe o novo Nome: ");
    string nome = Console.ReadLine();
    // Instanciar a classe Playlist
    Playlist obj = new Playlist(id, nome);
    // Atualizar a playlist no sistema
    Sistema.PlaylistAtualizar(obj);
    Console.WriteLine("Playlist atualizada.");
  }
  public static void PlaylistExcluir() {
    Console.WriteLine("Excluir uma playlist.");
    // Dados da playlist
    Console.Write("Informe o ID da Playlist a ser excluída: ");
    int id = int.Parse(Console.ReadLine());
    string nome = "";
    // Instanciar a classe Playlist
    Playlist obj = new Playlist(id, nome);
    // Atualizar a playlist no sistema
    Sistema.PlaylistExcluir(obj);
    Console.WriteLine("Playlist excluída.");
  }
  public static void Finalizar() {
    Visuals.Cabecalho();
    Visuals.Centralizar("Eu dei o meu melhor");
    Visuals.Centralizar("e ainda assim não");
    Visuals.Centralizar("consegui te agradar...");
    Visuals.LinhaVazia();
    Visuals.Centralizar("Adeus :(");
    Visuals.Finalizacao();
    Program.op = ' ';
  }
}