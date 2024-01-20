## Touch handlers

1.	There are methods OnMouseUpAsButton() and OnMouseDown()
	
	From the oficial documntation:
		These functions are called on GameObjects with Colliders marked as triggers.
		These settings are neccessary:
			For 3D physics: Physics.queriesHitTriggers
			For 2D physics: Physics2D.queriesHitTriggers

		In addition, OnMouseDown can be a coroutine.

	How does it work:
		MouseEvents.DoSendMouseEvents() - receive mouse click and chech for all possible collider.
		After all preparesion it execute:  
			var hit3D = CameraRaycastHelper.RaycastTry(camera, screenProjectionRay, distanceToClipPlane, camera.cullingMask & camera.eventMask);
        If any hits found this class send event to hit Object
            m_MouseDownHit[i].SendMessage("OnMouseDown") / "OnMouseUpAsButton", "OnMouseUp", "OnMouseDrag", "OnMouseOver", "OnMouseExit", "OnMouseEnter", "OnMouseOver"           

	Benefits:
		+ Easy to use, just attack script to GameObject
		+ Easy to understand, simple composition pattern

	Flaws:
		- Works only with mouse and touch screen, and will not work with VR or other not standard controllers.
		- You can't debug it with Debug.DrawRay();
		- Not work if one object hide another. Detect mouse interaction only on the nearest GameObject
		- Use legacy input system UnityEngine.InputLegacyModule - not work with new InputSystem

	https://github.com/Unity-Technologies/UnityCsReference/blob/master/Modules/InputLegacy/MouseEvents.cs	


2. bool Physics.Raycast(Ray ray, RaycastHit out hit);
	Benefits
		+ Can filter by layermask
		+ It can execute in the arbitrary Monobehaviour place, not only after the FixedUpdate.
		+ It does not depend on the Physics.queriesHitTriggers settings.
	Flaws:
		- Interact only on the first collided object.

3. RaycastHit[] Physics.RaycastAll(Ray ray);
	Benefits
		+ All from the Physics.Raycast
		+ Can detect collision on many objects
	Flaws
		- 

4. IPointerDownHandler and IPointerUpHandler - Event systems interfaces
	Part of the UnityEngine.UI Package

	EventSystem go throu all Raycastrs in the scene (Physics2DRaycaster, PhysicsRaycaster, GraphicsRaycaster). Check for any collision, and after that, send an events for all classes in the hierarchy implements IPointerDownHandler.
	var newPressed = ExecuteEvents.ExecuteHierarchy(currentOverGo, pointerEvent, ExecuteEvents.pointerDownHandler);

	UnityEngine.UI.Button implement IPointerClickHandler and all onClick

5. New input system
	To enable new Input System select in the drop down menu in the Player Setting -> Active Input Handling. 
	- Enabling new Input System broke interaction in old OnGUI() method
	- The new input system cannot yet feed text input into TextMesh Pro input field components
	- Unity Remote doesn't currently support the Input System

	Benefits:
		+ Fast way to implement Interaction considering design patterns.

	+ have to replace standart input module with InputSystemUIInputModule




Physics.queriesHitBackfaces


Links:


https://docs.unity3d.com/Manual/ExecutionOrder.html





Physics2D.OverlapPointAll(Camera.main.ScreenToWorldPoint(Input.mousePosition)) 
