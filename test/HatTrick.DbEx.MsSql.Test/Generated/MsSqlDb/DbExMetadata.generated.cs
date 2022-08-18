//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using HatTrick.DbEx.MsSql;
using HatTrick.DbEx.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using DbEx.dboDataService;
using DbEx.unit_testDataService;
using DbEx.secDataService;
#nullable enable
namespace DbEx.DataService
{
    public class MsSqlDbSqlDatabaseMetadata : ISqlDatabaseMetadata
    {
        private static readonly Dictionary<int, ISqlMetadata> _metadata = new Dictionary<int, ISqlMetadata>();

        #region interface
        public string Name { get; private set; } = "MsSqlDbExTest";
        public IDictionary<int, ISqlMetadata> Metadata => _metadata;
        #endregion

        #region constructors
        static MsSqlDbSqlDatabaseMetadata()
        {
            #region dbo schema
            _metadata.Add(1, new SqlSchemaMetadata("dbo"));
            
            #region dbo entities
            #region dbo.AccessAuditLog
            _metadata.Add(2, new SqlTableMetadata("AccessAuditLog"));
            _metadata.Add(3, new MsSqlColumnMetadata("Id", SqlDbType.Int) { IsIdentity = true });
            _metadata.Add(4, new MsSqlColumnMetadata("PersonId", SqlDbType.Int));
            _metadata.Add(5, new MsSqlColumnMetadata("AccessResult", SqlDbType.Int));
            _metadata.Add(6, new MsSqlColumnMetadata("DateCreated", SqlDbType.DateTime));
            #endregion

            #region dbo.Address
            _metadata.Add(7, new SqlTableMetadata("Address"));
            _metadata.Add(8, new MsSqlColumnMetadata("Id", SqlDbType.Int) { IsIdentity = true });
            _metadata.Add(9, new MsSqlColumnMetadata("AddressType", SqlDbType.Int));
            _metadata.Add(10, new MsSqlColumnMetadata("Line1", SqlDbType.VarChar, 50));
            _metadata.Add(11, new MsSqlColumnMetadata("Line2", SqlDbType.VarChar, 50));
            _metadata.Add(12, new MsSqlColumnMetadata("City", SqlDbType.VarChar, 60));
            _metadata.Add(13, new MsSqlColumnMetadata("State", SqlDbType.Char, 2));
            _metadata.Add(14, new MsSqlColumnMetadata("Zip", SqlDbType.VarChar, 10));
            _metadata.Add(15, new MsSqlColumnMetadata("DateCreated", SqlDbType.DateTime));
            _metadata.Add(16, new MsSqlColumnMetadata("DateUpdated", SqlDbType.DateTime));
            #endregion

            #region dbo.Person
            _metadata.Add(17, new SqlTableMetadata("Person"));
            _metadata.Add(18, new MsSqlColumnMetadata("Id", SqlDbType.Int) { IsIdentity = true });
            _metadata.Add(19, new MsSqlColumnMetadata("FirstName", SqlDbType.VarChar, 20));
            _metadata.Add(20, new MsSqlColumnMetadata("LastName", SqlDbType.VarChar, 20));
            _metadata.Add(21, new MsSqlColumnMetadata("BirthDate", SqlDbType.Date));
            _metadata.Add(22, new MsSqlColumnMetadata("GenderType", SqlDbType.Int));
            _metadata.Add(23, new MsSqlColumnMetadata("CreditLimit", SqlDbType.Int));
            _metadata.Add(24, new MsSqlColumnMetadata("YearOfLastCreditLimitReview", SqlDbType.Int));
            _metadata.Add(25, new MsSqlColumnMetadata("RegistrationDate", SqlDbType.DateTimeOffset, 10));
            _metadata.Add(26, new MsSqlColumnMetadata("LastLoginDate", SqlDbType.DateTimeOffset, 10));
            _metadata.Add(27, new MsSqlColumnMetadata("DateCreated", SqlDbType.DateTime));
            _metadata.Add(28, new MsSqlColumnMetadata("DateUpdated", SqlDbType.DateTime));
            #endregion

            #region dbo.Person_Address
            _metadata.Add(29, new SqlTableMetadata("Person_Address"));
            _metadata.Add(30, new MsSqlColumnMetadata("Id", SqlDbType.Int) { IsIdentity = true });
            _metadata.Add(31, new MsSqlColumnMetadata("PersonId", SqlDbType.Int));
            _metadata.Add(32, new MsSqlColumnMetadata("AddressId", SqlDbType.Int));
            _metadata.Add(33, new MsSqlColumnMetadata("DateCreated", SqlDbType.DateTime));
            #endregion

            #region dbo.Product
            _metadata.Add(34, new SqlTableMetadata("Product"));
            _metadata.Add(35, new MsSqlColumnMetadata("Id", SqlDbType.Int) { IsIdentity = true });
            _metadata.Add(36, new MsSqlColumnMetadata("ProductCategoryType", SqlDbType.Int));
            _metadata.Add(37, new MsSqlColumnMetadata("Name", SqlDbType.VarChar, 80));
            _metadata.Add(38, new MsSqlColumnMetadata("Description", SqlDbType.NVarChar, 4000));
            _metadata.Add(39, new MsSqlColumnMetadata("ListPrice", SqlDbType.Money));
            _metadata.Add(40, new MsSqlColumnMetadata("Price", SqlDbType.Money));
            _metadata.Add(41, new MsSqlColumnMetadata("Quantity", SqlDbType.Int));
            _metadata.Add(42, new MsSqlColumnMetadata("Image", SqlDbType.VarBinary, -1));
            _metadata.Add(43, new MsSqlColumnMetadata("Height", SqlDbType.Decimal, 4, 1));
            _metadata.Add(44, new MsSqlColumnMetadata("Width", SqlDbType.Decimal, 4, 1));
            _metadata.Add(45, new MsSqlColumnMetadata("Depth", SqlDbType.Decimal, 4, 1));
            _metadata.Add(46, new MsSqlColumnMetadata("Weight", SqlDbType.Decimal, 4, 1));
            _metadata.Add(47, new MsSqlColumnMetadata("ShippingWeight", SqlDbType.Decimal, 4, 1));
            _metadata.Add(48, new MsSqlColumnMetadata("ValidStartTimeOfDayForPurchase", SqlDbType.Time, 5));
            _metadata.Add(49, new MsSqlColumnMetadata("ValidEndTimeOfDayForPurchase", SqlDbType.Time, 5));
            _metadata.Add(50, new MsSqlColumnMetadata("DateCreated", SqlDbType.DateTime));
            _metadata.Add(51, new MsSqlColumnMetadata("DateUpdated", SqlDbType.DateTime));
            #endregion

            #region dbo.Purchase
            _metadata.Add(52, new SqlTableMetadata("Purchase"));
            _metadata.Add(53, new MsSqlColumnMetadata("Id", SqlDbType.Int) { IsIdentity = true });
            _metadata.Add(54, new MsSqlColumnMetadata("PersonId", SqlDbType.Int));
            _metadata.Add(55, new MsSqlColumnMetadata("OrderNumber", SqlDbType.VarChar, 20));
            _metadata.Add(56, new MsSqlColumnMetadata("TotalPurchaseQuantity", SqlDbType.Int));
            _metadata.Add(57, new MsSqlColumnMetadata("TotalPurchaseAmount", SqlDbType.Money));
            _metadata.Add(58, new MsSqlColumnMetadata("PurchaseDate", SqlDbType.DateTime));
            _metadata.Add(59, new MsSqlColumnMetadata("ShipDate", SqlDbType.DateTime));
            _metadata.Add(60, new MsSqlColumnMetadata("ExpectedDeliveryDate", SqlDbType.DateTime));
            _metadata.Add(61, new MsSqlColumnMetadata("TrackingIdentifier", SqlDbType.UniqueIdentifier));
            _metadata.Add(62, new MsSqlColumnMetadata("PaymentMethodType", SqlDbType.VarChar, 20));
            _metadata.Add(63, new MsSqlColumnMetadata("PaymentSourceType", SqlDbType.VarChar, 20));
            _metadata.Add(64, new MsSqlColumnMetadata("DateCreated", SqlDbType.DateTime));
            _metadata.Add(65, new MsSqlColumnMetadata("DateUpdated", SqlDbType.DateTime));
            #endregion

            #region dbo.PurchaseLine
            _metadata.Add(66, new SqlTableMetadata("PurchaseLine"));
            _metadata.Add(67, new MsSqlColumnMetadata("Id", SqlDbType.Int) { IsIdentity = true });
            _metadata.Add(68, new MsSqlColumnMetadata("PurchaseId", SqlDbType.Int));
            _metadata.Add(69, new MsSqlColumnMetadata("ProductId", SqlDbType.Int));
            _metadata.Add(70, new MsSqlColumnMetadata("PurchasePrice", SqlDbType.Decimal, 12, 2));
            _metadata.Add(71, new MsSqlColumnMetadata("Quantity", SqlDbType.Int));
            _metadata.Add(72, new MsSqlColumnMetadata("DateCreated", SqlDbType.DateTime));
            _metadata.Add(73, new MsSqlColumnMetadata("DateUpdated", SqlDbType.DateTime));
            #endregion

            #region dbo.PersonTotalPurchasesView
            _metadata.Add(74, new SqlTableMetadata("PersonTotalPurchasesView"));
            _metadata.Add(75, new MsSqlColumnMetadata("Id", SqlDbType.Int));
            _metadata.Add(76, new MsSqlColumnMetadata("TotalAmount", SqlDbType.Money));
            _metadata.Add(77, new MsSqlColumnMetadata("TotalCount", SqlDbType.Int));
            #endregion

            #endregion

            #region dbo stored procedures
            _metadata.Add(78, new StoredProcedureMetadata("SelectPerson_As_Dynamic_With_Input"));
            _metadata.Add(79, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(80, new StoredProcedureMetadata("SelectPerson_As_Dynamic_With_Input_And_InputOutput"));
            _metadata.Add(81, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(82, new MsSqlParameterMetadata("@CreditLimit", SqlDbType.Int));
            _metadata.Add(83, new StoredProcedureMetadata("SelectPerson_As_Dynamic_With_Input_And_Output"));
            _metadata.Add(84, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(85, new MsSqlParameterMetadata("@Count", SqlDbType.Int));
            _metadata.Add(86, new StoredProcedureMetadata("SelectPerson_As_DynamicList_With_Input"));
            _metadata.Add(87, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(88, new StoredProcedureMetadata("SelectPerson_As_DynamicList_With_Input_And_InputOutput"));
            _metadata.Add(89, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(90, new MsSqlParameterMetadata("@CreditLimit", SqlDbType.Int));
            _metadata.Add(91, new StoredProcedureMetadata("SelectPerson_As_DynamicList_With_Input_And_Output"));
            _metadata.Add(92, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(93, new MsSqlParameterMetadata("@Count", SqlDbType.Int));
            _metadata.Add(94, new StoredProcedureMetadata("SelectPersonId_As_ScalarValue_With_Input"));
            _metadata.Add(95, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(96, new StoredProcedureMetadata("SelectPersonId_As_ScalarValue_With_Input_And_Default_Value"));
            _metadata.Add(97, new StoredProcedureMetadata("SelectPersonId_As_ScalarValue_With_Input_And_InputOutput"));
            _metadata.Add(98, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(99, new MsSqlParameterMetadata("@CreditLimit", SqlDbType.Int));
            _metadata.Add(100, new StoredProcedureMetadata("SelectPersonId_As_ScalarValue_With_Input_And_Output"));
            _metadata.Add(101, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(102, new MsSqlParameterMetadata("@Count", SqlDbType.Int));
            _metadata.Add(103, new StoredProcedureMetadata("SelectPersonId_As_ScalarValueList_With_Input"));
            _metadata.Add(104, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(105, new StoredProcedureMetadata("SelectPersonId_As_ScalarValueList_With_Input_And_InputOutput"));
            _metadata.Add(106, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(107, new MsSqlParameterMetadata("@CreditLimit", SqlDbType.Int));
            _metadata.Add(108, new StoredProcedureMetadata("SelectPersonId_As_ScalarValueList_With_Input_And_Output"));
            _metadata.Add(109, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(110, new MsSqlParameterMetadata("@Count", SqlDbType.Int));
            _metadata.Add(111, new StoredProcedureMetadata("UpdatePersonCreditLimit_With_Inputs"));
            _metadata.Add(112, new MsSqlParameterMetadata("@P1", SqlDbType.Int));
            _metadata.Add(113, new MsSqlParameterMetadata("@CreditLimit", SqlDbType.Int));
            #endregion
            #endregion

            #region unit_test schema
            _metadata.Add(114, new SqlSchemaMetadata("unit_test"));
            
            #region unit_test entities
            #region unit_test.alias
            _metadata.Add(115, new SqlTableMetadata("alias"));
            _metadata.Add(116, new MsSqlColumnMetadata("identifier", SqlDbType.VarChar, 20));
            _metadata.Add(117, new MsSqlColumnMetadata("_identifier", SqlDbType.VarChar, 20));
            _metadata.Add(118, new MsSqlColumnMetadata("__identifier", SqlDbType.VarChar, 20));
            _metadata.Add(119, new MsSqlColumnMetadata("name", SqlDbType.VarChar, 20));
            _metadata.Add(120, new MsSqlColumnMetadata("_name", SqlDbType.VarChar, 20));
            _metadata.Add(121, new MsSqlColumnMetadata("__name", SqlDbType.VarChar, 20));
            _metadata.Add(122, new MsSqlColumnMetadata("schema", SqlDbType.VarChar, 20));
            _metadata.Add(123, new MsSqlColumnMetadata("_schema", SqlDbType.VarChar, 20));
            _metadata.Add(124, new MsSqlColumnMetadata("__schema", SqlDbType.VarChar, 20));
            _metadata.Add(125, new MsSqlColumnMetadata("_alias", SqlDbType.VarChar, 20));
            _metadata.Add(126, new MsSqlColumnMetadata("__alias", SqlDbType.VarChar, 20));
            _metadata.Add(127, new MsSqlColumnMetadata("entity", SqlDbType.VarChar, 20));
            _metadata.Add(128, new MsSqlColumnMetadata("_entity", SqlDbType.VarChar, 20));
            _metadata.Add(129, new MsSqlColumnMetadata("__entity", SqlDbType.VarChar, 20));
            #endregion

            #region unit_test.entity
            _metadata.Add(130, new SqlTableMetadata("entity"));
            _metadata.Add(131, new MsSqlColumnMetadata("identifier", SqlDbType.VarChar, 20));
            _metadata.Add(132, new MsSqlColumnMetadata("_identifier", SqlDbType.VarChar, 20));
            _metadata.Add(133, new MsSqlColumnMetadata("__identifier", SqlDbType.VarChar, 20));
            _metadata.Add(134, new MsSqlColumnMetadata("name", SqlDbType.VarChar, 20));
            _metadata.Add(135, new MsSqlColumnMetadata("_name", SqlDbType.VarChar, 20));
            _metadata.Add(136, new MsSqlColumnMetadata("__name", SqlDbType.VarChar, 20));
            _metadata.Add(137, new MsSqlColumnMetadata("schema", SqlDbType.VarChar, 20));
            _metadata.Add(138, new MsSqlColumnMetadata("_schema", SqlDbType.VarChar, 20));
            _metadata.Add(139, new MsSqlColumnMetadata("__schema", SqlDbType.VarChar, 20));
            _metadata.Add(140, new MsSqlColumnMetadata("alias", SqlDbType.VarChar, 20));
            _metadata.Add(141, new MsSqlColumnMetadata("_alias", SqlDbType.VarChar, 20));
            _metadata.Add(142, new MsSqlColumnMetadata("__alias", SqlDbType.VarChar, 20));
            _metadata.Add(143, new MsSqlColumnMetadata("_entity", SqlDbType.VarChar, 20));
            _metadata.Add(144, new MsSqlColumnMetadata("__entity", SqlDbType.VarChar, 20));
            #endregion

            #region unit_test.ExpressionElementType
            _metadata.Add(145, new SqlTableMetadata("ExpressionElementType"));
            _metadata.Add(146, new MsSqlColumnMetadata("Id", SqlDbType.Int));
            _metadata.Add(147, new MsSqlColumnMetadata("Boolean", SqlDbType.Bit));
            _metadata.Add(148, new MsSqlColumnMetadata("NullableBoolean", SqlDbType.Bit));
            _metadata.Add(149, new MsSqlColumnMetadata("Byte", SqlDbType.TinyInt));
            _metadata.Add(150, new MsSqlColumnMetadata("NullableByte", SqlDbType.TinyInt));
            _metadata.Add(151, new MsSqlColumnMetadata("ByteArray", SqlDbType.VarBinary, -1));
            _metadata.Add(152, new MsSqlColumnMetadata("NullableByteArray", SqlDbType.VarBinary, -1));
            _metadata.Add(153, new MsSqlColumnMetadata("DateTime", SqlDbType.DateTime2, 8));
            _metadata.Add(154, new MsSqlColumnMetadata("NullableDateTime", SqlDbType.DateTime2, 8));
            _metadata.Add(155, new MsSqlColumnMetadata("DateTimeOffset", SqlDbType.DateTimeOffset, 10));
            _metadata.Add(156, new MsSqlColumnMetadata("NullableDateTimeOffset", SqlDbType.DateTimeOffset, 10));
            _metadata.Add(157, new MsSqlColumnMetadata("Decimal", SqlDbType.Decimal, 5, 4));
            _metadata.Add(158, new MsSqlColumnMetadata("NullableDecimal", SqlDbType.Decimal, 5, 4));
            _metadata.Add(159, new MsSqlColumnMetadata("Double", SqlDbType.Money));
            _metadata.Add(160, new MsSqlColumnMetadata("NullableDouble", SqlDbType.Money));
            _metadata.Add(161, new MsSqlColumnMetadata("Guid", SqlDbType.UniqueIdentifier));
            _metadata.Add(162, new MsSqlColumnMetadata("NullableGuid", SqlDbType.UniqueIdentifier));
            _metadata.Add(163, new MsSqlColumnMetadata("Int16", SqlDbType.SmallInt));
            _metadata.Add(164, new MsSqlColumnMetadata("NullableInt16", SqlDbType.SmallInt));
            _metadata.Add(165, new MsSqlColumnMetadata("Int32", SqlDbType.Int));
            _metadata.Add(166, new MsSqlColumnMetadata("NullableInt32", SqlDbType.Int));
            _metadata.Add(167, new MsSqlColumnMetadata("Int64", SqlDbType.BigInt));
            _metadata.Add(168, new MsSqlColumnMetadata("NullableInt64", SqlDbType.BigInt));
            _metadata.Add(169, new MsSqlColumnMetadata("Single", SqlDbType.Real));
            _metadata.Add(170, new MsSqlColumnMetadata("NullableSingle", SqlDbType.Real));
            _metadata.Add(171, new MsSqlColumnMetadata("String", SqlDbType.VarChar, 20));
            _metadata.Add(172, new MsSqlColumnMetadata("NullableString", SqlDbType.VarChar, 20));
            _metadata.Add(173, new MsSqlColumnMetadata("TimeSpan", SqlDbType.Time, 5));
            _metadata.Add(174, new MsSqlColumnMetadata("NullableTimeSpan", SqlDbType.Time, 5));
            #endregion

            #region unit_test.identifier
            _metadata.Add(175, new SqlTableMetadata("identifier"));
            _metadata.Add(176, new MsSqlColumnMetadata("_identifier", SqlDbType.VarChar, 20));
            _metadata.Add(177, new MsSqlColumnMetadata("__identifier", SqlDbType.VarChar, 20));
            _metadata.Add(178, new MsSqlColumnMetadata("name", SqlDbType.VarChar, 20));
            _metadata.Add(179, new MsSqlColumnMetadata("_name", SqlDbType.VarChar, 20));
            _metadata.Add(180, new MsSqlColumnMetadata("__name", SqlDbType.VarChar, 20));
            _metadata.Add(181, new MsSqlColumnMetadata("schema", SqlDbType.VarChar, 20));
            _metadata.Add(182, new MsSqlColumnMetadata("_schema", SqlDbType.VarChar, 20));
            _metadata.Add(183, new MsSqlColumnMetadata("__schema", SqlDbType.VarChar, 20));
            _metadata.Add(184, new MsSqlColumnMetadata("alias", SqlDbType.VarChar, 20));
            _metadata.Add(185, new MsSqlColumnMetadata("_alias", SqlDbType.VarChar, 20));
            _metadata.Add(186, new MsSqlColumnMetadata("__alias", SqlDbType.VarChar, 20));
            _metadata.Add(187, new MsSqlColumnMetadata("entity", SqlDbType.VarChar, 20));
            _metadata.Add(188, new MsSqlColumnMetadata("_entity", SqlDbType.VarChar, 20));
            _metadata.Add(189, new MsSqlColumnMetadata("__entity", SqlDbType.VarChar, 20));
            #endregion

            #region unit_test.name
            _metadata.Add(190, new SqlTableMetadata("name"));
            _metadata.Add(191, new MsSqlColumnMetadata("identifier", SqlDbType.VarChar, 20));
            _metadata.Add(192, new MsSqlColumnMetadata("_identifier", SqlDbType.VarChar, 20));
            _metadata.Add(193, new MsSqlColumnMetadata("__identifier", SqlDbType.VarChar, 20));
            _metadata.Add(194, new MsSqlColumnMetadata("_name", SqlDbType.VarChar, 20));
            _metadata.Add(195, new MsSqlColumnMetadata("__name", SqlDbType.VarChar, 20));
            _metadata.Add(196, new MsSqlColumnMetadata("schema", SqlDbType.VarChar, 20));
            _metadata.Add(197, new MsSqlColumnMetadata("_schema", SqlDbType.VarChar, 20));
            _metadata.Add(198, new MsSqlColumnMetadata("__schema", SqlDbType.VarChar, 20));
            _metadata.Add(199, new MsSqlColumnMetadata("alias", SqlDbType.VarChar, 20));
            _metadata.Add(200, new MsSqlColumnMetadata("_alias", SqlDbType.VarChar, 20));
            _metadata.Add(201, new MsSqlColumnMetadata("__alias", SqlDbType.VarChar, 20));
            _metadata.Add(202, new MsSqlColumnMetadata("entity", SqlDbType.VarChar, 20));
            _metadata.Add(203, new MsSqlColumnMetadata("_entity", SqlDbType.VarChar, 20));
            _metadata.Add(204, new MsSqlColumnMetadata("__entity", SqlDbType.VarChar, 20));
            #endregion

            #region unit_test.schema
            _metadata.Add(205, new SqlTableMetadata("schema"));
            _metadata.Add(206, new MsSqlColumnMetadata("identifier", SqlDbType.VarChar, 20));
            _metadata.Add(207, new MsSqlColumnMetadata("_identifier", SqlDbType.VarChar, 20));
            _metadata.Add(208, new MsSqlColumnMetadata("__identifier", SqlDbType.VarChar, 20));
            _metadata.Add(209, new MsSqlColumnMetadata("name", SqlDbType.VarChar, 20));
            _metadata.Add(210, new MsSqlColumnMetadata("_name", SqlDbType.VarChar, 20));
            _metadata.Add(211, new MsSqlColumnMetadata("__name", SqlDbType.VarChar, 20));
            _metadata.Add(212, new MsSqlColumnMetadata("_schema", SqlDbType.VarChar, 20));
            _metadata.Add(213, new MsSqlColumnMetadata("__schema", SqlDbType.VarChar, 20));
            _metadata.Add(214, new MsSqlColumnMetadata("alias", SqlDbType.VarChar, 20));
            _metadata.Add(215, new MsSqlColumnMetadata("_alias", SqlDbType.VarChar, 20));
            _metadata.Add(216, new MsSqlColumnMetadata("__alias", SqlDbType.VarChar, 20));
            _metadata.Add(217, new MsSqlColumnMetadata("entity", SqlDbType.VarChar, 20));
            _metadata.Add(218, new MsSqlColumnMetadata("_entity", SqlDbType.VarChar, 20));
            _metadata.Add(219, new MsSqlColumnMetadata("__entity", SqlDbType.VarChar, 20));
            #endregion

            #endregion

            #region unit_test stored procedures
            #endregion
            #endregion

            #region sec schema
            _metadata.Add(220, new SqlSchemaMetadata("sec"));
            
            #region sec entities
            #region sec.Person
            _metadata.Add(221, new SqlTableMetadata("Person"));
            _metadata.Add(222, new MsSqlColumnMetadata("Id", SqlDbType.Int));
            _metadata.Add(223, new MsSqlColumnMetadata("SSN", SqlDbType.Char, 11));
            _metadata.Add(224, new MsSqlColumnMetadata("DateCreated", SqlDbType.DateTime));
            _metadata.Add(225, new MsSqlColumnMetadata("DateUpdated", SqlDbType.DateTime));
            #endregion

            #endregion

            #region sec stored procedures
            #endregion
            #endregion

        }

        public MsSqlDbSqlDatabaseMetadata(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        #endregion
    }
}