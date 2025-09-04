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
public static partial class BusyArea_MarkupExtensions
{
//================= Properties ======================//
 // IsBusy

/*ValueSetterGenerator*/
public static T IsBusy<T>(this T control, System.Boolean value) where T : SukiUI.Controls.BusyArea 
=> control._set(() => control.IsBusy = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsBusy<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.BusyArea 
   => control._set(SukiUI.Controls.BusyArea.IsBusyProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsBusy<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.BusyArea 
=> control._setEx(SukiUI.Controls.BusyArea.IsBusyProperty, ps, () => control.IsBusy = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsBusy<T>(this T control, IBinding binding) where T : SukiUI.Controls.BusyArea 
   => control._set(SukiUI.Controls.BusyArea.IsBusyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsBusy<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.BusyArea 
   => control._set(SukiUI.Controls.BusyArea.IsBusyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsBusy<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.BusyArea 
=> control._setEx(SukiUI.Controls.BusyArea.IsBusyProperty, ps, () => control.IsBusy = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BusyText

/*ValueSetterGenerator*/
public static T BusyText<T>(this T control, System.String value) where T : SukiUI.Controls.BusyArea 
=> control._set(() => control.BusyText = value!);

/*BindFromExpressionSetterGenerator*/
public static T BusyText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.BusyArea 
   => control._set(SukiUI.Controls.BusyArea.BusyTextProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BusyText<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.BusyArea 
=> control._setEx(SukiUI.Controls.BusyArea.BusyTextProperty, ps, () => control.BusyText = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BusyText<T>(this T control, IBinding binding) where T : SukiUI.Controls.BusyArea 
   => control._set(SukiUI.Controls.BusyArea.BusyTextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BusyText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.BusyArea 
   => control._set(SukiUI.Controls.BusyArea.BusyTextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BusyText<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.BusyArea 
=> control._setEx(SukiUI.Controls.BusyArea.BusyTextProperty, ps, () => control.BusyText = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IsBusy

/*ValueStyleSetterGenerator*/
public static Style<T> IsBusy<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.BusyArea 
=> style._addSetter(SukiUI.Controls.BusyArea.IsBusyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsBusy<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.BusyArea 
=> style._addSetter(SukiUI.Controls.BusyArea.IsBusyProperty, binding);


 // BusyText

/*ValueStyleSetterGenerator*/
public static Style<T> BusyText<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.BusyArea 
=> style._addSetter(SukiUI.Controls.BusyArea.BusyTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BusyText<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.BusyArea 
=> style._addSetter(SukiUI.Controls.BusyArea.BusyTextProperty, binding);



}
