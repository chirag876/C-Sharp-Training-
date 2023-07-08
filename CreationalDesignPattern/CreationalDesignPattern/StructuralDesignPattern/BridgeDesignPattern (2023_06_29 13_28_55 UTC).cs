using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bridge design pattern decouple an abstraction from its implementation so that the two can vary independently
//This pattern is used to separate an abstraction from its implementation so that both can be modified independently
//This pattern involves an interface which acts as a bridge between the abstraction class and implementer class.
//With bridge pattern both types of classes can be modified without affecting to each other.
//In this we hide the implementation of an abstraction completely from clients.
//We can share an implementation among multiple objects
//Both abstraction and implementation should be extensible.
//We avoid permanent binding between an abstraction and its implementation.
public interface ILEDTV
{
    void SwitchOn();
    void SwitchOff();
    void SetChannel(int channelNumber);
}

public class SamsungLedTv : ILEDTV
{
    public void SwitchOn()
    {
        Console.WriteLine("Turning ON : Samsung TV");
    }
    public void SwitchOff()
    {
        Console.WriteLine("Turning OFF : Samsung TV");
    }
    public void SetChannel(int channelNumber)
    {
        Console.WriteLine("Setting channel Number " + channelNumber + " on Samsung TV");
    }
}

public class SonyLedTv : ILEDTV
{
    public void SwitchOn()
    {
        Console.WriteLine("Turning ON : Sony TV");
    }
    public void SwitchOff()
    {
        Console.WriteLine("Turning OFF : Sony TV");
    }
    public void SetChannel(int channelNumber)
    {
        Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
    }
}

public abstract class AbstractRemoteControl
{
    protected ILEDTV ledTv;//protected variable ledTv which is going to be available to subclasses.
    protected AbstractRemoteControl(ILEDTV ledTv) 
    {
        this.ledTv = ledTv;
    }
    public abstract void SwitchOn();
    public abstract void SwitchOff();
    public abstract void SetChannel(int channelNumber);
}

public class SamsungRemoteControl : AbstractRemoteControl
{
    public SamsungRemoteControl(ILEDTV ledTv) : base(ledTv)
    {
    }

    public override void SwitchOn()
    {
        ledTv.SwitchOn();
    }
    public override void SwitchOff()
    {
        ledTv.SwitchOff();
    }
    public override void SetChannel(int channelNumber)
    {
        ledTv.SetChannel(channelNumber);
    }
}

public class SonyRemoteControl : AbstractRemoteControl
{
    public SonyRemoteControl(ILEDTV ledTv) : base(ledTv)
    {
    }
    public override void SwitchOn()
    {
        ledTv.SwitchOn();
    }
    public override void SwitchOff()
    {
        ledTv.SwitchOff();
    }
    public override void SetChannel(int channelNumber)
    {
        ledTv.SetChannel(channelNumber);
    }
}