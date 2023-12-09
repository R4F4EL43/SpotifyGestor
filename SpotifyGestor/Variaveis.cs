using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpotifyGestor
{
    public static class Variaveis
    {

        public static Regex Email = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,3}$");
        /*
        Começar por Letras (min ou maiu) ou Digitos ou pelos caracteres ('._%+-')
        Seguido de 1 @
        Seguido de Letras (min ou maiu) ou Digitos ou pelos caracteres ('.,-')
        Finalizando com 2 ou 3 Letras (min ou maiu)
        */



        public static Regex Password = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
        /*
        Pelo menos 8 caracteres                 {8,}
        Tem pelo menos 1 letra maiuscula        (?=.*?[A-Z])
        Tem pelo menos 1 letra minuscula        (?=.*?[a-z])
        Tem pelo menos 1 digito                 (?=.*?[0-9])
        Tem pelo menos 1 caracter especial      (?=.*?[#?!@$%^&*-])
        */



        public static Regex User = new Regex(@"[A-Za-z0-9]{8,}$");
        /*
        Pelo menos 8 caracteres                 {8,}
        Pode ter digitos                        0-9
        Pode ter letras maiusculas              A-Z
        Pode ter letras minusculas              a-z
        */



        public static void WriteJSON()
        {

        }


        public static List<Conta> Contas = new List<Conta>()
        {
            new Conta(0, "Rafael", "rafael@mail.com", "1234", true),
            new Conta(1, "Gustavo", "gustavo@mail.com", "1234", true),

            new Conta(2, "Matheus Aguiar", "tuezinho@mail.com", "prima", false),
            new Conta(3, "Clériton Silva", "teto@mail.com", "parafal", false),
            new Conta(4, "Vinicius Lima", "wiu@mail.com", "parafal", false)
        };
        public static List<Artista> Artistas = new List<Artista>()
        {
            new Artista(0, "Matuê", true, Contas.FirstOrDefault(s => s.Nome == "Matheus Aguiar")),
            new Artista(1, "Teto", true, Contas.FirstOrDefault(s => s.Nome == "Clériton Silva")),
            new Artista(2, "WIU", true, Contas.FirstOrDefault(s => s.Nome == "Vinicius Lima"))
        };

        public static List<Musica> Musicas = new List<Musica>()
        {
            new Musica(0, "Kenny G", 190, "Quer viver a minha vida? Faz cem mil sem esforço\r\nAhn, se eu quiser ela deixa eu pôr no osso\r\nSe meu som é uma droga, geral quer sentir o gosto", Variaveis.Artistas.FirstOrDefault(s => s.NomeArtistico == "Matuê")),
            new Musica(1, "PayPal", 165, "Quem é esse lebesquedo?\r\nQue eu não tô reconhecendo\r\nParecendo um flaiecstchuflaiol\r\n(What is his name?)", Variaveis.Artistas.FirstOrDefault(s => s.NomeArtistico == "Teto")),
            new Musica(3, "The Search", 200, "\"Hey, Nate, how's life?\"\r\nI don’t know, it's alright\r\nI've been dealin’ with some things like every human being\r\nAnd really didn't sleep much last night (Last night)\r\n\"I'm sorry,\" that's fine", Variaveis.Artistas.FirstOrDefault(s => s.NomeArtistico == "Teto"))
        };
        public static List<Album> Albums = new List<Album>();
        public static List<Playlist> Playlist = new List<Playlist>()
        {
            new Playlist("Cor D'água"),
            new Playlist("A Great Chaos"),
            new Playlist("?"),
            new Playlist("Members Only"),
            new Playlist("Utopia"),
        };
    }
}
