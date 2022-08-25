namespace MauiFocus
{
    public partial class AppColors : ResourceDictionary
    {
        public AppColors()
        {
            Add("Primary", Color.FromArgb("#512BD4"));
            Add("Light", Color.FromArgb("#DFD8F7"));
            Add("Dark", Color.FromArgb("#2B0B98"));
            Add("White", White);
            Add("Black", Black);
            Add("LightGray", Color.FromArgb("#E5E5E1"));
            Add("MidGray", Color.FromArgb("#969696"));
            Add("DarkGray", Color.FromArgb("#505050"));
            Add("PrimaryBrush", new SolidColorBrush((Color)this["Primary"]));
            Add("LightBrush", new SolidColorBrush((Color)this["Light"]));
            Add("DarkBrush", new SolidColorBrush((Color)this["Dark"]));
            Add("WhiteBrush", new SolidColorBrush((Color)this["White"]));
            Add("BlackBrush", new SolidColorBrush((Color)this["Black"]));
            Add("LightGrayBrush", new SolidColorBrush((Color)this["LightGray"]));
            Add("MidGrayBrush", new SolidColorBrush((Color)this["MidGray"]));
            Add("DarkGrayBrush", new SolidColorBrush((Color)this["DarkGray"]));
            Add("Yellow100Accent", Color.FromArgb("#F7B548"));
            Add("Yellow200Accent", Color.FromArgb("#FFD590"));
            Add("Yellow300Accent", Color.FromArgb("#FFE5B9"));
            Add("Cyan100Accent", Color.FromArgb("#28C2D1"));
            Add("Cyan200Accent", Color.FromArgb("#7BDDEF"));
            Add("Cyan300Accent", Color.FromArgb("#C3F2F4"));
            Add("Blue100Accent", Color.FromArgb("#3E8EED"));
            Add("Blue200Accent", Color.FromArgb("#72ACF1"));
            Add("Blue300Accent", Color.FromArgb("#A7CBF6"));
        }
    }
}

