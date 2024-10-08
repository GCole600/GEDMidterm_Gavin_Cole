namespace Chapter.Command
{
    public class TurnDown : global::Command.Command
    {
        private PlayerController _controller;

        public TurnDown(PlayerController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(PlayerController.Direction.Down);
        }
    }
}