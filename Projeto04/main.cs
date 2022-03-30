using System;

class Program {
  public static char op = ' ';

  public static void Main() {

    try {
      Sistema.ArquivosAbrir();
    } catch (Exception erro) {
      Console.WriteLine(erro.Message);
    }
    Console.WriteLine("Boas vindas ao MusIF.");

    do {
      try {
        Program.op = MenuPrincipal();
        switch(Program.op) {
          case 'A' : case 'a' : MenuPlaylists(); break;
          case 'B' : case 'b' : MenuMusicas(); break;
          case 'C' : case 'c' : MenuClientes(); break;
          case 'X' : case 'x' : Finalizar(); break;
        }
      } catch (Exception erro) {
        Program.op = 'ç'; // Colocar uma opção pra escolher se quer ou não continuar no aplicativo.
        Console.WriteLine("Erro: " +erro.Message);
      }
    } while (Program.op != ' ');
    
    try {
      Sistema.ArquivosSalvar();
    } catch (Exception erro) {
      Console.WriteLine(erro.Message);
    }
  }

  public static char MenuPrincipal() {
    Visuals.Cabecalho();
    Visuals.Centralizar("Bem-vindo ao MusIF.");
    Visuals.Finalizacao();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Visualizar");

    Visuals.Esquerda("Ⓐ  │ Playlists");
    Visuals.Esquerda("Ⓑ  │ Músicas");
    Visuals.Esquerda("Ⓒ  │ Clientes");

    Visuals.Finalizacao();

    Visuals.LinhaInicial();
    Visuals.Esquerda("Ⓧ  │ Fechar o MusIF");
    Visuals.Finalizacao();

    Visuals.Resposta();
    
    char op = char.Parse(Console.ReadLine());
    
    return op;
  }
  
  public static void MenuPlaylists() {
    Visuals.CaixaCabecalho();
    Console.WriteLine();
    Visuals.CaixaTituloLonga("Playlists");
    Visuals.Esquerda("Ⓐ  │ Adicionar uma nova Playlist");
    Visuals.Esquerda("Ⓑ  │ Editar uma Playlist");
    Visuals.Esquerda("Ⓒ  │ Apagar uma Playlist");
    Visuals.Esquerda("Ⓓ  │ Listar as Playlists cadastradas");
    Visuals.Finalizacao();

    NavBar();
    
    Visuals.Resposta();
    char resposta = char.Parse(Console.ReadLine());

    switch(resposta) {
      case 'A' : case 'a' : PlaylistInserir(); break;
      case 'B' : case 'b' : PlaylistAtualizar(); break;
      case 'C' : case 'c' : PlaylistExcluir(); break;
      case 'D' : case 'd' : PlaylistListar(); break;
      case 'Z' : case 'z' : Program.op = 'L'; break;
      case 'X' : case 'x' : Finalizar(); break;
      case 'V' : case 'v' : Program.op = 'L'; break;
    }
  }

  public static void MenuMusicas() {
    Visuals.CaixaCabecalho();
    Console.WriteLine();
    Visuals.CaixaTituloLonga("Músicas");
    Visuals.Esquerda("Ⓐ  │ Adicionar uma nova música");
    Visuals.Esquerda("Ⓑ  │ Editar uma música");
    Visuals.Esquerda("Ⓒ  │ Apagar uma música");
    Visuals.Esquerda("Ⓓ  │ Listar as músicas cadastradas");
    Visuals.Finalizacao();

    NavBar();
    
    Visuals.Resposta();
    char resposta = char.Parse(Console.ReadLine());

    switch(resposta) {
      case 'A' : case 'a' : MusicaInserir(); break;
      case 'B' : case 'b' : MusicaAtualizar(); break;
      case 'C' : case 'c' : MusicaExcluir(); break;
      case 'D' : case 'd' : MusicaListar(); break;
      case 'Z' : case 'z' : Program.op = 'L'; break;
      case 'X' : case 'x' : Finalizar(); break;
      case 'V' : case 'v' : Program.op = 'L'; break;
    }
  }

  public static void MenuClientes() {
    Visuals.CaixaCabecalho();
    Console.WriteLine();
    Visuals.CaixaTituloLonga("Playlists");
    Visuals.Esquerda("Ⓐ  │ Adicionar um novo cliente");
    Visuals.Esquerda("Ⓑ  │ Editar um cliente");
    Visuals.Esquerda("Ⓒ  │ Excluir um cliente");
    Visuals.Esquerda("Ⓓ  │ Listar os clientes cadastrados");
    Visuals.Finalizacao();

    NavBar();
    
    Visuals.Resposta();
    char resposta = char.Parse(Console.ReadLine());

    switch(resposta) {
      case 'A' : case 'a' : ClienteInserir(); break;
      case 'B' : case 'b' : ClienteAtualizar(); break;
      case 'C' : case 'c' : ClienteExcluir(); break;
      case 'D' : case 'd' : ClienteListar(); break;
      case 'Z' : case 'z' : Program.op = 'L'; break;
      case 'X' : case 'x' : Finalizar(); break;
      case 'V' : case 'v' : Program.op = 'L'; break;
    }
  }
  
  public static void PlaylistInserir() {
    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Adicionar uma Playlist");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o ID da Playlist a ser criada?");
    Visuals.Finalizacao();
    Visuals.Resposta();

    int id = int.Parse(Console.ReadLine());

    ///////////////////////////////

    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Adicionar uma Playlist");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o Nome da Playlist a ser criada?");
    Visuals.Finalizacao();
    Visuals.Resposta();
    
    string nome = Console.ReadLine();

    ///////////////////////////////////////
    
    Playlist objeto = new Playlist(id, nome);

    Sistema.PlaylistInserir(objeto);
    Program.op = 'L'; 
  }

  public static void PlaylistListar() {
    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Lista das Playlists criadas");

    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    Visuals.Finalizacao();

    NavBar();
    
    Visuals.Resposta();

    char resposta = char.Parse(Console.ReadLine());

    switch (resposta) {
      case 'Z' : case 'z' : Program.op = 'L'; break;
      case 'X' : case 'x': Finalizar(); break;
      case 'V' : case 'v' : MenuPlaylists(); break;
    }
  }
  public static void PlaylistAtualizar() {
    Visuals.CaixaCabecalho();
    Console.WriteLine();
    Visuals.CaixaTituloLonga("Editar uma Playlist");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
      Visuals.Finalizacao();

      NavBar();

      Visuals.Resposta();

      char resposta = char.Parse(Console.ReadLine());

      switch(resposta) {
        case 'Z' : case 'z' : Program.op = 'L'; break;
        case 'X' : case 'x' : Finalizar(); break;
        case 'V' : case 'v' : MenuPlaylists(); break;
      }
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
    Visuals.CaixaCabecalho();

    Visuals.CaixaTituloCurta("Excluir uma playlist");

    Console.WriteLine();
    Console.Write("Qual é o ID da playlist a ser excluída? 👉 ");
    int id = int.Parse(Console.ReadLine());
    string nome = "";
    // Instanciar a classe Playlist
    Playlist obj = new Playlist(id, nome);
    // Atualizar a playlist no sistema
    Sistema.PlaylistExcluir(obj);
    Console.WriteLine("Playlist excluída.");
  }

/////////////////////////////////////////////////////////
////////// PARTE DAS MUSICAS ////////////////////////////
/////////////////////////////////////////////////////////
  public static void MusicaInserir() {
    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Adicionar uma música");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o ID da música a ser criada?");
    Visuals.Finalizacao();
    Visuals.Resposta();

    int id = int.Parse(Console.ReadLine());

    ///////////////////////////////

    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Adicionar uma música");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o Nome da música a ser criada?");
    Visuals.Finalizacao();
    Visuals.Resposta();
    
    string nome = Console.ReadLine();

    ////////////////////////////

    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Adicionar uma música");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é a duração da música a ser criada?");
    Visuals.Finalizacao();
    Visuals.Resposta();

    DateTime duracao = DateTime.Parse(Console.ReadLine());

    //////////////////////////////////

    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Adicionar uma música");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o ID da playlist?");
    Visuals.Finalizacao();
    Visuals.Resposta();

    int idPlaylist = int.Parse(Console.ReadLine());

    /////////////////////////////////////

    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Adicionar uma música");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o ID do cliente?");
    Visuals.Finalizacao();
    Visuals.Resposta();

    int idCliente = int.Parse(Console.ReadLine());

    /////////////////////////////////////
    
    Musica objeto = new Musica(id, nome, duracao, idPlaylist, idCliente);

    Sistema.MusicaInserir(objeto);
    Program.op = 'L'; 
  }

  public static void MusicaListar() {
    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Lista das músicas cadastradas");

    foreach (Musica obj in Sistema.MusicaListar()) {
      Playlist p = Sistema.PlaylistListar(obj.GetIdPlaylist());
      Cliente c = Sistema.ClienteListar(obj.GetIdCliente());
      Visuals.Esquerda(Convert.ToString(obj + " - " + p.GetNome()));
    }
    Visuals.Finalizacao();

    NavBar();
    
    Visuals.Resposta();

    char resposta = char.Parse(Console.ReadLine());

    switch (resposta) {
      case 'Z' : case 'z' : Program.op = 'L'; break;
      case 'X' : case 'x': Finalizar(); break;
      case 'V' : case 'v' : MenuPlaylists(); break;
    }
  }
  public static void MusicaAtualizar() {
    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Editar uma música");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o ID da música a ser editada?");
    Visuals.Finalizacao();
    Visuals.Resposta();

    int id = int.Parse(Console.ReadLine());

    ///////////////////////////////

    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Editar uma música");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o novo Nome da música?");
    Visuals.Finalizacao();
    Visuals.Resposta();
    
    string nome = Console.ReadLine();

    ////////////////////////////

    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Adicionar uma música");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é a nova duração da música?");
    Visuals.Finalizacao();
    Visuals.Resposta();

    DateTime duracao = DateTime.Parse(Console.ReadLine());

    //////////////////////////////////

    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Adicionar uma música");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o novo ID da playlist?");
    Visuals.Finalizacao();
    Visuals.Resposta();

    int idPlaylist = int.Parse(Console.ReadLine());

    /////////////////////////////////////

    int idCliente = 0;
    
    Musica objeto = new Musica(id, nome, duracao, idPlaylist, idCliente);

    Sistema.MusicaAtualizar(objeto);
  }
  public static void MusicaExcluir() {
    Visuals.CaixaCabecalho();

    Visuals.CaixaTituloCurta("Excluir uma música");

    Console.WriteLine();
    Console.Write("Qual é o ID da música a ser excluída? 👉 ");
    int id = int.Parse(Console.ReadLine());
    // Instanciar a classe Musica
    Musica obj = new Musica(id);
    // Excluir a música do sistema
    Sistema.MusicaExcluir(obj);
    Console.WriteLine("Playlist excluída.");
  }

/////////////////////////////////////////////////////////
////////// PARTE DOS CLIENTES ////////////////////////////
/////////////////////////////////////////////////////////
  public static void ClienteInserir() {

    ///////////////////////////////

    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Adicionar um cliente");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o Nome do cliente a ser criado?");
    Visuals.Finalizacao();
    Visuals.Resposta();
    
    string nome = Console.ReadLine();

    /////////////////////////////////////

    int idCliente = 0;

    Cliente objeto = new Cliente { nome = nome };

    Sistema.ClienteInserir(objeto);
    Program.op = 'L'; 
  }

  public static void ClienteListar() {
    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Lista dos clientes cadastrados");

    foreach (Cliente obj in Sistema.ClienteListar()) {
      Visuals.Esquerda(Convert.ToString(obj));
    }
    Visuals.Finalizacao();

    NavBar();
    
    Visuals.Resposta();

    char resposta = char.Parse(Console.ReadLine());

    switch (resposta) {
      case 'Z' : case 'z' : Program.op = 'L'; break;
      case 'X' : case 'x': Finalizar(); break;
      case 'V' : case 'v' : MenuPlaylists(); break;
    }
  }
  public static void ClienteAtualizar() {
    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Editar um cliente");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o ID do cliente a ser editado?");
    Visuals.Finalizacao();
    Visuals.Resposta();

    int id = int.Parse(Console.ReadLine());

    ///////////////////////////////

    Visuals.CaixaCabecalho();

    Console.WriteLine();

    Visuals.CaixaTituloLonga("Editar um cliente");
    Visuals.Centralizar("Lista das Playlists criadas");
    Visuals.LinhaVazia();
    if (Sistema.nPlaylist <= 0) {
      Visuals.Centralizar("Você ainda não criou nenhuma Playlist.");
    } else {
      foreach (Playlist obj in Sistema.PlaylistListar()) {
        Visuals.Esquerda(Convert.ToString(obj));
      }
    }
    
    Visuals.LinhaDivisoria();
    Visuals.Centralizar("Qual é o novo Nome do cliente?");
    Visuals.Finalizacao();
    Visuals.Resposta();
    
    string nome = Console.ReadLine();


    /////////////////////////////////////

    int idCliente = 0;
    
    Cliente objeto = new Cliente { id = id, nome = nome };

    Sistema.ClienteAtualizar(objeto);
  }
  public static void ClienteExcluir() {
    Visuals.CaixaCabecalho();

    Visuals.CaixaTituloCurta("Excluir um cliente");

    Console.WriteLine();
    Console.Write("Qual é o ID do cliente a ser excluído? 👉 ");
    int id = int.Parse(Console.ReadLine());
    // Instanciar a classe Musica
    Cliente obj = new Cliente { id = id };
    // Excluir a música do sistema
    Sistema.ClienteExcluir(obj);
    Console.WriteLine("Cliente excluído.");
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

  public static void NavBar() {
    Visuals.LinhaInicial();
    Visuals.Esquerda("Ⓩ  │ Início");
    Visuals.Esquerda("Ⓧ  │ Fechar o MusIF");
    Visuals.Esquerda("Ⓥ  │ Voltar");
    Visuals.Finalizacao();
  }
}