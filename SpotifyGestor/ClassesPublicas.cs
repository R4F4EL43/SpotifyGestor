using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyGestor
{

    public class Conta
    {

        #region Construtor

        public Conta(string nome, string email, string password, bool isAdmin)
        {
            SetID();
            this.Nome = nome;
            this.Email = email; 
            this.Password = password;
            this._dataNasc = DateTime.Today;
            this.IsPremium = false;
            this.IsAdmin = isAdmin;
            this._playLists = new List<Playlist>();
        }


        #endregion



        #region Campos

        private int _idConta;
        private string _nome;
        private string _email;
        private string _password;
        private DateTime _dataNasc;
        private bool _isPremium;
        private bool _isAdmin;
        private List<Playlist> _playLists;


        #endregion



        #region Propriedades

        public int IdConta
        {
            get
            {
                return this._idConta;
            }
        }

        public string Nome
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Valor Inválido para Nome de Conta","Nome de Conta Inválido : " + value + " é null");
                else this._nome = value;
            }
            get
            {
                return this._nome;
            }
        }

        public string Email
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Valor Inválido para Email de Conta", "Email de Conta Inválido : " + value + " é null");
                else this._email = value;
            }
            get
            {
                return this._email;
            }
        }

        public string Password
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Valor Inválido para Password de Conta", "Password de Conta Inválido : " + value + " é null");
                else this._password = value;
            }
            get
            {
                return this._password;
            }
        }

        public bool IsPremium
        {
            set
            {
                this._isPremium = value;
            }
            get
            {
                return this._isPremium;
            }
        }

        public bool IsAdmin
        {
            set
            {
                this._isAdmin = value;
            }
            get
            {
                return this._isAdmin;
            }
        }

        public DateTime DataNasc
        {
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException("Valor Inválido para Data de Nascimento de Conta", "Data de Nascimento de Conta Inválido : " + value);
                else this._dataNasc = value;
            }
            get
            {
                return this._dataNasc;
            }
        }

        public List<Playlist> Playlists
        { 
            get
            {
                return this._playLists;
            }
        }


        #endregion



        #region Metodos

        public bool AddPlayList(Playlist playlist)
        {
            if(this._playLists.Contains(playlist))
                return false;

            this._playLists.Add(playlist);
            return true;
        }

        public bool DelPlayList(Playlist playlist)
        {
            if (!this._playLists.Contains(playlist))
                return false;

            this._playLists.Remove(playlist);
            return true;
        }

        private void SetID()
        {
            this._idConta = Variaveis.Contas.Count;
        }


        #endregion

    }


    public class Artista
    {

        #region Construtor

        public Artista(string nomeArtistico, bool verificado, Conta conta)
        {
            SetID();
            NomeArtistico = nomeArtistico;
            Verificado = verificado;
            Conta = conta;
            _albums = new List<Album>();
            _musicas = new List<Musica>();
        }


        #endregion



        #region Campos

        private int _idArtista;
        private string _nome;
        private string _nomeArtistico;
        private bool _verificado;
        private Conta _conta;
        private List<Album> _albums;
        private List<Musica> _musicas;


        #endregion



        #region Propriedades

        public int IdArtista
        {
            get
            {
                return this._idArtista;
            }
        }

        public string NomeArtistico
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Valor Inválido para Nome Artistico de Artista", "Nome Artistico de Artista Inválido : " + value + " é null");
                else this._nomeArtistico = value;
            }
            get
            {
                return this._nomeArtistico;
            }
        }

        public bool Verificado
        {
            set
            {
                this._verificado = value;
            }
            get
            {
                return this._verificado;
            }
        }

        public Conta Conta
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Valor Inválido para Conta de Artista", "Conta de Artista Inválido : " + value + " é null");
                else 
                    this._conta = value;
            }
            get
            {
                return this._conta;
            }
        }

        public List<Album> Albums
        {
            get
            {
                return this._albums;
            }
        }

        public List<Musica> Musicas
        {
            get
            {
                return this._musicas;
            }
        }


        #endregion



        #region Metodos

        public bool AddAlbum(Album album)
        {
            if(this._albums.Contains(album))
                return false;

            this._albums.Add(album);    
            return true;
        }

        public bool DelAlbum(Album album)
        {
            if (!this._albums.Contains(album))
                return false;

            this._albums.Remove(album);
            return true;
        }

        public bool AddMusica(Musica musica)
        {
            if (this._musicas.Contains(musica))
                return false;

            this._musicas.Remove(musica);
            return true;
        }

        public bool DelMusica(Musica musica)
        {
            if (!this._musicas.Contains(musica))
                return false;

            this._musicas.Remove(musica);
            return true;
        }

        private void SetID()
        {
            this._idArtista = Variaveis.Artistas.Count;
        }


        #endregion


    }


    public class Musica
    {

        #region Construtor

        public Musica(string nomeMusica, int duracao, string letra, Artista artista)
        {
            SetID();
            this.NomeMusica = nomeMusica;
            this.Duracao = duracao;
            this.Letra = letra;
            this.Artista = artista;
        }


        #endregion



        #region Campos

        private int _idMusica;
        private string _nomeMusica;
        private int _duracao;
        private string _letra;
        private Artista _artista;


        #endregion



        #region Propriedades

        public int IdMusica
        {
            get
            {
                return this._idMusica;
            }
        }

        public string NomeMusica
        {
            set
            {
                if(value == null)
                    throw new ArgumentNullException("Valor Inválido para Nome de Musica", "Nome de Musica Inválido : " + value + " é null");
                else
                    this._nomeMusica = value;
            }
            get
            {
                return this._nomeMusica;
            }
        }

        public int Duracao
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Valor Inválido para Duração de Musica", "Duração de Musica Inválido : " + value + " deve ser positivo");
                else
                    this._duracao = value;
            }
            get
            {
                return this._duracao;
            }
        }

        public string Letra
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Valor Inválido para Letra de Musica", "Letra de Musica Inválido : " + value + " é null");
                else
                    this._letra = value;
            }
            get
            {
                return this._letra;
            }
        }

        public Artista Artista
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Valor Inválido para Artista de Musica", "Artista de Musica Inválido : " + value + " é null");
                else
                    this._artista = value;
            }
            get
            {
                return this._artista;
            }
        }


        #endregion



        #region Metodos

        private void SetID()
        {
            this._idMusica = Variaveis.Musicas.Count;
        }


        #endregion


    }


    public class Album
    {
        #region Construtor

        public Album(string nome, Artista artista)
        {
            this.SetID();
            this.Nome = nome;
            this._duracao = 0;
            this._descricao = "";
            this.Artista = artista;
            this._musicas = new List<Musica>();
        }


        #endregion



        #region Campos

        private int _idAlbum;
        private string _nome;
        private int _duracao;
        private string _descricao;
        private Artista _artista;
        private List<Musica> _musicas;


        #endregion



        #region Propiedades

        public int IdAlbum {
            get
            {
                return this._idAlbum;
            }
        }

        public string Nome {
            set
            {
                if(value == null)
                    throw new ArgumentNullException("Valor Inválido para Nome de Album", "Nome de Album Inválido : " + value + " é null");
                else this._nome = value;
            }
            get
            {
                return this._nome;
            }            
        }

        public int Duracao {
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Valor Inválido para Duração de Album", "Duração de Album Inválido : " + value + " deve ser positivo");
                else this._duracao = value;
            }
            get
            {
                return this._duracao;
            }
        }

        public string Descricao {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Valor Inválido para Descricao de Album", "Descricao de Album Inválido : " + value + " é null"); 
                else this._descricao = value;
            }
            get
            {
                return this._descricao;
            }
        }

        public Artista Artista {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Valor Inválido para Artista de Album", "Artista de Album Inválido : " + value + " é null");
                else this._artista = value;
            }
            get
            {
                return this._artista;
            }
        }

        public List<Musica> Musicas {
            get
            {
                return this._musicas;
            }
        }


        #endregion



        #region Metodos

        public bool AddMusica(Musica musica)
        {
            if(_musicas.Contains(musica))
                return false;

            this._musicas.Add(musica);
            return true;
        }

        public bool DelMusica(Musica musica)
        {
            if (!_musicas.Contains(musica))
                return false;

            this._musicas.Remove(musica);
            return true;
        }

        public void SetDuracao()
        {
            this._duracao = 0;
            if (this.Musicas.Count == 0)
                return;

            foreach (Musica a in this.Musicas)
            {
                _duracao += a.Duracao;
            }
        }        

        private void SetID()
        {
            this._idAlbum = Variaveis.Albums.Count;
        }


        #endregion


    }


    public class Playlist
    {

        #region Construtor

        public Playlist(string nome)
        {
            SetID();
            this.Nome = nome;
            this._duracao = 0;
            this._musicas = new List<Musica>();
        }


        #endregion



        #region Campos

        private int _idPlaylist;
        private string _nome;
        private int _duracao;
        private List<Musica> _musicas;


        #endregion



        #region Propriedades

        public int IdPlaylist
        {
            get
            {
                return this._idPlaylist;
            }
        }

        public string Nome
        {
            set
            {
                if(value == null)
                    throw new ArgumentNullException("Valor Inválido para Nome de Playlist", "Nome de Playlist Inválido : " + value + " é null");
                else
                    this._nome = value;
            }
            get
            {
                return this._nome;
            }
        }

        public int Duracao
        {
            get
            {
                return this._duracao;
            }
        }

        public List<Musica> Musicas
        {
            get
            {
                return this._musicas;
            }
        }


        #endregion



        #region Metodos

        public bool AddMusica(Musica musica)
        {
            if (this._musicas.Contains(musica))
                return false;

            this._musicas.Add(musica);
            return true;
        }

        public bool DelMusica(Musica musica)
        {
            if (!this._musicas.Contains(musica))
                return false;

            this._musicas.Remove(musica);
            return true;
        }

        public void SetDuracao()
        {
            int tempo = 0;
            foreach(Musica a in _musicas)
            {
                tempo = a.Duracao;
            }
            this._duracao = tempo;
        }

        private void SetID()
        {
            this._idPlaylist = Variaveis.Albums.Count;
        }


        #endregion
    }

}
