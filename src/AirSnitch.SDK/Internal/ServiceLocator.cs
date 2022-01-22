namespace AirSnitch.SDK.Internal
{
    internal class ServiceLocator
    {
        public static ISerializer GetSerializer()
        {
            return new NewtonSoftJsonSerializer();
        }
    }
}