## Why we have to asign Transform position.

Why do we should assign a new Vector3 to transform.postion.

Everyone knows that we can't move any object in scene just by increasing transform.position.x+=delta, but why.

The reason comes from how C# works with structures.
Vector3 is a structure type, and structure is a value type.
When you get value from the property, it returns a copy of the value, so changing the value of a copy is useless. The compiler is stopping you from writing code that doesn't do what it looks like it does.
(../assets/Sprite_0.png)
The snippet below illustrates the difference between Value and Property.
	public class GO : MonoBehaviour
	{
	    private MyStruct MagicStructProperty { get; set; } // Property

	    private MyStruct MagicStructVariable; 			   // Variable

	    void Start()
	    {
	        StructExample.xPos = 10;            //Wont works

	        MagicStructVariable.xPos = 10;      //works
	    }

	    struct MyStruct 
	    {
	        public float xPos;
	    }
	}

In the Transform class position is property. 
    public Transform transform { get; }
So accessing transform.position returns Vector3 copy of position and you can't modify it.

### Links:
https://answers.unity.com/questions/1078528/cannot-modify-the-return-value-of-transformpositio.html