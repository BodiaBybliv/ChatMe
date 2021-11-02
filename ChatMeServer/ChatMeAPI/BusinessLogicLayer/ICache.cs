using System;

namespace BusinessLogicLayer
{
    public interface ICache
    {
        object Get(object key);

        void Set(object key, object value, TimeSpan expireTime);

        bool Exists(object key);
    }
}
