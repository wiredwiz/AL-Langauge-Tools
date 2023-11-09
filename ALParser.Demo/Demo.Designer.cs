namespace ALParser.Demo
{
   partial class Demo
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
         splitParser = new SplitContainer();
         tabConGrammar = new TabControl();
         tabPageEdit = new TabPage();
         fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
         tabPageGraph = new TabPage();
         gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
         listView1 = new ListView();
         colErrorMsg = new ColumnHeader();
         colErrorStartLine = new ColumnHeader();
         colErrorStartCol = new ColumnHeader();
         colErrorEndLine = new ColumnHeader();
         colErrorEndCol = new ColumnHeader();
         ((System.ComponentModel.ISupportInitialize)splitParser).BeginInit();
         splitParser.Panel1.SuspendLayout();
         splitParser.Panel2.SuspendLayout();
         splitParser.SuspendLayout();
         tabConGrammar.SuspendLayout();
         tabPageEdit.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).BeginInit();
         tabPageGraph.SuspendLayout();
         SuspendLayout();
         // 
         // splitParser
         // 
         splitParser.Dock = DockStyle.Fill;
         splitParser.Location = new Point(0, 0);
         splitParser.Name = "splitParser";
         splitParser.Orientation = Orientation.Horizontal;
         // 
         // splitParser.Panel1
         // 
         splitParser.Panel1.Controls.Add(tabConGrammar);
         // 
         // splitParser.Panel2
         // 
         splitParser.Panel2.Controls.Add(listView1);
         splitParser.Size = new Size(939, 750);
         splitParser.SplitterDistance = 511;
         splitParser.TabIndex = 0;
         // 
         // tabConGrammar
         // 
         tabConGrammar.Controls.Add(tabPageEdit);
         tabConGrammar.Controls.Add(tabPageGraph);
         tabConGrammar.Dock = DockStyle.Fill;
         tabConGrammar.Location = new Point(0, 0);
         tabConGrammar.Name = "tabConGrammar";
         tabConGrammar.SelectedIndex = 0;
         tabConGrammar.Size = new Size(939, 511);
         tabConGrammar.TabIndex = 1;
         // 
         // tabPageEdit
         // 
         tabPageEdit.Controls.Add(fastColoredTextBox1);
         tabPageEdit.Location = new Point(4, 29);
         tabPageEdit.Name = "tabPageEdit";
         tabPageEdit.Padding = new Padding(3);
         tabPageEdit.Size = new Size(931, 478);
         tabPageEdit.TabIndex = 0;
         tabPageEdit.Text = "Editor";
         tabPageEdit.UseVisualStyleBackColor = true;
         // 
         // fastColoredTextBox1
         // 
         fastColoredTextBox1.AccessibleDescription = "Textbox control";
         fastColoredTextBox1.AccessibleName = "Fast Colored Text Box";
         fastColoredTextBox1.AccessibleRole = AccessibleRole.Text;
         fastColoredTextBox1.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
         fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
         fastColoredTextBox1.AutoScrollMinSize = new Size(0, 18126);
         fastColoredTextBox1.BackBrush = null;
         fastColoredTextBox1.CharHeight = 18;
         fastColoredTextBox1.CharWidth = 10;
         fastColoredTextBox1.DefaultMarkerSize = 8;
         fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
         fastColoredTextBox1.Dock = DockStyle.Fill;
         fastColoredTextBox1.EnableBlinkingStyle = false;
         fastColoredTextBox1.FindForm = null;
         fastColoredTextBox1.FoldingHighlightColor = Color.LightGray;
         fastColoredTextBox1.FoldingHighlightEnabled = false;
         fastColoredTextBox1.GoToForm = null;
         fastColoredTextBox1.Hotkeys = resources.GetString("fastColoredTextBox1.Hotkeys");
         fastColoredTextBox1.IsReplaceMode = false;
         fastColoredTextBox1.LeftBracket = '{';
         fastColoredTextBox1.LeftBracket2 = '(';
         fastColoredTextBox1.LeftBracket3 = '[';
         fastColoredTextBox1.Location = new Point(3, 3);
         fastColoredTextBox1.Name = "fastColoredTextBox1";
         fastColoredTextBox1.Paddings = new Padding(0);
         fastColoredTextBox1.ReplaceForm = null;
         fastColoredTextBox1.RightBracket = '}';
         fastColoredTextBox1.RightBracket2 = ')';
         fastColoredTextBox1.RightBracket3 = ']';
         fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
         fastColoredTextBox1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors");
         fastColoredTextBox1.ShowFoldingLines = true;
         fastColoredTextBox1.Size = new Size(925, 472);
         fastColoredTextBox1.TabIndex = 0;
         fastColoredTextBox1.Text = resources.GetString("fastColoredTextBox1.Text");
         fastColoredTextBox1.ToolTipDelay = 100;
         fastColoredTextBox1.WordWrap = true;
         fastColoredTextBox1.Zoom = 100;
         fastColoredTextBox1.TextChanged += demoEdit_TextChanged;
         // 
         // tabPageGraph
         // 
         tabPageGraph.Controls.Add(gViewer1);
         tabPageGraph.Location = new Point(4, 29);
         tabPageGraph.Name = "tabPageGraph";
         tabPageGraph.Padding = new Padding(3);
         tabPageGraph.Size = new Size(931, 478);
         tabPageGraph.TabIndex = 1;
         tabPageGraph.Text = "Graph";
         tabPageGraph.UseVisualStyleBackColor = true;
         // 
         // gViewer1
         // 
         gViewer1.ArrowheadLength = 10D;
         gViewer1.AsyncLayout = false;
         gViewer1.AutoScroll = true;
         gViewer1.BackwardEnabled = false;
         gViewer1.BuildHitTree = true;
         gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
         gViewer1.Dock = DockStyle.Fill;
         gViewer1.EdgeInsertButtonVisible = false;
         gViewer1.FileName = "";
         gViewer1.ForwardEnabled = false;
         gViewer1.Graph = null;
         gViewer1.IncrementalDraggingModeAlways = false;
         gViewer1.InsertingEdge = false;
         gViewer1.LayoutAlgorithmSettingsButtonVisible = false;
         gViewer1.LayoutEditingEnabled = true;
         gViewer1.Location = new Point(3, 3);
         gViewer1.LooseOffsetForRouting = 0.25D;
         gViewer1.MouseHitDistance = 0.05D;
         gViewer1.Name = "gViewer1";
         gViewer1.NavigationVisible = false;
         gViewer1.NeedToCalculateLayout = true;
         gViewer1.OffsetForRelaxingInRouting = 0.6D;
         gViewer1.PaddingForEdgeRouting = 8D;
         gViewer1.PanButtonPressed = false;
         gViewer1.SaveAsImageEnabled = true;
         gViewer1.SaveAsMsaglEnabled = true;
         gViewer1.SaveButtonVisible = false;
         gViewer1.SaveGraphButtonVisible = false;
         gViewer1.SaveInVectorFormatEnabled = true;
         gViewer1.Size = new Size(925, 472);
         gViewer1.TabIndex = 0;
         gViewer1.TightOffsetForRouting = 0.125D;
         gViewer1.ToolBarIsVisible = true;
         gViewer1.Transform = (Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)resources.GetObject("gViewer1.Transform");
         gViewer1.UndoRedoButtonsVisible = false;
         gViewer1.WindowZoomButtonPressed = false;
         gViewer1.ZoomF = 1D;
         gViewer1.ZoomWindowThreshold = 0.05D;
         // 
         // listView1
         // 
         listView1.Columns.AddRange(new ColumnHeader[] { colErrorMsg, colErrorStartLine, colErrorStartCol, colErrorEndLine, colErrorEndCol });
         listView1.Dock = DockStyle.Fill;
         listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
         listView1.Location = new Point(0, 0);
         listView1.Name = "listView1";
         listView1.Size = new Size(939, 235);
         listView1.TabIndex = 0;
         listView1.UseCompatibleStateImageBehavior = false;
         listView1.View = View.Details;
         // 
         // colErrorMsg
         // 
         colErrorMsg.Text = "Error";
         colErrorMsg.Width = 500;
         // 
         // colErrorStartLine
         // 
         colErrorStartLine.Text = "Start Line";
         colErrorStartLine.Width = 90;
         // 
         // colErrorStartCol
         // 
         colErrorStartCol.Text = "Start Column";
         colErrorStartCol.Width = 90;
         // 
         // colErrorEndLine
         // 
         colErrorEndLine.Text = "End Line";
         colErrorEndLine.Width = 90;
         // 
         // colErrorEndCol
         // 
         colErrorEndCol.Text = "End Column";
         colErrorEndCol.Width = 90;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(939, 750);
         Controls.Add(splitParser);
         Name = "Form1";
         Text = "Parser Demo";
         splitParser.Panel1.ResumeLayout(false);
         splitParser.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)splitParser).EndInit();
         splitParser.ResumeLayout(false);
         tabConGrammar.ResumeLayout(false);
         tabPageEdit.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).EndInit();
         tabPageGraph.ResumeLayout(false);
         ResumeLayout(false);
      }

      #endregion

      private SplitContainer splitParser;
      private ListView listView1;
      private ColumnHeader colErrorMsg;
      private ColumnHeader colErrorStartLine;
      private ColumnHeader colErrorStartCol;
      private ColumnHeader colErrorEndLine;
      private ColumnHeader colErrorEndCol;
      private TabControl tabConGrammar;
      private TabPage tabPageEdit;
      private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
      private TabPage tabPageGraph;
      private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
   }
}