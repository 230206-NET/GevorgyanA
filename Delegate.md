# Delegates


## Definition
    - A delegate is a type that represents references to methods with a particular parameter list and return type.
    - Delegates allow methods to be passed as parameters.
    - A Delegate is an abstraction of one or more function pointers.
    - When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. 
    - You can invoke (or call) the method through the delegate instance.

## Delegate declaration/signature
    [access modifier] delegate [return type] DelegateTypeName([parameters]);
    - Example
    public delegate int MyMethod(int x, int y);

    - Declaration of a method with the same signature as the delegate.

    public int Add(int x, int y) {
        return x+y;
    }

## Delegate Types
    - Single Cast (one method reference assined to delegate)
    - Multi Cast (more than one method references assined to delegate)

## Use cases
    - Events (Mouse click, keyboard input)
    - Delegates can be used to define callback methods