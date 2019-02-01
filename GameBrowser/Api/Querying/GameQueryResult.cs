namespace GameBrowser.Api.Querying{
    class GameQueryResult{
        public string[] GameTitles {
            get; 
            set;
        }

        public int TotalCount {
            get; 
            set;
        }

        public GameQueryResult(){
            GameTitles = new string[] { };
        }
    }
}
