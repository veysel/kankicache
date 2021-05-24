using System;
using System.Runtime.Caching;

namespace kankicache
{
    public static class KankiCache
    {
        private static MemoryCache cache = new MemoryCache("kanki-cache");

        public static bool HasValue(string key)
        {
            return cache.Contains(key);
        }

        public static bool AddValue(string key, object value)
        {
            cache.Set(new CacheItem(key, value), new CacheItemPolicy() { SlidingExpiration = TimeSpan.FromHours(1) });
            return true;
        }

        public static bool AddValueWithExpiration(string key, object value, int expirationMinute)
        {
            cache.Set(new CacheItem(key, value), new CacheItemPolicy() { SlidingExpiration = TimeSpan.FromMinutes(expirationMinute) });
            return true;
        }

        public static object GetValue(string key)
        {
            return cache.Get(key);
        }

        public static bool RemoveValue(string key)
        {
            cache.Remove(key);
            return true;
        }
    }
}