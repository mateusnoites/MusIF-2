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
          case 'B' : case 'b' : MenuAtualizar(); break;
          case 'C' : case 'c' : PlaylistExcluir(); break;
          case 'D' : case 'd' : PlaylistListar(); break;
          case 'X' : case 'x' : Finalizar(); break;
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
    Visuals.Esquerda("X - Finalizar o MusIF");
    Visuals.Finalizacao();
    
    Visuals.Resposta();
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
  public static void MenuAtualizar() {
    Visuals.CaixaCabecalho();
    Console.WriteLine();
    Visuals.CaixaTituloLonga("Editar uma Playlist");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
      Visuals.Finalizacao();
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
      Visuals.LinhaDivisoria();
      Visuals.Centralizar("Qual é o ID da Playlist a ser editada?");
      Visuals.Finalizacao();
      Visuals.Resposta();

      int id = int.Parse(Console.ReadLine());

      // Nome
      Visuals.CaixaCabecalho();
      Console.WriteLine();
      Visuals.CaixaTituloLonga("Editar uma Playlist");
      Visuals.Centralizar("Lista das Playlists criadas");
      Visuals.LinhaVazia();
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
      Visuals.LinhaDivisoria();
      Visuals.Centralizar($"Qual será o novo nome da Playlist {id}?");
      Visuals.Finalizacao();
      Visuals.Resposta();
      string nome = Console.ReadLine();

      // Instanciar a classe Playlist
      Playlist objeto = new Playlist(id, nome);
      // Atualizar a playlist no sistema
      Sistema.PlaylistAtualizar(objeto);

      Visuals.CaixaCabecalho();
      Visuals.CaixaTituloCurta("Edições salvas.");
    }
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