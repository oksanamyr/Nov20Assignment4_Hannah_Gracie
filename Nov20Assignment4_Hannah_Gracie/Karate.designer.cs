﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nov20Assignment4_Hannah_Gracie
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="KarateSchool")]
	public partial class KarateDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertInstructor(Instructor instance);
    partial void UpdateInstructor(Instructor instance);
    partial void DeleteInstructor(Instructor instance);
    partial void InsertSection(Section instance);
    partial void UpdateSection(Section instance);
    partial void DeleteSection(Section instance);
    partial void InsertMember(Member instance);
    partial void UpdateMember(Member instance);
    partial void DeleteMember(Member instance);
    partial void InsertNetUser(NetUser instance);
    partial void UpdateNetUser(NetUser instance);
    partial void DeleteNetUser(NetUser instance);
    #endregion
		
		public KarateDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KarateDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KarateDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KarateDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Instructor> Instructors
		{
			get
			{
				return this.GetTable<Instructor>();
			}
		}
		
		public System.Data.Linq.Table<Section> Sections
		{
			get
			{
				return this.GetTable<Section>();
			}
		}
		
		public System.Data.Linq.Table<Member> Members
		{
			get
			{
				return this.GetTable<Member>();
			}
		}
		
		public System.Data.Linq.Table<NetUser> NetUsers
		{
			get
			{
				return this.GetTable<NetUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Instructor")]
	public partial class Instructor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _InstructorID;
		
		private string _InstructorFirstName;
		
		private string _InstructorLastName;
		
		private string _InstructorPhoneNumber;
		
		private EntityRef<NetUser> _NetUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInstructorIDChanging(int value);
    partial void OnInstructorIDChanged();
    partial void OnInstructorFirstNameChanging(string value);
    partial void OnInstructorFirstNameChanged();
    partial void OnInstructorLastNameChanging(string value);
    partial void OnInstructorLastNameChanged();
    partial void OnInstructorPhoneNumberChanging(string value);
    partial void OnInstructorPhoneNumberChanged();
    #endregion
		
		public Instructor()
		{
			this._NetUser = default(EntityRef<NetUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstructorID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int InstructorID
		{
			get
			{
				return this._InstructorID;
			}
			set
			{
				if ((this._InstructorID != value))
				{
					if (this._NetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnInstructorIDChanging(value);
					this.SendPropertyChanging();
					this._InstructorID = value;
					this.SendPropertyChanged("InstructorID");
					this.OnInstructorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstructorFirstName", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string InstructorFirstName
		{
			get
			{
				return this._InstructorFirstName;
			}
			set
			{
				if ((this._InstructorFirstName != value))
				{
					this.OnInstructorFirstNameChanging(value);
					this.SendPropertyChanging();
					this._InstructorFirstName = value;
					this.SendPropertyChanged("InstructorFirstName");
					this.OnInstructorFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstructorLastName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string InstructorLastName
		{
			get
			{
				return this._InstructorLastName;
			}
			set
			{
				if ((this._InstructorLastName != value))
				{
					this.OnInstructorLastNameChanging(value);
					this.SendPropertyChanging();
					this._InstructorLastName = value;
					this.SendPropertyChanged("InstructorLastName");
					this.OnInstructorLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstructorPhoneNumber", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string InstructorPhoneNumber
		{
			get
			{
				return this._InstructorPhoneNumber;
			}
			set
			{
				if ((this._InstructorPhoneNumber != value))
				{
					this.OnInstructorPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._InstructorPhoneNumber = value;
					this.SendPropertyChanged("InstructorPhoneNumber");
					this.OnInstructorPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NetUser_Instructor", Storage="_NetUser", ThisKey="InstructorID", OtherKey="UserID", IsForeignKey=true)]
		public NetUser NetUser
		{
			get
			{
				return this._NetUser.Entity;
			}
			set
			{
				NetUser previousValue = this._NetUser.Entity;
				if (((previousValue != value) 
							|| (this._NetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NetUser.Entity = null;
						previousValue.Instructor = null;
					}
					this._NetUser.Entity = value;
					if ((value != null))
					{
						value.Instructor = this;
						this._InstructorID = value.UserID;
					}
					else
					{
						this._InstructorID = default(int);
					}
					this.SendPropertyChanged("NetUser");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Section")]
	public partial class Section : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SectionID;
		
		private string _SectionName;
		
		private System.DateTime _SectionStartDate;
		
		private int _Member_ID;
		
		private int _Instructor_ID;
		
		private decimal _SectionFee;
		
		private EntityRef<Member> _Member;
		
		private EntityRef<NetUser> _NetUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSectionIDChanging(int value);
    partial void OnSectionIDChanged();
    partial void OnSectionNameChanging(string value);
    partial void OnSectionNameChanged();
    partial void OnSectionStartDateChanging(System.DateTime value);
    partial void OnSectionStartDateChanged();
    partial void OnMember_IDChanging(int value);
    partial void OnMember_IDChanged();
    partial void OnInstructor_IDChanging(int value);
    partial void OnInstructor_IDChanged();
    partial void OnSectionFeeChanging(decimal value);
    partial void OnSectionFeeChanged();
    #endregion
		
		public Section()
		{
			this._Member = default(EntityRef<Member>);
			this._NetUser = default(EntityRef<NetUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SectionID
		{
			get
			{
				return this._SectionID;
			}
			set
			{
				if ((this._SectionID != value))
				{
					this.OnSectionIDChanging(value);
					this.SendPropertyChanging();
					this._SectionID = value;
					this.SendPropertyChanged("SectionID");
					this.OnSectionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionName", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string SectionName
		{
			get
			{
				return this._SectionName;
			}
			set
			{
				if ((this._SectionName != value))
				{
					this.OnSectionNameChanging(value);
					this.SendPropertyChanging();
					this._SectionName = value;
					this.SendPropertyChanged("SectionName");
					this.OnSectionNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionStartDate", DbType="DateTime NOT NULL")]
		public System.DateTime SectionStartDate
		{
			get
			{
				return this._SectionStartDate;
			}
			set
			{
				if ((this._SectionStartDate != value))
				{
					this.OnSectionStartDateChanging(value);
					this.SendPropertyChanging();
					this._SectionStartDate = value;
					this.SendPropertyChanged("SectionStartDate");
					this.OnSectionStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Member_ID", DbType="Int NOT NULL")]
		public int Member_ID
		{
			get
			{
				return this._Member_ID;
			}
			set
			{
				if ((this._Member_ID != value))
				{
					if (this._Member.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMember_IDChanging(value);
					this.SendPropertyChanging();
					this._Member_ID = value;
					this.SendPropertyChanged("Member_ID");
					this.OnMember_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Instructor_ID", DbType="Int NOT NULL")]
		public int Instructor_ID
		{
			get
			{
				return this._Instructor_ID;
			}
			set
			{
				if ((this._Instructor_ID != value))
				{
					if (this._NetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnInstructor_IDChanging(value);
					this.SendPropertyChanging();
					this._Instructor_ID = value;
					this.SendPropertyChanged("Instructor_ID");
					this.OnInstructor_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionFee", DbType="Money NOT NULL")]
		public decimal SectionFee
		{
			get
			{
				return this._SectionFee;
			}
			set
			{
				if ((this._SectionFee != value))
				{
					this.OnSectionFeeChanging(value);
					this.SendPropertyChanging();
					this._SectionFee = value;
					this.SendPropertyChanged("SectionFee");
					this.OnSectionFeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_Section", Storage="_Member", ThisKey="Member_ID", OtherKey="Member_UserID", IsForeignKey=true)]
		public Member Member
		{
			get
			{
				return this._Member.Entity;
			}
			set
			{
				Member previousValue = this._Member.Entity;
				if (((previousValue != value) 
							|| (this._Member.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Member.Entity = null;
						previousValue.Sections.Remove(this);
					}
					this._Member.Entity = value;
					if ((value != null))
					{
						value.Sections.Add(this);
						this._Member_ID = value.Member_UserID;
					}
					else
					{
						this._Member_ID = default(int);
					}
					this.SendPropertyChanged("Member");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NetUser_Section", Storage="_NetUser", ThisKey="Instructor_ID", OtherKey="UserID", IsForeignKey=true)]
		public NetUser NetUser
		{
			get
			{
				return this._NetUser.Entity;
			}
			set
			{
				NetUser previousValue = this._NetUser.Entity;
				if (((previousValue != value) 
							|| (this._NetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NetUser.Entity = null;
						previousValue.Sections.Remove(this);
					}
					this._NetUser.Entity = value;
					if ((value != null))
					{
						value.Sections.Add(this);
						this._Instructor_ID = value.UserID;
					}
					else
					{
						this._Instructor_ID = default(int);
					}
					this.SendPropertyChanged("NetUser");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Member")]
	public partial class Member : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Member_UserID;
		
		private string _MemberFirstName;
		
		private string _MemberLastName;
		
		private System.DateTime _MemberDateJoined;
		
		private string _MemberPhoneNumber;
		
		private string _MemberEmail;
		
		private EntitySet<Section> _Sections;
		
		private EntityRef<NetUser> _NetUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMember_UserIDChanging(int value);
    partial void OnMember_UserIDChanged();
    partial void OnMemberFirstNameChanging(string value);
    partial void OnMemberFirstNameChanged();
    partial void OnMemberLastNameChanging(string value);
    partial void OnMemberLastNameChanged();
    partial void OnMemberDateJoinedChanging(System.DateTime value);
    partial void OnMemberDateJoinedChanged();
    partial void OnMemberPhoneNumberChanging(string value);
    partial void OnMemberPhoneNumberChanged();
    partial void OnMemberEmailChanging(string value);
    partial void OnMemberEmailChanged();
    #endregion
		
		public Member()
		{
			this._Sections = new EntitySet<Section>(new Action<Section>(this.attach_Sections), new Action<Section>(this.detach_Sections));
			this._NetUser = default(EntityRef<NetUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Member_UserID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Member_UserID
		{
			get
			{
				return this._Member_UserID;
			}
			set
			{
				if ((this._Member_UserID != value))
				{
					if (this._NetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMember_UserIDChanging(value);
					this.SendPropertyChanging();
					this._Member_UserID = value;
					this.SendPropertyChanged("Member_UserID");
					this.OnMember_UserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberFirstName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string MemberFirstName
		{
			get
			{
				return this._MemberFirstName;
			}
			set
			{
				if ((this._MemberFirstName != value))
				{
					this.OnMemberFirstNameChanging(value);
					this.SendPropertyChanging();
					this._MemberFirstName = value;
					this.SendPropertyChanged("MemberFirstName");
					this.OnMemberFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberLastName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string MemberLastName
		{
			get
			{
				return this._MemberLastName;
			}
			set
			{
				if ((this._MemberLastName != value))
				{
					this.OnMemberLastNameChanging(value);
					this.SendPropertyChanging();
					this._MemberLastName = value;
					this.SendPropertyChanged("MemberLastName");
					this.OnMemberLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberDateJoined", DbType="DateTime NOT NULL")]
		public System.DateTime MemberDateJoined
		{
			get
			{
				return this._MemberDateJoined;
			}
			set
			{
				if ((this._MemberDateJoined != value))
				{
					this.OnMemberDateJoinedChanging(value);
					this.SendPropertyChanging();
					this._MemberDateJoined = value;
					this.SendPropertyChanged("MemberDateJoined");
					this.OnMemberDateJoinedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberPhoneNumber", DbType="NVarChar(12) NOT NULL", CanBeNull=false)]
		public string MemberPhoneNumber
		{
			get
			{
				return this._MemberPhoneNumber;
			}
			set
			{
				if ((this._MemberPhoneNumber != value))
				{
					this.OnMemberPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._MemberPhoneNumber = value;
					this.SendPropertyChanged("MemberPhoneNumber");
					this.OnMemberPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberEmail", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string MemberEmail
		{
			get
			{
				return this._MemberEmail;
			}
			set
			{
				if ((this._MemberEmail != value))
				{
					this.OnMemberEmailChanging(value);
					this.SendPropertyChanging();
					this._MemberEmail = value;
					this.SendPropertyChanged("MemberEmail");
					this.OnMemberEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_Section", Storage="_Sections", ThisKey="Member_UserID", OtherKey="Member_ID")]
		public EntitySet<Section> Sections
		{
			get
			{
				return this._Sections;
			}
			set
			{
				this._Sections.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NetUser_Member", Storage="_NetUser", ThisKey="Member_UserID", OtherKey="UserID", IsForeignKey=true)]
		public NetUser NetUser
		{
			get
			{
				return this._NetUser.Entity;
			}
			set
			{
				NetUser previousValue = this._NetUser.Entity;
				if (((previousValue != value) 
							|| (this._NetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NetUser.Entity = null;
						previousValue.Member = null;
					}
					this._NetUser.Entity = value;
					if ((value != null))
					{
						value.Member = this;
						this._Member_UserID = value.UserID;
					}
					else
					{
						this._Member_UserID = default(int);
					}
					this.SendPropertyChanged("NetUser");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Sections(Section entity)
		{
			this.SendPropertyChanging();
			entity.Member = this;
		}
		
		private void detach_Sections(Section entity)
		{
			this.SendPropertyChanging();
			entity.Member = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NetUser")]
	public partial class NetUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _UserName;
		
		private string _UserPassword;
		
		private string _UserType;
		
		private EntityRef<Instructor> _Instructor;
		
		private EntitySet<Section> _Sections;
		
		private EntityRef<Member> _Member;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnUserPasswordChanging(string value);
    partial void OnUserPasswordChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    #endregion
		
		public NetUser()
		{
			this._Instructor = default(EntityRef<Instructor>);
			this._Sections = new EntitySet<Section>(new Action<Section>(this.attach_Sections), new Action<Section>(this.detach_Sections));
			this._Member = default(EntityRef<Member>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPassword", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string UserPassword
		{
			get
			{
				return this._UserPassword;
			}
			set
			{
				if ((this._UserPassword != value))
				{
					this.OnUserPasswordChanging(value);
					this.SendPropertyChanging();
					this._UserPassword = value;
					this.SendPropertyChanged("UserPassword");
					this.OnUserPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NetUser_Instructor", Storage="_Instructor", ThisKey="UserID", OtherKey="InstructorID", IsUnique=true, IsForeignKey=false)]
		public Instructor Instructor
		{
			get
			{
				return this._Instructor.Entity;
			}
			set
			{
				Instructor previousValue = this._Instructor.Entity;
				if (((previousValue != value) 
							|| (this._Instructor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Instructor.Entity = null;
						previousValue.NetUser = null;
					}
					this._Instructor.Entity = value;
					if ((value != null))
					{
						value.NetUser = this;
					}
					this.SendPropertyChanged("Instructor");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NetUser_Section", Storage="_Sections", ThisKey="UserID", OtherKey="Instructor_ID")]
		public EntitySet<Section> Sections
		{
			get
			{
				return this._Sections;
			}
			set
			{
				this._Sections.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NetUser_Member", Storage="_Member", ThisKey="UserID", OtherKey="Member_UserID", IsUnique=true, IsForeignKey=false)]
		public Member Member
		{
			get
			{
				return this._Member.Entity;
			}
			set
			{
				Member previousValue = this._Member.Entity;
				if (((previousValue != value) 
							|| (this._Member.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Member.Entity = null;
						previousValue.NetUser = null;
					}
					this._Member.Entity = value;
					if ((value != null))
					{
						value.NetUser = this;
					}
					this.SendPropertyChanged("Member");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Sections(Section entity)
		{
			this.SendPropertyChanging();
			entity.NetUser = this;
		}
		
		private void detach_Sections(Section entity)
		{
			this.SendPropertyChanging();
			entity.NetUser = null;
		}
	}
}
#pragma warning restore 1591
