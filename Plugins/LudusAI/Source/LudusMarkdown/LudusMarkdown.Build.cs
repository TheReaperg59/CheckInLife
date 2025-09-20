using UnrealBuildTool;

public class LudusMarkdown : ModuleRules
{
	public LudusMarkdown(ReadOnlyTargetRules Target) : base(Target)
	{
		bUsePrecompiled = true;
		PrecompileForTargets = PrecompileTargetsType.Any;
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		CppStandard = CppStandardVersion.Cpp20;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
			"CoreUObject",
			"Engine",
			"HotReload",
			"Json",
			"LudusCore",
			"UnrealEd",
			"EditorSubsystem"
		});

	}
}
