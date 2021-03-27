﻿using System;
using System.Collections.Generic;
using HatTrick.DbEx.Sql;
using HatTrick.DbEx.MsSql.Expression;
using SimpleConsole.Data;
using SimpleConsole.DataService;
using SimpleConsole.dboData;
using SimpleConsole.dboDataService;
using SimpleConsole.secDataService;

namespace NetCoreConsoleApp
{
	public class Aliasing : IExecute
	{
		#region execute
		public void Execute()
		{
			var maxPurchaseInfo = this.GetPersonMaxPurchaseInfo(9);
			(string, string) nameAndLocality = this.GetPersonFullNameAndCityAndStateAndZipCode(8);
			(int, string, string) idAndNameAndSSN = this.GetPersonIdAndPersonFullNameAndPersonSSN(8);
		}
		#endregion

		#region column aliasing
		public dynamic GetPersonMaxPurchaseInfo(int personId)
		{
			//select
			//dbo.Person.Id as PersonId,
			//dbo.Purchase.Id as PurchaseId,
			//dbo.Purchase.TotalPurchaseAmount as PurchaseAmount
			//from dbo.Person
			//inner join dbo.Purchase on dbo.Purchase.PersonId = dbo.Person.Id
			//where dbo.Person.Id = {personId};
			var result = db.SelectOne(
						dbo.Person.Id.As("PersonId"),
						dbo.Purchase.Id.As("PurchaseId"),
						dbo.Purchase.TotalPurchaseAmount.As("PurchaseAmount")
					)
				.From(dbo.Person)
				.InnerJoin(dbo.Purchase).On(dbo.Purchase.PersonId == dbo.Person.Id)
				.Where(dbo.Person.Id == personId)
				.Execute();

			//newing up another anonymous object is totally unnecessary, but shows that the aliases are now the dynamic properties
			return result == null 
				? null 
				: new { result.PersonId, result.PurchaseId, result.PurchaseAmount };
		}

		public (string, string) GetPersonFullNameAndCityAndStateAndZipCode(int personId)
		{
			//select
			//*
			//from dbo.Person
			//inner join dbo.Person_Address on dbo.Person_Address.PersonId = dbo.Person.Id
			//inner join dbo.Address on dbo.Address.Id = dbo.Person_Address.AddressId
			//where dbo.Person.Id = {personId};
			var result = db.SelectOne(
					db.fx.Concat(dbo.Person.FirstName, " ", dbo.Person.LastName).As("FullName"),
					db.fx.Concat(dbo.Address.City, ", ", dbo.Address.State, db.fx.Concat(" ", dbo.Address.Zip)).As("Locality")
					)
				.From(dbo.Person)
				.InnerJoin(dbo.PersonAddress).On(dbo.PersonAddress.PersonId == dbo.Person.Id)
				.InnerJoin(dbo.Address).On(dbo.Address.Id == dbo.PersonAddress.AddressId)
				.Where(dbo.Person.Id == personId)
				.Execute();

			return ValueTuple.Create(result.FullName, result.Locality);
		}
		#endregion

		#region table aliasing
		public (int, string, string) GetPersonIdAndPersonFullNameAndPersonSSN(int personId)
		{
			//NOTE:  both schemas contain a Person table -- sec.Person and dbo.Person
			//sec.Person contains secure data (Social Security Number)

			//select
			//dbo.Person.Id,
			//CONCAT(dbo.Person.FirstName, ' ', dbo.Person.LastName) as FullName,
			//secure.SSN
			//from dbo.Person
			//inner join sec.Person secure on secure.Id = dbo.Person.Id
			//where dbo.Person.Id = {personId};
			var result = db.SelectOne(
					dbo.Person.Id,
					db.fx.Concat(dbo.Person.FirstName, " ", dbo.Person.LastName).As("FullName"),
					sec.Person.As("secure").SSN
					)
				.From(dbo.Person)
				.InnerJoin(sec.Person.As("secure")).On(sec.Person.As("secure").Id == dbo.Person.Id)
				.Where(dbo.Person.Id == personId)
				.Execute();

			return ValueTuple.Create(result.Id, result.FullName, result.SSN);
		}
		#endregion
	}
}
