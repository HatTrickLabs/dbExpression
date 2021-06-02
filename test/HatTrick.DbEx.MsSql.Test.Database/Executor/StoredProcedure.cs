﻿using DbEx.Data;
using DbEx.DataService;
using DbEx.dboData;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Database.Executor
{
    [Trait("Statement", "STORED_PROCEDURE")]
    public partial class StoredProcedure : ExecutorTestBase
    {

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_ignored_input_parameter_with_default_and_return_scalar_value(int version, int expected = 3)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var id = db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input_And_Default_Value().GetValue<int>().Execute();

            //then
            id.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_parameter_and_return_dynamic(int version, int id = 1)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var person = db.sp.dbo.SelectPerson_As_Dynamic_With_Input(id).GetValue().Execute();

            //then
            ((int)person.Id).Should().Be(id);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_null_input_parameter_and_return_dynamic(int version, int? id = null)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var person = db.sp.dbo.SelectPerson_As_Dynamic_With_Input(id).GetValue().Execute();

            //then
            ((object)person).Should().BeNull();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_parameter_and_return_dynamic_list(int version, int id = 0, int expected = 50)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var persons = db.sp.dbo.SelectPerson_As_DynamicList_With_Input(id).GetValues<int?>().Execute();

            //then
            persons.Should().HaveCount(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_null_input_parameter_and_return_dynamic_list(int version, int? id = null)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var persons = db.sp.dbo.SelectPerson_As_DynamicList_With_Input(id).GetValues().Execute();

            //then
            persons.Should().BeEmpty();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_parameter_and_return_scalar_value(int version, int id = 1)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var value = db.sp.dbo.SelectPerson_As_Dynamic_With_Input(id).GetValue<int>().Execute();

            //then
            value.Should().Be(id);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_null_input_parameter_and_return_scalar_value(int version, int? id = null)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var value = db.sp.dbo.SelectPerson_As_Dynamic_With_Input(id).GetValue<int?>().Execute();

            //then
            value.Should().BeNull();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_parameter_and_return_scalar_value_list(int version, int id = 0, int expected = 50)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var values = db.sp.dbo.SelectPersonId_As_ScalarValueList_With_Input(id).GetValues<int>().Execute();

            //then
            values.Should().HaveCount(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_null_input_parameter_and_return_scalar_value_list(int version, int? id = null)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var values = db.sp.dbo.SelectPerson_As_Dynamic_With_Input(id).GetValues<int?>().Execute();

            //then
            values.Should().BeEmpty();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_and_output_parameters_and_return_dynamic(int version, int id = 1)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var count = 0;

            //when               
            var person = db.sp.dbo.SelectPerson_As_Dynamic_With_Input_And_Output(id, p => count = p[nameof(count)].GetValue<int>()).GetValue().Execute();

            //then
            ((int)person.Id).Should().Be(id);
            count.Should().Be(id);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_and_output_parameters_and_return_dynamic_list(int version, int id = 0, int expected = 50)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var count = 0;

            //when               
            var persons = db.sp.dbo.SelectPerson_As_DynamicList_With_Input_And_Output(id, p => count = p[nameof(count)].GetValue<int>()).GetValues().Execute();

            //then
            persons.Should().HaveCount(expected);
            count.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_and_inputoutput_parameter_and_return_scalar_value(int version, int id = 1, int creditLimit = 10000)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var outCreditLimit = 0;

            //when               
            var personId = db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input_And_InputOutput(id, creditLimit, p => outCreditLimit = p[nameof(creditLimit)].GetValue<int>()).GetValue<int>().Execute();

            //then
            personId.Should().Be(id);
            outCreditLimit.Should().Be(creditLimit * 2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_and_inputoutput_parameter_and_return_scalar_value_list(int version, int id = 1, int creditLimit = 10000, int expected = 11)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var outCreditLimit = 0;

            //when               
            var persons = db.sp.dbo.SelectPersonId_As_ScalarValueList_With_Input_And_InputOutput(id, creditLimit, p => outCreditLimit = p[nameof(creditLimit)].GetValue<int>()).GetValues().Execute();

            //then
            persons.Should().HaveCount(expected);
            outCreditLimit.Should().Be(creditLimit * 2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_and_inputoutput_parameter_and_return_dynamic_value(int version, int id = 1, int creditLimit = 10000)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var outCreditLimit = 0;

            //when               
            var person = db.sp.dbo.SelectPerson_As_Dynamic_With_Input_And_InputOutput(id, creditLimit, p => outCreditLimit = p[nameof(creditLimit)].GetValue<int>()).GetValue().Execute();

            //then
            ((int)person.Id).Should().Be(id);
            outCreditLimit.Should().Be(creditLimit * 2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_and_inputoutput_parameter_and_return_dynamic_list(int version, int id = 1, int creditLimit = 10000, int expected = 11)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var outCreditLimit = 0;

            //when               
            var persons = db.sp.dbo.SelectPerson_As_DynamicList_With_Input_And_InputOutput(id, creditLimit, p => outCreditLimit = p[nameof(creditLimit)].GetValue<int>()).GetValues().Execute();

            //then
            persons.Should().HaveCount(expected);
            outCreditLimit.Should().Be(creditLimit * 2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Can_execute_stored_procedure_with_input_and_output_parameter_with_no_return(int version, int id = 1, int creditLimit = 99999)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            db.sp.dbo.UpdatePersonCreditLimit_With_Inputs(id, creditLimit).Execute();

            //then
            var updated = db.SelectOne(dbo.Person.CreditLimit).From(dbo.Person).Where(dbo.Person.Id == id).Execute();
            updated.Should().Be(creditLimit);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_ignored_input_parameter_with_default_and_return_scalar_value(int version, int expected = 3)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var id = await db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input_And_Default_Value().GetValue<int>().ExecuteAsync();

            //then
            id.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_parameter_and_return_dynamic(int version, int id = 1)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var person = await db.sp.dbo.SelectPerson_As_Dynamic_With_Input(id).GetValue().ExecuteAsync();

            //then
            ((int)person.Id).Should().Be(id);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_null_input_parameter_and_return_dynamic(int version, int? id = null)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var person = await db.sp.dbo.SelectPerson_As_Dynamic_With_Input(id).GetValue().ExecuteAsync();

            //then
            ((object)person).Should().BeNull();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_parameter_and_return_dynamic_list(int version, int id = 0, int expected = 50)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var persons = await db.sp.dbo.SelectPerson_As_DynamicList_With_Input(id).GetValues<int?>().ExecuteAsync();

            //then
            persons.Should().HaveCount(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_null_input_parameter_and_return_dynamic_list(int version, int? id = null)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var persons = await db.sp.dbo.SelectPerson_As_DynamicList_With_Input(id).GetValues().ExecuteAsync();

            //then
            persons.Should().BeEmpty();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_parameter_and_return_scalar_value(int version, int id = 1)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var value = await db.sp.dbo.SelectPerson_As_Dynamic_With_Input(id).GetValue<int>().ExecuteAsync();

            //then
            value.Should().Be(id);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_null_input_parameter_and_return_scalar_value(int version, int? id = null)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var value = await db.sp.dbo.SelectPerson_As_Dynamic_With_Input(id).GetValue<int?>().ExecuteAsync();

            //then
            value.Should().BeNull();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_parameter_and_return_scalar_value_list(int version, int id = 0, int expected = 50)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var values = await db.sp.dbo.SelectPersonId_As_ScalarValueList_With_Input(id).GetValues<int>().ExecuteAsync();

            //then
            values.Should().HaveCount(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_null_input_parameter_and_return_scalar_value_list(int version, int? id = null)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            var values = await db.sp.dbo.SelectPerson_As_Dynamic_With_Input(id).GetValues<int?>().ExecuteAsync();

            //then
            values.Should().BeEmpty();
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_and_output_parameters_and_return_dynamic(int version, int id = 1)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var count = 0;

            //when               
            var person = await db.sp.dbo.SelectPerson_As_Dynamic_With_Input_And_Output(id, p => count = p[nameof(count)].GetValue<int>()).GetValue().ExecuteAsync();

            //then
            ((int)person.Id).Should().Be(id);
            count.Should().Be(id);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_and_output_parameters_and_return_dynamic_list(int version, int id = 0, int expected = 50)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var count = 0;

            //when               
            var persons = await db.sp.dbo.SelectPerson_As_DynamicList_With_Input_And_Output(id, p => count = p[nameof(count)].GetValue<int>()).GetValues().ExecuteAsync();

            //then
            persons.Should().HaveCount(expected);
            count.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_and_inputoutput_parameter_and_return_scalar_value(int version, int id = 1, int creditLimit = 10000)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var outCreditLimit = 0;

            //when               
            var personId = await db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input_And_InputOutput(id, creditLimit, p => outCreditLimit = p[nameof(creditLimit)].GetValue<int>()).GetValue<int>().ExecuteAsync();

            //then
            personId.Should().Be(id);
            outCreditLimit.Should().Be(creditLimit * 2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_and_inputoutput_parameter_and_return_scalar_value_list(int version, int id = 1, int creditLimit = 10000, int expected = 11)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var outCreditLimit = 0;

            //when               
            var persons = await db.sp.dbo.SelectPersonId_As_ScalarValueList_With_Input_And_InputOutput(id, creditLimit, p => outCreditLimit = p[nameof(creditLimit)].GetValue<int>()).GetValues().ExecuteAsync();

            //then
            persons.Should().HaveCount(expected);
            outCreditLimit.Should().Be(creditLimit * 2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_and_inputoutput_parameter_and_return_dynamic_value(int version, int id = 1, int creditLimit = 10000)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var outCreditLimit = 0;

            //when               
            var person = await db.sp.dbo.SelectPerson_As_Dynamic_With_Input_And_InputOutput(id, creditLimit, p => outCreditLimit = p[nameof(creditLimit)].GetValue<int>()).GetValue().ExecuteAsync();

            //then
            ((int)person.Id).Should().Be(id);
            outCreditLimit.Should().Be(creditLimit * 2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_and_inputoutput_parameter_and_return_dynamic_list(int version, int id = 1, int creditLimit = 10000, int expected = 11)
        {
            //given
            ConfigureForMsSqlVersion(version);
            var outCreditLimit = 0;

            //when               
            var persons = await db.sp.dbo.SelectPerson_As_DynamicList_With_Input_And_InputOutput(id, creditLimit, p => outCreditLimit = p[nameof(creditLimit)].GetValue<int>()).GetValues().ExecuteAsync();

            //then
            persons.Should().HaveCount(expected);
            outCreditLimit.Should().Be(creditLimit * 2);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Can_execute_async_stored_procedure_with_input_and_output_parameter_with_no_return(int version, int id = 1, int creditLimit = 99999)
        {
            //given
            ConfigureForMsSqlVersion(version);

            //when               
            await db.sp.dbo.UpdatePersonCreditLimit_With_Inputs(id, creditLimit).ExecuteAsync();

            //then
            var updated = await db.SelectOne(dbo.Person.CreditLimit).From(dbo.Person).Where(dbo.Person.Id == id).ExecuteAsync();
            updated.Should().Be(creditLimit);
        }
    }
}