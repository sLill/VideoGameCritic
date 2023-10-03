﻿using Microsoft.AspNetCore.SignalR;

namespace VideoGameGuy.Core
{
    public class CountdownTimerHub : Hub
    {
        #region Fields..
        private readonly CountdownTimerService _countdownTimerService;
        #endregion Fields..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        //public CountdownTimerHub(CountdownTimerService countdownTimerService)
        //{
        //    _countdownTimerService = countdownTimerService;
        //}

        public CountdownTimerHub()
        {

        }
        #endregion Constructors..

        #region Methods..
        #region Event Handlers..
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();

            //_countdownTimerService.AddClient(Context.ConnectionId, TimeSpan.FromSeconds(1));
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            //if (!string.IsNullOrEmpty(Context.ConnectionId))
            //    _countdownTimerService.RemoveClient(Context.ConnectionId);

            return base.OnDisconnectedAsync(exception);
        }
        #endregion Event Handlers..		

        public async Task StartCountdownForUser()
        {
            _countdownTimerService.AddClient(Context.ConnectionId, TimeSpan.FromSeconds(1));
        }
        #endregion Methods..
    }
}
