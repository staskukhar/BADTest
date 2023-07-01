using FirstUniqueLib;

namespace FirstUniqueLibTest;

public class UnitTest1
{
    [Fact]
    public void TestMethodSerach1()
    {
        Char expextedValue = 'm';
        var actualValue = Searcher.Search("The Tao gave birth to machine language. Machine language gave birthto the assembler.The assembler gave birth to the compiler. Now there are ten thousandlanguages.Each language has its purpose, however humble. Each languageexpresses the Yin and Yang of software. Each language has its place withinthe Tao. But do not program in COBOL if you can avoid it.");
        Assert.Equal(expextedValue, actualValue);
    }
}