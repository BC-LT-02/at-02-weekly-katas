namespace KillerGarageDoorTest;

using KillerGarageDoor;

public class RemoteControlTest
{
    [Fact]
    public void ItShoudlUpdateTheCorrectStateOfTheDoor()
    {
        RemoteControl control = new RemoteControl();
        control.PushButton('.');
        control.PushButton('.');
        Assert.Equal("closed", control.door.State);
        control.PushButton('P');
        Assert.Equal("opening", control.door.State);
        control.PushButton('.');
        Assert.Equal("opening", control.door.State);
        control.PushButton('.');
        Assert.Equal("opening", control.door.State);
        control.PushButton('P');
        Assert.Equal("stopped", control.door.State);
        control.PushButton('.');
        Assert.Equal("stopped", control.door.State);
        control.PushButton('P');
        Assert.Equal("opening", control.door.State);
        control.PushButton('O');
        Assert.Equal("closing", control.door.State);
        control.PushButton('.');
        Assert.Equal("closing", control.door.State);
    }

    [Fact]
    public void ItShoudlUpdateTheCorrectPositionOfTheDoor()
    {
        RemoteControl control = new RemoteControl();
        control.PushButton('.');
        control.door.ChangeDoorPosition();
        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(0, control.door.Position);

        control.PushButton('P');
        control.door.ChangeDoorPosition();
        Assert.Equal(1, control.door.Position);

        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(2, control.door.Position);

        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(3, control.door.Position);

        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(4, control.door.Position);

        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(5, control.door.Position);

        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(5, control.door.Position);
        
        control.PushButton('P');
        control.door.ChangeDoorPosition();
        Assert.Equal(5, control.door.Position);

        control.PushButton('O');
        control.door.ChangeDoorPosition();
        Assert.Equal(4, control.door.Position);

        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(3, control.door.Position);

        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(2, control.door.Position);

        control.PushButton('P');
        control.door.ChangeDoorPosition();
        Assert.Equal(2, control.door.Position);

        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(2, control.door.Position);

        control.PushButton('P');
        control.door.ChangeDoorPosition();
        Assert.Equal(1, control.door.Position);

        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(0, control.door.Position);

        control.PushButton('.');
        control.door.ChangeDoorPosition();
        Assert.Equal(0, control.door.Position);
    }

    [Fact]
    public void ItShouldRunTheEvenAndReturnTheCorrectOu()
    {
        RemoteControl firstControl = new RemoteControl();
        Assert.Equal("12222", firstControl.RunEvent("P.P.."));

        RemoteControl secondControl = new RemoteControl();
        Assert.Equal("001234321000", secondControl.RunEvent("..P...O....."));

        RemoteControl thirdControl = new RemoteControl();
        Assert.Equal("122234555", thirdControl.RunEvent("P.P.P...."));

        RemoteControl fourthControl = new RemoteControl();
        Assert.Equal("1210000", fourthControl.RunEvent("P.O...."));

        RemoteControl fifthControl = new RemoteControl();
        Assert.Equal("1232222100", fifthControl.RunEvent("P..OP..P.."));
    }
}