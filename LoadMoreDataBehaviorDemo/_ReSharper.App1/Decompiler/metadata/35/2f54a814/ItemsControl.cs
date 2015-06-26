// Type: Windows.UI.Xaml.Controls.ItemsControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral
// MVID: A327EA32-BBFD-46B9-A970-A7F324BB7169
// Assembly location: C:\Program Files (x86)\Windows Kits\8.1\References\CommonConfiguration\Neutral\Windows.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>
  /// Represents a control that can be used to present a collection of items.
  /// </summary>
  [WebHostHidden]
  [Composable(typeof (IItemsControlFactory), CompositionType.Public, 100794368U)]
  [ContentProperty(Name = "Items")]
  [Version(100794368U)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IItemsControlStatics), 100794368U)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ItemsControl : Control, IItemsControl, IItemsControl2, IItemContainerMapping, IItemsControlOverrides
  {
    /// <summary>
    /// Initializes a new instance of the ItemsControl class.
    /// </summary>
    [MethodImpl]
    public ItemsControl();
    /// <summary>
    /// Returns the item that corresponds to the specified, generated container.
    /// </summary>
    /// 
    /// <returns>
    /// The contained item, or the container if it does not contain an item.
    /// </returns>
    /// <param name="container">The DependencyObject that corresponds to the item to be returned.</param>
    [MethodImpl]
    public object IItemContainerMapping.ItemFromContainer([In] DependencyObject container);
    /// <summary>
    /// Returns the container corresponding to the specified item.
    /// </summary>
    /// 
    /// <returns>
    /// A container that corresponds to the specified item, if the item has a container and exists in the collection; otherwise, null.
    /// </returns>
    /// <param name="item">The item to retrieve the container for.</param>
    [MethodImpl]
    public DependencyObject IItemContainerMapping.ContainerFromItem([In] object item);
    /// <summary>
    /// Returns the index to the item that has the specified, generated container.
    /// </summary>
    /// 
    /// <returns>
    /// The index to the item that corresponds to the specified generated container.
    /// </returns>
    /// <param name="container">The generated container to retrieve the item index for.</param>
    [MethodImpl]
    public int IItemContainerMapping.IndexFromContainer([In] DependencyObject container);
    /// <summary>
    /// Returns the container for the item at the specified index within the ItemCollection.
    /// </summary>
    /// 
    /// <returns>
    /// The container for the item at the specified index within the item collection, if the item has a container; otherwise, null.
    /// </returns>
    /// <param name="index">The index of the item to retrieve.</param>
    [MethodImpl]
    public DependencyObject IItemContainerMapping.ContainerFromIndex([In] int index);
    [MethodImpl]
    protected virtual bool IItemsControlOverrides.IsItemItsOwnContainerOverride([In] object item);
    [MethodImpl]
    protected virtual DependencyObject IItemsControlOverrides.GetContainerForItemOverride();
    [MethodImpl]
    protected virtual void IItemsControlOverrides.ClearContainerForItemOverride([In] DependencyObject element, [In] object item);
    [MethodImpl]
    protected virtual void IItemsControlOverrides.PrepareContainerForItemOverride([In] DependencyObject element, [In] object item);
    [MethodImpl]
    protected virtual void IItemsControlOverrides.OnItemsChanged([In] object e);
    [MethodImpl]
    protected virtual void IItemsControlOverrides.OnItemContainerStyleChanged([In] Style oldItemContainerStyle, [In] Style newItemContainerStyle);
    [MethodImpl]
    protected virtual void IItemsControlOverrides.OnItemContainerStyleSelectorChanged([In] StyleSelector oldItemContainerStyleSelector, [In] StyleSelector newItemContainerStyleSelector);
    [MethodImpl]
    protected virtual void IItemsControlOverrides.OnItemTemplateChanged([In] DataTemplate oldItemTemplate, [In] DataTemplate newItemTemplate);
    [MethodImpl]
    protected virtual void IItemsControlOverrides.OnItemTemplateSelectorChanged([In] DataTemplateSelector oldItemTemplateSelector, [In] DataTemplateSelector newItemTemplateSelector);
    [MethodImpl]
    protected virtual void IItemsControlOverrides.OnGroupStyleSelectorChanged([In] GroupStyleSelector oldGroupStyleSelector, [In] GroupStyleSelector newGroupStyleSelector);
    /// <summary>
    /// Returns the ItemsControl that the specified element hosts items for.
    /// </summary>
    /// 
    /// <returns>
    /// The ItemsControl that the specified element hosts items for, or null.
    /// </returns>
    /// <param name="element">The host element.</param>
    [MethodImpl]
    public static ItemsControl GetItemsOwner([In] DependencyObject element);
    /// <summary>
    /// Returns the ItemsControl that owns the specified container element.
    /// </summary>
    /// 
    /// <returns>
    /// The ItemsControl that owns the specified container element; otherwise, null.
    /// </returns>
    /// <param name="container">The container element to return the ItemsControl for.</param>
    [MethodImpl]
    public static ItemsControl ItemsControlFromItemContainer([In] DependencyObject container);
    /// <summary>
    /// Gets or sets an object source used to generate the content of the ItemsControl.
    /// </summary>
    /// 
    /// <returns>
    /// The object that is used to generate the content of the ItemsControl. The default is null.
    /// </returns>
    public object IItemsControl.ItemsSource { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets the template that defines the panel that controls the layout of items.
    /// </summary>
    /// 
    /// <returns>
    /// An ItemsPanelTemplate that defines the panel to use for the layout of the items. The default value for the ItemsControl is an ItemsPanelTemplate that specifies a StackPanel.
    /// </returns>
    public ItemsPanelTemplate IItemsControl.ItemsPanel { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets a reference to a custom DataTemplateSelector logic class. The DataTemplateSelector referenced by this property returns a template to apply to items.
    /// </summary>
    /// 
    /// <returns>
    /// A reference to a custom DataTemplateSelector logic class.
    /// </returns>
    public DataTemplateSelector IItemsControl.ItemTemplateSelector { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets the DataTemplate used to display each item.
    /// </summary>
    /// 
    /// <returns>
    /// The template that specifies the visualization of the data objects. The default is null.
    /// </returns>
    public DataTemplate IItemsControl.ItemTemplate { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets the collection of Transition style elements that apply to the item containers of an ItemsControl.
    /// </summary>
    /// 
    /// <returns>
    /// The collection of Transition style elements that apply to the item containers of an ItemsControl.
    /// </returns>
    public TransitionCollection IItemsControl.ItemContainerTransitions { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets a reference to a custom StyleSelector logic class. The StyleSelector returns different Style values to use for the item container based on characteristics of the object being displayed.
    /// </summary>
    /// 
    /// <returns>
    /// A custom StyleSelector logic class.
    /// </returns>
    public StyleSelector IItemsControl.ItemContainerStyleSelector { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets the style that is used when rendering the item containers.
    /// </summary>
    /// 
    /// <returns>
    /// The style applied to the item containers. The default is null.
    /// </returns>
    public Style IItemsControl.ItemContainerStyle { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets a reference to a custom GroupStyleSelector logic class. The GroupStyleSelector returns different GroupStyle values to use for content based on the characteristics of that content.
    /// </summary>
    /// 
    /// <returns>
    /// A reference to a custom GroupStyleSelector logic class.
    /// </returns>
    public GroupStyleSelector IItemsControl.GroupStyleSelector { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets the name or path of the property that is displayed for each data item.
    /// </summary>
    /// 
    /// <returns>
    /// The name or path of the property that is displayed for each the data item in the control. The default is an empty string ("").
    /// </returns>
    public string IItemsControl.DisplayMemberPath { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets a collection of GroupStyle objects that define the appearance of each level of groups.
    /// </summary>
    /// 
    /// <returns>
    /// A collection of GroupStyle objects that define the appearance of each level of groups.
    /// </returns>
    public IObservableVector<GroupStyle> IItemsControl.GroupStyle { [MethodImpl] get; }
    /// <summary>
    /// Gets a value that indicates whether the control is using grouping.
    /// </summary>
    /// 
    /// <returns>
    /// true if a control is using grouping; otherwise, false.
    /// </returns>
    public bool IItemsControl.IsGrouping { [MethodImpl] get; }
    /// <summary>
    /// Gets the ItemContainerGenerator associated with this ItemsControl.
    /// </summary>
    /// 
    /// <returns>
    /// The ItemContainerGenerator associated with this ItemsControl.
    /// </returns>
    public ItemContainerGenerator IItemsControl.ItemContainerGenerator { [MethodImpl] get; }
    /// <summary>
    /// Gets the collection used to generate the content of the control.
    /// </summary>
    /// 
    /// <returns>
    /// The collection that is used to generate the content of the control, if it exists; otherwise, null. The default is an empty collection.
    /// </returns>
    public ItemCollection IItemsControl.Items { [MethodImpl] get; }
    /// <summary>
    /// Gets the Panel specified by ItemsPanel.
    /// </summary>
    /// 
    /// <returns>
    /// The Panel specified by ItemsPanel. The default is null.
    /// </returns>
    public Panel IItemsControl2.ItemsPanelRoot { [MethodImpl] get; }
    /// <summary>
    /// Identifies the DisplayMemberPath dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the DisplayMemberPath dependency property.
    /// </returns>
    public static DependencyProperty DisplayMemberPathProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the GroupStyleSelector dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the GroupStyleSelector dependency property.
    /// </returns>
    public static DependencyProperty GroupStyleSelectorProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the IsGrouping dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the IsGrouping dependency property.
    /// </returns>
    public static DependencyProperty IsGroupingProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the ItemContainerStyle dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the ItemContainerStyle dependency property.
    /// </returns>
    public static DependencyProperty ItemContainerStyleProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the ItemContainerStyleSelector dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the ItemContainerStyleSelector dependency property.
    /// </returns>
    public static DependencyProperty ItemContainerStyleSelectorProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the ItemContainerTransitions dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the ItemContainerTransitions dependency property.
    /// </returns>
    public static DependencyProperty ItemContainerTransitionsProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the ItemTemplate dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the ItemTemplate dependency property.
    /// </returns>
    public static DependencyProperty ItemTemplateProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the ItemTemplateSelector dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the ItemTemplateSelector dependency property.
    /// </returns>
    public static DependencyProperty ItemTemplateSelectorProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the ItemsPanel dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the ItemsPanel dependency property.
    /// </returns>
    public static DependencyProperty ItemsPanelProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the ItemsSource dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the ItemsSource dependency property.
    /// </returns>
    public static DependencyProperty ItemsSourceProperty { [MethodImpl] get; }
  }
}
