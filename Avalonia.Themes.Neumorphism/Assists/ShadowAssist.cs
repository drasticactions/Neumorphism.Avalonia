using System;
using System.Globalization;
using System.Threading;
using Anim = Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;

namespace Avalonia.Themes.Neumorphism.Assist
{
    public static class ShadowProvider
    {
        // The dark half of the neumorphic shadow pair. Kept public for back-compat /
        // per-element overrides (e.g. ShadowAssist.Darken passes an opaque black).
        public static Color MaterialShadowColor { get; set; } = Color.FromArgb(0x33, 0, 0, 0);

        // The light half — a soft top-left highlight. Correct on both light and dark
        // surfaces (a white highlight + dark shadow is the neumorphic dual-light look).
        public static Color NeumorphicHighlightColor { get; set; } = Color.FromArgb(0xCC, 255, 255, 255);

        /// <summary>
        /// Maps a depth step to a neumorphic dual shadow: a light highlight offset to the
        /// top-left and a dark shadow offset to the bottom-right (no longer a single
        /// Material drop-shadow). Higher depths use larger offset/blur.
        /// </summary>
        public static BoxShadows ToBoxShadows(this ShadowDepth shadowDepth, Color? overrideColor = null)
        {
            var (offset, blur) = shadowDepth switch
            {
                ShadowDepth.Depth0 => (0d, 0d),
                ShadowDepth.Depth1 => (2d, 4d),
                ShadowDepth.Depth2 => (3d, 6d),
                ShadowDepth.Depth3 => (5d, 10d),
                ShadowDepth.Depth4 => (8d, 16d),
                ShadowDepth.Depth5 => (12d, 24d),
                ShadowDepth.CenterDepth1 => (2d, 4d),
                ShadowDepth.CenterDepth2 => (3d, 6d),
                ShadowDepth.CenterDepth3 => (5d, 10d),
                ShadowDepth.CenterDepth4 => (8d, 16d),
                ShadowDepth.CenterDepth5 => (12d, 24d),
                _ => throw new ArgumentOutOfRangeException()
            };

            if (offset == 0d && blur == 0d)
                return new BoxShadows(new BoxShadow());

            var highlight = new BoxShadow
            { OffsetX = -offset, OffsetY = -offset, Blur = blur, Color = NeumorphicHighlightColor };
            var shadow = new BoxShadow
            { OffsetX = offset, OffsetY = offset, Blur = blur, Color = overrideColor ?? MaterialShadowColor };

            return new BoxShadows(highlight, new[] { shadow });
        }
    }

    public enum ShadowDepth
    {
        Depth0,
        Depth1,
        Depth2,
        Depth3,
        Depth4,
        Depth5,
        CenterDepth1,
        CenterDepth2,
        CenterDepth3,
        CenterDepth4,
        CenterDepth5
    }

    public static class ShadowAssist
    {
        public static readonly AvaloniaProperty<ShadowDepth> ShadowDepthProperty =
            AvaloniaProperty.RegisterAttached<AvaloniaObject, ShadowDepth>(
                "ShadowDepth", typeof(ShadowAssist));

        public static readonly AvaloniaProperty<bool> DarkenProperty =
            AvaloniaProperty.RegisterAttached<AvaloniaObject, bool>(
                "Darken", typeof(ShadowAssist));

        static ShadowAssist()
        {
            ShadowDepthProperty.Changed.Subscribe(ShadowDepthChangedCallback);
            DarkenProperty.Changed.Subscribe(DarkenPropertyChangedCallback);
        }

        private static void ShadowDepthChangedCallback(AvaloniaPropertyChangedEventArgs args)
        {
            if (args.Sender is Border border)
                border.BoxShadow =
                    (args.NewValue as ShadowDepth? ?? ShadowDepth.Depth0)
                    .ToBoxShadows();
        }

        public static void SetShadowDepth(AvaloniaObject element, ShadowDepth value)
            => element.SetValue(ShadowDepthProperty, value);

        public static ShadowDepth GetShadowDepth(AvaloniaObject element)
            => element.GetValue<ShadowDepth>(ShadowDepthProperty);

        private static void DarkenPropertyChangedCallback(AvaloniaPropertyChangedEventArgs obj)
        {
            if (obj.Sender is not Border border)
                return;

            var boxShadow = border.BoxShadow;

            var targetBoxShadows = (bool?)obj.NewValue == true
                ? GetShadowDepth(border).ToBoxShadows(Color.FromArgb(255, 0, 0, 0))
                : GetShadowDepth(border).ToBoxShadows();

            if (!border.Classes.Contains("no-transitions"))
            {
                var animation = new Anim.Animation { Duration = TimeSpan.FromMilliseconds(350), FillMode = Anim.FillMode.Both };
                animation.Children.Add(
                    new Anim.KeyFrame
                    {
                        Cue = Anim.Cue.Parse("0%", CultureInfo.CurrentCulture),
                        Setters =
                        {
                            new Setter
                            {
                                Property = Border.BoxShadowProperty,
                                Value = boxShadow
                            }
                        }
                    });
                animation.Children.Add(
                    new Anim.KeyFrame
                    {
                        Cue = Anim.Cue.Parse("100%", CultureInfo.CurrentCulture),
                        Setters =
                        {
                            new Setter
                            {
                                Property = Border.BoxShadowProperty,
                                Value = targetBoxShadows
                            }
                        }
                    });
                animation.RunAsync(border, CancellationToken.None);
            }
            else
            {
                border.SetValue(Border.BoxShadowProperty, targetBoxShadows);
            }
        }

        public static void SetDarken(AvaloniaObject element, bool value)
            => element.SetValue(DarkenProperty, value);

        public static bool GetDarken(AvaloniaObject element)
            => element.GetValue<bool>(DarkenProperty);
    }
}