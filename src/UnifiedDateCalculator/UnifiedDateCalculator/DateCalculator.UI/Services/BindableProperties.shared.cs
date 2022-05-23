namespace DateCalculator.UI.Services
{
    public static class BindableProperties
    {
        public static void Register()
        {
            DefaultBindableProperties.RegisterForCommand(
                (EventToCommandBehavior.CommandProperty, EventToCommandBehavior.CommandParameterProperty)
            );
        }
    }
}
