using NUnit.Framework;
using System.Collections.Generic;

namespace RouteBuilder.Tests
{
    /// <summary>
    /// Route builder unit tests.
    /// </summary>
    [TestFixture]
    public class RouteBuilderTests
    {
        /// <summary>
        /// Make sure the route is built correctly.
        /// </summary>
        [Test]
        public void EnsureRouteCorrectness()
        {
            var paths = new List<Path>
            {
                new Path { From = "Москва", To = "Тюмень" },
                new Path { From = "Тюмень", To = "Сочи" },
                new Path { From = "Ростов-на-Дону", To = "Москва" },
            };

            var actualRoute = new RouteBuilder().BuildRoute(paths);
            var expectedRoute = "Ростов-на-Дону - Москва - Тюмень - Сочи";

            Assert.AreEqual(expectedRoute, actualRoute);
        }
    }
}
