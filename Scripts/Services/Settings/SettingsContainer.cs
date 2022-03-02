using System.Collections.Generic;
using SimpleSave.Models;


namespace SimpleSave.Services
{
    /// <summary>
    /// Container to save settings into. 
    /// </summary>
    internal class SettingsContainer : BaseContainer<SettingsContainer>
    {
        #region Default Settings

        static SettingsContainer()
        {
            OnInstanceCreated += SetDefaultSettings;
        }

        private static void SetDefaultSettings(SettingsContainer container)
        {
            container.LogType = InternalLogType.Warning;
            container.Version = "0.1";

            container.Location = Location.DataPath;
            container.SpecifiedLocation = "/Savegames/";
            container.CustomLocation = string.Empty;
            container.AutoCreateDirectory = true;
            container.OverrideSavegames = true;

            container.SceneLoading = SceneLoading.LoadAll;
            container.SavegameEndCondition = SaveGameEndCondition.ActiveSceneChanged;
            container.AllowCrossComponentSaving = false;
            container.AssembliesToScan = new List<string> { "Assembly-CSharp" };

            container.HotKeysEnabled = true;
            container.DebugLogging = false;
        }

        #endregion

        public InternalLogType LogType;
        public string Version;

        public Location Location;
        public string SpecifiedLocation;
        public string CustomLocation;
        public bool AutoCreateDirectory;
        public bool OverrideSavegames;

        public SceneLoading SceneLoading;
        public SaveGameEndCondition SavegameEndCondition;
        public bool AlwaysSaveTagless;
        public bool AllowCrossComponentSaving;
        public List<string> AssembliesToScan;

        public bool HotKeysEnabled;
        public bool DebugLogging;
    }
}