﻿using System;
using System.Diagnostics;
using SimpleConsole.Data;
using SimpleConsole.DataService;
using SimpleConsole.dboData;
using SimpleConsole.dboDataService;
using HatTrick.DbEx.MsSql.Configuration;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.Sql.Configuration;
using HatTrick.DbEx.Sql.Converter;
using Microsoft.Extensions.Configuration;

namespace NetCoreConsoleApp
{
	class Program
	{
		#region main
		static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ConfigureDbEx();
            sw.Stop();

            Console.WriteLine($"Configured in {sw.ElapsedMilliseconds} milliseconds.{Environment.NewLine}");

            sw.Reset();

            sw.Start();
            //RunSelectExpressions();
            //RunSimpleInsertExpression();
            //RunTransactionalInsertExpression();
            //RunBatchInsertExpression();
            RunUpdateExpressions();
            sw.Stop();

            Console.WriteLine($"Queries complete in {sw.ElapsedMilliseconds} milliseconds.");
#if DEBUG
            Console.WriteLine("Press [Enter] to exit");
            Console.ReadLine();
#endif
        }
		#endregion

		#region configure dbex
		static void ConfigureDbEx()
        {
            var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                        .Build();

            DbExpressionConfigurationBuilder.AddDbExpression(c =>
            {
                c.AddMsSql2014Database<SimpleConsoleDb>(config.GetConnectionString("dbex_mssql_test"));
            });
        }
		#endregion

		#region run select expressions
		static void RunSelectExpressions()
        {
            var select = new SelectExpressions();

            var respa = select.SelectPersonById(1);
            var respb = select.SelectPersonByFirstNameLastNameAndBirthdate("Kyle", "Broflovski", DateTime.Parse("1996-03-01"));
            var respc = select.SelectTotalPurchaseViewByPersonId(2);
            var respd = select.SelectProductNameByid(1);
            var respe = select.GetProductDescriptionByNameAndPrice("LEGO City Advent Calendar", 22.99);
            var respf = select.GetPersonFullNameById(1);
            var respg = select.GetFullAddressById(1);
            var resph = select.GetTotalValueOfProductOnHandById(1);
            var respi = select.GetTotalValueOfAllProductsOnHand();
            var respj = select.GetAvgProductPrice();
            var respk = select.GetTotalPurchaseRevenue();
            var respl = select.GetMaxPurchaseLinePriceForAProductById(1);
            var respm = select.GetCountOfPurchaseLinesForProductId(1);
            var respn = select.GetPeopleOverAge25();
            var respo = select.GetProductsWithListPriceAtLeast20DollarsButLessThan30();
            var respp = select.GetAllAddressesWithinZip("80456");
            var respq = select.GetPurchaseLineProductDescriptionByPurchaseLineId(2);
            var respr = select.GetBillingAddressForPersonByPersonId(2);
            var resps = select.GetPeopleWhoHaveNotCompletedAPurchase();
            var respt = select.GetFullNameOfPeopleWithinZipCode("80456");
            var respu = select.PaginateAllPeopleGreaterThan18YrsOldWithinZipCodeSet(2, 5, new string[] { "02101", "02124", "02446", "02801", "03820", "08053", "80456" });
            var respv = select.FindAllPeopleHavingMoreThanOneAddress();
            var respw = select.FindAllPeopleWithLastNameStartingWith('c');
            var respx = select.GetAllLastNamesOfPeopleWhereSecondPositionOfLastNameIsChar('t');
            var respy = select.GetPeopleByComplexGenderAndZipFilter();
            var respz = select.FindAllPeopleInfoHavingMoreThanOneAddress();
            var resp1 = select.GetCompleteBillingAddressInfoByPersonId(2);
            var resp2 = select.GetAllPersonPurchaseCountAndTotalPurchasePriceInfoByZipCode("80456");
        }
        #endregion

        #region run simple insert expressions
        static void RunSimpleInsertExpression()
        {
            InsertExpressions inserts = new InsertExpressions();

			var p = new Person() 
            { 
                FirstName = "Charlie", 
                LastName = "Brown", 
                BirthDate = new DateTime(1950, 10, 1), 
                GenderType = GenderType.Male, 
                CreditLimit = 4500, 
                YearOfLastCreditLimitReview = 2019,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            inserts.SimpleInsertPerson(p);
		}
        #endregion

        #region run transactional insert expression
        static void RunTransactionalInsertExpression()
        {
            InsertExpressions insert = new InsertExpressions();

            var p = new Person()
            {
                FirstName = "Mickey",
                LastName = "Mouse",
                BirthDate = new DateTime(1928, 11, 18),
                GenderType = GenderType.Male,
                CreditLimit = 80000,
                YearOfLastCreditLimitReview = 2020,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            var a = new Address()
            {
                Line1 = "101 Disney Way",
                Line2 = "Suite 210",
                City = "Burbank",
                State = "CA",
                Zip = "91508",
                AddressType = AddressType.Mailing,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            insert.TransactionalInsertPersonAndAddress(p, a);
        }
        #endregion

        #region run batch insert expression
        static void RunBatchInsertExpression()
        {
            InsertExpressions insert = new InsertExpressions();

            var p1 = new Person()
            {
                FirstName = "Bugs",
                LastName = "Bunny",
                BirthDate = new DateTime(1940, 6, 27),
                GenderType = GenderType.Male,
                CreditLimit = 75000,
                YearOfLastCreditLimitReview = 2018,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            var p2 = new Person()
            {
                FirstName = "Elmer",
                LastName = "Fudd",
                BirthDate = new DateTime(1940, 3, 2),
                GenderType = GenderType.Male,
                CreditLimit = 1200,
                YearOfLastCreditLimitReview = 2018,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            var p3 = new Person()
            {
                FirstName = "Porky",
                LastName = "Pig",
                BirthDate = new DateTime(1935, 3, 2),
                GenderType = GenderType.Male,
                CreditLimit = 7500,
                YearOfLastCreditLimitReview = 2018,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            var p4 = new Person()
            {
                FirstName = "Daffy",
                LastName = "Duck",
                BirthDate = new DateTime(1937, 4, 17),
                GenderType = GenderType.Male,
                CreditLimit = 10000,
                YearOfLastCreditLimitReview = 2015,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            var p5 = new Person()
            {
                FirstName = "Witch",
                LastName = "Hazel",
                BirthDate = new DateTime(1954, 7, 24),
                GenderType = GenderType.Female,
                CreditLimit = 35000,
                YearOfLastCreditLimitReview = 2016,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            insert.BatchInsertPeople(p1, p2, p3, p4, p5);
        }
        #endregion

        #region simple update expressions
        static void RunUpdateExpressions()
        {
            var updates = new UpdateExpressions();

            updates.SimpleUpdatePersonSetCreditScore(1, 50000);

            updates.UpdateCreditLimitForAllGenderMatchWithinZip(GenderType.Female, "80440", 1500);

        }
        #endregion

        #region simple update expression
        static void RunSimpleUpdateExpression()
        {
            var updates = new UpdateExpressions();

            updates.SimpleUpdatePersonSetCreditScore(1, 50000);

        }
        #endregion
    }
}
