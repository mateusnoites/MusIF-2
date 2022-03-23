using System;

class Program {
  public static void Main() {
    Console.WriteLine("Bem-vindo ao MusIF.");
    Playlist p1 = new Playlist(1, "so as brabas");
    Musica m1 = new Musica(1, "A história de Jhonny", "kamaitachi", 2021, DateTime.Parse("0:6:00"), 1);
    Console.WriteLine(p1);
    Console.WriteLine(m1);
  }
}