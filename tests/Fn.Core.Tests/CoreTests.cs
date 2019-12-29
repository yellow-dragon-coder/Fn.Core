using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Fn.Core.Tests
{
    public class CoreTests
    {
        [Fact]
        public void In_Should_Work()
        {
            "A".In("A", "B", "C").Should().BeTrue();
            2.In(1, 2, 3, 4).Should().BeTrue();
            5.In(1, 2, 3, 4).Should().BeFalse();
            1.In(new List<int> { 1, 2, 3 }).Should().BeTrue();
            const string s = null;
            Assert.Throws<NullReferenceException>(() => s.In("X", "Y", "Z"));
        }
    }
}
