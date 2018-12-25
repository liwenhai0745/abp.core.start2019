using System;

namespace abp.core.start2019.Permissions
{
    public static class start2019Permissions
    {
        public const string GroupName = "start2019";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static string[] GetAll()
        {
            //Return an array of all permissions
            return Array.Empty<string>();
        }
    }
}