# Objects relationships - Coding-Dojo

This repositoriy contains two coding exercises to experience the impact of composition and other techniques on objects relationships encapsulation compared to the simplistic design approach.

The exercises are based on concepts covered by this post: http://blogs.ugidotnet.org/luKa/archive/2015/01/20/overcoming-the-one-weakness-of-oop.aspx

**Prerequisites:**
- Practical understanding of basic design principles, SOLID principles and Simple Design
- Experience with fundamental refactoring and design patterns of unit testing as in coding-dojo [Refactoring legacy code driven by tests] (https://github.com/lucaminudel/TDDwithMockObjectsAndDesignPrinciples/blob/master/TDDMicroExercises/README.md)

## Exercise 1. Simplistic design

The goal of this exercise is to experience the impact of simplistic design when new code changes are required.
In order to keep the design simplistic, 
- create direct dependencies between objects. I.e. here A -> B, concrete class A will istantiate and reference directly concrete class B instead of using interfaces or other abstractions or dependency inversions techniques;
- each feature that requires computations on the whole object graph, should be implemented in a single method that navigate the graph and compute the operation instead of introducing abstractions such as composite design pattern, visitor pattern, or any other abstraction.

The list below contains all the feature requests to be implemented. Implement one feature request at a time, without anticipating the following ones. You are encouraged to write unit tests. Every feature request should only take few minutes to implement. For every new feature request take notes of the difficulties you encountered because of the design.

**The problem:** We want to model different parts of a robot, connect them in different ways as the robot evolve, and implement some features that act on all robot parts.

(Each part has a battery with a capacity (Kilo Apmere Hour or KAh) and an on/off status. A robot part can be connected with and control other part)

1. **left arm**
  - [x] Implement a robot left arm. 
The left arm accepts and executes a command in the form of a string. For the shake of this exercise, it's sufficient to implement just the "check" diagnostic command that writes, to the output console or to a log, the status of the arm in the form of this message: "Left are status check is ok."
  - [x] The left arm also has a max charge (in Ampere Hour or Ah) of its internal 24KV battery.
  - [x] Finally the left arm also has a current On/Off switch status.
2. **robot bus**
  - [x] the robot bus is electricity powered
  - [x] it has an On/Off status like the left arm
  - [x] the left arm is connected to the robot bus and when the robot bus receive a command, the command is sent to the left arm
3. TBD TBD TDB TBD TDB TBD TDB TBD TDB TBD TDB 
4. TBD TBD TDB TBD TDB TBD TDB TBD TDB TBD TDB 
5. TBD TBD TDB TBD TDB TBD TDB TBD TDB TBD TDB 
6. TBD TBD TDB TBD TDB TBD TDB TBD TDB TBD TDB 



## Exercise 2. Target design

...
