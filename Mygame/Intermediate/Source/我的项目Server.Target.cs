using UnrealBuildTool;

public class 我的项目ServerTarget : TargetRules
{
	public 我的项目ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("我的项目");
	}
}
