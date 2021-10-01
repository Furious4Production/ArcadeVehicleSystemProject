/** Created and owned by Furious Production @ Michal Kolodziej. **/

using UnrealBuildTool;
using System.Collections.Generic;

public class VehicleSystemProjectEditorTarget : TargetRules
{
	public VehicleSystemProjectEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "VehicleSystemProject" } );
	}
}
