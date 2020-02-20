using System;
using System.ComponentModel;
using Xunit;
namespace PeacefulEnum.Test
{
    public sealed class EnumExtensionTests
    {
        [Fact]
        public void IsValidShouldReturnFalseWhenValueIsOutOfRange()
        {
            Mood mood = (Mood)300;
            Assert.False(mood.IsValid());
        }

        [Fact]
        public void IsValidShouldReturnTrueWhenValueIsInRange()
        {
            Mood mood = (Mood)1;
            Assert.True(mood.IsValid());
        }

        [Fact]
        public void IsValidShouldReturnFalseWhenValueIsNull()
        {
            Mood? mood = null;
            Assert.False(mood.IsValid());
        }

        [Fact]
        public void IsNullOrDefaultShouldReturnTrueWhenValueIsNull()
        {
            Mood? mood = null;
            Assert.True(mood.IsNullOrDefault());
        }

        [Fact]
        public void IsNullOrDefaultShouldReturnTrueWhenValueIsDefault()
        {
            Mood mood = Mood.Bored;
            Assert.True(mood.IsNullOrDefault((int)Mood.Bored));
        }

        [Fact]
        public void IsNullOrDefaultShouldReturnFalseWhenValueIsNotDefault()
        {
            Mood mood = Mood.Peaceful;
            Assert.False(mood.IsNullOrDefault());
        }

        [Fact]
        public void WhenEnumIsnullDescriptionShouldBeEmpty()
        {
            Mood? mood = null ;
            Assert.Equal(string.Empty, mood.Description());
        }

        [Fact]
        public void WhenEnumHasDescriptionTagThenDescriptionShouldBeReturned()
        {
            Mood mood = Mood.Peaceful;
            Assert.Equal("Description of peaceful", mood.Description());
        }

        [Fact]
        public void WhenEnumHasNoDescriptionTagThenDescriptionReturnsEmptyString()
        {
            Mood mood = Mood.Happy;
            Assert.Equal(string.Empty, mood.Description());
        }

        private enum Mood
        {
            Undefined = 0,
            [Description("Description of peaceful")]
            Peaceful = 1,
            Angry = 2,
            Happy = 3,
            Sad = 4,
            Bored = 5
        }
    }
}
