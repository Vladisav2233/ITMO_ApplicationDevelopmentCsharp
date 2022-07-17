using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for CalcUI.
	/// </summary>
	public class CalcUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox VersionInfo;
		private System.Windows.Forms.Button KeyExit;
		private System.Windows.Forms.Button KeyDate;
		private System.Windows.Forms.TextBox OutputDisplay;
		private System.Windows.Forms.Button KeyClear;
		private System.Windows.Forms.Button KeyMinus;
		private System.Windows.Forms.Button KeyPlus;
		private System.Windows.Forms.Button KeyEqual;
		private System.Windows.Forms.Button KeyMultiply;
		private System.Windows.Forms.Button KeyDivide;
		private System.Windows.Forms.Button KeyPoint;
		private System.Windows.Forms.Button KeySign;
		private System.Windows.Forms.Button KeyZero;
		private System.Windows.Forms.Button KeyNine;
		private System.Windows.Forms.Button KeyEight;
		private System.Windows.Forms.Button KeySeven;
		private System.Windows.Forms.Button KeySix;
		private System.Windows.Forms.Button KeyFive;
		private System.Windows.Forms.Button KeyFour;
		private System.Windows.Forms.Button KeyThree;
		private System.Windows.Forms.Button KeyTwo;
		private System.Windows.Forms.Button KeyOne;
        private Button KeySqrt;
        private Button KeyReverse;
        private Button KeySquare;
        private Button KeyExponentiation;

        // Output Display Constants.
        private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";
        private ToolTip toolTipDivide;
        private ToolTip toolTipMultiply;
        private ToolTip toolTipSubtract;
        private ToolTip toolTipAdd;
        private ToolTip toolTipExponentiation;
        private ToolTip toolTipSqrt;
        private ToolTip toolTipReverse;
        private ToolTip toolTipSquare;
        private ToolStripMenuItem âèäÊàëüêóëÿòîðàToolStripMenuItem;
        private ToolStripMenuItem ñòàíäàðòíûéToolStripMenuItem;
        private ToolStripMenuItem ðàñøèðåííûéToolStripMenuItem;
        private MenuStrip Menu;
        private ToolStripMenuItem ñòðîêàÂåðñèèToolStripMenuItem;
        private ToolStripMenuItem ñêðûòüToolStripMenuItem;
        private ToolStripMenuItem ïîêàçàòüToolStripMenuItem;
        private IContainer components;

        public CalcUI()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();

			//
			// Get version information from the Calculator Module.
			//

			VersionInfo.Text = CalcEngine.GetVersion();
			OutputDisplay.Text = "0";

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.KeySqrt = new System.Windows.Forms.Button();
            this.KeyReverse = new System.Windows.Forms.Button();
            this.KeySquare = new System.Windows.Forms.Button();
            this.KeyExponentiation = new System.Windows.Forms.Button();
            this.toolTipDivide = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMultiply = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSubtract = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExponentiation = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSqrt = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipReverse = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSquare = new System.Windows.Forms.ToolTip(this.components);
            this.âèäÊàëüêóëÿòîðàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ñòàíäàðòíûéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ðàñøèðåííûéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ñòðîêàÂåðñèèToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ñêðûòüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ïîêàçàòüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(213, 151);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(56, 40);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(21, 199);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(40, 40);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(21, 39);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(385, 20);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(117, 151);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(40, 40);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(69, 151);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(40, 40);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(213, 247);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(56, 40);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(69, 199);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(40, 40);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(21, 247);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(40, 40);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(117, 199);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(40, 40);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(165, 247);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(40, 40);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.toolTipAdd.SetToolTip(this.KeyPlus, "Ñëîæåíèå");
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(213, 199);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(56, 40);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(117, 247);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(40, 40);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(21, 103);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(40, 40);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(69, 247);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(40, 40);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(117, 103);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(40, 40);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(21, 71);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(385, 26);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(165, 199);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(40, 40);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.toolTipSubtract.SetToolTip(this.KeyMinus, "Âû÷èòàíèå");
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(69, 103);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(40, 40);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(165, 151);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(40, 40);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.toolTipDivide.SetToolTip(this.KeyMultiply, "Óìíîæåíèå");
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(21, 151);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(40, 40);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(213, 103);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(56, 40);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(165, 103);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(40, 40);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.toolTipDivide.SetToolTip(this.KeyDivide, "Äåëåíèå");
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // KeySqrt
            // 
            this.KeySqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySqrt.ForeColor = System.Drawing.Color.Blue;
            this.KeySqrt.Location = new System.Drawing.Point(288, 151);
            this.KeySqrt.Name = "KeySqrt";
            this.KeySqrt.Size = new System.Drawing.Size(118, 40);
            this.KeySqrt.TabIndex = 24;
            this.KeySqrt.TabStop = false;
            this.KeySqrt.Text = "Sqrt";
            this.toolTipSqrt.SetToolTip(this.KeySqrt, "Êâàäðàòíûé êîðåíü");
            this.KeySqrt.Click += new System.EventHandler(this.KeySqrt_Click);
            // 
            // KeyReverse
            // 
            this.KeyReverse.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyReverse.ForeColor = System.Drawing.Color.Blue;
            this.KeyReverse.Location = new System.Drawing.Point(288, 199);
            this.KeyReverse.Name = "KeyReverse";
            this.KeyReverse.Size = new System.Drawing.Size(118, 40);
            this.KeyReverse.TabIndex = 25;
            this.KeyReverse.TabStop = false;
            this.KeyReverse.Text = "1/X";
            this.toolTipReverse.SetToolTip(this.KeyReverse, "Îáðàòíîå çíà÷åíèå");
            this.KeyReverse.Click += new System.EventHandler(this.KeyReverse_Click);
            // 
            // KeySquare
            // 
            this.KeySquare.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySquare.ForeColor = System.Drawing.Color.Blue;
            this.KeySquare.Location = new System.Drawing.Point(288, 247);
            this.KeySquare.Name = "KeySquare";
            this.KeySquare.Size = new System.Drawing.Size(118, 40);
            this.KeySquare.TabIndex = 26;
            this.KeySquare.TabStop = false;
            this.KeySquare.Text = "^2";
            this.toolTipSquare.SetToolTip(this.KeySquare, "Êâàäðàò ÷èñëà");
            this.KeySquare.Click += new System.EventHandler(this.KeySquare_Click);
            // 
            // KeyExponentiation
            // 
            this.KeyExponentiation.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExponentiation.ForeColor = System.Drawing.Color.Blue;
            this.KeyExponentiation.Location = new System.Drawing.Point(288, 105);
            this.KeyExponentiation.Name = "KeyExponentiation";
            this.KeyExponentiation.Size = new System.Drawing.Size(118, 40);
            this.KeyExponentiation.TabIndex = 27;
            this.KeyExponentiation.TabStop = false;
            this.KeyExponentiation.Text = "^X";
            this.toolTipExponentiation.SetToolTip(this.KeyExponentiation, "Âîçâåäåíèå â ñòåïåíü");
            this.KeyExponentiation.Click += new System.EventHandler(this.KeyExponentiation_Click_1);
            // 
            // âèäÊàëüêóëÿòîðàToolStripMenuItem
            // 
            this.âèäÊàëüêóëÿòîðàToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ñòàíäàðòíûéToolStripMenuItem,
            this.ðàñøèðåííûéToolStripMenuItem});
            this.âèäÊàëüêóëÿòîðàToolStripMenuItem.Name = "âèäÊàëüêóëÿòîðàToolStripMenuItem";
            this.âèäÊàëüêóëÿòîðàToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.âèäÊàëüêóëÿòîðàToolStripMenuItem.Text = "Âèä êàëüêóëÿòîðà";
            // 
            // ñòàíäàðòíûéToolStripMenuItem
            // 
            this.ñòàíäàðòíûéToolStripMenuItem.Name = "ñòàíäàðòíûéToolStripMenuItem";
            this.ñòàíäàðòíûéToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ñòàíäàðòíûéToolStripMenuItem.Text = "Ñòàíäàðòíûé";
            this.ñòàíäàðòíûéToolStripMenuItem.Click += new System.EventHandler(this.ñòàíäàðòíûéToolStripMenuItem_Click);
            // 
            // ðàñøèðåííûéToolStripMenuItem
            // 
            this.ðàñøèðåííûéToolStripMenuItem.Name = "ðàñøèðåííûéToolStripMenuItem";
            this.ðàñøèðåííûéToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ðàñøèðåííûéToolStripMenuItem.Text = "Ðàñøèðåííûé";
            this.ðàñøèðåííûéToolStripMenuItem.Click += new System.EventHandler(this.ðàñøèðåííûéToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.âèäÊàëüêóëÿòîðàToolStripMenuItem,
            this.ñòðîêàÂåðñèèToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(425, 24);
            this.Menu.TabIndex = 22;
            this.Menu.Text = "menuStrip1";
            // 
            // ñòðîêàÂåðñèèToolStripMenuItem
            // 
            this.ñòðîêàÂåðñèèToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ñêðûòüToolStripMenuItem,
            this.ïîêàçàòüToolStripMenuItem});
            this.ñòðîêàÂåðñèèToolStripMenuItem.Name = "ñòðîêàÂåðñèèToolStripMenuItem";
            this.ñòðîêàÂåðñèèToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.ñòðîêàÂåðñèèToolStripMenuItem.Text = "Ñòðîêà âåðñèè";
            // 
            // ñêðûòüToolStripMenuItem
            // 
            this.ñêðûòüToolStripMenuItem.Name = "ñêðûòüToolStripMenuItem";
            this.ñêðûòüToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ñêðûòüToolStripMenuItem.Text = "Ñêðûòü";
            this.ñêðûòüToolStripMenuItem.Click += new System.EventHandler(this.ñêðûòüToolStripMenuItem_Click);
            // 
            // ïîêàçàòüToolStripMenuItem
            // 
            this.ïîêàçàòüToolStripMenuItem.Name = "ïîêàçàòüToolStripMenuItem";
            this.ïîêàçàòüToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ïîêàçàòüToolStripMenuItem.Text = "Ïîêàçàòü";
            this.ïîêàçàòüToolStripMenuItem.Click += new System.EventHandler(this.ïîêàçàòüToolStripMenuItem_Click);
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(425, 312);
            this.Controls.Add(this.KeyExponentiation);
            this.Controls.Add(this.KeySquare);
            this.Controls.Add(this.KeyReverse);
            this.Controls.Add(this.KeySqrt);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.Menu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(150, 150);
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.TopMost = true;
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        // Ìàòåììàòè÷åñêèå äåéñòâèÿ
		protected void KeyPlus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eAdd);
		}

		protected void KeyMinus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eSubtract);
		}

		protected void KeyMultiply_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eMultiply);
		}

		protected void KeyDivide_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eDivide);
		}
      
        private void KeySqrt_Click(object sender, EventArgs e)
        {
            double firstnumber = 0;
            double numericAnswer = 0;
            firstnumber = System.Convert.ToDouble(OutputDisplay.Text);
            numericAnswer = Math.Sqrt(firstnumber);
            OutputDisplay.Text = System.Convert.ToString(numericAnswer);
            //CalcEngine.CalcOne();
            //CalcEngine.CalcOperation(CalcEngine.Operator.eSqrt);
        }
        private void KeyReverse_Click(object sender, EventArgs e)
        {
            double firstnumber = 0;
            double numericAnswer = 0;
            firstnumber = System.Convert.ToDouble(OutputDisplay.Text);
            numericAnswer = 1/firstnumber;
            OutputDisplay.Text = System.Convert.ToString(numericAnswer);
            //CalcEngine.CalcOne();
            //CalcEngine.CalcOperation(CalcEngine.Operator.eSqrt);
            //CalcEngine.CalcOperation(CalcEngine.Operator.eReverse);
        }
        private void KeyExponentiation_Click_1(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eExponentiation);
        }

        private void KeySquare_Click(object sender, EventArgs e)
        {
            double firstnumber = 0;
            double numericAnswer = 0;
            firstnumber = System.Convert.ToDouble(OutputDisplay.Text);
            numericAnswer = firstnumber * firstnumber;
            OutputDisplay.Text = System.Convert.ToString(numericAnswer);
            //CalcEngine.CalcOperation(CalcEngine.Operator.eSquare);

        }

        //
        // Other non-numeric key click methods.
        //

        protected void KeySign_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcSign();
		}

		protected void KeyPoint_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcDecimal();
		}

		protected void KeyDate_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}

		protected void KeyClear_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			OutputDisplay.Text = "0";
		}

		//
		// Perform the calculation.
		//

		protected void KeyEqual_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (nineOut);
		}

		protected void KeyEight_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (eightOut);
		}

		protected void KeySeven_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sevenOut);
		}

		protected void KeySix_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sixOut);
		}

		protected void KeyFive_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fiveOut);
		}

		protected void KeyFour_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fourOut);
		}

		protected void KeyThree_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (threeOut);
		}

		protected void KeyTwo_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (twoOut);
		}

		protected void KeyOne_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (oneOut);
		}

		protected void KeyZero_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (zeroOut);
		}

        //
        // End the program.
        //

        protected void KeyExit_Click (object sender, System.EventArgs e)
		{
			this.Close();
		}
        private void ðàñøèðåííûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeySqrt.Visible = true;
            KeyReverse.Visible = true;
            KeySquare.Visible = true;
            KeyExponentiation.Visible = true;
            OutputDisplay.Size = new System.Drawing.Size(385, 26);
            VersionInfo.Size = new System.Drawing.Size(385, 20);
            this.Size = new System.Drawing.Size(445, 355);
            
        }

        private void ñòàíäàðòíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeySqrt.Visible = false;
            KeyReverse.Visible = false;
            KeySquare.Visible = false;
            KeyExponentiation.Visible = false;
            OutputDisplay.Size = new System.Drawing.Size(248, 26);
            VersionInfo.Size = new System.Drawing.Size(248, 20);
            this.Size = new System.Drawing.Size(300, 355);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main() 
		{
			Application.Run(new CalcUI());
		}


        private void ñêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionInfo.Visible = false;
        }

        private void ïîêàçàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionInfo.Visible = true;
        }
    }
}
