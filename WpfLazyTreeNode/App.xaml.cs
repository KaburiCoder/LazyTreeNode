using System.Windows;
using WpfLazyTreeNode.ViewModels;
using WpfLazyTreeNode.Views;

namespace WpfLazyTreeNode
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      MainView view = new MainView
      {
        DataContext = new MainViewModel()
      };
      view.Show();
    }
  }
}
