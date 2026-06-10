using Avalonia.Media;

namespace Avalonia.Themes.Neumorphism
{
    public partial class ColorPaletteResources
    {
        private bool _hasAccentColor;
        private Color _accentColor;
        private Color _accentColorDark1, _accentColorDark2, _accentColorDark3;
        private Color _accentColorLight1, _accentColorLight2, _accentColorLight3;


        public static readonly DirectProperty<ColorPaletteResources, Color> AccentProperty
            = AvaloniaProperty.RegisterDirect<ColorPaletteResources, Color>(nameof(Accent), r => r.Accent, (r, v) => r.Accent = v);

        /// <summary>
        /// Gets or sets the Accent color value.
        /// </summary>
        public Color Accent
        {
            get => _accentColor;
            set => SetAndRaise(AccentProperty, ref _accentColor, value);
        }

        /// <summary>
        /// Gets or sets the AltHigh color value.
        /// </summary>
        public Color AltHigh { get => GetColor("SystemAltHighColor"); set => SetColor("SystemAltHighColor", value); }

        /// <summary>
        /// Gets or sets the AltLow color value.
        /// </summary>
        public Color AltLow { get => GetColor("SystemAltLowColor"); set => SetColor("SystemAltLowColor", value); }

        /// <summary>
        /// Gets or sets the AltMedium color value.
        /// </summary>
        public Color AltMedium { get => GetColor("SystemAltMediumColor"); set => SetColor("SystemAltMediumColor", value); }

        /// <summary>
        /// Gets or sets the AltMediumHigh color value.
        /// </summary>
        public Color AltMediumHigh { get => GetColor("SystemAltMediumHighColor"); set => SetColor("SystemAltMediumHighColor", value); }

        /// <summary>
        /// Gets or sets the AltMediumLow color value.
        /// </summary>
        public Color AltMediumLow { get => GetColor("SystemAltMediumLowColor"); set => SetColor("SystemAltMediumLowColor", value); }

        /// <summary>
        /// Gets or sets the BaseHigh color value.
        /// </summary>
        public Color BaseHigh { get => GetColor("SystemBaseHighColor"); set => SetColor("SystemBaseHighColor", value); }

        /// <summary>
        /// Gets or sets the BaseLow color value.
        /// </summary>
        public Color BaseLow { get => GetColor("SystemBaseLowColor"); set => SetColor("SystemBaseLowColor", value); }

        /// <summary>
        /// Gets or sets the BaseMedium color value.
        /// </summary>
        public Color BaseMedium { get => GetColor("SystemBaseMediumColor"); set => SetColor("SystemBaseMediumColor", value); }

        /// <summary>
        /// Gets or sets the BaseMediumHigh color value.
        /// </summary>
        public Color BaseMediumHigh { get => GetColor("SystemBaseMediumHighColor"); set => SetColor("SystemBaseMediumHighColor", value); }

        /// <summary>
        /// Gets or sets the BaseMediumLow color value.
        /// </summary>
        public Color BaseMediumLow { get => GetColor("SystemBaseMediumLowColor"); set => SetColor("SystemBaseMediumLowColor", value); }

        /// <summary>
        /// Gets or sets the ChromeAltLow color value.
        /// </summary>
        public Color ChromeAltLow { get => GetColor("SystemChromeAltLowColor"); set => SetColor("SystemChromeAltLowColor", value); }

        /// <summary>
        /// Gets or sets the ChromeBlackHigh color value.
        /// </summary>
        public Color ChromeBlackHigh { get => GetColor("SystemChromeBlackHighColor"); set => SetColor("SystemChromeBlackHighColor", value); }

        /// <summary>
        /// Gets or sets the ChromeBlackLow color value.
        /// </summary>
        public Color ChromeBlackLow { get => GetColor("SystemChromeBlackLowColor"); set => SetColor("SystemChromeBlackLowColor", value); }

        /// <summary>
        /// Gets or sets the ChromeBlackMedium color value.
        /// </summary>
        public Color ChromeBlackMedium { get => GetColor("SystemChromeBlackMediumColor"); set => SetColor("SystemChromeBlackMediumColor", value); }

        /// <summary>
        /// Gets or sets the ChromeBlackMediumLow color value.
        /// </summary>
        public Color ChromeBlackMediumLow { get => GetColor("SystemChromeBlackMediumLowColor"); set => SetColor("SystemChromeBlackMediumLowColor", value); }

        /// <summary>
        /// Gets or sets the ChromeDisabledHigh color value.
        /// </summary>
        public Color ChromeDisabledHigh { get => GetColor("SystemChromeDisabledHighColor"); set => SetColor("SystemChromeDisabledHighColor", value); }

        /// <summary>
        /// Gets or sets the ChromeDisabledLow color value.
        /// </summary>
        public Color ChromeDisabledLow { get => GetColor("SystemChromeDisabledLowColor"); set => SetColor("SystemChromeDisabledLowColor", value); }

        /// <summary>
        /// Gets or sets the ChromeGray color value.
        /// </summary>
        public Color ChromeGray { get => GetColor("SystemChromeGrayColor"); set => SetColor("SystemChromeGrayColor", value); }

        /// <summary>
        /// Gets or sets the ChromeHigh color value.
        /// </summary>
        public Color ChromeHigh { get => GetColor("SystemChromeHighColor"); set => SetColor("SystemChromeHighColor", value); }

        /// <summary>
        /// Gets or sets the ChromeLow color value.
        /// </summary>
        public Color ChromeLow { get => GetColor("SystemChromeLowColor"); set => SetColor("SystemChromeLowColor", value); }

        /// <summary>
        /// Gets or sets the ChromeMedium color value.
        /// </summary>
        public Color ChromeMedium { get => GetColor("SystemChromeMediumColor"); set => SetColor("SystemChromeMediumColor", value); }

        /// <summary>
        /// Gets or sets the ChromeMediumLow color value.
        /// </summary>
        public Color ChromeMediumLow { get => GetColor("SystemChromeMediumLowColor"); set => SetColor("SystemChromeMediumLowColor", value); }

        /// <summary>
        /// Gets or sets the ChromeWhite color value.
        /// </summary>
        public Color ChromeWhite { get => GetColor("SystemChromeWhiteColor"); set => SetColor("SystemChromeWhiteColor", value); }

        /// <summary>
        /// Gets or sets the ErrorText color value.
        /// </summary>
        public Color ErrorText { get => GetColor("SystemErrorTextColor"); set => SetColor("SystemErrorTextColor", value); }

        /// <summary>
        /// Gets or sets the ListLow color value.
        /// </summary>
        public Color ListLow { get => GetColor("SystemListLowColor"); set => SetColor("SystemListLowColor", value); }

        /// <summary>
        /// Gets or sets the ListMedium color value.
        /// </summary>
        public Color ListMedium { get => GetColor("SystemListMediumColor"); set => SetColor("SystemListMediumColor", value); }

        /// <summary>
        /// Gets or sets the RegionColor color value.
        /// </summary>
        public Color RegionColor { get => GetColor("SystemRegionColor"); set => SetColor("SystemRegionColor", value); }


        //new !!!!!!!!!!!!!!


        /// <summary>
        /// Gets or sets the ValidationErrorColor color value.
        /// </summary>
        public Color ValidationErrorColor { get => GetColor("ValidationErrorColor"); set => SetColor("ValidationErrorColor", value); }


        /// <summary>
        /// Gets or sets the NeumorphismPaper color value.
        /// </summary>
        public Color NeumorphismPaper { get => GetColor("NeumorphismPaper"); set => SetColor("NeumorphismPaper", value); }

        /// <summary>
        /// Gets or sets the NeumorphismBackground color value.
        /// </summary>
        public Color NeumorphismBackground { get => GetColor("NeumorphismBackground"); set => SetColor("NeumorphismBackground", value); }

        /// <summary>
        /// Gets or sets the NeumorphismForeground color value.
        /// </summary>
        public Color NeumorphismForeground { get => GetColor("NeumorphismForeground"); set => SetColor("NeumorphismForeground", value); }

        /// <summary>
        /// Gets or sets the NeumorphismCardBackground color value.
        /// </summary>
        public Color NeumorphismCardBackground { get => GetColor("NeumorphismCardBackground"); set => SetColor("NeumorphismCardBackground", value); }

        /// <summary>
        /// Gets or sets the NeumorphismToolBarBackground color value.
        /// </summary>
        public Color NeumorphismToolBarBackground { get => GetColor("NeumorphismToolBarBackground"); set => SetColor("NeumorphismToolBarBackground", value); }

        /// <summary>
        /// Gets or sets the NeumorphismBody color value.
        /// </summary>
        public Color NeumorphismBody { get => GetColor("NeumorphismBody"); set => SetColor("NeumorphismBody", value); }

        /// <summary>
        /// Gets or sets the NeumorphismBodyLight color value.
        /// </summary>
        public Color NeumorphismBodyLight { get => GetColor("NeumorphismBodyLight"); set => SetColor("NeumorphismBodyLight", value); }

        /// <summary>
        /// Gets or sets the NeumorphismColumnHeader color value.
        /// </summary>
        public Color NeumorphismColumnHeader { get => GetColor("NeumorphismColumnHeader"); set => SetColor("NeumorphismColumnHeader", value); }

        /// <summary>
        /// Gets or sets the NeumorphismCheckBoxOff color value.
        /// </summary>
        public Color NeumorphismCheckBoxOff { get => GetColor("NeumorphismCheckBoxOff"); set => SetColor("NeumorphismCheckBoxOff", value); }

        /// <summary>
        /// Gets or sets the NeumorphismDisabled color value.
        /// </summary>
        public Color NeumorphismDisabled { get => GetColor("NeumorphismDisabled"); set => SetColor("NeumorphismDisabled", value); }

        /// <summary>
        /// Gets or sets the NeumorphismTextBoxBorder color value.
        /// </summary>
        public Color NeumorphismTextBoxBorder { get => GetColor("NeumorphismTextBoxBorder"); set => SetColor("NeumorphismTextBoxBorder", value); }

        /// <summary>
        /// Gets or sets the NeumorphismDivider color value.
        /// </summary>
        public Color NeumorphismDivider { get => GetColor("NeumorphismDivider"); set => SetColor("NeumorphismDivider", value); }

        /// <summary>
        /// Gets or sets the NeumorphismSelection color value.
        /// </summary>
        public Color NeumorphismSelection { get => GetColor("NeumorphismSelection"); set => SetColor("NeumorphismSelection", value); }

        /// <summary>
        /// Gets or sets the NeumorphismToolForeground color value.
        /// </summary>
        public Color NeumorphismToolForeground { get => GetColor("NeumorphismToolForeground"); set => SetColor("NeumorphismToolForeground", value); }

        /// <summary>
        /// Gets or sets the NeumorphismToolBackground color value.
        /// </summary>
        public Color NeumorphismToolBackground { get => GetColor("NeumorphismToolBackground"); set => SetColor("NeumorphismToolBackground", value); }

        /// <summary>
        /// Gets or sets the NeumorphismFlatButtonClick color value.
        /// </summary>
        public Color NeumorphismFlatButtonClick { get => GetColor("NeumorphismFlatButtonClick"); set => SetColor("NeumorphismFlatButtonClick", value); }

        /// <summary>
        /// Gets or sets the NeumorphismFlatButtonRipple color value.
        /// </summary>
        public Color NeumorphismFlatButtonRipple { get => GetColor("NeumorphismFlatButtonRipple"); set => SetColor("NeumorphismFlatButtonRipple", value); }


        /// <summary>
        /// Gets or sets the NeumorphismToolTipBackground color value.
        /// </summary>
        public Color NeumorphismToolTipBackground { get => GetColor("NeumorphismToolTipBackground"); set => SetColor("NeumorphismToolTipBackground", value); }


        /// <summary>
        /// Gets or sets the NeumorphismChipBackground color value.
        /// </summary>
        public Color NeumorphismChipBackground { get => GetColor("NeumorphismChipBackground"); set => SetColor("NeumorphismChipBackground", value); }

        /// <summary>
        /// Gets or sets the NeumorphismSnackbarBackground color value.
        /// </summary>
        public Color NeumorphismSnackbarBackground { get => GetColor("NeumorphismSnackbarBackground"); set => SetColor("NeumorphismSnackbarBackground", value); }

        /// <summary>
        /// Gets or sets the NeumorphismSnackbarMouseOver color value.
        /// </summary>
        public Color NeumorphismSnackbarMouseOver { get => GetColor("NeumorphismSnackbarMouseOver"); set => SetColor("NeumorphismSnackbarMouseOver", value); }

        /// <summary>
        /// Gets or sets the NeumorphismSnackbarRipple color value.
        /// </summary>
        public Color NeumorphismSnackbarRipple { get => GetColor("NeumorphismSnackbarRipple"); set => SetColor("NeumorphismSnackbarRipple", value); }


        /// <summary>
        /// Gets or sets the NeumorphismTextFieldBoxBackground color value.
        /// </summary>
        public Color NeumorphismTextFieldBoxBackground { get => GetColor("NeumorphismTextFieldBoxBackground"); set => SetColor("NeumorphismTextFieldBoxBackground", value); }


        /// <summary>
        /// Gets or sets the NeumorphismTextFieldBoxHoverBackground color value.
        /// </summary>
        public Color NeumorphismTextFieldBoxHoverBackground { get => GetColor("NeumorphismTextFieldBoxHoverBackground"); set => SetColor("NeumorphismTextFieldBoxHoverBackground", value); }


        /// <summary>
        /// Gets or sets the NeumorphismTextFieldBoxDisabledBackground color value.
        /// </summary>
        public Color NeumorphismTextFieldBoxDisabledBackground { get => GetColor("NeumorphismTextFieldBoxDisabledBackground"); set => SetColor("NeumorphismTextFieldBoxDisabledBackground", value); }


        /// <summary>
        /// Gets or sets the NeumorphismTextAreaBorder color value.
        /// </summary>
        public Color NeumorphismTextAreaBorder { get => GetColor("NeumorphismTextAreaBorder"); set => SetColor("NeumorphismTextAreaBorder", value); }


        /// <summary>
        /// Gets or sets the NeumorphismTextAreaInactiveBorder color value.
        /// </summary>
        public Color NeumorphismTextAreaInactiveBorder { get => GetColor("NeumorphismTextAreaInactiveBorder"); set => SetColor("NeumorphismTextAreaInactiveBorder", value); }


        /// <summary>
        /// Gets or sets the NeumorphismDataGridRowHoverBackground color value.
        /// </summary>
        public Color NeumorphismDataGridRowHoverBackground { get => GetColor("NeumorphismDataGridRowHoverBackground"); set => SetColor("NeumorphismDataGridRowHoverBackground", value); }


        /// <summary>
        /// Gets or sets the NeumorphismShadowLight color value.
        /// </summary>
        public Color NeumorphismShadowLight { get => GetColor("NeumorphismShadowLight"); set => SetColor("NeumorphismShadowLight", value); }


        /// <summary>
        /// Gets or sets the NeumorphismShadowDark color value.
        /// </summary>
        public Color NeumorphismShadowDark { get => GetColor("NeumorphismShadowDark"); set => SetColor("NeumorphismShadowDark", value); }


        /// <summary>
        /// Gets or sets the NeumorphismBorderShadow color value.
        /// </summary>
        public Color NeumorphismBorderShadow { get => GetColor("NeumorphismBorderShadow"); set => SetColor("NeumorphismBorderShadow", value); }


        /// <summary>
        /// Gets or sets the NeumorphismDisabledNoTransparency color value.
        /// </summary>
        public Color NeumorphismDisabledNoTransparency { get => GetColor("NeumorphismDisabledNoTransparency"); set => SetColor("NeumorphismDisabledNoTransparency", value); }


        /// <summary>
        /// Gets or sets the NeumorphismTransparent color value.
        /// </summary>
        public Color NeumorphismTransparent { get => GetColor("NeumorphismTransparent"); set => SetColor("NeumorphismTransparent", value); }

        /// <summary>
        /// Gets or sets the NeumorphismSilverGray color value.
        /// </summary>
        public Color NeumorphismSilverGray { get => GetColor("NeumorphismSilverGray"); set => SetColor("NeumorphismSilverGray", value); }

        /// <summary>
        /// Gets or sets the NeumorphismDarkGray color value.
        /// </summary>
        public Color NeumorphismDarkGray { get => GetColor("NeumorphismDarkGray"); set => SetColor("NeumorphismDarkGray", value); }

        /// <summary>
        /// Gets or sets the NeumorphismMediumGray color value.
        /// </summary>
        public Color NeumorphismMediumGray { get => GetColor("NeumorphismMediumGray"); set => SetColor("NeumorphismMediumGray", value); }

        /// <summary>
        /// Gets or sets the NeumorphismLightGray color value.
        /// </summary>
        public Color NeumorphismLightGray { get => GetColor("NeumorphismLightGray"); set => SetColor("NeumorphismLightGray", value); }

        /// <summary>
        /// Gets or sets the NeumorphismFocus color value.
        /// </summary>
        public Color NeumorphismFocus { get => GetColor("NeumorphismFocus"); set => SetColor("NeumorphismFocus", value); }
    }
}