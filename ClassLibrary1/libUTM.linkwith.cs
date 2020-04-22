using ObjCRuntime;

[assembly: LinkWith("libUTM.a", LinkTarget.Arm64, ForceLoad = true, Frameworks = "", LinkerFlags = "-lstdc++ -lz", SmartLink = true, IsCxx = true)]