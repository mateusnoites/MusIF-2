using System;

public class Playlist {
  private int id;
  private string nome;
  public Playlist(int id, string nome) {
    this.id = id;
    this.nome = nome;
  }

  public Playlist() {
    
  }
  public void SetID(int id) {
    this.id = id;
  }
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public int GetID() {
    return id;
  }
  public string GetNome() {
    return nome;
  }
  public override string ToString() {
    return $"{id}  │ {nome}";
  }
}