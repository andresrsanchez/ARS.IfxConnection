using IBM.Data.DB2.Core;
using Xunit;

namespace ARS.IfxConnection
{
    public class IfxConnectionTests
    {
        [Fact]
        public void IfxConnection_ShouldNotThrowException()
        {
            const string connectionString = "Server=127.0.0.1:9089;Database=iot;UID=informix;PWD=in4mix;Persist Security Info=True;Authentication=Server;";
            using (var conn = new DB2Connection(connectionString))
            {
                conn.Open();
            }
        }

        [Fact]
        public void IfxConnection_ResultShouldBeOne()
        {
            /* Arrange */
            object actualValue;
            const string query = @"SELECT Id 
                                   FROM DummyTable";
            const string connectionString = "Server=127.0.0.1:9089;Database=dummyifx;UID=informix;PWD=in4mix;Persist Security Info=True;Authentication=Server;";

            /* Act */
            using (var conn = new DB2Connection(connectionString))
            {
                conn.Open();
                using (var command = new DB2Command(query, conn))
                {
                    actualValue = command.ExecuteScalar();
                }
            }

            /* Assert */
            Assert.Equal(1, actualValue);
        }
    }
}
