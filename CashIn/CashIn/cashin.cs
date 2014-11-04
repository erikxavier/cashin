// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from cashin on 2014-11-04 21:06:49Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace CashIn
{
	using System;
	using System.ComponentModel;
	using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	
	
	public partial class CashinDB : DataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public CashinDB(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public CashinDB(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public CashinDB(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<Cidade> Cidade
		{
			get
			{
				return this.GetTable<Cidade>();
			}
		}
		
		public Table<Cliente> Cliente
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public Table<Endereco> Endereco
		{
			get
			{
				return this.GetTable<Endereco>();
			}
		}
		
		public Table<Itensorcamento> Itensorcamento
		{
			get
			{
				return this.GetTable<Itensorcamento>();
			}
		}
		
		public Table<Itenspadrao> Itenspadrao
		{
			get
			{
				return this.GetTable<Itenspadrao>();
			}
		}
		
		public Table<Notas> Notas
		{
			get
			{
				return this.GetTable<Notas>();
			}
		}
		
		public Table<Orcamento> Orcamento
		{
			get
			{
				return this.GetTable<Orcamento>();
			}
		}
		
		public Table<Pessoa> Pessoa
		{
			get
			{
				return this.GetTable<Pessoa>();
			}
		}
		
		public Table<Pgtoprojeto> Pgtoprojeto
		{
			get
			{
				return this.GetTable<Pgtoprojeto>();
			}
		}
		
		public Table<Projeto> Projeto
		{
			get
			{
				return this.GetTable<Projeto>();
			}
		}
		
		public Table<Statustarefa> Statustarefa
		{
			get
			{
				return this.GetTable<Statustarefa>();
			}
		}
		
		public Table<Tarefas> Tarefas
		{
			get
			{
				return this.GetTable<Tarefas>();
			}
		}
		
		public Table<Uf> Uf
		{
			get
			{
				return this.GetTable<Uf>();
			}
		}
		
		public Table<Usuario> Usuario
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
	}
	
	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class Cashin
	{
		
		public Cashin(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT
	
	public partial class CashinDB
	{
		
		public CashinDB(IDbConnection connection) : 
				base(connection, new DbLinq.MySql.MySqlVendor())
		{
			this.OnCreated();
		}
		
		public CashinDB(IDbConnection connection, IVendor sqlDialect) : 
				base(connection, sqlDialect)
		{
			this.OnCreated();
		}
		
		public CashinDB(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
				base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion
	
	[Table(Name="cashin.cidade")]
	public partial class Cidade : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _idcIdade;
		
		private string _iduF;
		
		private string _nome;
		
		private EntitySet<Endereco> _endereco;
		
		private EntityRef<Uf> _uf = new EntityRef<Uf>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDCidadeChanged();
		
		partial void OnIDCidadeChanging(int value);
		
		partial void OnIDUfChanged();
		
		partial void OnIDUfChanging(string value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		#endregion
		
		
		public Cidade()
		{
			_endereco = new EntitySet<Endereco>(new Action<Endereco>(this.Endereco_Attach), new Action<Endereco>(this.Endereco_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_idcIdade", Name="idCidade", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDCidade
		{
			get
			{
				return this._idcIdade;
			}
			set
			{
				if ((_idcIdade != value))
				{
					this.OnIDCidadeChanging(value);
					this.SendPropertyChanging();
					this._idcIdade = value;
					this.SendPropertyChanged("IDCidade");
					this.OnIDCidadeChanged();
				}
			}
		}
		
		[Column(Storage="_iduF", Name="idUF", DbType="char(2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string IDUf
		{
			get
			{
				return this._iduF;
			}
			set
			{
				if (((_iduF == value) 
							== false))
				{
					this.OnIDUfChanging(value);
					this.SendPropertyChanging();
					this._iduF = value;
					this.SendPropertyChanged("IDUf");
					this.OnIDUfChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="Nome", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_endereco", OtherKey="IDCidade", ThisKey="IDCidade", Name="fk_Endereco_Cidade1")]
		[DebuggerNonUserCode()]
		public EntitySet<Endereco> Endereco
		{
			get
			{
				return this._endereco;
			}
			set
			{
				this._endereco = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_uf", OtherKey="IDUf", ThisKey="IDUf", Name="fk_Cidade_UF", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Uf Uf
		{
			get
			{
				return this._uf.Entity;
			}
			set
			{
				if (((this._uf.Entity == value) 
							== false))
				{
					if ((this._uf.Entity != null))
					{
						Uf previousUf = this._uf.Entity;
						this._uf.Entity = null;
						previousUf.Cidade.Remove(this);
					}
					this._uf.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Endereco_Attach(Endereco entity)
		{
			this.SendPropertyChanging();
			entity.Cidade = this;
		}
		
		private void Endereco_Detach(Endereco entity)
		{
			this.SendPropertyChanging();
			entity.Cidade = null;
		}
		#endregion
	}
	
	[Table(Name="cashin.cliente")]
	public partial class Cliente : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _descricao;
		
		private int _idcLiente;
		
		private System.Nullable<int> _idpEssoa;
		
		private EntitySet<Orcamento> _orcamento;
		
		private EntityRef<Pessoa> _pessoa = new EntityRef<Pessoa>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescricaoChanged();
		
		partial void OnDescricaoChanging(string value);
		
		partial void OnIDClienteChanged();
		
		partial void OnIDClienteChanging(int value);
		
		partial void OnIDPessoaChanged();
		
		partial void OnIDPessoaChanging(System.Nullable<int> value);
		#endregion
		
		
		public Cliente()
		{
			_orcamento = new EntitySet<Orcamento>(new Action<Orcamento>(this.Orcamento_Attach), new Action<Orcamento>(this.Orcamento_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_descricao", Name="descricao", DbType="varchar(300)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				if (((_descricao == value) 
							== false))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[Column(Storage="_idcLiente", Name="idCliente", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDCliente
		{
			get
			{
				return this._idcLiente;
			}
			set
			{
				if ((_idcLiente != value))
				{
					this.OnIDClienteChanging(value);
					this.SendPropertyChanging();
					this._idcLiente = value;
					this.SendPropertyChanged("IDCliente");
					this.OnIDClienteChanged();
				}
			}
		}
		
		[Column(Storage="_idpEssoa", Name="idPessoa", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDPessoa
		{
			get
			{
				return this._idpEssoa;
			}
			set
			{
				if ((_idpEssoa != value))
				{
					this.OnIDPessoaChanging(value);
					this.SendPropertyChanging();
					this._idpEssoa = value;
					this.SendPropertyChanged("IDPessoa");
					this.OnIDPessoaChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_orcamento", OtherKey="IDCliente", ThisKey="IDCliente", Name="fk_Orcamento_Cliente1")]
		[DebuggerNonUserCode()]
		public EntitySet<Orcamento> Orcamento
		{
			get
			{
				return this._orcamento;
			}
			set
			{
				this._orcamento = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_pessoa", OtherKey="IDPessoa", ThisKey="IDPessoa", Name="fk_Cliente_Pessoa1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Pessoa Pessoa
		{
			get
			{
				return this._pessoa.Entity;
			}
			set
			{
				if (((this._pessoa.Entity == value) 
							== false))
				{
					if ((this._pessoa.Entity != null))
					{
						Pessoa previousPessoa = this._pessoa.Entity;
						this._pessoa.Entity = null;
						previousPessoa.Cliente.Remove(this);
					}
					this._pessoa.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Orcamento_Attach(Orcamento entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = this;
		}
		
		private void Orcamento_Detach(Orcamento entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = null;
		}
		#endregion
	}
	
	[Table(Name="cashin.endereco")]
	public partial class Endereco : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _bairro;
		
		private System.Nullable<int> _idcIdade;
		
		private int _ideNdereco;
		
		private System.Nullable<int> _idpEssoa;
		
		private string _logradouro;
		
		private EntityRef<Cidade> _cidade = new EntityRef<Cidade>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBairroChanged();
		
		partial void OnBairroChanging(string value);
		
		partial void OnIDCidadeChanged();
		
		partial void OnIDCidadeChanging(System.Nullable<int> value);
		
		partial void OnIDEnderecoChanged();
		
		partial void OnIDEnderecoChanging(int value);
		
		partial void OnIDPessoaChanged();
		
		partial void OnIDPessoaChanging(System.Nullable<int> value);
		
		partial void OnLogradouroChanged();
		
		partial void OnLogradouroChanging(string value);
		#endregion
		
		
		public Endereco()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_bairro", Name="Bairro", DbType="varchar(200)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Bairro
		{
			get
			{
				return this._bairro;
			}
			set
			{
				if (((_bairro == value) 
							== false))
				{
					this.OnBairroChanging(value);
					this.SendPropertyChanging();
					this._bairro = value;
					this.SendPropertyChanged("Bairro");
					this.OnBairroChanged();
				}
			}
		}
		
		[Column(Storage="_idcIdade", Name="idCidade", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDCidade
		{
			get
			{
				return this._idcIdade;
			}
			set
			{
				if ((_idcIdade != value))
				{
					this.OnIDCidadeChanging(value);
					this.SendPropertyChanging();
					this._idcIdade = value;
					this.SendPropertyChanged("IDCidade");
					this.OnIDCidadeChanged();
				}
			}
		}
		
		[Column(Storage="_ideNdereco", Name="idEndereco", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDEndereco
		{
			get
			{
				return this._ideNdereco;
			}
			set
			{
				if ((_ideNdereco != value))
				{
					this.OnIDEnderecoChanging(value);
					this.SendPropertyChanging();
					this._ideNdereco = value;
					this.SendPropertyChanged("IDEndereco");
					this.OnIDEnderecoChanged();
				}
			}
		}
		
		[Column(Storage="_idpEssoa", Name="idPessoa", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDPessoa
		{
			get
			{
				return this._idpEssoa;
			}
			set
			{
				if ((_idpEssoa != value))
				{
					this.OnIDPessoaChanging(value);
					this.SendPropertyChanging();
					this._idpEssoa = value;
					this.SendPropertyChanged("IDPessoa");
					this.OnIDPessoaChanged();
				}
			}
		}
		
		[Column(Storage="_logradouro", Name="Logradouro", DbType="varchar(200)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Logradouro
		{
			get
			{
				return this._logradouro;
			}
			set
			{
				if (((_logradouro == value) 
							== false))
				{
					this.OnLogradouroChanging(value);
					this.SendPropertyChanging();
					this._logradouro = value;
					this.SendPropertyChanged("Logradouro");
					this.OnLogradouroChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_cidade", OtherKey="IDCidade", ThisKey="IDCidade", Name="fk_Endereco_Cidade1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Cidade Cidade
		{
			get
			{
				return this._cidade.Entity;
			}
			set
			{
				if (((this._cidade.Entity == value) 
							== false))
				{
					if ((this._cidade.Entity != null))
					{
						Cidade previousCidade = this._cidade.Entity;
						this._cidade.Entity = null;
						previousCidade.Endereco.Remove(this);
					}
					this._cidade.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="cashin.itensorcamento")]
	public partial class Itensorcamento : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _descricao;
		
		private int _iditemOrcamento;
		
		private System.Nullable<int> _idoRcamento;
		
		private string _nome;
		
		private System.Nullable<decimal> _valor;
		
		private EntityRef<Orcamento> _orcamento = new EntityRef<Orcamento>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescricaoChanged();
		
		partial void OnDescricaoChanging(string value);
		
		partial void OnIditemOrcamentoChanged();
		
		partial void OnIditemOrcamentoChanging(int value);
		
		partial void OnIDOrcamentoChanged();
		
		partial void OnIDOrcamentoChanging(System.Nullable<int> value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnValorChanged();
		
		partial void OnValorChanging(System.Nullable<decimal> value);
		#endregion
		
		
		public Itensorcamento()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_descricao", Name="descricao", DbType="varchar(300)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				if (((_descricao == value) 
							== false))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[Column(Storage="_iditemOrcamento", Name="iditemOrcamento", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IditemOrcamento
		{
			get
			{
				return this._iditemOrcamento;
			}
			set
			{
				if ((_iditemOrcamento != value))
				{
					this.OnIditemOrcamentoChanging(value);
					this.SendPropertyChanging();
					this._iditemOrcamento = value;
					this.SendPropertyChanged("IditemOrcamento");
					this.OnIditemOrcamentoChanged();
				}
			}
		}
		
		[Column(Storage="_idoRcamento", Name="idOrcamento", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDOrcamento
		{
			get
			{
				return this._idoRcamento;
			}
			set
			{
				if ((_idoRcamento != value))
				{
					this.OnIDOrcamentoChanging(value);
					this.SendPropertyChanging();
					this._idoRcamento = value;
					this.SendPropertyChanged("IDOrcamento");
					this.OnIDOrcamentoChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_valor", Name="valor", DbType="decimal", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Valor
		{
			get
			{
				return this._valor;
			}
			set
			{
				if ((_valor != value))
				{
					this.OnValorChanging(value);
					this.SendPropertyChanging();
					this._valor = value;
					this.SendPropertyChanged("Valor");
					this.OnValorChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_orcamento", OtherKey="IDOrcamento", ThisKey="IDOrcamento", Name="fk_itemsOrcamento_Orcamento1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Orcamento Orcamento
		{
			get
			{
				return this._orcamento.Entity;
			}
			set
			{
				if (((this._orcamento.Entity == value) 
							== false))
				{
					if ((this._orcamento.Entity != null))
					{
						Orcamento previousOrcamento = this._orcamento.Entity;
						this._orcamento.Entity = null;
						previousOrcamento.Itensorcamento.Remove(this);
					}
					this._orcamento.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="cashin.itenspadrao")]
	public partial class Itenspadrao : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _descricao;
		
		private int _iditensPadrao;
		
		private System.Nullable<int> _iduSuario;
		
		private System.Nullable<decimal> _valor;
		
		private EntityRef<Usuario> _usuario = new EntityRef<Usuario>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescricaoChanged();
		
		partial void OnDescricaoChanging(string value);
		
		partial void OnIditensPadraoChanged();
		
		partial void OnIditensPadraoChanging(int value);
		
		partial void OnIDUsuarioChanged();
		
		partial void OnIDUsuarioChanging(System.Nullable<int> value);
		
		partial void OnValorChanged();
		
		partial void OnValorChanging(System.Nullable<decimal> value);
		#endregion
		
		
		public Itenspadrao()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_descricao", Name="descricao", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				if (((_descricao == value) 
							== false))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[Column(Storage="_iditensPadrao", Name="iditensPadrao", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IditensPadrao
		{
			get
			{
				return this._iditensPadrao;
			}
			set
			{
				if ((_iditensPadrao != value))
				{
					this.OnIditensPadraoChanging(value);
					this.SendPropertyChanging();
					this._iditensPadrao = value;
					this.SendPropertyChanged("IditensPadrao");
					this.OnIditensPadraoChanged();
				}
			}
		}
		
		[Column(Storage="_iduSuario", Name="idUsuario", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDUsuario
		{
			get
			{
				return this._iduSuario;
			}
			set
			{
				if ((_iduSuario != value))
				{
					this.OnIDUsuarioChanging(value);
					this.SendPropertyChanging();
					this._iduSuario = value;
					this.SendPropertyChanged("IDUsuario");
					this.OnIDUsuarioChanged();
				}
			}
		}
		
		[Column(Storage="_valor", Name="valor", DbType="decimal", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Valor
		{
			get
			{
				return this._valor;
			}
			set
			{
				if ((_valor != value))
				{
					this.OnValorChanging(value);
					this.SendPropertyChanging();
					this._valor = value;
					this.SendPropertyChanged("Valor");
					this.OnValorChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_usuario", OtherKey="IDUsuario", ThisKey="IDUsuario", Name="fk_itensPadrao_Usuario1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Usuario Usuario
		{
			get
			{
				return this._usuario.Entity;
			}
			set
			{
				if (((this._usuario.Entity == value) 
							== false))
				{
					if ((this._usuario.Entity != null))
					{
						Usuario previousUsuario = this._usuario.Entity;
						this._usuario.Entity = null;
						previousUsuario.Itenspadrao.Remove(this);
					}
					this._usuario.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="cashin.notas")]
	public partial class Notas : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _data;
		
		private int _idnOtas;
		
		private System.Nullable<int> _idpRojeto;
		
		private System.Nullable<decimal> _valor;
		
		private EntityRef<Projeto> _projeto = new EntityRef<Projeto>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDataChanged();
		
		partial void OnDataChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDNotasChanged();
		
		partial void OnIDNotasChanging(int value);
		
		partial void OnIDProjetoChanged();
		
		partial void OnIDProjetoChanging(System.Nullable<int> value);
		
		partial void OnValorChanged();
		
		partial void OnValorChanging(System.Nullable<decimal> value);
		#endregion
		
		
		public Notas()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_data", Name="data", DbType="date", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> Data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((_data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[Column(Storage="_idnOtas", Name="idNotas", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDNotas
		{
			get
			{
				return this._idnOtas;
			}
			set
			{
				if ((_idnOtas != value))
				{
					this.OnIDNotasChanging(value);
					this.SendPropertyChanging();
					this._idnOtas = value;
					this.SendPropertyChanged("IDNotas");
					this.OnIDNotasChanged();
				}
			}
		}
		
		[Column(Storage="_idpRojeto", Name="idProjeto", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDProjeto
		{
			get
			{
				return this._idpRojeto;
			}
			set
			{
				if ((_idpRojeto != value))
				{
					this.OnIDProjetoChanging(value);
					this.SendPropertyChanging();
					this._idpRojeto = value;
					this.SendPropertyChanged("IDProjeto");
					this.OnIDProjetoChanged();
				}
			}
		}
		
		[Column(Storage="_valor", Name="valor", DbType="decimal", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Valor
		{
			get
			{
				return this._valor;
			}
			set
			{
				if ((_valor != value))
				{
					this.OnValorChanging(value);
					this.SendPropertyChanging();
					this._valor = value;
					this.SendPropertyChanged("Valor");
					this.OnValorChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_projeto", OtherKey="IDProjeto", ThisKey="IDProjeto", Name="fk_Notas_Projeto1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Projeto Projeto
		{
			get
			{
				return this._projeto.Entity;
			}
			set
			{
				if (((this._projeto.Entity == value) 
							== false))
				{
					if ((this._projeto.Entity != null))
					{
						Projeto previousProjeto = this._projeto.Entity;
						this._projeto.Entity = null;
						previousProjeto.Notas.Remove(this);
					}
					this._projeto.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="cashin.orcamento")]
	public partial class Orcamento : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _data;
		
		private System.Nullable<int> _idcLiente;
		
		private int _idoRcamento;
		
		private System.Nullable<int> _iduSuario;
		
		private System.Nullable<System.DateTime> _validade;
		
		private EntitySet<Itensorcamento> _itensorcamento;
		
		private EntitySet<Projeto> _projeto;
		
		private EntityRef<Cliente> _cliente = new EntityRef<Cliente>();
		
		private EntityRef<Usuario> _usuario = new EntityRef<Usuario>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDataChanged();
		
		partial void OnDataChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDClienteChanged();
		
		partial void OnIDClienteChanging(System.Nullable<int> value);
		
		partial void OnIDOrcamentoChanged();
		
		partial void OnIDOrcamentoChanging(int value);
		
		partial void OnIDUsuarioChanged();
		
		partial void OnIDUsuarioChanging(System.Nullable<int> value);
		
		partial void OnValidadeChanged();
		
		partial void OnValidadeChanging(System.Nullable<System.DateTime> value);
		#endregion
		
		
		public Orcamento()
		{
			_itensorcamento = new EntitySet<Itensorcamento>(new Action<Itensorcamento>(this.Itensorcamento_Attach), new Action<Itensorcamento>(this.Itensorcamento_Detach));
			_projeto = new EntitySet<Projeto>(new Action<Projeto>(this.Projeto_Attach), new Action<Projeto>(this.Projeto_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_data", Name="data", DbType="date", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> Data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((_data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[Column(Storage="_idcLiente", Name="idCliente", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDCliente
		{
			get
			{
				return this._idcLiente;
			}
			set
			{
				if ((_idcLiente != value))
				{
					this.OnIDClienteChanging(value);
					this.SendPropertyChanging();
					this._idcLiente = value;
					this.SendPropertyChanged("IDCliente");
					this.OnIDClienteChanged();
				}
			}
		}
		
		[Column(Storage="_idoRcamento", Name="idOrcamento", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDOrcamento
		{
			get
			{
				return this._idoRcamento;
			}
			set
			{
				if ((_idoRcamento != value))
				{
					this.OnIDOrcamentoChanging(value);
					this.SendPropertyChanging();
					this._idoRcamento = value;
					this.SendPropertyChanged("IDOrcamento");
					this.OnIDOrcamentoChanged();
				}
			}
		}
		
		[Column(Storage="_iduSuario", Name="idUsuario", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDUsuario
		{
			get
			{
				return this._iduSuario;
			}
			set
			{
				if ((_iduSuario != value))
				{
					this.OnIDUsuarioChanging(value);
					this.SendPropertyChanging();
					this._iduSuario = value;
					this.SendPropertyChanged("IDUsuario");
					this.OnIDUsuarioChanged();
				}
			}
		}
		
		[Column(Storage="_validade", Name="validade", DbType="date", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> Validade
		{
			get
			{
				return this._validade;
			}
			set
			{
				if ((_validade != value))
				{
					this.OnValidadeChanging(value);
					this.SendPropertyChanging();
					this._validade = value;
					this.SendPropertyChanged("Validade");
					this.OnValidadeChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_itensorcamento", OtherKey="IDOrcamento", ThisKey="IDOrcamento", Name="fk_itemsOrcamento_Orcamento1")]
		[DebuggerNonUserCode()]
		public EntitySet<Itensorcamento> Itensorcamento
		{
			get
			{
				return this._itensorcamento;
			}
			set
			{
				this._itensorcamento = value;
			}
		}
		
		[Association(Storage="_projeto", OtherKey="IDOrcamento", ThisKey="IDOrcamento", Name="fk_Projeto_Orcamento1")]
		[DebuggerNonUserCode()]
		public EntitySet<Projeto> Projeto
		{
			get
			{
				return this._projeto;
			}
			set
			{
				this._projeto = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_cliente", OtherKey="IDCliente", ThisKey="IDCliente", Name="fk_Orcamento_Cliente1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Cliente Cliente
		{
			get
			{
				return this._cliente.Entity;
			}
			set
			{
				if (((this._cliente.Entity == value) 
							== false))
				{
					if ((this._cliente.Entity != null))
					{
						Cliente previousCliente = this._cliente.Entity;
						this._cliente.Entity = null;
						previousCliente.Orcamento.Remove(this);
					}
					this._cliente.Entity = value;
					if ((value != null))
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
		
		[Association(Storage="_usuario", OtherKey="IDUsuario", ThisKey="IDUsuario", Name="fk_Orcamento_Usuario1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Usuario Usuario
		{
			get
			{
				return this._usuario.Entity;
			}
			set
			{
				if (((this._usuario.Entity == value) 
							== false))
				{
					if ((this._usuario.Entity != null))
					{
						Usuario previousUsuario = this._usuario.Entity;
						this._usuario.Entity = null;
						previousUsuario.Orcamento.Remove(this);
					}
					this._usuario.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Itensorcamento_Attach(Itensorcamento entity)
		{
			this.SendPropertyChanging();
			entity.Orcamento = this;
		}
		
		private void Itensorcamento_Detach(Itensorcamento entity)
		{
			this.SendPropertyChanging();
			entity.Orcamento = null;
		}
		
		private void Projeto_Attach(Projeto entity)
		{
			this.SendPropertyChanging();
			entity.Orcamento = this;
		}
		
		private void Projeto_Detach(Projeto entity)
		{
			this.SendPropertyChanging();
			entity.Orcamento = null;
		}
		#endregion
	}
	
	[Table(Name="cashin.pessoa")]
	public partial class Pessoa : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _documento;
		
		private string _email;
		
		private int _idpEssoa;
		
		private string _nome;
		
		private System.Nullable<System.DateTime> _nscto;
		
		private string _sexo;
		
		private string _telefone;
		
		private string _tipoPessoa;
		
		private EntitySet<Cliente> _cliente;
		
		private EntitySet<Usuario> _usuario;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDocumentoChanged();
		
		partial void OnDocumentoChanging(string value);
		
		partial void OnEmailChanged();
		
		partial void OnEmailChanging(string value);
		
		partial void OnIDPessoaChanged();
		
		partial void OnIDPessoaChanging(int value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnNsctoChanged();
		
		partial void OnNsctoChanging(System.Nullable<System.DateTime> value);
		
		partial void OnSexoChanged();
		
		partial void OnSexoChanging(string value);
		
		partial void OnTelefoneChanged();
		
		partial void OnTelefoneChanging(string value);
		
		partial void OnTipoPessoaChanged();
		
		partial void OnTipoPessoaChanging(string value);
		#endregion
		
		
		public Pessoa()
		{
			_cliente = new EntitySet<Cliente>(new Action<Cliente>(this.Cliente_Attach), new Action<Cliente>(this.Cliente_Detach));
			_usuario = new EntitySet<Usuario>(new Action<Usuario>(this.Usuario_Attach), new Action<Usuario>(this.Usuario_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_documento", Name="documento", DbType="varchar(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Documento
		{
			get
			{
				return this._documento;
			}
			set
			{
				if (((_documento == value) 
							== false))
				{
					this.OnDocumentoChanging(value);
					this.SendPropertyChanging();
					this._documento = value;
					this.SendPropertyChanged("Documento");
					this.OnDocumentoChanged();
				}
			}
		}
		
		[Column(Storage="_email", Name="email", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				if (((_email == value) 
							== false))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Column(Storage="_idpEssoa", Name="idPessoa", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDPessoa
		{
			get
			{
				return this._idpEssoa;
			}
			set
			{
				if ((_idpEssoa != value))
				{
					this.OnIDPessoaChanging(value);
					this.SendPropertyChanging();
					this._idpEssoa = value;
					this.SendPropertyChanged("IDPessoa");
					this.OnIDPessoaChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="Nome", DbType="varchar(200)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_nscto", Name="nscto", DbType="date", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> Nscto
		{
			get
			{
				return this._nscto;
			}
			set
			{
				if ((_nscto != value))
				{
					this.OnNsctoChanging(value);
					this.SendPropertyChanging();
					this._nscto = value;
					this.SendPropertyChanged("Nscto");
					this.OnNsctoChanged();
				}
			}
		}
		
		[Column(Storage="_sexo", Name="sexo", DbType="char(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sexo
		{
			get
			{
				return this._sexo;
			}
			set
			{
				if (((_sexo == value) 
							== false))
				{
					this.OnSexoChanging(value);
					this.SendPropertyChanging();
					this._sexo = value;
					this.SendPropertyChanged("Sexo");
					this.OnSexoChanged();
				}
			}
		}
		
		[Column(Storage="_telefone", Name="telefone", DbType="varchar(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Telefone
		{
			get
			{
				return this._telefone;
			}
			set
			{
				if (((_telefone == value) 
							== false))
				{
					this.OnTelefoneChanging(value);
					this.SendPropertyChanging();
					this._telefone = value;
					this.SendPropertyChanged("Telefone");
					this.OnTelefoneChanged();
				}
			}
		}
		
		[Column(Storage="_tipoPessoa", Name="tipoPessoa", DbType="char(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string TipoPessoa
		{
			get
			{
				return this._tipoPessoa;
			}
			set
			{
				if (((_tipoPessoa == value) 
							== false))
				{
					this.OnTipoPessoaChanging(value);
					this.SendPropertyChanging();
					this._tipoPessoa = value;
					this.SendPropertyChanged("TipoPessoa");
					this.OnTipoPessoaChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_cliente", OtherKey="IDPessoa", ThisKey="IDPessoa", Name="fk_Cliente_Pessoa1")]
		[DebuggerNonUserCode()]
		public EntitySet<Cliente> Cliente
		{
			get
			{
				return this._cliente;
			}
			set
			{
				this._cliente = value;
			}
		}
		
		[Association(Storage="_usuario", OtherKey="IDPessoa", ThisKey="IDPessoa", Name="fk_Usuario_Pessoa1")]
		[DebuggerNonUserCode()]
		public EntitySet<Usuario> Usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				this._usuario = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Cliente_Attach(Cliente entity)
		{
			this.SendPropertyChanging();
			entity.Pessoa = this;
		}
		
		private void Cliente_Detach(Cliente entity)
		{
			this.SendPropertyChanging();
			entity.Pessoa = null;
		}
		
		private void Usuario_Attach(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Pessoa = this;
		}
		
		private void Usuario_Detach(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Pessoa = null;
		}
		#endregion
	}
	
	[Table(Name="cashin.pgtoprojeto")]
	public partial class Pgtoprojeto : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _data;
		
		private int _idpGtoProjeto;
		
		private int _idpRojeto;
		
		private string _recibo;
		
		private System.Nullable<decimal> _valor;
		
		private EntityRef<Projeto> _projeto = new EntityRef<Projeto>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDataChanged();
		
		partial void OnDataChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDPgtoProjetoChanged();
		
		partial void OnIDPgtoProjetoChanging(int value);
		
		partial void OnIDProjetoChanged();
		
		partial void OnIDProjetoChanging(int value);
		
		partial void OnReciboChanged();
		
		partial void OnReciboChanging(string value);
		
		partial void OnValorChanged();
		
		partial void OnValorChanging(System.Nullable<decimal> value);
		#endregion
		
		
		public Pgtoprojeto()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_data", Name="data", DbType="date", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> Data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((_data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[Column(Storage="_idpGtoProjeto", Name="idPgtoProjeto", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDPgtoProjeto
		{
			get
			{
				return this._idpGtoProjeto;
			}
			set
			{
				if ((_idpGtoProjeto != value))
				{
					this.OnIDPgtoProjetoChanging(value);
					this.SendPropertyChanging();
					this._idpGtoProjeto = value;
					this.SendPropertyChanged("IDPgtoProjeto");
					this.OnIDPgtoProjetoChanged();
				}
			}
		}
		
		[Column(Storage="_idpRojeto", Name="idProjeto", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDProjeto
		{
			get
			{
				return this._idpRojeto;
			}
			set
			{
				if ((_idpRojeto != value))
				{
					this.OnIDProjetoChanging(value);
					this.SendPropertyChanging();
					this._idpRojeto = value;
					this.SendPropertyChanged("IDProjeto");
					this.OnIDProjetoChanged();
				}
			}
		}
		
		[Column(Storage="_recibo", Name="recibo", DbType="varchar(300)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Recibo
		{
			get
			{
				return this._recibo;
			}
			set
			{
				if (((_recibo == value) 
							== false))
				{
					this.OnReciboChanging(value);
					this.SendPropertyChanging();
					this._recibo = value;
					this.SendPropertyChanged("Recibo");
					this.OnReciboChanged();
				}
			}
		}
		
		[Column(Storage="_valor", Name="valor", DbType="decimal", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Valor
		{
			get
			{
				return this._valor;
			}
			set
			{
				if ((_valor != value))
				{
					this.OnValorChanging(value);
					this.SendPropertyChanging();
					this._valor = value;
					this.SendPropertyChanged("Valor");
					this.OnValorChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_projeto", OtherKey="IDProjeto", ThisKey="IDProjeto", Name="fk_PgtoProjeto_Projeto1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Projeto Projeto
		{
			get
			{
				return this._projeto.Entity;
			}
			set
			{
				if (((this._projeto.Entity == value) 
							== false))
				{
					if ((this._projeto.Entity != null))
					{
						Projeto previousProjeto = this._projeto.Entity;
						this._projeto.Entity = null;
						previousProjeto.Pgtoprojeto.Remove(this);
					}
					this._projeto.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="cashin.projeto")]
	public partial class Projeto : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _idoRcamento;
		
		private int _idpRojeto;
		
		private System.Nullable<System.DateTime> _inicio;
		
		private System.Nullable<System.DateTime> _prazo;
		
		private EntitySet<Notas> _notas;
		
		private EntitySet<Pgtoprojeto> _pgtoprojeto;
		
		private EntitySet<Tarefas> _tarefas;
		
		private EntityRef<Orcamento> _orcamento = new EntityRef<Orcamento>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDOrcamentoChanged();
		
		partial void OnIDOrcamentoChanging(System.Nullable<int> value);
		
		partial void OnIDProjetoChanged();
		
		partial void OnIDProjetoChanging(int value);
		
		partial void OnInicioChanged();
		
		partial void OnInicioChanging(System.Nullable<System.DateTime> value);
		
		partial void OnPrazoChanged();
		
		partial void OnPrazoChanging(System.Nullable<System.DateTime> value);
		#endregion
		
		
		public Projeto()
		{
			_notas = new EntitySet<Notas>(new Action<Notas>(this.Notas_Attach), new Action<Notas>(this.Notas_Detach));
			_pgtoprojeto = new EntitySet<Pgtoprojeto>(new Action<Pgtoprojeto>(this.Pgtoprojeto_Attach), new Action<Pgtoprojeto>(this.Pgtoprojeto_Detach));
			_tarefas = new EntitySet<Tarefas>(new Action<Tarefas>(this.Tarefas_Attach), new Action<Tarefas>(this.Tarefas_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_idoRcamento", Name="idOrcamento", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDOrcamento
		{
			get
			{
				return this._idoRcamento;
			}
			set
			{
				if ((_idoRcamento != value))
				{
					this.OnIDOrcamentoChanging(value);
					this.SendPropertyChanging();
					this._idoRcamento = value;
					this.SendPropertyChanged("IDOrcamento");
					this.OnIDOrcamentoChanged();
				}
			}
		}
		
		[Column(Storage="_idpRojeto", Name="idProjeto", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDProjeto
		{
			get
			{
				return this._idpRojeto;
			}
			set
			{
				if ((_idpRojeto != value))
				{
					this.OnIDProjetoChanging(value);
					this.SendPropertyChanging();
					this._idpRojeto = value;
					this.SendPropertyChanged("IDProjeto");
					this.OnIDProjetoChanged();
				}
			}
		}
		
		[Column(Storage="_inicio", Name="inicio", DbType="date", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> Inicio
		{
			get
			{
				return this._inicio;
			}
			set
			{
				if ((_inicio != value))
				{
					this.OnInicioChanging(value);
					this.SendPropertyChanging();
					this._inicio = value;
					this.SendPropertyChanged("Inicio");
					this.OnInicioChanged();
				}
			}
		}
		
		[Column(Storage="_prazo", Name="prazo", DbType="date", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> Prazo
		{
			get
			{
				return this._prazo;
			}
			set
			{
				if ((_prazo != value))
				{
					this.OnPrazoChanging(value);
					this.SendPropertyChanging();
					this._prazo = value;
					this.SendPropertyChanged("Prazo");
					this.OnPrazoChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_notas", OtherKey="IDProjeto", ThisKey="IDProjeto", Name="fk_Notas_Projeto1")]
		[DebuggerNonUserCode()]
		public EntitySet<Notas> Notas
		{
			get
			{
				return this._notas;
			}
			set
			{
				this._notas = value;
			}
		}
		
		[Association(Storage="_pgtoprojeto", OtherKey="IDProjeto", ThisKey="IDProjeto", Name="fk_PgtoProjeto_Projeto1")]
		[DebuggerNonUserCode()]
		public EntitySet<Pgtoprojeto> Pgtoprojeto
		{
			get
			{
				return this._pgtoprojeto;
			}
			set
			{
				this._pgtoprojeto = value;
			}
		}
		
		[Association(Storage="_tarefas", OtherKey="IDProjeto", ThisKey="IDProjeto", Name="fk_Tarefas_Projeto1")]
		[DebuggerNonUserCode()]
		public EntitySet<Tarefas> Tarefas
		{
			get
			{
				return this._tarefas;
			}
			set
			{
				this._tarefas = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_orcamento", OtherKey="IDOrcamento", ThisKey="IDOrcamento", Name="fk_Projeto_Orcamento1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Orcamento Orcamento
		{
			get
			{
				return this._orcamento.Entity;
			}
			set
			{
				if (((this._orcamento.Entity == value) 
							== false))
				{
					if ((this._orcamento.Entity != null))
					{
						Orcamento previousOrcamento = this._orcamento.Entity;
						this._orcamento.Entity = null;
						previousOrcamento.Projeto.Remove(this);
					}
					this._orcamento.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Notas_Attach(Notas entity)
		{
			this.SendPropertyChanging();
			entity.Projeto = this;
		}
		
		private void Notas_Detach(Notas entity)
		{
			this.SendPropertyChanging();
			entity.Projeto = null;
		}
		
		private void Pgtoprojeto_Attach(Pgtoprojeto entity)
		{
			this.SendPropertyChanging();
			entity.Projeto = this;
		}
		
		private void Pgtoprojeto_Detach(Pgtoprojeto entity)
		{
			this.SendPropertyChanging();
			entity.Projeto = null;
		}
		
		private void Tarefas_Attach(Tarefas entity)
		{
			this.SendPropertyChanging();
			entity.Projeto = this;
		}
		
		private void Tarefas_Detach(Tarefas entity)
		{
			this.SendPropertyChanging();
			entity.Projeto = null;
		}
		#endregion
	}
	
	[Table(Name="cashin.statustarefa")]
	public partial class Statustarefa : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _idsTatusTarefa;
		
		private string _nome;
		
		private EntitySet<Tarefas> _tarefas;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDStatusTarefaChanged();
		
		partial void OnIDStatusTarefaChanging(int value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		#endregion
		
		
		public Statustarefa()
		{
			_tarefas = new EntitySet<Tarefas>(new Action<Tarefas>(this.Tarefas_Attach), new Action<Tarefas>(this.Tarefas_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_idsTatusTarefa", Name="idStatusTarefa", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDStatusTarefa
		{
			get
			{
				return this._idsTatusTarefa;
			}
			set
			{
				if ((_idsTatusTarefa != value))
				{
					this.OnIDStatusTarefaChanging(value);
					this.SendPropertyChanging();
					this._idsTatusTarefa = value;
					this.SendPropertyChanged("IDStatusTarefa");
					this.OnIDStatusTarefaChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_tarefas", OtherKey="IDStatus", ThisKey="IDStatusTarefa", Name="fk_Tarefas_StatusTarefa1")]
		[DebuggerNonUserCode()]
		public EntitySet<Tarefas> Tarefas
		{
			get
			{
				return this._tarefas;
			}
			set
			{
				this._tarefas = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Tarefas_Attach(Tarefas entity)
		{
			this.SendPropertyChanging();
			entity.Statustarefa = this;
		}
		
		private void Tarefas_Detach(Tarefas entity)
		{
			this.SendPropertyChanging();
			entity.Statustarefa = null;
		}
		#endregion
	}
	
	[Table(Name="cashin.tarefas")]
	public partial class Tarefas : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _descricao;
		
		private System.Nullable<int> _idpRojeto;
		
		private System.Nullable<int> _idsTatus;
		
		private System.Nullable<int> _idtArefaPai;
		
		private int _idtArefas;
		
		private System.Nullable<int> _iduSuarioAlocado;
		
		private string _titulo;
		
		private EntityRef<Projeto> _projeto = new EntityRef<Projeto>();
		
		private EntityRef<Statustarefa> _statustarefa = new EntityRef<Statustarefa>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescricaoChanged();
		
		partial void OnDescricaoChanging(string value);
		
		partial void OnIDProjetoChanged();
		
		partial void OnIDProjetoChanging(System.Nullable<int> value);
		
		partial void OnIDStatusChanged();
		
		partial void OnIDStatusChanging(System.Nullable<int> value);
		
		partial void OnIDTarefaPaiChanged();
		
		partial void OnIDTarefaPaiChanging(System.Nullable<int> value);
		
		partial void OnIDTarefasChanged();
		
		partial void OnIDTarefasChanging(int value);
		
		partial void OnIDUsuarioAlocadoChanged();
		
		partial void OnIDUsuarioAlocadoChanging(System.Nullable<int> value);
		
		partial void OnTituloChanged();
		
		partial void OnTituloChanging(string value);
		#endregion
		
		
		public Tarefas()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_descricao", Name="descricao", DbType="varchar(300)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				if (((_descricao == value) 
							== false))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[Column(Storage="_idpRojeto", Name="idProjeto", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDProjeto
		{
			get
			{
				return this._idpRojeto;
			}
			set
			{
				if ((_idpRojeto != value))
				{
					this.OnIDProjetoChanging(value);
					this.SendPropertyChanging();
					this._idpRojeto = value;
					this.SendPropertyChanged("IDProjeto");
					this.OnIDProjetoChanged();
				}
			}
		}
		
		[Column(Storage="_idsTatus", Name="idStatus", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDStatus
		{
			get
			{
				return this._idsTatus;
			}
			set
			{
				if ((_idsTatus != value))
				{
					this.OnIDStatusChanging(value);
					this.SendPropertyChanging();
					this._idsTatus = value;
					this.SendPropertyChanged("IDStatus");
					this.OnIDStatusChanged();
				}
			}
		}
		
		[Column(Storage="_idtArefaPai", Name="idTarefaPai", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDTarefaPai
		{
			get
			{
				return this._idtArefaPai;
			}
			set
			{
				if ((_idtArefaPai != value))
				{
					this.OnIDTarefaPaiChanging(value);
					this.SendPropertyChanging();
					this._idtArefaPai = value;
					this.SendPropertyChanged("IDTarefaPai");
					this.OnIDTarefaPaiChanged();
				}
			}
		}
		
		[Column(Storage="_idtArefas", Name="idTarefas", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDTarefas
		{
			get
			{
				return this._idtArefas;
			}
			set
			{
				if ((_idtArefas != value))
				{
					this.OnIDTarefasChanging(value);
					this.SendPropertyChanging();
					this._idtArefas = value;
					this.SendPropertyChanged("IDTarefas");
					this.OnIDTarefasChanged();
				}
			}
		}
		
		[Column(Storage="_iduSuarioAlocado", Name="idUsuarioAlocado", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDUsuarioAlocado
		{
			get
			{
				return this._iduSuarioAlocado;
			}
			set
			{
				if ((_iduSuarioAlocado != value))
				{
					this.OnIDUsuarioAlocadoChanging(value);
					this.SendPropertyChanging();
					this._iduSuarioAlocado = value;
					this.SendPropertyChanged("IDUsuarioAlocado");
					this.OnIDUsuarioAlocadoChanged();
				}
			}
		}
		
		[Column(Storage="_titulo", Name="titulo", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Titulo
		{
			get
			{
				return this._titulo;
			}
			set
			{
				if (((_titulo == value) 
							== false))
				{
					this.OnTituloChanging(value);
					this.SendPropertyChanging();
					this._titulo = value;
					this.SendPropertyChanged("Titulo");
					this.OnTituloChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_projeto", OtherKey="IDProjeto", ThisKey="IDProjeto", Name="fk_Tarefas_Projeto1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Projeto Projeto
		{
			get
			{
				return this._projeto.Entity;
			}
			set
			{
				if (((this._projeto.Entity == value) 
							== false))
				{
					if ((this._projeto.Entity != null))
					{
						Projeto previousProjeto = this._projeto.Entity;
						this._projeto.Entity = null;
						previousProjeto.Tarefas.Remove(this);
					}
					this._projeto.Entity = value;
					if ((value != null))
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
		
		[Association(Storage="_statustarefa", OtherKey="IDStatusTarefa", ThisKey="IDStatus", Name="fk_Tarefas_StatusTarefa1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Statustarefa Statustarefa
		{
			get
			{
				return this._statustarefa.Entity;
			}
			set
			{
				if (((this._statustarefa.Entity == value) 
							== false))
				{
					if ((this._statustarefa.Entity != null))
					{
						Statustarefa previousStatustarefa = this._statustarefa.Entity;
						this._statustarefa.Entity = null;
						previousStatustarefa.Tarefas.Remove(this);
					}
					this._statustarefa.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="cashin.uf")]
	public partial class Uf : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _iduF;
		
		private string _nome;
		
		private EntitySet<Cidade> _cidade;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDUfChanged();
		
		partial void OnIDUfChanging(string value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		#endregion
		
		
		public Uf()
		{
			_cidade = new EntitySet<Cidade>(new Action<Cidade>(this.Cidade_Attach), new Action<Cidade>(this.Cidade_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_iduF", Name="idUf", DbType="char(2)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string IDUf
		{
			get
			{
				return this._iduF;
			}
			set
			{
				if (((_iduF == value) 
							== false))
				{
					this.OnIDUfChanging(value);
					this.SendPropertyChanging();
					this._iduF = value;
					this.SendPropertyChanged("IDUf");
					this.OnIDUfChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="Nome", DbType="varchar(100)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_cidade", OtherKey="IDUf", ThisKey="IDUf", Name="fk_Cidade_UF")]
		[DebuggerNonUserCode()]
		public EntitySet<Cidade> Cidade
		{
			get
			{
				return this._cidade;
			}
			set
			{
				this._cidade = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Cidade_Attach(Cidade entity)
		{
			this.SendPropertyChanging();
			entity.Uf = this;
		}
		
		private void Cidade_Detach(Cidade entity)
		{
			this.SendPropertyChanging();
			entity.Uf = null;
		}
		#endregion
	}
	
	[Table(Name="cashin.usuario")]
	public partial class Usuario : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _idpEssoa;
		
		private int _iduSuario;
		
		private string _pass;
		
		private string _user;
		
		private EntitySet<Itenspadrao> _itenspadrao;
		
		private EntitySet<Orcamento> _orcamento;
		
		private EntityRef<Pessoa> _pessoa = new EntityRef<Pessoa>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDPessoaChanged();
		
		partial void OnIDPessoaChanging(System.Nullable<int> value);
		
		partial void OnIDUsuarioChanged();
		
		partial void OnIDUsuarioChanging(int value);
		
		partial void OnPassChanged();
		
		partial void OnPassChanging(string value);
		
		partial void OnUserChanged();
		
		partial void OnUserChanging(string value);
		#endregion
		
		
		public Usuario()
		{
			_itenspadrao = new EntitySet<Itenspadrao>(new Action<Itenspadrao>(this.Itenspadrao_Attach), new Action<Itenspadrao>(this.Itenspadrao_Detach));
			_orcamento = new EntitySet<Orcamento>(new Action<Orcamento>(this.Orcamento_Attach), new Action<Orcamento>(this.Orcamento_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_idpEssoa", Name="idPessoa", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> IDPessoa
		{
			get
			{
				return this._idpEssoa;
			}
			set
			{
				if ((_idpEssoa != value))
				{
					this.OnIDPessoaChanging(value);
					this.SendPropertyChanging();
					this._idpEssoa = value;
					this.SendPropertyChanged("IDPessoa");
					this.OnIDPessoaChanged();
				}
			}
		}
		
		[Column(Storage="_iduSuario", Name="idUsuario", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDUsuario
		{
			get
			{
				return this._iduSuario;
			}
			set
			{
				if ((_iduSuario != value))
				{
					this.OnIDUsuarioChanging(value);
					this.SendPropertyChanging();
					this._iduSuario = value;
					this.SendPropertyChanged("IDUsuario");
					this.OnIDUsuarioChanged();
				}
			}
		}
		
		[Column(Storage="_pass", Name="pass", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if (((_pass == value) 
							== false))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[Column(Storage="_user", Name="user", DbType="varchar(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string User
		{
			get
			{
				return this._user;
			}
			set
			{
				if (((_user == value) 
							== false))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._user = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_itenspadrao", OtherKey="IDUsuario", ThisKey="IDUsuario", Name="fk_itensPadrao_Usuario1")]
		[DebuggerNonUserCode()]
		public EntitySet<Itenspadrao> Itenspadrao
		{
			get
			{
				return this._itenspadrao;
			}
			set
			{
				this._itenspadrao = value;
			}
		}
		
		[Association(Storage="_orcamento", OtherKey="IDUsuario", ThisKey="IDUsuario", Name="fk_Orcamento_Usuario1")]
		[DebuggerNonUserCode()]
		public EntitySet<Orcamento> Orcamento
		{
			get
			{
				return this._orcamento;
			}
			set
			{
				this._orcamento = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_pessoa", OtherKey="IDPessoa", ThisKey="IDPessoa", Name="fk_Usuario_Pessoa1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Pessoa Pessoa
		{
			get
			{
				return this._pessoa.Entity;
			}
			set
			{
				if (((this._pessoa.Entity == value) 
							== false))
				{
					if ((this._pessoa.Entity != null))
					{
						Pessoa previousPessoa = this._pessoa.Entity;
						this._pessoa.Entity = null;
						previousPessoa.Usuario.Remove(this);
					}
					this._pessoa.Entity = value;
					if ((value != null))
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
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Itenspadrao_Attach(Itenspadrao entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void Itenspadrao_Detach(Itenspadrao entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
		
		private void Orcamento_Attach(Orcamento entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void Orcamento_Detach(Orcamento entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
		#endregion
	}
}
