﻿namespace DateCalculator.WinForms.Views
{
	partial class DateForm
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
			components = new System.ComponentModel.Container();
			dtpStartDate = new DateTimePicker();
			dateViewModelBindingSource = new BindingSource(components);
			dtpEndDate = new DateTimePicker();
			lblDiffResult = new Label();
			cboOptions = new ComboBox();
			lblDiffInDays = new Label();
			lblCaption = new Label();
			modePanel = new Panel();
			rdoSubtract = new RadioButton();
			rdoAdd = new RadioButton();
			addSubPanel = new TableLayoutPanel();
			cboWeeks = new ComboBox();
			lblWeeks = new Label();
			lblYears = new Label();
			lblMonths = new Label();
			lblDays = new Label();
			cboYears = new ComboBox();
			cboMonths = new ComboBox();
			cboDays = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dateViewModelBindingSource).BeginInit();
			modePanel.SuspendLayout();
			addSubPanel.SuspendLayout();
			SuspendLayout();
			// 
			// dtpStartDate
			// 
			dtpStartDate.Location = new Point(250, 68);
			dtpStartDate.Name = "dtpStartDate";
			dtpStartDate.Size = new Size(300, 31);
			dtpStartDate.TabIndex = 1;
			// 
			// dateViewModelBindingSource
			// 
			dateViewModelBindingSource.DataSource = typeof(DateViewModel);
			// 
			// dtpEndDate
			// 
			dtpEndDate.Location = new Point(250, 116);
			dtpEndDate.Name = "dtpEndDate";
			dtpEndDate.Size = new Size(300, 31);
			dtpEndDate.TabIndex = 2;
			// 
			// lblDiffResult
			// 
			lblDiffResult.AutoSize = true;
			lblDiffResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblDiffResult.Location = new Point(250, 360);
			lblDiffResult.Name = "lblDiffResult";
			lblDiffResult.Size = new Size(111, 25);
			lblDiffResult.TabIndex = 5;
			lblDiffResult.Text = "[DiffResult]";
			// 
			// cboOptions
			// 
			cboOptions.DropDownStyle = ComboBoxStyle.DropDownList;
			cboOptions.FormattingEnabled = true;
			cboOptions.Location = new Point(250, 18);
			cboOptions.Name = "cboOptions";
			cboOptions.Size = new Size(300, 33);
			cboOptions.TabIndex = 0;
			// 
			// lblDiffInDays
			// 
			lblDiffInDays.AutoSize = true;
			lblDiffInDays.Font = new Font("Segoe UI", 9F);
			lblDiffInDays.Location = new Point(250, 403);
			lblDiffInDays.Name = "lblDiffInDays";
			lblDiffInDays.Size = new Size(105, 25);
			lblDiffInDays.TabIndex = 6;
			lblDiffInDays.Text = "[DiffInDays]";
			// 
			// lblCaption
			// 
			lblCaption.AutoSize = true;
			lblCaption.Location = new Point(250, 317);
			lblCaption.Name = "lblCaption";
			lblCaption.Size = new Size(84, 25);
			lblCaption.TabIndex = 4;
			lblCaption.Text = "[Caption]";
			// 
			// modePanel
			// 
			addSubPanel.SetColumnSpan(modePanel, 4);
			modePanel.Controls.Add(rdoSubtract);
			modePanel.Controls.Add(rdoAdd);
			modePanel.Dock = DockStyle.Fill;
			modePanel.Location = new Point(3, 3);
			modePanel.Name = "modePanel";
			modePanel.Size = new Size(457, 36);
			modePanel.TabIndex = 0;
			// 
			// rdoSubtract
			// 
			rdoSubtract.AutoSize = true;
			rdoSubtract.Location = new Point(249, 2);
			rdoSubtract.Name = "rdoSubtract";
			rdoSubtract.Size = new Size(103, 29);
			rdoSubtract.TabIndex = 1;
			rdoSubtract.TabStop = true;
			rdoSubtract.Text = "Subtract";
			rdoSubtract.UseVisualStyleBackColor = true;
			// 
			// rdoAdd
			// 
			rdoAdd.AutoSize = true;
			rdoAdd.Location = new Point(105, 3);
			rdoAdd.Name = "rdoAdd";
			rdoAdd.Size = new Size(71, 29);
			rdoAdd.TabIndex = 0;
			rdoAdd.TabStop = true;
			rdoAdd.Text = "Add";
			rdoAdd.UseVisualStyleBackColor = true;
			// 
			// addSubPanel
			// 
			addSubPanel.ColumnCount = 4;
			addSubPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			addSubPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			addSubPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			addSubPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			addSubPanel.Controls.Add(cboWeeks, 2, 2);
			addSubPanel.Controls.Add(lblWeeks, 2, 1);
			addSubPanel.Controls.Add(lblYears, 0, 1);
			addSubPanel.Controls.Add(modePanel, 0, 0);
			addSubPanel.Controls.Add(lblMonths, 1, 1);
			addSubPanel.Controls.Add(lblDays, 3, 1);
			addSubPanel.Controls.Add(cboYears, 0, 2);
			addSubPanel.Controls.Add(cboMonths, 1, 2);
			addSubPanel.Controls.Add(cboDays, 3, 2);
			addSubPanel.Location = new Point(169, 168);
			addSubPanel.Name = "addSubPanel";
			addSubPanel.RowCount = 3;
			addSubPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
			addSubPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
			addSubPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
			addSubPanel.Size = new Size(463, 126);
			addSubPanel.TabIndex = 3;
			// 
			// cboWeeks
			// 
			cboWeeks.DropDownStyle = ComboBoxStyle.DropDownList;
			cboWeeks.FormattingEnabled = true;
			cboWeeks.Location = new Point(233, 86);
			cboWeeks.Name = "cboWeeks";
			cboWeeks.Size = new Size(109, 33);
			cboWeeks.TabIndex = 3;
			// 
			// lblWeeks
			// 
			lblWeeks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			lblWeeks.AutoSize = true;
			lblWeeks.Location = new Point(233, 50);
			lblWeeks.Name = "lblWeeks";
			lblWeeks.Size = new Size(109, 25);
			lblWeeks.TabIndex = 102;
			lblWeeks.Text = "Weeks";
			// 
			// lblYears
			// 
			lblYears.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			lblYears.AutoSize = true;
			lblYears.Location = new Point(3, 50);
			lblYears.Name = "lblYears";
			lblYears.Size = new Size(109, 25);
			lblYears.TabIndex = 100;
			lblYears.Text = "Years";
			// 
			// lblMonths
			// 
			lblMonths.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			lblMonths.AutoSize = true;
			lblMonths.Location = new Point(118, 50);
			lblMonths.Name = "lblMonths";
			lblMonths.Size = new Size(109, 25);
			lblMonths.TabIndex = 101;
			lblMonths.Text = "Months";
			// 
			// lblDays
			// 
			lblDays.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			lblDays.AutoSize = true;
			lblDays.Location = new Point(348, 50);
			lblDays.Name = "lblDays";
			lblDays.Size = new Size(112, 25);
			lblDays.TabIndex = 103;
			lblDays.Text = "Days";
			// 
			// cboYears
			// 
			cboYears.DropDownStyle = ComboBoxStyle.DropDownList;
			cboYears.FormattingEnabled = true;
			cboYears.Location = new Point(3, 86);
			cboYears.Name = "cboYears";
			cboYears.Size = new Size(109, 33);
			cboYears.TabIndex = 1;
			// 
			// cboMonths
			// 
			cboMonths.DropDownStyle = ComboBoxStyle.DropDownList;
			cboMonths.FormattingEnabled = true;
			cboMonths.Location = new Point(118, 86);
			cboMonths.Name = "cboMonths";
			cboMonths.Size = new Size(109, 33);
			cboMonths.TabIndex = 2;
			// 
			// cboDays
			// 
			cboDays.DropDownStyle = ComboBoxStyle.DropDownList;
			cboDays.FormattingEnabled = true;
			cboDays.Location = new Point(348, 86);
			cboDays.Name = "cboDays";
			cboDays.Size = new Size(112, 33);
			cboDays.TabIndex = 4;
			// 
			// DateForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(addSubPanel);
			Controls.Add(lblCaption);
			Controls.Add(lblDiffInDays);
			Controls.Add(cboOptions);
			Controls.Add(lblDiffResult);
			Controls.Add(dtpStartDate);
			Controls.Add(dtpEndDate);
			Name = "DateForm";
			Text = "DateForm";
			((System.ComponentModel.ISupportInitialize)dateViewModelBindingSource).EndInit();
			modePanel.ResumeLayout(false);
			modePanel.PerformLayout();
			addSubPanel.ResumeLayout(false);
			addSubPanel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dtpStartDate;
		private DateTimePicker dtpEndDate;
		private BindingSource dateViewModelBindingSource;
		private Label lblDiffResult;
		private ComboBox cboOptions;
		private Label lblDiffInDays;
		private Label lblCaption;
		private Panel modePanel;
		private RadioButton rdoSubtract;
		private RadioButton rdoAdd;
		private TableLayoutPanel addSubPanel;
		private Label lblYears;
		private Label lblMonths;
		private Label lblDays;
		private ComboBox cboYears;
		private ComboBox cboMonths;
		private ComboBox cboDays;
		private ComboBox cboWeeks;
		private Label lblWeeks;
	}
}
