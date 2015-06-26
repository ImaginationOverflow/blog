using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Xaml.Interactivity;
using WinRTXamlToolkit.Controls.Extensions;

namespace IOToolkit.Views.Behaviors
{
    public class LoadMoreDataAtScrollEndBehavior : DependencyObject, IBehavior
    {
        public enum ScrollOrientation
        {
            Default,
            Vertical,
            Horizontal
        }
        public static readonly DependencyProperty LoadMoreItemsCommandProperty = DependencyProperty.Register("LoadMoreItemsCommand", typeof(ICommand), typeof(LoadMoreDataAtScrollEndBehavior), null);

        private ScrollViewer _scrollViewer;

        public DependencyObject AssociatedObject { get; private set; }

        public ScrollOrientation Orientation { get; set; }

        public double Threshold { get; set; }

        public ICommand LoadMoreItemsCommand
        {
            get { return GetValue(LoadMoreItemsCommandProperty) as ICommand; }
            set { SetValue(LoadMoreItemsCommandProperty, value); }
        }

        public void Attach(DependencyObject associatedObject)
        {
            AssociatedObject = associatedObject;

            if (associatedObject is ScrollViewer)
            {
                AttachToScrollViewer(associatedObject as ScrollViewer);
            }
            else
            {
                var obj = associatedObject as Control;
                obj.Loaded += Control_Loaded;
            }
          
        }


        void Control_Loaded(object sender, RoutedEventArgs e)
        {
            var obj = AssociatedObject as Control;
            obj.Loaded -= Control_Loaded;

            //
            //  If nothing configured, automatically configure to horizontal scroll when
            //  the object is a well known horizontal control
            //
            if (Orientation == ScrollOrientation.Default)
                Orientation = IsKnownHorizontalControl(AssociatedObject) ? ScrollOrientation.Horizontal : ScrollOrientation.Vertical;

            AttachToScrollViewer(AssociatedObject.GetFirstDescendantOfType<ScrollViewer>());
        }

        private bool IsKnownHorizontalControl(DependencyObject associatedObject)
        {
            return associatedObject is GridView || associatedObject is Hub;
        }


        private void AttachToScrollViewer(ScrollViewer scroll)
        {
            _scrollViewer = scroll;
            if (Orientation == ScrollOrientation.Horizontal)
                _scrollViewer.ViewChanged += ScrollViewer_Horizontal_ViewChanged;
            else
                _scrollViewer.ViewChanged += ScrollViewer_Vertical_ViewChanged;
        }


        private void ScrollViewer_Vertical_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            var verticalOffset = _scrollViewer.VerticalOffset;
            var maxVerticalOffset = _scrollViewer.ScrollableHeight;

            CallCommandIfEndReached(verticalOffset, maxVerticalOffset);
        }

        private void ScrollViewer_Horizontal_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            var horizontalOffset = _scrollViewer.HorizontalOffset;
            var maxHorizontalOffset = _scrollViewer.ScrollableWidth;

            CallCommandIfEndReached(horizontalOffset, maxHorizontalOffset);
        }

        private double _lastMaxOffset;

        private async void CallCommandIfEndReached(double currOffset, double maxOffset)
        {

            if (maxOffset == 0 || 
                _lastMaxOffset >= maxOffset)
                return;

            if ((currOffset + Threshold) >= maxOffset)
            {
                _lastMaxOffset = maxOffset;

                if (LoadMoreItemsCommand != null)
                {
                    LoadMoreItemsCommand.Execute(null);
                }
            }
        }


        public void Detach()
        {
            AssociatedObject = null;
            _scrollViewer.ViewChanged -= ScrollViewer_Vertical_ViewChanged;
            _scrollViewer.ViewChanged -= ScrollViewer_Horizontal_ViewChanged;
            _scrollViewer = null;
        }

    }

}
