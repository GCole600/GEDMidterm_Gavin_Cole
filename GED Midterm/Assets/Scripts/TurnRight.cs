namespace Chapter.Command
{
    public class TurnRight : global::Command.Command
    {
        private PlayerController _controller;

        public TurnRight(PlayerController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(PlayerController.Direction.Right);
        }
    }
}