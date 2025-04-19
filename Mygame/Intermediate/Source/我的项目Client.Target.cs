using UnrealBuildTool;

public class 我的项目ClientTarget : TargetRules
{
	public 我的项目ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("我的项目");
	}
}
