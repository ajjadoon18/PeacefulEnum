# PeacefulEnum
Peaceful Enum. Helper methods around C# enumerations for common use cases

# Install via nuget
```
Install-Package PeacefulEnum -Version 1.0.0
```
Package available at: https://www.nuget.org/packages/PeacefulEnum/

Github: https://github.com/ajjadoon18/PeacefulEnum

# Docs
- IsEnumValid

Validates that enum value is in valid range and not null
```
Mood mood = (Mood)300;
Assert.False(mood.IsEnumValid());
```

- IsEnumNullOrDefault

Checks if enum value is null or has a default value
```
Mood? mood = null;
Assert.True(mood.IsEnumNullOrDefault());

Mood mood = Mood.Bored;
Assert.True(mood.IsEnumNullOrDefault((int)Mood.Bored));

Mood mood = Mood.Peaceful;
Assert.False(mood.IsEnumNullOrDefault());

```
