using DbEx.DataService;
using DbEx.dboData;
using DbEx.dboDataService;
using FluentAssertions;
using HatTrick.DbEx.MsSql.Test.Executor;
using HatTrick.DbEx.Sql.Expression;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace HatTrick.DbEx.MsSql.Test.Integration.Events
{
    public class StoredProcedureEventCompositionTests : ResetDatabaseNotRequired
    {
        [Theory]
        [MsSqlVersions.AllVersions]
        public void Do_all_pipeline_events_fire_when_executing_a_stored_procedure(int version, int expected = 10)
        {
            //given
            var executionCount = 0;
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version,
                    c => c.Events
                        .OnBeforeStart(_ => executionCount++)
                        .OnBeforeStoredProcedureStart(_ => executionCount++)
                        .OnAfterStoredProcedureAssembly(_ => executionCount++)
                        .OnAfterAssembly(_ => executionCount++)
                        .OnBeforeCommand(_ => executionCount++)
                        .OnBeforeStoredProcedureCommand(_ => executionCount++)
                        .OnAfterStoredProcedureCommand(_ => executionCount++)
                        .OnAfterCommand(_ => executionCount++)
                        .OnAfterStoredProcedureComplete(_ => executionCount++)
                        .OnAfterComplete(_ => executionCount++)
                    );

            //when
            db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input(1).Execute();

            //then
            executionCount.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Do_all_pipeline_events_fire_when_executing_a_stored_procedure_and_event_confiugurations_are_repeated(int version, int expected = 20)
        {
            //given
            var executionCount = 0;
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version,
                    c => c.Events
                        .OnBeforeStart(_ => executionCount++)
                        .OnBeforeStart(_ => executionCount++)

                        .OnBeforeStoredProcedureStart(_ => executionCount++)
                        .OnBeforeStoredProcedureStart(_ => executionCount++)

                        .OnAfterStoredProcedureAssembly(_ => executionCount++)
                        .OnAfterStoredProcedureAssembly(_ => executionCount++)

                        .OnAfterAssembly(_ => executionCount++)
                        .OnAfterAssembly(_ => executionCount++)

                        .OnBeforeCommand(_ => executionCount++)
                        .OnBeforeCommand(_ => executionCount++)

                        .OnBeforeStoredProcedureCommand(_ => executionCount++)
                        .OnBeforeStoredProcedureCommand(_ => executionCount++)

                        .OnAfterStoredProcedureCommand(_ => executionCount++)
                        .OnAfterStoredProcedureCommand(_ => executionCount++)

                        .OnAfterCommand(_ => executionCount++)
                        .OnAfterCommand(_ => executionCount++)

                        .OnAfterStoredProcedureComplete(_ => executionCount++)
                        .OnAfterStoredProcedureComplete(_ => executionCount++)

                        .OnAfterComplete(_ => executionCount++)
                        .OnAfterComplete(_ => executionCount++)
                    );

            //when
            db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input(1).Execute();

            //then
            executionCount.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Do_all_pipeline_events_fire_in_order_when_executing_a_stored_procedure(int version, string expected = "9876543210")
        {
            //given
            var execution = "";
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version,
                    c => c.Events
                        .OnBeforeStart(_ => execution += "9")
                        .OnBeforeStoredProcedureStart(_ => execution += "8")
                        .OnAfterStoredProcedureAssembly(_ => execution += "7")
                        .OnAfterAssembly(_ => execution += "6")
                        .OnBeforeCommand(_ => execution += "5")
                        .OnBeforeStoredProcedureCommand(_ => execution += "4")
                        .OnAfterStoredProcedureCommand(_ => execution += "3")
                        .OnAfterCommand(_ => execution += "2")
                        .OnAfterStoredProcedureComplete(_ => execution += "1")
                        .OnAfterComplete(_ => execution += "0")
                    );

            //when
            db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input(1).Execute();

            //then
            execution.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public void Do_all_pipeline_events_fire_when_executing_a_stored_procedure_and_predicate_is_met(int version, int expected = 10)
        {
            //given
            var executionCount = 0;
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version,
                    c => c.Events
                        .OnBeforeStart(_ => executionCount++, c => c.Expression.IsStoredProcedureQueryExpression())
                        .OnBeforeStoredProcedureStart(_ => executionCount++, c => c.Expression.IsStoredProcedureQueryExpression())
                        .OnAfterStoredProcedureAssembly(_ => executionCount++, c => c.Expression.IsStoredProcedureQueryExpression())
                        .OnAfterAssembly(_ => executionCount++, c => c.Expression.IsStoredProcedureQueryExpression())
                        .OnBeforeCommand(_ => executionCount++, c => c.Expression.IsStoredProcedureQueryExpression())
                        .OnBeforeStoredProcedureCommand(_ => executionCount++, c => c.Expression.IsStoredProcedureQueryExpression())
                        .OnAfterStoredProcedureCommand(_ => executionCount++, c => c.Expression.IsStoredProcedureQueryExpression())
                        .OnAfterCommand(_ => executionCount++, c => c.Expression.IsStoredProcedureQueryExpression())
                        .OnAfterStoredProcedureComplete(_ => executionCount++, c => c.Expression.IsStoredProcedureQueryExpression())
                        .OnAfterComplete(_ => executionCount++, c => c.Expression.IsStoredProcedureQueryExpression())
                    );

            //when
            db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input(1).Execute();

            //then
            executionCount.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Do_all_pipeline_events_fire_when_executing_a_stored_procedure_async(int version, int expected = 10)
        {
            //given
            var executionCount = 0;
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version,
                    c => c.Events
                        .OnBeforeStart(_ => executionCount++)
                        .OnBeforeStoredProcedureStart(_ => executionCount++)
                        .OnAfterStoredProcedureAssembly(_ => executionCount++)
                        .OnAfterAssembly(_ => executionCount++)
                        .OnBeforeCommand(_ => executionCount++)
                        .OnBeforeStoredProcedureCommand(_ => executionCount++)
                        .OnAfterStoredProcedureCommand(_ => executionCount++)
                        .OnAfterCommand(_ => executionCount++)
                        .OnAfterStoredProcedureComplete(_ => executionCount++)
                        .OnAfterComplete(_ => executionCount++)
                    );

            //when
            await db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input(1).ExecuteAsync();

            //then
            executionCount.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Do_all_pipeline_events_fire_when_executing_a_stored_procedure_async_and_event_configurations_are_repeated(int version, int expected = 20)
        {
            //given
            var executionCount = 0;
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version,
                    c => c.Events
                        .OnBeforeStart(_ => executionCount++)
                        .OnBeforeStart(_ => executionCount++)

                        .OnBeforeStoredProcedureStart(_ => executionCount++)
                        .OnBeforeStoredProcedureStart(_ => executionCount++)

                        .OnAfterStoredProcedureAssembly(_ => executionCount++)
                        .OnAfterStoredProcedureAssembly(_ => executionCount++)

                        .OnAfterAssembly(_ => executionCount++)
                        .OnAfterAssembly(_ => executionCount++)

                        .OnBeforeCommand(_ => executionCount++)
                        .OnBeforeCommand(_ => executionCount++)

                        .OnBeforeStoredProcedureCommand(_ => executionCount++)
                        .OnBeforeStoredProcedureCommand(_ => executionCount++)

                        .OnAfterStoredProcedureCommand(_ => executionCount++)
                        .OnAfterStoredProcedureCommand(_ => executionCount++)

                        .OnAfterCommand(_ => executionCount++)
                        .OnAfterCommand(_ => executionCount++)

                        .OnAfterStoredProcedureComplete(_ => executionCount++)
                        .OnAfterStoredProcedureComplete(_ => executionCount++)

                        .OnAfterComplete(_ => executionCount++)
                        .OnAfterComplete(_ => executionCount++)
                    );

            //when
            await db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input(1).ExecuteAsync();

            //then
            executionCount.Should().Be(expected);
        }

        [Theory]
        [MsSqlVersions.AllVersions]
        public async Task Do_all_pipeline_events_fire_in_order_when_executing_a_stored_procedure_async(int version, string expected = "9876543210")
        {
            //given
            var execution = "";
            var (db, serviceProvider) = Configure<MsSqlDb>().ForMsSqlVersion(version,
                    c => c.Events
                        .OnBeforeStart(_ => execution += "9")
                        .OnBeforeStoredProcedureStart(_ => execution += "8")
                        .OnAfterStoredProcedureAssembly(_ => execution += "7")
                        .OnAfterAssembly(_ => execution += "6")
                        .OnBeforeCommand(_ => execution += "5")
                        .OnBeforeStoredProcedureCommand(_ => execution += "4")
                        .OnAfterStoredProcedureCommand(_ => execution += "3")
                        .OnAfterCommand(_ => execution += "2")
                        .OnAfterStoredProcedureComplete(_ => execution += "1")
                        .OnAfterComplete(_ => execution += "0")
                    );

            //when
            await db.sp.dbo.SelectPersonId_As_ScalarValue_With_Input(1).ExecuteAsync();

            //then
            execution.Should().Be(expected);
        }
    }
}