#region Auto-generated classes for testlinq database on 2014-10-20 19:56:28Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from testlinq on 2014-10-20 19:56:28Z
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

namespace testlinq
{
	public partial class Testlinq : DataContext
	{
		public Testlinq(IDbConnection connection)
		: base(connection, new DbLinq.MySql.MySqlVendor())
		{
		}

		public Testlinq(IDbConnection connection, IVendor vendor)
		: base(connection, vendor)
		{
		}

		public Table<Notas> Notas { get { return GetTable<Notas>(); } }
		public Table<Pessoa> Pessoa { get { return GetTable<Pessoa>(); } }

	}

	[Table(Name = "testlinq.notas")]
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

		#region int CodigoPessoa

		private int _codigoPessoa;
		[DebuggerNonUserCode]
		[Column(Storage = "_codigoPessoa", Name = "codigo_pessoa", DbType = "int", CanBeNull = false)]
		public int CodigoPessoa
		{
			get
			{
				return _codigoPessoa;
			}
			set
			{
				if (value != _codigoPessoa)
				{
					_codigoPessoa = value;
					OnPropertyChanged("CodigoPessoa");
				}
			}
		}

		#endregion

		#region string Disciplina

		private string _disciplina;
		[DebuggerNonUserCode]
		[Column(Storage = "_disciplina", Name = "disciplina", DbType = "varchar(50)")]
		public string Disciplina
		{
			get
			{
				return _disciplina;
			}
			set
			{
				if (value != _disciplina)
				{
					_disciplina = value;
					OnPropertyChanged("Disciplina");
				}
			}
		}

		#endregion

		#region decimal? Nota

		private decimal? _nota;
		[DebuggerNonUserCode]
		[Column(Storage = "_nota", Name = "nota", DbType = "decimal(3,1)")]
		public decimal? Nota
		{
			get
			{
				return _nota;
			}
			set
			{
				if (value != _nota)
				{
					_nota = value;
					OnPropertyChanged("Nota");
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<Pessoa> _pessoa;
		[Association(Storage = "_pessoa", ThisKey = "CodigoPessoa", Name = "notas_ibfk_1", IsForeignKey = true)]
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
						previousPessoa.Notas.Remove(this);
					}
					_pessoa.Entity = value;
					if (value != null)
					{
						value.Notas.Add(this);
						_codigoPessoa = value.Codigo;
					}
					else
					{
						_codigoPessoa = default(int);
					}
				}
			}
		}


		#endregion

		#region ctor

		public Notas()
		{
			_pessoa = new EntityRef<Pessoa>();
		}

		#endregion

	}

	[Table(Name = "testlinq.pessoa")]
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

		#region int Codigo

		private int _codigo;
		[DebuggerNonUserCode]
		[Column(Storage = "_codigo", Name = "codigo", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int Codigo
		{
			get
			{
				return _codigo;
			}
			set
			{
				if (value != _codigo)
				{
					_codigo = value;
					OnPropertyChanged("Codigo");
				}
			}
		}

		#endregion

		#region string Cpf

		private string _cpf;
		[DebuggerNonUserCode]
		[Column(Storage = "_cpf", Name = "cpf", DbType = "varchar(15)", CanBeNull = false)]
		public string Cpf
		{
			get
			{
				return _cpf;
			}
			set
			{
				if (value != _cpf)
				{
					_cpf = value;
					OnPropertyChanged("Cpf");
				}
			}
		}

		#endregion

		#region string Curso

		private string _curso;
		[DebuggerNonUserCode]
		[Column(Storage = "_curso", Name = "curso", DbType = "varchar(20)")]
		public string Curso
		{
			get
			{
				return _curso;
			}
			set
			{
				if (value != _curso)
				{
					_curso = value;
					OnPropertyChanged("Curso");
				}
			}
		}

		#endregion

		#region string Nome

		private string _nome;
		[DebuggerNonUserCode]
		[Column(Storage = "_nome", Name = "nome", DbType = "varchar(100)", CanBeNull = false)]
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

		private EntitySet<Notas> _notas;
		[Association(Storage = "_notas", OtherKey = "CodigoPessoa", Name = "notas_ibfk_1")]
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


		#endregion

		#region Attachement handlers

		private void Notas_Attach(Notas entity)
		{
			entity.Pessoa = this;
		}

		private void Notas_Detach(Notas entity)
		{
			entity.Pessoa = null;
		}


		#endregion

		#region ctor

		public Pessoa()
		{
			_notas = new EntitySet<Notas>(Notas_Attach, Notas_Detach);
		}

		#endregion

	}
}
