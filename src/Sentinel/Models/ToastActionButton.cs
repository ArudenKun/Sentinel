using System.Diagnostics.CodeAnalysis;
using Antelcat.AutoGen.ComponentModel;
using SukiUI.Enums;
using SukiUI.Toasts;

namespace Sentinel.Models;

[AutoDeconstruct]
public partial class ToastActionButton
{
    public required object ButtonContent { get; set; }
    public Action<ISukiToast> OnClicked { get; set; } = _ => { };
    public bool DismissOnClick { get; set; }
    public SukiButtonStyles Styles { get; set; } = SukiButtonStyles.Flat;

    public ToastActionButton() { }

    [SetsRequiredMembers]
    public ToastActionButton(
        object buttonContent,
        Action<ISukiToast>? onClicked = null,
        bool dismissOnClick = false,
        SukiButtonStyles styles = SukiButtonStyles.Flat
    )
    {
        ButtonContent = buttonContent;
        if (onClicked is not null)
            OnClicked = onClicked;
        DismissOnClick = dismissOnClick;
        Styles = styles;
    }
}
