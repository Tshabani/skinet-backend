using Skinet.Debugging;

namespace Skinet
{
    public class SkinetConsts
    {
        public const string LocalizationSourceName = "Skinet";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "94dacfe9c8524b7db8769eac3b89d3d4";
    }
}
