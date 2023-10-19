using System.Text;
using FluentAssertions;
using Org.Edgerunner.BC.AL.Parsing.Lexers;
using Org.Edgerunner.BC.AL.Parsing.Tokens;
using Org.Edgerunner.Buffers;
using Org.Edgerunner.Buffers.Input;

namespace Org.Edgerunner.BC.AL.Parsing.Tests
{
   public class LexerTests
   {
      [Theory]
      [InlineData(1, 7, "14")]
      [InlineData(15, 15, "2")]
      [InlineData(15, 29, "100")]
      public void Fetching_an_integer_literal_token_results_in_the_correct_result(int lineNumber, int position, string number)
      {
         // Given a new AL lexer
         var lexer = new AlLexer();

         // loading a demo al file
         var buffer = new TextBuffer("demo.al", Encoding.Default.CodePage);

         // setting the buffer position
         buffer.SetBufferPoint(new BufferPoint(lineNumber, position));

         // and then reading a token
         var token = lexer.ReadTokenFromBuffer(buffer) as LiteralToken;

         // The token is a valid LiteralToken of type integer
         token.LiteralType.Should().Be(LiteralType.Integer);
         token.TokenType.Should().Be((int)TokenType.Literal);
         token.Value.Should().Be(number);
      }

      [Theory]
      [InlineData(258, 44, "false")]
      [InlineData(314, 50, "true")]
      public void Fetching_a_boolean_literal_token_results_in_the_correct_result(int lineNumber, int position, string boolean)
      {
         // Given a new AL lexer
         var lexer = new AlLexer();

         // loading a demo al file
         var buffer = new TextBuffer("demo.al", Encoding.Default.CodePage);

         // setting the buffer position
         buffer.SetBufferPoint(new BufferPoint(lineNumber, position));

         // and then reading a token
         var token = lexer.ReadTokenFromBuffer(buffer) as LiteralToken;

         // The token is a valid LiteralToken of type integer
         token.LiteralType.Should().Be(LiteralType.Boolean);
         token.TokenType.Should().Be((int)TokenType.Literal);
         token.Value.Should().Be(boolean);
      }

      [Theory]
      [InlineData(249, 40, "\"Warehouse Receipt Header\"", false)]
      [InlineData(252, 17, "if", true)]
      [InlineData(251, 13, "begin", true)]
      public void Fetching_an_identifier_token_results_in_the_correct_result(int lineNumber, int position, string name, bool reserved)
      {
         // Given a new AL lexer
         var lexer = new AlLexer();

         // loading a demo al file
         var buffer = new TextBuffer("demo.al", Encoding.Default.CodePage);

         // setting the buffer position
         buffer.SetBufferPoint(new BufferPoint(lineNumber, position));

         // and then reading a token
         var token = lexer.ReadTokenFromBuffer(buffer) as IdentifierToken;

         // The token is a valid LiteralToken of type integer
         token.ReservedWord.Should().Be(reserved);
         token.TokenType.Should().Be((int)TokenType.Identifier);
         token.Value.Should().Be(name);
      }
   }
}