using System;
using System.Windows.Forms;

namespace GUI_NET_Framework
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortDesc_rdo = new System.Windows.Forms.RadioButton();
            this.sortAsc_rdo = new System.Windows.Forms.RadioButton();
            this.sortNo_rdo = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.delimiter_tbx = new System.Windows.Forms.TextBox();
            this.splitByDelimiter_chk = new System.Windows.Forms.CheckBox();
            this.uniqueItems_chk = new System.Windows.Forms.CheckBox();
            this.separator_tbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inNewLine_chk = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listSufix_tbx = new System.Windows.Forms.TextBox();
            this.itemPrefix_tbx = new System.Windows.Forms.TextBox();
            this.itemSufix_tbx = new System.Windows.Forms.TextBox();
            this.listPrefix_tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uniqueItemsCount_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.itemsCount_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.commaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semicolonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commaapostrophToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semicolonapostrophToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commaquotationMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semicolonquotationMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commasqareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semicolonsquareBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eachItemInNewLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyUniqueItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortDesc_rdo);
            this.groupBox1.Controls.Add(this.sortAsc_rdo);
            this.groupBox1.Controls.Add(this.sortNo_rdo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.delimiter_tbx);
            this.groupBox1.Controls.Add(this.splitByDelimiter_chk);
            this.groupBox1.Controls.Add(this.uniqueItems_chk);
            this.groupBox1.Controls.Add(this.separator_tbx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.inNewLine_chk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listSufix_tbx);
            this.groupBox1.Controls.Add(this.itemPrefix_tbx);
            this.groupBox1.Controls.Add(this.itemSufix_tbx);
            this.groupBox1.Controls.Add(this.listPrefix_tbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox1.Size = new System.Drawing.Size(212, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // sortDesc_rdo
            // 
            this.sortDesc_rdo.AutoSize = true;
            this.sortDesc_rdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.sortDesc_rdo.Location = new System.Drawing.Point(108, 247);
            this.sortDesc_rdo.Name = "sortDesc_rdo";
            this.sortDesc_rdo.Size = new System.Drawing.Size(57, 20);
            this.sortDesc_rdo.TabIndex = 57;
            this.sortDesc_rdo.Text = "Desc";
            this.sortDesc_rdo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.sortDesc_rdo.UseVisualStyleBackColor = true;
            // 
            // sortAsc_rdo
            // 
            this.sortAsc_rdo.AutoSize = true;
            this.sortAsc_rdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.sortAsc_rdo.Location = new System.Drawing.Point(54, 247);
            this.sortAsc_rdo.Name = "sortAsc_rdo";
            this.sortAsc_rdo.Size = new System.Drawing.Size(48, 20);
            this.sortAsc_rdo.TabIndex = 55;
            this.sortAsc_rdo.Text = "Asc";
            this.sortAsc_rdo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.sortAsc_rdo.UseVisualStyleBackColor = true;
            // 
            // sortNo_rdo
            // 
            this.sortNo_rdo.AutoSize = true;
            this.sortNo_rdo.Checked = true;
            this.sortNo_rdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.sortNo_rdo.Location = new System.Drawing.Point(5, 247);
            this.sortNo_rdo.Name = "sortNo_rdo";
            this.sortNo_rdo.Size = new System.Drawing.Size(43, 20);
            this.sortNo_rdo.TabIndex = 54;
            this.sortNo_rdo.TabStop = true;
            this.sortNo_rdo.Text = "No";
            this.sortNo_rdo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(2, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 53;
            this.label9.Text = "Sort:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // delimiter_tbx
            // 
            this.delimiter_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.delimiter_tbx.Location = new System.Drawing.Point(146, 181);
            this.delimiter_tbx.Name = "delimiter_tbx";
            this.delimiter_tbx.Size = new System.Drawing.Size(57, 25);
            this.delimiter_tbx.TabIndex = 12;
            // 
            // splitByDelimiter_chk
            // 
            this.splitByDelimiter_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.splitByDelimiter_chk.ForeColor = System.Drawing.Color.Black;
            this.splitByDelimiter_chk.Location = new System.Drawing.Point(5, 182);
            this.splitByDelimiter_chk.Name = "splitByDelimiter_chk";
            this.splitByDelimiter_chk.Size = new System.Drawing.Size(150, 24);
            this.splitByDelimiter_chk.TabIndex = 52;
            this.splitByDelimiter_chk.Text = "Split using delimiter:";
            this.splitByDelimiter_chk.UseVisualStyleBackColor = true;
            // 
            // uniqueItems_chk
            // 
            this.uniqueItems_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.uniqueItems_chk.ForeColor = System.Drawing.Color.Black;
            this.uniqueItems_chk.Location = new System.Drawing.Point(5, 134);
            this.uniqueItems_chk.Name = "uniqueItems_chk";
            this.uniqueItems_chk.Size = new System.Drawing.Size(185, 24);
            this.uniqueItems_chk.TabIndex = 51;
            this.uniqueItems_chk.Text = "Only unique items";
            this.uniqueItems_chk.UseVisualStyleBackColor = true;
            // 
            // separator_tbx
            // 
            this.separator_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.separator_tbx.Location = new System.Drawing.Point(76, 24);
            this.separator_tbx.Name = "separator_tbx";
            this.separator_tbx.Size = new System.Drawing.Size(127, 25);
            this.separator_tbx.TabIndex = 0;
            this.separator_tbx.Text = ",";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(5, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Separator:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inNewLine_chk
            // 
            this.inNewLine_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.inNewLine_chk.ForeColor = System.Drawing.Color.Black;
            this.inNewLine_chk.Location = new System.Drawing.Point(5, 158);
            this.inNewLine_chk.Name = "inNewLine_chk";
            this.inNewLine_chk.Size = new System.Drawing.Size(185, 24);
            this.inNewLine_chk.TabIndex = 50;
            this.inNewLine_chk.Text = "Each item in new line";
            this.inNewLine_chk.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(129, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Item";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(168, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "List";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(129, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sufix";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prefix";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // listSufix_tbx
            // 
            this.listSufix_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listSufix_tbx.Location = new System.Drawing.Point(168, 73);
            this.listSufix_tbx.Name = "listSufix_tbx";
            this.listSufix_tbx.Size = new System.Drawing.Size(35, 25);
            this.listSufix_tbx.TabIndex = 40;
            // 
            // itemPrefix_tbx
            // 
            this.itemPrefix_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.itemPrefix_tbx.Location = new System.Drawing.Point(45, 73);
            this.itemPrefix_tbx.Name = "itemPrefix_tbx";
            this.itemPrefix_tbx.Size = new System.Drawing.Size(35, 25);
            this.itemPrefix_tbx.TabIndex = 20;
            // 
            // itemSufix_tbx
            // 
            this.itemSufix_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.itemSufix_tbx.Location = new System.Drawing.Point(129, 73);
            this.itemSufix_tbx.Name = "itemSufix_tbx";
            this.itemSufix_tbx.Size = new System.Drawing.Size(35, 25);
            this.itemSufix_tbx.TabIndex = 30;
            // 
            // listPrefix_tbx
            // 
            this.listPrefix_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listPrefix_tbx.Location = new System.Drawing.Point(5, 73);
            this.listPrefix_tbx.Name = "listPrefix_tbx";
            this.listPrefix_tbx.Size = new System.Drawing.Size(35, 25);
            this.listPrefix_tbx.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(5, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // preview
            // 
            this.preview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.preview.Location = new System.Drawing.Point(9, 73);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(330, 286);
            this.preview.TabIndex = 2;
            this.preview.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uniqueItemsCount_lbl);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.itemsCount_lbl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.preview);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(223, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 366);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // uniqueItemsCount_lbl
            // 
            this.uniqueItemsCount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uniqueItemsCount_lbl.Location = new System.Drawing.Point(168, 44);
            this.uniqueItemsCount_lbl.Name = "uniqueItemsCount_lbl";
            this.uniqueItemsCount_lbl.Size = new System.Drawing.Size(78, 23);
            this.uniqueItemsCount_lbl.TabIndex = 11;
            this.uniqueItemsCount_lbl.Text = "<number>";
            this.uniqueItemsCount_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(6, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Number of unique items: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemsCount_lbl
            // 
            this.itemsCount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.itemsCount_lbl.Location = new System.Drawing.Point(168, 21);
            this.itemsCount_lbl.Name = "itemsCount_lbl";
            this.itemsCount_lbl.Size = new System.Drawing.Size(93, 23);
            this.itemsCount_lbl.TabIndex = 9;
            this.itemsCount_lbl.Text = "<number>";
            this.itemsCount_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Number of items: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.CopyToClipboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CopyToClipboard.Location = new System.Drawing.Point(5, 295);
            this.CopyToClipboard.Margin = new System.Windows.Forms.Padding(0);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(212, 60);
            this.CopyToClipboard.TabIndex = 8;
            this.CopyToClipboard.Text = "Copy to clipboard";
            this.CopyToClipboard.UseVisualStyleBackColor = true;
            this.CopyToClipboard.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Aplication is minimized";
            this.notifyIcon1.BalloonTipTitle = "Paste the List";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Paste the List";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commaToolStripMenuItem,
            this.semicolonToolStripMenuItem,
            this.commaapostrophToolStripMenuItem,
            this.semicolonapostrophToolStripMenuItem,
            this.commaquotationMarksToolStripMenuItem,
            this.semicolonquotationMarksToolStripMenuItem,
            this.commasqareToolStripMenuItem,
            this.semicolonsquareBracketToolStripMenuItem,
            this.toolStripSeparator1,
            this.eachItemInNewLineToolStripMenuItem,
            this.onlyUniqueItemsToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(257, 302);
            // 
            // commaToolStripMenuItem
            // 
            this.commaToolStripMenuItem.Name = "commaToolStripMenuItem";
            this.commaToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.commaToolStripMenuItem.Text = "comma,..";
            this.commaToolStripMenuItem.Click += new System.EventHandler(this.commaToolStripMenuItem_Click);
            // 
            // semicolonToolStripMenuItem
            // 
            this.semicolonToolStripMenuItem.Name = "semicolonToolStripMenuItem";
            this.semicolonToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.semicolonToolStripMenuItem.Text = "semicolon; ...";
            this.semicolonToolStripMenuItem.Click += new System.EventHandler(this.semicolonToolStripMenuItem_Click);
            // 
            // commaapostrophToolStripMenuItem
            // 
            this.commaapostrophToolStripMenuItem.Name = "commaapostrophToolStripMenuItem";
            this.commaapostrophToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.commaapostrophToolStripMenuItem.Text = "\'comma\',\'apostroph\',\'...";
            this.commaapostrophToolStripMenuItem.Click += new System.EventHandler(this.commaApostrophToolStripMenuItem_Click);
            // 
            // semicolonapostrophToolStripMenuItem
            // 
            this.semicolonapostrophToolStripMenuItem.Name = "semicolonapostrophToolStripMenuItem";
            this.semicolonapostrophToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.semicolonapostrophToolStripMenuItem.Text = "\'semicolon\';\'apostroph\';\'...";
            this.semicolonapostrophToolStripMenuItem.Click += new System.EventHandler(this.semicolonApostrophToolStripMenuItem_Click);
            // 
            // commaquotationMarksToolStripMenuItem
            // 
            this.commaquotationMarksToolStripMenuItem.Name = "commaquotationMarksToolStripMenuItem";
            this.commaquotationMarksToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.commaquotationMarksToolStripMenuItem.Text = "\"comma\",\"quotation marks\",\"...";
            this.commaquotationMarksToolStripMenuItem.Click += new System.EventHandler(this.commaQuotationMarksToolStripMenuItem_Click);
            // 
            // semicolonquotationMarksToolStripMenuItem
            // 
            this.semicolonquotationMarksToolStripMenuItem.Name = "semicolonquotationMarksToolStripMenuItem";
            this.semicolonquotationMarksToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.semicolonquotationMarksToolStripMenuItem.Text = "\"semicolon\";\"quotation marks\";\"...";
            this.semicolonquotationMarksToolStripMenuItem.Click += new System.EventHandler(this.semicolonQuotationMarksToolStripMenuItem_Click);
            // 
            // commasqareToolStripMenuItem
            // 
            this.commasqareToolStripMenuItem.Name = "commasqareToolStripMenuItem";
            this.commasqareToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.commasqareToolStripMenuItem.Text = "[comma],[square bracket]";
            this.commasqareToolStripMenuItem.Click += new System.EventHandler(this.commaSqareToolStripMenuItem_Click);
            // 
            // semicolonsquareBracketToolStripMenuItem
            // 
            this.semicolonsquareBracketToolStripMenuItem.Name = "semicolonsquareBracketToolStripMenuItem";
            this.semicolonsquareBracketToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.semicolonsquareBracketToolStripMenuItem.Text = "[semicolon];[square bracket]";
            this.semicolonsquareBracketToolStripMenuItem.Click += new System.EventHandler(this.semicolonSquareBracketToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // eachItemInNewLineToolStripMenuItem
            // 
            this.eachItemInNewLineToolStripMenuItem.Name = "eachItemInNewLineToolStripMenuItem";
            this.eachItemInNewLineToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.eachItemInNewLineToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.eachItemInNewLineToolStripMenuItem.Text = "Each item in new line";
            this.eachItemInNewLineToolStripMenuItem.Click += new System.EventHandler(this.eachItemInNewLineToolStripMenuItem_Click);
            // 
            // onlyUniqueItemsToolStripMenuItem
            // 
            this.onlyUniqueItemsToolStripMenuItem.Name = "onlyUniqueItemsToolStripMenuItem";
            this.onlyUniqueItemsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.onlyUniqueItemsToolStripMenuItem.Text = "Only unique items";
            this.onlyUniqueItemsToolStripMenuItem.Click += new System.EventHandler(this.onlyUniqueItemsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(253, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.CopyToClipboard);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(579, 374);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(579, 398);
            this.toolStripContainer1.TabIndex = 53;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(579, 398);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Past the list";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }


        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox listSufix_tbx;
        private TextBox itemPrefix_tbx;
        private TextBox itemSufix_tbx;
        private TextBox listPrefix_tbx;
        private CheckBox inNewLine_chk;
        private RichTextBox preview;
        private GroupBox groupBox2;
        private TextBox separator_tbx;
        private Label label7;
        private Button CopyToClipboard;
        private Label label8;
        private Label itemsCount_lbl;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eachItemInNewLineToolStripMenuItem;
        private Label uniqueItemsCount_lbl;
        private Label label10;
        private CheckBox uniqueItems_chk;
        private CheckBox splitByDelimiter_chk;
        #endregion

        private TextBox delimiter_tbx;
        private ToolStripMenuItem onlyUniqueItemsToolStripMenuItem;
        private ToolStripMenuItem commaapostrophToolStripMenuItem;
        private ToolStripMenuItem semicolonapostrophToolStripMenuItem;
        private ToolStripMenuItem commaquotationMarksToolStripMenuItem;
        private ToolStripMenuItem semicolonquotationMarksToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem commaToolStripMenuItem;
        private ToolStripMenuItem semicolonToolStripMenuItem;
        private ToolStripMenuItem commasqareToolStripMenuItem;
        private ToolStripMenuItem semicolonsquareBracketToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private RadioButton sortDesc_rdo;
        private RadioButton sortAsc_rdo;
        private RadioButton sortNo_rdo;
        private Label label9;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}