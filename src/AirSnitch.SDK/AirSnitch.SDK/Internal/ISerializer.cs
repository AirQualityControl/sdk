namespace AirSnitch.SDK.Internal
{
    internal interface ISerializer
    {
        string Serialize(object target);
    }
}