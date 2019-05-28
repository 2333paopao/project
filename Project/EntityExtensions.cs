using System;

namespace Project
{
    public static class EntityExtensions
    {
        public static void ForceId(this Entity entity, Guid id)
        {
            PrivateAccess.SetPrivate(entity, "Id", id);
        }
    }
}
