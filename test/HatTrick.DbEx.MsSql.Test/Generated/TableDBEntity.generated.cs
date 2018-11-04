using System;
using System.Collections.Generic;

namespace DataService
{
	using Data;
    using Data.dbo;
    using HatTrick.DbEx.Sql.Executor;
    using HatTrick.DbEx.Sql.Expression;
    using HatTrick.DbEx.Sql.Mapper;

    public static partial class dbo
	{
		#region address
		public partial class AddressEntity : EntityExpression<Address>
		{
			#region internals
			private FieldExpression<int> _id;
			private FieldExpression<AddressType> _addressType;
			private FieldExpression<string> _line1;
			private FieldExpression<string> _line2;
			private FieldExpression<string> _city;
			private FieldExpression<string> _state;
			private FieldExpression<string> _zip;
			private FieldExpression<DateTime> _dateCreated;
			private FieldExpression<DateTime> _dateUpdated;
			#endregion

			#region interface properties
			public FieldExpression<int> Id { get { return _id; } }
			public FieldExpression<AddressType> AddressType { get { return _addressType; } }
			public FieldExpression<string> Line1 { get { return _line1; } }
			public FieldExpression<string> Line2 { get { return _line2; } }
			public FieldExpression<string> City { get { return _city; } }
			public FieldExpression<string> State { get { return _state; } }
			public FieldExpression<string> Zip { get { return _zip; } }
			public FieldExpression<DateTime> DateCreated { get { return _dateCreated; } }
			public FieldExpression<DateTime> DateUpdated { get { return _dateUpdated; } }
            #endregion

            #region constructors
            public AddressEntity(SchemaExpression schema, string entityName) : this(schema, entityName, null)
            {

            }
            public AddressEntity(SchemaExpression schema, string entityName, string aliasName) : base(schema, entityName, aliasName)
			{
				_id = new FieldExpression<int>(this, "Id", 4);
				_addressType = new FieldExpression<AddressType>(this, "AddressType", 4);
				_line1 = new FieldExpression<string>(this, "Line1", 50);
				_line2 = new FieldExpression<string>(this, "Line2", 50);
				_city = new FieldExpression<string>(this, "City", 60);
				_state = new FieldExpression<string>(this, "State", 2);
				_zip = new FieldExpression<string>(this, "Zip", 10);
				_dateCreated = new FieldExpression<DateTime>(this, "DateCreated", 8);
				_dateUpdated = new FieldExpression<DateTime>(this, "DateUpdated", 8);
			}
			#endregion

			#region methods
			public override SelectExpressionSet GetInclusiveSelectExpression()
			{
				SelectExpressionSet select = null;
           		select &= _id;
           		select &= _addressType;
           		select &= _line1;
           		select &= _line2;
           		select &= _city;
           		select &= _state;
           		select &= _zip;
           		select &= _dateCreated;
           		select &= _dateUpdated;
				return select;
			}

            public override InsertExpressionSet GetInclusiveInsertExpression(Address address)
			{
				InsertExpressionSet expr = null;
				expr &= _addressType.Insert(address.AddressType);
				expr &= _line1.Insert(address.Line1);
				expr &= _line2.Insert(address.Line2);
				expr &= _city.Insert(address.City);
				expr &= _state.Insert(address.State);
				expr &= _zip.Insert(address.Zip);
				expr &= _dateCreated.Insert(address.DateCreated);
				expr &= _dateUpdated.Insert(address.DateUpdated);
				return expr;
			}

			public override AssignmentExpressionSet GetAssignmentExpression(Address from, Address to)
			{
				AssignmentExpressionSet expr = null;
				if (from.AddressType != to.AddressType) { expr &= _addressType.Set(to.AddressType); }
				if (from.Line1 != to.Line1) { expr &= _line1.Set(to.Line1); }
				if (from.Line2 != to.Line2) { expr &= _line2.Set(to.Line2); }
				if (from.City != to.City) { expr &= _city.Set(to.City); }
				if (from.State != to.State) { expr &= _state.Set(to.State); }
				if (from.Zip != to.Zip) { expr &= _zip.Set(to.Zip); }
				expr &= _dateUpdated.Set(DateTime.UtcNow);
				return expr;
			}

            public override void FillObject(SqlStatementExecutionResultSet.Row row, Address address, IValueMapper mapper)
            {
				address.Id = mapper.Map<int>("Address.Id", row.Fields[0]);
                address.AddressType = (AddressType)mapper.Map<int>("Address.AddressType", row.Fields[1]);
				address.Line1 = mapper.Map<string>("Address.Line1", row.Fields[2]);
				address.Line2 = mapper.Map<string>("Address.Line2", row.Fields[3]);
				address.City = mapper.Map<string>("Address.City", row.Fields[4]);
				address.State = mapper.Map<string>("Address.State", row.Fields[5]);
				address.Zip = mapper.Map<string>("Address.Zip", row.Fields[6]);
				address.DateCreated = mapper.Map<DateTime>("Address.DateCreated", row.Fields[7]);
				address.DateUpdated = mapper.Map<DateTime>("Address.DateUpdated", row.Fields[8]);
			}

			protected bool IsPersistSafe(Address address, out List<string> validationMessages)
			{
				validationMessages = new List<string>();
				if (address.Line1 == null) { validationMessages.Add("Line1 cannot be empty."); }
				if (address.Line1 != null && address.Line1.Length > 50) { validationMessages.Add("Line1 cannot be longer than 50 characters."); }
				if (address.Line2 != null && address.Line2.Length > 50) { validationMessages.Add("Line2 cannot be longer than 50 characters."); }
				if (address.City == null) { validationMessages.Add("City cannot be empty."); }
				if (address.City != null && address.City.Length > 60) { validationMessages.Add("City cannot be longer than 60 characters."); }
				if (address.State == null) { validationMessages.Add("State cannot be empty."); }
				if (address.State != null && address.State.Length > 2) { validationMessages.Add("State cannot be longer than 2 characters."); }
				if (address.Zip == null) { validationMessages.Add("Zip cannot be empty."); }
				if (address.Zip != null && address.Zip.Length > 10) { validationMessages.Add("Zip cannot be longer than 10 characters."); }
				if (address.DateCreated == default(DateTime)) { validationMessages.Add("Date Created must contain a value."); }
				if (address.DateUpdated == default(DateTime)) { validationMessages.Add("Date Updated must contain a value."); }
				return validationMessages.Count == 0;
			}
			#endregion
		}
		#endregion
		#region person
		public partial class PersonEntity : EntityExpression
		{
			#region internals
			private FieldExpression<int> _id;
			private FieldExpression<string> _firstName;
			private FieldExpression<string> _lastName;
			private FieldExpression<DateTime> _birthDate;
			private FieldExpression<DateTime> _dateCreated;
			private FieldExpression<DateTime> _dateUpdated;
			#endregion

			#region interface properties
			public FieldExpression<int> Id { get { return _id; } }
			public FieldExpression<string> FirstName { get { return _firstName; } }
			public FieldExpression<string> LastName { get { return _lastName; } }
			public FieldExpression<DateTime> BirthDate { get { return _birthDate; } }
			public FieldExpression<DateTime> DateCreated { get { return _dateCreated; } }
			public FieldExpression<DateTime> DateUpdated { get { return _dateUpdated; } }
            #endregion

            #region constructors
            public PersonEntity(SchemaExpression schema, string entityName) : this(schema, entityName, null)
            {

            }
            public PersonEntity(SchemaExpression schema, string entityName, string aliasName) : base(schema, entityName, aliasName)
			{
				_id = new FieldExpression<int>(this, "Id", 4);
				_firstName = new FieldExpression<string>(this, "FirstName", 20);
				_lastName = new FieldExpression<string>(this, "LastName", 20);
				_birthDate = new FieldExpression<DateTime>(this, "BirthDate", 8);
				_dateCreated = new FieldExpression<DateTime>(this, "DateCreated", 8);
				_dateUpdated = new FieldExpression<DateTime>(this, "DateUpdated", 8);
			}
			#endregion

			#region methods
			public override SelectExpressionSet GetInclusiveSelectExpression()
			{
				SelectExpressionSet select = null;
           		select &= _id;
           		select &= _firstName;
           		select &= _lastName;
           		select &= _birthDate;
           		select &= _dateCreated;
           		select &= _dateUpdated;
				return select;
			}

			public InsertExpressionSet GetInclusiveInsertExpression(Person person)
			{
				InsertExpressionSet expr = null;
				expr &= _firstName.Insert(person.FirstName);
				expr &= _lastName.Insert(person.LastName);
				expr &= _birthDate.Insert(person.BirthDate);
				expr &= _dateCreated.Insert(person.DateCreated);
				expr &= _dateUpdated.Insert(person.DateUpdated);
				return expr;
			}

			public AssignmentExpressionSet GetAssignmentExpression(Person from, Person to)
			{
				AssignmentExpressionSet expr = null;
				if (from.FirstName != to.FirstName) { expr &= _firstName.Set(to.FirstName); }
				if (from.LastName != to.LastName) { expr &= _lastName.Set(to.LastName); }
				if (from.BirthDate != to.BirthDate) { expr &= _birthDate.Set(to.BirthDate); }
				expr &= _dateUpdated.Set(DateTime.UtcNow);
				return expr;
			}
		
			public void FillObject(Person person, object[] values)
			{
				//if the column allows null, do the dbnull check, else just cast in..???
				person.Id = (int)values[0];
				person.FirstName = (string)values[1];
				person.LastName = (string)values[2];
				person.BirthDate = DateTime.SpecifyKind((DateTime)values[3], DateTimeKind.Utc);
				person.DateCreated = DateTime.SpecifyKind((DateTime)values[4], DateTimeKind.Utc);
				person.DateUpdated = DateTime.SpecifyKind((DateTime)values[5], DateTimeKind.Utc);
			}

			protected bool IsPersistSafe(Person person, out List<string> validationMessages)
			{
				validationMessages = new List<string>();
				if (person.FirstName == null) { validationMessages.Add("First Name cannot be empty."); }
				if (person.FirstName != null && person.FirstName.Length > 20) { validationMessages.Add("First Name cannot be longer than 20 characters."); }
				if (person.LastName == null) { validationMessages.Add("Last Name cannot be empty."); }
				if (person.LastName != null && person.LastName.Length > 20) { validationMessages.Add("Last Name cannot be longer than 20 characters."); }
				if (person.BirthDate == default(DateTime)) { validationMessages.Add("Birth Date must contain a value."); }
				if (person.DateCreated == default(DateTime)) { validationMessages.Add("Date Created must contain a value."); }
				if (person.DateUpdated == default(DateTime)) { validationMessages.Add("Date Updated must contain a value."); }
				return validationMessages.Count == 0;
			}
			#endregion
		}
		#endregion
		#region person_ address
		public partial class Person_AddressEntity : EntityExpression<Person_Address>
		{
			#region internals
			private FieldExpression<int> _id;
			private FieldExpression<int> _personId;
			private FieldExpression<int> _addressId;
			private FieldExpression<DateTime> _dateCreated;
			#endregion

			#region interface properties
			public FieldExpression<int> Id { get { return _id; } }
			public FieldExpression<int> PersonId { get { return _personId; } }
			public FieldExpression<int> AddressId { get { return _addressId; } }
			public FieldExpression<DateTime> DateCreated { get { return _dateCreated; } }
            #endregion

            #region constructors
            public Person_AddressEntity(SchemaExpression schema, string entityName) : this(schema, entityName, null)
            {

            }
            public Person_AddressEntity(SchemaExpression schema, string entityName, string aliasName) : base(schema, entityName, aliasName)
			{
				_id = new FieldExpression<int>(this, "Id", 4);
				_personId = new FieldExpression<int>(this, "PersonId", 4);
				_addressId = new FieldExpression<int>(this, "AddressId", 4);
				_dateCreated = new FieldExpression<DateTime>(this, "DateCreated", 8);
			}
			#endregion

			#region methods

			public override SelectExpressionSet GetInclusiveSelectExpression()
			{
				SelectExpressionSet select = null;
           		select &= _id;
           		select &= _personId;
           		select &= _addressId;
           		select &= _dateCreated;
				return select;
			}

            public override InsertExpressionSet GetInclusiveInsertExpression(Person_Address person_Address)
			{
				InsertExpressionSet expr = null;
				expr &= _personId.Insert(person_Address.PersonId);
				expr &= _addressId.Insert(person_Address.AddressId);
				expr &= _dateCreated.Insert(person_Address.DateCreated);
				return expr;
			}

			public override AssignmentExpressionSet GetAssignmentExpression(Person_Address from, Person_Address to)
			{
				AssignmentExpressionSet expr = null;
				if (from.PersonId != to.PersonId) { expr &= _personId.Set(to.PersonId); }
				if (from.AddressId != to.AddressId) { expr &= _addressId.Set(to.AddressId); }
				return expr;
			}
		
            public override void FillObject(SqlStatementExecutionResultSet.Row row, Person_Address person_Address, IValueMapper mapper)
            {
                person_Address.Id = mapper.Map<int>("Person_Address.Id", row.Fields[0]);
                person_Address.PersonId = mapper.Map<int>("Person_Address.PersonId", row.Fields[1]);
                person_Address.AddressId = mapper.Map<int>("Person_Address.AddressId", row.Fields[2]);
                person_Address.DateCreated = mapper.Map<DateTime>("Person_Address.DateCreated", row.Fields[3]);
            }

            protected bool IsPersistSafe(Person_Address person_Address, out List<string> validationMessages)
			{
				validationMessages = new List<string>();
				if (person_Address.DateCreated == default(DateTime)) { validationMessages.Add("Date Created must contain a value."); }
				return validationMessages.Count == 0;
			}
			#endregion
		}
		#endregion
		#region product
		public partial class ProductEntity : EntityExpression<Product>
		{
			#region internals
			private FieldExpression<int> _id;
			private FieldExpression<string> _name;
			private FieldExpression<string> _description;
			private FieldExpression<decimal> _price;
			private FieldExpression<int> _quantity;
			private FieldExpression<DateTime> _dateCreated;
			private FieldExpression<DateTime> _dateUpdated;
			#endregion

			#region interface properties
			public FieldExpression<int> Id { get { return _id; } }
			public FieldExpression<string> Name { get { return _name; } }
			public FieldExpression<string> Description { get { return _description; } }
			public FieldExpression<decimal> Price { get { return _price; } }
			public FieldExpression<int> Quantity { get { return _quantity; } }
			public FieldExpression<DateTime> DateCreated { get { return _dateCreated; } }
			public FieldExpression<DateTime> DateUpdated { get { return _dateUpdated; } }
            #endregion

            #region constructors
            public ProductEntity(SchemaExpression schema, string entityName) : this(schema, entityName, null)
            {

            }

            public ProductEntity(SchemaExpression schema, string entityName, string aliasName) : base(schema, entityName, aliasName)
			{
				_id = new FieldExpression<int>(this, "Id", 4);
				_name = new FieldExpression<string>(this, "Name", 80);
				_description = new FieldExpression<string>(this, "Description", 300);
				_price = new FieldExpression<decimal>(this, "Price", 9);
				_quantity = new FieldExpression<int>(this, "Quantity", 4);
				_dateCreated = new FieldExpression<DateTime>(this, "DateCreated", 8);
				_dateUpdated = new FieldExpression<DateTime>(this, "DateUpdated", 8);
			}
			#endregion

			#region methods
			public override SelectExpressionSet GetInclusiveSelectExpression()
			{
				SelectExpressionSet select = null;
           		select &= _id;
           		select &= _name;
           		select &= _description;
           		select &= _price;
           		select &= _quantity;
           		select &= _dateCreated;
           		select &= _dateUpdated;
				return select;
			}

			public override InsertExpressionSet GetInclusiveInsertExpression(Product product)
			{
				InsertExpressionSet expr = null;
				expr &= _name.Insert(product.Name);
				expr &= _description.Insert(product.Description);
				expr &= _price.Insert(product.Price);
				expr &= _quantity.Insert(product.Quantity);
				expr &= _dateCreated.Insert(product.DateCreated);
				expr &= _dateUpdated.Insert(product.DateUpdated);
				return expr;
			}

			public override AssignmentExpressionSet GetAssignmentExpression(Product from, Product to)
			{
				AssignmentExpressionSet expr = null;
				if (from.Name != to.Name) { expr &= _name.Set(to.Name); }
				if (from.Description != to.Description) { expr &= _description.Set(to.Description); }
				if (from.Price != to.Price) { expr &= _price.Set(to.Price); }
				if (from.Quantity != to.Quantity) { expr &= _quantity.Set(to.Quantity); }
				expr &= _dateUpdated.Set(DateTime.UtcNow);
				return expr;
			}
		
			public override void FillObject(SqlStatementExecutionResultSet.Row row, Product product, IValueMapper mapper)
            {
                product.Id = mapper.Map<int>("Product.Id", row.Fields[0]);
                product.Name = mapper.Map<string>("Product.Name", row.Fields[1]);
                product.Description = mapper.Map<string>("Product.Description", row.Fields[2]);
                product.Price = mapper.Map<decimal>("Product.Price", row.Fields[3]);
                product.Quantity = mapper.Map<int>("Product.Quantity", row.Fields[4]);
                product.DateCreated = mapper.Map<DateTime>("Product.DateCreated", row.Fields[5]);
                product.DateUpdated = mapper.Map<DateTime>("Product.IdDateUpdted", row.Fields[6]);
            }

            protected bool IsPersistSafe(Product product, out List<string> validationMessages)
			{
				validationMessages = new List<string>();
				if (product.Name == null) { validationMessages.Add("Name cannot be empty."); }
				if (product.Name != null && product.Name.Length > 80) { validationMessages.Add("Name cannot be longer than 80 characters."); }
				if (product.Description != null && product.Description.Length > 300) { validationMessages.Add("Description cannot be longer than 300 characters."); }
				if (product.DateCreated == default(DateTime)) { validationMessages.Add("Date Created must contain a value."); }
				if (product.DateUpdated == default(DateTime)) { validationMessages.Add("Date Updated must contain a value."); }
				return validationMessages.Count == 0;
			}
			#endregion
		}
		#endregion
		#region purchase
		public partial class PurchaseEntity : EntityExpression<Purchase>
		{
			#region internals
			private FieldExpression<int> _id;
			private FieldExpression<int> _personId;
			private FieldExpression<int> _productId;
			private FieldExpression<decimal> _purchasePrice;
			private FieldExpression<DateTime> _purchaseDate;
			private FieldExpression<DateTime> _dateCreated;
			#endregion

			#region interface properties
			public FieldExpression<int> Id { get { return _id; } }
			public FieldExpression<int> PersonId { get { return _personId; } }
			public FieldExpression<int> ProductId { get { return _productId; } }
			public FieldExpression<decimal> PurchasePrice { get { return _purchasePrice; } }
			public FieldExpression<DateTime> PurchaseDate { get { return _purchaseDate; } }
			public FieldExpression<DateTime> DateCreated { get { return _dateCreated; } }
            #endregion

            #region constructors
            public PurchaseEntity(SchemaExpression schema, string entityName) : this(schema, entityName, null)
            {

            }
            public PurchaseEntity(SchemaExpression schema, string entityName, string aliasName) : base(schema, entityName, aliasName)
			{
				_id = new FieldExpression<int>(this, "Id", 4);
				_personId = new FieldExpression<int>(this, "PersonId", 4);
				_productId = new FieldExpression<int>(this, "ProductId", 4);
				_purchasePrice = new FieldExpression<decimal>(this, "PurchasePrice", 9);
				_purchaseDate = new FieldExpression<DateTime>(this, "PurchaseDate", 8);
				_dateCreated = new FieldExpression<DateTime>(this, "DateCreated", 8);
			}
			#endregion

			#region methods
			
			public override SelectExpressionSet GetInclusiveSelectExpression()
			{
				SelectExpressionSet select = null;
           		select &= _id;
           		select &= _personId;
           		select &= _productId;
           		select &= _purchasePrice;
           		select &= _purchaseDate;
           		select &= _dateCreated;
				return select;
			}

			public override InsertExpressionSet GetInclusiveInsertExpression(Purchase purchase)
			{
				InsertExpressionSet expr = null;
				expr &= _personId.Insert(purchase.PersonId);
				expr &= _productId.Insert(purchase.ProductId);
				expr &= _purchasePrice.Insert(purchase.PurchasePrice);
				expr &= _purchaseDate.Insert(purchase.PurchaseDate);
				expr &= _dateCreated.Insert(purchase.DateCreated);
				return expr;
			}

			public override AssignmentExpressionSet GetAssignmentExpression(Purchase from, Purchase to)
			{
				AssignmentExpressionSet expr = null;
				if (from.PersonId != to.PersonId) { expr &= _personId.Set(to.PersonId); }
				if (from.ProductId != to.ProductId) { expr &= _productId.Set(to.ProductId); }
				if (from.PurchasePrice != to.PurchasePrice) { expr &= _purchasePrice.Set(to.PurchasePrice); }
				if (from.PurchaseDate != to.PurchaseDate) { expr &= _purchaseDate.Set(to.PurchaseDate); }
				return expr;
			}
		
            public override void FillObject(SqlStatementExecutionResultSet.Row row, Purchase purchase, IValueMapper mapper)
            {
                purchase.Id = mapper.Map<int>("Purchase.Id", row.Fields[0]);
                purchase.PersonId = mapper.Map<int>("Purchase.PersonId", row.Fields[1]);
                purchase.ProductId = mapper.Map<int>("Purchase.ProductId", row.Fields[2]);
                purchase.PurchasePrice = mapper.Map<decimal>("Purchase.PurchasePrice", row.Fields[3]);
                purchase.PurchaseDate = mapper.Map<DateTime>("Purchase.PurchaseDate", row.Fields[4]);
                purchase.DateCreated = mapper.Map<DateTime>("Purchase.DateCreated", row.Fields[5]);
            }

            protected bool IsPersistSafe(Purchase purchase, out List<string> validationMessages)
			{
				validationMessages = new List<string>();
				if (purchase.PurchaseDate == default(DateTime)) { validationMessages.Add("Purchase Date must contain a value."); }
				if (purchase.DateCreated == default(DateTime)) { validationMessages.Add("Date Created must contain a value."); }
				return validationMessages.Count == 0;
			}
			#endregion
		}
		#endregion
	}
}
namespace DataService
{
    using Data.sec;
    using HatTrick.DbEx.Sql.Executor;
    using HatTrick.DbEx.Sql.Expression;
    using HatTrick.DbEx.Sql.Mapper;

    public static partial class sec
	{
		#region person
		public partial class PersonEntity : EntityExpression<Person>
		{
			#region internals
			private static volatile FieldExpression<int> _id;
			private static volatile FieldExpression<long> _personId;
			private static volatile FieldExpression<string> _sSN;
			private static volatile FieldExpression<DateTime> _dateCreated;
			private static volatile FieldExpression<DateTime> _dateUpdated;
			#endregion

			#region interface properties
			public FieldExpression<int> Id { get { return _id; } }
			public FieldExpression<long> PersonId { get { return _personId; } }
			public FieldExpression<string> SSN { get { return _sSN; } }
			public FieldExpression<DateTime> DateCreated { get { return _dateCreated; } }
			public FieldExpression<DateTime> DateUpdated { get { return _dateUpdated; } }
            #endregion

            #region constructors
            public PersonEntity(SchemaExpression schema, string entityName) : this(schema, entityName, null)
            {

            }
            public PersonEntity(SchemaExpression schema, string entityName, string aliasName) : base(schema, entityName, aliasName)
			{
				_id = new FieldExpression<int>(this, "Id", 4);
				_personId = new FieldExpression<long>(this, "PersonId", 8);
				_sSN = new FieldExpression<string>(this, "SSN", 9);
				_dateCreated = new FieldExpression<DateTime>(this, "DateCreated", 8);
				_dateUpdated = new FieldExpression<DateTime>(this, "DateUpdated", 8);
			}
			#endregion

			#region methods
			
			public override SelectExpressionSet GetInclusiveSelectExpression()
			{
				SelectExpressionSet select = null;
           		select &= _id;
           		select &= _personId;
           		select &= _sSN;
           		select &= _dateCreated;
           		select &= _dateUpdated;
				return select;
			}

			public override InsertExpressionSet GetInclusiveInsertExpression(Person person)
			{
				InsertExpressionSet expr = null;
				expr &= _personId.Insert(person.PersonId);
				expr &= _sSN.Insert(person.SSN);
				expr &= _dateCreated.Insert(person.DateCreated);
				expr &= _dateUpdated.Insert(person.DateUpdated);
				return expr;
			}

			public override AssignmentExpressionSet GetAssignmentExpression(Person from, Person to)
			{
				AssignmentExpressionSet expr = null;
				if (from.PersonId != to.PersonId) { expr &= _personId.Set(to.PersonId); }
				if (from.SSN != to.SSN) { expr &= _sSN.Set(to.SSN); }
				expr &= _dateUpdated.Set(DateTime.UtcNow);
				return expr;
			}
		
            public override void FillObject(SqlStatementExecutionResultSet.Row data, Person person, IValueMapper valueMapper)
            {
                person.Id = valueMapper.Map<int>("Person.Id", data.Fields[0].Value);
                person.PersonId = valueMapper.Map<int>("Person.PersonId", data.Fields[1].Value);
                person.SSN = valueMapper.Map<string>("Person.SSN", data.Fields[2].Value);
                person.DateCreated = valueMapper.Map<DateTime>("Person.DateCreated", data.Fields[3].Value);
                person.DateUpdated = valueMapper.Map<DateTime>("Person.DateUpdated", data.Fields[4].Value);
            }

            protected bool IsPersistSafe(Person person, out List<string> validationMessages)
			{
				validationMessages = new List<string>();
				if (person.SSN == null) { validationMessages.Add("S S N cannot be empty."); }
				if (person.SSN != null && person.SSN.Length > 9) { validationMessages.Add("S S N cannot be longer than 9 characters."); }
				if (person.DateCreated == default(DateTime)) { validationMessages.Add("Date Created must contain a value."); }
				if (person.DateUpdated == default(DateTime)) { validationMessages.Add("Date Updated must contain a value."); }
				return validationMessages.Count == 0;
			}
			#endregion
		}
		#endregion
	}
}
