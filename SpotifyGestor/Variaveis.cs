using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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



        public static void WriteJSON(string path)
        {
            //Ficheiro JSON das Contas
            string finalPath = Path.Combine(path, "Contas.json");
            string jsonString = JsonConvert.SerializeObject(Contas, Formatting.Indented);
            File.WriteAllText(finalPath, jsonString);

            //Ficheiro JSON dos Artistas
            finalPath = Path.Combine(path, "Artistas.json");
            jsonString = JsonConvert.SerializeObject(Artistas, Formatting.Indented);
            File.WriteAllText(finalPath, jsonString);

            //Ficheiro JSON das Musicas
            finalPath = Path.Combine(path, "Musicas.json");
            jsonString = JsonConvert.SerializeObject(Musicas, Formatting.Indented);
            File.WriteAllText(finalPath, jsonString);

            //Ficheiro JSON das Playlists
            finalPath = Path.Combine(path, "Playlists.json");
            jsonString = JsonConvert.SerializeObject(Playlist, Formatting.Indented);
            File.WriteAllText(finalPath, jsonString);
        }


        public static List<Conta> Contas = new List<Conta>()
        {
            new Conta(0, "Rafael", "rafael@mail.com", "1234", true, new List<Playlist>()
            {
                
                //Variaveis.Playlist.FirstOrDefault(s => s.Nome == "Cor D'água")
            }),
            new Conta(1, "Gustavo", "gustavo@mail.com", "1234", true),

            new Conta(2, "Matheus Aguiar", "tuezinho@mail.com", "prima", false),
            new Conta(3, "Clériton Silva", "teto@mail.com", "parafal", false),
            new Conta(4, "Vinicius Lima", "wiu@mail.com", "parafal", false),

            new Conta(5, "JC", "JCarvalho@inete.net", "C4Life", true),
            new Conta(6, "JRC", "JCosta@inete.net", "SQL", true),

            new Conta(7, "Kanye Omari", "KanyeOmari@mail.com", "abc123", false),
            new Conta(8, "Marshall Mathers", "MarshallMathers@mail.com", "abc123", false)
        };
        public static List<Artista> Artistas = new List<Artista>()
        {
            new Artista(0, "Matuê", true, Contas.FirstOrDefault(s => s.Nome == "Matheus Aguiar")),
            new Artista(1, "Teto", true, Contas.FirstOrDefault(s => s.Nome == "Clériton Silva")),
            new Artista(2, "WIU", true, Contas.FirstOrDefault(s => s.Nome == "Vinicius Lima")),
            new Artista(3, "Kanye West", true, Contas.FirstOrDefault(s => s.Nome == "Kanye Omari")),
            new Artista(4, "Eminem", true, Contas.FirstOrDefault(s => s.Nome == "Marshall Mathers"))
        };

        public static List<Musica> Musicas = new List<Musica>()
        {
            new Musica(0, "Kenny G", 190, "Quer viver a minha vida? Faz cem mil sem esforço\r\nAhn, se eu quiser ela deixa eu pôr no osso\r\nSe meu som é uma droga, geral quer sentir o gosto", Variaveis.Artistas.FirstOrDefault(s => s.NomeArtistico == "Matuê")),
            new Musica(1, "PayPal", 165, "Quem é esse lebesquedo?\r\nQue eu não tô reconhecendo\r\nParecendo um flaiecstchuflaiol\r\n(What is his name?)", Variaveis.Artistas.FirstOrDefault(s => s.NomeArtistico == "Teto")),
            new Musica(3, "The Search", 200, "\"Hey, Nate, how's life?\"\r\nI don’t know, it's alright\r\nI've been dealin’ with some things like every human being\r\nAnd really didn't sleep much last night (Last night)\r\n\"I'm sorry,\" that's fine", Variaveis.Artistas.FirstOrDefault(s => s.NomeArtistico == "Teto")),
            new Musica(4, "Stronger", 210, "N-Now-Now that, that don't kill me\r\nCan only make me stronger\r\nI need you to hurry up now\r\n'Cause I can't wait much longer\r\nI know I got to be right now\r\n'Cause I can't get much wronger, ", Variaveis.Artistas.FirstOrDefault(s => s.NomeArtistico == "Kanye West")),
            new Musica(5, "Conexões de Máfia", 200, "Minha corrente e meu relógio têm branco e rosé\r\nTudo, um doce, uma bala de V\r\nEu não vim da roça, eu vou vingar os\r\nQue me vingaram, só pra fuder você (Oh)", Variaveis.Artistas.FirstOrDefault(s => s.NomeArtistico == "Matuê")),
            new Musica(6, "Rap God", 360, "'Cause I'm beginnin' to feel like a Rap God, Rap God\r\nAll my people from the front to the back nod, back nod\r\nNow, who thinks their arms are long enough to slap box, slap box?\r\nLet me show you maintainin' this shit ain't that hard, that hard\r\nEverybody want the key and the secret to rap immortality like Ι have got", Variaveis.Artistas.FirstOrDefault(s => s.NomeArtistico == "Eminem"))
        };
        public static List<Album> Albums = new List<Album>();
        public static List<Playlist> Playlist = new List<Playlist>()
        {
            new Playlist(0, "Cor D'água", new List<Musica>()
            {
                Variaveis.Musicas.FirstOrDefault(s => s.NomeMusica == "Kenny G"),
                Variaveis.Musicas.FirstOrDefault(s => s.NomeMusica == "Conexões de Máfia")
            }),
            new Playlist("A Great Chaos"),
            new Playlist("?"),
            new Playlist("Members Only"),
            new Playlist("Utopia"),
            new Playlist("Máquina do tempo"),
            new Playlist("Graduation"),
            new Playlist("Kamikaze"),
            new Playlist("Curtain Call 2")
        };
    }
}
