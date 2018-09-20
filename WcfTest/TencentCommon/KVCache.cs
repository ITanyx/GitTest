using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TencentCommon
{
    public class KVCache<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _cache;
        private readonly ReaderWriterLock _rwLock;
        protected Dictionary<TKey, TValue> Cache
        {
            get
            {
                return this._cache;
            }
        }
        public KVCache() : this(null)
        {
        }
        public KVCache(IEqualityComparer<TKey> comparer)
        {
            this._rwLock = new ReaderWriterLock();
            this._cache = new Dictionary<TKey, TValue>(comparer);
        }
        public TValue TryCreateCacheItem(TKey key, Func<TValue> creator)
        {
            this._rwLock.AcquireReaderLock(-1);
            try
            {
                TValue tValue;
                if (this._cache.TryGetValue(key, out tValue))
                {
                    TValue result = tValue;
                    return result;
                }
            }
            finally
            {
                this._rwLock.ReleaseReaderLock();
            }
            TValue value = creator();
            this._rwLock.AcquireWriterLock(-1);
            try
            {
                TValue tValue;
                if (this._cache.TryGetValue(key, out tValue))
                {
                    TValue result = tValue;
                    return result;
                }
                this._cache.Add(key, value);
            }
            finally
            {
                this._rwLock.ReleaseWriterLock();
            }
            return this._cache[key];
        }
        public TValue TryUpdateCacheItem(TKey key, Func<TValue> creator)
        {
            this._rwLock.AcquireReaderLock(-1);
            TValue result;
            try
            {
                if (this._cache.ContainsKey(key))
                {
                    this._cache[key] = creator();
                }
                else
                {
                    this._cache.Add(key, creator());
                }
                result = this._cache[key];
            }
            finally
            {
                this._rwLock.ReleaseReaderLock();
            }
            return result;
        }
        public bool TryGetCacheItem(TKey key, out TValue val)
        {
            this._rwLock.AcquireReaderLock(-1);
            bool result;
            try
            {
                result = this._cache.TryGetValue(key, out val);
            }
            finally
            {
                this._rwLock.ReleaseReaderLock();
            }
            return result;
        }
    }
}
