namespace ALParser.Demo
{
   partial class Form1
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
         splitParser = new SplitContainer();
         listView1 = new ListView();
         colErrorMsg = new ColumnHeader();
         colErrorStartLine = new ColumnHeader();
         colErrorStartCol = new ColumnHeader();
         colErrorEndLine = new ColumnHeader();
         colErrorEndCol = new ColumnHeader();
         ((System.ComponentModel.ISupportInitialize)splitParser).BeginInit();
         splitParser.Panel2.SuspendLayout();
         splitParser.SuspendLayout();
         SuspendLayout();
         // 
         // splitParser
         // 
         splitParser.Dock = DockStyle.Fill;
         splitParser.Location = new Point(0, 0);
         splitParser.Name = "splitParser";
         splitParser.Orientation = Orientation.Horizontal;
         // 
         // splitParser.Panel2
         // 
         splitParser.Panel2.Controls.Add(listView1);
         splitParser.Size = new Size(939, 750);
         splitParser.SplitterDistance = 511;
         splitParser.TabIndex = 0;
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
         Text = "Form1";
         splitParser.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)splitParser).EndInit();
         splitParser.ResumeLayout(false);
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
   }
}