namespace VideoGameCritic.Data
{
    public class ErrorViewModel
    {
        #region Properties..
        public string? RequestId { get; set; }

        public bool ShowRequestId 
            => !string.IsNullOrEmpty(RequestId); 
        #endregion Properties..
    }
}