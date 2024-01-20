# VSCode Unity3d debugger
1. Check for the last Mono version % mono -V
2. Fix an issue with OmniSharp
	https://stackoverflow.com/questions/66235663/vs-code-problems-with-c-sharp-extension-some-projects-have-trouble-loading-due
		Briefly:
			The first one: Check the version of your C# extension. If you are in 1.25.0, you need to go to the extension settings to set omnisharp.useModernNet to false.

			The second: If you are in version 1.25.0, revert your version to 1.24.0. Make sure to set omnisharp.useGlobalMono to always.
3. Install extension "VSCode Unity Debugger" by "shinganEuler", it was version 3.0.13. Using this extension create and save porjectName/.vscode/launch.json
4. Remove this extension and install "Debugger for Unity 301" by "p1gd0g". Copy launch.json from the "shinganEuler"



# VSCode extension for Unity
	Sinse Auugust 2023 extensionn for Unity in VSCode returned
https://forum.unity.com/threads/microsoft-previews-unity-extension-for-visual-studio-code.1468913/