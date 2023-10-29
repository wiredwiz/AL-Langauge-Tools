using Org.Edgerunner.BC.AL.Language.Lexers;
using Org.Edgerunner.Buffers.Input;
using System.Text;
using FluentAssertions;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Language.Lexers;

// ReSharper disable ExceptionNotDocumented
// ReSharper disable TooManyDeclarations

namespace Org.Edgerunner.BC.AL.Language.Parsers.Tests
{
   public class VariableTests
   {
      [Fact]
      public void Text_variable_parses_correctly()
      {
         // loading a demo al file
         var buffer = new TextBuffer("Variables.al", Encoding.Default.CodePage);
         var lexer = new AlLexer();

         // Then tokenizing the file into a token stream
         var stream = new TokenStream<AlToken>(lexer.ReadTokensFromBuffer(buffer));

         // And moving the token stream to the text variable declaration
         stream.Position = 8;

         // And finally parsing the text declaration tokens
         var context = new AlParserContext();
         var parser = new AlParser();
         parser.ParseVariableDeclaration(stream, context);

         // results in the expected parse tree
         context.State.Should().Be(0);
         var rule = context.CurrentRule;
         rule.Should().NotBeNull();
         rule!.Parent.Should().BeNull();
         rule.Start.StartingLine.Should().Be(3);
         rule.Start.StartingColumn.Should().Be(4);
         rule.End.EndingLine.Should().Be(3);
         rule.End.EndingColumn.Should().Be(25);
      }

      [Fact]
      public void Option_variable_parses_correctly()
      {
         // loading a demo al file
         var buffer = new TextBuffer("Variables.al", Encoding.Default.CodePage);
         var lexer = new AlLexer();

         // Then tokenizing the file into a token stream
         var stream = new TokenStream<AlToken>(lexer.ReadTokensFromBuffer(buffer));

         // And moving the token stream to the option variable declaration
         stream.Position = 15;

         // And finally parsing the option declaration tokens
         var context = new AlParserContext();
         var parser = new AlParser();
         parser.ParseVariableDeclaration(stream, context);

         // results in the expected parse tree
         context.State.Should().Be(0);
         var rule = context.CurrentRule;
         rule.Should().NotBeNull();
         rule!.Parent.Should().BeNull();
         rule.Start.StartingLine.Should().Be(4);
         rule.Start.StartingColumn.Should().Be(4);
         rule.End.EndingLine.Should().Be(4);
         rule.End.EndingColumn.Should().Be(39);
      }

      [Theory]
      [InlineData(24, 5, 4, 5, 31)]
      [InlineData(29, 6, 4, 6, 24)]
      public void Record_variable_parses_correctly(int streamPosition, int startLine, int startColumn, int endLine, int endColumn)
      {
         // loading a demo al file
         var buffer = new TextBuffer("Variables.al", Encoding.Default.CodePage);
         var lexer = new AlLexer();

         // Then tokenizing the file into a token stream
         var stream = new TokenStream<AlToken>(lexer.ReadTokensFromBuffer(buffer));

         // And moving the token stream to the option variable declaration
         stream.Position = streamPosition;

         // And finally parsing the record declaration tokens
         var context = new AlParserContext();
         var parser = new AlParser();
         parser.ParseVariableDeclaration(stream, context);

         // results in the expected parse tree
         context.State.Should().Be(0);
         var rule = context.CurrentRule;
         rule.Should().NotBeNull();
         rule!.Parent.Should().BeNull();
         rule.Start.StartingLine.Should().Be(startLine);
         rule.Start.StartingColumn.Should().Be(startColumn);
         rule.End.EndingLine.Should().Be(endLine);
         rule.End.EndingColumn.Should().Be(endColumn);
      }
   }
}