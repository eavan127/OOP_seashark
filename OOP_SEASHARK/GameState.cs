namespace OOP_SEASHARK
{
    /// <summary>
    /// Static singleton to share game progress state between forms.
    /// </summary>
    public static class GameState
    {
        /// <summary>True after the player successfully completes the Beginner level.</summary>
        public static bool BeginnerCompleted { get; set; } = false;

        /// <summary>Number of keys collected (Beginner awards 3; max is 6 after Advanced).</summary>
        public static int KeysCollected { get; set; } = 0;
    }
}
