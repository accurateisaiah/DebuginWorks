using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(DebuginWorks.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(DebuginWorks.BuildInfo.Company)]
[assembly: AssemblyProduct(DebuginWorks.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + DebuginWorks.BuildInfo.Author)]
[assembly: AssemblyTrademark(DebuginWorks.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(DebuginWorks.BuildInfo.Version)]
[assembly: AssemblyFileVersion(DebuginWorks.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(DebuginWorks.DebuginWorks), DebuginWorks.BuildInfo.Name, DebuginWorks.BuildInfo.Version, DebuginWorks.BuildInfo.Author, DebuginWorks.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]