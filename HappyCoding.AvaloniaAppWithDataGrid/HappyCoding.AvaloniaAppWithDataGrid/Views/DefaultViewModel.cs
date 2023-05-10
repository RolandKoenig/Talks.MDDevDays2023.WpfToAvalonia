using System.Collections.ObjectModel;
using System.Linq;
using HappyCoding.AvaloniaAppWithDataGrid.Data;
using HappyCoding.AvaloniaAppWithDataGrid.Util;

namespace HappyCoding.AvaloniaAppWithDataGrid.Views;

public class DefaultViewModel : ViewModelBase
{
    private TestDataRow? _selectedItem;

    private ObservableCollection<TestDataRow> Items { get; }

    public TestDataRow? SelectedItem
    {
        get => _selectedItem;
        set => SetField(ref _selectedItem, value);
    }

    public DefaultViewModel()
    {
        var testData = TestDataLoader.LoadTestData(100, 500);

        this.Items = new ObservableCollection<TestDataRow>(testData);
        this.SelectedItem = testData.FirstOrDefault();
    }
}