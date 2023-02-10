namespace Week1;

public class RemoteControl
{
    public Door door = new Door();

    public bool obstacle = false; 

    public void PushButton(char character)
    {
        if(character == 'P')
        {
            CheckDoorState();
        }

        if(character == 'O')
        {
            door.State = "closing";
            obstacle = true;
        }
    }

    public void CheckDoorState()
    {
        if ((door.State == "closed" || door.State == "stopped") && obstacle == false)
        {
            door.State = "opening";
        }
        else if (door.State == "opening" || door.State == "closing")
        {
            door.State = "stopped";
        }
        else if (obstacle == true)
        {
            door.State = "closing";
        }
    }

    public string RunEvent(string newEvent)
    {
        string output = "";
        char[] characters = newEvent.ToCharArray();
        foreach(char character in characters)
        {
            PushButton(character);
            door.ChangeDoorPosition();
            output += door.Position.ToString();
        }

        return output;
    }
}