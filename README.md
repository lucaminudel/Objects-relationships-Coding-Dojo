# Objects relationships encapsulation via composition - Coding-Dojo

This repositoriy contains two coding exercises to experience the impact of composition and other techniques on objects relationships encapsulation compared to the simplistic design approach.

The exercises are based on concepts covered by this post: http://blogs.ugidotnet.org/luKa/archive/2015/01/20/overcoming-the-one-weakness-of-oop.aspx

Prerequisites:
- Practical understanding of basic design principles, SOLID principles and Simple Design
- Experience with fundamental refactorind and design pattern of unit testing as in [Refactoring legacy code driven by tests] (https://github.com/lucaminudel/TDDwithMockObjectsAndDesignPrinciples/blob/master/TDDMicroExercises/README.md)

## Exercise 1. Simplistic design

The goal of this exercise is to experience the impact of simplistic design when new code changes are required.
In order to keep the design simplistic, 
- create direct dependencies between objects. I.e. here A -> B, concrete class A will istantiate and reference directly concrete class B instead of using interfaces or other abstractions or dependency inversions techniques
- implement each required operation on the object graph in a single method that navigate the graph and compute the operation intead of introducing abstractions such as composite design pattern, visitor pattern, or any other abstraction.
