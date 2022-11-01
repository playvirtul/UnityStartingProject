namespace CodeBase.Logic
{
    public class AnimatorState
    {
        public static AnimatorState Idle { get; }
        public static AnimatorState Attack { get; }
        public static AnimatorState Walking { get; }
        public static AnimatorState Died { get; }
        public static AnimatorState Unknown { get; }
    }
}