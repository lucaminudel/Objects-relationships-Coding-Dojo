# Objects relationships - Coding-Dojo

This repository contains two coding exercises, to be finished in sequence.

**The goal** of these exercises is to experience the impact of composition and other design techniques to encapsulate objects relationships (in exercise 2), and compare that with simplistic design approach (from exercise 1). The goal is reached solving in sequence exercise 1 and 2, and then comparing how easy or how difficult it was to add each new feature on both settings.

**Timing:** exercise 1 takes about 2 hours, and exercise 2 takes about 1 and half hours.


**Prerequisites:**
- Practical understanding of basic design principles, SOLID principles and Simple Design
- Experience with fundamental refactoring and design patterns of unit testing as in coding-dojo [Refactoring legacy code driven by tests] (https://github.com/lucaminudel/TDDwithMockObjectsAndDesignPrinciples/blob/master/TDDMicroExercises/README.md)

## Exercise 1. Simplistic design

The goal of this exercise is to experience the impact of simplistic design when adding new features.
In order to keep the design simplistic, 
- create direct dependencies between objects. I.e. for A -> B, concrete class A will instantiate and reference directly concrete class B instead of using interfaces or other abstractions or dependency inversions techniques;
- each feature that requires computations on the whole object graph, should be implemented in a single method that navigates the graph and computes the operation instead of introducing abstractions such as composite design pattern, visitor pattern, or any other abstraction.

The list below contains all the feature requests to be implemented. Implement one feature request at a time, without anticipating the following ones. Every feature request should only take few minutes to implement.

**The problem:** We want to model different parts of a robot, connect them in different ways as the robot evolve, and implement some features that act on the whole object graph of robot parts.

1. **Left arm**
  - [x] Implement a robot left arm. 
  - [x] The left arm has a max charge (in Ampere Hour or Ah) of its internal 24KV battery.
  - [x] Finally the left arm also has a current On/Off switch status.
  - [ ] FYI left arm and each other robot parts impements many complex commands specific to that part, their implementation is omitted in this exercise.
2. **Robot bus**
  - [x] the robot bus is electricity powered, so it doesn't have a battery and its max charge value.
  - [x] it has an On/Off status like the left arm.
  - [x] the left arm is connected to the robot bus.
  - [ ] FYI When the robot bus receive a command, the command is sent to the left arm and every other robot parts connected to the bus. The commands transmission implementation is also omitted in this exercise.
3. **Right foot**
  - [x] like the left arm. it has an On/Off switch status and the max charge of the internal battery.
  - [x] the right foot is connected to the robot bus too.
4. **Dashboard**
  - [x] implement a function/method that navigates all the robot parts starting from robot bus, and reports the On/Off status of all robot parts, including the robot bus status. Report should have one line per robot part, and should use identation to visualise the tree structure, see an example [here](https://en.wikipedia.org/wiki/Tree_structure#Outlines_and_tree_views).
  - [x] implement a function/method that navigates all the robot parts starting from robot bus, and calculates the total cost to re-charge all the internal batteries; the cost per 1000 Ah is £0.2.
5. **Right thigh**
  - [x] add a right thigh and connect it to the robot bus. It also has the On/Off status, and a max charge.
  - [x] update the two dashboard reports accordingly.
  - [ ] take notes of the classes that had to change to add this part. What do you think of this coupling? 
6. **Right lower limb**
  - [x] add a right lower limb and connect it to the robot bus. It also has the On/Off status, and a max charge.
  - [x] update the two dashboard reports accordingly.
  - [ ] take notes of the classes that had to change to add this part. What do you think of this coupling? 
7. **Hip**
  - [x] add a hip and connect it to the robot bus. Hip itself has On/Off status and max charge.
  - [x] connect the thigh, the lower limb and the foot to the hip. Update On/Off status report and add indentation to visually represent the tree structure.
  - [ ] take notes of the classes that had to change. What do you think of this coupling? 
  - [ ] have you noticed the appearance of method call chains (aka train wreck)?
8. **Shoulder**
  - [x] add a shoulder part and connect it to the robot bus. Shoulder part has On/Off status and max charge.
  - [x] connect the left arm to shoulder part. Use again indentation in the updated On/Off status report. 
  - [ ] take again notes of the classes that had to change. What do you think of this coupling? 
  - [ ] have you noticed the appearance of more method call chains?
9. **Trunk**
  - [x] rename robot bus to trunk.
10. **Right leg parts**
  - [x] connect right lower limb to the right thigh and the right foot to the right lower limb. Ensure report indentation reflects the new structure.
  - [ ] take again notes of the classes that had to change.
  - [ ] more method call chains?
11. **Left arm part On/Off status format change**
  - [x] if you are using boolean as current representation, change it for the left arm to enum, constants or flags. Or the other way round.
  - [ ] take again notes of the classes that had to change. What do you think of this other coupling? 


## Exercise 2. Target design


The goal of this exercise is to experience a different design that reduces the impact of changes to the object graph and the related objects. In order to use a different design,
- invert the dependencies from the dashboard functions (On/Off status report and total cost to re-charge all the internal batteries) to the robot parts so that the robot parts have a dependency to the dashboard and not the opposite;
- use a common interface and, if needed, the adapter pattern to abstract away differences between different robot parts;
- pass the dashboard object to the robot parts as a visitor in the visitor pattern; let each robot part take care of passing the dashboard to the other directly contained/referenced robot parts,so that the responsibility of navigating the object graph moves from the dashboard functions/methods into each robot part.

As for the previous exercise, the list below contains all the feature requests to be implemented. Implement one feature request at a time, without anticipating the following ones. Every feature request should only take few minutes to implement.

**The problem:** We want to model different parts of a robot, compose them in different ways as the robot evolve, and have some features carried out by the composite of robot parts.

1. **Left arm**
  - [x] Implement a robot left arm. 
  - [x] The left arm has a max charge (in Ampere Hour or Ah) of its internal 24KV battery. No need to expose this as public getter.
  - [x] Finally the left arm also has a current On/Off switch status.  No need to expose this as public getter.
  - [ ] FYI left arm and each other robot parts impements many complex commands specific to that part, their implementation is omitted in this exercise.
2. **Robot bus**
  - [x] the robot bus is electricity powered, so it doesn't have a battery and its max charge value.
  - [x] it has an On/Off status like the left arm.
  - [x] the left arm is connected to the robot bus. No need to expose this as public getter. Use dependency injection in the robot bus constructor to get reference to the left arm. Continue to do the same for the other robot parts in the following step.
  - [ ] FYI When the robot bus receive a command, the command is sent to the left arm  and every other robot parts connected to the bus. The commands transmission implementation is also omitted in this exercise.
3. **Right foot**
  - [x] like the left arm. it has an On/Off switch status and the max charge of the internal battery.
  - [x] the right foot is connected to the robot bus too.
  - [ ] you can introduce abstractions to abstract away differences between robot parts, and group them into a collection of  uniform items.
4. **Dashboard**
  - [x] implement a function/method that navigates all the robot parts starting from robot bus, and reports the On/Off status of all robot parts, including the robot bus status. Report should have one line per robot part, and should use identation to visualise the tree structure, see an example [here](https://en.wikipedia.org/wiki/Tree_structure#Outlines_and_tree_views).
  - [x] implement a function/method that navigates all the robot parts starting from robot bus, and calculates the total cost to re-charge all the internal batteries; the cost per 1000 Ah is £0.2.
  - [ ] use the visitor pattern and pass around the dashboard object.
  - [ ] does the collection of robot parts help?
5. **Right thigh**
  - [x] add a right thigh and connect it to the robot bus. It also has the On/Off status, and a max charge.
  - [x] update the two dashboard reports accordingly.
  - [ ] take notes of the classes that had to change to add this part. Is it different from exercise 1? 
  - [ ] does the collection of robot parts help?
6. **Right lower limb**
  - [x] add a right lower limb and connect it to the robot bus. It also has the On/Off status, and a max charge.
  - [x] update the two dashboard reports accordingly.
  - [ ] take notes of the classes that had to change to add this part. Is it different from exercise 1? 
  - [ ] does the collection of robot parts help?
7. **Hip**
  - [x] add a hip and connect it to the robot bus. Hip itself has On/Off status and max charge.
  - [x] connect the thigh, the lower limb and the foot to the hip. Update On/Off status report and add indentation to visually represent the tree structure.
  - [ ] take notes of the classes that had to change. Is it different from exercise 1? In which way?
  - [ ] have you noticed any appearance of method call chains (aka train wreck) at all?
8. **Shoulder**
  - [x] add a shoulder part and connect it to the robot bus. Shoulder part has On/Off status and max charge.
  - [x] connect the left arm to shoulder part. Use again indentation in the updated On/Off status report. 
  - [ ] take again notes of the classes that had to change. Which differences do you notice from exercise 1? 
  - [ ] any appearance of method call chains (aka train wreck) ?
9. **Trunk**
  - [x] rename robot bus to trunk.
10. **Right leg parts**
  - [x] connect right lower limb to the right thigh and the right foot to the right lower limb. Ensure report indentation reflects the new structure.
  - [ ] notes again whic classes that had to change compared to exercise 1.
  - [ ] any method call chains?
11. **Left arm On/Off status format change**
  - [x] if you are using boolean as current representation, change it for the left arm to enum, constants or flags. Or the other way round.
  - [ ] what classes that had to change compared to exercise 1? 

## Post exercises reflections

- **The composition design style** used in the 2nd exercise, encapsulates the knowledge and navigation of the object graph into the composite objects. As result, when there are changes at object graph, as for feature requests #7 #8 and #10, changes required are confined to the objects directly involved and do not escalate to the rest of the object graph or to the dashboard functions navigating the graph
- **The inversion of the dependency** used in the 2nd exercise, from the unstable objects more likely to change (the robot parts) to the more stable objects (the dashboard) limits the impact of changes that don’t impact the dashboard object, as for feature request #11
- **Interfaces and adapter pattern** used in the 2nd exercise, abstract away differences between the robot parts and so they make it possible to compose objects in different ways, and they make it easier to work with a collection of robot parts.
- **Better encapsulation without property getters** that can be avoided in the 2nd exercise for the On/Off status, the max charge and the relationship because the composite design style encapsulate the object relationships of the graph and the visitor pattern encapsulate the reporting responsibility, so that they don't need to be accessed by the external functions of the dashboard.


This post shows in a very clear and visual way the concept of programming by composition that is used the 2nd exercise: http://blog.davidpeterson.co.uk/2011/01/object-oriented-example.html

The key concept of the exercises are based on this post that should help you to connect the dots, and explain way the design of the 2nd exercise made it easier for you to implement some of the feature changes: http://blogs.ugidotnet.org/luKa/archive/2015/01/20/overcoming-the-one-weakness-of-oop.aspx
