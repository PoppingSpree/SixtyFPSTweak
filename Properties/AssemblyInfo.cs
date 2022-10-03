using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(SixtyFPSTweak.RisingSlash.BuildInfo.Description)]
[assembly: AssemblyDescription(SixtyFPSTweak.RisingSlash.BuildInfo.Description)]
[assembly: AssemblyCompany(SixtyFPSTweak.RisingSlash.BuildInfo.Company)]
[assembly: AssemblyProduct(SixtyFPSTweak.RisingSlash.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + SixtyFPSTweak.RisingSlash.BuildInfo.Author)]
[assembly: AssemblyTrademark(SixtyFPSTweak.RisingSlash.BuildInfo.Company)]
[assembly: AssemblyVersion(SixtyFPSTweak.RisingSlash.BuildInfo.Version)]
[assembly: AssemblyFileVersion(SixtyFPSTweak.RisingSlash.BuildInfo.Version)]
[assembly: MelonInfo(typeof(SixtyFPSTweak.RisingSlash.SixtyFPSTweak), SixtyFPSTweak.RisingSlash.BuildInfo.Name, SixtyFPSTweak.RisingSlash.BuildInfo.Version, SixtyFPSTweak.RisingSlash.BuildInfo.Author, SixtyFPSTweak.RisingSlash.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]