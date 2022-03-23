using System;

class Musica {
  private int id;
  private string nome;
  private string artista;
  private int lancamento;
  private DateTime duracao;
  private int idPlaylist;
  
  public Musica(int id, string nome, string artista, int lancamento, DateTime duracao, int idPlaylist) {
    this.id = id;
    this.nome = nome;
    this.artista = artista;
    this.lancamento = lancamento;
    this.duracao = duracao;
    this.idPlaylist = idPlaylist;
  }
  public void SetID(int id) {
    this.id = id;
  }
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public void SetArtista(string artista) {
    this.artista = artista;
  }
  public void SetLancamento(int lancamento) {
    this.lancamento = lancamento;
  }
  public void SetDuracao(DateTime duracao) {
    this.duracao = duracao;
  }
  public void SetIdPlaylist(int idPlaylist) {
    this.idPlaylist = idPlaylist;
  }
  
  public int GetID() {
    return id;
  }
  public string GetNome() {
    return nome;
  }
  public string GetArtista() {
    return artista;
  }
  public int GetLancamento() {
    return lancamento;
  }
  public DateTime GetDuracao() {
    return duracao;
  }
  public int GetIdPlaylist() {
    return idPlaylist;
  }
  
  public override string ToString() {
    return $"{id} - {nome} - {artista} - {lancamento} - {duracao:mm:ss}";
  }
}