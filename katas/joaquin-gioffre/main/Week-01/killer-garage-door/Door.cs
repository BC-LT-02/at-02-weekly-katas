namespace Week1;

public class Door
{
    public int Position = 0;
    public string State = "closed"; 
    public const int OPENED_POSITION = 5;
    public const int CLOSED_POSITION = 0;

    public void ChangeDoorPosition()
    {
        if (State == "opening" && Position < OPENED_POSITION)
        {
            Position++;
        }
        else if (State == "closing" && Position > CLOSED_POSITION)
        {
            Position--;
        }
    }
}