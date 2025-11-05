using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacayaIPT101Solution.MacayaDomain.Models;
using MacayaIPT101Solution.MacayaYoutubeViewer.Stores;
using MacayaIPT101Solution.MacayaYoutubeViewer.ViewModels;

namespace MacayaIPT101Solution.MacayaYoutubeViewer.Commands
{
    public class OpenEditYouTubeViewerCommand : CommandBase
    {
        private readonly YouTubeViewersListingItemViewModel _youTubeViewersListingItemViewModel;
        private readonly YouTubeViewersStore _youTubeViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditYouTubeViewerCommand(YouTubeViewersListingItemViewModel youTubeViewersListingItemViewModel,
            YouTubeViewersStore youTubeViewersStore, 
            ModalNavigationStore modalNavigationStore)
        {
            _youTubeViewersListingItemViewModel = youTubeViewersListingItemViewModel;
            _youTubeViewersStore = youTubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            YouTubeViewer youTubeViewer = _youTubeViewersListingItemViewModel.YouTubeViewer;

            EditYouTubeViewerViewModel editYouTubeViewerViewModel = 
                new EditYouTubeViewerViewModel(youTubeViewer, _youTubeViewersStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editYouTubeViewerViewModel;
        }
    }
}
