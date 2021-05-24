using System;
using Xunit;
using kankicache;

namespace kankicache.tests
{
    public class KankiCacheTest
    {
        [Fact]
        public void HasValue_CheckReturnValue_IsFalseCheck()
        {
            string key = Guid.NewGuid().ToString();

            Assert.False(KankiCache.HasValue(key));
        }

        [Fact]
        public void HasValue_CheckReturnValue_IsTrueCheck()
        {
            string key = Guid.NewGuid().ToString();

            KankiCache.AddValue(key, "test");
            Assert.True(KankiCache.HasValue(key));
            KankiCache.RemoveValue(key);
        }

        [Fact]
        public void AddValue_CheckReturnValue_IsTrueCheck()
        {
            string key = Guid.NewGuid().ToString();

            Assert.True(KankiCache.AddValue(key, "test"));
            KankiCache.RemoveValue(key);
        }

        [Fact]
        public void AddValueWithExpiration_CheckReturnValue_IsTrueCheck()
        {
            string key = Guid.NewGuid().ToString();

            Assert.True(KankiCache.AddValueWithExpiration(key, "test", 1));
            KankiCache.RemoveValue(key);
        }

        [Fact]
        public void GetValue_CheckReturnValue_IsNullCheck()
        {
            string key = Guid.NewGuid().ToString();

            Assert.Null(KankiCache.GetValue(key));
        }

        [Fact]
        public void GetValue_CheckReturnValue_IsNotNullCheck()
        {
            string key = Guid.NewGuid().ToString();

            KankiCache.AddValue(key, "test");
            Assert.NotNull(KankiCache.GetValue(key));
            KankiCache.RemoveValue(key);
        }

        [Fact]
        public void RemoveValue_CheckReturnValue_IsTrueCheck()
        {
            string key = Guid.NewGuid().ToString();

            Assert.True(KankiCache.RemoveValue(key));
        }

        [Fact]
        public void RemoveValue_CheckReturnValue_IsTrueCheckForHasValue()
        {
            string key = Guid.NewGuid().ToString();

            KankiCache.AddValue(key, "test");
            Assert.True(KankiCache.RemoveValue(key));
        }
    }
}