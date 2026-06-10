using System;
using Avalonia.Markup.Xaml;
using Avalonia.Metadata;

namespace Avalonia.Themes.Neumorphism.Controls.Extensions
{
    public sealed class NeumorphInternalIconExtension : MarkupExtension
    {
        public NeumorphInternalIconExtension()
        {
        }

        public NeumorphInternalIconExtension(string kind)
        {
            Kind = kind;
        }

        public NeumorphInternalIconExtension(string kind, double? size)
        {
            Kind = kind;
            Size = size;
        }

        [ConstructorArgument("kind")] public string Kind { get; set; }

        [ConstructorArgument("size")] public double? Size { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var result = new NeumorphInternalIcon
            {
                Kind = Kind ?? string.Empty
            };

            if (!Size.HasValue)
                return result;

            result.Height = Size.Value;
            result.Width = Size.Value;

            return result;
        }
    }
}