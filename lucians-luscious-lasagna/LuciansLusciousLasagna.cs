class Lasagna
{
	// TODO: define the 'ExpectedMinutesInOven()' method
	public int ExpectedMinutesInOven()
	{
		return 40;
	}

	// TODO: define the 'RemainingMinutesInOven()' method
	public int RemainingMinutesInOven(int minutesInOven)
	{
		return this.ExpectedMinutesInOven() - minutesInOven;
	}

	// TODO: define the 'PreparationTimeInMinutes()' method
	public int PreparationTimeInMinutes(int numberOfLayers)
	{
		return numberOfLayers * 2;
	}

	// TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberofLayers, int minutesInOven)
    {
        return this.PreparationTimeInMinutes(numberofLayers) + minutesInOven;
    }
}
