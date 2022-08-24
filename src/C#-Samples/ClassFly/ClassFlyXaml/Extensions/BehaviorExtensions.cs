namespace VijayAnand.Toolkit.Markup
{
    public static class BehaviorExtensions
    {
        public static TView AddBehavior<TView, TBindableObject>(this TView view, Behavior<TBindableObject> behavior)
            where TView : View
            where TBindableObject : BindableObject
        {
            view.Behaviors.Add(behavior);
            return view;
        }
    }
}
