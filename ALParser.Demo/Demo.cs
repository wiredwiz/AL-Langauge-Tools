using System.ComponentModel;
using FastColoredTextBoxNS.Types;
using Org.Edgerunner.BC.AL.Language.Lexers;
using Org.Edgerunner.BC.AL.Language.Parsers;
using Org.Edgerunner.BC.AL.Language.Tokens;
using Org.Edgerunner.Buffers.Input;
using Org.Edgerunner.Language.Lexers;

namespace ALParser.Demo
{
   public partial class Demo : Form
   {
      public Demo()
      {
         InitializeComponent();
         _Lexer.AddErrorListener(_ErrorListener);
         _Parser.AddErrorListener(_ErrorListener);
      }

      private AlParser _Parser = new AlParser();
      private AlLexer _Lexer = new AlLexer();
      private TextBuffer _Buffer;
      private ITextEditorColorStyle _Styles = new AlDefaultColorStyle();
      private AlErrorListener _ErrorListener = new AlErrorListener();

      private void demoEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
      {
         // TODO: Add parser logic
         _Buffer = new TextBuffer(demoEditor.Text);
         _ErrorListener.Clear();
         var tokens = _Lexer.ReadTokensFromBuffer(_Buffer);
         var stream = new TokenStream<AlToken>(tokens);
         _Parser.ParseSource(stream);
         MessageList.DataSource = new BindingList<AlErrorFacade>(_ErrorListener.Errors.Select(x => new AlErrorFacade(x)).ToList());
         demoEditor.ClearAllStyles();
         var last = tokens.Last();
         foreach (var token in tokens)
         {
            var span = demoEditor.GetRange(token.GetStart(), token.GetEnd());
            if (token.IsAssignmentOperator)
               span.SetStyle(_Styles.AssignmentOperators);
            else if (token.IsComparisonOperator)
               span.SetStyle(_Styles.ComparisonOperators);
            else if (token.IsBinaryOperator)
               span.SetStyle(_Styles.BinaryOperators);
            else if (token.IsOperator)
               span.SetStyle(_Styles.Operators);
            else if (token is ErrorToken)
               span.SetStyle(_Styles.Error);
            else if (token is SymbolToken)
               span.SetStyle(_Styles.Symbols);
            else if (token is IdentifierToken { ReservedWord: true })
               span.SetStyle(_Styles.Keywords);
            else if (token is IdentifierToken identToken && identToken.Value.StartsWith('"'))
               span.SetStyle(_Styles.QuotedIdentifiers);
            //else if (token is IdentifierToken)
            //   span.SetStyle(_Styles.Identifiers);
            else if (token is LiteralToken { LiteralType: LiteralType.String })
               span.SetStyle(_Styles.StringLiterals);
            else if (token is LiteralToken { LiteralType: LiteralType.Decimal or LiteralType.Integer })
               span.SetStyle(_Styles.NumberLiterals);
            else if (token is LiteralToken)
               span.SetStyle(_Styles.OtherLiterals);
            else
               span.SetStyle(_Styles.Default);
         }
      }

      private void MessageList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         var selectedRow = MessageList.Rows[e.RowIndex];
         if (selectedRow.DataBoundItem is AlErrorFacade error)
         {
            demoEditor.Focus();
            demoEditor.Selection = new TextSelectionRange(demoEditor, error.Column - 1, error.Line - 1, error.Column - 1, error.Line - 1);
            demoEditor.DoCaretVisible();
         }
      }
   }
}