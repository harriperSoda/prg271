# C# Object-Oriented Programming Practice

## Object Instantiation & Memory Architecture

### Point 1 - Understanding the `Dog myDog = new Dog();` Statement

#### Type Declaration & Reference Variable
- **`Dog`**: Specifies the data type, connecting the variable to your class blueprint.
- **`myDog`**: Creates a reference variable (like a pointer or remote control) stored on the execution stack.

#### Dynamic Memory Allocation
- **`new`**: The keyword that commands the system to allocate a fresh block of memory.
- **Heap Allocation**: Reserves space on the managed heap to hold the physical object instance and its unique field values (`name`, `age`, `height`, and `weight`).

#### Constructor Execution
- **`Dog()`**: Triggers the class constructor behind the scenes to initialize the object and make it ready for execution.