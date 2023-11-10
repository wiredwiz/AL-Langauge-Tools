﻿namespace ALParser.Demo
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
         demoEditor = new FastColoredTextBoxNS.FastColoredTextBox();
         tabPageGraph = new TabPage();
         gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
         MessageList = new DataGridView();
         Source = new DataGridViewTextBoxColumn();
         Message = new DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)splitParser).BeginInit();
         splitParser.Panel1.SuspendLayout();
         splitParser.Panel2.SuspendLayout();
         splitParser.SuspendLayout();
         tabConGrammar.SuspendLayout();
         tabPageEdit.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)demoEditor).BeginInit();
         tabPageGraph.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)MessageList).BeginInit();
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
         splitParser.Panel2.Controls.Add(MessageList);
         splitParser.Size = new Size(939, 750);
         splitParser.SplitterDistance = 600;
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
         tabConGrammar.Size = new Size(939, 600);
         tabConGrammar.TabIndex = 1;
         // 
         // tabPageEdit
         // 
         tabPageEdit.Controls.Add(demoEditor);
         tabPageEdit.Location = new Point(4, 29);
         tabPageEdit.Name = "tabPageEdit";
         tabPageEdit.Padding = new Padding(3);
         tabPageEdit.Size = new Size(931, 567);
         tabPageEdit.TabIndex = 0;
         tabPageEdit.Text = "Editor";
         tabPageEdit.UseVisualStyleBackColor = true;
         // 
         // demoEditor
         // 
         demoEditor.AccessibleDescription = "Textbox control";
         demoEditor.AccessibleName = "Fast Colored Text Box";
         demoEditor.AccessibleRole = AccessibleRole.Text;
         demoEditor.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
         demoEditor.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
         demoEditor.AutoScrollMinSize = new Size(0, 17154);
         demoEditor.BackBrush = null;
         demoEditor.BackColor = Color.Black;
         demoEditor.CaretColor = Color.LightGray;
         demoEditor.CharHeight = 18;
         demoEditor.CharWidth = 10;
         demoEditor.DefaultMarkerSize = 8;
         demoEditor.DisabledColor = Color.FromArgb(100, 180, 180, 180);
         demoEditor.Dock = DockStyle.Fill;
         demoEditor.EnableBlinkingStyle = false;
         demoEditor.FindForm = null;
         demoEditor.FoldingHighlightColor = Color.LightGray;
         demoEditor.FoldingHighlightEnabled = false;
         demoEditor.ForeColor = Color.White;
         demoEditor.GoToForm = null;
         demoEditor.Hotkeys = resources.GetString("demoEditor.Hotkeys");
         demoEditor.IsReplaceMode = false;
         demoEditor.LeftBracket = '{';
         demoEditor.LeftBracket2 = '(';
         demoEditor.LeftBracket3 = '[';
         demoEditor.Location = new Point(3, 3);
         demoEditor.Name = "demoEditor";
         demoEditor.Paddings = new Padding(0);
         demoEditor.ReplaceForm = null;
         demoEditor.RightBracket = '}';
         demoEditor.RightBracket2 = ')';
         demoEditor.RightBracket3 = ']';
         demoEditor.SelectionColor = Color.FromArgb(60, 0, 0, 255);
         demoEditor.ServiceColors = null;
         demoEditor.ShowFoldingLines = true;
         demoEditor.Size = new Size(925, 561);
         demoEditor.TabIndex = 0;
         demoEditor.Text = resources.GetString("demoEditor.Text");
         demoEditor.TextAreaBorderColor = Color.White;
         demoEditor.ToolTipDelay = 100;
         demoEditor.WordWrap = true;
         demoEditor.Zoom = 100;
         demoEditor.TextChanged += demoEditor_TextChanged;
         // 
         // tabPageGraph
         // 
         tabPageGraph.Controls.Add(gViewer1);
         tabPageGraph.Location = new Point(4, 29);
         tabPageGraph.Name = "tabPageGraph";
         tabPageGraph.Padding = new Padding(3);
         tabPageGraph.Size = new Size(931, 567);
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
         gViewer1.Size = new Size(925, 561);
         gViewer1.TabIndex = 0;
         gViewer1.TightOffsetForRouting = 0.125D;
         gViewer1.ToolBarIsVisible = true;
         gViewer1.Transform = (Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)resources.GetObject("gViewer1.Transform");
         gViewer1.UndoRedoButtonsVisible = false;
         gViewer1.WindowZoomButtonPressed = false;
         gViewer1.ZoomF = 1D;
         gViewer1.ZoomWindowThreshold = 0.05D;
         // 
         // MessageList
         // 
         MessageList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         MessageList.Columns.AddRange(new DataGridViewColumn[] { Source, Message });
         MessageList.Dock = DockStyle.Fill;
         MessageList.Location = new Point(0, 0);
         MessageList.MultiSelect = false;
         MessageList.Name = "MessageList";
         MessageList.RowHeadersWidth = 51;
         MessageList.RowTemplate.Height = 29;
         MessageList.Size = new Size(939, 146);
         MessageList.TabIndex = 0;
         MessageList.CellDoubleClick += MessageList_CellDoubleClick;
         // 
         // Source
         // 
         Source.DataPropertyName = "Source";
         Source.HeaderText = "Source";
         Source.MinimumWidth = 6;
         Source.Name = "Source";
         Source.ReadOnly = true;
         Source.Width = 125;
         // 
         // Message
         // 
         Message.DataPropertyName = "Message";
         Message.HeaderText = "Message";
         Message.MinimumWidth = 6;
         Message.Name = "Message";
         Message.ReadOnly = true;
         Message.Width = 500;
         // 
         // Demo
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(939, 750);
         Controls.Add(splitParser);
         Name = "Demo";
         Text = "Parser Demo";
         splitParser.Panel1.ResumeLayout(false);
         splitParser.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)splitParser).EndInit();
         splitParser.ResumeLayout(false);
         tabConGrammar.ResumeLayout(false);
         tabPageEdit.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)demoEditor).EndInit();
         tabPageGraph.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)MessageList).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private SplitContainer splitParser;
      private TabControl tabConGrammar;
      private TabPage tabPageEdit;
      private FastColoredTextBoxNS.FastColoredTextBox demoEditor;
      private TabPage tabPageGraph;
      private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
      private DataGridView dataGridView1;
      private DataGridView MessageList;
      private DataGridViewTextBoxColumn Source;
      private DataGridViewTextBoxColumn Message;
   }
}