using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Styling;
using Avalonia.Themes.Neumorphism.Colors.ColorManipulation;
using Avalonia.Themes.Neumorphism.Enums;

namespace Avalonia.Themes.Neumorphism
{
    /// <summary>
    /// Includes the Neumorphism theme in an application.
    /// </summary>
    public class NeumorphismTheme : Styles
    {
        // Muted, low-saturation seeds suit the soft-UI look. Consumers can override
        // with any colour; the light/mid/dark hue brushes are derived from the seed.
        private static readonly Color DefaultAccentColor = Color.FromRgb(0x6C, 0x7A, 0x89);
        private static readonly Color DefaultSecondaryAccent = Color.FromRgb(0xB0, 0x85, 0x7B);

        /// <summary>
        /// Initializes a new instance of the <see cref="NeumorphismTheme"/> class.
        /// </summary>
        /// <param name="sp">The parent's service provider.</param>
        public NeumorphismTheme(IServiceProvider sp = null)
        {
            AvaloniaXamlLoader.Load(sp, this);

            // Seed the hue brushes from the default accents so the theme renders even
            // when a consumer never sets AccentColor/SecondaryAccent explicitly (those
            // assignments would otherwise be the only thing that creates the brushes).
            ApplyAccent(AccentColor);
            ApplySecondaryAccent(SecondaryAccent);
        }



        public static readonly StyledProperty<ApplicationTheme> BaseThemeProperty
            = AvaloniaProperty.Register<NeumorphismTheme, ApplicationTheme>(nameof(BaseTheme));

        public ApplicationTheme BaseTheme
        {
            get => GetValue(BaseThemeProperty);
            set => SetValue(BaseThemeProperty, value);
        }


        public static readonly StyledProperty<Color> AccentColorProperty =
            AvaloniaProperty.Register<NeumorphismTheme, Color>(nameof(AccentColor), DefaultAccentColor);

        /// <summary>
        /// Gets or sets the primary accent colour. The light/mid/dark primary hue brushes
        /// are derived from this single seed via perceptual lighten/darken.
        /// </summary>
        public Color AccentColor
        {
            get => GetValue(AccentColorProperty);
            set => SetValue(AccentColorProperty, value);
        }


        public static readonly StyledProperty<Color> SecondaryAccentProperty =
            AvaloniaProperty.Register<NeumorphismTheme, Color>(nameof(SecondaryAccent), DefaultSecondaryAccent);

        /// <summary>
        /// Gets or sets the secondary accent colour. The light/mid/dark secondary hue brushes
        /// are derived from this single seed via perceptual lighten/darken.
        /// </summary>
        public Color SecondaryAccent
        {
            get => GetValue(SecondaryAccentProperty);
            set => SetValue(SecondaryAccentProperty, value);
        }



        protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        {
            base.OnPropertyChanged(change);

            if (change.Property == AccentColorProperty)
            {
                ApplyAccent(AccentColor);
            }
            else if (change.Property == SecondaryAccentProperty)
            {
                ApplySecondaryAccent(SecondaryAccent);
            }
            else if (change.Property == BaseThemeProperty)
            {
                Application.Current?.SetValue(ThemeVariantScope.ActualThemeVariantProperty,
                    BaseTheme == ApplicationTheme.Dark ? ThemeVariant.Dark : ThemeVariant.Light);
            }
        }

        private static void ApplyAccent(Color accent)
        {
            var resources = Application.Current?.Resources;
            if (resources is null)
                return;

            resources["PrimaryHueLightBrush"] = accent.Lighten();
            resources["PrimaryHueMidBrush"] = accent;
            resources["PrimaryHueDarkBrush"] = accent.Darken();

            resources["PrimaryHueLightForegroundBrush"] = accent.Lighten().ContrastingForegroundColor();
            resources["PrimaryHueMidForegroundBrush"] = accent.ContrastingForegroundColor();
            resources["PrimaryHueDarkForegroundBrush"] = accent.Darken().ContrastingForegroundColor();
        }

        private static void ApplySecondaryAccent(Color accent)
        {
            var resources = Application.Current?.Resources;
            if (resources is null)
                return;

            resources["SecondaryHueLightBrush"] = accent.Lighten();
            resources["SecondaryHueMidBrush"] = accent;
            resources["SecondaryHueDarkBrush"] = accent.Darken();

            resources["SecondaryHueLightForegroundBrush"] = accent.Lighten().ContrastingForegroundColor();
            resources["SecondaryHueMidForegroundBrush"] = accent.ContrastingForegroundColor();
            resources["SecondaryHueDarkForegroundBrush"] = accent.Darken().ContrastingForegroundColor();
        }
    }
}
