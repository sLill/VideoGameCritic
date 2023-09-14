namespace VideoGameCritic.Data
{
    public class ErrorLog : ModelBase
    {
        #region Properties..
        public Guid ErrorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Message { get; set; }
        #endregion Properties..

        #region Constructors..
        #endregion Constructors..
    }
}
