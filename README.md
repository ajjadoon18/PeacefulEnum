# PeacefulEnum
Peaceful Enum. Helper methods around C# enumerations for common use cases

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
