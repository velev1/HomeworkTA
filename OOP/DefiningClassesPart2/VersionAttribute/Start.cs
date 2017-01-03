namespace VersionAttribute
{
    using System;

    [Version(1, 0)]
    [Version(1, 1)]
    [Version(1, 2)]
    public class Start
    {
        static void Main()
        {
            Type type = typeof(Start);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in allAttributes)
            {
                Console.WriteLine(
                    "This version is {0} ",
                    versionAttribute.Full);
            }

        }
    }
}
