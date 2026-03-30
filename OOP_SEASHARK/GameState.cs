namespace OOP_GroupProject
{
    // This class helps us keep track of how the player is doing across different screens
    public static class GameState
    {
        // We set this to true once the player clears the first level
        public static bool BeginnerCompleted { get; set; } = false;

        // Keeps a count of how many keys the player has managed to grab
        public static int KeysCollected { get; set; } = 0;
    }

}
