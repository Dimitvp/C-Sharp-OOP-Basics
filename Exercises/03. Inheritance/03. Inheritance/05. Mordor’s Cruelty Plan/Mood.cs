class Mood
{
    private string moodLevel;

    public Mood(int points)
    {
        this.Points = points;
    }

    public int Points
    {
        set
        {
            //Angry - below - 5 points of happiness;
            //Sad - from - 5 to 0 points of happiness;
            //Happy - from 0 to 15 points of happiness;
            //JavaScript - when happiness points are more than 15;

            if (value < -5)
            {
                moodLevel = "Angry";
            }
            else if (value >= -5 && value < 0)
            {
                moodLevel = "Sad";
            }
            else if (value >= 0 && value < 15)
            {
                moodLevel = "Happy";
            }
            else
            {
                moodLevel = "JavaScript";
            }

        }
    }

    public override string ToString()
    {
        return moodLevel;
    }
}