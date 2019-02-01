using MediaBrowser.Model.Plugins;

namespace GameBrowser.Configuration{
    public class PluginConfiguration : BasePluginConfiguration{
        
        /*
         * <summary>
         * Gets or sets the game systems.
         *</summary>
         * <value>The game systems.</value
         */
        public ConsoleFolderConfiguration[] GameSystems {
			get;
			set;
		}
        
        /*
         * <summary>
         * Gets or sets the EmuMovies Username
         * </summary>
         */
		public string EmuMoviesUsername {
			get;
			set;
		}

        /*
         * <summary>
         * Gets or sets the EmuMovies Password
         * </summary>
         */
		public string EmuMoviesPassword {
			get;
			set;
		}

        /*
		 * <summary>
         * Initializes a new instance of the <see cref="PluginConfiguration" /> class.
         * </summary>
         */
        public PluginConfiguration()
        {
            GameSystems = new ConsoleFolderConfiguration[] { };
        }
    }
}
