using System;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Styling;
using Avalonia.VisualTree;

namespace Avalonia.Themes.Neumorphism.Accents
{
    internal class SystemAccentColors : ResourceProvider
    {
        public const string AccentKey = "SystemAccentColor";
        public const string AccentDark1Key = "SystemAccentColorDark1";
        public const string AccentDark2Key = "SystemAccentColorDark2";
        public const string AccentDark3Key = "SystemAccentColorDark3";
        public const string AccentLight1Key = "SystemAccentColorLight1";
        public const string AccentLight2Key = "SystemAccentColorLight2";
        public const string AccentLight3Key = "SystemAccentColorLight3";


        public const string PrimaryHueLightForegroundBrushKey = "PrimaryHueLightForegroundBrush";
        public const string PrimaryHueMidForegroundBrushKey = "PrimaryHueMidForegroundBrush";
        public const string PrimaryHueDarkForegroundBrushKey = "PrimaryHueDarkForegroundBrush";
        public const string PrimaryHueLightBrushKey = "PrimaryHueLightBrush";
        public const string PrimaryHueMidBrushKey = "PrimaryHueMidBrush";
        public const string PrimaryHueDarkBrushKey = "PrimaryHueDarkBrush";

        public const string SecondaryHueLightForegroundBrushKey = "SecondaryHueLightForegroundBrush";
        public const string SecondaryHueMidForegroundBrushKey = "SecondaryHueMidForegroundBrush";
        public const string SecondaryHueDarkForegroundBrushKey = "SecondaryHueDarkForegroundBrush";
        public const string SecondaryHueLightBrushKey = "SecondaryHueLightBrush";
        public const string SecondaryHueMidBrushKey = "SecondaryHueMidBrush";
        public const string SecondaryHueDarkBrushKey = "SecondaryHueDarkBrush";

        public const string ValidationErrorBrushKey = "ValidationErrorBrush";
        public const string NeumorphismBackgroundKey = "NeumorphismBackground";
        public const string NeumorphismForegroundKey = "NeumorphismForeground";
        public const string NeumorphismPaperKey = "NeumorphismPaper";
        public const string NeumorphismCardBackgroundKey = "NeumorphismCardBackground";
        public const string NeumorphismToolBarBackgroundKey = "NeumorphismToolBarBackground";
        public const string NeumorphismBodyKey = "NeumorphismBody";
        public const string NeumorphismBodyLightKey = "NeumorphismBodyLight";
        public const string NeumorphismColumnHeaderKey = "NeumorphismColumnHeader";
        public const string NeumorphismCheckBoxOffKey = "NeumorphismCheckBoxOff";
        public const string NeumorphismDisabledKey = "NeumorphismDisabled";
        public const string NeumorphismTextBoxBorderKey = "NeumorphismTextBoxBorder";
        public const string NeumorphismDividerKey = "NeumorphismDivider";
        public const string NeumorphismSelectionKey = "NeumorphismSelection";
        public const string NeumorphismToolForegroundKey = "NeumorphismToolForeground";
        public const string NeumorphismToolBackgroundKey = "NeumorphismToolBackground";
        public const string NeumorphismFlatButtonClickKey = "NeumorphismFlatButtonClick";
        public const string NeumorphismFlatButtonRippleKey = "NeumorphismFlatButtonRipple";
        public const string NeumorphismToolTipBackgroundKey = "NeumorphismToolTipBackground";
        public const string NeumorphismChipBackgroundKey = "NeumorphismChipBackground";
        public const string NeumorphismSnackbarBackgroundKey = "NeumorphismSnackbarBackground";
        public const string NeumorphismSnackbarMouseOverKey = "NeumorphismSnackbarMouseOver";
        public const string NeumorphismSnackbarRippleKey = "NeumorphismSnackbarRipple";
        public const string NeumorphismTextFieldBoxBackgroundKey = "NeumorphismTextFieldBoxBackground";
        public const string NeumorphismTextFieldBoxHoverBackgroundKey = "NeumorphismTextFieldBoxHoverBackground";
        public const string NeumorphismTextFieldBoxDisabledBackgroundKey = "NeumorphismTextFieldBoxDisabledBackground";
        public const string NeumorphismTextAreaBorderKey = "NeumorphismTextAreaBorder";
        public const string NeumorphismTextAreaInactiveBorderKey = "NeumorphismTextAreaInactiveBorder";
        public const string NeumorphismDataGridRowHoverBackgroundKey = "NeumorphismDataGridRowHoverBackground";
        public const string NeumorphismShadowLightKey = "NeumorphismShadowLight";
        public const string NeumorphismShadowDarkKey = "NeumorphismShadowDark";
        public const string NeumorphismBorderShadowKey = "NeumorphismBorderShadow";
        public const string NeumorphismDisabledNoTransparencyKey = "NeumorphismDisabledNoTransparency";




        private static readonly Color s_defaultSystemAccentColor = Color.FromRgb(0, 120, 215);
        private bool _invalidateColors = true;
        private Color _systemAccentColor;
        private Color _systemAccentColorDark1, _systemAccentColorDark2, _systemAccentColorDark3;
        private Color _systemAccentColorLight1, _systemAccentColorLight2, _systemAccentColorLight3;

        public override bool HasResources => true;

        public override bool TryGetResource(object key, ThemeVariant theme, out object value)
        {
            if (key is string strKey)
            {
                if (strKey.Equals(AccentKey, StringComparison.InvariantCulture))
                {
                    EnsureColors();
                    value = _systemAccentColor;
                    return true;
                }

                if (strKey.Equals(AccentDark1Key, StringComparison.InvariantCulture))
                {
                    EnsureColors();
                    value = _systemAccentColorDark1;
                    return true;
                }

                if (strKey.Equals(AccentDark2Key, StringComparison.InvariantCulture))
                {
                    EnsureColors();
                    value = _systemAccentColorDark2;
                    return true;
                }

                if (strKey.Equals(AccentDark3Key, StringComparison.InvariantCulture))
                {
                    EnsureColors();
                    value = _systemAccentColorDark3;
                    return true;
                }

                if (strKey.Equals(AccentLight1Key, StringComparison.InvariantCulture))
                {
                    EnsureColors();
                    value = _systemAccentColorLight1;
                    return true;
                }

                if (strKey.Equals(AccentLight2Key, StringComparison.InvariantCulture))
                {
                    EnsureColors();
                    value = _systemAccentColorLight2;
                    return true;
                }

                if (strKey.Equals(AccentLight3Key, StringComparison.InvariantCulture))
                {
                    EnsureColors();
                    value = _systemAccentColorLight3;
                    return true;
                }
            }

            value = null;
            return false;
        }

        public void AddOwner(IResourceHost owner)
        {
            if (GetFromOwner(owner) is { } platformSettings)
            {
                platformSettings.ColorValuesChanged += PlatformSettingsOnColorValuesChanged;
            }

            _invalidateColors = true;
        }

        public void RemoveOwner(IResourceHost owner)
        {
            if (GetFromOwner(owner) is { } platformSettings)
            {
                platformSettings.ColorValuesChanged -= PlatformSettingsOnColorValuesChanged;
            }

            _invalidateColors = true;
        }

        private void EnsureColors()
        {
            if (_invalidateColors)
            {
                _invalidateColors = false;

                var platformSettings = GetFromOwner(Owner);

                _systemAccentColor = platformSettings?.GetColorValues().AccentColor1 ?? s_defaultSystemAccentColor;
                (_systemAccentColorDark1, _systemAccentColorDark2, _systemAccentColorDark3,
                        _systemAccentColorLight1, _systemAccentColorLight2, _systemAccentColorLight3) = CalculateAccentShades(_systemAccentColor);
            }
        }

        private static IPlatformSettings GetFromOwner(IResourceHost owner)
        {
            return owner switch
            {
                Application app => app.PlatformSettings,
                Visual visual => visual.GetPlatformSettings(),
                _ => null
            };
        }

        public static (Color d1, Color d2, Color d3, Color l1, Color l2, Color l3) CalculateAccentShades(Color accentColor)
        {
            // dark1step = (hslAccent.L - SystemAccentColorDark1.L) * 255
            const double dark1step = 28.5 / 255d;
            const double dark2step = 49 / 255d;
            const double dark3step = 74.5 / 255d;
            // light1step = (SystemAccentColorLight1.L - hslAccent.L) * 255
            const double light1step = 39 / 255d;
            const double light2step = 70 / 255d;
            const double light3step = 103 / 255d;

            var hslAccent = accentColor.ToHsl();

            return (
                // Darker shades
                new HslColor(hslAccent.A, hslAccent.H, hslAccent.S, hslAccent.L - dark1step).ToRgb(),
                new HslColor(hslAccent.A, hslAccent.H, hslAccent.S, hslAccent.L - dark2step).ToRgb(),
                new HslColor(hslAccent.A, hslAccent.H, hslAccent.S, hslAccent.L - dark3step).ToRgb(),

                // Lighter shades
                new HslColor(hslAccent.A, hslAccent.H, hslAccent.S, hslAccent.L + light1step).ToRgb(),
                new HslColor(hslAccent.A, hslAccent.H, hslAccent.S, hslAccent.L + light2step).ToRgb(),
                new HslColor(hslAccent.A, hslAccent.H, hslAccent.S, hslAccent.L + light3step).ToRgb()
            );
        }

        private void PlatformSettingsOnColorValuesChanged(object sender, PlatformColorValues e)
        {
            _invalidateColors = true;
            Owner?.NotifyHostedResourcesChanged(ResourcesChangedEventArgs.Create());
        }
    }
}