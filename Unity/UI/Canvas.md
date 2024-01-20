## Canvas layout
Convert from world space to canvas space
https://answers.unity.com/questions/799616/unity-46-beta-19-how-to-convert-from-world-space-t.html

Layout Group Explained
https://www.hallgrimgames.com/blog/2018/10/16/unity-layout-groups-explained

- Any Game Object with a Rect Transform on it can function as a layout element. They will by default have minimum, preferred, and flexible sizes of 0. 
- ILayoutElement contains: minWidth, preferredWidth, flexibleWidth
- A layout group doesn't control its own size. Instead it functions as a layout element itself which may be controlled by other layout controllers or be set manually.
- 


SizeDelta
	https://stackoverflow.com/questions/44471568/how-to-calculate-sizedelta-in-recttransform