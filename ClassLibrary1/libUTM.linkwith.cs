using ObjCRuntime;

[assembly: LinkWith("libcocos2diOS.a", LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true, Frameworks = "", LinkerFlags = "-lstdc++ -lz", SmartLink = true, IsCxx = true)]