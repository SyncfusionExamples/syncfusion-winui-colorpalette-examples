using Microsoft.UI;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;

namespace ColorPalette_features
{
    public class ColorPaletteViewModel : NotificationObject
    {
        private bool showDefaultColorButton = true;
        private bool showMoreColorsButton = true;
        private bool showNoColorButton;
        private Brush selectedBrush=  new SolidColorBrush(Colors.Yellow);
        private ColorPaletteNames activePalette;
        private bool showPaletteColorsHeader = true;
        private ColorPaletteModel paletteColors = new ColorPaletteModel();
        private StandardPaletteModel standardColors = new StandardPaletteModel();
        private ICommand paletteCommand;
        private ICommand standardCommand;
        private bool allowPaletteColorShadesSpacing = true;
        private bool allowStandardColorShadesSpacing = false;
        private ColorPaletteNames colorPaletteNames = new ColorPaletteNames();

        public ColorPaletteViewModel()
        {
            this.PaletteCommand = new DelegateCommand(this.EnablePaletteColorShadesSpacing);
            this.StandardCommand = new DelegateCommand(this.EnableStandardColorShadesSpacing);
        }

        public ColorPaletteNames ColorPaletteNames
        {
            get
            {
                return colorPaletteNames;
            }
            set
            {
                if (this.colorPaletteNames != value)
                {
                    this.colorPaletteNames = value;
                    this.RaisePropertyChanged(nameof(this.ColorPaletteNames));
                }
            }
        }
        
        public Brush SelectedBrush
        {
            get
            {
                return selectedBrush;
            }
            set
            {
                if (this.selectedBrush != value)
                {
                    this.selectedBrush = value;
                    this.RaisePropertyChanged(nameof(this.SelectedBrush));
                }
            }
        }

        public bool ShowDefaultColorButton
        {
            get
            {
                return showDefaultColorButton;
            }
            set
            {
                if (this.showDefaultColorButton != value)
                {
                    this.showDefaultColorButton = value;
                    this.RaisePropertyChanged(nameof(this.ShowDefaultColorButton));
                }
            }
        }

        public bool ShowMoreColorsButton
        {
            get
            {
                return showMoreColorsButton;
            }
            set
            {
                if (this.showMoreColorsButton != value)
                {
                    this.showMoreColorsButton = value;
                    this.RaisePropertyChanged(nameof(this.ShowMoreColorsButton));
                }
            }
        }

        public bool ShowNoColorButton
        {
            get
            {
                return showNoColorButton;
            }
            set
            {
                if (this.showNoColorButton != value)
                {
                    this.showNoColorButton = value;
                    this.RaisePropertyChanged(nameof(this.ShowNoColorButton));
                }
            }
        }

        public ColorPaletteNames ActivePalette
        {
            get
            {
                return activePalette;
            }
            set
            {
                if (this.activePalette != value)
                {
                    this.activePalette = value;
                    this.RaisePropertyChanged(nameof(this.ActivePalette));
                }
            }
        }

        public bool ShowPaletteColorsHeader
        {
            get
            {
                return showPaletteColorsHeader;
            }
            set
            {
                if (this.showPaletteColorsHeader != value)
                {
                    this.showPaletteColorsHeader = value;
                    this.RaisePropertyChanged(nameof(this.ShowPaletteColorsHeader));
                }
            }
        }

        public ColorPaletteModel PaletteColors
        {
            get
            {
                return paletteColors;
            }
            set
            {
                if (this.paletteColors != value)
                {
                    this.paletteColors = value;
                    this.RaisePropertyChanged(nameof(this.PaletteColors));
                }
            }
        }

        public StandardPaletteModel StandardColors
        {
            get
            {
                return standardColors;
            }
            set
            {
                if (this.standardColors != value)
                {
                    this.standardColors = value;
                    this.RaisePropertyChanged(nameof(this.StandardColors));
                }
            }
        }

        public ICommand PaletteCommand
        {
            get
            {
                return paletteCommand;
            }
            set
            {
                if (this.paletteCommand != value)
                {
                    this.paletteCommand = value;
                    this.RaisePropertyChanged(nameof(this.PaletteCommand));
                }
            }
        }

        public ICommand StandardCommand
        {
            get
            {
                return standardCommand;
            }
            set
            {
                if (this.standardCommand != value)
                {
                    this.standardCommand = value;
                    this.RaisePropertyChanged(nameof(this.StandardCommand));
                }
            }
        }

        public bool AllowPaletteColorShadesSpacing
        {
            get
            {
                return allowPaletteColorShadesSpacing;
            }
            set
            {
                if (this.allowPaletteColorShadesSpacing != value)
                {
                    this.allowPaletteColorShadesSpacing = value;
                    this.RaisePropertyChanged(nameof(this.AllowPaletteColorShadesSpacing));
                }
            }
        }

        public bool AllowStandardColorShadesSpacing
        {
            get
            {
                return allowStandardColorShadesSpacing;
            }
            set
            {
                if (this.allowStandardColorShadesSpacing != value)
                {
                    this.allowStandardColorShadesSpacing = value;
                    this.RaisePropertyChanged(nameof(this.AllowStandardColorShadesSpacing));
                }
            }
        }

        private void EnablePaletteColorShadesSpacing(object parameter)
        {
            this.AllowPaletteColorShadesSpacing =
                this.PaletteColors.ShowColors && this.PaletteColors.ShowColorShades;
        }

        private void EnableStandardColorShadesSpacing(object parameter)
        {
            this.AllowStandardColorShadesSpacing =
                this.StandardColors.ShowColors && this.StandardColors.ShowColorShades;
        }
    }
}
