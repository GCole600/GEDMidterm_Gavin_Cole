namespace Chapter.Command
{
    public class TurnLeft : global::Command.Command
    {
        private PlayerController _controller;

        public TurnLeft(PlayerController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(PlayerController.Direction.Left);
        }
    }
}