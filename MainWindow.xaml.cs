using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace WPF_DataBinding_ObjectList
{
	public partial class MainWindow : Window
	{
		List<Student> Students = new List<Student>();
		public MainWindow()
		{
			InitializeComponent();
			// Create List.
			Students.Add(new Student("Modest", "William", "XXXXXY", "mw@freemail.hu", 4.55));
			Students.Add(new Student("Modest", "Alexandra", "MAXXXX", "ma@freemail.hu", 4.65));
			Students.Add(new Student("Strict", "Image", "STXXXY", "si@freemail.hu", 4.55));
			Students.Add(new Student("Smarty", "Edward", "SMEXXY", "se@freemail.hu", 3.25));
			// Data source name - the list object - this will be the default data source
			// for all children of the grid.
			grGrid.DataContext = Students;
		}

		private void btPrevious_Click(object sender, RoutedEventArgs e)
		{
			ICollectionView cv = CollectionViewSource.GetDefaultView(Students);
			// If there is a previous item to move to.
			if (cv.CurrentPosition > 0)
				cv.MoveCurrentToPrevious();
			else
				// If not (i.e., the current one is the first), jump to the last one.
				cv.MoveCurrentToLast();
		}


		private void btNext_Click(object sender, RoutedEventArgs e)
		{
			ICollectionView cv = CollectionViewSource.GetDefaultView(Students);
			// If there are still items in the list, move to the next one.
			if (cv.CurrentPosition < Students.Count - 1)
				cv.MoveCurrentToNext();
			else
				// If not (i.e., the current one is the last), jump to the first one.
				cv.MoveCurrentToFirst();
		}

		private void btLowestAverage_Click(object sender, RoutedEventArgs e)
		{
			// Sorts the list items in ascending order based on the average.
			Students.Sort((a, b) =>
					a.OverallAverage == b.OverallAverage ?
					0 :
					(a.OverallAverage > b.OverallAverage ? 1 : -1));
			ICollectionView cv = CollectionViewSource.GetDefaultView(Students);
			// Jump to the first item in the list.
			cv.MoveCurrentToFirst();
		}

		private void btHighestAverage_Click(object sender, RoutedEventArgs e)
		{
			// Sorts the list items in ascending order based on the average.
			Students.Sort((a, b) =>
					a.OverallAverage == b.OverallAverage ?
					0 :
					(a.OverallAverage > b.OverallAverage ? 1 : -1));
			ICollectionView cv = CollectionViewSource.GetDefaultView(Students);
			// Jump to the last item in the list.
			cv.MoveCurrentToLast();
		}

	}

}