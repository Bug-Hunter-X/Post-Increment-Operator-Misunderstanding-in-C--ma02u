# C# Post-Increment Operator Bug

This example highlights a potential source of confusion for developers unfamiliar with the nuances of the post-increment operator (`++`) in C#.

The `MyMethod` function demonstrates how the post-increment operator (`++`) increments the value of `MyProperty` *after* its value has been assigned to the variable `x`.  This can lead to unexpected results if the developer anticipates the incremented value to be assigned to `x`.

The solution provides a corrected approach to achieve the intended behavior.