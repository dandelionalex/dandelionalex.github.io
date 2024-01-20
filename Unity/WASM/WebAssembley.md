WebAssembley (wasm)

https://github.com/WebAssembly


WebAssembley MVP
	Java Script is garbage collected memory

WebAssembley has binary and text format.

Compilling process:

Working with memory in browser:
	WebAssembly has 32-bit and 64-bit architecture variants, called wasm32 and wasm64. wasm32 has an ILP32 data model, meaning that int, long, and pointer types are all 32-bit, while the long long type is 64-bit. wasm64 has an LP64 data model, meaning that long and pointer types will be 64-bit, while int is 32-bit.

	https://webassembly.github.io/spec/core/syntax/modules.html#Tables
	https://github.com/WebAssembly/memory64/blob/main/proposals/memory64/Overview.md
	https://v8.dev/blog/4gb-wasm-memory

	Browser ha limination of allocation memory to 4Gb





https://github.com/WebAssembly/wabt - WebAssemble binary toolkit
https://developer.mozilla.org/en-US/docs/WebAssembly - oficial documentation

https://cmake.org/cmake/help/latest/manual/cmake.1.html

links
https://www.webassemblyman.com/wat_webassembly_text_format.html




Profilling:

https://medium.com/performance-engineering-for-the-ordinary-barbie/intro-to-memory-profiling-chrome-devtools-memory-tab-explained-5a99d3ba85d2
https://developer.chrome.com/blog/wasm-debugging-2020/

Tools
Emscripten
	https://emscripten.org/docs/getting_started/downloads.html

cmake 

clang

LLVM
	The main purpose of LLVM is make the same optimestion step for all the languages
	https://youtu.be/J5xExRGaIIY?si=gy9xt4yWc_uROf05

Python


IL2CPP

Google V8
	https://v8.dev/

WebGL	

Compillers explanation
	https://youtu.be/4HgShra-KnY?si=vgCanKCeRJv650Q2