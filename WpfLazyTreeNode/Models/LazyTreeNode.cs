using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfLazyTreeNode.Models
{
  public class LazyTreeNode
  {
    private ObservableCollection<LazyTreeNode>? _children;
    private bool _isExpanded;

    // 자식노드의 부모가 누구인지 할당
    private void _children_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
      if (e.Action == NotifyCollectionChangedAction.Add)
      {
        foreach (LazyTreeNode node in e.NewItems!)
        {
          node.Parent = this;
        }
      }
    }

    /// <summary>노드가 펼쳐졌을 때 이벤트</summary>
    public event Action<LazyTreeNode>? OnExpanded;

    public string Key { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public object? Tag { get; set; }
    public BitmapImage? OpenedImage { get; set; }
    public BitmapImage? ClosedImage { get; set; }
    public LazyTreeNode? Parent { get; set; }
    public ObservableCollection<LazyTreeNode> Children
    {
      get
      {
        if (_children == null)
        {
          _children = new ObservableCollection<LazyTreeNode>();
          _children.CollectionChanged += _children_CollectionChanged;
        }
        return _children;
      }
      set => _children = value;
    }

    public bool IsExpanded
    {
      get => _isExpanded; set
      {
        _isExpanded = value;
        if (_isExpanded)
        {
          Children.Clear();
          OnExpanded?.Invoke(this);
        }
      }
    }

    public void AddDummyNode()
    {
      Children.Add(new LazyTreeNode());
    }
  }
}
