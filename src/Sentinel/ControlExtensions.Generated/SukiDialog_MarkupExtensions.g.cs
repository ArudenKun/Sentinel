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
public static partial class SukiDialog_MarkupExtensions
{
//================= Properties ======================//
 // ViewModel

/*ValueSetterGenerator*/
public static T ViewModel<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiDialog 
=> control._set(() => control.ViewModel = value!);

/*BindFromExpressionSetterGenerator*/
public static T ViewModel<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ViewModelProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ViewModel<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.ViewModelProperty, ps, () => control.ViewModel = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ViewModel<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ViewModelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ViewModel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ViewModelProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ViewModel<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.ViewModelProperty, ps, () => control.ViewModel = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, System.String value) where T : SukiUI.Controls.SukiDialog 
=> control._set(() => control.Title = value!);

/*BindFromExpressionSetterGenerator*/
public static T Title<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.TitleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Title<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.TitleProperty, ps, () => control.Title = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Title<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.TitleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Title<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.TitleProperty, ps, () => control.Title = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiDialog 
=> control._set(() => control.Content = value!);

/*BindFromExpressionSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Content<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.ContentProperty, ps, () => control.Content = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Content<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Content<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.ContentProperty, ps, () => control.Content = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsViewModelOnly

/*ValueSetterGenerator*/
public static T IsViewModelOnly<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiDialog 
=> control._set(() => control.IsViewModelOnly = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsViewModelOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.IsViewModelOnlyProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsViewModelOnly<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.IsViewModelOnlyProperty, ps, () => control.IsViewModelOnly = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsViewModelOnly<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.IsViewModelOnlyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsViewModelOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.IsViewModelOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsViewModelOnly<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.IsViewModelOnlyProperty, ps, () => control.IsViewModelOnly = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiDialog 
=> control._set(() => control.Icon = value!);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.IconProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Icon<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.IconProperty, ps, () => control.Icon = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Icon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.IconProperty, ps, () => control.Icon = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowCardBackground

/*ValueSetterGenerator*/
public static T ShowCardBackground<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiDialog 
=> control._set(() => control.ShowCardBackground = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowCardBackground<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ShowCardBackgroundProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowCardBackground<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.ShowCardBackgroundProperty, ps, () => control.ShowCardBackground = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowCardBackground<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ShowCardBackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowCardBackground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ShowCardBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowCardBackground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.ShowCardBackgroundProperty, ps, () => control.ShowCardBackground = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IconColor

/*ValueSetterGenerator*/
public static T IconColor<T>(this T control, Avalonia.Media.IBrush value) where T : SukiUI.Controls.SukiDialog 
=> control._set(() => control.IconColor = value!);

/*BindFromExpressionSetterGenerator*/
public static T IconColor<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.IconColorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IconColor<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.IconColorProperty, ps, () => control.IconColor = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IconColor<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.IconColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconColor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.IconColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IconColor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.IconColorProperty, ps, () => control.IconColor = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ActionButtons

/*ValueSetterGenerator*/
public static T ActionButtons<T>(this T control, System.Collections.ObjectModel.ObservableCollection<System.Object> value) where T : SukiUI.Controls.SukiDialog 
=> control._set(() => control.ActionButtons = value!);

/*BindFromExpressionSetterGenerator*/
public static T ActionButtons<T>(this T control, Func<System.Collections.ObjectModel.ObservableCollection<System.Object>> func, Action<System.Collections.ObjectModel.ObservableCollection<System.Object>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ActionButtonsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ActionButtons<T>(this T control,System.Collections.ObjectModel.ObservableCollection<System.Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.ActionButtonsProperty, ps, () => control.ActionButtons = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ActionButtons<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ActionButtonsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ActionButtons<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiDialog 
   => control._set(SukiUI.Controls.SukiDialog.ActionButtonsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ActionButtons<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.ObjectModel.ObservableCollection<System.Object>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiDialog 
=> control._setEx(SukiUI.Controls.SukiDialog.ActionButtonsProperty, ps, () => control.ActionButtons = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // ViewModel

/*ValueStyleSetterGenerator*/
public static Style<T> ViewModel<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.ViewModelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewModel<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.ViewModelProperty, binding);


 // Title

/*ValueStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.TitleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.TitleProperty, binding);


 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.ContentProperty, binding);


 // IsViewModelOnly

/*ValueStyleSetterGenerator*/
public static Style<T> IsViewModelOnly<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.IsViewModelOnlyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsViewModelOnly<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.IsViewModelOnlyProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.IconProperty, binding);


 // ShowCardBackground

/*ValueStyleSetterGenerator*/
public static Style<T> ShowCardBackground<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.ShowCardBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowCardBackground<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.ShowCardBackgroundProperty, binding);


 // IconColor

/*ValueStyleSetterGenerator*/
public static Style<T> IconColor<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.IconColorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IconColor<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.IconColorProperty, binding);


 // ActionButtons

/*ValueStyleSetterGenerator*/
public static Style<T> ActionButtons<T>(this Style<T> style, System.Collections.ObjectModel.ObservableCollection<System.Object> value) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.ActionButtonsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ActionButtons<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiDialog 
=> style._addSetter(SukiUI.Controls.SukiDialog.ActionButtonsProperty, binding);



}
