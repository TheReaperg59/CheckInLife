using UnrealBuildTool;

public class LudusClient : ModuleRules
{
	public LudusClient(ReadOnlyTargetRules Target) : base(Target)
	{
		bUsePrecompiled = true;
		PrecompileForTargets = PrecompileTargetsType.Any;
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"InputCore",
				"LudusCore",
				"HTTP",
				"HTTPServer",
				"Projects",
				"Json",
				"JsonUtilities", 
				"BlueprintGraph",
				"HotReload", 
				"SQLiteCore",
				"SQLiteSupport",
				"LudusDatabase",
				"BlueprintGraph",
				"Kismet",
				"KismetCompiler"
			}
		);

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"LudusEditor",
				"LevelEditor",
				"UnrealEd",
				"EditorSubsystem",
				"SlateCore",
				"Slate",
				"EditorScriptingUtilities", 
				"BlueprintGraph",
				"GameplayTasksEditor",
				"UMG", 
				"AnimGraph", 
				"AIGraph",
			}
		);
	}
}