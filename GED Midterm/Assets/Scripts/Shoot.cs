namespace Chapter.Command
{
    public class Shoot : global::Command.Command
    {
        private PlayerController _controller;

        public Shoot(PlayerController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.PlayerShoot();
        }
    }
}