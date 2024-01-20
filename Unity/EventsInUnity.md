# Events in Unity
1. MessagePipe 
	https://github.com/Cysharp/MessagePipe
2. Spread enents using ScriptableObjects. Eeach events reprasents in didicated scriptable object. To subscribe/unsibsctribe we must add field to MonoBehavior object.
	+ Easy to use on UnityEnviroment. Not overengeenered
	- Not works with a not unity classes

	https://www.youtube.com/watch?v=lgA8KirhLEU&t=248s
3. Store EventHandlers in Dictionary with Key (type) of child of EventArgs
	Dictionary<Type, List<EventHandler> subcsribersByType = new Dictionary<Type, EventHandler>();
	public void Subscribe<T> (EventHandler handler) where T : EventArgs
	{
		subcsribersByType.Add(typeof(T), handler);
	}
	https://www.youtube.com/watch?v=JUoZhJ0Ztmg

	- relays on type of data, so it is impossible to make different events with same data
4.  
	https://github.com/NullTale/UnityEventBus	


3. Events in UniRX event


very good explanation of Events vs Delegates
https://www.youtube.com/watch?v=6NRqwL3N5Go - 






NOT GOOD
https://hackernoon.com/using-an-enum-based-event-bus-pattern-in-unity - not good example by mail.ru employer, using UniRX