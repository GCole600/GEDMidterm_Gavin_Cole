namespace Chapter.Command
{
    public class TurnUp : global::Command.Command
    {
        private PlayerController _controller;

        public TurnUp(PlayerController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(PlayerController.Direction.Up);
        }
    }
}