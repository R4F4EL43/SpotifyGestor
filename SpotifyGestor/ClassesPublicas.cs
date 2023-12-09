using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyGestor
{

    public class Conta
    {

        #region Construtor

        public Conta(int id, string nome, string email, string password, bool isAdmin)
        {
            this.IdConta = id;
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
            set
            {
                this._idConta = value;
            }
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
                    throw new ArgumentNullException("value");
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
                    throw new ArgumentNullException("value");
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
                    throw new ArgumentNullException("value");
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
                    throw new ArgumentOutOfRangeException("value");
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


        #endregion

    }


    public class Artista
    {

        #region Construtor

        public Artista(int idartista, string nomeArtistico, bool verificado, Conta conta)
        {
            IdArtista = idartista;
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
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                else this._idArtista = value;
            }
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
                    throw new ArgumentNullException("value");
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
                    throw new ArgumentNullException("value");
                else this._conta = value;
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


        #endregion


    }


    public class Musica
    {

        #region Construtor

        public Musica(int idMusica, string nomeMusica, int duracao, string letra, Artista artista)
        {
            this.IdMusica = idMusica;
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
            set
            {
                this._idMusica = value;
            }
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
                    throw new ArgumentNullException("value");
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
                    throw new ArgumentOutOfRangeException("value");
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
                    throw new ArgumentNullException("value");
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
                    throw new ArgumentNullException("value");
                else
                    this._artista = value;
            }
            get
            {
                return this._artista;
            }
        }


        #endregion

    }


    public class Album
    {
        #region Construtor

        public Album(int idAlbum, string nome, int duracao, string descricao, Artista artista)
        {
            IdAlbum = idAlbum;
            Nome = nome;
            Duracao = duracao;
            Descricao = descricao;
            Artista = artista;
            _musicas = new List<Musica>();
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
            set
            {
                this._idAlbum = value;
            }
            get
            {
                return this._idAlbum;
            }
        }

        public string Nome {
            set
            {
                if(value == null)
                    throw new ArgumentNullException("value");
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
                    throw new ArgumentOutOfRangeException("value");
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
                    throw new ArgumentNullException("value");
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
                    throw new ArgumentNullException("value");
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


        #endregion


    }


    public class Playlist
    {

        #region Construtor

        public Playlist(int id, string nome)
        {
            this.IdPlaylist = id;
            this.Nome = nome;
            this.Duracao = 0;
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
            set
            {
                this._idPlaylist = value;
            }
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
                    throw new ArgumentNullException("value");
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
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("value");
                else
                    this._duracao = value;
            }
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

        private void SetDuracao()
        {
            int tempo = 0;
            foreach(Musica a in _musicas)
            {
                tempo = a.Duracao;
            }
            this._duracao = tempo;
        }


        #endregion
    }

}
