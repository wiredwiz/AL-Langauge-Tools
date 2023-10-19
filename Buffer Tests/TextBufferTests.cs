using FluentAssertions;
using Org.Edgerunner.Buffers.Input;

// ReSharper disable ExceptionNotDocumented

namespace Org.Edgerunner.Buffers.Tests
{
   public class TextBufferTests
   {
      private TextBuffer GenerateTestBuffer()
      {
         var text =
            "This is an example file\n" + // 24 long
            "With a few lines of\r\n" + // 21 long
            "\n" + // 1 long
            "text to test The buffer"; // 23 long
         return new TextBuffer(text);
      }

      [Theory]
      [InlineData(1, "This is an example file\n")]
      [InlineData(2, "With a few lines of\r\n")]
      [InlineData(3, "\n")]
      [InlineData(4, "text to test The buffer")]
      public void Get_a_line_from_the_buffer_works(int line, string text)
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // fetching a specified text line results in the right text
         buffer.GetLine(line).Should().Be(text);
      }

      [Theory]
      [InlineData(1, 1, 'h')]
      [InlineData(2, 1, 'i')]
      [InlineData(3, 1, 's')]
      [InlineData(24, 1, 'W')]
      [InlineData(46, 1, 't')]
      [InlineData(69, 1, '\0')]
      [InlineData(25, -1, '\n')]
      [InlineData(24, -1, 'e')]
      public void Peeking_at_a_character_in_a_buffer_works(int absolute, int offset, char peeked)
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // and moving to the specified absolute position
         buffer.AbsolutePosition = absolute;

         // Peeking at a character results in the right character
         buffer.PeekChar(offset).Should().Be(peeked);
      }

      [Theory]
      [InlineData(1, 1, 0, 1, 1)]
      [InlineData(1, 2, -1, 1, 1)]
      [InlineData(2, 1, -1, 1, 24)]
      [InlineData(1, 23, 4, 2, 3)]
      public void Getting_a_buffer_point_in_a_buffer_works(int line, int position, int offset, int resultLine, int resultPosition)
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // and moving to the specified line and position
         buffer.ColumnPosition = 1;
         buffer.LineNumber = line;
         buffer.ColumnPosition = position;

         // Then getting a buffer point results in the correct position
         var point = buffer.GetBufferPoint(offset);
         point.LineNumber.Should().Be(resultLine);
         point.Column.Should().Be(resultPosition);
      }

      [Theory]
      [InlineData(1, 1)]
      [InlineData(1, 24)]
      [InlineData(3, 1)]
      public void Setting_a_buffer_point_in_a_buffer_moves_to_the_correct_position(int line, int position)
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // and moving to the specified line and position
         buffer.MoveToEndOfBuffer();

         // Then getting a buffer point results in the correct position
         buffer.SetBufferPoint(new BufferPoint(line, position));
         buffer.LineNumber.Should().Be(line);
         buffer.ColumnPosition.Should().Be(position);
      }

      [Theory]
      [InlineData(1, 'T')]
      [InlineData(2, 'T')]
      [InlineData(3, 'h')]
      [InlineData(26, 'W')]
      [InlineData(47, '\n')]
      public void Getting_the_previous_character_in_a_buffer_works(int absolute, char next)
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // and moving to the specified absolute position
         buffer.AbsolutePosition = absolute;

         // getting the previous character results in the right character
         buffer.GetPreviousChar().Should().Be(next);
      }

      [Theory]
      [InlineData(1, 'h')]
      [InlineData(2, 'i')]
      [InlineData(3, 's')]
      [InlineData(24, 'W')]
      [InlineData(46, 't')]
      [InlineData(69, '\0')]
      [InlineData(70, '\0')]
      public void Getting_the_next_character_in_a_buffer_works(int absolute, char next)
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // and moving to the specified absolute position
         buffer.AbsolutePosition = absolute;

         // getting the next character results in the right character
         buffer.GetNextChar().Should().Be(next);
      }

      [Theory]
      [InlineData(1, 24, 24)]
      [InlineData(2, 21, 45)]
      [InlineData(3, 1, 46)]
      public void Moving_to_the_end_of_a_buffer_line_works(int line, int position, int absolute)
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // and moving to end of a specified line
         buffer.LineNumber = line;
         buffer.MoveToEndOfLine();

         // Buffer position and content is correct
         buffer.Current.Should().Be('\n');
         buffer.LineNumber.Should().Be(line);
         buffer.ColumnPosition.Should().Be(position);
         buffer.AbsolutePosition.Should().Be(absolute);
      }

      [Theory]
      [InlineData(1, 'T', 1)]
      [InlineData(2, 'W', 25)]
      [InlineData(3, '\n', 46)]
      [InlineData(4, 't', 47)]
      public void Moving_to_the_beginning_of_a_buffer_line_works(int line, char letter, int absoluteIndex)
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // and moving to the beginning of a specified line
         buffer.LineNumber = line;
         buffer.MoveToBeginningOfLine();

         // Buffer position and content is correct
         buffer.Current.Should().Be(letter);
         buffer.LineNumber.Should().Be(line);
         buffer.ColumnPosition.Should().Be(1);
         buffer.AbsolutePosition.Should().Be(absoluteIndex);
      }

      [Fact]
      public void Testing_for_beginning_of_buffer_position_works()
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();
         
         // and moving to the beginning of the buffer
         buffer.MoveToBeginningOfBuffer();

         // results in beginning of the buffer proving true
         buffer.AtBeginningOfBuffer().Should().BeTrue();
         buffer.AtEndOfBuffer().Should().BeFalse();
      }

      [Fact]
      public void Testing_for_end_of_buffer_position_works()
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();
         
         // and moving to the beginning of the buffer
         buffer.MoveToEndOfBuffer();

         // results in end of the buffer proving true
         buffer.AtBeginningOfBuffer().Should().BeFalse();
         buffer.AtEndOfBuffer().Should().BeTrue();
      }
      
      [Fact]
      public void Moving_to_the_beginning_of_a_buffer_works()
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // and advancing to end of line
         buffer.MoveToEndOfLine();

         // and then back to the beginning of the buffer
         buffer.MoveToBeginningOfBuffer();

         // results in the correct buffer position and content
         buffer.Current.Should().Be('T');
         buffer.LineNumber.Should().Be(1);
         buffer.ColumnPosition.Should().Be(1);
      }

      [Fact]
      public void Moving_to_the_end_of_a_buffer_works()
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // and advancing to end of the buffer
         buffer.LineNumber = 2;
         buffer.MoveToEndOfBuffer();

         // Buffer position and content is correct
         buffer.Current.Should().Be('\0');
         buffer.LineNumber.Should().Be(4);
         buffer.ColumnPosition.Should().Be(24);
         buffer.AbsolutePosition.Should().Be(70);
      }

      [Fact]
      public void Buffer_IsEmpty_is_true()
      {
         // Starting with a new empty buffer
         var buffer = new TextBuffer(string.Empty);

         // buffer is empty is true
         buffer.IsEmpty.Should().BeTrue();
      }

      [Fact]
      public void Buffer_IsEmpty_is_false()
      {
         // Starting with a new test buffer
         var buffer = GenerateTestBuffer();

         // buffer is empty is false
         buffer.IsEmpty.Should().BeFalse();
      }

      [Theory]
      [InlineData(-1)]
      [InlineData(0)]
      [InlineData(71)]
      [InlineData(100)]
      public void Moving_to_an_invalid_absolute_position_in_the_buffer_throws_an_exception(int absolutePosition)
      {
         // Starting with a new buffer
         var buffer = GenerateTestBuffer();

         // and moving to the specified absolute position throws an exception
         Action action = () => buffer.AbsolutePosition = absolutePosition;
         action.Should().Throw<ArgumentOutOfRangeException>()
               .WithMessage("Absolute position is outside the valid range for the buffer (Parameter 'value')");
      }
   }
}