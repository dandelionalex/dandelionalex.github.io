MINE TYPE
	application/octet-stream 	- This is the default for binary files. As it means unknown binary file
	application/wasm			- 
	application/gzip			- 
	text/html  					- 
	text/plain					- This is the default for textual files.
	text/css 					- 
	text/javascript				- 

HEADER:

content-type: application/octet-stream


CURL commands:
curl -I ya.ru 
curl - v 



HTTP Response Header "Content-Encoding: gzip"

SVN COMMANDS
svn propset glu:content-type text/html


errors:

Unable to parse Build/WebGL.framework.js.gz! This can happen if build compression was enabled but web server hosting the content was misconfigured to not serve the file with HTTP Response Header "Content-Encoding: gzip" present. Check browser Console and Devtools Network tab to debug.

