namespace FAIL
{
    public class Setting
    {
        #region Vars

        private string _shard;
        private uint _homeRunebookID;
        private int _homeRuneNumber;

        #endregion Vars

        #region Properties

        public string Shard
        {
            get { return _shard; }
            set { _shard = value; }
        }

        public uint HomeRunebookID
        {
            get { return _homeRunebookID; }
            set { _homeRunebookID = value; }
        }

        public int HomeRuneNumber
        {
            get { return _homeRuneNumber; }
            set { _homeRuneNumber = value; }
        }

        #endregion Properties

        #region Constructs

        public Setting()
        {
        }

        public Setting(string Shard, uint HomeRunebookID, int HomeRuneNumber)
        {
            this.Shard = Shard;
            this.HomeRunebookID = HomeRunebookID;
            this.HomeRuneNumber = HomeRuneNumber;
        }

        #endregion Constructs
    }
}