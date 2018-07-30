using System.Windows;
namespace WpfMath.Controls {
	/// <summary>
	/// SimpleTextBoxDialog.xaml
	/// </summary>
	public partial class SimpleTextBoxDialog : Window {
		public SimpleTextBoxDialog() {
			InitializeComponent();
		}
		public SimpleTextBoxDialog(string textboxContent) {
			InitializeComponent();
			Textbox.Text = textboxContent;
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			this.Close();
		}
	}
}
