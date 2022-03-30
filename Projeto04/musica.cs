using System;

public class Musica {
  private int id;
  private string nome;
  private string artista;
  private int lancamento;
  private DateTime duracao;
  private int idPlaylist;
  private int idCliente;

  public Musica(int id) {
    this.id = id;
  }
  
  public Musica(int id, string nome, DateTime duracao, int idPlaylist, int idCliente) {
    this.id = id;
    this.nome = nome;
    this.duracao = duracao;
    this.idPlaylist = idPlaylist;
    this.idCliente = idCliente;
  }
  public Musica() {
    
  }
  public void SetID(int id) {
    this.id = id;
  }
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public void SetDuracao(DateTime duracao) {
    this.duracao = duracao;
  }
  public void SetIdPlaylist(int idPlaylist) {
    this.idPlaylist = idPlaylist;
  }

  public void SetIdCliente(int idCliente) {
    this.idCliente = idCliente;
  }
  
  public int GetID() {
    return id;
  }
  public string GetNome() {
    return nome;
  }
  public DateTime GetDuracao() {
    return duracao;
  }
  public int GetIdPlaylist() {
    return idPlaylist;
  }

  public int GetIdCliente() {
    return idCliente;
  }
  
  public override string ToString() {
    return $"{id}  │ {nome} - {duracao:mm:ss}";
  }
}