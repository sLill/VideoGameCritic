﻿using System.ComponentModel;

namespace VideoGameGuy.Data
{
    #region Enums..
    public enum IgdbPlatformCategory
    {
        console,
        arcade,
        platform,
        operating_system,
        portable_console,
        computer,
    }

    public enum IgdbCategory
    {
        main_game,
        dlc_addon,
        expansion,
        bundle,
        standalone_expansion,
        mod,
        episode,
        season,
        remake,
        remaster,
        expanded_game,
        port,
        fork,
        pack,
        update,
    }

    public enum IgdbStatus
    {
        main_game,
        dlc_addon,
        expansion,
        bundle,
        standalone_expansion,
        mod,
        episode,
        season,
        remake,
        remaster,
        expanded_game,
        port,
        fork,
        pack,
        update,
    }

    public enum IgdbScreenshotSize
    {
        //	90 x 128	Fit
        [DefaultValue("cover_small")]
        cover_small,

        // 569 x 320	Lfill, Center gravity
        [DefaultValue("screenshot_med")]
        screenshot_med,

        // 264 x 374	Fit
        [DefaultValue("cover_big")]
        cover_big,

        // 284 x 160	Fit
        [DefaultValue("logo_med")]
        logo_med,

        //	889 x 500	Lfill, Center gravity
        [DefaultValue("screenshot_big")]
        screenshot_big,

        //	1280 x 720	Lfill, Center gravity
        [DefaultValue("screenshot_huge")]
        screenshot_huge,

        // 90 x 90	Thumb, Center gravity
        [DefaultValue("thumb")]
        thumb,

        // 35 x 35	Thumb, Center gravity
        [DefaultValue("micro")]
        micro,

        // 1280 x 720	Fit, Center gravity
        [DefaultValue("720p")]
        i720p,

        // 1920 x 1080	Fit, Center gravity
        [DefaultValue("1080p")]
        i1080p
    }
    #endregion Enums..

    // https://api-docs.igdb.com/#game
    public class IgdbGame
    {
        #region Properties..
        public long id { get; set; }
        public double aggregated_rating { get; set; }
        public double aggregated_rating_count { get; set; }
        public List<long> artworks { get; set; }
        public IgdbCategory category { get; set; }
        public Guid checksum { get; set; }
        public long cover { get; set; }
        public ulong created_at { get; set; }
        public ulong first_release_date { get; set; }
        public List<long> game_modes { get; set; }
        public List<long> multiplayer_modes { get; set; }
        public string name { get; set; }
        public long parent_game { get; set; }
        public List<long> platforms { get; set; }
        public double rating { get; set; }
        public int rating_count { get; set; }
        public List<long> screenshots { get; set; }
        public IgdbStatus status { get; set; }
        public string storyline { get; set; }
        public string summary { get; set; }
        public List<long> themes { get; set; }
        public double total_rating { get; set; }
        public int total_rating_count { get; set; }
        public ulong updated_at { get; set; }
        #endregion Properties..
    }

    public class IgdbArtwork
    {
        #region Properties..
        public long id { get; set; }
        public Guid checksum { get; set; }
        public long game { get; set; }
        public int height { get; set; }
        public int image_id { get; set; }
        public string url { get; set; }
        public int width { get; set; } 
        #endregion Properties..
    }

    public class IgdbGameMode
    {
        #region Properties..
        public long id { get; set; }
        public Guid checksum { get; set; }
        public ulong created_at { get; set; }
        public string name { get; set; }
        public ulong updated_at { get; set; } 
        #endregion Properties..
    }

    public class IgdbMultiplayerMode
    {
        #region Properties..
        public long id { get; set; }
        public bool campaigncoop { get; set; }
        public Guid checksum { get; set; }
        public bool dropin { get; set; }
        public long game { get; set; }
        public bool lancoop { get; set; }
        public bool offlinecoop { get; set; }
        public bool onlinecoop { get; set; }
        public long platform { get; set; }
        public bool splitscreen { get; set; }
        public bool splitscreenonline { get; set; } 
        #endregion Properties..
    }

    public class IgdbPlatform
    {
        #region Properties..
        public long id { get; set; }
        public IgdbPlatformCategory category { get; set; }
        public Guid checksum { get; set; }
        public ulong created_at { get; set; }
        public string name { get; set; }
        public long platform_family { get; set; }
        public long platform_logo { get; set; }
        public ulong updated_at { get; set; } 
        #endregion Properties..
    }

    public class IgdbPlatformFamily
    {
        #region Properties..
        public long id { get; set; }
        public Guid checksum { get; set; }
        public string name { get; set; } 
        #endregion Properties..
    }

    public class IgdbPlatformLogo
    {
        #region Properties..
        public long id { get; set; }
        public Guid checksum { get; set; }
        public int height { get; set; }
        public string image_id { get; set; }
        public string url { get; set; }
        public int width { get; set; } 
        #endregion Properties..
    }

    public class IgdbScreenshot
    {
        #region Properties..
        public long id { get; set; }
        public Guid checksum { get; set; }
        public long game { get; set; }
        public int height { get; set; }
        public string image_id { get; set; }
        public string url { get; set; }
        public int width { get; set; } 
        #endregion Properties..
    }

    public class IgdbTheme
    {
        #region Properties..
        public long id { get; set; }
        public Guid checksum { get; set; }
        public ulong created_at { get; set; }
        public string name { get; set; }
        public ulong updated_at { get; set; }
        public string url { get; set; } 
        #endregion Properties..
    }
}
