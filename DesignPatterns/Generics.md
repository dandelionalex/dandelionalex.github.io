# Generics 

Main benefits of generics:
-> Calling a method through an interface is slower than calling it directly on the concrete type.
-> If the type implementing IFoo is a value type, the non-generic version will box the value of the parameter, and boxing can negatively affect performance (especially if you call this method very often).
-> If your method returns a value, the generic version can return a T rather than a IFoo, which is convenient if you need to call a method of T on the result.

https://stackoverflow.com/questions/7224675/practical-advantage-of-generics-vs-interfaces