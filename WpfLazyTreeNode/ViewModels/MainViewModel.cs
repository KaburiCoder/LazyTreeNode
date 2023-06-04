using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLazyTreeNode.Models;

namespace WpfLazyTreeNode.ViewModels
{
  public class MainViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler? PropertyChanged;

    public LazyTreeNode CreateNode(string key, string text)
    {
      var node = new LazyTreeNode { Key = key, Text = text };
      node.OnExpanded += Node_OnExpanded;

      return node;
    }

    private void Node_OnExpanded(LazyTreeNode node)
    {
      switch (node.Key)
      {
        case "1":
          node.Children.Add(CreateNode("3", "홍길동의 자식"));
          break;
        case "2":
          node.Children.Add(CreateNode("4", "김이박의 자식"));
          break;
      }    
    }

    public MainViewModel()
    {
      PathNodes = new();

      PathNodes.Add(CreateNode("1", "홍길동"));
      PathNodes.Add(CreateNode("2", "김이박"));
    }

    public ObservableCollection<LazyTreeNode> PathNodes { get; set; }
  }
}
