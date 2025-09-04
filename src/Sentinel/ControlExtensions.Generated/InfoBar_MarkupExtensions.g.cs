#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class InfoBar_MarkupExtensions
{
//================= Properties ======================//
 // Severity

/*ValueSetterGenerator*/
public static T Severity<T>(this T control, Avalonia.Controls.Notifications.NotificationType value) where T : SukiUI.Controls.InfoBar 
=> control._set(() => control.Severity = value!);

/*BindFromExpressionSetterGenerator*/
public static T Severity<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationType> func, Action<Avalonia.Controls.Notifications.NotificationType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.SeverityProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Severity<T>(this T control,Avalonia.Controls.Notifications.NotificationType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.SeverityProperty, ps, () => control.Severity = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Severity<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.SeverityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Severity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.SeverityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Severity<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Notifications.NotificationType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.SeverityProperty, ps, () => control.Severity = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsOpen

/*ValueSetterGenerator*/
public static T IsOpen<T>(this T control, System.Boolean value) where T : SukiUI.Controls.InfoBar 
=> control._set(() => control.IsOpen = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsOpenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.IsOpenProperty, ps, () => control.IsOpen = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsOpen<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.IsOpenProperty, ps, () => control.IsOpen = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsClosable

/*ValueSetterGenerator*/
public static T IsClosable<T>(this T control, System.Boolean value) where T : SukiUI.Controls.InfoBar 
=> control._set(() => control.IsClosable = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsClosable<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsClosableProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsClosable<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.IsClosableProperty, ps, () => control.IsClosable = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsClosable<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsClosableProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsClosable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsClosableProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsClosable<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.IsClosableProperty, ps, () => control.IsClosable = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsOpaque

/*ValueSetterGenerator*/
public static T IsOpaque<T>(this T control, System.Boolean value) where T : SukiUI.Controls.InfoBar 
=> control._set(() => control.IsOpaque = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsOpaque<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsOpaqueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsOpaque<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.IsOpaqueProperty, ps, () => control.IsOpaque = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsOpaque<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsOpaqueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsOpaque<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsOpaqueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsOpaque<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.IsOpaqueProperty, ps, () => control.IsOpaque = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, System.String value) where T : SukiUI.Controls.InfoBar 
=> control._set(() => control.Title = value!);

/*BindFromExpressionSetterGenerator*/
public static T Title<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.TitleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Title<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.TitleProperty, ps, () => control.Title = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Title<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.TitleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Title<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.TitleProperty, ps, () => control.Title = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleOrientation

/*ValueSetterGenerator*/
public static T TitleOrientation<T>(this T control, Avalonia.Layout.Orientation value) where T : SukiUI.Controls.InfoBar 
=> control._set(() => control.TitleOrientation = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleOrientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.TitleOrientationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleOrientation<T>(this T control,Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.TitleOrientationProperty, ps, () => control.TitleOrientation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleOrientation<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.TitleOrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleOrientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.TitleOrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleOrientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.TitleOrientationProperty, ps, () => control.TitleOrientation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Message

/*ValueSetterGenerator*/
public static T Message<T>(this T control, System.String value) where T : SukiUI.Controls.InfoBar 
=> control._set(() => control.Message = value!);

/*BindFromExpressionSetterGenerator*/
public static T Message<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.MessageProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Message<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.MessageProperty, ps, () => control.Message = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Message<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.MessageProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Message<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.MessageProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Message<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.MessageProperty, ps, () => control.Message = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MessageTextAlignment

/*ValueSetterGenerator*/
public static T MessageTextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : SukiUI.Controls.InfoBar 
=> control._set(() => control.MessageTextAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T MessageTextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.MessageTextAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MessageTextAlignment<T>(this T control,Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.MessageTextAlignmentProperty, ps, () => control.MessageTextAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MessageTextAlignment<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.MessageTextAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MessageTextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.MessageTextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MessageTextAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.MessageTextAlignmentProperty, ps, () => control.MessageTextAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsTextSelectable

/*ValueSetterGenerator*/
public static T IsTextSelectable<T>(this T control, System.Boolean value) where T : SukiUI.Controls.InfoBar 
=> control._set(() => control.IsTextSelectable = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsTextSelectable<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsTextSelectableProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsTextSelectable<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.IsTextSelectableProperty, ps, () => control.IsTextSelectable = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTextSelectable<T>(this T control, IBinding binding) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsTextSelectableProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTextSelectable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.InfoBar 
   => control._set(SukiUI.Controls.InfoBar.IsTextSelectableProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsTextSelectable<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.InfoBar 
=> control._setEx(SukiUI.Controls.InfoBar.IsTextSelectableProperty, ps, () => control.IsTextSelectable = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Severity

/*ValueStyleSetterGenerator*/
public static Style<T> Severity<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationType value) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.SeverityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Severity<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.SeverityProperty, binding);


 // IsOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.IsOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.IsOpenProperty, binding);


 // IsClosable

/*ValueStyleSetterGenerator*/
public static Style<T> IsClosable<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.IsClosableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsClosable<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.IsClosableProperty, binding);


 // IsOpaque

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpaque<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.IsOpaqueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpaque<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.IsOpaqueProperty, binding);


 // Title

/*ValueStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.TitleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.TitleProperty, binding);


 // TitleOrientation

/*ValueStyleSetterGenerator*/
public static Style<T> TitleOrientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.TitleOrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleOrientation<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.TitleOrientationProperty, binding);


 // Message

/*ValueStyleSetterGenerator*/
public static Style<T> Message<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.MessageProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Message<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.MessageProperty, binding);


 // MessageTextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> MessageTextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.MessageTextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MessageTextAlignment<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.MessageTextAlignmentProperty, binding);


 // IsTextSelectable

/*ValueStyleSetterGenerator*/
public static Style<T> IsTextSelectable<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.IsTextSelectableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTextSelectable<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.InfoBar 
=> style._addSetter(SukiUI.Controls.InfoBar.IsTextSelectableProperty, binding);



}
