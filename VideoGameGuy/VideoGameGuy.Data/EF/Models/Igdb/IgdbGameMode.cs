﻿namespace VideoGameGuy.Data
{
    public class IgdbGameMode : ModelBase
    {
        #region Fields..
        #endregion Fields..

        #region Properties..
        public Guid IgdbGameModeId { get; set; }

        public List<IgdbGame>? Games { get; set; }
        #endregion Properties..

        #region Constructors..
        #endregion Constructors..

        #region Methods..
        #endregion Methods..
    }
}