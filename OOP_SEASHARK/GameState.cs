namespace OOP_GroupProject
{
    // This class helps us keep track of how the player is doing across different screens
    public static class GameState
    {
        // This variable checks whether the Beginner Level is completed
        // Set this to true once the player complete the first level
        // Default value is false, so Advanced Level is locked initially
        public static bool BeginnerCompleted { get; set; } = false;

        // This variable stores the number of keys collected by the player
        // Keys are collected when the player answers quiz questions correctly
        public static int KeysCollected { get; set; } = 0;
    }

}
