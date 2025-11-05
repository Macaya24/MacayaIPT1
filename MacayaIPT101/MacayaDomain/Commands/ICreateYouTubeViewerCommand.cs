using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacayaIPT101Solution.MacayaDomain.Models;

namespace MacayaIPT101Solution.MacayaDomain.Commands
{
    public interface ICreateYouTubeViewerCommand
    {
        Task Execute(YouTubeViewer youTubeViewer);
    }
}
