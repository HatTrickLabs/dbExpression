//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using HatTrick.DbEx.Sql.Expression;
using HatTrick.DbEx.Sql;
#nullable enable
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace DbEx.dboData
{
    #region access audit log

    public partial class AccessAuditLog : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual int PersonId { get; set; }
        public virtual int AccessResult { get; set; }
        public virtual DateTime DateCreated { get; set; }
        #endregion

        #region constructor
        public AccessAuditLog()
        {
        }
        #endregion
    }
    #endregion

    #region address

    public partial class Address : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual MsSql.DocumentationExamples.AddressType? AddressType { get; set; } = null;
        public virtual string Line1 { get; set; } = string.Empty;
        public virtual string? Line2 { get; set; } = null;
        public virtual string City { get; set; } = string.Empty;
        public virtual MsSql.DocumentationExamples.StateType State { get; set; }
        public virtual string Zip { get; set; } = string.Empty;
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateUpdated { get; set; }
        #endregion

        #region constructor
        public Address()
        {
        }
        #endregion
    }
    #endregion

    #region person

    public partial class Person : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; } = string.Empty;
        public virtual string LastName { get; set; } = string.Empty;
        public virtual DateTime? BirthDate { get; set; } = null;
        public virtual MsSql.DocumentationExamples.GenderType GenderType { get; set; }
        public virtual int? CreditLimit { get; set; } = null;
        public virtual int? YearOfLastCreditLimitReview { get; set; } = null;
        public virtual DateTimeOffset RegistrationDate { get; set; }
        public virtual DateTimeOffset? LastLoginDate { get; set; } = null;
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateUpdated { get; set; }
        #endregion

        #region constructor
        public Person()
        {
        }
        #endregion
    }
    #endregion

    #region person address

    public partial class PersonAddress : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual int PersonId { get; set; }
        public virtual int AddressId { get; set; }
        public virtual DateTime DateCreated { get; set; }
        #endregion

        #region constructor
        public PersonAddress()
        {
        }
        #endregion
    }
    #endregion

    #region product

    public partial class Product : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual MsSql.DocumentationExamples.ProductCategoryType? ProductCategoryType { get; set; } = null;
        public virtual string Name { get; set; } = string.Empty;
        public virtual MsSql.DocumentationExamples.ProductDescription? Description { get; set; } = null;
        public virtual double ListPrice { get; set; }
        public virtual double Price { get; set; }
        public virtual double Quantity { get; set; }
        public virtual byte[]? Image { get; set; } = null;
        public virtual decimal? Height { get; set; } = null;
        public virtual decimal? Width { get; set; } = null;
        public virtual decimal? Depth { get; set; } = null;
        public virtual decimal? Weight { get; set; } = null;
        public virtual decimal ShippingWeight { get; set; }
        public virtual TimeSpan? ValidStartTimeOfDayForPurchase { get; set; } = null;
        public virtual TimeSpan? ValidEndTimeOfDayForPurchase { get; set; } = null;
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateUpdated { get; set; }
        #endregion

        #region constructor
        public Product()
        {
        }
        #endregion
    }
    #endregion

    #region purchase

    public partial class Purchase : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual int PersonId { get; set; }
        public virtual string OrderNumber { get; set; } = string.Empty;
        public virtual int TotalPurchaseQuantity { get; set; }
        public virtual double TotalPurchaseAmount { get; set; }
        public virtual DateTime PurchaseDate { get; set; }
        public virtual DateTime? ShipDate { get; set; } = null;
        public virtual DateTime? ExpectedDeliveryDate { get; set; } = null;
        public virtual Guid? TrackingIdentifier { get; set; } = null;
        public virtual MsSql.DocumentationExamples.PaymentMethodType PaymentMethodType { get; set; }
        public virtual MsSql.DocumentationExamples.PaymentSourceType? PaymentSourceType { get; set; } = null;
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateUpdated { get; set; }
        #endregion

        #region constructor
        public Purchase()
        {
        }
        #endregion
    }
    #endregion

    #region purchase line

    public partial class PurchaseLine : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual int PurchaseId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual decimal PurchasePrice { get; set; }
        public virtual int Quantity { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateUpdated { get; set; }
        #endregion

        #region constructor
        public PurchaseLine()
        {
        }
        #endregion
    }
    #endregion

    #region person total purchases view

    public partial class PersonTotalPurchasesView : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual double? TotalAmount { get; set; } = null;
        public virtual int? TotalCount { get; set; } = null;
        #endregion

        #region constructor
        public PersonTotalPurchasesView()
        {
        }
        #endregion
    }
    #endregion

}
namespace DbEx.secData
{
    #region person

    public partial class Person : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual string SocialSecurityNumber { get; set; } = string.Empty;
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateUpdated { get; set; }
        #endregion

        #region constructor
        public Person()
        {
        }
        #endregion
    }
    #endregion

}
namespace DbEx.unit_testData
{
    #region alias
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    public partial class alias : IDbEntity
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    {
        #region interface
        public virtual string? identifier { get; set; } = null;
        public virtual string? _identifier { get; set; } = null;
        public virtual string? __identifier { get; set; } = null;
        public virtual string? name { get; set; } = null;
        public virtual string? _name { get; set; } = null;
        public virtual string? __name { get; set; } = null;
        public virtual string? schema { get; set; } = null;
        public virtual string? _schema { get; set; } = null;
        public virtual string? __schema { get; set; } = null;
        public virtual string? _alias { get; set; } = null;
        public virtual string? __alias { get; set; } = null;
        public virtual string? entity { get; set; } = null;
        public virtual string? _entity { get; set; } = null;
        public virtual string? __entity { get; set; } = null;
        #endregion

        #region constructor
        public alias()
        {
        }
        #endregion
    }
    #endregion

    #region entity
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    public partial class entity : IDbEntity
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    {
        #region interface
        public virtual string? identifier { get; set; } = null;
        public virtual string? _identifier { get; set; } = null;
        public virtual string? __identifier { get; set; } = null;
        public virtual string? name { get; set; } = null;
        public virtual string? _name { get; set; } = null;
        public virtual string? __name { get; set; } = null;
        public virtual string? schema { get; set; } = null;
        public virtual string? _schema { get; set; } = null;
        public virtual string? __schema { get; set; } = null;
        public virtual string? alias { get; set; } = null;
        public virtual string? _alias { get; set; } = null;
        public virtual string? __alias { get; set; } = null;
        public virtual string? _entity { get; set; } = null;
        public virtual string? __entity { get; set; } = null;
        #endregion

        #region constructor
        public entity()
        {
        }
        #endregion
    }
    #endregion

    #region expression element type

    public partial class ExpressionElementType : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual bool Boolean { get; set; }
        public virtual bool? NullableBoolean { get; set; } = null;
        public virtual byte Byte { get; set; }
        public virtual byte? NullableByte { get; set; } = null;
        public virtual byte[] ByteArray { get; set; } = new byte[0];
        public virtual byte[]? NullableByteArray { get; set; } = null;
        public virtual DateTime DateTime { get; set; }
        public virtual DateTime? NullableDateTime { get; set; } = null;
        public virtual DateTimeOffset DateTimeOffset { get; set; }
        public virtual DateTimeOffset? NullableDateTimeOffset { get; set; } = null;
        public virtual decimal Decimal { get; set; }
        public virtual decimal? NullableDecimal { get; set; } = null;
        public virtual double Double { get; set; }
        public virtual double? NullableDouble { get; set; } = null;
        public virtual Guid Guid { get; set; }
        public virtual Guid? NullableGuid { get; set; } = null;
        public virtual short Int16 { get; set; }
        public virtual short? NullableInt16 { get; set; } = null;
        public virtual int Int32 { get; set; }
        public virtual int? NullableInt32 { get; set; } = null;
        public virtual long Int64 { get; set; }
        public virtual long? NullableInt64 { get; set; } = null;
        public virtual float Single { get; set; }
        public virtual float? NullableSingle { get; set; } = null;
        public virtual string String { get; set; } = string.Empty;
        public virtual string? NullableString { get; set; } = null;
        public virtual TimeSpan TimeSpan { get; set; }
        public virtual TimeSpan? NullableTimeSpan { get; set; } = null;
        #endregion

        #region constructor
        public ExpressionElementType()
        {
        }
        #endregion
    }
    #endregion

    #region identifier
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    public partial class identifier : IDbEntity
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    {
        #region interface
        public virtual string? _identifier { get; set; } = null;
        public virtual string? __identifier { get; set; } = null;
        public virtual string? name { get; set; } = null;
        public virtual string? _name { get; set; } = null;
        public virtual string? __name { get; set; } = null;
        public virtual string? schema { get; set; } = null;
        public virtual string? _schema { get; set; } = null;
        public virtual string? __schema { get; set; } = null;
        public virtual string? alias { get; set; } = null;
        public virtual string? _alias { get; set; } = null;
        public virtual string? __alias { get; set; } = null;
        public virtual string? entity { get; set; } = null;
        public virtual string? _entity { get; set; } = null;
        public virtual string? __entity { get; set; } = null;
        #endregion

        #region constructor
        public identifier()
        {
        }
        #endregion
    }
    #endregion

    #region name
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    public partial class name : IDbEntity
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    {
        #region interface
        public virtual string? identifier { get; set; } = null;
        public virtual string? _identifier { get; set; } = null;
        public virtual string? __identifier { get; set; } = null;
        public virtual string? _name { get; set; } = null;
        public virtual string? __name { get; set; } = null;
        public virtual string? schema { get; set; } = null;
        public virtual string? _schema { get; set; } = null;
        public virtual string? __schema { get; set; } = null;
        public virtual string? alias { get; set; } = null;
        public virtual string? _alias { get; set; } = null;
        public virtual string? __alias { get; set; } = null;
        public virtual string? entity { get; set; } = null;
        public virtual string? _entity { get; set; } = null;
        public virtual string? __entity { get; set; } = null;
        #endregion

        #region constructor
        public name()
        {
        }
        #endregion
    }
    #endregion

    #region schema
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    public partial class schema : IDbEntity
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    {
        #region interface
        public virtual string? identifier { get; set; } = null;
        public virtual string? _identifier { get; set; } = null;
        public virtual string? __identifier { get; set; } = null;
        public virtual string? name { get; set; } = null;
        public virtual string? _name { get; set; } = null;
        public virtual string? __name { get; set; } = null;
        public virtual string? _schema { get; set; } = null;
        public virtual string? __schema { get; set; } = null;
        public virtual string? alias { get; set; } = null;
        public virtual string? _alias { get; set; } = null;
        public virtual string? __alias { get; set; } = null;
        public virtual string? entity { get; set; } = null;
        public virtual string? _entity { get; set; } = null;
        public virtual string? __entity { get; set; } = null;
        #endregion

        #region constructor
        public schema()
        {
        }
        #endregion
    }
    #endregion

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
