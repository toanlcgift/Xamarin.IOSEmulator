﻿using ObjCRuntime;

[assembly: LinkWith("libUTM.a", LinkTarget.Arm64, ForceLoad = true, Frameworks = "MetalKit", LinkerFlags = "-lstdc++ -lz -lgstautodetect -lgstaudiotestsrc -lgstvideoconvert -lgstaudioconvert -lgstvideoscale -lgstvolume -lgstcoreelements -lgstvideorate -lgstjpeg -lgstaudioresample -lgstplayback -lgstadder -lgstopengl -lgstaudiorate -lgstvideofilter -lgstapp -lgstgio -lgsttypefindfunctions -lgstvideotestsrc -lgstosxaudio", SmartLink = true, IsCxx = true)]