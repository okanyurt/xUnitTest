using System;
using Xunit;

namespace Calculations.Test
{
    public class NameTestCase
    {
        public Names name => new Names();
    }
    public class Name_TestCase : IClassFixture<NameTestCase>
    {
        private readonly NameTestCase _name;
        public Name_TestCase(NameTestCase name)
        {
            _name = name;
        }
        [Fact]
        public void MakeFullNameTest()
        {
            //var names = new Names();
            var names = _name.name;
            var result = names.MakeFullName("okan", "Yurt");
            //Assert.Equal("Okan Yurt", result);
            //Assert.Contains("Okan",result,StringComparison.InvariantCultureIgnoreCase);
            Assert.StartsWith("okan", result, StringComparison.InvariantCultureIgnoreCase);
            //Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }
        [Fact]
        public void NickName_MustBeNull()
        {
            //var names = new Names();
            var names = _name.name;
            Assert.Null(names.NickName);
           // Assert.NotNull(names.NickName);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            //var names = new Names();
            var names = _name.name;
            var result = names.MakeFullName("Okan", "Yurt");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
