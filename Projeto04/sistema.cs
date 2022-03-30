using System;
using System.Collections.Generic;
using System.Xml.Serialization; // A importação está funcionando
using System.IO;
using System.Text;

class Sistema {
  private static Playlist[] playlists = new Playlist[10];
  public static int nPlaylist;
  private static List<Musica> musicas = new List<Musica>();
  private static List<Cliente> clientes = new List<Cliente>();

  public static void ArquivosAbrir() {
    XmlSerializer xml = new XmlSerializer(typeof(Playlist[]));
    StreamReader f = new StreamReader("./playlists.xml", Encoding.Default);
    playlists = (Playlist[]) xml.Deserialize(f);
    nPlaylist = playlists.Length;
    f.Close();
  }

  public static void ArquivosSalvar() {
    XmlSerializer xml = new XmlSerializer(typeof(Playlist[]));
    StreamWriter f = new StreamWriter("./playlists.xml", false, Encoding.Default);
    xml.Serialize(f, PlaylistListar());
    f.Close();
  }

  public static void PlaylistInserir(Playlist obj) {
    // Verifica o tamanho do vetor

    if(nPlaylist == playlists.Length) 
      Array.Resize(ref playlists, 2 * playlists.Length);

    // Inserir o objeto  no vetor
    playlists[nPlaylist] = obj;

    // Incrementar o contador

    nPlaylist++;
  }
  public static Playlist[] PlaylistListar() {
    // Retornar os objetos cadastrados
    Playlist[] aux = new Playlist[nPlaylist];
    Array.Copy(playlists, aux, nPlaylist);

    return aux;
  }
  public static Playlist PlaylistListar(int id) {
    // Percorrer o vetor com as Playlists e retornar a playlist com o id informado.
    foreach (Playlist obj in playlists) 
      if (obj != null && obj.GetID() == id) return obj;
    return null;
  }
  public static void PlaylistAtualizar(Playlist obj) {
    // Localizar a playlist com o id informado
    Playlist aux = PlaylistListar(obj.GetID());

    // Atualiza o nome da playlist
    if (aux != null) {
      aux.SetNome(obj.GetNome());
    }
  }
  public static void PlaylistExcluir(Playlist obj) {
    // Localizar no vetor o índice do objeto
    int aux = PlaylistIndice(obj.GetID());
    // Remove a playlist se o índice foi encontrado
    if (aux != -1) {
      for (int i = aux; i < nPlaylist - 1; i++) {
        playlists[i] = playlists[i + 1];
      }
      // Decrementa o contador de playlists
      nPlaylist--;
    }
  }
  private static int PlaylistIndice(int id) {
    // Percorrer o vetor com as Playlists e retornar o índice do elemento com o id informado.
    for (int i = 0; i < nPlaylist; i++) {
      // Cada objeto Playlist no vetor
      Playlist obj = playlists[i];
      if(obj.GetID() == id) return i;
    }
    return -1;
  }

  public static void MusicaInserir(Musica obj) {
    // Insere o objeto na lista
    musicas.Add(obj);
  }
  public static List<Musica> MusicaListar() {
    return musicas;
  }

  public static List<Musica> MusicaListar(Cliente cliente) {
    // Retorna os objetos cadastrados para um cliente
    List<Musica> r = new List<Musica>();

    // Percorre o vetor das Músicas e retorna as músicas do cliente informado.
    foreach (Musica obj in musicas) 
      if (obj.GetIdCliente() == cliente.id) 
        r.Add(obj);
    
    return musicas;
  }
  
  public static Musica MusicaListar(int id) {
    // Percorre o vetor das Músicas e retorna a música com o ID informado.
    foreach (Musica obj in musicas) 
      if (obj.GetID() == id) return obj;
    return null;
  }
  public static void MusicaAtualizar(Musica obj) {
    // Localizar a música com o id informado
    Musica aux = MusicaListar(obj.GetID());

    // Atualiza os demais atributos da música
    if (aux != null) {
      aux.SetNome(obj.GetNome());
      aux.SetDuracao(obj.GetDuracao());
      aux.SetIdPlaylist(obj.GetIdPlaylist());
    }
  }
  public static void MusicaExcluir(Musica obj) {
    // Localizar o pet com o ID informado
    Musica aux = MusicaListar(obj.GetID());
    
    // Remove a música da lista
    if (aux != null) {
      musicas.Remove(aux);
    }
  }

/////////////////////////////////////////

  
  public static void ClienteInserir(Cliente obj) {
    // Calcular o ID do cliente a ser incluído
    int id = 0;

    foreach (Cliente aux in clientes) {
      if (aux.id > id) {
        id = aux.id;
      }
    }
    obj.id = id + 1;
    // Insere o objeto na lista
    clientes.Add(obj);
  }
  public static List<Cliente> ClienteListar() {
    return clientes;
  }
  public static Cliente ClienteListar(int id) {
    // Percorre o a lista de clientes e retorna o cliente com o ID informado.
    foreach (Cliente obj in clientes) 
      if (obj.id == id) return obj;
    return null;
  }
  public static void ClienteAtualizar(Cliente obj) {
    // Localizar o cliente com o id informado
    Cliente aux = ClienteListar(obj.id);

    // Atualiza as demais propriedades do cliente
    if (aux != null) {
      aux.nome = obj.nome;
    }
  }
  public static void ClienteExcluir(Cliente obj) {
    // Localizar o cliente com o ID informado
    Cliente aux = ClienteListar(obj.id);
    
    // Remove o cliente da lista
    if (aux != null) {
      clientes.Remove(aux);
    }
  }
}