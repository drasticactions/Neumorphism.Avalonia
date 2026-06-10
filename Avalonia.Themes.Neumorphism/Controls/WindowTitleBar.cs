using System;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.VisualTree;

namespace Avalonia.Themes.Neumorphism.Controls
{
    /// <summary>
    /// A neumorphic, cross-platform window title bar with caption buttons.
    /// <para>
    /// Intended to be placed at the top of a <see cref="Window"/> whose <c>WindowDecorations</c> is
    /// <c>BorderOnly</c>: that keeps the native, resizable frame on Windows, Linux and macOS while removing the
    /// native caption buttons (incl. macOS traffic lights), so this control can supply fully themed chrome. The
    /// window is moved via <see cref="Window.BeginMoveDrag"/> and resized by the native border.
    /// </para>
    /// <para>
    /// The layout adapts to the OS: on macOS the control sets the <c>:macos</c> pseudo-class and shows round
    /// "traffic-light" buttons on the left; elsewhere it shows squared caption buttons on the right.
    /// </para>
    /// </summary>
    [PseudoClasses(":maximized", ":macos")]
    public class WindowTitleBar : TemplatedControl
    {
        /// <summary>Optional content shown next to the title (e.g. a logo or menu button).</summary>
        public static readonly StyledProperty<object> LeftContentProperty =
            AvaloniaProperty.Register<WindowTitleBar, object>(nameof(LeftContent));

        public object LeftContent
        {
            get => GetValue(LeftContentProperty);
            set => SetValue(LeftContentProperty, value);
        }

        /// <summary>Whether the maximize/zoom button is shown (mirrors the window's <c>CanResize</c>).</summary>
        public static readonly StyledProperty<bool> CanMaximizeProperty =
            AvaloniaProperty.Register<WindowTitleBar, bool>(nameof(CanMaximize), true);

        public bool CanMaximize
        {
            get => GetValue(CanMaximizeProperty);
            private set => SetValue(CanMaximizeProperty, value);
        }

        public static readonly DirectProperty<WindowTitleBar, ICommand> MinimizeCommandProperty =
            AvaloniaProperty.RegisterDirect<WindowTitleBar, ICommand>(nameof(MinimizeCommand), o => o.MinimizeCommand);

        public static readonly DirectProperty<WindowTitleBar, ICommand> MaximizeRestoreCommandProperty =
            AvaloniaProperty.RegisterDirect<WindowTitleBar, ICommand>(nameof(MaximizeRestoreCommand), o => o.MaximizeRestoreCommand);

        public static readonly DirectProperty<WindowTitleBar, ICommand> CloseCommandProperty =
            AvaloniaProperty.RegisterDirect<WindowTitleBar, ICommand>(nameof(CloseCommand), o => o.CloseCommand);

        /// <summary>Minimizes the window. Bound by the caption buttons in the template.</summary>
        public ICommand MinimizeCommand { get; }

        /// <summary>Toggles maximize/restore. Bound by the caption buttons in the template.</summary>
        public ICommand MaximizeRestoreCommand { get; }

        /// <summary>Closes the window. Bound by the caption buttons in the template.</summary>
        public ICommand CloseCommand { get; }

        private Window _window;

        public WindowTitleBar()
        {
            MinimizeCommand = new ActionCommand(Minimize);
            MaximizeRestoreCommand = new ActionCommand(ToggleMaximize);
            CloseCommand = new ActionCommand(Close);
            PseudoClasses.Set(":macos", OperatingSystem.IsMacOS());
        }

        protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnAttachedToVisualTree(e);

            _window = TopLevel.GetTopLevel(this) as Window;
            if (_window != null)
            {
                _window.PropertyChanged += OnWindowPropertyChanged;
                UpdateMaximizedState();
                UpdateButtonsAvailability();
            }
        }

        protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnDetachedFromVisualTree(e);

            if (_window != null)
            {
                _window.PropertyChanged -= OnWindowPropertyChanged;
                _window = null;
            }
        }

        protected override void OnPointerPressed(PointerPressedEventArgs e)
        {
            base.OnPointerPressed(e);

            if (_window == null || !e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
                return;

            // Ignore presses on the caption buttons (or any button in LeftContent) so they keep working.
            if (e.Source is Visual source && source.FindAncestorOfType<Button>(true) != null)
                return;

            if (e.ClickCount == 2)
            {
                ToggleMaximize();
                e.Handled = true;
                return;
            }

            _window.BeginMoveDrag(e);
        }

        private void OnWindowPropertyChanged(object sender, AvaloniaPropertyChangedEventArgs e)
        {
            if (e.Property == Window.WindowStateProperty)
                UpdateMaximizedState();
            else if (e.Property == Window.CanResizeProperty)
                UpdateButtonsAvailability();
        }

        private void UpdateMaximizedState() =>
            PseudoClasses.Set(":maximized", _window?.WindowState == WindowState.Maximized);

        private void UpdateButtonsAvailability() => CanMaximize = _window?.CanResize ?? true;

        private void Minimize()
        {
            if (_window != null)
                _window.WindowState = WindowState.Minimized;
        }

        private void ToggleMaximize()
        {
            if (_window == null || !_window.CanResize)
                return;

            _window.WindowState = _window.WindowState == WindowState.Maximized
                ? WindowState.Normal
                : WindowState.Maximized;
        }

        private void Close() => _window?.Close();

        private sealed class ActionCommand : ICommand
        {
            private readonly Action _execute;
            public ActionCommand(Action execute) => _execute = execute;
            public bool CanExecute(object parameter) => true;
            public void Execute(object parameter) => _execute();
            public event EventHandler CanExecuteChanged { add { } remove { } }
        }
    }
}
