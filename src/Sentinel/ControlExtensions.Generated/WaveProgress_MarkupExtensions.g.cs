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
public static partial class WaveProgress_MarkupExtensions
{
//================= Properties ======================//
 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Double value) where T : SukiUI.Controls.WaveProgress 
=> control._set(() => control.Value = value!);

/*BindFromExpressionSetterGenerator*/
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.WaveProgress 
   => control._set(SukiUI.Controls.WaveProgress.ValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Value<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.WaveProgress 
=> control._setEx(SukiUI.Controls.WaveProgress.ValueProperty, ps, () => control.Value = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Value<T>(this T control, IBinding binding) where T : SukiUI.Controls.WaveProgress 
   => control._set(SukiUI.Controls.WaveProgress.ValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.WaveProgress 
   => control._set(SukiUI.Controls.WaveProgress.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Value<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.WaveProgress 
=> control._setEx(SukiUI.Controls.WaveProgress.ValueProperty, ps, () => control.Value = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsTextVisible

/*ValueSetterGenerator*/
public static T IsTextVisible<T>(this T control, System.Boolean value) where T : SukiUI.Controls.WaveProgress 
=> control._set(() => control.IsTextVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsTextVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.WaveProgress 
   => control._set(SukiUI.Controls.WaveProgress.IsTextVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsTextVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.WaveProgress 
=> control._setEx(SukiUI.Controls.WaveProgress.IsTextVisibleProperty, ps, () => control.IsTextVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTextVisible<T>(this T control, IBinding binding) where T : SukiUI.Controls.WaveProgress 
   => control._set(SukiUI.Controls.WaveProgress.IsTextVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTextVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.WaveProgress 
   => control._set(SukiUI.Controls.WaveProgress.IsTextVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsTextVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.WaveProgress 
=> control._setEx(SukiUI.Controls.WaveProgress.IsTextVisibleProperty, ps, () => control.IsTextVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.WaveProgress 
=> style._addSetter(SukiUI.Controls.WaveProgress.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.WaveProgress 
=> style._addSetter(SukiUI.Controls.WaveProgress.ValueProperty, binding);


 // IsTextVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsTextVisible<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.WaveProgress 
=> style._addSetter(SukiUI.Controls.WaveProgress.IsTextVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTextVisible<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.WaveProgress 
=> style._addSetter(SukiUI.Controls.WaveProgress.IsTextVisibleProperty, binding);



}
