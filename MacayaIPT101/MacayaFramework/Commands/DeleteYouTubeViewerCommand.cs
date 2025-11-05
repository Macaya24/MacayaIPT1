using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacayaIPT101Solution.MacayaDomain.Commands;
using MacayaIPT101Solution.MacayaFramework.DTOs;

namespace MacayaIPT101Solution.MacayaFramework.Commands
{
    public class DeleteYouTubeViewerCommand : IDeleteYouTubeViewerCommand
    {
        private readonly YouTubeViewersDbContextFactory _contextFactory;

        public DeleteYouTubeViewerCommand(YouTubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(Guid id)
        {
            using (YouTubeViewersDbContext context = _contextFactory.Create())
            {
                YouTubeViewerDto youTubeViewerDto = new YouTubeViewerDto()
                {
                    Id = id,
                };

                context.YouTubeViewers.Remove(youTubeViewerDto);
                await context.SaveChangesAsync();
            }
        }
    }
}
