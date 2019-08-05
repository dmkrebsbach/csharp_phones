public class Galaxy : Phone, IRingable // Class Phone, Children - Galaxy, Interface (IRingable)
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) 
        {
            // we would include here any members that are unique to Galaxy phones were there any
        }
    public string Ring() // from IRingable.cs File
    {
        return $"... { RingTone } ...";
    }
    public string Unlock() // from IRingable.cs File
    {
        return $"Galaxy { VersionNumber } unlocked with Fingerprint Scanner";
    }
    public override void DisplayInfo() // called on Program.cs file
    {
        System.Console.WriteLine("#####PHONE DISPLAY INFO#####");
        System.Console.WriteLine($"Galaxy { VersionNumber }");
        System.Console.WriteLine($"Battery Percentage: { BatteryPercentage }");
        System.Console.WriteLine($"Carrier: { Carrier }");
        System.Console.WriteLine($"Ring Tone: {RingTone}");
        System.Console.WriteLine("############################");
        System.Console.WriteLine("");
    }
}