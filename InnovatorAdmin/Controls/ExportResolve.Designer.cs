﻿namespace InnovatorAdmin.Controls
{
  partial class ExportResolve
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.resolveGrid = new Controls.DataGrid();
      this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.conStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mniEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.mniIncludeInPackage = new System.Windows.Forms.ToolStripMenuItem();
      this.mniRemoveReferencingItems = new System.Windows.Forms.ToolStripMenuItem();
      this.mniRemoveReferences = new System.Windows.Forms.ToolStripMenuItem();
      this.mniReset = new System.Windows.Forms.ToolStripMenuItem();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btnActions = new InnovatorAdmin.Controls.FlatButton();
      this.label1 = new System.Windows.Forms.Label();
      this.txtFilter = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.resolveGrid)).BeginInit();
      this.conStrip.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      //
      // resolveGrid
      //
      this.resolveGrid.AllowUserToAddRows = false;
      this.resolveGrid.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.resolveGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.resolveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.resolveGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colOrigin,
            this.colType});
      this.tableLayoutPanel1.SetColumnSpan(this.resolveGrid, 3);
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.resolveGrid.DefaultCellStyle = dataGridViewCellStyle2;
      this.resolveGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.resolveGrid.Location = new System.Drawing.Point(3, 38);
      this.resolveGrid.Name = "resolveGrid";
      this.resolveGrid.ReadOnly = true;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.resolveGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.resolveGrid.RowHeadersVisible = false;
      this.resolveGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.resolveGrid.Size = new System.Drawing.Size(517, 265);
      this.resolveGrid.TabIndex = 0;
      this.resolveGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.resolveGrid_CellFormatting);
      this.resolveGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.resolveGrid_CellMouseClick);
      //
      // colName
      //
      this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colName.DataPropertyName = "Name";
      this.colName.HeaderText = "Name";
      this.colName.MinimumWidth = 300;
      this.colName.Name = "colName";
      this.colName.ReadOnly = true;
      //
      // colOrigin
      //
      this.colOrigin.DataPropertyName = "Origin";
      this.colOrigin.HeaderText = "Origin";
      this.colOrigin.Name = "colOrigin";
      this.colOrigin.ReadOnly = true;
      //
      // colType
      //
      this.colType.DataPropertyName = "Type";
      this.colType.HeaderText = "Type";
      this.colType.Name = "colType";
      this.colType.ReadOnly = true;
      //
      // conStrip
      //
      this.conStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniEdit,
            this.mniIncludeInPackage,
            this.mniRemoveReferencingItems,
            this.mniRemoveReferences,
            this.mniReset});
      this.conStrip.Name = "conStrip";
      this.conStrip.Size = new System.Drawing.Size(216, 114);
      //
      // mniEdit
      //
      this.mniEdit.Name = "mniEdit";
      this.mniEdit.Size = new System.Drawing.Size(215, 22);
      this.mniEdit.Text = "Edit";
      this.mniEdit.Click += new System.EventHandler(this.mniEdit_Click);
      //
      // mniIncludeInPackage
      //
      this.mniIncludeInPackage.Name = "mniIncludeInPackage";
      this.mniIncludeInPackage.Size = new System.Drawing.Size(215, 22);
      this.mniIncludeInPackage.Text = "Include in Package";
      this.mniIncludeInPackage.Click += new System.EventHandler(this.mniIncludeInPackage_Click);
      //
      // mniRemoveReferencingItems
      //
      this.mniRemoveReferencingItems.Name = "mniRemoveReferencingItems";
      this.mniRemoveReferencingItems.Size = new System.Drawing.Size(215, 22);
      this.mniRemoveReferencingItems.Text = "Remove Referencing Items";
      this.mniRemoveReferencingItems.Click += new System.EventHandler(this.mniRemoveReferencingItems_Click);
      //
      // mniRemoveReferences
      //
      this.mniRemoveReferences.Name = "mniRemoveReferences";
      this.mniRemoveReferences.Size = new System.Drawing.Size(215, 22);
      this.mniRemoveReferences.Text = "Remove References";
      this.mniRemoveReferences.Click += new System.EventHandler(this.mniRemoveReferences_Click);
      //
      // mniReset
      //
      this.mniReset.Name = "mniReset";
      this.mniReset.Size = new System.Drawing.Size(215, 22);
      this.mniReset.Text = "Reset Action";
      this.mniReset.Click += new System.EventHandler(this.mniReset_Click);
      //
      // tableLayoutPanel1
      //
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.resolveGrid, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnActions, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtFilter, 2, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 306);
      this.tableLayoutPanel1.TabIndex = 1;
      //
      // btnActions
      //
      this.btnActions.AutoSize = true;
      this.btnActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnActions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnActions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnActions.ForeColor = System.Drawing.Color.Black;
      this.btnActions.Location = new System.Drawing.Point(3, 3);
      this.btnActions.Name = "btnActions";
      this.btnActions.Padding = new System.Windows.Forms.Padding(2);
      this.btnActions.Size = new System.Drawing.Size(75, 29);
      this.btnActions.TabIndex = 1;
      this.btnActions.Text = "Actions ▼";
      this.btnActions.Theme = InnovatorAdmin.Controls.FlatButtonTheme.LightGray;
      this.btnActions.UseVisualStyleBackColor = false;
      this.btnActions.Click += new System.EventHandler(this.btnActions_Click);
      //
      // label1
      //
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(382, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Filter:";
      //
      // txtFilter
      //
      this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.txtFilter.Location = new System.Drawing.Point(420, 7);
      this.txtFilter.Name = "txtFilter";
      this.txtFilter.Size = new System.Drawing.Size(100, 20);
      this.txtFilter.TabIndex = 3;
      this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
      //
      // ExportResolve
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ExportResolve";
      this.Size = new System.Drawing.Size(523, 306);
      ((System.ComponentModel.ISupportInitialize)(this.resolveGrid)).EndInit();
      this.conStrip.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.DataGrid resolveGrid;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ContextMenuStrip conStrip;
    private System.Windows.Forms.ToolStripMenuItem mniIncludeInPackage;
    private System.Windows.Forms.ToolStripMenuItem mniReset;
    private System.Windows.Forms.ToolStripMenuItem mniEdit;
    private System.Windows.Forms.ToolStripMenuItem mniRemoveReferencingItems;
    private System.Windows.Forms.ToolStripMenuItem mniRemoveReferences;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrigin;
    private System.Windows.Forms.DataGridViewTextBoxColumn colType;
    private FlatButton btnActions;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFilter;
  }
}
