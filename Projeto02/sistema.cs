using System;

class Sistema {
  private static Playlist[] playlists = new Playlist[10];
  private static int nPlaylist;

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
}