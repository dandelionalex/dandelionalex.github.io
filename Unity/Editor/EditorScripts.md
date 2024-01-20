## Editor scripts

There are four global parts of UnityEditor API
	1. Attributes - 		(Header, Range, Space etc) very simple solution 
	2. Property Drawer -	
	Custom Inspector
	2. Editor Window
	3. Custom 
	4. Handles


# Classes
	
	Editor 			- Base class for constom inspector scripts for existing MonoBehaviour.
	EditorWindow 	- Base class for costom editor window. Exist separately from scene GameObjects

	SceneView 		- inherits from EditorWindow
	ObjectPreview 	- Base Class to derive from when creating Custom Previews.

# GUI types
	- IMGUI (Immediate Mode GUI) - old fashioned GUI, used mainly to customize inspector
	- UGUI (UnityGUI) - quite modern GUI, - used in realtime can't be implememented in inspector
	- UI Toolkit (UIElements) - the lastest GUI, only used in the editor. Since Unity 2022.1 UI ToolKit is recomended packege for Editor UI


Attributes
	[CustomEditor(typeof(WaypointPath))]



Events:
	Editor.OnSceneGUI() 					- handle an event in the Scene view.
	Editor.OnInspectorGUI() override		- function to make a custom inspector.
	Editor.OnGUI()							- 


Selection.activeTransform = target;
SceneView.lastActiveSceneView.FrameSelected();


Links:
	https://docs.unity3d.com/ScriptReference/Event.html
	https://nosuchstudio.medium.com/learn-unity-editor-scripting-overview-part-0-1da6fe2552ba
	https://www.blog.radiator.debacle.us/2016/06/working-with-custom-objectpreviews-and.html - ObjectPreview
	https://catlikecoding.com/unity/tutorials/editor/star/ - make and ajust star mesh using IMGUI
	https://docs.unity3d.com/ScriptReference/Editor.RenderStaticPreview.html - 
