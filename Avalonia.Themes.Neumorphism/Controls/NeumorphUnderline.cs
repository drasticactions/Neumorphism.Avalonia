using Avalonia.Controls;
using Avalonia.Media;

namespace Avalonia.Themes.Neumorphism.Controls
{
    public sealed class NeumorphUnderline : ContentControl
    {
        /// <summary>
        /// Defines the <see cref="IdleBrush"/> property.
        /// </summary>
        public static readonly StyledProperty<IBrush> IdleBrushProperty =
            AvaloniaProperty.Register<NeumorphUnderline, IBrush>(nameof(IdleBrush));

        public IBrush IdleBrush
        {
            get => GetValue(IdleBrushProperty);
            set => SetValue(IdleBrushProperty, value);
        }

        /// <summary>
        /// Defines the <see cref="ActiveBrush"/> property.
        /// </summary>
        public static readonly StyledProperty<IBrush> ActiveBrushProperty =
            AvaloniaProperty.Register<NeumorphUnderline, IBrush>(nameof(ActiveBrush));

        public IBrush ActiveBrush
        {
            get => GetValue(ActiveBrushProperty);
            set => SetValue(ActiveBrushProperty, value);
        }

        /// <summary>
        /// Defines the <see cref="IsActive"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsActiveProperty =
            AvaloniaProperty.Register<NeumorphUnderline, bool>(nameof(IsActive));

        public bool IsActive
        {
            get => GetValue(IsActiveProperty);
            set => SetValue(IsActiveProperty, value);
        }

        /// <summary>
        /// Defines the <see cref="IsHovered"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsHoveredProperty =
            AvaloniaProperty.Register<NeumorphUnderline, bool>(nameof(IsHovered));

        public bool IsHovered
        {
            get => GetValue(IsHoveredProperty);
            set => SetValue(IsHoveredProperty, value);
        }
    }
}