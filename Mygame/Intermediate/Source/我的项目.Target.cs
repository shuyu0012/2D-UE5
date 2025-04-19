using UnrealBuildTool;

public class 我的项目Target : TargetRules
{
	public 我的项目Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("我的项目");
	}
}
