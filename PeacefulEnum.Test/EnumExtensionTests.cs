using System;
using System.ComponentModel;
using Xunit;
namespace PeacefulEnum.Test
{
    public sealed class EnumExtensionTests
    {
        [Fact]
        public void IsEnumValidShouldReturnFalseWhenValueIsOutOfRange()
        {
            Mood mood = (Mood)300;
            Assert.False(mood.IsEnumValid());
        }

        [Fact]
        public void IsEnumValidShouldReturnTrueWhenValueIsInRange()
        {
            Mood mood = (Mood)1;
            Assert.True(mood.IsEnumValid());
        }

        [Fact]
        public void IsEnumValidShouldReturnFalseWhenValueIsNull()
        {
            Mood? mood = null;
            Assert.False(mood.IsEnumValid());
        }

        [Fact]
        public void IsEnumNullOrDefaultShouldReturnTrueWhenValueIsNull()
        {
            Mood? mood = null;
            Assert.True(mood.IsEnumNullOrDefault());
        }

        [Fact]
        public void IsEnumNullOrDefaultShouldReturnTrueWhenValueIsDefault()
        {
            Mood mood = Mood.Bored;
            Assert.True(mood.IsEnumNullOrDefault((int)Mood.Bored));
        }

        [Fact]
        public void IsEnumNullOrDefaultShouldReturnFalseWhenValueIsNotDefault()
        {
            Mood mood = Mood.Peaceful;
            Assert.False(mood.IsEnumNullOrDefault());
        }

        private enum Mood
        {
            Undefined = 0,
            [Description("Description of peacefull")]
            Peaceful = 1,
            Angry = 2,
            Happy = 3,
            Sad = 4,
            Bored = 5
        }
    }
}
