// Type: Windows.UI.Xaml.Controls.Hub
// Assembly: Windows, Version=255.255.255.255, Culture=neutral
// MVID: A327EA32-BBFD-46B9-A970-A7F324BB7169
// Assembly location: C:\Program Files (x86)\Windows Kits\8.1\References\CommonConfiguration\Neutral\Windows.winmd

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>
  /// Represents a control that displays groups of content in a panning view.
  /// </summary>
  [WebHostHidden]
  [Version(100859904U)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IHubFactory), CompositionType.Public, 100859904U)]
  [ContentProperty(Name = "Sections")]
  [Static(typeof (IHubStatics), 100859904U)]
  public class Hub : Control, IHub, ISemanticZoomInformation
  {
    /// <summary>
    /// Initializes a new instance of the Hub class.
    /// </summary>
    [MethodImpl]
    public Hub();
    /// <summary>
    /// Scrolls the hub to bring the specified hub section into view.
    /// </summary>
    /// <param name="section">The hub section to bring into view.</param>
    [MethodImpl]
    public void IHub.ScrollToSection([In] HubSection section);
    /// <summary>
    /// Initializes the changes to related aspects of presentation (such as scrolling UI or state) when the overall view for a SemanticZoom is about to change.
    /// </summary>
    [MethodImpl]
    public void ISemanticZoomInformation.InitializeViewChange();
    /// <summary>
    /// Changes related aspects of presentation when the overall view for a SemanticZoom changes.
    /// </summary>
    [MethodImpl]
    public void ISemanticZoomInformation.CompleteViewChange();
    /// <summary>
    /// Forces content in the view to scroll until the item that's specified by SemanticZoomLocation is visible. Also focuses the item if it finds the item.
    /// </summary>
    /// <param name="item">The item in the view to scroll to.</param>
    [MethodImpl]
    public void ISemanticZoomInformation.MakeVisible([In] SemanticZoomLocation item);
    /// <summary>
    /// Initializes item-wise operations that are related to a view change when the Hub instance is the source view and the pending destination view is a potentially different implementing view.
    /// </summary>
    /// <param name="source">The view item as represented in the source view.</param><param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public void ISemanticZoomInformation.StartViewChangeFrom([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
    /// <summary>
    /// Initializes item-wise operations that are related to a view change when the source view is a different view and the pending destination view is the Hub instance.
    /// </summary>
    /// <param name="source">The view item as represented in the source view.</param><param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public void ISemanticZoomInformation.StartViewChangeTo([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
    /// <summary>
    /// Completes item-wise operations that are related to a view change when the Hub instance is the source view and the new view is a potentially different implementing view.
    /// </summary>
    /// <param name="source">The view item as represented in the source view.</param><param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public void ISemanticZoomInformation.CompleteViewChangeFrom([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
    /// <summary>
    /// Completes item-wise operations that are related to a view change when the Hub instance is the destination view and the source view is a potentially different implementing view.
    /// </summary>
    /// <param name="source">The view item as represented in the source view.</param><param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public void ISemanticZoomInformation.CompleteViewChangeTo([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
    /// <summary>
    /// Gets or sets the SemanticZoom instance that hosts the Hub.
    /// </summary>
    /// 
    /// <returns>
    /// The SemanticZoom instance that hosts this Hub, or null if the Hub is not hosted in a SemanticZoom control.
    /// </returns>
    public SemanticZoom ISemanticZoomInformation.SemanticZoomOwner { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets a value that indicates whether the Hub instance is the zoomed-in view in its owning SemanticZoom.
    /// </summary>
    /// 
    /// <returns>
    /// true if the Hub is the zoomed-in view; otherwise, false.
    /// </returns>
    public bool ISemanticZoomInformation.IsZoomedInView { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets a value that indicates whether the Hub instance is the active view in its owning SemanticZoom.
    /// </summary>
    /// 
    /// <returns>
    /// true if the Hub is the active view; otherwise, false.
    /// </returns>
    public bool ISemanticZoomInformation.IsActiveView { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets the orientation of a Hub.
    /// </summary>
    /// 
    /// <returns>
    /// One of the Orientation values. The default is Horizontal.
    /// </returns>
    public Orientation IHub.Orientation { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets the DataTemplate used to display the content of the hub header.
    /// </summary>
    /// 
    /// <returns>
    /// The template that specifies the visualization of the header object. The default is null.
    /// </returns>
    public DataTemplate IHub.HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets the content for the hub header.
    /// </summary>
    /// 
    /// <returns>
    /// The content of the hub header. The default is null.
    /// </returns>
    public object IHub.Header { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets or sets the index of the hub section to show first when the Hub is initialized.
    /// </summary>
    /// 
    /// <returns>
    /// The index of the hub section to show first when the Hub is initialized.
    /// </returns>
    public int IHub.DefaultSectionIndex { [MethodImpl] get; [MethodImpl] set; }
    /// <summary>
    /// Gets a collection of the headers of the hub sections.
    /// </summary>
    /// 
    /// <returns>
    /// The headers of the hub sections. The default is an empty collection.
    /// </returns>
    public IObservableVector<object> IHub.SectionHeaders { [MethodImpl] get; }
    /// <summary>
    /// Gets all the hub sections in the Hub.
    /// </summary>
    /// 
    /// <returns>
    /// All the hub sections in the Hub. The default is an empty collection.
    /// </returns>
    public IList<HubSection> IHub.Sections { [MethodImpl] get; }
    /// <summary>
    /// Gets the hub sections currently on the screen.
    /// </summary>
    /// 
    /// <returns>
    /// The hub sections currently on the screen.
    /// </returns>
    public IList<HubSection> IHub.SectionsInView { [MethodImpl] get; }
    /// <summary>
    /// Identifies the DefaultSectionIndex dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the DefaultSectionIndex dependency property.
    /// </returns>
    public static DependencyProperty DefaultSectionIndexProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the Header dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the Header dependency property.
    /// </returns>
    public static DependencyProperty HeaderProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the HeaderTemplate dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the HeaderTemplate dependency property.
    /// </returns>
    public static DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the IsActiveView dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the IsActiveView dependency property.
    /// </returns>
    public static DependencyProperty IsActiveViewProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the IsZoomedInView dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the IsZoomedInView dependency property.
    /// </returns>
    public static DependencyProperty IsZoomedInViewProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the Orientation dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the Orientation dependency property.
    /// </returns>
    public static DependencyProperty OrientationProperty { [MethodImpl] get; }
    /// <summary>
    /// Identifies the SemanticZoomOwner dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the SemanticZoomOwner dependency property.
    /// </returns>
    public static DependencyProperty SemanticZoomOwnerProperty { [MethodImpl] get; }
    /// <summary>
    /// Occurs when a section header is clicked and the section's IsHeaderInteractive property is true.
    /// </summary>
    public event HubSectionHeaderClickEventHandler IHub.SectionHeaderClick;
    /// <summary>
    /// Occurs when the SectionsInView collection changes.
    /// </summary>
    public event SectionsInViewChangedEventHandler IHub.SectionsInViewChanged;
  }
}
