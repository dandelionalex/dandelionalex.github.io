# Unity WASM

https://docs.unity3d.com/2021.3/Documentation/Manual/class-PlayerSettingsWebGL.html



https://medium.com/@depanther/unity-webgl-secrets-b6ddf214f1fd
PlayerSettings.WebGL.emscriptenArgs = " --profiling-funcs ";

Emscripten version: "2.0.19" path: /Applications/Unity/Hub/Editor/2021.3.28f1/PlaybackEngines/WebGLSupport/BuildTools/Emscripten/emscripten


https://emscripten.org/docs/tools_reference/emcc.html


WASM WebAssemble is a binary instruction format for a stack-based virtual macnine.

https://llvm.org/
emscripten


WASM restriction:
	- Tasks (UniRX)
	- UDP
	- Textures size/compression
	- Memory size ( for bundle decompression)
	- Mobile devices - 

To Investigate:
1. IndexDB -?
2. File.IO, FileStream