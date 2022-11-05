using UnrealBuildTool;

public class PompierPompTarget : TargetRules
{
	public PompierPompTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("PompierPomp");
	}
}
