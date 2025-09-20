using UnrealBuildTool;

public class LudusDatabase : ModuleRules
{
    public LudusDatabase(ReadOnlyTargetRules Target) : base(Target)
    {
		bUsePrecompiled = true;
		PrecompileForTargets = PrecompileTargetsType.Any;
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core", 
                "SQLiteCore",
                "LudusCore",
                "SQLiteCore",
                "SQLiteSupport"
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
            }
        );
    }
}