#tool nuget:?package=Wyam
#addin nuget:?package=Cake.Wyam

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Build")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Recipe = "Blog",
            Theme = "SolidState",
            UpdatePackages = true
        });        
    });
    
Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Recipe = "Blog",
            Theme = "SolidState",
            UpdatePackages = true,
            Preview = true,
            Watch = true
        });        
    });

Task("Debug")
    .Does(() =>
    {
        StartProcess("../Wyam/src/clients/Wyam/bin/Debug/wyam.exe",
            "-a \"../Wyam/src/**/bin/Debug/*.dll\" -r \"blog -i\" -t \"../Wyam/themes/Blog/CleanBlog\" -p -w");
    });

Task("Mono")
    .Does(() =>
    {
        StartProcess(@"c:\Program Files\Mono\bin\mono.exe", "../Wyam/src/clients/Wyam/bin/Debug/wyam.exe " +
            "-a \"../Wyam/src/**/bin/Debug/*.dll\" -r \"blog -i\" -t \"../Wyam/themes/Blog/CleanBlog\" -p --verbose");
    });

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Preview");    

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
