using System;

public class Visuals {
  public static void Cabecalho() {
    Console.Clear();
    LinhaInicial();
    Console.WriteLine("║             𝄞 ⓜ  ⓤ  ⓢ  ⓘ  ⓕ  𝄞              ║");
    LinhaDivisoria();
  }

  public static void CaixaCabecalho() {
    Console.Clear();
    Console.WriteLine("╔═════════════════════════════════════════════╗");
    Console.WriteLine("║             𝄞 ⓜ  ⓤ  ⓢ  ⓘ  ⓕ  𝄞              ║");
    Finalizacao();
  }

  public static void LinhaInicial() {
    Console.WriteLine("╔═════════════════════════════════════════════╗");
  }
  
  public static void LinhaDivisoria() {
    Console.WriteLine("╠═════════════════════════════════════════════╣");
  }

  public static void Finalizacao() {
    Console.WriteLine("╚═════════════════════════════════════════════╝");
  }

  public static void LinhaVazia() {
    string textoFinal = "";

    textoFinal += "║";
    
    for (int i = 0; i < Tamanho; i++) {
      textoFinal += " ";
    }

    textoFinal += "║";

    Console.WriteLine(textoFinal);
  }

  public static void Resposta() {
    Console.WriteLine();
    Console.Write(" 👉 ");
  }

  public static void Centralizar(string texto) {
    string textoFinal = "";

    int tamanhoJanela = Tamanho;
    
    int esquerda;
    int direita;
    int tamanhoTexto = texto.Length;

    var janelaMenosTexto = tamanhoJanela - tamanhoTexto;
    var espaco = janelaMenosTexto / 2;

    if ((janelaMenosTexto % 2) != 0) {
      esquerda = (int)janelaMenosTexto / 2;
      direita = esquerda + 1;
    } else {
      esquerda = janelaMenosTexto / 2;
      direita = esquerda;
    }

    textoFinal += "║";

    for (int i = 0; i < esquerda; i++) {
      textoFinal += " ";
    }
    
    textoFinal += texto;

    for (int i = 0; i < direita; i++) {
      textoFinal += " ";
    }

    textoFinal += "║";

    Console.WriteLine(textoFinal);
  }

  public static void Esquerda(string texto) {
    string textoFinal = "";

    int tamanhoJanela = Tamanho;

    int qttdEspacos = tamanhoJanela - 1 - texto.Length;

    textoFinal += "║ ";
    textoFinal += texto;

    for (int i = 0; i < qttdEspacos; i++) {
      textoFinal += " ";
    }

    textoFinal += "║";

    Console.WriteLine(textoFinal);
  }

  public static void Direita(string texto) {
    string textoFinal = "";

    int tamanhoJanela = Tamanho;

    int qttdEspacos = tamanhoJanela - 1 - texto.Length;

    textoFinal += "║";

    for (int i = 0; i < qttdEspacos; i++) {
      textoFinal += " ";
    }

    textoFinal += texto;

    textoFinal += " ║";

    Console.WriteLine(textoFinal);
  }

  public static void CentralizarSegundo(string texto) {
    string textoFinal = "";

    int tamanhoJanela = Tamanho;
    
    int esquerda;
    int direita;
    int tamanhoTexto = texto.Length;

    var janelaMenosTexto = tamanhoJanela - tamanhoTexto;
    var espaco = janelaMenosTexto / 2;

    if ((janelaMenosTexto % 2) != 0) {
      esquerda = (int)janelaMenosTexto / 2;
      direita = esquerda + 1;
    } else {
      esquerda = janelaMenosTexto / 2;
      direita = esquerda;
    }

    textoFinal += "║ ";

    for (int i = 0; i < esquerda; i++) {
      textoFinal += " ";
    }
    
    textoFinal += texto;

    for (int i = 0; i < direita; i++) {
      textoFinal += " ";
    }

    textoFinal += "║";

    Console.WriteLine(textoFinal);
  }

  public static void Titulo(string texto) {
    Centralizar(texto);
    LinhaDivisoria();
  }

  public static void CaixaTituloLonga(string texto) {
    string textoFinal = "𝄞 " + texto;
    LinhaInicial();
    CentralizarSegundo(textoFinal);
    LinhaDivisoria();
  }

  public static void CaixaTituloCurta(string texto) {
    LinhaInicial();
    string textoFinal = "𝄞 " + texto;
    CentralizarSegundo(textoFinal);
    Finalizacao();
  }

  public static int Tamanho = 45;
}