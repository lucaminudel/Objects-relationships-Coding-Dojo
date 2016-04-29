# Objects relationships - Coding-Dojo

This repositoriy contains two coding exercises to experience the impact of composition and other techniques on objects relationships encapsulation compared to the simplistic design approach.

The exercises are based on concepts covered by this post: http://blogs.ugidotnet.org/luKa/archive/2015/01/20/overcoming-the-one-weakness-of-oop.aspx

**Prerequisites:**
- Practical understanding of basic design principles, SOLID principles and Simple Design
- Experience with fundamental refactoring and design patterns of unit testing as in coding-dojo [Refactoring legacy code driven by tests] (https://github.com/lucaminudel/TDDwithMockObjectsAndDesignPrinciples/blob/master/TDDMicroExercises/README.md)

## Exercise 1. Simplistic design

The goal of this exercise is to experience the impact of simplistic design when new code changes are required.
In order to keep the design simplistic, 
- create direct dependencies between objects. I.e. here A -> B, concrete class A will istantiate and reference directly concrete class B instead of using interfaces or other abstractions or dependency inversions techniques
- implement each required operation on the object graph in a single method that navigate the graph and compute the operation intead of introducing abstractions such as composite design pattern, visitor pattern, or any other abstraction.

Implement the feature requests from this list. Implement one feature request at time, without anticipating the following ones. You are encouraged to write unit tests. Everyone should only take few minutes to implement. For every new feature request take notes of the difficulties you encountered because of the design.

**The problem:** We want to model different parts of a robot, connect them in different ways as the robot evolve, and apply some computations to these parts.

(Each part has a battery with a capacity (Kilo Apmere Hour or KAh) and an on/off status. A robot part can be connected with and control other part)

1. TBD TBD TDB TBD TDB TBD TDB TBD TDB TBD TDB 
2. TBD TBD TDB TBD TDB TBD TDB TBD TDB TBD TDB 
3. TBD TBD TDB TBD TDB TBD TDB TBD TDB TBD TDB 
4. TBD TBD TDB TBD TDB TBD TDB TBD TDB TBD TDB 
5. TBD TBD TDB TBD TDB TBD TDB TBD TDB TBD TDB 
6. TBD TBD TDB TBD TDB TBD TDB TBD TDB TBD TDB 



## Exercise 2. Target design

...
