# iOSLargeTitleRepro
 A reproduction demonstrating the incorrect BarBackgroundColor when using `On<iOS>().SetPrefersLargeTitles(true)`
 
 ![Sample GIF](https://user-images.githubusercontent.com/13558917/65711206-449ec100-e049-11e9-9ea8-7eecedff7d62.gif)
 
## Environment 


=== Visual Studio Enterprise 2019 for Mac ===

Version 8.3 (build 1805)
Installation UUID: 3a44bb7e-f162-4472-825a-c8f8d1d6fd30
	GTK+ 2.24.23 (Raleigh theme)
	Xamarin.Mac 5.16.1.24 (d16-3 / 08809f5b)

	Package version: 604000198

=== Mono Framework MDK ===

Runtime:
	Mono 6.4.0.198 (2019-06/fe64a4765e6) (64-bit)
	Package version: 604000198

=== Xamarin Designer ===

Version: 16.3.0.230
Hash: bbe518670
Branch: remotes/origin/d16-3-xcode11
Build date: 2019-09-17 18:39:30 UTC

=== NuGet ===

Version: 5.3.0.6192

=== .NET Core SDK ===

SDK: /usr/local/share/dotnet/sdk/3.0.100/Sdks
SDK Versions:
	3.0.100
	3.0.100-rc1-014190
	3.0.100-preview9-014004
	3.0.100-preview8-013656
	3.0.100-preview7-012821
	3.0.100-preview6-012264
	2.2.402
	2.1.701
	2.1.700
	1.1.14
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/6.4.0/lib/mono/msbuild/Current/bin/Sdks

=== .NET Core Runtime ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	3.0.0
	3.0.0-rc1-19456-20
	3.0.0-preview9-19423-09
	3.0.0-preview7-27912-14
	3.0.0-preview6-27804-01
	2.2.7
	2.1.13
	2.1.12
	2.1.11
	1.1.13
	1.0.16

=== Xamarin.Profiler ===

Version: 1.6.11.16
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Updater ===

Version: 11

=== Apple Developer Tools ===

Xcode 11.0 (14936)
Build 11A420a

=== Xamarin.Mac ===

Xamarin.Mac not installed. Can't find /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/Version.

=== Xamarin.iOS ===

Version: 13.2.0.42 (Visual Studio Enterprise)
Hash: 5e8a208b
Branch: d16-3
Build date: 2019-09-17 14:19:30-0400

=== Xamarin.Android ===

Version: 10.0.0.43 (Visual Studio Enterprise)
Commit: xamarin-android/d16-3/8af1ca8
Android SDK: /Users/bramin/Library/Developer/Xamarin/android-sdk-macosx
	Supported Android versions:
		None installed

SDK Tools Version: 26.1.1
SDK Platform Tools Version: 29.0.3
SDK Build Tools Version: 28.0.3

Build Information: 
Mono: mono/mono/2019-06@7af64d1ebe9
Java.Interop: xamarin/java.interop/d16-3@5836f58
LibZipSharp: grendello/LibZipSharp/d16-3@71f4a94
LibZip: nih-at/libzip/rel-1-5-1@b95cf3f
ProGuard: xamarin/proguard/master@905836d
SQLite: xamarin/sqlite/3.27.1@8212a2d
Xamarin.Android Tools: xamarin/xamarin-android-tools/d16-3@cb41333

=== Microsoft Mobile OpenJDK ===

Java SDK: /Users/bramin/Library/Developer/Xamarin/jdk/microsoft_dist_openjdk_1.8.0.25
1.8.0-25
Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Android SDK Manager ===

Version: 1.4.0.65
Hash: c33b107
Branch: remotes/origin/d16-3
Build date: 2019-09-19 20:42:44 UTC

=== Android Device Manager ===

Version: 1.2.0.115
Hash: 724ea69
Branch: remotes/origin/d16-3
Build date: 2019-09-19 20:43:06 UTC

=== Xamarin Inspector ===

Version: 1.4.3
Hash: db27525
Branch: 1.4-release
Build date: Mon, 09 Jul 2018 21:20:18 GMT
Client compatibility: 1

=== Build Information ===

Release ID: 803001805
Git revision: df50511ccb08d4d84a53939f1d7fc0b40cbb0ee1
Build date: 2019-09-20 16:10:55+00
Build branch: release-8.3
Xamarin extensions: da8d448cd65f2cc87c5e6dc7e2c2ca7b96d20c72

=== Operating System ===

Mac OS X 10.14.6
Darwin 18.7.0 Darwin Kernel Version 18.7.0
    Tue Aug 20 16:57:14 PDT 2019
    root:xnu-4903.271.2~2/RELEASE_X86_64 x86_64

