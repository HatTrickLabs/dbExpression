using System;
using HatTrick.DbEx.Sql;

namespace ServerSideBlazorApp.dboData
{
    #region address
    public partial class Address : IDbEntity
    {
        #region interface
        public int Id { get; set; }
        public ServerSideBlazorApp.Data.AddressType? AddressType { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        #endregion

        #region constructor
        public Address()
        {
        }
        #endregion
    }
    #endregion

    #region customer
    public partial class Customer : IDbEntity
    {
        #region interface
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public ServerSideBlazorApp.Data.GenderType GenderType { get; set; }
        public int? CreditLimit { get; set; }
        public int? YearOfLastCreditLimitReview { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        #endregion

        #region constructor
        public Customer()
        {
        }
        #endregion
    }
    #endregion

    #region customer address
    public partial class CustomerAddress : IDbEntity
    {
        #region interface
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int AddressId { get; set; }
        public DateTime DateCreated { get; set; }
        #endregion

        #region constructor
        public CustomerAddress()
        {
        }
        #endregion
    }
    #endregion

    #region product
    public partial class Product : IDbEntity
    {
        #region interface
        public int Id { get; set; }
        public ServerSideBlazorApp.Data.ProductCategoryType? ProductCategoryType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double ListPrice { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public byte[] Image { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Weight { get; set; }
        public decimal ShippingWeight { get; set; }
        public TimeSpan? ValidStartTimeOfDayForPurchase { get; set; }
        public TimeSpan? ValidEndTimeOfDayForPurchase { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
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
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string OrderNumber { get; set; }
        public int TotalPurchaseQuantity { get; set; }
        public double TotalPurchaseAmount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public Guid? TrackingIdentifier { get; set; }
        public ServerSideBlazorApp.Data.PaymentMethodType PaymentMethodType { get; set; }
        public ServerSideBlazorApp.Data.PaymentSourceType? PaymentSourceType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
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
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
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
        public int Id { get; set; }
        public double? TotalAmount { get; set; }
        public int? TotalCount { get; set; }
        #endregion

        #region constructor
        public PersonTotalPurchasesView()
        {
        }
        #endregion
    }
    #endregion

}
namespace ServerSideBlazorApp.secData
{
    #region person
    public partial class Person : IDbEntity
    {
        #region interface
        public int Id { get; set; }
        public string SSN { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateUpdated { get; set; }
        #endregion

        #region constructor
        public Person()
        {
        }
        #endregion
    }
    #endregion

}
