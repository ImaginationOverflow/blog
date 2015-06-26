using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ClassLibrary1
{
    public class SomeItem
    {
        public int Id { get; set; }
    }

    public class SomeViewModel : ObservableObject
    {
        public ObservableCollection<SomeItem> ListItems { get; set; }
        public ObservableCollection<SomeItem> ScrollItems { get; set; }
        public ObservableCollection<SomeItem> ScrollThItems { get; set; }
        public ObservableCollection<SomeItem> GridItems { get; set; }

        public SomeViewModel()
        {
            ListItems = new ObservableCollection<SomeItem>();
            ScrollItems = new ObservableCollection<SomeItem>();
            GridItems = new ObservableCollection<SomeItem>();
            ScrollThItems = new ObservableCollection<SomeItem>();

            AddMoreItemsToCollection(ScrollThItems,false);
            AddMoreItemsToCollection(ListItems,false);
            AddMoreItemsToCollection(ScrollItems,false);

            AddMoreItemsToCollection(GridItems,false);
            AddMoreItemsToCollection(GridItems,false);
            AddMoreItemsToCollection(GridItems,false);
        }

        private ICommand _loadMoreListITemsCommand;

        /// <summary>
        /// Gets the LoadMoreListItems.
        /// </summary>
        public ICommand LoadMoreListItemsCommand
        {
            get
            {
                return _loadMoreListITemsCommand
                    ?? (_loadMoreListITemsCommand = new RelayCommand(
                                          () => AddMoreItemsToCollection(ListItems)));

            }
        }

        private ICommand _loadMoreGridItemsCommand;

        /// <summary>
        /// Gets the LoadMoreGridItemsCommand.
        /// </summary>
        public ICommand LoadMoreGridItemsCommand
        {
            get
            {
                return _loadMoreGridItemsCommand
                    ?? (_loadMoreGridItemsCommand = new RelayCommand(
                        () =>
                        {
                            AddMoreItemsToCollection(GridItems);
                        }));
            }
        }

        private ICommand _loadMoreScrollItemsCommand;

        /// <summary>
        /// Gets the LoadMoreScrollItemsCommand.
        /// </summary>
        public ICommand LoadMoreScrollItemsCommand
        {
            get
            {
                return _loadMoreScrollItemsCommand
                    ?? (_loadMoreScrollItemsCommand = new RelayCommand(
                        () =>
                        {
                            AddMoreItemsToCollection(ScrollItems);
                        }));
            }
        }

        private ICommand _loadmorescrollWithThCommand;

        /// <summary>
        /// Gets the LoadmorescrollWithThCommand.
        /// </summary>
        public ICommand LoadmorescrollWithThCommand
        {
            get
            {
                return _loadmorescrollWithThCommand
                    ?? (_loadmorescrollWithThCommand = new RelayCommand(
                        () =>
                        {
                            AddMoreItemsToCollection(ScrollThItems);
                        }));
            }
        }

        private async void AddMoreItemsToCollection(ObservableCollection<SomeItem> col, bool wait = true)
        {

            //
            //  Emulate net req
            //
            if (wait)
                await Task.Delay(100);
            const int moreItemsCount = 10;

            for (int i = 0, currId = col.Count; i < moreItemsCount; i++, currId++)
            {
                col.Add(new SomeItem { Id = currId });
            }
        }
    }
}
