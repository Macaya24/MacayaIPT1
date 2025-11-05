using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacayaIPT101Solution.MacayaDomain.Commands;
using MacayaIPT101Solution.MacayaDomain.Models;
using MacayaIPT101Solution.MacayaFramework.DTOs;

namespace MacayaIPT101Solution.MacayaFramework.Commands
{
    public class CreateYouTubeViewerCommand : ICreateYouTubeViewerCommand
    {
        private readonly YouTubeViewersDbContextFactory _contextFactory;

        public CreateYouTubeViewerCommand(YouTubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(YouTubeViewer youTubeViewer)
        {
            using (YouTubeViewersDbContext context = _contextFactory.Create())
            {
                YouTubeViewerDto youTubeViewerDto = new YouTubeViewerDto()
                {
                    Id = youTubeViewer.Id,
                    Username = youTubeViewer.Username,
                    IsSubscribed = youTubeViewer.IsSubscribed,
                    IsMember = youTubeViewer.IsMember,
                };

                context.YouTubeViewers.Add(youTubeViewerDto);
                await context.SaveChangesAsync();
            }
        }
    }
}
