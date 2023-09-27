﻿using Microsoft.EntityFrameworkCore;

namespace VideoGameGuy.Data
{
    public class IgdbGames_MultiplayerModesRepository : RepositoryBase, IIgdbGames_MultiplayerModesRepository
    {
        #region Fields..
        protected readonly IgdbDbContext _igdbDbContext;
        #endregion Fields..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        public IgdbGames_MultiplayerModesRepository(ILogger<IgdbGames_MultiplayerModesRepository> logger,
                                                    IgdbDbContext igdbDbContext)
         : base(logger)
        {
            _igdbDbContext = igdbDbContext;
        }
        #endregion Constructors..

        #region Methods..
        public async Task<bool> AddOrUpdateRangeAsync(IEnumerable<IgdbGames_MultiplayerModes> igdbGames_MultiplayerModes, bool suspendSaveChanges = false)
        {
            bool success = true;

            try
            {
                foreach (var entry in igdbGames_MultiplayerModes)
                {
                    var existingEntry = await _igdbDbContext.Games_MultiplayerModes.FirstOrDefaultAsync(x => x.Games_SourceId == entry.Games_SourceId 
                                && x.MultiplayerModes_SourceId == entry.MultiplayerModes_SourceId);

                    // Add
                    if (existingEntry == default)
                        _igdbDbContext.Games_MultiplayerModes.Add(entry);

                    // Update
                    else
                    {
                        // Nothing to update on join tables
                    }
                }

                if (!suspendSaveChanges)
                    await _igdbDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message} - {ex.StackTrace}");
                success = false;
            }

            return success;
        }

        public async Task<bool> SaveBulkChangesAsync()
        {
            bool success = true;

            try
            {
                await _igdbDbContext.BulkInsertAsync(_bulkItemsToAdd);
                //await _igdbDbContext.BulkSaveChangesAsync();

                _bulkItemsToAdd.Clear();
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message} - {ex.StackTrace}");
                success = false;
            }

            return success;
        }

        public async Task<bool> StageBulkChangesAsync(IEnumerable<IgdbGames_MultiplayerModes> igdbGames_MultiplayerModes)
        {
            bool success = true;

            foreach (var entry in igdbGames_MultiplayerModes)
            {
                try
                {
                    var existingEntry = await _igdbDbContext.Games_MultiplayerModes.FirstOrDefaultAsync(x => x.Games_SourceId == entry.Games_SourceId
                                                  && x.MultiplayerModes_SourceId == entry.MultiplayerModes_SourceId);
                    // Add
                    if (existingEntry == default)
                        _bulkItemsToAdd.Add(entry);

                    // Update
                    else
                    {
                        // Nothing to update on join tables
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"{ex.Message} - {ex.StackTrace}");
                    success = false;
                }
            }

            return success;
        }
        #endregion Methods..
    }
}
