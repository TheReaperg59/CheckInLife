using UnrealBuildTool;

public class LudusChatUI : ModuleRules
{
	public LudusChatUI(ReadOnlyTargetRules Target) : base(Target)
	{
		bUsePrecompiled = true;
		PrecompileForTargets = PrecompileTargetsType.Any;
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		CppStandard = CppStandardVersion.Cpp20;

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"InputCore",
				"Slate",
				"SlateCore",
				"UMG",
				"LudusClient",
				"Projects",
				"UnrealEd",
				"Documentation",
				"GraphEditor",
				"BlueprintGraph",
				"MessageLog",
				"ApplicationCore",
				"Json",
				"EditorSubsystem"
			}
		);

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"LudusCore",
				"WorkspaceMenuStructure",
				"ToolMenus",
				"AppFramework",
				"EditorFramework",
				"Kismet",
				"PlacementMode",
				"Settings",
				"PropertyEditor",
				"DesktopPlatform",
				"AssetTools",
				"SourceCodeAccess",
				"ContentBrowser",
				"LevelEditor",
				"AssetRegistry",
				"Analytics",
				"GameProjectGeneration",
				"LudusMarkdown"
			}
		);

		PrivateIncludePathModuleNames.AddRange(
			new string[] {
				"MainFrame",
				"TargetPlatform",
				"TargetDeviceServices",
				"LauncherServices",
			}
		);

		DynamicallyLoadedModuleNames.AddRange(
			new string[] {
				"MainFrame",
				"LauncherServices",
			}
		);
	}
}