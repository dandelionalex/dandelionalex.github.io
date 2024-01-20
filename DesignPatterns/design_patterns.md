# Programming Paradigm

## Imperative Programming
	Procedural Programming
	Functional Programming

## Declarative Programming
	Reactive Programming

## Object-Oriented Programming	

	https://www.freecodecamp.org/news/an-introduction-to-programming-paradigms/


# Design patterns

## Language independent explanation of design patterns
	Refactoring Guru: https://refactoring.guru/design-patterns/flyweight
	http://gameprogrammingpatterns.com/


	https://github.com/Habrador/Unity-Programming-Patterns list of patterns based on this book 

## Patterns I usualy use:

### 1. Singleton
	Single instance much better

### 2. Observer
	This pattern is all about what will happen after an event has happened. Which methods should be called etc...

### 3. Command

### 4. Factory

### 5. Object Pool

### 6. Service Locator pattern

### 7. State aka state machine

### Achitectural patterns: -----

	IoC - inversion of control
		1. Accordingly to DI, This states that a class should not configure its dependencies statically but should be configured by some other class from outside.
		2. For example framework control execution order of the developers code. 
		3. The major difference between an object-oriented framework and a class library is that the framework calls the application code.
		
		https://medium.com/ssense-tech/dependency-injection-vs-dependency-inversion-vs-inversion-of-control-lets-set-the-record-straight-5dc818dc32d1


	DI - Dependency injection NOT dependency inversion
		Zenject
		https://vcontainer.hadashikick.jp/
		https://github.com/gustavopsantos/reflex
		https://blog.ploeh.dk/2014/06/10/pure-di/ - aka pure man DI
		https://www.freecodecamp.org/news/a-quick-intro-to-dependency-injection-what-it-is-and-when-to-use-it-7578c84fa88f
	ECS - 

## MVP / MVC / MVMC
	Model View Controller
		View knows about model
		View send user input events to Controller
		Cntroller update model

	Model View Presenter
		Presenter update view, view send to presenter user inputs updates;

		https://medium.com/@onurkiris05/model-view-presenter-pattern-mvp-design-patterns-for-unity-4-60e17dd9e7c0
	
	Model View View Model
		View doesnt direct reference the View Model - it use binding instead. Thereby there are no reference between View Model and Model.
		Lots Views can be binded to one ViewModel.
		
	https://blog.devgenius.io/model-view-controller-family-3a0d869d81ea
	https://blog.devgenius.io/model-view-controller-mvc-pattern-in-unity-4ec9061dd0c

## Entiti-Component Pattern
	https://www.toptal.com/unity-unity3d/unity-with-mvc-how-to-level-up-your-game-development

## Clean architecture
	also known as "Domain Driven Design" or "Onion Architecture" or "Hexagonal Architecture" or "Vertical Slice Architecture"

	Simple Clean Architecture
		https://genki-sano.medium.com/simplified-clean-architecture-design-pattern-for-unity-967931583c47

		https://oncehub.com/blog/explaining-clean-architecture
		https://www.codingblocks.net/podcast/clean-architecture-make-your-architecture-scream/ - scream architecture
		https://www.c-sharpcorner.com/article/what-is-clean-architecture/	

## Other architecture patterns 
	https://towardsdatascience.com/10-common-software-architectural-patterns-in-a-nutshell-a0b47a1e9013			

## OTHER therms
	The first class objects is object that can:
		- Appear in an expression
		- Be assigned to a variable
		- Be used as an argument
		- Be returned by a function call
	KISS
		- Keep it simple stupid
	YAGNI
		- You aren't gonna need it
	BDUF 
		- Big design up front		

## SOLID
	- Single Responsibility
	- Open Closure
	- Liskov Substitution
	- Interface Segregation
	- Dependency inversion
		High-level modules should not import anything from low-level modules; they should both depend on abstractions
		Abstractions should not rely on concrete implementations; concrete implementations should depend on abstractions
		The dependency inversion principle states that high-level modules should depend on abstractions rather than low-level modules

## OOP principles
	- Encapsulation
	- Abstraction
	- Inheritance
	- Composition 
	- Polymorphism
		Термин “полиморфизм” обозначает семейство различных механизмов, позволяющих использовать один и тот же участок программы с различными типами в различных контекстах.
	
https://isaaccomputerscience.org/concepts/prog_func_first_class_objects?examBoard=all&stage=all

