Make build external:
There are two ways:
1. Build from command line.
2. Build from the python scripts.


FLOW:
1. Task in jira has an ID
2. Developer make feature brunch using JirasTaskID
3. For the test purpose Developer can forсe build in Jenkins. It will stored in developers sub domain. ( there are a check box "force rebuild resources").
4. There are a logs from the last build in the Developers folder.
5. All builds run Unity's unitTests


Links:
https://docs.unity3d.com/Manual/CommandLineArguments.html

/Applications/Unity/2022.1.4/Unity.app/Contents/MacOS/Unity -projectPath ~/Documents/GitHub/monkeyleague -executeMethod BuildScript.PerformBuild 99 -buildTarget Android -batchmode -quit -logfile ~/Documents/Builds/build_test.log

/Applications/Unity/Hub/Editor/2022.3.2f1/Unity.app/Contents/MacOS/Unity -projectPath /Users/aleksejpozdnakov/Documents/DirtyTacoStudio/StopXenoFuck/StopXenoFuckUnity -executeMethod XenoBuildScript.StartBuild

Which task I want to make
1. Format html
2. Compare files
3. Upload to amazon
4. Report to email
5. Report to slack
6. Make a archive on xCode
7. Run Unit Tests

Requerements
Emscripten
LLVM
clang (part of the LLVM)

