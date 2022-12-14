using FluentAssertions;
using NanoBlog.Attributes;

namespace NanoBlog.Test.Attributes.FileNameValidationAttribute;

public class IsValid
{
    [Fact]
    public void TestValidFileName()
    {
        var sut = new ValidFileName();

        sut.IsValid("a-normal-file.txt").Should().BeTrue();
        sut.IsValid("THIS-is--1-tEsT.txt").Should().BeTrue();
    }
    
    [Fact]
    public void TestInvalidFileName()
    {
        var sut = new ValidFileName();

        sut.IsValid("What\tare whitespaces anyway?.txt").Should().BeFalse();
        sut.IsValid("__.txt").Should().BeFalse();
        sut.IsValid("/../../../etc/passwd.txt").Should().BeFalse();
        sut.IsValid("🏳‍🌈🏳‍🌈🏳‍🌈.txt").Should().BeFalse();
        sut.IsValid("https://raw.githubusercontent.com/neon-JS/NanoBlog/main/src/BlogFiles/Structure/footer.txt")
            .Should()
            .BeFalse();
        sut.IsValid("totally-harmless.exe").Should().BeFalse();
    }
}