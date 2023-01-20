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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace DbExAlt.dboAltData
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
        public virtual int? AddressType { get; set; }
        public virtual string Line1 { get; set; }
        public virtual string Line2 { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }
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

    #region person alt

    public partial class PersonAlt : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual string FirstNameAlt { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime? BirthDate { get; set; }
        public virtual int GenderType { get; set; }
        public virtual int? CreditLimit { get; set; }
        public virtual int? YearOfLastCreditLimitReview { get; set; }
        public virtual DateTimeOffset RegistrationDate { get; set; }
        public virtual DateTimeOffset? LastLoginDate { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateUpdated { get; set; }
        #endregion

        #region constructor
        public PersonAlt()
        {
        }
        #endregion
    }
    #endregion

    #region person_ address

    public partial class Person_Address : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual int PersonId { get; set; }
        public virtual int AddressId { get; set; }
        public virtual DateTime DateCreated { get; set; }
        #endregion

        #region constructor
        public Person_Address()
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
        public virtual int? ProductCategoryType { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual double ListPrice { get; set; }
        public virtual double Price { get; set; }
        public virtual int Quantity { get; set; }
        public virtual byte[] Image { get; set; }
        public virtual decimal? Height { get; set; }
        public virtual decimal? Width { get; set; }
        public virtual decimal? Depth { get; set; }
        public virtual decimal? Weight { get; set; }
        public virtual decimal ShippingWeight { get; set; }
        public virtual TimeSpan? ValidStartTimeOfDayForPurchase { get; set; }
        public virtual TimeSpan? ValidEndTimeOfDayForPurchase { get; set; }
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
        public virtual string OrderNumber { get; set; }
        public virtual int TotalPurchaseQuantity { get; set; }
        public virtual double TotalPurchaseAmount { get; set; }
        public virtual DateTime PurchaseDate { get; set; }
        public virtual DateTime? ShipDate { get; set; }
        public virtual DateTime? ExpectedDeliveryDate { get; set; }
        public virtual Guid? TrackingIdentifier { get; set; }
        public virtual string PaymentMethodType { get; set; }
        public virtual string PaymentSourceType { get; set; }
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
        public virtual double? TotalAmount { get; set; }
        public virtual int? TotalCount { get; set; }
        #endregion

        #region constructor
        public PersonTotalPurchasesView()
        {
        }
        #endregion
    }
    #endregion

}
namespace DbExAlt.secData
{
    #region person

    public partial class Person : IDbEntity

    {
        #region interface
        public virtual int Id { get; set; }
        public virtual string SSN { get; set; }
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
namespace DbExAlt.unit_testData
{
    #region alias
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    public partial class alias : IDbEntity
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters

    {
        #region interface
        public virtual string identifier { get; set; }
        public virtual string _identifier { get; set; }
        public virtual string __identifier { get; set; }
        public virtual string name { get; set; }
        public virtual string _name { get; set; }
        public virtual string __name { get; set; }
        public virtual string schema { get; set; }
        public virtual string _schema { get; set; }
        public virtual string __schema { get; set; }
        public virtual string _alias { get; set; }
        public virtual string __alias { get; set; }
        public virtual string entity { get; set; }
        public virtual string _entity { get; set; }
        public virtual string __entity { get; set; }
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
        public virtual string identifier { get; set; }
        public virtual string _identifier { get; set; }
        public virtual string __identifier { get; set; }
        public virtual string name { get; set; }
        public virtual string _name { get; set; }
        public virtual string __name { get; set; }
        public virtual string schema { get; set; }
        public virtual string _schema { get; set; }
        public virtual string __schema { get; set; }
        public virtual string alias { get; set; }
        public virtual string _alias { get; set; }
        public virtual string __alias { get; set; }
        public virtual string _entity { get; set; }
        public virtual string __entity { get; set; }
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
        public virtual bool? NullableBoolean { get; set; }
        public virtual byte Byte { get; set; }
        public virtual byte? NullableByte { get; set; }
        public virtual byte[] ByteArray { get; set; }
        public virtual byte[] NullableByteArray { get; set; }
        public virtual DateTime DateTime { get; set; }
        public virtual DateTime? NullableDateTime { get; set; }
        public virtual DateTimeOffset DateTimeOffset { get; set; }
        public virtual DateTimeOffset? NullableDateTimeOffset { get; set; }
        public virtual decimal Decimal { get; set; }
        public virtual decimal? NullableDecimal { get; set; }
        public virtual double Double { get; set; }
        public virtual double? NullableDouble { get; set; }
        public virtual Guid Guid { get; set; }
        public virtual Guid? NullableGuid { get; set; }
        public virtual short Int16 { get; set; }
        public virtual short? NullableInt16 { get; set; }
        public virtual int Int32 { get; set; }
        public virtual int? NullableInt32 { get; set; }
        public virtual long Int64 { get; set; }
        public virtual long? NullableInt64 { get; set; }
        public virtual float Single { get; set; }
        public virtual float? NullableSingle { get; set; }
        public virtual string String { get; set; }
        public virtual string NullableString { get; set; }
        public virtual TimeSpan TimeSpan { get; set; }
        public virtual TimeSpan? NullableTimeSpan { get; set; }
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
        public virtual string _identifier { get; set; }
        public virtual string __identifier { get; set; }
        public virtual string name { get; set; }
        public virtual string _name { get; set; }
        public virtual string __name { get; set; }
        public virtual string schema { get; set; }
        public virtual string _schema { get; set; }
        public virtual string __schema { get; set; }
        public virtual string alias { get; set; }
        public virtual string _alias { get; set; }
        public virtual string __alias { get; set; }
        public virtual string entity { get; set; }
        public virtual string _entity { get; set; }
        public virtual string __entity { get; set; }
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
        public virtual string identifier { get; set; }
        public virtual string _identifier { get; set; }
        public virtual string __identifier { get; set; }
        public virtual string _name { get; set; }
        public virtual string __name { get; set; }
        public virtual string schema { get; set; }
        public virtual string _schema { get; set; }
        public virtual string __schema { get; set; }
        public virtual string alias { get; set; }
        public virtual string _alias { get; set; }
        public virtual string __alias { get; set; }
        public virtual string entity { get; set; }
        public virtual string _entity { get; set; }
        public virtual string __entity { get; set; }
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
        public virtual string identifier { get; set; }
        public virtual string _identifier { get; set; }
        public virtual string __identifier { get; set; }
        public virtual string name { get; set; }
        public virtual string _name { get; set; }
        public virtual string __name { get; set; }
        public virtual string _schema { get; set; }
        public virtual string __schema { get; set; }
        public virtual string alias { get; set; }
        public virtual string _alias { get; set; }
        public virtual string __alias { get; set; }
        public virtual string entity { get; set; }
        public virtual string _entity { get; set; }
        public virtual string __entity { get; set; }
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
