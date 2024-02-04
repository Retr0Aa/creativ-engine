workspace "CreativEngine"
    configurations { "Debug", "Release" }
    startproject "CreativEditor"

    group "Engine"
    project "CreativEngine"
        kind "SharedLib"
        language "C#"
        targetdir "bin/Engine/%{cfg.buildcfg}"
        location "CreativEngine"

        nuget { "Newtonsoft.Json:13.0.3" }

        files { "CreativEngine/src/**.cs" }

        links { "Retr0Log", "System.Drawing", "System.Windows.Forms" }
    
    project "CreativEditor"
        kind "ConsoleApp"
        location "CreativEditor"
        language "C#"
        targetdir "bin/Editor/%{cfg.buildcfg}"

        files { "CreativEditor/src/**.cs" }

        links { "System", "CreativEngine", "System.Drawing", "System.Windows.Forms" }

    group ""
    project "BuildGame"
        kind "ConsoleApp"
        language "C#"
        targetdir "bin/BuildGame/%{cfg.buildcfg}"
        location "BuildGame"
    
        files { "BuildGame/src/**.cs" }
    
        links { "CreativEngine", "System.Drawing", "System.Windows.Forms" }

    group "Dependecies"
    include "Dependencies/Retr0Log"