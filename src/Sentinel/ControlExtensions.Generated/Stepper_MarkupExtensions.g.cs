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
public static partial class Stepper_MarkupExtensions
{
//================= Properties ======================//
 // AlternativeStyle

/*ValueSetterGenerator*/
public static T AlternativeStyle<T>(this T control, System.Boolean value) where T : SukiUI.Controls.Stepper 
=> control._set(() => control.AlternativeStyle = value!);

/*BindFromExpressionSetterGenerator*/
public static T AlternativeStyle<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Stepper 
   => control._set(SukiUI.Controls.Stepper.AlternativeStyleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AlternativeStyle<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Stepper 
=> control._setEx(SukiUI.Controls.Stepper.AlternativeStyleProperty, ps, () => control.AlternativeStyle = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AlternativeStyle<T>(this T control, IBinding binding) where T : SukiUI.Controls.Stepper 
   => control._set(SukiUI.Controls.Stepper.AlternativeStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AlternativeStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Stepper 
   => control._set(SukiUI.Controls.Stepper.AlternativeStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AlternativeStyle<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Stepper 
=> control._setEx(SukiUI.Controls.Stepper.AlternativeStyleProperty, ps, () => control.AlternativeStyle = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Index

/*ValueSetterGenerator*/
public static T Index<T>(this T control, System.Int32 value) where T : SukiUI.Controls.Stepper 
=> control._set(() => control.Index = value!);

/*BindFromExpressionSetterGenerator*/
public static T Index<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Stepper 
   => control._set(SukiUI.Controls.Stepper.IndexProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Index<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Stepper 
=> control._setEx(SukiUI.Controls.Stepper.IndexProperty, ps, () => control.Index = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Index<T>(this T control, IBinding binding) where T : SukiUI.Controls.Stepper 
   => control._set(SukiUI.Controls.Stepper.IndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Index<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Stepper 
   => control._set(SukiUI.Controls.Stepper.IndexProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Index<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Stepper 
=> control._setEx(SukiUI.Controls.Stepper.IndexProperty, ps, () => control.Index = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Steps

/*ValueSetterGenerator*/
public static T Steps<T>(this T control, System.Collections.IEnumerable value) where T : SukiUI.Controls.Stepper 
=> control._set(() => control.Steps = value!);

/*BindFromExpressionSetterGenerator*/
public static T Steps<T>(this T control, Func<System.Collections.IEnumerable> func, Action<System.Collections.IEnumerable>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.Stepper 
   => control._set(SukiUI.Controls.Stepper.StepsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Steps<T>(this T control,System.Collections.IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Stepper 
=> control._setEx(SukiUI.Controls.Stepper.StepsProperty, ps, () => control.Steps = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Steps<T>(this T control, IBinding binding) where T : SukiUI.Controls.Stepper 
   => control._set(SukiUI.Controls.Stepper.StepsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Steps<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.Stepper 
   => control._set(SukiUI.Controls.Stepper.StepsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Steps<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.Stepper 
=> control._setEx(SukiUI.Controls.Stepper.StepsProperty, ps, () => control.Steps = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // AlternativeStyle

/*ValueStyleSetterGenerator*/
public static Style<T> AlternativeStyle<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.Stepper 
=> style._addSetter(SukiUI.Controls.Stepper.AlternativeStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AlternativeStyle<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Stepper 
=> style._addSetter(SukiUI.Controls.Stepper.AlternativeStyleProperty, binding);


 // Index

/*ValueStyleSetterGenerator*/
public static Style<T> Index<T>(this Style<T> style, System.Int32 value) where T : SukiUI.Controls.Stepper 
=> style._addSetter(SukiUI.Controls.Stepper.IndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Index<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Stepper 
=> style._addSetter(SukiUI.Controls.Stepper.IndexProperty, binding);


 // Steps

/*ValueStyleSetterGenerator*/
public static Style<T> Steps<T>(this Style<T> style, System.Collections.IEnumerable value) where T : SukiUI.Controls.Stepper 
=> style._addSetter(SukiUI.Controls.Stepper.StepsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Steps<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.Stepper 
=> style._addSetter(SukiUI.Controls.Stepper.StepsProperty, binding);



}
