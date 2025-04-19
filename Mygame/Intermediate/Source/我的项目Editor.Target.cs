using UnrealBuildTool;

public class 我的项目EditorTarget : TargetRules
{
	public 我的项目EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("我的项目");
	}
}
