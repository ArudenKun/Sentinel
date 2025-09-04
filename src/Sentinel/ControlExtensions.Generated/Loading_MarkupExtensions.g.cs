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
public static partial class Loading_MarkupExtensions
{
//================= Properties ======================//
 // LoadingStyle

/*ValueSetterGenerator*/
public static T LoadingStyle<T>(this T control, SukiUI.Controls.LoadingStyle value) where T : SukiUI.Controls.Loading 
=> control._set(() => control.LoadingStyle = value!);

/*BindFromExpressionSetterGenerator*/
public static T LoadingStyle<T>(this T control, Func<SukiUI.Controls.LoadingStyle> func, Action<SukiUI.Controls.LoadingStyle>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Loading 
   => control._set(SukiUI.Controls.Loading.LoadingStyleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LoadingStyle<T>(this T control,SukiUI.Controls.LoadingStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Loading 
=> control._setEx(SukiUI.Controls.Loading.LoadingStyleProperty, ps, () => control.LoadingStyle = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LoadingStyle<T>(this T control, IBinding binding) where T : SukiUI.Controls.Loading 
   => control._set(SukiUI.Controls.Loading.LoadingStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LoadingStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Loading 
   => control._set(SukiUI.Controls.Loading.LoadingStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LoadingStyle<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Controls.LoadingStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Loading 
=> control._setEx(SukiUI.Controls.Loading.LoadingStyleProperty, ps, () => control.LoadingStyle = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Foreground

/*ValueSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value) where T : SukiUI.Controls.Loading 
=> control._set(() => control.Foreground = value!);

/*BindFromExpressionSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Loading 
   => control._set(SukiUI.Controls.Loading.ForegroundProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Foreground<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Loading 
=> control._setEx(SukiUI.Controls.Loading.ForegroundProperty, ps, () => control.Foreground = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Foreground<T>(this T control, IBinding binding) where T : SukiUI.Controls.Loading 
   => control._set(SukiUI.Controls.Loading.ForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Loading 
   => control._set(SukiUI.Controls.Loading.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Foreground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Loading 
=> control._setEx(SukiUI.Controls.Loading.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // LoadingStyle

/*ValueStyleSetterGenerator*/
public static Style<T> LoadingStyle<T>(this Style<T> style, SukiUI.Controls.LoadingStyle value) where T : SukiUI.Controls.Loading 
=> style._addSetter(SukiUI.Controls.Loading.LoadingStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LoadingStyle<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Loading 
=> style._addSetter(SukiUI.Controls.Loading.LoadingStyleProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : SukiUI.Controls.Loading 
=> style._addSetter(SukiUI.Controls.Loading.ForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Loading 
=> style._addSetter(SukiUI.Controls.Loading.ForegroundProperty, binding);



}
