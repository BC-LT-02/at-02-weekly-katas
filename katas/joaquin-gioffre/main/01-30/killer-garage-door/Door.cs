namespace KillerGarageDoor;

public class Door
{
    public int Position = 0;
    public string State = "closed"; 

    public void ChangeDoorPosition()
    {
        if (State == "opening" && Position < 5)
        {
            Position++;
        }
        else if (State == "closing" && Position > 0)
        {
            Position--;
        }
    }
}