#region Auto-generated classes for cashin database on 2014-11-04 19:24:38Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from cashin on 2014-11-04 19:24:38Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Reflection;
using DbLinq.Data.Linq;
using DbLinq.Vendor;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace CashIn
{
	public partial class CashinDB : DbLinq.MySql.MySqlDataContext
	{
        public CashinDB()
            : base(new MySqlConnection("server=localhost;uid=root;database=cashin"))
        {
        }

		public Table<Cidade> Cidades { get { return GetTable<Cidade>(); } }
		public Table<Cliente> Clientes { get { return GetTable<Cliente>(); } }
		public Table<Endereco> Enderecos { get { return GetTable<Endereco>(); } }
		public Table<Itensorcamento> Itensorcamento { get { return GetTable<Itensorcamento>(); } }
		public Table<Itenspadrao> Itenspadrao { get { return GetTable<Itenspadrao>(); } }
		public Table<Notas> Notas { get { return GetTable<Notas>(); } }
		public Table<Orcamento> Orcamentos { get { return GetTable<Orcamento>(); } }
		public Table<Pessoa> Pessoas { get { return GetTable<Pessoa>(); } }
		public Table<Pgtoprojeto> Pgtoprojeto { get { return GetTable<Pgtoprojeto>(); } }
		public Table<Projeto> Projetos { get { return GetTable<Projeto>(); } }
		public Table<Statustarefa> Statustarefa { get { return GetTable<Statustarefa>(); } }
		public Table<Tarefas> Tarefas { get { return GetTable<Tarefas>(); } }
		public Table<Uf> Uf { get { return GetTable<Uf>(); } }
		public Table<Usuario> Usuarios { get { return GetTable<Usuario>(); } }

	}

	[Table(Name = "cashin.cidade")]
	public partial class Cidade : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int IDCidade

		private int _idcIdade;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcIdade", Name = "idCidade", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDCidade
		{
			get
			{
				return _idcIdade;
			}
			set
			{
				if (value != _idcIdade)
				{
					_idcIdade = value;
					OnPropertyChanged("IDCidade");
				}
			}
		}

		#endregion

		#region string IDUf

		private string _iduF;
		[DebuggerNonUserCode]
		[Column(Storage = "_iduF", Name = "idUF", DbType = "char(2)")]
		public string IDUf
		{
			get
			{
				return _iduF;
			}
			set
			{
				if (value != _iduF)
				{
					_iduF = value;
					OnPropertyChanged("IDUf");
				}
			}
		}

		#endregion

		#region string Nome

		private string _nome;
		[DebuggerNonUserCode]
		[Column(Storage = "_nome", Name = "Nome", DbType = "varchar(100)")]
		public string Nome
		{
			get
			{
				return _nome;
			}
			set
			{
				if (value != _nome)
				{
					_nome = value;
					OnPropertyChanged("Nome");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Endereco> _endereco;
		[Association(Storage = "_endereco", OtherKey = "IDCidade", Name = "fk_Endereco_Cidade1")]
		[DebuggerNonUserCode]
		public EntitySet<Endereco> Endereco
		{
			get
			{
				return _endereco;
			}
			set
			{
				_endereco = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<Uf> _uf;
		[Association(Storage = "_uf", ThisKey = "IDUf", Name = "fk_Cidade_UF", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Uf Uf
		{
			get
			{
				return _uf.Entity;
			}
			set
			{
				if (value != _uf.Entity)
				{
					if (_uf.Entity != null)
					{
						var previousUf = _uf.Entity;
						_uf.Entity = null;
						previousUf.Cidade.Remove(this);
					}
					_uf.Entity = value;
					if (value != null)
					{
						value.Cidade.Add(this);
						_iduF = value.IDUf;
					}
					else
					{
						_iduF = null;
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void Endereco_Attach(Endereco entity)
		{
			entity.Cidade = this;
		}

		private void Endereco_Detach(Endereco entity)
		{
			entity.Cidade = null;
		}


		#endregion

		#region ctor

		public Cidade()
		{
			_endereco = new EntitySet<Endereco>(Endereco_Attach, Endereco_Detach);
			_uf = new EntityRef<Uf>();
		}

		#endregion

	}

	[Table(Name = "cashin.cliente")]
	public partial class Cliente : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Descricao

		private string _descricao;
		[DebuggerNonUserCode]
		[Column(Storage = "_descricao", Name = "descricao", DbType = "varchar(300)")]
		public string Descricao
		{
			get
			{
				return _descricao;
			}
			set
			{
				if (value != _descricao)
				{
					_descricao = value;
					OnPropertyChanged("Descricao");
				}
			}
		}

		#endregion

		#region int IDCliente

		private int _idcLiente;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcLiente", Name = "idCliente", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDCliente
		{
			get
			{
				return _idcLiente;
			}
			set
			{
				if (value != _idcLiente)
				{
					_idcLiente = value;
					OnPropertyChanged("IDCliente");
				}
			}
		}

		#endregion

		#region int? IDPessoa

		private int? _idpEssoa;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpEssoa", Name = "idPessoa", DbType = "int")]
		public int? IDPessoa
		{
			get
			{
				return _idpEssoa;
			}
			set
			{
				if (value != _idpEssoa)
				{
					_idpEssoa = value;
					OnPropertyChanged("IDPessoa");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Orcamento> _orcamento;
		[Association(Storage = "_orcamento", OtherKey = "IDCliente", Name = "fk_Orcamento_Cliente1")]
		[DebuggerNonUserCode]
		public EntitySet<Orcamento> Orcamento
		{
			get
			{
				return _orcamento;
			}
			set
			{
				_orcamento = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<Pessoa> _pessoa;
		[Association(Storage = "_pessoa", ThisKey = "IDPessoa", Name = "fk_Cliente_Pessoa1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Pessoa Pessoa
		{
			get
			{
				return _pessoa.Entity;
			}
			set
			{
				if (value != _pessoa.Entity)
				{
					if (_pessoa.Entity != null)
					{
						var previousPessoa = _pessoa.Entity;
						_pessoa.Entity = null;
						previousPessoa.Cliente.Remove(this);
					}
					_pessoa.Entity = value;
					if (value != null)
					{
						value.Cliente.Add(this);
						_idpEssoa = value.IDPessoa;
					}
					else
					{
						_idpEssoa = null;
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void Orcamento_Attach(Orcamento entity)
		{
			entity.Cliente = this;
		}

		private void Orcamento_Detach(Orcamento entity)
		{
			entity.Cliente = null;
		}


		#endregion

		#region ctor

		public Cliente()
		{
			_orcamento = new EntitySet<Orcamento>(Orcamento_Attach, Orcamento_Detach);
			_pessoa = new EntityRef<Pessoa>();
		}

		#endregion

	}

	[Table(Name = "cashin.endereco")]
	public partial class Endereco : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Bairro

		private string _bairro;
		[DebuggerNonUserCode]
		[Column(Storage = "_bairro", Name = "Bairro", DbType = "varchar(200)")]
		public string Bairro
		{
			get
			{
				return _bairro;
			}
			set
			{
				if (value != _bairro)
				{
					_bairro = value;
					OnPropertyChanged("Bairro");
				}
			}
		}

		#endregion

		#region int? IDCidade

		private int? _idcIdade;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcIdade", Name = "idCidade", DbType = "int")]
		public int? IDCidade
		{
			get
			{
				return _idcIdade;
			}
			set
			{
				if (value != _idcIdade)
				{
					_idcIdade = value;
					OnPropertyChanged("IDCidade");
				}
			}
		}

		#endregion

		#region int IDEndereco

		private int _ideNdereco;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideNdereco", Name = "idEndereco", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDEndereco
		{
			get
			{
				return _ideNdereco;
			}
			set
			{
				if (value != _ideNdereco)
				{
					_ideNdereco = value;
					OnPropertyChanged("IDEndereco");
				}
			}
		}

		#endregion

		#region int? IDPessoa

		private int? _idpEssoa;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpEssoa", Name = "idPessoa", DbType = "int")]
		public int? IDPessoa
		{
			get
			{
				return _idpEssoa;
			}
			set
			{
				if (value != _idpEssoa)
				{
					_idpEssoa = value;
					OnPropertyChanged("IDPessoa");
				}
			}
		}

		#endregion

		#region string Logradouro

		private string _logradouro;
		[DebuggerNonUserCode]
		[Column(Storage = "_logradouro", Name = "Logradouro", DbType = "varchar(200)")]
		public string Logradouro
		{
			get
			{
				return _logradouro;
			}
			set
			{
				if (value != _logradouro)
				{
					_logradouro = value;
					OnPropertyChanged("Logradouro");
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<Cidade> _cidade;
		[Association(Storage = "_cidade", ThisKey = "IDCidade", Name = "fk_Endereco_Cidade1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Cidade Cidade
		{
			get
			{
				return _cidade.Entity;
			}
			set
			{
				if (value != _cidade.Entity)
				{
					if (_cidade.Entity != null)
					{
						var previousCidade = _cidade.Entity;
						_cidade.Entity = null;
						previousCidade.Endereco.Remove(this);
					}
					_cidade.Entity = value;
					if (value != null)
					{
						value.Endereco.Add(this);
						_idcIdade = value.IDCidade;
					}
					else
					{
						_idcIdade = null;
					}
				}
			}
		}


		#endregion

		#region ctor

		public Endereco()
		{
			_cidade = new EntityRef<Cidade>();
		}

		#endregion

	}

	[Table(Name = "cashin.itensorcamento")]
	public partial class Itensorcamento : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Descricao

		private string _descricao;
		[DebuggerNonUserCode]
		[Column(Storage = "_descricao", Name = "descricao", DbType = "varchar(300)")]
		public string Descricao
		{
			get
			{
				return _descricao;
			}
			set
			{
				if (value != _descricao)
				{
					_descricao = value;
					OnPropertyChanged("Descricao");
				}
			}
		}

		#endregion

		#region int IditemOrcamento

		private int _iditemOrcamento;
		[DebuggerNonUserCode]
		[Column(Storage = "_iditemOrcamento", Name = "iditemOrcamento", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IditemOrcamento
		{
			get
			{
				return _iditemOrcamento;
			}
			set
			{
				if (value != _iditemOrcamento)
				{
					_iditemOrcamento = value;
					OnPropertyChanged("IditemOrcamento");
				}
			}
		}

		#endregion

		#region int? IDOrcamento

		private int? _idoRcamento;
		[DebuggerNonUserCode]
		[Column(Storage = "_idoRcamento", Name = "idOrcamento", DbType = "int")]
		public int? IDOrcamento
		{
			get
			{
				return _idoRcamento;
			}
			set
			{
				if (value != _idoRcamento)
				{
					_idoRcamento = value;
					OnPropertyChanged("IDOrcamento");
				}
			}
		}

		#endregion

		#region string Nome

		private string _nome;
		[DebuggerNonUserCode]
		[Column(Storage = "_nome", Name = "nome", DbType = "varchar(100)")]
		public string Nome
		{
			get
			{
				return _nome;
			}
			set
			{
				if (value != _nome)
				{
					_nome = value;
					OnPropertyChanged("Nome");
				}
			}
		}

		#endregion

		#region decimal? Valor

		private decimal? _valor;
		[DebuggerNonUserCode]
		[Column(Storage = "_valor", Name = "valor", DbType = "decimal")]
		public decimal? Valor
		{
			get
			{
				return _valor;
			}
			set
			{
				if (value != _valor)
				{
					_valor = value;
					OnPropertyChanged("Valor");
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<Orcamento> _orcamento;
		[Association(Storage = "_orcamento", ThisKey = "IDOrcamento", Name = "fk_itemsOrcamento_Orcamento1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Orcamento Orcamento
		{
			get
			{
				return _orcamento.Entity;
			}
			set
			{
				if (value != _orcamento.Entity)
				{
					if (_orcamento.Entity != null)
					{
						var previousOrcamento = _orcamento.Entity;
						_orcamento.Entity = null;
						previousOrcamento.Itensorcamento.Remove(this);
					}
					_orcamento.Entity = value;
					if (value != null)
					{
						value.Itensorcamento.Add(this);
						_idoRcamento = value.IDOrcamento;
					}
					else
					{
						_idoRcamento = null;
					}
				}
			}
		}


		#endregion

		#region ctor

		public Itensorcamento()
		{
			_orcamento = new EntityRef<Orcamento>();
		}

		#endregion

	}

	[Table(Name = "cashin.itenspadrao")]
	public partial class Itenspadrao : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Descricao

		private string _descricao;
		[DebuggerNonUserCode]
		[Column(Storage = "_descricao", Name = "descricao", DbType = "varchar(45)")]
		public string Descricao
		{
			get
			{
				return _descricao;
			}
			set
			{
				if (value != _descricao)
				{
					_descricao = value;
					OnPropertyChanged("Descricao");
				}
			}
		}

		#endregion

		#region int IditensPadrao

		private int _iditensPadrao;
		[DebuggerNonUserCode]
		[Column(Storage = "_iditensPadrao", Name = "iditensPadrao", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IditensPadrao
		{
			get
			{
				return _iditensPadrao;
			}
			set
			{
				if (value != _iditensPadrao)
				{
					_iditensPadrao = value;
					OnPropertyChanged("IditensPadrao");
				}
			}
		}

		#endregion

		#region int? IDUsuario

		private int? _iduSuario;
		[DebuggerNonUserCode]
		[Column(Storage = "_iduSuario", Name = "idUsuario", DbType = "int")]
		public int? IDUsuario
		{
			get
			{
				return _iduSuario;
			}
			set
			{
				if (value != _iduSuario)
				{
					_iduSuario = value;
					OnPropertyChanged("IDUsuario");
				}
			}
		}

		#endregion

		#region decimal? Valor

		private decimal? _valor;
		[DebuggerNonUserCode]
		[Column(Storage = "_valor", Name = "valor", DbType = "decimal")]
		public decimal? Valor
		{
			get
			{
				return _valor;
			}
			set
			{
				if (value != _valor)
				{
					_valor = value;
					OnPropertyChanged("Valor");
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<Usuario> _usuario;
		[Association(Storage = "_usuario", ThisKey = "IDUsuario", Name = "fk_itensPadrao_Usuario1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Usuario Usuario
		{
			get
			{
				return _usuario.Entity;
			}
			set
			{
				if (value != _usuario.Entity)
				{
					if (_usuario.Entity != null)
					{
						var previousUsuario = _usuario.Entity;
						_usuario.Entity = null;
						previousUsuario.Itenspadrao.Remove(this);
					}
					_usuario.Entity = value;
					if (value != null)
					{
						value.Itenspadrao.Add(this);
						_iduSuario = value.IDUsuario;
					}
					else
					{
						_iduSuario = null;
					}
				}
			}
		}


		#endregion

		#region ctor

		public Itenspadrao()
		{
			_usuario = new EntityRef<Usuario>();
		}

		#endregion

	}

	[Table(Name = "cashin.notas")]
	public partial class Notas : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region DateTime? Data

		private DateTime? _data;
		[DebuggerNonUserCode]
		[Column(Storage = "_data", Name = "data", DbType = "date")]
		public DateTime? Data
		{
			get
			{
				return _data;
			}
			set
			{
				if (value != _data)
				{
					_data = value;
					OnPropertyChanged("Data");
				}
			}
		}

		#endregion

		#region int IDNotas

		private int _idnOtas;
		[DebuggerNonUserCode]
		[Column(Storage = "_idnOtas", Name = "idNotas", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDNotas
		{
			get
			{
				return _idnOtas;
			}
			set
			{
				if (value != _idnOtas)
				{
					_idnOtas = value;
					OnPropertyChanged("IDNotas");
				}
			}
		}

		#endregion

		#region int? IDProjeto

		private int? _idpRojeto;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpRojeto", Name = "idProjeto", DbType = "int")]
		public int? IDProjeto
		{
			get
			{
				return _idpRojeto;
			}
			set
			{
				if (value != _idpRojeto)
				{
					_idpRojeto = value;
					OnPropertyChanged("IDProjeto");
				}
			}
		}

		#endregion

		#region decimal? Valor

		private decimal? _valor;
		[DebuggerNonUserCode]
		[Column(Storage = "_valor", Name = "valor", DbType = "decimal")]
		public decimal? Valor
		{
			get
			{
				return _valor;
			}
			set
			{
				if (value != _valor)
				{
					_valor = value;
					OnPropertyChanged("Valor");
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<Projeto> _projeto;
		[Association(Storage = "_projeto", ThisKey = "IDProjeto", Name = "fk_Notas_Projeto1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Projeto Projeto
		{
			get
			{
				return _projeto.Entity;
			}
			set
			{
				if (value != _projeto.Entity)
				{
					if (_projeto.Entity != null)
					{
						var previousProjeto = _projeto.Entity;
						_projeto.Entity = null;
						previousProjeto.Notas.Remove(this);
					}
					_projeto.Entity = value;
					if (value != null)
					{
						value.Notas.Add(this);
						_idpRojeto = value.IDProjeto;
					}
					else
					{
						_idpRojeto = null;
					}
				}
			}
		}


		#endregion

		#region ctor

		public Notas()
		{
			_projeto = new EntityRef<Projeto>();
		}

		#endregion

	}

	[Table(Name = "cashin.orcamento")]
	public partial class Orcamento : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region DateTime? Data

		private DateTime? _data;
		[DebuggerNonUserCode]
		[Column(Storage = "_data", Name = "data", DbType = "date")]
		public DateTime? Data
		{
			get
			{
				return _data;
			}
			set
			{
				if (value != _data)
				{
					_data = value;
					OnPropertyChanged("Data");
				}
			}
		}

		#endregion

		#region int? IDCliente

		private int? _idcLiente;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcLiente", Name = "idCliente", DbType = "int")]
		public int? IDCliente
		{
			get
			{
				return _idcLiente;
			}
			set
			{
				if (value != _idcLiente)
				{
					_idcLiente = value;
					OnPropertyChanged("IDCliente");
				}
			}
		}

		#endregion

		#region int IDOrcamento

		private int _idoRcamento;
		[DebuggerNonUserCode]
		[Column(Storage = "_idoRcamento", Name = "idOrcamento", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDOrcamento
		{
			get
			{
				return _idoRcamento;
			}
			set
			{
				if (value != _idoRcamento)
				{
					_idoRcamento = value;
					OnPropertyChanged("IDOrcamento");
				}
			}
		}

		#endregion

		#region int? IDUsuario

		private int? _iduSuario;
		[DebuggerNonUserCode]
		[Column(Storage = "_iduSuario", Name = "idUsuario", DbType = "int")]
		public int? IDUsuario
		{
			get
			{
				return _iduSuario;
			}
			set
			{
				if (value != _iduSuario)
				{
					_iduSuario = value;
					OnPropertyChanged("IDUsuario");
				}
			}
		}

		#endregion

		#region DateTime? Validade

		private DateTime? _validade;
		[DebuggerNonUserCode]
		[Column(Storage = "_validade", Name = "validade", DbType = "date")]
		public DateTime? Validade
		{
			get
			{
				return _validade;
			}
			set
			{
				if (value != _validade)
				{
					_validade = value;
					OnPropertyChanged("Validade");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Itensorcamento> _itensorcamento;
		[Association(Storage = "_itensorcamento", OtherKey = "IDOrcamento", Name = "fk_itemsOrcamento_Orcamento1")]
		[DebuggerNonUserCode]
		public EntitySet<Itensorcamento> Itensorcamento
		{
			get
			{
				return _itensorcamento;
			}
			set
			{
				_itensorcamento = value;
			}
		}

		private EntitySet<Projeto> _projeto;
		[Association(Storage = "_projeto", OtherKey = "IDOrcamento", Name = "fk_Projeto_Orcamento1")]
		[DebuggerNonUserCode]
		public EntitySet<Projeto> Projeto
		{
			get
			{
				return _projeto;
			}
			set
			{
				_projeto = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<Cliente> _cliente;
		[Association(Storage = "_cliente", ThisKey = "IDCliente", Name = "fk_Orcamento_Cliente1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Cliente Cliente
		{
			get
			{
				return _cliente.Entity;
			}
			set
			{
				if (value != _cliente.Entity)
				{
					if (_cliente.Entity != null)
					{
						var previousCliente = _cliente.Entity;
						_cliente.Entity = null;
						previousCliente.Orcamento.Remove(this);
					}
					_cliente.Entity = value;
					if (value != null)
					{
						value.Orcamento.Add(this);
						_idcLiente = value.IDCliente;
					}
					else
					{
						_idcLiente = null;
					}
				}
			}
		}

		private EntityRef<Usuario> _usuario;
		[Association(Storage = "_usuario", ThisKey = "IDUsuario", Name = "fk_Orcamento_Usuario1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Usuario Usuario
		{
			get
			{
				return _usuario.Entity;
			}
			set
			{
				if (value != _usuario.Entity)
				{
					if (_usuario.Entity != null)
					{
						var previousUsuario = _usuario.Entity;
						_usuario.Entity = null;
						previousUsuario.Orcamento.Remove(this);
					}
					_usuario.Entity = value;
					if (value != null)
					{
						value.Orcamento.Add(this);
						_iduSuario = value.IDUsuario;
					}
					else
					{
						_iduSuario = null;
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void Itensorcamento_Attach(Itensorcamento entity)
		{
			entity.Orcamento = this;
		}

		private void Itensorcamento_Detach(Itensorcamento entity)
		{
			entity.Orcamento = null;
		}

		private void Projeto_Attach(Projeto entity)
		{
			entity.Orcamento = this;
		}

		private void Projeto_Detach(Projeto entity)
		{
			entity.Orcamento = null;
		}


		#endregion

		#region ctor

		public Orcamento()
		{
			_itensorcamento = new EntitySet<Itensorcamento>(Itensorcamento_Attach, Itensorcamento_Detach);
			_projeto = new EntitySet<Projeto>(Projeto_Attach, Projeto_Detach);
			_cliente = new EntityRef<Cliente>();
			_usuario = new EntityRef<Usuario>();
		}

		#endregion

	}

	[Table(Name = "cashin.pessoa")]
	public partial class Pessoa : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Documento

		private string _documento;
		[DebuggerNonUserCode]
		[Column(Storage = "_documento", Name = "documento", DbType = "varchar(20)")]
		public string Documento
		{
			get
			{
				return _documento;
			}
			set
			{
				if (value != _documento)
				{
					_documento = value;
					OnPropertyChanged("Documento");
				}
			}
		}

		#endregion

		#region string Email

		private string _email;
		[DebuggerNonUserCode]
		[Column(Storage = "_email", Name = "email", DbType = "varchar(100)")]
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				if (value != _email)
				{
					_email = value;
					OnPropertyChanged("Email");
				}
			}
		}

		#endregion

		#region int IDPessoa

		private int _idpEssoa;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpEssoa", Name = "idPessoa", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDPessoa
		{
			get
			{
				return _idpEssoa;
			}
			set
			{
				if (value != _idpEssoa)
				{
					_idpEssoa = value;
					OnPropertyChanged("IDPessoa");
				}
			}
		}

		#endregion

		#region string Nome

		private string _nome;
		[DebuggerNonUserCode]
		[Column(Storage = "_nome", Name = "Nome", DbType = "varchar(200)")]
		public string Nome
		{
			get
			{
				return _nome;
			}
			set
			{
				if (value != _nome)
				{
					_nome = value;
					OnPropertyChanged("Nome");
				}
			}
		}

		#endregion

		#region DateTime? Nscto

		private DateTime? _nscto;
		[DebuggerNonUserCode]
		[Column(Storage = "_nscto", Name = "nscto", DbType = "date")]
		public DateTime? Nscto
		{
			get
			{
				return _nscto;
			}
			set
			{
				if (value != _nscto)
				{
					_nscto = value;
					OnPropertyChanged("Nscto");
				}
			}
		}

		#endregion

		#region string Sexo

		private string _sexo;
		[DebuggerNonUserCode]
		[Column(Storage = "_sexo", Name = "sexo", DbType = "char(1)")]
		public string Sexo
		{
			get
			{
				return _sexo;
			}
			set
			{
				if (value != _sexo)
				{
					_sexo = value;
					OnPropertyChanged("Sexo");
				}
			}
		}

		#endregion

		#region string Telefone

		private string _telefone;
		[DebuggerNonUserCode]
		[Column(Storage = "_telefone", Name = "telefone", DbType = "varchar(20)")]
		public string Telefone
		{
			get
			{
				return _telefone;
			}
			set
			{
				if (value != _telefone)
				{
					_telefone = value;
					OnPropertyChanged("Telefone");
				}
			}
		}

		#endregion

		#region string TipoPessoa

		private string _tipoPessoa;
		[DebuggerNonUserCode]
		[Column(Storage = "_tipoPessoa", Name = "tipoPessoa", DbType = "char(1)")]
		public string TipoPessoa
		{
			get
			{
				return _tipoPessoa;
			}
			set
			{
				if (value != _tipoPessoa)
				{
					_tipoPessoa = value;
					OnPropertyChanged("TipoPessoa");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Cliente> _cliente;
		[Association(Storage = "_cliente", OtherKey = "IDPessoa", Name = "fk_Cliente_Pessoa1")]
		[DebuggerNonUserCode]
		public EntitySet<Cliente> Cliente
		{
			get
			{
				return _cliente;
			}
			set
			{
				_cliente = value;
			}
		}

		private EntitySet<Usuario> _usuario;
		[Association(Storage = "_usuario", OtherKey = "IDPessoa", Name = "fk_Usuario_Pessoa1")]
		[DebuggerNonUserCode]
		public EntitySet<Usuario> Usuario
		{
			get
			{
				return _usuario;
			}
			set
			{
				_usuario = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void Cliente_Attach(Cliente entity)
		{
			entity.Pessoa = this;
		}

		private void Cliente_Detach(Cliente entity)
		{
			entity.Pessoa = null;
		}

		private void Usuario_Attach(Usuario entity)
		{
			entity.Pessoa = this;
		}

		private void Usuario_Detach(Usuario entity)
		{
			entity.Pessoa = null;
		}


		#endregion

		#region ctor

		public Pessoa()
		{
			_cliente = new EntitySet<Cliente>(Cliente_Attach, Cliente_Detach);
			_usuario = new EntitySet<Usuario>(Usuario_Attach, Usuario_Detach);
		}

		#endregion

	}

	[Table(Name = "cashin.pgtoprojeto")]
	public partial class Pgtoprojeto : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region DateTime? Data

		private DateTime? _data;
		[DebuggerNonUserCode]
		[Column(Storage = "_data", Name = "data", DbType = "date")]
		public DateTime? Data
		{
			get
			{
				return _data;
			}
			set
			{
				if (value != _data)
				{
					_data = value;
					OnPropertyChanged("Data");
				}
			}
		}

		#endregion

		#region int IDPgtoProjeto

		private int _idpGtoProjeto;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpGtoProjeto", Name = "idPgtoProjeto", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDPgtoProjeto
		{
			get
			{
				return _idpGtoProjeto;
			}
			set
			{
				if (value != _idpGtoProjeto)
				{
					_idpGtoProjeto = value;
					OnPropertyChanged("IDPgtoProjeto");
				}
			}
		}

		#endregion

		#region int IDProjeto

		private int _idpRojeto;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpRojeto", Name = "idProjeto", DbType = "int", CanBeNull = false)]
		public int IDProjeto
		{
			get
			{
				return _idpRojeto;
			}
			set
			{
				if (value != _idpRojeto)
				{
					_idpRojeto = value;
					OnPropertyChanged("IDProjeto");
				}
			}
		}

		#endregion

		#region string Recibo

		private string _recibo;
		[DebuggerNonUserCode]
		[Column(Storage = "_recibo", Name = "recibo", DbType = "varchar(300)")]
		public string Recibo
		{
			get
			{
				return _recibo;
			}
			set
			{
				if (value != _recibo)
				{
					_recibo = value;
					OnPropertyChanged("Recibo");
				}
			}
		}

		#endregion

		#region decimal? Valor

		private decimal? _valor;
		[DebuggerNonUserCode]
		[Column(Storage = "_valor", Name = "valor", DbType = "decimal")]
		public decimal? Valor
		{
			get
			{
				return _valor;
			}
			set
			{
				if (value != _valor)
				{
					_valor = value;
					OnPropertyChanged("Valor");
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<Projeto> _projeto;
		[Association(Storage = "_projeto", ThisKey = "IDProjeto", Name = "fk_PgtoProjeto_Projeto1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Projeto Projeto
		{
			get
			{
				return _projeto.Entity;
			}
			set
			{
				if (value != _projeto.Entity)
				{
					if (_projeto.Entity != null)
					{
						var previousProjeto = _projeto.Entity;
						_projeto.Entity = null;
						previousProjeto.Pgtoprojeto.Remove(this);
					}
					_projeto.Entity = value;
					if (value != null)
					{
						value.Pgtoprojeto.Add(this);
						_idpRojeto = value.IDProjeto;
					}
					else
					{
						_idpRojeto = default(int);
					}
				}
			}
		}


		#endregion

		#region ctor

		public Pgtoprojeto()
		{
			_projeto = new EntityRef<Projeto>();
		}

		#endregion

	}

	[Table(Name = "cashin.projeto")]
	public partial class Projeto : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int? IDOrcamento

		private int? _idoRcamento;
		[DebuggerNonUserCode]
		[Column(Storage = "_idoRcamento", Name = "idOrcamento", DbType = "int")]
		public int? IDOrcamento
		{
			get
			{
				return _idoRcamento;
			}
			set
			{
				if (value != _idoRcamento)
				{
					_idoRcamento = value;
					OnPropertyChanged("IDOrcamento");
				}
			}
		}

		#endregion

		#region int IDProjeto

		private int _idpRojeto;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpRojeto", Name = "idProjeto", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDProjeto
		{
			get
			{
				return _idpRojeto;
			}
			set
			{
				if (value != _idpRojeto)
				{
					_idpRojeto = value;
					OnPropertyChanged("IDProjeto");
				}
			}
		}

		#endregion

		#region DateTime? Inicio

		private DateTime? _inicio;
		[DebuggerNonUserCode]
		[Column(Storage = "_inicio", Name = "inicio", DbType = "date")]
		public DateTime? Inicio
		{
			get
			{
				return _inicio;
			}
			set
			{
				if (value != _inicio)
				{
					_inicio = value;
					OnPropertyChanged("Inicio");
				}
			}
		}

		#endregion

		#region DateTime? Prazo

		private DateTime? _prazo;
		[DebuggerNonUserCode]
		[Column(Storage = "_prazo", Name = "prazo", DbType = "date")]
		public DateTime? Prazo
		{
			get
			{
				return _prazo;
			}
			set
			{
				if (value != _prazo)
				{
					_prazo = value;
					OnPropertyChanged("Prazo");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Notas> _notas;
		[Association(Storage = "_notas", OtherKey = "IDProjeto", Name = "fk_Notas_Projeto1")]
		[DebuggerNonUserCode]
		public EntitySet<Notas> Notas
		{
			get
			{
				return _notas;
			}
			set
			{
				_notas = value;
			}
		}

		private EntitySet<Pgtoprojeto> _pgtoprojeto;
		[Association(Storage = "_pgtoprojeto", OtherKey = "IDProjeto", Name = "fk_PgtoProjeto_Projeto1")]
		[DebuggerNonUserCode]
		public EntitySet<Pgtoprojeto> Pgtoprojeto
		{
			get
			{
				return _pgtoprojeto;
			}
			set
			{
				_pgtoprojeto = value;
			}
		}

		private EntitySet<Tarefas> _tarefas;
		[Association(Storage = "_tarefas", OtherKey = "IDProjeto", Name = "fk_Tarefas_Projeto1")]
		[DebuggerNonUserCode]
		public EntitySet<Tarefas> Tarefas
		{
			get
			{
				return _tarefas;
			}
			set
			{
				_tarefas = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<Orcamento> _orcamento;
		[Association(Storage = "_orcamento", ThisKey = "IDOrcamento", Name = "fk_Projeto_Orcamento1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Orcamento Orcamento
		{
			get
			{
				return _orcamento.Entity;
			}
			set
			{
				if (value != _orcamento.Entity)
				{
					if (_orcamento.Entity != null)
					{
						var previousOrcamento = _orcamento.Entity;
						_orcamento.Entity = null;
						previousOrcamento.Projeto.Remove(this);
					}
					_orcamento.Entity = value;
					if (value != null)
					{
						value.Projeto.Add(this);
						_idoRcamento = value.IDOrcamento;
					}
					else
					{
						_idoRcamento = null;
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void Notas_Attach(Notas entity)
		{
			entity.Projeto = this;
		}

		private void Notas_Detach(Notas entity)
		{
			entity.Projeto = null;
		}

		private void Pgtoprojeto_Attach(Pgtoprojeto entity)
		{
			entity.Projeto = this;
		}

		private void Pgtoprojeto_Detach(Pgtoprojeto entity)
		{
			entity.Projeto = null;
		}

		private void Tarefas_Attach(Tarefas entity)
		{
			entity.Projeto = this;
		}

		private void Tarefas_Detach(Tarefas entity)
		{
			entity.Projeto = null;
		}


		#endregion

		#region ctor

		public Projeto()
		{
			_notas = new EntitySet<Notas>(Notas_Attach, Notas_Detach);
			_pgtoprojeto = new EntitySet<Pgtoprojeto>(Pgtoprojeto_Attach, Pgtoprojeto_Detach);
			_tarefas = new EntitySet<Tarefas>(Tarefas_Attach, Tarefas_Detach);
			_orcamento = new EntityRef<Orcamento>();
		}

		#endregion

	}

	[Table(Name = "cashin.statustarefa")]
	public partial class Statustarefa : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int IDStatusTarefa

		private int _idsTatusTarefa;
		[DebuggerNonUserCode]
		[Column(Storage = "_idsTatusTarefa", Name = "idStatusTarefa", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDStatusTarefa
		{
			get
			{
				return _idsTatusTarefa;
			}
			set
			{
				if (value != _idsTatusTarefa)
				{
					_idsTatusTarefa = value;
					OnPropertyChanged("IDStatusTarefa");
				}
			}
		}

		#endregion

		#region string Nome

		private string _nome;
		[DebuggerNonUserCode]
		[Column(Storage = "_nome", Name = "nome", DbType = "varchar(45)")]
		public string Nome
		{
			get
			{
				return _nome;
			}
			set
			{
				if (value != _nome)
				{
					_nome = value;
					OnPropertyChanged("Nome");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Tarefas> _tarefas;
		[Association(Storage = "_tarefas", OtherKey = "IDStatus", Name = "fk_Tarefas_StatusTarefa1")]
		[DebuggerNonUserCode]
		public EntitySet<Tarefas> Tarefas
		{
			get
			{
				return _tarefas;
			}
			set
			{
				_tarefas = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void Tarefas_Attach(Tarefas entity)
		{
			entity.Statustarefa = this;
		}

		private void Tarefas_Detach(Tarefas entity)
		{
			entity.Statustarefa = null;
		}


		#endregion

		#region ctor

		public Statustarefa()
		{
			_tarefas = new EntitySet<Tarefas>(Tarefas_Attach, Tarefas_Detach);
		}

		#endregion

	}

	[Table(Name = "cashin.tarefas")]
	public partial class Tarefas : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Descricao

		private string _descricao;
		[DebuggerNonUserCode]
		[Column(Storage = "_descricao", Name = "descricao", DbType = "varchar(300)")]
		public string Descricao
		{
			get
			{
				return _descricao;
			}
			set
			{
				if (value != _descricao)
				{
					_descricao = value;
					OnPropertyChanged("Descricao");
				}
			}
		}

		#endregion

		#region int? IDProjeto

		private int? _idpRojeto;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpRojeto", Name = "idProjeto", DbType = "int")]
		public int? IDProjeto
		{
			get
			{
				return _idpRojeto;
			}
			set
			{
				if (value != _idpRojeto)
				{
					_idpRojeto = value;
					OnPropertyChanged("IDProjeto");
				}
			}
		}

		#endregion

		#region int? IDStatus

		private int? _idsTatus;
		[DebuggerNonUserCode]
		[Column(Storage = "_idsTatus", Name = "idStatus", DbType = "int")]
		public int? IDStatus
		{
			get
			{
				return _idsTatus;
			}
			set
			{
				if (value != _idsTatus)
				{
					_idsTatus = value;
					OnPropertyChanged("IDStatus");
				}
			}
		}

		#endregion

		#region int? IDTarefaPai

		private int? _idtArefaPai;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtArefaPai", Name = "idTarefaPai", DbType = "int")]
		public int? IDTarefaPai
		{
			get
			{
				return _idtArefaPai;
			}
			set
			{
				if (value != _idtArefaPai)
				{
					_idtArefaPai = value;
					OnPropertyChanged("IDTarefaPai");
				}
			}
		}

		#endregion

		#region int IDTarefas

		private int _idtArefas;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtArefas", Name = "idTarefas", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDTarefas
		{
			get
			{
				return _idtArefas;
			}
			set
			{
				if (value != _idtArefas)
				{
					_idtArefas = value;
					OnPropertyChanged("IDTarefas");
				}
			}
		}

		#endregion

		#region int? IDUsuarioAlocado

		private int? _iduSuarioAlocado;
		[DebuggerNonUserCode]
		[Column(Storage = "_iduSuarioAlocado", Name = "idUsuarioAlocado", DbType = "int")]
		public int? IDUsuarioAlocado
		{
			get
			{
				return _iduSuarioAlocado;
			}
			set
			{
				if (value != _iduSuarioAlocado)
				{
					_iduSuarioAlocado = value;
					OnPropertyChanged("IDUsuarioAlocado");
				}
			}
		}

		#endregion

		#region string Titulo

		private string _titulo;
		[DebuggerNonUserCode]
		[Column(Storage = "_titulo", Name = "titulo", DbType = "varchar(100)")]
		public string Titulo
		{
			get
			{
				return _titulo;
			}
			set
			{
				if (value != _titulo)
				{
					_titulo = value;
					OnPropertyChanged("Titulo");
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<Projeto> _projeto;
		[Association(Storage = "_projeto", ThisKey = "IDProjeto", Name = "fk_Tarefas_Projeto1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Projeto Projeto
		{
			get
			{
				return _projeto.Entity;
			}
			set
			{
				if (value != _projeto.Entity)
				{
					if (_projeto.Entity != null)
					{
						var previousProjeto = _projeto.Entity;
						_projeto.Entity = null;
						previousProjeto.Tarefas.Remove(this);
					}
					_projeto.Entity = value;
					if (value != null)
					{
						value.Tarefas.Add(this);
						_idpRojeto = value.IDProjeto;
					}
					else
					{
						_idpRojeto = null;
					}
				}
			}
		}

		private EntityRef<Statustarefa> _statustarefa;
		[Association(Storage = "_statustarefa", ThisKey = "IDStatus", Name = "fk_Tarefas_StatusTarefa1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public Statustarefa Statustarefa
		{
			get
			{
				return _statustarefa.Entity;
			}
			set
			{
				if (value != _statustarefa.Entity)
				{
					if (_statustarefa.Entity != null)
					{
						var previousStatustarefa = _statustarefa.Entity;
						_statustarefa.Entity = null;
						previousStatustarefa.Tarefas.Remove(this);
					}
					_statustarefa.Entity = value;
					if (value != null)
					{
						value.Tarefas.Add(this);
						_idsTatus = value.IDStatusTarefa;
					}
					else
					{
						_idsTatus = null;
					}
				}
			}
		}


		#endregion

		#region ctor

		public Tarefas()
		{
			_projeto = new EntityRef<Projeto>();
			_statustarefa = new EntityRef<Statustarefa>();
		}

		#endregion

	}

	[Table(Name = "cashin.uf")]
	public partial class Uf : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string IDUf

		private string _iduF;
		[DebuggerNonUserCode]
		[Column(Storage = "_iduF", Name = "idUf", DbType = "char(2)", IsPrimaryKey = true, CanBeNull = false)]
		public string IDUf
		{
			get
			{
				return _iduF;
			}
			set
			{
				if (value != _iduF)
				{
					_iduF = value;
					OnPropertyChanged("IDUf");
				}
			}
		}

		#endregion

		#region string Nome

		private string _nome;
		[DebuggerNonUserCode]
		[Column(Storage = "_nome", Name = "Nome", DbType = "varchar(100)")]
		public string Nome
		{
			get
			{
				return _nome;
			}
			set
			{
				if (value != _nome)
				{
					_nome = value;
					OnPropertyChanged("Nome");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Cidade> _cidade;
		[Association(Storage = "_cidade", OtherKey = "IDUf", Name = "fk_Cidade_UF")]
		[DebuggerNonUserCode]
		public EntitySet<Cidade> Cidade
		{
			get
			{
				return _cidade;
			}
			set
			{
				_cidade = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void Cidade_Attach(Cidade entity)
		{
			entity.Uf = this;
		}

		private void Cidade_Detach(Cidade entity)
		{
			entity.Uf = null;
		}


		#endregion

		#region ctor

		public Uf()
		{
			_cidade = new EntitySet<Cidade>(Cidade_Attach, Cidade_Detach);
		}

		#endregion

	}

	[Table(Name = "cashin.usuario")]
	public partial class Usuario : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int? IDPessoa

		private int? _idpEssoa;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpEssoa", Name = "idPessoa", DbType = "int")]
		public int? IDPessoa
		{
			get
			{
				return _idpEssoa;
			}
			set
			{
				if (value != _idpEssoa)
				{
					_idpEssoa = value;
					OnPropertyChanged("IDPessoa");
				}
			}
		}

		#endregion

		#region int IDUsuario

		private int _iduSuario;
		[DebuggerNonUserCode]
		[Column(Storage = "_iduSuario", Name = "idUsuario", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int IDUsuario
		{
			get
			{
				return _iduSuario;
			}
			set
			{
				if (value != _iduSuario)
				{
					_iduSuario = value;
					OnPropertyChanged("IDUsuario");
				}
			}
		}

		#endregion

		#region string Pass

		private string _pass;
		[DebuggerNonUserCode]
		[Column(Storage = "_pass", Name = "pass", DbType = "varchar(45)")]
		public string Pass
		{
			get
			{
				return _pass;
			}
			set
			{
				if (value != _pass)
				{
					_pass = value;
					OnPropertyChanged("Pass");
				}
			}
		}

		#endregion

		#region string User

		private string _user;
		[DebuggerNonUserCode]
		[Column(Storage = "_user", Name = "`user`", DbType = "varchar(20)")]
		public string User
		{
			get
			{
				return _user;
			}
			set
			{
				if (value != _user)
				{
					_user = value;
					OnPropertyChanged("User");
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<Itenspadrao> _itenspadrao;
		[Association(Storage = "_itenspadrao", OtherKey = "IDUsuario", Name = "fk_itensPadrao_Usuario1")]
		[DebuggerNonUserCode]
		public EntitySet<Itenspadrao> Itenspadrao
		{
			get
			{
				return _itenspadrao;
			}
			set
			{
				_itenspadrao = value;
			}
		}

		private EntitySet<Orcamento> _orcamento;
		[Association(Storage = "_orcamento", OtherKey = "IDUsuario", Name = "fk_Orcamento_Usuario1")]
		[DebuggerNonUserCode]
		public EntitySet<Orcamento> Orcamento
		{
			get
			{
				return _orcamento;
			}
			set
			{
				_orcamento = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<Pessoa> _pessoa = new EntityRef<Pessoa>();
		[Association(Storage = "_pessoa", ThisKey = "IDPessoa", Name = "fk_Usuario_Pessoa1", IsForeignKey = true)]
		public Pessoa Pessoa
		{
			get
			{
				return _pessoa.Entity;
			}
			set
			{
				if (value != _pessoa.Entity)
				{
					if (_pessoa.Entity != null)
					{
						var previousPessoa = _pessoa.Entity;
						_pessoa.Entity = null;
						previousPessoa.Usuario.Remove(this);
					}
					_pessoa.Entity = value;
					if (value != null)
					{
						value.Usuario.Add(this);
						_idpEssoa = value.IDPessoa;
					}
					else
					{
						_idpEssoa = null;
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void Itenspadrao_Attach(Itenspadrao entity)
		{
			entity.Usuario = this;
		}

		private void Itenspadrao_Detach(Itenspadrao entity)
		{
			entity.Usuario = null;
		}

		private void Orcamento_Attach(Orcamento entity)
		{
			entity.Usuario = this;
		}

		private void Orcamento_Detach(Orcamento entity)
		{
			entity.Usuario = null;
		}


		#endregion

		#region ctor

		public Usuario()
		{
			_itenspadrao = new EntitySet<Itenspadrao>(Itenspadrao_Attach, Itenspadrao_Detach);
			_orcamento = new EntitySet<Orcamento>(Orcamento_Attach, Orcamento_Detach);
			_pessoa = new EntityRef<Pessoa>();
		}

		#endregion

	}
}
