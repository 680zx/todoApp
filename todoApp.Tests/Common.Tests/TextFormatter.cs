using NUnit.Framework;
using todoApp.Common;
using todoApp.Common.Interfaces;

namespace todoApp.Tests.Common.Tests
{
    [TestFixture]
    class TextFormatterTests
    {
        [Test]
        public void Format_SimpleString_FormattedStringReturned()
        {
            // Arrange
            const int MAX_ROW_LENGTH = 64;
            ITextFormatter textFormatter = new TextFormatter(MAX_ROW_LENGTH);
            var text = 
                "Haskell (/ˈhæskəl/[27]) is a general-purpose, statically typed, " +
                "purely functional programming language with type inference and lazy evaluation." +
                "[28][29] Designed for teaching, research and industrial application, Haskell has " +
                "pioneered a number of advanced programming language features such as type classes, " +
                "which enable type-safe operator overloading. Haskell's main implementation is the " +
                "Glasgow Haskell Compiler (GHC). It is named after logician Haskell Curry.";

            const string DESIRED_STRING = 
                "Haskell (/ˈhæskəl/[27]) is a general-purpose, statically typed,\n" +
                "purely functional programming language with type inference and\n" +
                "lazy evaluation.[28][29] Designed for teaching, research and\n" +
                "industrial application, Haskell has pioneered a number of\n" +
                "advanced programming language features such as type classes,\n" +
                "which enable type-safe operator overloading. Haskell's main\n" +
                "implementation is the Glasgow Haskell Compiler (GHC). It is\n" +
                "named after logician Haskell Curry.";

            // Act
            var result = textFormatter.Format(text);

            // Arrange
            Assert.AreEqual(DESIRED_STRING, result);
        }
    }
}
