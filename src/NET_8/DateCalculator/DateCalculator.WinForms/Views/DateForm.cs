namespace DateCalculator.WinForms.Views;

public partial class DateForm : Form
{
	public DateForm()
	{
		InitializeComponent();
		ConfigureDataBindings();
		dateViewModelBindingSource.DataSource = new DateViewModel();
	}
	
	private void ConfigureDataBindings()
	{
		// DateForm
		DataBindings.Add(new Binding(nameof(Text), dateViewModelBindingSource, nameof(DateViewModel.Title), true));
		// cboOptions
		cboOptions.DataBindings.Add(new Binding(nameof(ComboBox.DataSource), dateViewModelBindingSource, nameof(DateViewModel.Options), true));
		cboOptions.DataBindings.Add(new Binding(nameof(ComboBox.SelectedIndex), dateViewModelBindingSource, nameof(DateViewModel.SelectedOption), true, DataSourceUpdateMode.OnPropertyChanged));
		// dtpStartDate
		dtpStartDate.DataBindings.Add(new Binding(nameof(DateTimePicker.Value), dateViewModelBindingSource, nameof(DateViewModel.StartDate), true, DataSourceUpdateMode.OnPropertyChanged));
		// dtpEndDate
		dtpEndDate.DataBindings.Add(new Binding(nameof(DateTimePicker.Value), dateViewModelBindingSource, nameof(DateViewModel.EndDate), true, DataSourceUpdateMode.OnPropertyChanged));
		dtpEndDate.DataBindings.Add(new Binding(nameof(Visible), dateViewModelBindingSource, nameof(DateViewModel.DiffMode), true, DataSourceUpdateMode.OnPropertyChanged));
		// addSubPanel
		addSubPanel.DataBindings.Add(new Binding(nameof(Visible), dateViewModelBindingSource, nameof(DateViewModel.DiffModeInverse), true, DataSourceUpdateMode.OnPropertyChanged));
		// rdoAdd
		rdoAdd.DataBindings.Add(new Binding(nameof(RadioButton.Checked), dateViewModelBindingSource, nameof(DateViewModel.AddMode), true, DataSourceUpdateMode.OnPropertyChanged));
		// cboYears
		cboYears.DataBindings.Add(new Binding(nameof(ComboBox.DataSource), dateViewModelBindingSource, nameof(DateViewModel.YearRange), true));
		cboYears.DataBindings.Add(new Binding(nameof(ComboBox.SelectedIndex), dateViewModelBindingSource, nameof(DateViewModel.SelectedYear), true, DataSourceUpdateMode.OnPropertyChanged));
		// cboMonths
		cboMonths.DataBindings.Add(new Binding(nameof(ComboBox.DataSource), dateViewModelBindingSource, nameof(DateViewModel.MonthRange), true));
		cboMonths.DataBindings.Add(new Binding(nameof(ComboBox.SelectedIndex), dateViewModelBindingSource, nameof(DateViewModel.SelectedMonth), true, DataSourceUpdateMode.OnPropertyChanged));
		// cboDays
		cboDays.DataBindings.Add(new Binding(nameof(ComboBox.DataSource), dateViewModelBindingSource, nameof(DateViewModel.DayRange), true));
		cboDays.DataBindings.Add(new Binding(nameof(ComboBox.SelectedIndex), dateViewModelBindingSource, nameof(DateViewModel.SelectedDay), true, DataSourceUpdateMode.OnPropertyChanged));
		// lblCaption
		lblCaption.DataBindings.Add(new Binding(nameof(Label.Text), dateViewModelBindingSource, nameof(DateViewModel.ResultCaption), true));
		// lblDiffResult
		lblDiffResult.DataBindings.Add(new Binding(nameof(Label.Text), dateViewModelBindingSource, nameof(DateViewModel.DiffResult), true));
		// lblDiffInDays
		lblDiffInDays.DataBindings.Add(new Binding(nameof(Label.Text), dateViewModelBindingSource, nameof(DateViewModel.DiffInDays), true));
	}
}
