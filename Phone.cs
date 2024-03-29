public abstract class Phone  // abstract method. This method will be implemented by the subclasses
{
    private string _versionNumber;
    private int _batteryPercentage;
    private string _carrier;
    private string _ringTone;
    public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
    {
        _versionNumber = versionNumber;
        _batteryPercentage = batteryPercentage;
        _carrier = carrier;
        _ringTone = ringTone;
    }

    public abstract void DisplayInfo();  // public getters and setters removed for brevity. Please implement them yourself
    public string VersionNumber 
    {
        get {return _versionNumber;} 
        set{_versionNumber=value;}
    }
    public int BatteryPercentage 
    {
        get {return _batteryPercentage;}
        set {_batteryPercentage=value;}    
    }
    public string Carrier 
    {
        get {return _carrier;}
        set {_carrier=value;}
    }
    public string RingTone 
    {   get {return _ringTone;}
        set {_ringTone=value;}
    }
    
}