# Fluent If-Then-Else

## IFluentIf

This interface should be implemented by whatever object to which you want to add Fluent IfElse. The `If()` method should take an if condition expression and simply return a new `FluentThen` object, passing the calling object and the if condition expression.

## FluentThen

This is what will be returned by the call to `If()` and represents the first logic block in an if statement. The only method on the `FluentThen` class is `Then()`, which takes an Action delegate that provides the then-statment activity. Subsequently, the method returns an instance of the `FluentElse` class.

## FluentElse

The `IFluentElse` interface exposes two methods, implemented by the `FluentElse` class.

### Else()

Represents an else block of an if-then-else statment, and takes an action as an argument, which provides the action to occur within this block. `Else()` returns an instance of the `FluentEndIf` class.

### EndIf()

Provides a way to end the if-then chain without providing an else statement. A call to the `EndIf` method here simply returns an instance of the `FluentEndIf` class.

## FluentEndIf

Contains only an `EndIf()` method, which can be called to return control to the calling object.

## Examples

### Without else statement

> `var foo = new Foo();`
>
> `foo.If( [some test is true] )`
>
> `.Then(() => [some resulting action if previous test is` _true_`] )`
>
> `.EndIf()`

### With else statement

> `var foo = new Foo();`
>
> `foo.If( [some test is true] )`
>
> `.Then(() => [some resulting action to perform when the if expression evaluates to` _true_`] )`
>
> `.Else(() => [some resulting action to perform when the if expression evaluates to` _false_`] )`
>
> `.EndIf()`

## Tasks

The code is set up with tasks you can run from VS Code. The tasks have been made for use with Visual Studio Code just because that's the editor I used to develop. The tasks are simply meant to help simplify the development process; if you're just using the extensions as a user, you won't really care about them.

### How to use them

> `Ctrl + Shift + P` (or `Ctrl + P ->` followed by pressing `>`)
>
> Then type `Tasks: Run Task`
>
> The tasks should appear in a dropdown box and it's pretty straightforward from there!

### Summary of the tasks available

| Task  | Description                                                  |
| :---- | :----------------------------------------------------------- |
| Build | Silently builds and nothing more.                            |
| Clear | Removes bin and obj folders without building them afterward. |
