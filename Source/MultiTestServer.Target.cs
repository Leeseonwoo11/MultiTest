using UnrealBuildTool;
using System.Collections.Generic;

public class MultiTestServerTarget : TargetRules
{
    public MultiTestServerTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Server;

        ExtraModuleNames.AddRange(new string[] { "MultiTest" });
    }
}
