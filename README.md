# LSystemGenerator
A Library for generating instructions easily from a list of given rules.
```
Example: Dragons Curve ->

string instuctions = LSystemGenerator.LSystem.Generate("f", 15, new Dictionary<string, string> { 
    { "f", "f+g" },
    { "g", "f-g" },
    { "-", "-" },
    { "+", "+" }
});

```
