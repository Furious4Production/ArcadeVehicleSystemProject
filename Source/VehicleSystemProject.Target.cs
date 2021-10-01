/** Created and owned by Furious Production @ Michal Kolodziej. **/

using UnrealBuildTool;
using System.Collections.Generic;

public class VehicleSystemProjectTarget : TargetRules
{
	public VehicleSystemProjectTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "VehicleSystemProject" } );
	}
}
