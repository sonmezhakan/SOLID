#SOLID Principle
-In object-oriented programming, SOLID principles are design patterns used to make software design more understandable, flexible, and sustainable.

1. Single Responsibility Principle
2. Open/Closed Principle
3. Liskov Substitution Principle
4. Interface Segregation Principle
5. Dependency Inversion Principle

##Single Responsibility Principle
-Single Responsibility Principle advocates that each class and method should have only one responsibility. This means that classes and methods should be used for a single purpose. Classes and methods with a single responsibility are easier to code, have better readability, and are more easily manageable. Moreover, they reduce the number of errors, increase development speed, and help in quickly identifying encountered errors.

##Open/Closed Principle
-Open/Closed Principle states that when creating our classes and methods, we should design with an anticipation of possible future requests and developments. It advocates that the code should be designed in a way that the addition of new functionalities and requirements in the project does not require changes to the existing code, and it should be extensible without modifying previously written code.

##Liskov Substitution Principle
-Subclasses should use all the functions inherited from their superclass. At the same time, operations performed in subclasses should not affect the superclasses. However, if a subclass is not going to use all the features of the superclass, another principle of SOLID comes into play the Interface Segregation Principle.

##Interfaces Segregation Principle
-Principle that advocates the separation of interfaces. Interfaces contain declarations of abstract methods. When an interface is implemented by a class, that class is obligated to use all the methods defined in that interface. However, implementing methods in a class that are not needed goes against this principle. Therefore, interfaces should be separated, preventing classes from being forced to use unnecessary methods.

##Dependency Inversion Principle
-According to this principle, high-level and low-level modules should not be dependent on each other but should be dependent on abstractions (interfaces or abstract classes). Interfaces or abstract classes should not depend on subclasses; instead, subclasses should depend on interfaces or abstract classes. This way, when using classes, dependencies are reduced by calling through interfaces or abstract classes, and changes made in subclasses do not affect them.
