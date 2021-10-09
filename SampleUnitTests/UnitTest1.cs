using System;
using FluentAndCSharpExtensions;
using FluentAssertions;
using Xunit;

namespace SampleUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var fileName = "file_Name";
            fileName.ToAttachmentKey().Should().Be(fileName);
        }
    }
}